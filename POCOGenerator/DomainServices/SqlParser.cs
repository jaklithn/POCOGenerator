using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using POCOGenerator.Entities;


namespace POCOGenerator.DomainServices
{
	public class SqlParser
	{
		public List<ResultItem> ResultItems { get; private set; }

		public SqlParser(string connectionString, string sql)
		{
			// Parse possible entity names specified in the custom "AS" section
			var procedureEntityNames = string.Empty;
			var sqlUpper = sql.ToUpper().Trim();
			if (sqlUpper.StartsWith("EXEC"))
			{
				var posAs = sqlUpper.IndexOf(" AS ");
				if (posAs > 5)
				{
					procedureEntityNames = sql.Substring(posAs + 4);
					sql = sql.Substring(0, posAs);
				}
			}

			// Decorate table name with brackets
			var posFrom = sql.IndexOf(" FROM ");
			if (posFrom > 0)
			{
				var tableName = sql.Substring(posFrom + 6);
				tableName = tableName.Replace("[", "").Replace("]", "");
				var sections = tableName.Split(".".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				var decoratedTable = "[" + string.Join("].[", sections) + "]";
				sql = sql.Substring(0, posFrom + 6) + decoratedTable;
			}

			ParseTables(connectionString, sql, procedureEntityNames);
			ParseColumns();
			GenerateCode();
		}

		public static List<string> GetTableNames(string connectionString)
		{
			using (var con = new SqlConnection(connectionString))
			{
				con.Open();
				var tables = new List<string>();
				var dt = con.GetSchema("Tables");
				foreach (DataRow row in dt.Rows)
				{
					var database = row[0].ToString();
					var schema = row[1].ToString();
					var name = row[2].ToString();
					var type = row[3].ToString();
					Debug.WriteLine("{0}, {1}, {2}, {3}", database, schema, name, type);

					if (type == "BASE TABLE" && name != "sysdiagrams")
					{
						var tableSpecifier = schema == "dbo" ? name : string.Format("{0}.{1}", schema, name);
						tables.Add(tableSpecifier);
					}
				}
				return tables.OrderBy(t => t).ToList();
			}
		}

		private void ParseTables(string connectionString, string sql, string procedureEntityNames)
		{
			using (var con = new SqlConnection(connectionString))
			{
				con.Open();
				using (var cmd = new SqlCommand())
				{
					cmd.Connection = con;
					cmd.CommandType = GetCommandType(sql);
					cmd.CommandText = GetCommandText(cmd.CommandType, sql);
					cmd.CommandTimeout = 60;
					if (cmd.CommandType == CommandType.StoredProcedure)
						cmd.Parameters.AddRange(GetParameters(sql));

					ResultItems = new List<ResultItem>();

					// Retrieve data
					var content = new DataSet();
					using (var adapter = new SqlDataAdapter(cmd))
					{
						adapter.Fill(content);
					}

					// Loop through data tables and datareader in parallell adding data+schema
					using (var dr = cmd.ExecuteReader(CommandBehavior.Default))
					{
						for (var i = 0; i < content.Tables.Count; i++)
						{
							var table = content.Tables[i];
							var resultItem = new ResultItem { SchemaTable = dr.GetSchemaTable(), DataTable = table, EntityName = GetEntityName(sql, i, table.TableName, procedureEntityNames) };
							ResultItems.Add(resultItem);
							dr.NextResult();
						}
					}
				}
			}
		}

		private void ParseColumns()
		{
			foreach (var resultItem in ResultItems)
			{
				resultItem.SqlColumns = new List<SqlColumn>();

				var typeProperties = new[] { "DataType", "ProviderSpecificDataType" };
				var missingProperties = new HashSet<string>();

				for (var rowIndex = 0; rowIndex < resultItem.SchemaTable.Rows.Count; rowIndex++)
				{
					var sqlColumn = new SqlColumn();
					for (var columnIndex = 0; columnIndex < resultItem.SchemaTable.Columns.Count; columnIndex++)
					{
						var propertyName = resultItem.SchemaTable.Columns[columnIndex].ColumnName;
						var value = resultItem.SchemaTable.Rows[rowIndex][columnIndex];

						if (typeProperties.Contains(propertyName))
						{
							value = ((Type)value).FullName;
						}

						var property = typeof(SqlColumn).GetProperty(propertyName);
						if (!Convert.IsDBNull(value) && property != null)
						{
							property.SetValue(sqlColumn, value, null);
						}
						else
						{
							missingProperties.Add(propertyName);
						}
					}

					// Adjust

					var decimalTypes = new[] { "real", "float", "decimal", "money", "smallmoney" };
					if (decimalTypes.Contains(sqlColumn.DataTypeName))
					{
						sqlColumn.NumericScale = 0;
						sqlColumn.NumericPrecision = 0;
					}
					resultItem.SqlColumns.Add(sqlColumn);
				}

				Debug.WriteLine(string.Format("MissingProperties: {0}", string.Join(", ", missingProperties)));
			}
		}

		private void GenerateCode()
		{
			foreach (var resultItem in ResultItems)
			{
				var sb = new StringBuilder();
				sb.AppendLine(string.Format("public class {0}", resultItem.EntityName));
				sb.AppendLine("{");

				foreach (var sqlColumn in resultItem.SqlColumns)
				{
					sb.AppendLine($"    public {GetNullableDataType(sqlColumn)} {sqlColumn.ColumnName} {{ get; set; }}");
				}

				sb.AppendLine("}");
				sb.AppendLine("");

				resultItem.Code = sb.ToString();
			}
		}

		private static string GetNullableDataType(SqlColumn sqlColumn)
		{
			var dataType = GetDataType(sqlColumn);
			var addNullability = sqlColumn.AllowDBNull && dataType != "string";
			return addNullability ? dataType + "?" : dataType;
		}

		private static string GetDataType(SqlColumn sqlColumn)
		{
			switch (sqlColumn.DataTypeName)
			{
				case "bit":
					return "bool";

				case "tinyint":
					return "byte";
				case "smallint":
					return "short";
				case "int":
					return "int";
				case "bigint":
					return "long";

				case "real":
					return "float";
				case "float":
					return "double";
				case "decimal":
				case "money":
				case "smallmoney":
					return "decimal";

				case "time":
					return "TimeSpan";
				case "date":
				case "datetime":
				case "datetime2":
				case "smalldatetime":
					return "DateTime";
				case "datetimeoffset":
					return "DateTimeOffset";

				case "char":
				case "varchar":
				case "nchar":
				case "nvarchar":
				case "text":
				case "ntext":
				case "xml":
					return "string";

				case "binary":
				case "image":
				case "varbinary":
				case "timestamp":
					return "byte[]";

				case "uniqueidentifier":
					return "Guid";

				case "variant":
				case "Udt":
					return "object";

				case "Structured":
					return "DataTable";

				case "geography":
					return "geography";

				default:
					// Fallback to be manually handled by user
					return sqlColumn.DataTypeName;
			}
		}

		private static string GetCommandText(CommandType commandType, string sql)
		{
			switch (commandType)
			{
				case CommandType.Text:
					return sql;

				case CommandType.StoredProcedure:
					var sections = sql.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
					if (sections.Count() > 2 && sections[0].ToUpper() == "EXEC")
						return sections[1];
					throw new Exception("Could not parse Name of StoredProcedure");

				default:
					throw new Exception(string.Format("CommandType={0} is not handled", commandType));
			}
		}

		private static CommandType GetCommandType(string sql)
		{
			return sql.ToUpper().Trim().StartsWith("SELECT") ? CommandType.Text : CommandType.StoredProcedure;
		}

		private static string GetEntityName(string sql, int index, string tableName, string procedureEntityNames)
		{
			var commandType = GetCommandType(sql);
			switch (commandType)
			{
				case CommandType.Text:
					var sections = sql.Split("[] ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
					return sections[sections.Length - 1];

				case CommandType.StoredProcedure:
					if (!string.IsNullOrEmpty(procedureEntityNames))
					{
						var names = procedureEntityNames.Split(",. ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
						if (index < names.Length)
							return names[index];
					}
					break;
			}
			return tableName;
		}

		private static SqlParameter[] GetParameters(string sql)
		{
			var parameters = new List<SqlParameter>();
			var pos = sql.IndexOf('@');
			if (pos > 0)
			{
				sql = sql.Substring(pos);
				var pairs = sql.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				foreach (var pair in pairs)
				{
					var values = pair.Split("= ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
					parameters.Add(new SqlParameter(values[0], values[1]));
				}
			}
			return parameters.ToArray();
		}

	}
}
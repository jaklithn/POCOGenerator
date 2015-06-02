using System.Collections.Generic;
using System.Data;


namespace POCOGenerator.Entities
{
	public class ResultItem
	{
		public string EntityName { get; set; }
		public DataTable SchemaTable { get; set; }
		public DataTable DataTable { get; set; }
		public List<SqlColumn> SqlColumns { get; set; }
		public string Code { get; set; }
	}
}
namespace POCOGenerator.Entities
{
	public class SqlColumn
	{
		public string ColumnName { get; set; }
		public string BaseColumnName { get; set; }
		public string BaseTableName { get; set; }
		public string DataType { get; set; }
		public string ProviderSpecificDataType { get; set; }
		public string DataTypeName { get; set; }

		public int ColumnOrdinal { get; set; }
		public int ColumnSize { get; set; }
		public int NumericPrecision { get; set; }
		public int NumericScale { get; set; }

		public int ProviderType { get; set; }
		public int NonVersionedProviderType { get; set; }

		public bool IsUnique { get; set; }
		public bool IsColumnSet { get; set; }
		public bool AllowDBNull { get; set; }
		public bool IsKey { get; set; }
		public bool IsIdentity { get; set; }
		public bool IsAutoIncrement { get; set; }
		public bool IsRowVersion { get; set; }
		public bool IsLong { get; set; }
		public bool IsReadOnly { get; set; }

	}
}
using System.Data.SqlClient;


namespace POCOGenerator.Entities
{
	public class ConnectionItem
	{
		public string ConnectionString { get; set; }
		public string DisplayName
		{
			get
			{
				var builder = new SqlConnectionStringBuilder(ConnectionString);
				return string.Format("{0} [{1}]", builder.InitialCatalog.PadRight(25),builder.DataSource);
			}
		}

	}
}
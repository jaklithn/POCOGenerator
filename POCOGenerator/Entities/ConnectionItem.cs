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
				return $"{builder.InitialCatalog}    [{builder.DataSource}]";
			}
		}

		public ConnectionItem(string connectionString)
		{
			ConnectionString = connectionString;
		}
	}
}
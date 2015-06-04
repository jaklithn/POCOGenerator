using System.ComponentModel;


namespace POCOGenerator.Entities
{
	public class Settings
	{
		public BindingList<ConnectionItem> ConnectionStrings { get; set; }
		public string SelectedConnection { get; set; }
		public string SqlView { get; set; }
		public string SqlProcedure { get; set; }

		public Settings()
		{
			ConnectionStrings = new BindingList<ConnectionItem>();
			SelectedConnection = null;
			SqlView = "SELECT * FROM ViewName";
			SqlProcedure = "EXEC StoredProcedure @parameter1=value1, @parameter2=value2, ... [AS Result1, Result2, ...]";
		}
	}
}
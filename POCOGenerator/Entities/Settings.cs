using System.Collections.Generic;


namespace POCOGenerator.Entities
{
	public class Settings
	{
		public List<string> ConnectionStrings { get; set; }
		public string SelectedConnection { get; set; }
		public string SqlView { get; set; }
		public string SqlProcedure { get; set; }

		public Settings()
		{
			ConnectionStrings = new List<string>();
			SelectedConnection = null;
			SqlView = "SELECT * FROM ViewName";
			SqlProcedure = "EXEC StoredProcedure @parameter1=value1, @parameter2=value2, ... [AS Result1, Result2, ...]";
		}
	}
}
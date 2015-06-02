using System;
using System.Windows.Forms;
using POCOGenerator.Controls;
using POCOGenerator.DomainServices;
using POCOGenerator.Properties;


namespace POCOGenerator
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			tabResult.TabPages.Clear();
		}


		private void LoadTables()
		{
			cboTableName.DataSource = SqlParser.GetTableNames(txtConnectionString.Text);
		}

		private void Generate(string sql)
		{
			try
			{
				Cursor = Cursors.WaitCursor;

				var adoHandler = new SqlParser(txtConnectionString.Text, sql);
				resultItemBindingSource.DataSource = adoHandler.ResultItems;

				tabResult.TabPages.Clear();
				foreach (var resultItem in adoHandler.ResultItems)
				{
					var tabPage = new TabPage { Text = resultItem.EntityName, Margin = new Padding(0) };
					tabResult.TabPages.Add(tabPage);

					var content = new ResultContent { Dock = DockStyle.Fill };
					content.Initiate(resultItem);
					tabPage.Controls.Add(content);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("GenerateClass", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}
		
		private void AdjustSql()
		{
			var sql = txtSqlView.Text.Trim();
			txtSqlView.Text = sql.Replace("SELECT *", "SELECT TOP 10 *");
		}

		private void GetSettings()
		{
			txtConnectionString.Text = Settings.Default.ConnectionString;
			txtSqlView.Text = Settings.Default.SQLView;
			txtSqlProcedure.Text = Settings.Default.SQLProcedure;

			if (Environment.UserName == "jal")
			{
				txtSqlProcedure.Text = "EXEC usp_ExtExportGetTasks @ServerId=0, @ExternalSystemId=2, @MaxProcessingTimeInMinutes=5  AS Task, Customer, Activity, Helper";
			}
		}

		private void SaveSettings()
		{
			Settings.Default.ConnectionString = txtConnectionString.Text;
			Settings.Default.SQLView = txtSqlView.Text;
			Settings.Default.SQLProcedure = txtSqlProcedure.Text;
			Settings.Default.Save();
		}

		//private void SetShowState()
		//{
		//	var isText = optText.Checked;
		//	var isProcedure = optStoredProcedure.Checked;
		//	txtSqlText.Visible = isText;
		//	txtSqlProcedure.Visible = isProcedure;
		//	lblEntityName.Visible = isProcedure;
		//	txtEntityNames.Visible = isProcedure;
		//}

		#region Event Handlers

		private void Main_Load(object sender, EventArgs e)
		{
			GetSettings();
		}

		private void btnParseTables_Click(object sender, EventArgs e)
		{
			LoadTables();
		}

		private void btnGenerateTable_Click(object sender, EventArgs e)
		{
			var sql = string.Format("SELECT * FROM [{0}]", cboTableName.Text);
			SaveSettings();
			Generate(sql);
		}

		private void btnGenerateView_Click(object sender, EventArgs e)
		{
			SaveSettings();
			AdjustSql();
			Generate(txtSqlView.Text);
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			SaveSettings();
			Generate(txtSqlProcedure.Text);
		}

		#endregion
	}
}
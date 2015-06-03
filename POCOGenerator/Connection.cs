using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace POCOGenerator
{
	public partial class Connection : Form
	{
		public Connection()
		{
			InitializeComponent();
		}

		public string ConnectionString
		{
			get { return txtConnectionString.Text; }
			set { txtConnectionString.Text = value; }
		}

		public string DisplayName
		{
			get
			{
				var builder = new SqlConnectionStringBuilder(ConnectionString);
				return string.Format("{0} - {1}", builder.DataSource, builder.InitialCatalog);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				using (var con = new SqlConnection(txtConnectionString.Text))
				{
					con.Open();
				}
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to validate connection string", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
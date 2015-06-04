using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using POCOGenerator.Extenders;


namespace POCOGenerator
{
	public partial class Connection : Form
	{
		public Connection()
		{
			InitializeComponent();
		}


		#region  Properties

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

		#endregion


		#region Event Handlers

		private void Connection_Load(object sender, EventArgs e)
		{
			if (txtConnectionString.Text.IsNullOrEmpty())
			{
				txtConnectionString.Text = "Server=localhost; Database=; Trusted_Connection=True; User ID=; Password=;";
			}
		}

		private void Connection_Activated(object sender, EventArgs e)
		{
			btnCancel.Focus();
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

		#endregion
	}
}
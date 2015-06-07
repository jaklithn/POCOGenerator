using System.Windows.Forms;
using POCOGenerator.Entities;


namespace POCOGenerator.Controls
{
	public partial class ResultContent : UserControl
	{
		public ResultContent()
		{
			InitializeComponent();
		}

		public void Initiate(ResultItem resultItem)
		{
			sqlColumnBindingSource.DataSource = resultItem.SqlColumns;
			grdData.DataSource = resultItem.DataTable;
			txtCode.Text = resultItem.Code;
		}

		private void txtCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				txtCode.SelectAll();
			}
		}

		private void grdData_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			// There might be errors when a column has binary data.
			// This often happens for MigrationTables.
			// For this purpose we can safely suppress the errors.
			e.Cancel=true;
		}
	}
}
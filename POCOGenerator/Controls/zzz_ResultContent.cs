using System.Windows.Forms;
using POCOGenerator.Entities;


namespace POCOGenerator.Controls
{
	public partial class zzz_ResultContent : UserControl
	{
		public zzz_ResultContent()
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
	}
}
namespace POCOGenerator
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.lblConnectionString = new System.Windows.Forms.Label();
			this.txtConnectionString = new System.Windows.Forms.TextBox();
			this.txtSqlView = new System.Windows.Forms.TextBox();
			this.btnGenerateProc = new System.Windows.Forms.Button();
			this.tabResult = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtSqlProcedure = new System.Windows.Forms.TextBox();
			this.btnGenerateTable = new System.Windows.Forms.Button();
			this.btnGenerateView = new System.Windows.Forms.Button();
			this.cboTableName = new System.Windows.Forms.ComboBox();
			this.btnParseTables = new System.Windows.Forms.Button();
			this.sqlColumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.resultItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabResult.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sqlColumnBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resultItemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblConnectionString
			// 
			this.lblConnectionString.AutoSize = true;
			this.lblConnectionString.Location = new System.Drawing.Point(14, 9);
			this.lblConnectionString.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblConnectionString.Name = "lblConnectionString";
			this.lblConnectionString.Size = new System.Drawing.Size(91, 13);
			this.lblConnectionString.TabIndex = 5;
			this.lblConnectionString.Text = "Connection String";
			// 
			// txtConnectionString
			// 
			this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConnectionString.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.txtConnectionString.ForeColor = System.Drawing.Color.Navy;
			this.txtConnectionString.Location = new System.Drawing.Point(12, 27);
			this.txtConnectionString.Margin = new System.Windows.Forms.Padding(2);
			this.txtConnectionString.Multiline = true;
			this.txtConnectionString.Name = "txtConnectionString";
			this.txtConnectionString.Size = new System.Drawing.Size(1248, 52);
			this.txtConnectionString.TabIndex = 6;
			// 
			// txtSqlView
			// 
			this.txtSqlView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSqlView.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.txtSqlView.ForeColor = System.Drawing.Color.Navy;
			this.txtSqlView.Location = new System.Drawing.Point(17, 117);
			this.txtSqlView.Margin = new System.Windows.Forms.Padding(2);
			this.txtSqlView.Multiline = true;
			this.txtSqlView.Name = "txtSqlView";
			this.txtSqlView.Size = new System.Drawing.Size(1092, 24);
			this.txtSqlView.TabIndex = 18;
			// 
			// btnGenerateProc
			// 
			this.btnGenerateProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerateProc.Location = new System.Drawing.Point(1113, 145);
			this.btnGenerateProc.Margin = new System.Windows.Forms.Padding(2);
			this.btnGenerateProc.Name = "btnGenerateProc";
			this.btnGenerateProc.Size = new System.Drawing.Size(147, 24);
			this.btnGenerateProc.TabIndex = 23;
			this.btnGenerateProc.Text = "Generate from Procedure";
			this.btnGenerateProc.UseVisualStyleBackColor = true;
			this.btnGenerateProc.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// tabResult
			// 
			this.tabResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabResult.Controls.Add(this.tabPage1);
			this.tabResult.Controls.Add(this.tabPage2);
			this.tabResult.Location = new System.Drawing.Point(11, 174);
			this.tabResult.Name = "tabResult";
			this.tabResult.Padding = new System.Drawing.Point(20, 4);
			this.tabResult.SelectedIndex = 0;
			this.tabResult.Size = new System.Drawing.Size(1249, 595);
			this.tabResult.TabIndex = 28;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1241, 567);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1241, 567);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtSqlProcedure
			// 
			this.txtSqlProcedure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSqlProcedure.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.txtSqlProcedure.ForeColor = System.Drawing.Color.Navy;
			this.txtSqlProcedure.Location = new System.Drawing.Point(17, 145);
			this.txtSqlProcedure.Margin = new System.Windows.Forms.Padding(2);
			this.txtSqlProcedure.Multiline = true;
			this.txtSqlProcedure.Name = "txtSqlProcedure";
			this.txtSqlProcedure.Size = new System.Drawing.Size(1092, 24);
			this.txtSqlProcedure.TabIndex = 31;
			// 
			// btnGenerateTable
			// 
			this.btnGenerateTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerateTable.Location = new System.Drawing.Point(1113, 88);
			this.btnGenerateTable.Margin = new System.Windows.Forms.Padding(2);
			this.btnGenerateTable.Name = "btnGenerateTable";
			this.btnGenerateTable.Size = new System.Drawing.Size(147, 24);
			this.btnGenerateTable.TabIndex = 32;
			this.btnGenerateTable.Text = "Generate from Table";
			this.btnGenerateTable.UseVisualStyleBackColor = true;
			this.btnGenerateTable.Click += new System.EventHandler(this.btnGenerateTable_Click);
			// 
			// btnGenerateView
			// 
			this.btnGenerateView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerateView.Location = new System.Drawing.Point(1113, 117);
			this.btnGenerateView.Margin = new System.Windows.Forms.Padding(2);
			this.btnGenerateView.Name = "btnGenerateView";
			this.btnGenerateView.Size = new System.Drawing.Size(147, 24);
			this.btnGenerateView.TabIndex = 33;
			this.btnGenerateView.Text = "Generate from View";
			this.btnGenerateView.UseVisualStyleBackColor = true;
			this.btnGenerateView.Click += new System.EventHandler(this.btnGenerateView_Click);
			// 
			// cboTableName
			// 
			this.cboTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTableName.FormattingEnabled = true;
			this.cboTableName.Location = new System.Drawing.Point(871, 90);
			this.cboTableName.MaxDropDownItems = 50;
			this.cboTableName.Name = "cboTableName";
			this.cboTableName.Size = new System.Drawing.Size(238, 21);
			this.cboTableName.TabIndex = 34;
			// 
			// btnParseTables
			// 
			this.btnParseTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnParseTables.Location = new System.Drawing.Point(746, 89);
			this.btnParseTables.Margin = new System.Windows.Forms.Padding(2);
			this.btnParseTables.Name = "btnParseTables";
			this.btnParseTables.Size = new System.Drawing.Size(108, 23);
			this.btnParseTables.TabIndex = 35;
			this.btnParseTables.Text = "Parse Tables";
			this.btnParseTables.UseVisualStyleBackColor = true;
			this.btnParseTables.Click += new System.EventHandler(this.btnParseTables_Click);
			// 
			// sqlColumnBindingSource
			// 
			this.sqlColumnBindingSource.DataSource = typeof(POCOGenerator.Entities.SqlColumn);
			// 
			// resultItemBindingSource
			// 
			this.resultItemBindingSource.DataSource = typeof(POCOGenerator.Entities.ResultItem);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1271, 780);
			this.Controls.Add(this.btnParseTables);
			this.Controls.Add(this.cboTableName);
			this.Controls.Add(this.btnGenerateView);
			this.Controls.Add(this.btnGenerateTable);
			this.Controls.Add(this.txtSqlProcedure);
			this.Controls.Add(this.btnGenerateProc);
			this.Controls.Add(this.tabResult);
			this.Controls.Add(this.txtSqlView);
			this.Controls.Add(this.lblConnectionString);
			this.Controls.Add(this.txtConnectionString);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Generate POCO class from SQL Server";
			this.Load += new System.EventHandler(this.Main_Load);
			this.tabResult.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sqlColumnBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resultItemBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label lblConnectionString;
		internal System.Windows.Forms.TextBox txtConnectionString;
		internal System.Windows.Forms.TextBox txtSqlView;
		internal System.Windows.Forms.Button btnGenerateProc;
		private System.Windows.Forms.BindingSource sqlColumnBindingSource;
		private System.Windows.Forms.BindingSource resultItemBindingSource;
		private System.Windows.Forms.TabControl tabResult;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		internal System.Windows.Forms.TextBox txtSqlProcedure;
		internal System.Windows.Forms.Button btnGenerateTable;
		internal System.Windows.Forms.Button btnGenerateView;
		private System.Windows.Forms.ComboBox cboTableName;
		internal System.Windows.Forms.Button btnParseTables;
	}
}


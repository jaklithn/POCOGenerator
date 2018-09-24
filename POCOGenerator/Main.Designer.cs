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
			this.txtSqlView = new System.Windows.Forms.TextBox();
			this.btnGenerateProc = new System.Windows.Forms.Button();
			this.tabResult = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.txtSqlProcedure = new System.Windows.Forms.TextBox();
			this.btnGenerateTable = new System.Windows.Forms.Button();
			this.btnGenerateView = new System.Windows.Forms.Button();
			this.cboTableName = new System.Windows.Forms.ComboBox();
			this.cboConnection = new System.Windows.Forms.ComboBox();
			this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblConnection = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.sqlColumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.resultItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lnkSource = new System.Windows.Forms.LinkLabel();
			this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tabResult.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sqlColumnBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.resultItemBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSqlView
			// 
			this.txtSqlView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSqlView.Font = new System.Drawing.Font("Courier New", 9.75F);
			this.txtSqlView.ForeColor = System.Drawing.Color.Navy;
			this.txtSqlView.Location = new System.Drawing.Point(19, 47);
			this.txtSqlView.Margin = new System.Windows.Forms.Padding(2);
			this.txtSqlView.Multiline = true;
			this.txtSqlView.Name = "txtSqlView";
			this.txtSqlView.Size = new System.Drawing.Size(1175, 24);
			this.txtSqlView.TabIndex = 18;
			// 
			// btnGenerateProc
			// 
			this.btnGenerateProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerateProc.Location = new System.Drawing.Point(1207, 81);
			this.btnGenerateProc.Margin = new System.Windows.Forms.Padding(2);
			this.btnGenerateProc.Name = "btnGenerateProc";
			this.btnGenerateProc.Size = new System.Drawing.Size(188, 24);
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
			this.tabResult.Location = new System.Drawing.Point(11, 128);
			this.tabResult.Name = "tabResult";
			this.tabResult.Padding = new System.Drawing.Point(20, 4);
			this.tabResult.SelectedIndex = 0;
			this.tabResult.Size = new System.Drawing.Size(1384, 624);
			this.tabResult.TabIndex = 28;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1376, 596);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1376, 596);
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
			this.txtSqlProcedure.Location = new System.Drawing.Point(19, 81);
			this.txtSqlProcedure.Margin = new System.Windows.Forms.Padding(2);
			this.txtSqlProcedure.Multiline = true;
			this.txtSqlProcedure.Name = "txtSqlProcedure";
			this.txtSqlProcedure.Size = new System.Drawing.Size(1175, 24);
			this.txtSqlProcedure.TabIndex = 31;
			// 
			// btnGenerateTable
			// 
			this.btnGenerateTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerateTable.Location = new System.Drawing.Point(1207, 14);
			this.btnGenerateTable.Margin = new System.Windows.Forms.Padding(2);
			this.btnGenerateTable.Name = "btnGenerateTable";
			this.btnGenerateTable.Size = new System.Drawing.Size(188, 24);
			this.btnGenerateTable.TabIndex = 32;
			this.btnGenerateTable.Text = "Generate from Table";
			this.btnGenerateTable.UseVisualStyleBackColor = true;
			this.btnGenerateTable.Click += new System.EventHandler(this.btnGenerateTable_Click);
			// 
			// btnGenerateView
			// 
			this.btnGenerateView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGenerateView.Location = new System.Drawing.Point(1207, 47);
			this.btnGenerateView.Margin = new System.Windows.Forms.Padding(2);
			this.btnGenerateView.Name = "btnGenerateView";
			this.btnGenerateView.Size = new System.Drawing.Size(188, 24);
			this.btnGenerateView.TabIndex = 33;
			this.btnGenerateView.Text = "Generate from View";
			this.btnGenerateView.UseVisualStyleBackColor = true;
			this.btnGenerateView.Click += new System.EventHandler(this.btnGenerateView_Click);
			// 
			// cboTableName
			// 
			this.cboTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cboTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cboTableName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cboTableName.FormattingEnabled = true;
			this.cboTableName.Location = new System.Drawing.Point(966, 16);
			this.cboTableName.MaxDropDownItems = 50;
			this.cboTableName.Name = "cboTableName";
			this.cboTableName.Size = new System.Drawing.Size(228, 21);
			this.cboTableName.TabIndex = 34;
			// 
			// cboConnection
			// 
			this.cboConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cboConnection.DataSource = this.connectionBindingSource;
			this.cboConnection.DisplayMember = "DisplayName";
			this.cboConnection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cboConnection.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cboConnection.Location = new System.Drawing.Point(114, 16);
			this.cboConnection.Name = "cboConnection";
			this.cboConnection.Size = new System.Drawing.Size(550, 21);
			this.cboConnection.TabIndex = 36;
			this.cboConnection.ValueMember = "ConnectionString";
			// 
			// connectionBindingSource
			// 
			this.connectionBindingSource.DataSource = typeof(POCOGenerator.Entities.ConnectionItem);
			this.connectionBindingSource.CurrentChanged += new System.EventHandler(this.connectionBindingSource_CurrentChanged);
			// 
			// lblConnection
			// 
			this.lblConnection.AutoSize = true;
			this.lblConnection.Location = new System.Drawing.Point(16, 20);
			this.lblConnection.Name = "lblConnection";
			this.lblConnection.Size = new System.Drawing.Size(92, 13);
			this.lblConnection.TabIndex = 37;
			this.lblConnection.Text = "Connection string:";
			this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(678, 14);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(60, 24);
			this.btnAdd.TabIndex = 38;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Location = new System.Drawing.Point(742, 14);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(60, 24);
			this.btnEdit.TabIndex = 39;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRemove.Location = new System.Drawing.Point(806, 14);
			this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(60, 24);
			this.btnRemove.TabIndex = 40;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// sqlColumnBindingSource
			// 
			this.sqlColumnBindingSource.DataSource = typeof(POCOGenerator.Entities.SqlColumn);
			// 
			// resultItemBindingSource
			// 
			this.resultItemBindingSource.DataSource = typeof(POCOGenerator.Entities.ResultItem);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(894, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 41;
			this.label1.Text = "Table name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblVersion.ForeColor = System.Drawing.Color.Navy;
			this.lblVersion.Location = new System.Drawing.Point(11, 756);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(307, 21);
			this.lblVersion.TabIndex = 42;
			this.lblVersion.Text = "Version 1.0, Jakob Lithner";
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lnkSource
			// 
			this.lnkSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkSource.AutoSize = true;
			this.lnkSource.Location = new System.Drawing.Point(1248, 760);
			this.lnkSource.Name = "lnkSource";
			this.lnkSource.Size = new System.Drawing.Size(147, 13);
			this.lnkSource.TabIndex = 43;
			this.lnkSource.TabStop = true;
			this.lnkSource.Text = "OpenSource stored at GitHub";
			this.lnkSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.MyToolTip.SetToolTip(this.lnkSource, "Find source in GitHub repository");
			this.lnkSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSource_LinkClicked);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(1406, 780);
			this.Controls.Add(this.lnkSource);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.cboConnection);
			this.Controls.Add(this.lblConnection);
			this.Controls.Add(this.cboTableName);
			this.Controls.Add(this.btnGenerateView);
			this.Controls.Add(this.btnGenerateTable);
			this.Controls.Add(this.txtSqlProcedure);
			this.Controls.Add(this.btnGenerateProc);
			this.Controls.Add(this.tabResult);
			this.Controls.Add(this.txtSqlView);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Generate C# POCO class from SQL Server";
			this.Load += new System.EventHandler(this.Main_Load);
			this.tabResult.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sqlColumnBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.resultItemBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

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
		private System.Windows.Forms.ComboBox cboConnection;
		private System.Windows.Forms.Label lblConnection;
		internal System.Windows.Forms.Button btnAdd;
		internal System.Windows.Forms.Button btnEdit;
		internal System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.BindingSource connectionBindingSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.LinkLabel lnkSource;
		private System.Windows.Forms.ToolTip MyToolTip;
	}
}


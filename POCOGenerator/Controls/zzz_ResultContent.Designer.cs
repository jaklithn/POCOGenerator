namespace POCOGenerator.Controls
{
	partial class zzz_ResultContent
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.sqlColumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.txtCode = new System.Windows.Forms.TextBox();
			this.grdData = new System.Windows.Forms.DataGridView();
			this.flowTable = new System.Windows.Forms.TableLayoutPanel();
			this.isAutoIncrementDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isIdentityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.allowDBNullDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.numericPrecisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumericScale = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grdSchema = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.sqlColumnBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			this.flowTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdSchema)).BeginInit();
			this.SuspendLayout();
			// 
			// sqlColumnBindingSource
			// 
			this.sqlColumnBindingSource.DataSource = typeof(POCOGenerator.Entities.SqlColumn);
			// 
			// txtCode
			// 
			this.txtCode.BackColor = System.Drawing.Color.White;
			this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCode.ForeColor = System.Drawing.Color.Blue;
			this.txtCode.Location = new System.Drawing.Point(2, 433);
			this.txtCode.Margin = new System.Windows.Forms.Padding(2);
			this.txtCode.Multiline = true;
			this.txtCode.Name = "txtCode";
			this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCode.Size = new System.Drawing.Size(1294, 230);
			this.txtCode.TabIndex = 26;
			this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
			// 
			// grdData
			// 
			this.grdData.AllowUserToAddRows = false;
			this.grdData.AllowUserToDeleteRows = false;
			this.grdData.AllowUserToResizeRows = false;
			this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdData.Location = new System.Drawing.Point(3, 3);
			this.grdData.Name = "grdData";
			this.grdData.ReadOnly = true;
			this.grdData.RowHeadersWidth = 20;
			this.grdData.RowTemplate.Height = 18;
			this.grdData.Size = new System.Drawing.Size(1292, 226);
			this.grdData.TabIndex = 27;
			// 
			// flowTable
			// 
			this.flowTable.ColumnCount = 1;
			this.flowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.flowTable.Controls.Add(this.txtCode, 0, 2);
			this.flowTable.Controls.Add(this.grdData, 0, 0);
			this.flowTable.Controls.Add(this.grdSchema, 0, 1);
			this.flowTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowTable.Location = new System.Drawing.Point(0, 0);
			this.flowTable.Name = "flowTable";
			this.flowTable.RowCount = 3;
			this.flowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.flowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.flowTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.flowTable.Size = new System.Drawing.Size(1298, 665);
			this.flowTable.TabIndex = 28;
			// 
			// isAutoIncrementDataGridViewCheckBoxColumn
			// 
			this.isAutoIncrementDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.isAutoIncrementDataGridViewCheckBoxColumn.DataPropertyName = "IsAutoIncrement";
			this.isAutoIncrementDataGridViewCheckBoxColumn.FillWeight = 8F;
			this.isAutoIncrementDataGridViewCheckBoxColumn.HeaderText = "IsAutoIncrement";
			this.isAutoIncrementDataGridViewCheckBoxColumn.Name = "isAutoIncrementDataGridViewCheckBoxColumn";
			this.isAutoIncrementDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// isIdentityDataGridViewCheckBoxColumn
			// 
			this.isIdentityDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.isIdentityDataGridViewCheckBoxColumn.DataPropertyName = "IsIdentity";
			this.isIdentityDataGridViewCheckBoxColumn.FillWeight = 8F;
			this.isIdentityDataGridViewCheckBoxColumn.HeaderText = "IsIdentity";
			this.isIdentityDataGridViewCheckBoxColumn.Name = "isIdentityDataGridViewCheckBoxColumn";
			this.isIdentityDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// isKeyDataGridViewCheckBoxColumn
			// 
			this.isKeyDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.isKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsKey";
			this.isKeyDataGridViewCheckBoxColumn.FillWeight = 8F;
			this.isKeyDataGridViewCheckBoxColumn.HeaderText = "IsKey";
			this.isKeyDataGridViewCheckBoxColumn.Name = "isKeyDataGridViewCheckBoxColumn";
			this.isKeyDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// allowDBNullDataGridViewCheckBoxColumn
			// 
			this.allowDBNullDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.allowDBNullDataGridViewCheckBoxColumn.DataPropertyName = "AllowDBNull";
			this.allowDBNullDataGridViewCheckBoxColumn.FillWeight = 8F;
			this.allowDBNullDataGridViewCheckBoxColumn.HeaderText = "AllowDBNull";
			this.allowDBNullDataGridViewCheckBoxColumn.Name = "allowDBNullDataGridViewCheckBoxColumn";
			this.allowDBNullDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// numericPrecisionDataGridViewTextBoxColumn
			// 
			this.numericPrecisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.numericPrecisionDataGridViewTextBoxColumn.DataPropertyName = "NumericPrecision";
			this.numericPrecisionDataGridViewTextBoxColumn.FillWeight = 8F;
			this.numericPrecisionDataGridViewTextBoxColumn.HeaderText = "NumericPrecision";
			this.numericPrecisionDataGridViewTextBoxColumn.Name = "numericPrecisionDataGridViewTextBoxColumn";
			this.numericPrecisionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// NumericScale
			// 
			this.NumericScale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NumericScale.DataPropertyName = "NumericScale";
			this.NumericScale.FillWeight = 8F;
			this.NumericScale.HeaderText = "NumericScale";
			this.NumericScale.Name = "NumericScale";
			this.NumericScale.ReadOnly = true;
			// 
			// columnSizeDataGridViewTextBoxColumn
			// 
			this.columnSizeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnSizeDataGridViewTextBoxColumn.DataPropertyName = "ColumnSize";
			this.columnSizeDataGridViewTextBoxColumn.FillWeight = 8F;
			this.columnSizeDataGridViewTextBoxColumn.HeaderText = "ColumnSize";
			this.columnSizeDataGridViewTextBoxColumn.Name = "columnSizeDataGridViewTextBoxColumn";
			this.columnSizeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataTypeDataGridViewTextBoxColumn
			// 
			this.dataTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
			this.dataTypeDataGridViewTextBoxColumn.FillWeight = 12F;
			this.dataTypeDataGridViewTextBoxColumn.HeaderText = "CLR DataType";
			this.dataTypeDataGridViewTextBoxColumn.Name = "dataTypeDataGridViewTextBoxColumn";
			this.dataTypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataTypeNameDataGridViewTextBoxColumn
			// 
			this.dataTypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataTypeNameDataGridViewTextBoxColumn.DataPropertyName = "DataTypeName";
			this.dataTypeNameDataGridViewTextBoxColumn.FillWeight = 12F;
			this.dataTypeNameDataGridViewTextBoxColumn.HeaderText = "SQL DataType";
			this.dataTypeNameDataGridViewTextBoxColumn.Name = "dataTypeNameDataGridViewTextBoxColumn";
			this.dataTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// columnNameDataGridViewTextBoxColumn
			// 
			this.columnNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.columnNameDataGridViewTextBoxColumn.DataPropertyName = "ColumnName";
			this.columnNameDataGridViewTextBoxColumn.FillWeight = 20F;
			this.columnNameDataGridViewTextBoxColumn.HeaderText = "ColumnName";
			this.columnNameDataGridViewTextBoxColumn.Name = "columnNameDataGridViewTextBoxColumn";
			this.columnNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// grdSchema
			// 
			this.grdSchema.AllowUserToAddRows = false;
			this.grdSchema.AllowUserToDeleteRows = false;
			this.grdSchema.AllowUserToResizeRows = false;
			this.grdSchema.AutoGenerateColumns = false;
			this.grdSchema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdSchema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNameDataGridViewTextBoxColumn,
            this.dataTypeNameDataGridViewTextBoxColumn,
            this.dataTypeDataGridViewTextBoxColumn,
            this.columnSizeDataGridViewTextBoxColumn,
            this.NumericScale,
            this.numericPrecisionDataGridViewTextBoxColumn,
            this.allowDBNullDataGridViewCheckBoxColumn,
            this.isKeyDataGridViewCheckBoxColumn,
            this.isIdentityDataGridViewCheckBoxColumn,
            this.isAutoIncrementDataGridViewCheckBoxColumn});
			this.grdSchema.DataSource = this.sqlColumnBindingSource;
			this.grdSchema.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdSchema.Location = new System.Drawing.Point(2, 234);
			this.grdSchema.Margin = new System.Windows.Forms.Padding(2);
			this.grdSchema.Name = "grdSchema";
			this.grdSchema.ReadOnly = true;
			this.grdSchema.RowHeadersVisible = false;
			this.grdSchema.RowHeadersWidth = 20;
			this.grdSchema.RowTemplate.Height = 18;
			this.grdSchema.Size = new System.Drawing.Size(1294, 195);
			this.grdSchema.TabIndex = 25;
			// 
			// ResultContent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowTable);
			this.Name = "zzz_ResultContent";
			this.Size = new System.Drawing.Size(1298, 665);
			((System.ComponentModel.ISupportInitialize)(this.sqlColumnBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			this.flowTable.ResumeLayout(false);
			this.flowTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdSchema)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource sqlColumnBindingSource;
		internal System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.DataGridView grdData;
		private System.Windows.Forms.TableLayoutPanel flowTable;
		internal System.Windows.Forms.DataGridView grdSchema;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnSizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumericScale;
		private System.Windows.Forms.DataGridViewTextBoxColumn numericPrecisionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn allowDBNullDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isKeyDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isIdentityDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isAutoIncrementDataGridViewCheckBoxColumn;

	}
}

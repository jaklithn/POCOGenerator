namespace POCOGenerator.Controls
{
	partial class ResultContent
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
			this.tabTable = new System.Windows.Forms.TabControl();
			this.tabData = new System.Windows.Forms.TabPage();
			this.grdData = new System.Windows.Forms.DataGridView();
			this.tabSchema = new System.Windows.Forms.TabPage();
			this.grdSchema = new System.Windows.Forms.DataGridView();
			this.columnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumericScale = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numericPrecisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.allowDBNullDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isKeyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isIdentityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isAutoIncrementDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.sqlColumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableResult = new System.Windows.Forms.TableLayoutPanel();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.baseColumnNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.baseTableNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.providerSpecificDataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnOrdinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numericScaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.providerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nonVersionedProviderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isUniqueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isColumnSetDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isRowVersionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isLongDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isReadOnlyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.tabTable.SuspendLayout();
			this.tabData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			this.tabSchema.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdSchema)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sqlColumnBindingSource)).BeginInit();
			this.tableResult.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabTable
			// 
			this.tabTable.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabTable.Controls.Add(this.tabData);
			this.tabTable.Controls.Add(this.tabSchema);
			this.tabTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabTable.Font = new System.Drawing.Font("Arial", 9F);
			this.tabTable.Location = new System.Drawing.Point(3, 403);
			this.tabTable.Multiline = true;
			this.tabTable.Name = "tabTable";
			this.tabTable.Padding = new System.Drawing.Point(20, 6);
			this.tabTable.SelectedIndex = 0;
			this.tabTable.Size = new System.Drawing.Size(1216, 322);
			this.tabTable.TabIndex = 0;
			// 
			// tabData
			// 
			this.tabData.Controls.Add(this.grdData);
			this.tabData.Location = new System.Drawing.Point(30, 4);
			this.tabData.Name = "tabData";
			this.tabData.Padding = new System.Windows.Forms.Padding(3);
			this.tabData.Size = new System.Drawing.Size(1182, 314);
			this.tabData.TabIndex = 0;
			this.tabData.Text = "Data";
			this.tabData.UseVisualStyleBackColor = true;
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
			this.grdData.Size = new System.Drawing.Size(1176, 308);
			this.grdData.TabIndex = 28;
			// 
			// tabSchema
			// 
			this.tabSchema.Controls.Add(this.grdSchema);
			this.tabSchema.Location = new System.Drawing.Point(30, 4);
			this.tabSchema.Name = "tabSchema";
			this.tabSchema.Padding = new System.Windows.Forms.Padding(3);
			this.tabSchema.Size = new System.Drawing.Size(1182, 314);
			this.tabSchema.TabIndex = 1;
			this.tabSchema.Text = "Schema";
			this.tabSchema.UseVisualStyleBackColor = true;
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
			this.grdSchema.Location = new System.Drawing.Point(3, 3);
			this.grdSchema.Margin = new System.Windows.Forms.Padding(2);
			this.grdSchema.Name = "grdSchema";
			this.grdSchema.ReadOnly = true;
			this.grdSchema.RowHeadersVisible = false;
			this.grdSchema.RowHeadersWidth = 20;
			this.grdSchema.RowTemplate.Height = 18;
			this.grdSchema.Size = new System.Drawing.Size(1176, 308);
			this.grdSchema.TabIndex = 26;
			// 
			// columnNameDataGridViewTextBoxColumn
			// 
			this.columnNameDataGridViewTextBoxColumn.DataPropertyName = "ColumnName";
			this.columnNameDataGridViewTextBoxColumn.HeaderText = "ColumnName";
			this.columnNameDataGridViewTextBoxColumn.Name = "columnNameDataGridViewTextBoxColumn";
			this.columnNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataTypeNameDataGridViewTextBoxColumn
			// 
			this.dataTypeNameDataGridViewTextBoxColumn.DataPropertyName = "DataTypeName";
			this.dataTypeNameDataGridViewTextBoxColumn.HeaderText = "DataTypeName";
			this.dataTypeNameDataGridViewTextBoxColumn.Name = "dataTypeNameDataGridViewTextBoxColumn";
			this.dataTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataTypeDataGridViewTextBoxColumn
			// 
			this.dataTypeDataGridViewTextBoxColumn.DataPropertyName = "DataType";
			this.dataTypeDataGridViewTextBoxColumn.HeaderText = "DataType";
			this.dataTypeDataGridViewTextBoxColumn.Name = "dataTypeDataGridViewTextBoxColumn";
			this.dataTypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// columnSizeDataGridViewTextBoxColumn
			// 
			this.columnSizeDataGridViewTextBoxColumn.DataPropertyName = "ColumnSize";
			this.columnSizeDataGridViewTextBoxColumn.HeaderText = "ColumnSize";
			this.columnSizeDataGridViewTextBoxColumn.Name = "columnSizeDataGridViewTextBoxColumn";
			this.columnSizeDataGridViewTextBoxColumn.ReadOnly = true;
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
			// numericPrecisionDataGridViewTextBoxColumn
			// 
			this.numericPrecisionDataGridViewTextBoxColumn.DataPropertyName = "NumericPrecision";
			this.numericPrecisionDataGridViewTextBoxColumn.HeaderText = "NumericPrecision";
			this.numericPrecisionDataGridViewTextBoxColumn.Name = "numericPrecisionDataGridViewTextBoxColumn";
			this.numericPrecisionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// allowDBNullDataGridViewCheckBoxColumn
			// 
			this.allowDBNullDataGridViewCheckBoxColumn.DataPropertyName = "AllowDBNull";
			this.allowDBNullDataGridViewCheckBoxColumn.HeaderText = "AllowDBNull";
			this.allowDBNullDataGridViewCheckBoxColumn.Name = "allowDBNullDataGridViewCheckBoxColumn";
			this.allowDBNullDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// isKeyDataGridViewCheckBoxColumn
			// 
			this.isKeyDataGridViewCheckBoxColumn.DataPropertyName = "IsKey";
			this.isKeyDataGridViewCheckBoxColumn.HeaderText = "IsKey";
			this.isKeyDataGridViewCheckBoxColumn.Name = "isKeyDataGridViewCheckBoxColumn";
			this.isKeyDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// isIdentityDataGridViewCheckBoxColumn
			// 
			this.isIdentityDataGridViewCheckBoxColumn.DataPropertyName = "IsIdentity";
			this.isIdentityDataGridViewCheckBoxColumn.HeaderText = "IsIdentity";
			this.isIdentityDataGridViewCheckBoxColumn.Name = "isIdentityDataGridViewCheckBoxColumn";
			this.isIdentityDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// isAutoIncrementDataGridViewCheckBoxColumn
			// 
			this.isAutoIncrementDataGridViewCheckBoxColumn.DataPropertyName = "IsAutoIncrement";
			this.isAutoIncrementDataGridViewCheckBoxColumn.HeaderText = "IsAutoIncrement";
			this.isAutoIncrementDataGridViewCheckBoxColumn.Name = "isAutoIncrementDataGridViewCheckBoxColumn";
			this.isAutoIncrementDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// sqlColumnBindingSource
			// 
			this.sqlColumnBindingSource.DataSource = typeof(POCOGenerator.Entities.SqlColumn);
			// 
			// tableResult
			// 
			this.tableResult.ColumnCount = 1;
			this.tableResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableResult.Controls.Add(this.txtCode, 0, 0);
			this.tableResult.Controls.Add(this.tabTable, 0, 1);
			this.tableResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableResult.Location = new System.Drawing.Point(0, 0);
			this.tableResult.Name = "tableResult";
			this.tableResult.RowCount = 2;
			this.tableResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
			this.tableResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableResult.Size = new System.Drawing.Size(1222, 728);
			this.tableResult.TabIndex = 1;
			// 
			// txtCode
			// 
			this.txtCode.BackColor = System.Drawing.Color.White;
			this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCode.ForeColor = System.Drawing.Color.Blue;
			this.txtCode.Location = new System.Drawing.Point(2, 2);
			this.txtCode.Margin = new System.Windows.Forms.Padding(2);
			this.txtCode.Multiline = true;
			this.txtCode.Name = "txtCode";
			this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCode.Size = new System.Drawing.Size(1218, 396);
			this.txtCode.TabIndex = 27;
			this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
			// 
			// baseColumnNameDataGridViewTextBoxColumn
			// 
			this.baseColumnNameDataGridViewTextBoxColumn.DataPropertyName = "BaseColumnName";
			this.baseColumnNameDataGridViewTextBoxColumn.HeaderText = "BaseColumnName";
			this.baseColumnNameDataGridViewTextBoxColumn.Name = "baseColumnNameDataGridViewTextBoxColumn";
			this.baseColumnNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// baseTableNameDataGridViewTextBoxColumn
			// 
			this.baseTableNameDataGridViewTextBoxColumn.DataPropertyName = "BaseTableName";
			this.baseTableNameDataGridViewTextBoxColumn.HeaderText = "BaseTableName";
			this.baseTableNameDataGridViewTextBoxColumn.Name = "baseTableNameDataGridViewTextBoxColumn";
			this.baseTableNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// providerSpecificDataTypeDataGridViewTextBoxColumn
			// 
			this.providerSpecificDataTypeDataGridViewTextBoxColumn.DataPropertyName = "ProviderSpecificDataType";
			this.providerSpecificDataTypeDataGridViewTextBoxColumn.HeaderText = "ProviderSpecificDataType";
			this.providerSpecificDataTypeDataGridViewTextBoxColumn.Name = "providerSpecificDataTypeDataGridViewTextBoxColumn";
			this.providerSpecificDataTypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// columnOrdinalDataGridViewTextBoxColumn
			// 
			this.columnOrdinalDataGridViewTextBoxColumn.DataPropertyName = "ColumnOrdinal";
			this.columnOrdinalDataGridViewTextBoxColumn.HeaderText = "ColumnOrdinal";
			this.columnOrdinalDataGridViewTextBoxColumn.Name = "columnOrdinalDataGridViewTextBoxColumn";
			this.columnOrdinalDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// numericScaleDataGridViewTextBoxColumn
			// 
			this.numericScaleDataGridViewTextBoxColumn.DataPropertyName = "NumericScale";
			this.numericScaleDataGridViewTextBoxColumn.HeaderText = "NumericScale";
			this.numericScaleDataGridViewTextBoxColumn.Name = "numericScaleDataGridViewTextBoxColumn";
			this.numericScaleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// providerTypeDataGridViewTextBoxColumn
			// 
			this.providerTypeDataGridViewTextBoxColumn.DataPropertyName = "ProviderType";
			this.providerTypeDataGridViewTextBoxColumn.HeaderText = "ProviderType";
			this.providerTypeDataGridViewTextBoxColumn.Name = "providerTypeDataGridViewTextBoxColumn";
			this.providerTypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nonVersionedProviderTypeDataGridViewTextBoxColumn
			// 
			this.nonVersionedProviderTypeDataGridViewTextBoxColumn.DataPropertyName = "NonVersionedProviderType";
			this.nonVersionedProviderTypeDataGridViewTextBoxColumn.HeaderText = "NonVersionedProviderType";
			this.nonVersionedProviderTypeDataGridViewTextBoxColumn.Name = "nonVersionedProviderTypeDataGridViewTextBoxColumn";
			this.nonVersionedProviderTypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// isUniqueDataGridViewCheckBoxColumn
			// 
			this.isUniqueDataGridViewCheckBoxColumn.DataPropertyName = "IsUnique";
			this.isUniqueDataGridViewCheckBoxColumn.HeaderText = "IsUnique";
			this.isUniqueDataGridViewCheckBoxColumn.Name = "isUniqueDataGridViewCheckBoxColumn";
			this.isUniqueDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// isColumnSetDataGridViewCheckBoxColumn
			// 
			this.isColumnSetDataGridViewCheckBoxColumn.DataPropertyName = "IsColumnSet";
			this.isColumnSetDataGridViewCheckBoxColumn.HeaderText = "IsColumnSet";
			this.isColumnSetDataGridViewCheckBoxColumn.Name = "isColumnSetDataGridViewCheckBoxColumn";
			this.isColumnSetDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// isRowVersionDataGridViewCheckBoxColumn
			// 
			this.isRowVersionDataGridViewCheckBoxColumn.DataPropertyName = "IsRowVersion";
			this.isRowVersionDataGridViewCheckBoxColumn.HeaderText = "IsRowVersion";
			this.isRowVersionDataGridViewCheckBoxColumn.Name = "isRowVersionDataGridViewCheckBoxColumn";
			this.isRowVersionDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// isLongDataGridViewCheckBoxColumn
			// 
			this.isLongDataGridViewCheckBoxColumn.DataPropertyName = "IsLong";
			this.isLongDataGridViewCheckBoxColumn.HeaderText = "IsLong";
			this.isLongDataGridViewCheckBoxColumn.Name = "isLongDataGridViewCheckBoxColumn";
			this.isLongDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// isReadOnlyDataGridViewCheckBoxColumn
			// 
			this.isReadOnlyDataGridViewCheckBoxColumn.DataPropertyName = "IsReadOnly";
			this.isReadOnlyDataGridViewCheckBoxColumn.HeaderText = "IsReadOnly";
			this.isReadOnlyDataGridViewCheckBoxColumn.Name = "isReadOnlyDataGridViewCheckBoxColumn";
			this.isReadOnlyDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// ResultContent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableResult);
			this.Name = "ResultContent";
			this.Size = new System.Drawing.Size(1222, 728);
			this.tabTable.ResumeLayout(false);
			this.tabData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			this.tabSchema.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdSchema)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sqlColumnBindingSource)).EndInit();
			this.tableResult.ResumeLayout(false);
			this.tableResult.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabTable;
		private System.Windows.Forms.TabPage tabData;
		private System.Windows.Forms.TabPage tabSchema;
		private System.Windows.Forms.DataGridView grdData;
		internal System.Windows.Forms.DataGridView grdSchema;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumericScale;
		private System.Windows.Forms.TableLayoutPanel tableResult;
		internal System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.BindingSource sqlColumnBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn baseColumnNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn baseTableNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn providerSpecificDataTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataTypeNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnOrdinalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnSizeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numericPrecisionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numericScaleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn providerTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nonVersionedProviderTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isUniqueDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isColumnSetDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn allowDBNullDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isKeyDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isIdentityDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isAutoIncrementDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isRowVersionDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isLongDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isReadOnlyDataGridViewCheckBoxColumn;
	}
}

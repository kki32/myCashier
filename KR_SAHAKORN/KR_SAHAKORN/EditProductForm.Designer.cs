namespace KR_SAHAKORN
{
    partial class EditProductForm
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.editStockGrid = new System.Windows.Forms.DataGridView();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.saveEditStockButton = new System.Windows.Forms.Button();
            this.editProductHistoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.damagedProduct = new System.Windows.Forms.Button();
            this.editProductCategoryColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.column_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warningText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editStockGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // editStockGrid
            // 
            this.editStockGrid.AllowUserToAddRows = false;
            this.editStockGrid.AllowUserToDeleteRows = false;
            this.editStockGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editStockGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.editStockGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editStockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.editStockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editStockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editProductCategoryColumn,
            this.column_2,
            this.Column22,
            this.Column30,
            this.column_5,
            this.column_6,
            this.column_7,
            this.column_8});
            this.editStockGrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.editStockGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.editStockGrid.Location = new System.Drawing.Point(24, 12);
            this.editStockGrid.MultiSelect = false;
            this.editStockGrid.Name = "editStockGrid";
            this.editStockGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.editStockGrid.Size = new System.Drawing.Size(877, 95);
            this.editStockGrid.TabIndex = 24;
            this.editStockGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.editStockGrid_CellValueChanged);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // saveEditStockButton
            // 
            this.saveEditStockButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.saveEditStockButton.Location = new System.Drawing.Point(826, 331);
            this.saveEditStockButton.Name = "saveEditStockButton";
            this.saveEditStockButton.Size = new System.Drawing.Size(75, 32);
            this.saveEditStockButton.TabIndex = 25;
            this.saveEditStockButton.Text = "Save";
            this.saveEditStockButton.UseVisualStyleBackColor = true;
            this.saveEditStockButton.Click += new System.EventHandler(this.saveEditStockButton_Click);
            // 
            // editProductHistoryRichTextBox
            // 
            this.editProductHistoryRichTextBox.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.editProductHistoryRichTextBox.Location = new System.Drawing.Point(24, 155);
            this.editProductHistoryRichTextBox.Name = "editProductHistoryRichTextBox";
            this.editProductHistoryRichTextBox.ReadOnly = true;
            this.editProductHistoryRichTextBox.Size = new System.Drawing.Size(877, 142);
            this.editProductHistoryRichTextBox.TabIndex = 26;
            this.editProductHistoryRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.label1.Location = new System.Drawing.Point(19, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "ข้อมูลในอดีต";
            // 
            // removeProductButton
            // 
            this.removeProductButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.removeProductButton.Location = new System.Drawing.Point(719, 331);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(85, 32);
            this.removeProductButton.TabIndex = 28;
            this.removeProductButton.Text = "ลบสินค้า";
            this.removeProductButton.UseVisualStyleBackColor = true;
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButton_Click);
            // 
            // editProductCategoryColumn
            // 
            this.editProductCategoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.editProductCategoryColumn.FillWeight = 30F;
            this.editProductCategoryColumn.HeaderText = GlobalEnums.LOCATION;
            this.editProductCategoryColumn.Name = "editProductCategoryColumn";
            this.editProductCategoryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editProductCategoryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // column_2
            // 
            this.column_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_2.HeaderText = GlobalEnums.NAME;
            this.column_2.Name = "column_2";
            // 
            // Column22
            // 
            this.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column22.FillWeight = 30F;
            this.Column22.HeaderText = GlobalEnums.PRICE;
            this.Column22.Name = "Column22";
            // 
            // Column30
            // 
            this.Column30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column30.FillWeight = 30F;
            this.Column30.HeaderText = GlobalEnums.INSTOCK;
            this.Column30.Name = "Column30";
            // 
            // column_5
            // 
            this.column_5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_5.FillWeight = 30F;
            this.column_5.HeaderText = GlobalEnums.ORIGINAL_COST;
            this.column_5.Name = "column_5";
            // 
            // column_6
            // 
            this.column_6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_6.FillWeight = 30F;
            this.column_6.HeaderText = GlobalEnums.PROFIT;
            this.column_6.Name = "column_6";
            //// 
            //// column_7
            //// 
            //this.column_7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //this.column_7.FillWeight = 30F;
            //this.column_7.HeaderText = "ควรมีใน stock";
            //this.column_7.Name = "column_7";
            //// 
            //// column_8
            //// 
            //this.column_8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            //this.column_8.FillWeight = 30F;
            //this.column_8.HeaderText = "ราคาต้นทุน (จำนวน/แพ็ค)";
            //this.column_8.Name = "column_8";
            //// 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.warningText.ForeColor = System.Drawing.Color.DarkRed;
            this.warningText.Location = new System.Drawing.Point(19, 300);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(0, 26);
            this.warningText.TabIndex = 30;
            // 
            // EditProductForm
            // 
            this.ClientSize = new System.Drawing.Size(929, 388);
            this.Controls.Add(this.warningText);
            this.Controls.Add(this.damagedProduct);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editProductHistoryRichTextBox);
            this.Controls.Add(this.saveEditStockButton);
            this.Controls.Add(this.editStockGrid);
            this.Name = "EditProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.editStockGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox editProductHistoryRichTextBox;
        private System.Windows.Forms.Button saveEditStockButton;
        private System.Windows.Forms.Button removeProductButton;
        protected System.Windows.Forms.DataGridView editStockGrid;
        private System.Windows.Forms.Button damagedProduct;
        private System.Windows.Forms.DataGridViewComboBoxColumn editProductCategoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_7;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_8;
        private System.Windows.Forms.Label warningText;
    }
}
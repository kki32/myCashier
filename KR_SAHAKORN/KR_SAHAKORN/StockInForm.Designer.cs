namespace KR_SAHAKORN
{
    partial class StockInForm
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
            this.stockInGrid = new System.Windows.Forms.DataGridView();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stockInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockInGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // stockInGrid
            // 
            this.stockInGrid.AllowUserToAddRows = false;
            this.stockInGrid.AllowUserToDeleteRows = false;
            this.stockInGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockInGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.stockInGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stockInGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockInGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column20,
            this.Column23,
            this.Column1,
            this.Column2,
            this.Column21});
            this.stockInGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.stockInGrid.Location = new System.Drawing.Point(24, 61);
            this.stockInGrid.MultiSelect = false;
            this.stockInGrid.Name = "stockInGrid";
            this.stockInGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockInGrid.Size = new System.Drawing.Size(877, 277);
            this.stockInGrid.TabIndex = 24;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 25;
            this.label1.Text = "*ปิดหน้าต่างเพื่อหยุดการรับ stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(759, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 26);
            this.label5.TabIndex = 32;
            this.label5.Text = "วันที่";
            // 
            // stockInDateTimePicker
            // 
            this.stockInDateTimePicker.CustomFormat = "MM-dd-yyyy";
            this.stockInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stockInDateTimePicker.Location = new System.Drawing.Point(800, 12);
            this.stockInDateTimePicker.Name = "stockInDateTimePicker";
            this.stockInDateTimePicker.Size = new System.Drawing.Size(101, 34);
            this.stockInDateTimePicker.TabIndex = 31;
            this.stockInDateTimePicker.ValueChanged += new System.EventHandler(this.stockInDateTimePicker_ValueChanged);
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column20.HeaderText = "รายการสินค้า";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column23.FillWeight = 30F;
            this.Column23.HeaderText = "เพิ่มไปใน stock";
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "เปลี่ยนราคาต่อชิ้น";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 131;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "เปลี่ยนราคาต่อแพ็ค";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 140;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column21.FillWeight = 30F;
            this.Column21.HeaderText = "เปลี่ยนราคาต้นทุน";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // StockInForm
            // 
            this.ClientSize = new System.Drawing.Size(929, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stockInDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockInGrid);
            this.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.Name = "StockInForm";
            ((System.ComponentModel.ISupportInitialize)(this.stockInGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Diagnostics.EventLog eventLog1;
        protected System.Windows.Forms.DataGridView stockInGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker stockInDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column21;
    }
}
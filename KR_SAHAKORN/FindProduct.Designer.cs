namespace KR_SAHAKORN
{
    partial class FindProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.findProductsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalItems = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.findProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // findProductsGrid
            // 
            this.findProductsGrid.AllowUserToAddRows = false;
            this.findProductsGrid.AllowUserToDeleteRows = false;
            this.findProductsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findProductsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.findProductsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.findProductsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.findProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.findProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.productName,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.findProductsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.findProductsGrid.Location = new System.Drawing.Point(12, 29);
            this.findProductsGrid.Name = "findProductsGrid";
            this.findProductsGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.findProductsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.findProductsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.findProductsGrid.ShowEditingIcon = false;
            this.findProductsGrid.Size = new System.Drawing.Size(668, 268);
            this.findProductsGrid.TabIndex = 0;
            this.findProductsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.findProduct_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "ชนิด";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "รายการ";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "ราคาต่อชิ้น";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 30F;
            this.Column4.HeaderText = "ใน stock";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 30F;
            this.Column5.HeaderText = "ควรมีใน stock";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.addProductButton.Location = new System.Drawing.Point(562, 303);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(118, 28);
            this.addProductButton.TabIndex = 1;
            this.addProductButton.Text = "เพิ่มรายการ";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.AddProductFromBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.label1.Location = new System.Drawing.Point(13, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // totalItems
            // 
            this.totalItems.AutoSize = true;
            this.totalItems.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.totalItems.Location = new System.Drawing.Point(49, 303);
            this.totalItems.Name = "totalItems";
            this.totalItems.Size = new System.Drawing.Size(47, 26);
            this.totalItems.TabIndex = 3;
            this.totalItems.Text = "label2";
            // 
            // FindProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 337);
            this.Controls.Add(this.totalItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.findProductsGrid);
            this.Name = "FindProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindProduct";
            ((System.ComponentModel.ISupportInitialize)(this.findProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView findProductsGrid;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
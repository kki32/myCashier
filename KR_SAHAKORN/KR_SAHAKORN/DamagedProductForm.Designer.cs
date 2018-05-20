namespace KR_SAHAKORN
{
    partial class DamagedProductForm
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
            this.expiredRadioButton = new System.Windows.Forms.RadioButton();
            this.damagedRadioButton = new System.Windows.Forms.RadioButton();
            this.confirmDamagedProductButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.etcRadioButton = new System.Windows.Forms.RadioButton();
            this.EtcTextBox = new System.Windows.Forms.TextBox();
            this.payTotalLabel = new System.Windows.Forms.Label();
            this.damagedQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damagedQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // expiredRadioButton
            // 
            this.expiredRadioButton.AutoSize = true;
            this.expiredRadioButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.expiredRadioButton.Location = new System.Drawing.Point(19, 54);
            this.expiredRadioButton.Name = "expiredRadioButton";
            this.expiredRadioButton.Size = new System.Drawing.Size(76, 30);
            this.expiredRadioButton.TabIndex = 0;
            this.expiredRadioButton.TabStop = true;
            this.expiredRadioButton.Text = "หมดอายุ";
            this.expiredRadioButton.UseVisualStyleBackColor = true;
            // 
            // damagedRadioButton
            // 
            this.damagedRadioButton.AutoSize = true;
            this.damagedRadioButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.damagedRadioButton.Location = new System.Drawing.Point(19, 87);
            this.damagedRadioButton.Name = "damagedRadioButton";
            this.damagedRadioButton.Size = new System.Drawing.Size(95, 30);
            this.damagedRadioButton.TabIndex = 1;
            this.damagedRadioButton.TabStop = true;
            this.damagedRadioButton.Text = "ชำรุดตอนซื้อ";
            this.damagedRadioButton.UseVisualStyleBackColor = true;
            // 
            // confirmDamagedProductButton
            // 
            this.confirmDamagedProductButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.confirmDamagedProductButton.Location = new System.Drawing.Point(192, 253);
            this.confirmDamagedProductButton.Name = "confirmDamagedProductButton";
            this.confirmDamagedProductButton.Size = new System.Drawing.Size(75, 31);
            this.confirmDamagedProductButton.TabIndex = 2;
            this.confirmDamagedProductButton.Text = "บันทึก";
            this.confirmDamagedProductButton.UseVisualStyleBackColor = true;
            this.confirmDamagedProductButton.Click += new System.EventHandler(this.confirmDamagedProductButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "เหตุผลของสินค้าชำรุด";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.etcRadioButton);
            this.groupBox1.Controls.Add(this.EtcTextBox);
            this.groupBox1.Controls.Add(this.expiredRadioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.payTotalLabel);
            this.groupBox1.Controls.Add(this.damagedRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // etcRadioButton
            // 
            this.etcRadioButton.AutoSize = true;
            this.etcRadioButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.etcRadioButton.Location = new System.Drawing.Point(19, 128);
            this.etcRadioButton.Name = "etcRadioButton";
            this.etcRadioButton.Size = new System.Drawing.Size(14, 13);
            this.etcRadioButton.TabIndex = 9;
            this.etcRadioButton.TabStop = true;
            this.etcRadioButton.UseVisualStyleBackColor = true;
            this.etcRadioButton.CheckedChanged += new System.EventHandler(this.selectEtc_CheckedChanged);
            // 
            // EtcTextBox
            // 
            this.EtcTextBox.Enabled = false;
            this.EtcTextBox.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.EtcTextBox.Location = new System.Drawing.Point(39, 118);
            this.EtcTextBox.Name = "EtcTextBox";
            this.EtcTextBox.Size = new System.Drawing.Size(141, 34);
            this.EtcTextBox.TabIndex = 8;
            this.EtcTextBox.Text = "อื่นๆ";
            // 
            // payTotalLabel
            // 
            this.payTotalLabel.AutoSize = true;
            this.payTotalLabel.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.payTotalLabel.Location = new System.Drawing.Point(79, 29);
            this.payTotalLabel.Name = "payTotalLabel";
            this.payTotalLabel.Size = new System.Drawing.Size(0, 26);
            this.payTotalLabel.TabIndex = 7;
            // 
            // damagedQuantity
            // 
            this.damagedQuantity.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.damagedQuantity.Location = new System.Drawing.Point(107, 196);
            this.damagedQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.damagedQuantity.Name = "damagedQuantity";
            this.damagedQuantity.Size = new System.Drawing.Size(52, 34);
            this.damagedQuantity.TabIndex = 7;
            this.damagedQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.label1.Location = new System.Drawing.Point(52, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "จำนวน";
            // 
            // DamagedProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(391, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.damagedQuantity);
            this.Controls.Add(this.confirmDamagedProductButton);
            this.Name = "DamagedProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.damagedQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton expiredRadioButton;
        private System.Windows.Forms.RadioButton damagedRadioButton;
        private System.Windows.Forms.Button confirmDamagedProductButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label payTotalLabel;
        private System.Windows.Forms.RadioButton etcRadioButton;
        private System.Windows.Forms.TextBox EtcTextBox;
        private System.Windows.Forms.NumericUpDown damagedQuantity;
        private System.Windows.Forms.Label label1;
    }
}
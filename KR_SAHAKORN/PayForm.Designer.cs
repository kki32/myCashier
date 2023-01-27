namespace KR_SAHAKORN
{
    partial class PayForm
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
            this.payBySignRadioButton = new System.Windows.Forms.RadioButton();
            this.payByCashRadioButton = new System.Windows.Forms.RadioButton();
            this.confirmToPayButton = new System.Windows.Forms.Button();
            this.givenLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.payTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payTotalLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payBySignRadioButton
            // 
            this.payBySignRadioButton.AutoSize = true;
            this.payBySignRadioButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.payBySignRadioButton.Location = new System.Drawing.Point(7, 19);
            this.payBySignRadioButton.Name = "payBySignRadioButton";
            this.payBySignRadioButton.Size = new System.Drawing.Size(49, 30);
            this.payBySignRadioButton.TabIndex = 0;
            this.payBySignRadioButton.TabStop = true;
            this.payBySignRadioButton.Text = "เซ็น";
            this.payBySignRadioButton.UseVisualStyleBackColor = true;
            // 
            // payByCashRadioButton
            // 
            this.payByCashRadioButton.AutoSize = true;
            this.payByCashRadioButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.payByCashRadioButton.Location = new System.Drawing.Point(7, 52);
            this.payByCashRadioButton.Name = "payByCashRadioButton";
            this.payByCashRadioButton.Size = new System.Drawing.Size(64, 30);
            this.payByCashRadioButton.TabIndex = 1;
            this.payByCashRadioButton.TabStop = true;
            this.payByCashRadioButton.Text = "เงินสด";
            this.payByCashRadioButton.UseVisualStyleBackColor = true;
            this.payByCashRadioButton.CheckedChanged += new System.EventHandler(this.selectCash_CheckedChanged);
            // 
            // confirmToPayButton
            // 
            this.confirmToPayButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.confirmToPayButton.Location = new System.Drawing.Point(159, 196);
            this.confirmToPayButton.Name = "confirmToPayButton";
            this.confirmToPayButton.Size = new System.Drawing.Size(75, 31);
            this.confirmToPayButton.TabIndex = 2;
            this.confirmToPayButton.Text = "บันทึก";
            this.confirmToPayButton.UseVisualStyleBackColor = true;
            this.confirmToPayButton.Click += new System.EventHandler(this.confirmToPayButton_Click);

            this.AcceptButton = this.confirmToPayButton;
            // 
            // givenLabel
            // 
            this.givenLabel.AutoSize = true;
            this.givenLabel.Enabled = false;
            this.givenLabel.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.givenLabel.Location = new System.Drawing.Point(69, 54);
            this.givenLabel.Name = "givenLabel";
            this.givenLabel.Size = new System.Drawing.Size(40, 26);
            this.givenLabel.TabIndex = 3;
            this.givenLabel.Text = "ให้มา";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.label2.Location = new System.Drawing.Point(31, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "รวมทั้งสิ้น";
            // 
            // payTextBox
            // 
            this.payTextBox.Enabled = false;
            this.payTextBox.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.payTextBox.Location = new System.Drawing.Point(115, 46);
            this.payTextBox.Name = "payTextBox";
            this.payTextBox.Size = new System.Drawing.Size(50, 34);
            this.payTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payBySignRadioButton);
            this.groupBox1.Controls.Add(this.payTotalLabel);
            this.groupBox1.Controls.Add(this.payByCashRadioButton);
            this.groupBox1.Controls.Add(this.payTextBox);
            this.groupBox1.Controls.Add(this.givenLabel);
            this.groupBox1.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(34, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
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
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.totalCostLabel.Location = new System.Drawing.Point(89, 30);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(47, 26);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.Text = "label3";
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(303, 253);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmToPayButton);
            this.Name = "PayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton payBySignRadioButton;
        private System.Windows.Forms.RadioButton payByCashRadioButton;
        private System.Windows.Forms.Button confirmToPayButton;
        private System.Windows.Forms.Label givenLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox payTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label payTotalLabel;
        private System.Windows.Forms.Label totalCostLabel;
    }
}
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
            this.confirmToPayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.AcceptButton = this.confirmToPayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(303, 253);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmToPayButton);
            this.Name = "PayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmToPayButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalCostLabel;
    }
}
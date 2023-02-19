namespace KR_SAHAKORN
{
    partial class AddProductForm
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
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.newProductQuantityPerPack = new System.Windows.Forms.TextBox();
            this.newProductPrice = new System.Windows.Forms.TextBox();
            this.newProductMin = new System.Windows.Forms.NumericUpDown();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.newProductInStock = new System.Windows.Forms.NumericUpDown();
            this.newProductCategoryDropDown = new System.Windows.Forms.ComboBox();
            this.newProductName = new System.Windows.Forms.TextBox();
            this.newProductFlavour = new System.Windows.Forms.TextBox();
            this.newProductQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newProductBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.newProductPricePerPack = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.newProductOriginalPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.newProductMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductInStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(352, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 26);
            this.label16.TabIndex = 25;
            this.label16.Text = "ราคาต่อแพ็ค";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 26);
            this.label15.TabIndex = 24;
            this.label15.Text = "จำนวนในแพ็ค";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 26);
            this.label14.TabIndex = 23;
            this.label14.Text = "ราคาต้นทุน";
            // 
            // newProductQuantityPerPack
            // 
            this.newProductQuantityPerPack.Location = new System.Drawing.Point(427, 250);
            this.newProductQuantityPerPack.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductQuantityPerPack.Name = "newProductQuantityPerPack";
            this.newProductQuantityPerPack.Size = new System.Drawing.Size(54, 34);
            this.newProductQuantityPerPack.TabIndex = 21;
            this.newProductQuantityPerPack.Text = "0";
            // 
            // newProductPrice
            // 
            this.newProductPrice.Location = new System.Drawing.Point(426, 57);
            this.newProductPrice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductPrice.Name = "newProductPrice";
            this.newProductPrice.Size = new System.Drawing.Size(53, 34);
            this.newProductPrice.TabIndex = 6;
            // 
            // newProductMin
            // 
            this.newProductMin.Location = new System.Drawing.Point(426, 147);
            this.newProductMin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductMin.Name = "newProductMin";
            this.newProductMin.Size = new System.Drawing.Size(54, 34);
            this.newProductMin.TabIndex = 8;
            this.newProductMin.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Location = new System.Drawing.Point(427, 357);
            this.addNewProductButton.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(103, 36);
            this.addNewProductButton.TabIndex = 9;
            this.addNewProductButton.Text = "เพิ่มสินค้า";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // newProductInStock
            // 
            this.newProductInStock.Location = new System.Drawing.Point(425, 103);
            this.newProductInStock.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductInStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.newProductInStock.Name = "newProductInStock";
            this.newProductInStock.Size = new System.Drawing.Size(54, 34);
            this.newProductInStock.TabIndex = 7;
            this.newProductInStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newProductCategoryDropDown
            // 
            this.newProductCategoryDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.newProductCategoryDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.newProductCategoryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newProductCategoryDropDown.FormattingEnabled = true;
            this.newProductCategoryDropDown.Location = new System.Drawing.Point(98, 36);
            this.newProductCategoryDropDown.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductCategoryDropDown.Name = "newProductCategoryDropDown";
            this.newProductCategoryDropDown.Size = new System.Drawing.Size(112, 34);
            this.newProductCategoryDropDown.TabIndex = 1;
            // 
            // newProductName
            // 
            this.newProductName.Location = new System.Drawing.Point(98, 87);
            this.newProductName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductName.Name = "newProductName";
            this.newProductName.Size = new System.Drawing.Size(112, 34);
            this.newProductName.TabIndex = 2;
            // 
            // newProductFlavour
            // 
            this.newProductFlavour.Location = new System.Drawing.Point(100, 224);
            this.newProductFlavour.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductFlavour.Name = "newProductFlavour";
            this.newProductFlavour.Size = new System.Drawing.Size(110, 34);
            this.newProductFlavour.TabIndex = 4;
            // 
            // newProductQuantity
            // 
            this.newProductQuantity.Location = new System.Drawing.Point(100, 283);
            this.newProductQuantity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductQuantity.Name = "newProductQuantity";
            this.newProductQuantity.Size = new System.Drawing.Size(62, 34);
            this.newProductQuantity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "หมวด*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "ประเภท(*)";
            // 
            // newProductBrand
            // 
            this.newProductBrand.Location = new System.Drawing.Point(100, 150);
            this.newProductBrand.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductBrand.Name = "newProductBrand";
            this.newProductBrand.Size = new System.Drawing.Size(110, 34);
            this.newProductBrand.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "ยี่ห้อ(*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "สี/รส/กลิ่น";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "ปริมาตร/ขนาด";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = "ราคาต่อชิ้น*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "ใน stock มี*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(372, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 26);
            this.label12.TabIndex = 18;
            this.label12.Text = "ควรมี*";
            // 
            // newProductPricePerPack
            // 
            this.newProductPricePerPack.Location = new System.Drawing.Point(427, 205);
            this.newProductPricePerPack.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductPricePerPack.Name = "newProductPricePerPack";
            this.newProductPricePerPack.Size = new System.Drawing.Size(54, 34);
            this.newProductPricePerPack.TabIndex = 20;
            this.newProductPricePerPack.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CordiaUPC", 12.25F);
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "เช่น ที่ดักหนู แชมพู";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CordiaUPC", 12.25F);
            this.label2.Location = new System.Drawing.Point(20, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "เช่น ยูโร่ เลย์";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("CordiaUPC", 12.25F);
            this.label4.Location = new System.Drawing.Point(8, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "เช่น ช็อกโกแล็ต";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("CordiaUPC", 12.25F);
            this.label13.Location = new System.Drawing.Point(7, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 30;
            this.label13.Text = "เช่น 100มล 100ก";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // newProductOriginalPrice
            // 
            this.newProductOriginalPrice.Location = new System.Drawing.Point(428, 296);
            this.newProductOriginalPrice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.newProductOriginalPrice.Name = "newProductOriginalPrice";
            this.newProductOriginalPrice.Size = new System.Drawing.Size(54, 34);
            this.newProductOriginalPrice.TabIndex = 22;
            this.newProductOriginalPrice.Text = "0.0";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 411);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newProductPrice);
            this.Controls.Add(this.newProductMin);
            this.Controls.Add(this.addNewProductButton);
            this.Controls.Add(this.newProductInStock);
            this.Controls.Add(this.newProductCategoryDropDown);
            this.Controls.Add(this.newProductName);
            this.Controls.Add(this.newProductFlavour);
            this.Controls.Add(this.newProductQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.newProductBrand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.newProductPricePerPack);
            this.Controls.Add(this.newProductQuantityPerPack);
            this.Controls.Add(this.newProductOriginalPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.newProductMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newProductInStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox newProductQuantityPerPack;
        private System.Windows.Forms.TextBox newProductPrice;
        private System.Windows.Forms.NumericUpDown newProductMin;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.NumericUpDown newProductInStock;
        private System.Windows.Forms.ComboBox newProductCategoryDropDown;
        private System.Windows.Forms.TextBox newProductName;
        private System.Windows.Forms.TextBox newProductFlavour;
        private System.Windows.Forms.TextBox newProductQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newProductBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox newProductPricePerPack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox newProductOriginalPrice;
    }
}
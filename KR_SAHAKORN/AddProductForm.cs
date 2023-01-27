using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_SAHAKORN
{
    public partial class AddProductForm : Form
    {

        public Item newItem;
        public StockInForm stockInForm;
        public AddProductForm()
        {
            InitializeComponent();
            LoadNewProductCategory();
        }

        public void setStockInForm(StockInForm stockInForm)
        {
            this.stockInForm = stockInForm;
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    if (newProductCategoryDropDown.Text == "")
            //    {
            //        MessageBox.Show("ต้องมีหมวด", "Must have category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else if (newProductName.Text == "" && newProductBrand.Text == "")
            //    {
            //        MessageBox.Show("ต้องมียี่ห้อหรือชื่อ", "Must have brand or name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else if (newProductPrice.Text == "")
            //    {
            //        MessageBox.Show("ราคาไม่ถูกต้อง", "Invalid price", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else if (newProductInStock.Text == "")
            //    {
            //        MessageBox.Show("จำนวนใน stock ไม่ถูกต้อง", "Invalid in stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }//TODO try-catch double
            //    else if (Convert.ToDouble(newProductPrice.Text) <= 0)
            //    {
            //        MessageBox.Show("ราคาต้องมากกว่า 0", "Can't have free product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    else if (InfoManager.containsItem(newProductName.Text))
            //    {
            //        MessageBox.Show("มี product นี้แล้ว", "Already got this in stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else if (newProductPricePerPack.Text == "")
            //    {
            //        MessageBox.Show("ราคาต่อแพ็คไม่ถูกต้อง", "Price per pack is invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //    else if (newProductQuantityPerPack.Text == "")
            //    {
            //        MessageBox.Show("จำนวนต่อแพ็คไม่ถูกต้อง", "Quantity per pack is invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else if (newProductOriginalPrice.Text == "")
            //    {
            //        MessageBox.Show("ราคาต้นทุนไม่ถูกต้อง", "Original price is invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        //TODO copy and paste
            //        double tempDouble;
            //        int tempInt;
            //        if (Double.TryParse(newProductPrice.Text, out tempDouble) &&
            //            Double.TryParse(newProductPricePerPack.Text, out tempDouble) &&
            //            Int32.TryParse(newProductInStock.Text, out tempInt) &&
            //            Int32.TryParse(newProductMin.Text, out tempInt) &&
            //            Int32.TryParse(newProductQuantityPerPack.Text, out tempInt) 
            //            )
            //        {
            //            if (newProductOriginalPrice.Text.Contains('/'))
            //            {
            //                try
            //                {
            //                    string[] temp = newProductOriginalPrice.Text.Split('/');
            //                    double pricePerPiece = Convert.ToDouble(temp[0]) / Convert.ToDouble(temp[1]);
            //                    newProductOriginalPrice.Text = newProductOriginalPrice.Text + "=" + pricePerPiece.ToString();
            //                }
            //                catch (Exception exception)
            //                {

            //                    MessageBox.Show("format ผิดพลาด ลองแค่ใส่ ราคา/จำนวน", "Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    InfoManager.LogMessage(GlobalEnums.Severity.Error, "Wrong format for original price field - have /");
            //                    return;
            //                }
            //            }
            //            else
            //            {
            //                double doubleNumber;
            //                if (!Double.TryParse(newProductOriginalPrice.Text, out doubleNumber))
            //                {
            //                    MessageBox.Show("format ผิดพลาด", "Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    InfoManager.LogMessage(GlobalEnums.Severity.Error, "Wrong format for original price field - no /");
            //                    return;
            //                }
            //            }


            //            string name = "";
            //            if (newProductName.Text != "")
            //            {
            //                name += newProductName.Text;
            //            }
            //            if (newProductName.Text != "" && newProductBrand.Text != "")
            //            {
            //                name += " ";
            //            }

            //            if (newProductBrand.Text != "")
            //            {
            //                name += newProductBrand.Text;
            //            }


            //            if (newProductFlavour.Text != "")
            //            {
            //                name += " " + newProductFlavour.Text;
            //            }

            //            if (newProductQuantity.Text != "")
            //            {
            //                name += " " + newProductQuantity.Text;
            //            }


            //            newItem = new Item(name, Convert.ToDouble(newProductPrice.Text), Convert.ToInt32(newProductInStock.Text),
            //            Convert.ToInt32(newProductMin.Text), newProductCategoryDropDown.Text, newProductOriginalPrice.Text, Double.Parse(newProductPricePerPack.Text), Int32.Parse(newProductQuantityPerPack.Text));
            //            newItem.AddItemHistory(new ItemHistory(DateTime.Now, "", "", "", GlobalEnums.HistoryStyle.Add));
            //            InfoManager.AddNewProduct(newItem);

            //            if (InfoManager.stockInMode)
            //            {
            //                stockInForm.UpdateGrid(newItem.name, "ใน stock", "0", newProductInStock.Text);
            //                stockInForm.UpdateGrid(newItem.name, "ราคาต้นทุน (จำนวน/แพ็ค)", "0", newProductInStock.Text);
            //                stockInForm.UpdateGrid(newItem.name, "ราคาต่อชิ้น", "0", newProductInStock.Text);
            //                stockInForm.UpdateGrid(newItem.name, "ราคาต่อแพ็ค", "0", newProductInStock.Text);
                            
            //            }

            //            MessageBox.Show("เพิ่มสินค้าเสร็จเรียบร้อย", "Product is now added to the stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            Close();
            //            //TODO fix this
            //            ////TODO if original blank
            //            //newProductGrid.Rows.Add(newProductCategoryDropDown.Text, name, Convert.ToDouble(newProductPrice.Text), Convert.ToDouble(newProductPricePerPack.Text), Convert.ToInt32(newProductQuantityPerPack.Text), Convert.ToInt32(newProductInStock.Text),
            //            //    Convert.ToInt32(newProductMin.Text), newProductOriginalPrice.Text);
            //            //newProductGrid.FirstDisplayedScrollingRowIndex = newProductGrid.Rows[newProductGrid.RowCount - 1].Index;
            //            //totalItems.Text = newProductGrid.RowCount.ToString();

            //            //LoadProductAutoComplete(itemTobeBoughtTextbox);
            //            //LoadProductAutoComplete(searchProductTextbox);

            //        }


            //    }
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show("format มีปัญหา", "There was a problem with the format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void LoadNewProductCategory()
        {
            foreach (var line in InfoManager.LoadType())
            {
                string[] tokens = line.Split('\n');
                newProductCategoryDropDown.Items.Add(tokens[0]);
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }

}

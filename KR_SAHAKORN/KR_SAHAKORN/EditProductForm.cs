using KR_SAHAKORN;
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
    public partial class EditProductForm : Form
    {
        public bool ignoreEvent = false;
        public Item product;
        Dictionary<string, ItemHistory> tempHistories = new Dictionary<string, ItemHistory>();
        public DateTime date;
        public StockInForm stockInForm;
     

        private void RefreshEditProductGrid()
        {
            editStockGrid.Rows.Clear();
            editProductHistoryRichTextBox.Clear();


            //TEMP SOL
            warningText.Text = "";
            if (product.name.Equals(GlobalEnums.COLD_WATER))
            {
                column_2.ReadOnly = true;
                column_5.ReadOnly = true;
                column_6.ReadOnly = true;
                column_7.ReadOnly = true;
                column_8.ReadOnly = true;
                var water = InfoManager.getItem(GlobalEnums.WATER);
                editStockGrid.Rows.Add(product.type, product.name, product.price, product.pricePerPack, water.quantityPerPack, water.instock, water.minInstock, water.originalPrice);
                warningText.Text = string.Format("ไม่สามารถเปลี่ยน '{0}' ได้ กรุณาไปที่ '{5}' ถ้าอยากเปลี่ยนข้อมูลดังต่อไปนี้\n'{4}', '{1}', '{2}', '{3}' (ชั่วคราว)", GlobalEnums.COLUMN_2, GlobalEnums.COLUMN_5, GlobalEnums.COLUMN_6, GlobalEnums.COLUMN_7, GlobalEnums.COLUMN_8, GlobalEnums.WATER);
            }
            else
            {
                if (product.name.Equals(GlobalEnums.WATER))
                {
                    column_2.ReadOnly = true;
                    warningText.Text = string.Format("ไม่สามารถเปลี่ยน '{0}' ได้ (ชั่วคราว)", GlobalEnums.COLUMN_2);
                }

                editStockGrid.Rows.Add(product.type, product.name, product.price, product.pricePerPack, product.quantityPerPack, product.instock, product.minInstock, product.originalPrice);
                
            }
         



            editStockGrid.Rows[0].Selected = false;

            foreach (ItemHistory itemh in product.getAllItemHistories())
            {
                if (itemh.style == GlobalEnums.HistoryStyle.Edit)
                {
                    editProductHistoryRichTextBox.AppendText(MessageLibrary.EDIT_ITEM(itemh.date.ToString(), itemh.field, itemh.before, itemh.after));
                }
                else if (itemh.style == GlobalEnums.HistoryStyle.Add)
                {
                    editProductHistoryRichTextBox.AppendText(MessageLibrary.ADD_ITEM(itemh.date.ToString()));
                }
                else if (itemh.style == GlobalEnums.HistoryStyle.Damaged)
                {
                    editProductHistoryRichTextBox.AppendText(MessageLibrary.DAMAGED_ITEM(itemh.date.ToString(), itemh.field, itemh.before, itemh.after));
                    editProductHistoryRichTextBox.AppendText("\n");
                }
                else
                {
                    MessageBox.Show(MessageLibrary.CODE_ERROR_MESSAGE(), MessageLibrary.CODE_ERROR_TITLE(GlobalEnums.CodeError.CE1), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public EditProductForm(Item item)
        {
            InitializeComponent();
            this.Text = item.name;
            product = item;

            editProductCategoryColumn.Items.Clear();
            foreach (var type in InfoManager.getType())
            {
                editProductCategoryColumn.Items.Add(type);
            }


            RefreshEditProductGrid();

        }

        public void setStockInForm(StockInForm stockInForm)
        {
            this.stockInForm = stockInForm;
        }

        private void saveEditStockButton_Click(object sender, EventArgs e)
        {
            foreach(ItemHistory itemh in tempHistories.Values)
            {
                if(itemh != null)
                {
                    InfoManager.setItem(product.name, itemh.after, itemh.field);
                    InfoManager.AddItemHistory(product.name, itemh);
                    if (InfoManager.stockInMode)
                    {
                        stockInForm.UpdateGrid(product.name, itemh.field, itemh.before, itemh.after);
                    }
                }
            }
            Close();
        }

        private void editStockGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0 && e.ColumnIndex >= 0 && !ignoreEvent)
            {
                string columnName = editStockGrid.Columns[e.ColumnIndex].HeaderText;
                string oldValue = null;
                string newValue = "";

                try
                {
                    newValue = editStockGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
                    switch (e.ColumnIndex)
                    {
                        case 0:
                            oldValue = product.type;
                            break;
                        case 1:
                            oldValue = product.name;
                            break;
                        case 2:
                            oldValue = product.price.ToString();
                            break;
                        case 3:
                            oldValue = product.pricePerPack.ToString();
                            break;
                        case 4:
                            oldValue = product.quantityPerPack.ToString();
                            break;
                        case 5:
                            oldValue = product.instock.ToString();
                            int number;
                            if (!Int32.TryParse(newValue, out number))
                            {
                                editStockGrid[e.ColumnIndex, e.RowIndex].Value = oldValue;
                                MessageBox.Show("format ผิดพลาด", "Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        case 6:
                            oldValue = product.minInstock.ToString();
                            break;
                        case 7:
                            oldValue = product.originalPrice.ToString();
                            if (newValue.Contains('/'))
                            {
                                try
                                {
                                    string[] temp = newValue.Split('/');
                                    double pricePerPiece = Convert.ToDouble(temp[0]) / Convert.ToDouble(temp[1]);
                                    newValue = newValue + "=" + pricePerPiece.ToString();
                                }
                                catch (Exception exception)
                                {
                                    ignoreEvent = true;
                                    editStockGrid[e.ColumnIndex, e.RowIndex].Value = oldValue;
                                    ignoreEvent = false;
                                    MessageBox.Show("format ผิดพลาด ลองแค่ใส่ ราคา/จำนวน", "Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    InfoManager.LogMessage(GlobalEnums.Severity.Error, "Wrong format for original price field - have /");
                                    return;
                                }
                            }
                            else
                            {
                                double doubleNumber;
                                if (!Double.TryParse(newValue, out doubleNumber))
                                {
                                    editStockGrid[e.ColumnIndex, e.RowIndex].Value = oldValue;
                                    MessageBox.Show("format ผิดพลาด", "Invalid format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    InfoManager.LogMessage(GlobalEnums.Severity.Error, "Wrong format for original price field - no /");
                                    return;
                                }
                            }

                            break;
                    }

                    if (oldValue != null)
                    {
                        tempHistories[columnName] = new ItemHistory(DateTime.Now, oldValue, newValue, columnName, GlobalEnums.HistoryStyle.Edit);
                    }
                    else
                    {
                        InfoManager.LogMessage(GlobalEnums.Severity.Error, "oldValue is null when trying to set item history");
                    }
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show(MessageLibrary.FORMAT_ERROR.description, MessageLibrary.FORMAT_ERROR.title, MessageBoxButtons.OK, MessageLibrary.FORMAT_ERROR.severity); 
                }
           

            }

        }


        private void removeProductButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("คุณแน่ใจนะ?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult.Equals(DialogResult.OK))
            {
                InfoManager.RemoveProduct(product.name);
                Close();
            }
        }


        private void damagedProduct_Click(object sender, EventArgs e)
        {
            var valid = false;
            if(tempHistories.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("ข้อมูลที่ใส่มาจะถูกลบถ้าคุณไม่เซฟ คุณแน่ใจนะ", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dialogResult.Equals(DialogResult.OK))
                {
                    valid = true;
                }
            }
            else
            {
                valid = true;
            }

            if (valid)
            {
                tempHistories.Clear();
                DamagedProductForm damagedProductForm = new DamagedProductForm(product);
                {
                    var result = damagedProductForm.ShowDialog();
                    if (result == DialogResult.Cancel)
                    {
                        RefreshEditProductGrid();
                    }
                }
            }
     
            
        }
    }

}

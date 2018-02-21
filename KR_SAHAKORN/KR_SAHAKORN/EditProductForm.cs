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

     
        public EditProductForm(Item item)
        {
            InitializeComponent();

            editProductCategoryColumn.Items.Clear();
            foreach (var type in InfoManager.getType())
            {
                editProductCategoryColumn.Items.Add(type);
            }

            editStockGrid.Rows.Add(item.type, item.name, item.price, item.pricePerPack, item.quantityPerPack, item.instock, item.minInstock, item.originalPrice);
            editStockGrid.Rows[0].Selected = false;
            foreach (ItemHistory itemh in item.getAllItemHistories())
            {
                if(itemh.style == GlobalEnums.HistoryStyle.Edit)
                {
                    editProductHistoryRichTextBox.AppendText(MessageLibrary.EDIT_ITEM(itemh.date.ToString(), itemh.field, itemh.before, itemh.after));
                }
                else
                {
                    editProductHistoryRichTextBox.AppendText(MessageLibrary.ADD_ITEM(itemh.date.ToString()));
                }
             
            }
  
            this.product = item;
        }

        private void saveEditStockButton_Click(object sender, EventArgs e)
        {
            foreach(ItemHistory itemh in tempHistories.Values)
            {
                if(itemh != null)
                {
                    InfoManager.setItem(product.name, itemh.after, itemh.field);
                    InfoManager.AddItemHistory(product.name, itemh);
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
                string newValue = editStockGrid[e.ColumnIndex, e.RowIndex].Value.ToString();
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
                        if (newValue.Contains('/')){
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
    }

}

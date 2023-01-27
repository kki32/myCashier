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
    public partial class DamagedProductForm : Form
    {
        private Item product;
        public DamagedProductForm(Item item)
        {
            InitializeComponent();
            product = item;
            this.Text = "สินค้าเสีย";
        }


        private void selectEtc_CheckedChanged(object sender, EventArgs e)
        {
            EtcTextBox.Enabled = etcRadioButton.Checked;
            EtcTextBox.Text = "";
        }

        private void confirmDamagedProductButton_Click(object sender, EventArgs e)
        {
            var reason = "";
            var selectedRadioButtons = groupBox1.Controls.OfType<RadioButton>()
                           .FirstOrDefault(n => n.Checked);
            if (selectedRadioButtons != null)
            {
                if (selectedRadioButtons.Text.Equals(""))
                {
                    if(EtcTextBox.Text != "")
                    {
                        reason = EtcTextBox.Text;
                    }
                }
                else
                {
                    reason = selectedRadioButtons.Text;
                }
            }
    

            if (reason.Equals(""))
            {
                MessageBox.Show("โปรดระบุเหตุผล", "Reason", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("คุณแน่ใจนะ?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dialogResult.Equals(DialogResult.OK))
                {
                    var before = product.instock;
                    InfoManager.AddDamagedProduct(product.name, Convert.ToInt32(damagedQuantity.Value));
                    var after = product.instock;
                    InfoManager.AddItemHistory(product.name, new ItemHistory(DateTime.Now, before.ToString(), after.ToString(), reason, GlobalEnums.HistoryStyle.Damaged));
          
                    Close();
                }

              }
        }
    }
}

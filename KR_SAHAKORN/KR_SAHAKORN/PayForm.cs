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
    public partial class PayForm : Form
    {
        private double totalCost = 0.0;

        public PayForm(double totalCost)
        {
            InitializeComponent();
            this.Text = "ชำระสินค้า";
            totalCostLabel.Text = totalCost.ToString();
            this.totalCost = totalCost;
        }

        private void confirmToPayButton_Click(object sender, EventArgs e)
        {
            if (payByCashRadioButton.Checked || payBySignRadioButton.Checked )
            {
                if (payByCashRadioButton.Checked)
                {

                    double pay = 0;
                    Double.TryParse(payTextBox.Text.ToString(), out pay);
                    double leftOver = pay - totalCost;
                    if (leftOver >= 0)
                    {
                        InfoManager.currentTransaction.setGiven(pay);

                        MessageBox.Show("ทอน " + leftOver.ToString(), "Left over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("เงินไม่พอ", "Not enough money", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    InfoManager.currentTransaction.setIsCash(true);
                }
                else
                {
                    MessageBox.Show("เสร็จเรียบร้อย", "Transaction is completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InfoManager.currentTransaction.setIsCash(false);
                }

                InfoManager.currentTransaction.setIsCompleted(true);
                payByCashRadioButton.Checked = true;
                payBySignRadioButton.Checked = false;
                payTextBox.Clear();
                this.Close();

            }
            else
            {
                MessageBox.Show("เลือกวิธีชำระเงิน", "Please choose one method", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void selectCash_CheckedChanged(object sender, EventArgs e)
        {
            if (payByCashRadioButton.Checked)
            {
                payTextBox.Enabled = true;
                givenLabel.Enabled = true;
            }
            else
            {
                payTextBox.Enabled = false;
                givenLabel.Enabled = false;
            }
        }
    }
}

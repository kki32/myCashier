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
            MessageBox.Show("เสร็จเรียบร้อย", "Transaction is completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InfoManager.currentTransaction.setIsCash(false);
   
            InfoManager.currentTransaction.setIsCompleted(true);
            this.Close();
        }
    }
}

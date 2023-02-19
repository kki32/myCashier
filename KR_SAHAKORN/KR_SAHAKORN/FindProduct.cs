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
    public partial class FindProduct : Form
    {
        MainForm mainForm;
        public FindProduct(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            mainForm.LoadGenericStockGrid(findProductsGrid);
            totalItems.Text = findProductsGrid.RowCount.ToString();
        }

        private void AddProductFromBrowse_Click(object sender, EventArgs e)
        {
            List<Item> products = new List<Item>();

            foreach (DataGridViewRow selected in findProductsGrid.SelectedRows)
            {
                products.Add(InfoManager.getItem(selected.Cells["productName"].Value.ToString()));
            }
            mainForm.addSelectedProductsToSellGrid(products);
            this.Close();
        }

        private void findProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Item> products = new List<Item>();

            foreach (DataGridViewRow selected in findProductsGrid.SelectedRows)
            {
                products.Add(InfoManager.getItem(selected.Cells["productName"].Value.ToString()));
            }
            mainForm.addSelectedProductsToSellGrid(products);
            this.Close();
        }
    }
}

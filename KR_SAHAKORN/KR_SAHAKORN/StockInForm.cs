using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO:
//field name into enum
//observable pattern
//messages have its own class
//separate logics, not all in infomanager
//naming variable
//writing unit tests


namespace KR_SAHAKORN
{
    public partial class StockInForm : Form
    {
        public StockInForm()
        {
            InitializeComponent();
            InfoManager.stockInMode = true;
            InfoManager.LoadStockIn();
            UpdateGrid();
            
        }

        delegate void UpdateGridVoidDelegate(string item, string field, string before, string after);

        public void UpdateGrid()
        {
            stockInGrid.Rows.Clear();
            Dictionary<string, List<string>> stockInOnTheDate = InfoManager.GetStockIn(stockInDateTimePicker.Value.Date);
            if(stockInOnTheDate != null)
            {
                foreach (string item in stockInOnTheDate.Keys)
                {
                    stockInGrid.Rows.Add(item, stockInOnTheDate[item][0], stockInOnTheDate[item][1],
           stockInOnTheDate[item][2], stockInOnTheDate[item][3]);
                }
            }
   
        }
        public void UpdateGrid(string item, string field, string before, string after)
        {
            if (stockInGrid.InvokeRequired)
            {
                UpdateGridVoidDelegate d = new UpdateGridVoidDelegate(UpdateGrid);
                this.Invoke(d, new object[] { item, field, before, after });
            }
            else
            {
        
                InfoManager.AddStockIn(stockInDateTimePicker.Value.Date, item, field, before, after);
                List<string> infos = InfoManager.GetStockInForSpecificItem(stockInDateTimePicker.Value.Date, item);

                if (infos != null)
                {
                        //TODO name change affects this?
                        bool found = false;
                        foreach (DataGridViewRow row in stockInGrid.Rows)
                        {
                            if (row.Cells[0].Value.Equals(item))
                            {
                                found = true;

                                row.Cells[0].Value = item;
                                row.Cells[1].Value = infos[0];
                                row.Cells[2].Value = infos[1];
                                row.Cells[3].Value = infos[2];
                                row.Cells[4].Value = infos[3];
                                break;
                            }
                        }

                        if (!found)
                        {
                            stockInGrid.Rows.Add(item, infos[0], infos[1], infos[2], infos[3]);
                        }    
                }
            }
        }

        private void stockInDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}

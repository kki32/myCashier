using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;           // MUST download JSON using NUGet package
using System.Threading;

namespace KR_SAHAKORN
{
	public partial class MainForm : Form
	{
		private object tempValue;
		private bool ignoreEvent = false;
		private StockInForm stockInForm = null;
		public MainForm()
		{

			InitializeComponent();
			this.Text = "KR SAHAKORN v.2023.2.19";

			//LOGIC
			InfoManager.LoadType();
			InfoManager.LoadStock();
			InfoManager.LoadBuyerNames();
			//InfoManager.LoadCashbook();
			InfoManager.LoadSignbook();
			InfoManager.LoadCurrentRefId();
			InfoManager.LoadAccounting();

			//GUI
			LoadSellPage();
			//LoadCashbookGrid();
			LoadSignbookPage();
			LoadStockPage();
			LoadEtcPage();
		}

		private void LoadSellPage()
		{
			LoadBuyerNameComboBox(buyerNameComboBox, false);
			ResetTransactionView(true);
		}

		private void LoadSignbookPage()
		{
			signbookDateTimePickerFrom.Value = InfoManager.getMondayOfThisWeek();
			signbookDateTimePickerTo.Value = signbookDateTimePickerFrom.Value.AddDays(6);

			LoadBuyerNameComboBox(buyerNameComboBoxInSignBook);
			InfoManager.LoadSignbook();
			LoadSignbookGrid();
		}

		private void LoadAccountingGrid()
		{
			//reconciliationGrid.Rows.Clear();

			//var temp = new DateTime(accountingDateTimePicker.Value.Year, accountingDateTimePicker.Value.Month, 1);
			//var firstDayOfTheMonth = new DateTime(accountingDateTimePicker.Value.Year, accountingDateTimePicker.Value.Month, 1);
			//var lastDayOfTheMonth = temp.AddMonths(1).AddDays(-1);
			//if (DateTime.Today.Date < lastDayOfTheMonth)
			//{
			//    lastDayOfTheMonth = DateTime.Today;
			//}

			//foreach (DateTime day in InfoManager.EachDay(firstDayOfTheMonth, lastDayOfTheMonth))
			//{
			//    double costPerDay = 0;

			//    foreach (Transaction t in InfoManager.getCashBook())
			//    {
			//        if (day.Date == t.date.Date)
			//        {
			//            costPerDay += t.finalTotalCost;
			//        }
			//    }

			//    var date = day.ToString();
			//    //var got = InfoManager.getTotalReconciliation(day);
			//    var received = InfoManager.getReceived(day);
			//    var paid = InfoManager.getPaid(day);
			//    reconciliationGrid.Rows.Add(date, costPerDay, received, received - costPerDay, paid, received - paid);


			//}
			//updateTotalReconciliationGrid();
		}

		private void itemToBeBoughtTextbox_Click(object sender, EventArgs e)
		{
			// clear graytext watermark
			if (itemTobeBoughtTextbox.Text.Length > 0 && itemTobeBoughtTextbox.Text == "ชื่อสินค้า")
			{
				itemTobeBoughtTextbox.ForeColor = SystemColors.WindowText;
				itemTobeBoughtTextbox.Text = "";
			}
		}

		//private void LoadCashbookGrid()
		//{
		//    cashBookGrid.Rows.Clear();
		//    foreach (Transaction trans in InfoManager.getCashBook())
		//    {
		//        foreach (BoughtItem b in trans.bought)
		//        {
		//            var from = Convert.ToDateTime(fromDateTimePicker.Value);
		//            var to = Convert.ToDateTime(toDateTimePicker.Value);

		//            if (trans.date.Date <= to.Date && trans.date.Date >= from.Date)
		//            {
		//                cashBookGrid.Rows.Add(trans.id, trans.date, b.buyer, b.item.name, b.quantity, b.item.price, b.item.totalPrice, b.totalCost,
		// trans.finalTotalCost, trans.given, trans.leftOver);
		//            }
		//        }
		//    }
		//    cashBookGrid.Sort(cashBookGrid.Columns[InfoManager.DATE_COL], ListSortDirection.Ascending);

		//    var authenticated = InfoManager.authenticateCashbook;
		//    foreach (DataGridViewColumn dc in cashBookGrid.Columns)
		//    {
		//        dc.ReadOnly = !authenticated;
		//    }
		//    cashBookGrid.Refresh();
		//    cashBookGrid.Update();

		//}

		private void findItemButton_Click(object sender, EventArgs e)
		{
			FindProduct findProductForm = new FindProduct(this);
			{
				findProductForm.ShowDialog();
			}
			// go to Form2.cs
		}

		public void addSelectedProductsToSellGrid(List<Item> selectedProducts)
		{
			string errorMessage = "";
			List<string> error = null;

			foreach (Item product in selectedProducts)
			{
				error = addSellGrid(product, true);
				if (error.Count() > 0)
				{
					errorMessage += product.name + "\n";
				}

			}

			if (errorMessage != "")
			{
				MessageBox.Show("ไม่พอ stock ไม่ตรง ควรเช็คใหม่สำหรับ\n" + errorMessage, error[1], MessageBoxButtons.OK, MessageBoxIcon.Information);
			}



		}

		private List<string> addSellGrid(Item item, bool browseMode = false)
		{
			List<string> error = new List<string>();
			//validate have enough
			int existedRow = -1;
			foreach (DataGridViewRow existing in sellGrid.Rows)
			{
				if (item.name.Equals(existing.Cells[InfoManager.NAME_COL].Value))
				{
					existedRow = existing.Index;
					break;
				}
			}
			int addedQuantity = 0;
			if (browseMode)
			{
				addedQuantity = 1;
			}
			else
			{
				addedQuantity = Convert.ToInt32(amountNumericUpDown.Value);
			}


			if (existedRow >= 0) //already in the sell grid
			{
				var existingQuantity = sellGrid.Rows[existedRow].Cells[InfoManager.QUANTITY_COL];
				addedQuantity = Convert.ToInt32(existingQuantity.Value) + Convert.ToInt32(addedQuantity);
				existingQuantity.Value = addedQuantity;

				var existingTotal = sellGrid.Rows[existedRow].Cells[InfoManager.TOTAL_COL];
				existingTotal.Value = item.price * addedQuantity;
			}
			else
			{
				sellGrid.Rows.Add(item.name, addedQuantity, item.price.ToString(), item.price * addedQuantity);
			}
			return error;
		}

		public void addToSystemButton_Click(object sender, EventArgs e)
		{
			// check item in stock
			if (!InfoManager.containsItem(itemTobeBoughtTextbox.Text))
			{
				MessageBox.Show("หาไม่เจอ", "Cannot be found", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				var error = addSellGrid(InfoManager.getItem(itemTobeBoughtTextbox.Text));
				if (error.Count() > 0)
				{
					MessageBox.Show(error[0], error[1], MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				itemTobeBoughtTextbox.Text = "";
				amountNumericUpDown.Value = 1;
			}
		}

		private void payButton_Click(object sender, EventArgs e)
		{
			if (buyerNameComboBox.Text == "")
			{
				MessageBox.Show("เลือกผู้ซื้อ", "Please choose buyer", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				InfoManager.currentTransaction = new Transaction();
				foreach (DataGridViewRow Datarow in sellGrid.Rows)
				{
					var cost = 0.0;
					var quantity = 0;
					Double.TryParse(Datarow.Cells[InfoManager.PRICE_COL].Value.ToString(), out cost);
					Int32.TryParse(Datarow.Cells[InfoManager.QUANTITY_COL].Value.ToString(), out quantity);
					InfoManager.currentTransaction.AddItem(new BoughtItem(InfoManager.getItem(Datarow.Cells[InfoManager.NAME_COL].Value.ToString()),
					  quantity,
					  buyerNameComboBox.Text));
				}


				if (sellGrid.Rows.Count > 0)
				{

					var payForm = new PayForm(InfoManager.currentTransaction.finalTotalCost);
					{
						payForm.ShowDialog();

						if (InfoManager.currentTransaction.isCompleted)
						{
							if (sellDatePicker.Value.Date == DateTime.Today.Date)
							{
								InfoManager.currentTransaction.date = DateTime.Now;

							}
							else
							{
								InfoManager.currentTransaction.date = sellDatePicker.Value.Date;

							}
							InfoManager.SaveCurrentTransactionToCashbook();

							LoadAccountingGrid();
							ResetTransactionView(false);
							LoadGenericStockGrid(stockGrid);
						}

					}
				}
				else
				{
					MessageBox.Show("ไม่มีสินค้า", "No product", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}


		private double LoadSignbookFor(string buyer, double total = 0)
		{
			foreach (Transaction trans in InfoManager.getSignTransaction(buyer))
			{
				if (trans.date.Date >= signbookDateTimePickerFrom.Value.Date && trans.date.Date <= signbookDateTimePickerTo.Value.Date)
				{
					foreach (BoughtItem b in trans.bought)
					{
						signBookGrid.Rows.Add(trans.id, b.buyer, trans.date, b.item.name, b.quantity, b.item.price, b.totalCost);
					}
					total += trans.finalTotalCost;
				}
			}
			return total;

		}
		#region initialize or reset fields

		private void LoadBuyerNameComboBox(ComboBox c, bool includeEveryone = true)
		{
			c.DropDownHeight = c.MaxDropDownItems * c.ItemHeight;
			c.Items.Clear();

			// Buyer's name in combobox
			foreach (var line in InfoManager.LoadBuyerNames())
			{
				string[] tokens = line.Split('\n');
				if (!(tokens[0] == "ทุกคน" && !includeEveryone))
					c.Items.Add(tokens[0]);
			}
		}

		private void LoadGenericStockAutoComplete(TextBox textBox)
		{
			//SuggestStrings will have the logic to return array of strings either from cache/db
			AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
			collection.AddRange(InfoManager.getStockKeys());
			textBox.AutoCompleteCustomSource = collection;
		}

		private void ResetTransactionView(bool resetDate)
		{
			AllowQuantityEditable();
			buyerNameComboBox.SelectedItem = null;
			itemTobeBoughtTextbox.Clear();
			LoadGenericStockAutoComplete(itemTobeBoughtTextbox);
			amountNumericUpDown.Text = "1";
			if (resetDate)
				sellDatePicker.Text = DateTime.Today.ToString();
			sellGrid.Rows.Clear();
			sellGrid.Refresh();
		}

		#endregion

		#region sign book tab

		private void LoadSignbookGrid()
		{
			if (buyerNameComboBoxInSignBook.Text != "")
			{
				double total = 0;
				signBookGrid.Rows.Clear();
				if (buyerNameComboBoxInSignBook.Text == InfoManager.EVERYONE)
				{
					foreach (string buyer in InfoManager.LoadBuyerNames())
					{
						if (buyer != InfoManager.EVERYONE)
						{
							total = LoadSignbookFor(buyer, total);
						}

					}
				}
				else
				{
					total = LoadSignbookFor(buyerNameComboBoxInSignBook.Text);
				}
				signBookGrid.Sort(signBookGrid.Columns[InfoManager.ID_COL], ListSortDirection.Descending);
				buyerTotal.Text = total.ToString();

			}
			else
			{
				buyerNameComboBoxInSignBook.Text = InfoManager.EVERYONE;
			}
		}


		private void BuyerSign_SelectedValueChanged(object sender, EventArgs e)
		{
			LoadSignbookGrid();
		}

		#endregion


		#region etc page
		private void UnselectedOption()
		{
			needToBuyGrid.Visible = false;
			addNewBuyerGroupBox.Visible = false;
			totalLabelGroupBoxInEtcTab.Visible = false;
			accountingGroupbox.Visible = false;
		}



		public void LoadGenericStockGrid(DataGridView grid)
		{

			grid.Rows.Clear();

			foreach (Item item in InfoManager.getStockItems())
			{
				grid.Rows.Add(item.type, item.name, item.price, item.instock, Item.GetOriginalCost(item), item.profit, item.location);
			}

			grid.Sort(grid.Columns[1], ListSortDirection.Ascending);

		}


		private void LoadEtcPage()
		{
			UnselectedOption();
			LoadAccountingGrid();
		}

		private void LoadStockPage()
		{
			LoadGenericStockGrid(stockGrid);
			LoadGenericStockAutoComplete(searchProductTextbox);

			totalLabelForStockTab.Text = stockGrid.RowCount.ToString();
		}
		#endregion


		#region etc tab
		private void etcComboBox_TextChanged(object sender, EventArgs e)
		{
			UnselectedOption();
			switch (etcComboBox.Text)
			{
				case "":
					MessageBox.Show("เลือก", "Please choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				case "เพิ่มคนซื้อ":
					addNewBuyerGroupBox.Visible = true;
					break;
				case "ดู stock ที่ขาด":
					needToBuyGrid.Visible = true;
					totalLabelGroupBoxInEtcTab.Visible = true;
					needToBuyGrid.Rows.Clear();
					foreach (Item i in InfoManager.getStockItems())
					{
						if (i.instock <= i.minInstock)
						{
							needToBuyGrid.Rows.Add(i.name, i.price, i.instock, i.minInstock);
						}
					}
					totalItems.Text = needToBuyGrid.RowCount.ToString();
					break;
				case "ตัดวัน/ดูยอดเงินสด":
					InfoManager.authenticate = false;
					accountingGroupbox.Visible = true;

					break;
			}


		}
		#endregion


		private void AllowQuantityEditable()
		{

			foreach (DataGridViewColumn dc in sellGrid.Columns)
			{
				if (dc.Index.Equals(1) || dc.Index.Equals(2))
				{
					dc.ReadOnly = false;
				}
				else
				{
					dc.ReadOnly = true;
				}
			}

		}

		private void cancelItem_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow selected in sellGrid.SelectedRows)
			{
				sellGrid.Rows.Remove(selected);
			}
		}

		private void addNewBuyer_Click(object sender, EventArgs e)
		{
			bool existed = false;
			foreach (string buyer in InfoManager.LoadBuyerNames())
			{
				if (buyer.Equals(newBuyerTextInput.Text))
				{
					existed = true;
					break;
				}
			}
			if (!existed)
			{
				InfoManager.AddNewBuyer(newBuyerTextInput.Text);


				LoadBuyerNameComboBox(buyerNameComboBox, false);
				LoadBuyerNameComboBox(buyerNameComboBoxInSignBook);
				newBuyerTextInput.Text = "";
				MessageBox.Show("เสร็จเรียบร้อย", "Thank you for waiting", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				MessageBox.Show("มีแล้ว", "Already existed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void tab_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tab.SelectedTab.Text == "สมุดเซ็น" && buyerNameComboBoxInSignBook.Text != "")
			{
				LoadSignbookGrid();
			}
		}


		private void sellGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			//TODO
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				if (e.ColumnIndex == 2)
				{
					string item = sellGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
					//if (Convert.ToInt32(sellGrid.Rows[e.RowIndex].Cells[2].Value) > InfoManager.getItem(item).instock)
					//{
					//    sellGrid.Rows[e.RowIndex].Cells[2].Value = 1;
					//    MessageBox.Show("ไม่พอ", "Not enough", MessageBoxButtons.OK, MessageBoxIcon.Error);

					//}
				}
			}
		}

		private void selectedMonth_ValueChanged(object sender, EventArgs e)
		{
			LoadSignbookGrid();
		}

		private void changeProductInfo_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{

		}

		private void changeProductInfo_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			tempValue = stockGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
		}


		private void findProductButton_Click(object sender, EventArgs e)
		{
			stockGrid.ClearSelection();
			foreach (DataGridViewRow row in stockGrid.Rows)
			{
				if (row.Cells[1].Value.Equals(searchProductTextbox.Text))
				{
					stockGrid.Rows[row.Index].Selected = true;
					stockGrid.FirstDisplayedScrollingRowIndex = stockGrid.SelectedRows[0].Index;
					stockGrid_CellClick(sender, new DataGridViewCellEventArgs(0, row.Index));
					break;
				}
			}
		}

		private void gotCash_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				if (e.ColumnIndex == 2) //รายรับ
				{
					double received = Convert.ToDouble(reconciliationGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					var t = Convert.ToDateTime(reconciliationGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
					// t = Convert.ToDateTime(t.ToString(InfoManager.DATE_FORMAT));
					InfoManager.SaveReceivedToAccounting(t, received);
					double expected = Convert.ToDouble(reconciliationGrid.Rows[e.RowIndex].Cells[1].Value);
					reconciliationGrid.Rows[e.RowIndex].Cells[3].Value = received - expected;
					double paid = Convert.ToDouble(reconciliationGrid.Rows[e.RowIndex].Cells[4].Value);

					reconciliationGrid.Rows[e.RowIndex].Cells[5].Value = received - paid;

					//TODO log message
				}
				/*if (e.ColumnIndex == 4) 
                {
                    double received = Convert.ToDouble(reconciliationGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    var t = Convert.ToDateTime(reconciliationGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    
                    InfoManager.SaveReceivedToAccounting(t, received);
                    double paid = Convert.ToDouble(reconciliationGrid.Rows[e.RowIndex].Cells[5].Value);
                    reconciliationGrid.Rows[e.RowIndex].Cells[5].Value = received - paid;
          //TODO log message
                }*/
				if (e.ColumnIndex == 4)//รายจ่าย
				{
					double paid = Convert.ToDouble(reconciliationGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					var t = Convert.ToDateTime(reconciliationGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

					InfoManager.SavePaidToAccounting(t, paid);
					double received = Convert.ToDouble(reconciliationGrid.Rows[e.RowIndex].Cells[2].Value);
					reconciliationGrid.Rows[e.RowIndex].Cells[5].Value = received - paid;
				}

				updateTotalReconciliationGrid();
			}
		}

		private void updateTotalReconciliationGrid()
		{
			var total = 0.0;
			foreach (DataGridViewRow row in reconciliationGrid.Rows)
			{
				total += Convert.ToDouble(row.Cells[5].Value);
			}
			totalReconciliationLabelResult.Text = total.ToString();

		}

		private void accountingDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			LoadAccountingGrid();
		}

		private void gotCash_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			/*
            if (e.ColumnIndex == 2 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                /*
                tempValue = reconciliationGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (InfoManager.authenticate)
                {
                */
			// reconciliationGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;

			/*}
            else
            {
                Authentication authenticationForm = new Authentication("etcPage");
                {
                    authenticationForm.ShowDialog();
                }
            }

        }    */


		}

		private void searchProductTextbox_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if (ch == '\n')
			{
				findProductButton_Click(sender, e);
			}

		}

		private void signbookChangeOrDeleteButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("คุณแน่ใจนะ?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (dialogResult.Equals(DialogResult.OK))
			{
				foreach (DataGridViewRow selected in signBookGrid.SelectedRows)
				{
					InfoManager.RemoveSignbookEntry(selected.Cells[1].Value.ToString(), Convert.ToInt32(selected.Cells[0].Value));

					List<DataGridViewRow> RowsToDelete = new List<DataGridViewRow>();
					foreach (DataGridViewRow row in signBookGrid.Rows)
					{
						if (selected.Cells[0].Value.Equals(row.Cells[0].Value))
						{
							RowsToDelete.Add(row);
						}

					}
					foreach (DataGridViewRow row in RowsToDelete) signBookGrid.Rows.Remove(row);
				}
				LoadGenericStockGrid(stockGrid);
				LoadSignbookGrid();
			}
		}



		private void signbookToDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			LoadSignbookGrid();
		}

		private void signbookFromDateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			LoadSignbookGrid();
		}




		private void stockGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				string productName = stockGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

				if (InfoManager.containsItem(productName))
				{
					EditProductForm editProductForm = new EditProductForm(InfoManager.getItem(productName));
					editProductForm.setStockInForm(stockInForm);
					editProductForm.ShowDialog();

					productName = editProductForm.product.name;
					if (InfoManager.containsItem(productName))
					{
						var item = InfoManager.getItem(productName);
						stockGrid.Rows[e.RowIndex].SetValues(item.type, item.name, item.price, item.totalPrice, item.quantityPerPack, item.instock, item.minInstock, item.originalPrice, item.message);
					}
					else
					{
						stockGrid.Rows.RemoveAt(stockGrid.Rows[e.RowIndex].Index);
						totalLabelForStockTab.Text = stockGrid.RowCount.ToString();
					}
					LoadGenericStockAutoComplete(itemTobeBoughtTextbox);
					LoadGenericStockAutoComplete(searchProductTextbox);
				}
			}

		}

		private void addProductButton_Click(object sender, EventArgs e)
		{
			AddProductForm addProductForm = new AddProductForm();
			addProductForm.setStockInForm(stockInForm);
			addProductForm.ShowDialog();

			if (addProductForm.newItem != null)
			{
				stockGrid.Rows.Add(addProductForm.newItem.type, addProductForm.newItem.name, addProductForm.newItem.price, addProductForm.newItem.totalPrice, addProductForm.newItem.quantityPerPack, addProductForm.newItem.instock, addProductForm.newItem.minInstock, addProductForm.newItem.originalPrice);
				stockGrid.Rows[stockGrid.Rows.Count - 1].Selected = true;
				stockGrid.FirstDisplayedScrollingRowIndex = stockGrid.SelectedRows[0].Index;

				totalLabelForStockTab.Text = stockGrid.RowCount.ToString();

				LoadGenericStockAutoComplete(itemTobeBoughtTextbox);
				LoadGenericStockAutoComplete(searchProductTextbox);
			}

		}

		private void OpenStockInForm()
		{
			if (stockInForm == null)
			{
				//todo use datasource for stockin to help updating data
				stockInForm = new StockInForm();
				stockInForm.ShowDialog();
				stockInForm = null;
				InfoManager.stockInMode = false;
			}
			else
			{
				MessageBox.Show("กำลังจดเข้า stock", "Currently doing stock in", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void stockInButton_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ThreadStart(OpenStockInForm));
			thread.Start();
		}

		private void exportStock_Click(object sender, EventArgs e)
		{
			try
			{
				var file = FileHelper.ExportStockCsv();
				MessageBox.Show(string.Format(MessageLibrary.EXPORT_STOCK_SUCCESSFUL.description, file), MessageLibrary.EXPORT_STOCK_SUCCESSFUL.title, MessageBoxButtons.OK, MessageLibrary.EXPORT_STOCK_SUCCESSFUL.severity);
			}
			catch (Exception exception)
			{
				MessageBox.Show(MessageLibrary.EXPORT_ERROR(), MessageLibrary.CODE_ERROR_TITLE(GlobalEnums.CodeError.CE3), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void importStockBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var file = FileHelper.ImportStockCsv();
				itemTobeBoughtTextbox.Clear();
				LoadGenericStockAutoComplete(itemTobeBoughtTextbox);
				MessageBox.Show(string.Format(MessageLibrary.EXPORT_STOCK_SUCCESSFUL.description, file), MessageLibrary.EXPORT_STOCK_SUCCESSFUL.title, MessageBoxButtons.OK, MessageLibrary.EXPORT_STOCK_SUCCESSFUL.severity);
			}
			catch (Exception exception)
			{
				MessageBox.Show(MessageLibrary.IMPORT_ERROR(), MessageLibrary.CODE_ERROR_TITLE(GlobalEnums.CodeError.CE3), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void exportSignBookButton_Click(object sender, EventArgs e)
		{
			try
			{
				var file = FileHelper.ExportSignBookCsv(buyerNameComboBoxInSignBook.Text, signbookDateTimePickerFrom.Value.Date, signbookDateTimePickerTo.Value.Date);
				MessageBox.Show(string.Format(MessageLibrary.EXPORT_SIGN_BOOK_SUCCESSFUL.description, file), MessageLibrary.EXPORT_STOCK_SUCCESSFUL.title, MessageBoxButtons.OK, MessageLibrary.EXPORT_STOCK_SUCCESSFUL.severity);
			}
			catch (Exception exception)
			{
				MessageBox.Show(MessageLibrary.EXPORT_ERROR(), MessageLibrary.CODE_ERROR_TITLE(GlobalEnums.CodeError.CE3), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
/* References 
 https://stackoverflow.com/questions/5964545/how-to-fill-combobox-with-text-file-item
 https://stackoverflow.com/questions/10187963/selecting-an-item-in-combobox-by-typing
 https://stackoverflow.com/questions/19466805/set-default-format-of-datetimepicker-as-dd-mm-yyyy
 https://stackoverflow.com/questions/18497130/watermark-for-textbox    
 https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
 https://stackoverflow.com/questions/11769890/show-a-new-form-when-click-a-button
 https://stackoverflow.com/questions/9526159/json-deserialization-how-to-get-values-out-of-a-json-array-of-objects


*/

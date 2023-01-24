using System.Windows.Forms;

namespace KR_SAHAKORN
{
    partial class MainForm
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
            this.sellGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab = new System.Windows.Forms.TabControl();
            this.sellTab = new System.Windows.Forms.TabPage();
            this.sellDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sellDateLabel = new System.Windows.Forms.Label();
            this.cancelItem = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.buyerNameComboBox = new System.Windows.Forms.ComboBox();
            this.findItemButton = new System.Windows.Forms.Button();
            this.addToSystemButton = new System.Windows.Forms.Button();
            this.buyerLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemTobeBoughtTextbox = new System.Windows.Forms.TextBox();
            this.cashTab = new System.Windows.Forms.TabPage();
            this.cashbookChangeOrDeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cashBookGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ให้เป = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignTab = new System.Windows.Forms.TabPage();
            this.exportSignBookButton = new System.Windows.Forms.Button();
            this.signbookChangeOrDeleteButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.signbookDateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.buyerTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signbookDateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buyerNameComboBoxInSignBook = new System.Windows.Forms.ComboBox();
            this.signBookGrid = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTab = new System.Windows.Forms.TabPage();
            this.importStockBtn = new System.Windows.Forms.Button();
            this.exportStock = new System.Windows.Forms.Button();
            this.searchProductTextbox = new System.Windows.Forms.TextBox();
            this.findProductButton = new System.Windows.Forms.Button();
            this.totalLabelForStockTab = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.addToStockButton = new System.Windows.Forms.Button();
            this.stockGrid = new System.Windows.Forms.DataGridView();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newProductGridTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtcTab = new System.Windows.Forms.TabPage();
            this.totalLabelGroupBoxInEtcTab = new System.Windows.Forms.GroupBox();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.totalItems = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.etcComboBox = new System.Windows.Forms.ComboBox();
            this.accountingGroupbox = new System.Windows.Forms.GroupBox();
            this.totalReconciliationLabelResult = new System.Windows.Forms.Label();
            this.totalReconciliationLabel = new System.Windows.Forms.Label();
            this.reconciliationGrid = new System.Windows.Forms.DataGridView();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addNewBuyerGroupBox = new System.Windows.Forms.GroupBox();
            this.newBuyerTextInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.needToBuyGrid = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.sellGrid)).BeginInit();
            this.tab.SuspendLayout();
            this.sellTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.cashTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookGrid)).BeginInit();
            this.SignTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signBookGrid)).BeginInit();
            this.stockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).BeginInit();
            this.EtcTab.SuspendLayout();
            this.totalLabelGroupBoxInEtcTab.SuspendLayout();
            this.accountingGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconciliationGrid)).BeginInit();
            this.addNewBuyerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.needToBuyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // sellGrid
            // 
            this.sellGrid.AllowUserToAddRows = false;
            this.sellGrid.AllowUserToDeleteRows = false;
            this.sellGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.sellGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sellGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.totalCostColumn});
            this.sellGrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellGrid.Location = new System.Drawing.Point(17, 239);
            this.sellGrid.Margin = new System.Windows.Forms.Padding(4);
            this.sellGrid.Name = "sellGrid";
            this.sellGrid.RowHeadersWidth = 51;
            this.sellGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellGrid.Size = new System.Drawing.Size(1084, 331);
            this.sellGrid.TabIndex = 8;
            this.sellGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellGrid_CellContentClick);
            this.sellGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellGrid_CellValueChanged);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 148.834F;
            this.Column2.HeaderText = "รายการสินค้า";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "จำนวน";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 30F;
            this.Column4.HeaderText = "ราคาต่อชิ้น";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // totalCostColumn
            // 
            this.totalCostColumn.HeaderText = "รวมทั้งสิ้น";
            this.totalCostColumn.MinimumWidth = 6;
            this.totalCostColumn.Name = "totalCostColumn";
            this.totalCostColumn.ReadOnly = true;
            this.totalCostColumn.Width = 107;
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.sellTab);
            this.tab.Controls.Add(this.cashTab);
            this.tab.Controls.Add(this.SignTab);
            this.tab.Controls.Add(this.stockTab);
            this.tab.Controls.Add(this.EtcTab);
            this.tab.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Margin = new System.Windows.Forms.Padding(4);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1129, 737);
            this.tab.TabIndex = 10;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tab_SelectedIndexChanged);
            // 
            // sellTab
            // 
            this.sellTab.Controls.Add(this.sellDatePicker);
            this.sellTab.Controls.Add(this.sellDateLabel);
            this.sellTab.Controls.Add(this.cancelItem);
            this.sellTab.Controls.Add(this.payButton);
            this.sellTab.Controls.Add(this.sellGrid);
            this.sellTab.Controls.Add(this.buyerNameComboBox);
            this.sellTab.Controls.Add(this.findItemButton);
            this.sellTab.Controls.Add(this.addToSystemButton);
            this.sellTab.Controls.Add(this.buyerLabel);
            this.sellTab.Controls.Add(this.amountNumericUpDown);
            this.sellTab.Controls.Add(this.itemTobeBoughtTextbox);
            this.sellTab.Location = new System.Drawing.Point(4, 43);
            this.sellTab.Margin = new System.Windows.Forms.Padding(4);
            this.sellTab.Name = "sellTab";
            this.sellTab.Padding = new System.Windows.Forms.Padding(4);
            this.sellTab.Size = new System.Drawing.Size(1121, 690);
            this.sellTab.TabIndex = 0;
            this.sellTab.Text = "ขาย";
            this.sellTab.UseVisualStyleBackColor = true;
            // 
            // sellDatePicker
            // 
            this.sellDatePicker.CustomFormat = "dd-MM-yyyy";
            this.sellDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sellDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sellDatePicker.Location = new System.Drawing.Point(961, 15);
            this.sellDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.sellDatePicker.Name = "sellDatePicker";
            this.sellDatePicker.Size = new System.Drawing.Size(139, 40);
            this.sellDatePicker.TabIndex = 13;
            // 
            // sellDateLabel
            // 
            this.sellDateLabel.AutoSize = true;
            this.sellDateLabel.Location = new System.Drawing.Point(1011, 15);
            this.sellDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sellDateLabel.Name = "sellDateLabel";
            this.sellDateLabel.Size = new System.Drawing.Size(86, 34);
            this.sellDateLabel.TabIndex = 12;
            this.sellDateLabel.Text = "todayDate";
            // 
            // cancelItem
            // 
            this.cancelItem.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelItem.Location = new System.Drawing.Point(744, 610);
            this.cancelItem.Margin = new System.Windows.Forms.Padding(4);
            this.cancelItem.Name = "cancelItem";
            this.cancelItem.Size = new System.Drawing.Size(187, 39);
            this.cancelItem.TabIndex = 11;
            this.cancelItem.Text = "ยกเลิกรายการ";
            this.cancelItem.UseVisualStyleBackColor = true;
            this.cancelItem.Click += new System.EventHandler(this.cancelItem_Click);
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.payButton.Location = new System.Drawing.Point(961, 610);
            this.payButton.Margin = new System.Windows.Forms.Padding(4);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(140, 39);
            this.payButton.TabIndex = 4;
            this.payButton.Text = "ชำระสินค้า";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // buyerNameComboBox
            // 
            this.buyerNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.buyerNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.buyerNameComboBox.DropDownHeight = 200;
            this.buyerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyerNameComboBox.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerNameComboBox.FormattingEnabled = true;
            this.buyerNameComboBox.IntegralHeight = false;
            this.buyerNameComboBox.Location = new System.Drawing.Point(125, 46);
            this.buyerNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.buyerNameComboBox.MaxDropDownItems = 10;
            this.buyerNameComboBox.Name = "buyerNameComboBox";
            this.buyerNameComboBox.Size = new System.Drawing.Size(160, 42);
            this.buyerNameComboBox.TabIndex = 1;
            // 
            // findItemButton
            // 
            this.findItemButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findItemButton.Location = new System.Drawing.Point(331, 171);
            this.findItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.findItemButton.Name = "findItemButton";
            this.findItemButton.Size = new System.Drawing.Size(187, 41);
            this.findItemButton.TabIndex = 9;
            this.findItemButton.Text = "ค้นหาสินค้า";
            this.findItemButton.UseVisualStyleBackColor = true;
            this.findItemButton.Click += new System.EventHandler(this.findItemButton_Click);
            // 
            // addToSystemButton
            // 
            this.addToSystemButton.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToSystemButton.Location = new System.Drawing.Point(667, 122);
            this.addToSystemButton.Margin = new System.Windows.Forms.Padding(4);
            this.addToSystemButton.Name = "addToSystemButton";
            this.addToSystemButton.Size = new System.Drawing.Size(187, 41);
            this.addToSystemButton.TabIndex = 7;
            this.addToSystemButton.Text = "เพิ่มในรายการ";
            this.addToSystemButton.UseVisualStyleBackColor = true;
            this.addToSystemButton.Click += new System.EventHandler(this.addToSystemButton_Click);
            // 
            // buyerLabel
            // 
            this.buyerLabel.AutoSize = true;
            this.buyerLabel.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyerLabel.Location = new System.Drawing.Point(48, 52);
            this.buyerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buyerLabel.Name = "buyerLabel";
            this.buyerLabel.Size = new System.Drawing.Size(66, 30);
            this.buyerLabel.TabIndex = 0;
            this.buyerLabel.Text = "ชื่อผู้ซื้อ";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountNumericUpDown.Location = new System.Drawing.Point(549, 123);
            this.amountNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(75, 40);
            this.amountNumericUpDown.TabIndex = 3;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemTobeBoughtTextbox
            // 
            this.itemTobeBoughtTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.itemTobeBoughtTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.itemTobeBoughtTextbox.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTobeBoughtTextbox.Location = new System.Drawing.Point(125, 122);
            this.itemTobeBoughtTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.itemTobeBoughtTextbox.MaxLength = 50;
            this.itemTobeBoughtTextbox.Name = "itemTobeBoughtTextbox";
            this.itemTobeBoughtTextbox.Size = new System.Drawing.Size(391, 40);
            this.itemTobeBoughtTextbox.TabIndex = 2;
            this.itemTobeBoughtTextbox.Click += new System.EventHandler(this.itemToBeBoughtTextbox_Click);
            // 
            // cashTab
            // 
            this.cashTab.Controls.Add(this.cashbookChangeOrDeleteButton);
            this.cashTab.Controls.Add(this.label2);
            this.cashTab.Controls.Add(this.label1);
            this.cashTab.Controls.Add(this.toDateTimePicker);
            this.cashTab.Controls.Add(this.fromDateTimePicker);
            this.cashTab.Controls.Add(this.cashBookGrid);
            this.cashTab.Location = new System.Drawing.Point(4, 43);
            this.cashTab.Margin = new System.Windows.Forms.Padding(4);
            this.cashTab.Name = "cashTab";
            this.cashTab.Padding = new System.Windows.Forms.Padding(4);
            this.cashTab.Size = new System.Drawing.Size(1121, 690);
            this.cashTab.TabIndex = 1;
            this.cashTab.Text = "สมุดเงินสด";
            this.cashTab.UseVisualStyleBackColor = true;
            // 
            // cashbookChangeOrDeleteButton
            // 
            this.cashbookChangeOrDeleteButton.Location = new System.Drawing.Point(999, 638);
            this.cashbookChangeOrDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.cashbookChangeOrDeleteButton.Name = "cashbookChangeOrDeleteButton";
            this.cashbookChangeOrDeleteButton.Size = new System.Drawing.Size(100, 42);
            this.cashbookChangeOrDeleteButton.TabIndex = 5;
            this.cashbookChangeOrDeleteButton.Text = "ลบ";
            this.cashbookChangeOrDeleteButton.UseVisualStyleBackColor = true;
            this.cashbookChangeOrDeleteButton.Click += new System.EventHandler(this.cashbookChangeOrDeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(621, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "จาก";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(883, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "ถึง";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CustomFormat = "MM-dd-yyyy";
            this.toDateTimePicker.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(923, 46);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(149, 40);
            this.toDateTimePicker.TabIndex = 2;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CustomFormat = "MM-dd-yyyy";
            this.fromDateTimePicker.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimePicker.Location = new System.Drawing.Point(673, 46);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(151, 40);
            this.fromDateTimePicker.TabIndex = 1;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // cashBookGrid
            // 
            this.cashBookGrid.AllowUserToAddRows = false;
            this.cashBookGrid.AllowUserToDeleteRows = false;
            this.cashBookGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cashBookGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cashBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashBookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.date,
            this.ให้เป,
            this.Column5,
            this.quantity,
            this.Column7,
            this.Column37,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.cashBookGrid.Location = new System.Drawing.Point(17, 112);
            this.cashBookGrid.Margin = new System.Windows.Forms.Padding(4);
            this.cashBookGrid.Name = "cashBookGrid";
            this.cashBookGrid.ReadOnly = true;
            this.cashBookGrid.RowHeadersWidth = 51;
            this.cashBookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cashBookGrid.Size = new System.Drawing.Size(1081, 518);
            this.cashBookGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "ref";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.FillWeight = 40F;
            this.date.HeaderText = "วันที่";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // ให้เป
            // 
            this.ให้เป.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ให้เป.FillWeight = 30F;
            this.ให้เป.HeaderText = "เป็นของ";
            this.ให้เป.MinimumWidth = 6;
            this.ให้เป.Name = "ให้เป";
            this.ให้เป.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "ซื้อ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.FillWeight = 30F;
            this.quantity.HeaderText = "จำนวน";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.FillWeight = 30F;
            this.Column7.HeaderText = "ราคาต่อชิ้น";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column37
            // 
            this.Column37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column37.FillWeight = 30F;
            this.Column37.HeaderText = "ราคาต่อแพ็ค";
            this.Column37.MinimumWidth = 6;
            this.Column37.Name = "Column37";
            this.Column37.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.FillWeight = 30F;
            this.Column8.HeaderText = "รวม";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.FillWeight = 30F;
            this.Column9.HeaderText = "รวมทั้งสื้น";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.FillWeight = 30F;
            this.Column10.HeaderText = "ให้มา";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.FillWeight = 30F;
            this.Column11.HeaderText = "ทอน";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // SignTab
            // 
            this.SignTab.Controls.Add(this.exportSignBookButton);
            this.SignTab.Controls.Add(this.signbookChangeOrDeleteButton);
            this.SignTab.Controls.Add(this.label13);
            this.SignTab.Controls.Add(this.signbookDateTimePickerFrom);
            this.SignTab.Controls.Add(this.label4);
            this.SignTab.Controls.Add(this.buyerTotal);
            this.SignTab.Controls.Add(this.label3);
            this.SignTab.Controls.Add(this.signbookDateTimePickerTo);
            this.SignTab.Controls.Add(this.buyerNameComboBoxInSignBook);
            this.SignTab.Controls.Add(this.signBookGrid);
            this.SignTab.Location = new System.Drawing.Point(4, 43);
            this.SignTab.Margin = new System.Windows.Forms.Padding(4);
            this.SignTab.Name = "SignTab";
            this.SignTab.Padding = new System.Windows.Forms.Padding(4);
            this.SignTab.Size = new System.Drawing.Size(1121, 690);
            this.SignTab.TabIndex = 2;
            this.SignTab.Text = "สมุดเซ็น";
            this.SignTab.UseVisualStyleBackColor = true;
            // 
            // exportSignBookButton
            // 
            this.exportSignBookButton.Location = new System.Drawing.Point(419, 30);
            this.exportSignBookButton.Name = "exportSignBookButton";
            this.exportSignBookButton.Padding = new System.Windows.Forms.Padding(2);
            this.exportSignBookButton.Size = new System.Drawing.Size(133, 48);
            this.exportSignBookButton.TabIndex = 9;
            this.exportSignBookButton.Text = "Export Sign";
            this.exportSignBookButton.UseVisualStyleBackColor = true;
            this.exportSignBookButton.Click += new System.EventHandler(this.exportSignBookButton_Click);
            // 
            // signbookChangeOrDeleteButton
            // 
            this.signbookChangeOrDeleteButton.Location = new System.Drawing.Point(999, 644);
            this.signbookChangeOrDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.signbookChangeOrDeleteButton.Name = "signbookChangeOrDeleteButton";
            this.signbookChangeOrDeleteButton.Size = new System.Drawing.Size(100, 36);
            this.signbookChangeOrDeleteButton.TabIndex = 8;
            this.signbookChangeOrDeleteButton.Text = "แก้ไข/ลบ";
            this.signbookChangeOrDeleteButton.UseVisualStyleBackColor = true;
            this.signbookChangeOrDeleteButton.Click += new System.EventHandler(this.signbookChangeOrDeleteButton_Click);
            // 
            // label13
            // 
            this.label13.AccessibleDescription = "0";
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(584, 48);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 30);
            this.label13.TabIndex = 7;
            this.label13.Text = "จาก";
            // 
            // signbookDateTimePickerFrom
            // 
            this.signbookDateTimePickerFrom.CustomFormat = "dd-MM-yyyy";
            this.signbookDateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.signbookDateTimePickerFrom.Location = new System.Drawing.Point(648, 43);
            this.signbookDateTimePickerFrom.Margin = new System.Windows.Forms.Padding(4);
            this.signbookDateTimePickerFrom.Name = "signbookDateTimePickerFrom";
            this.signbookDateTimePickerFrom.Size = new System.Drawing.Size(145, 40);
            this.signbookDateTimePickerFrom.TabIndex = 6;
            this.signbookDateTimePickerFrom.ValueChanged += new System.EventHandler(this.signbookFromDateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AccessibleDescription = "0";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(876, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "ถึง";
            // 
            // buyerTotal
            // 
            this.buyerTotal.AutoSize = true;
            this.buyerTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buyerTotal.Location = new System.Drawing.Point(4, 652);
            this.buyerTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buyerTotal.Name = "buyerTotal";
            this.buyerTotal.Size = new System.Drawing.Size(20, 34);
            this.buyerTotal.TabIndex = 4;
            this.buyerTotal.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(751, 841);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "รวมทั้งสิ้น";
            // 
            // signbookDateTimePickerTo
            // 
            this.signbookDateTimePickerTo.AccessibleDescription = "0";
            this.signbookDateTimePickerTo.CustomFormat = "dd-MM-yyyy";
            this.signbookDateTimePickerTo.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.signbookDateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.signbookDateTimePickerTo.Location = new System.Drawing.Point(940, 43);
            this.signbookDateTimePickerTo.Margin = new System.Windows.Forms.Padding(4);
            this.signbookDateTimePickerTo.Name = "signbookDateTimePickerTo";
            this.signbookDateTimePickerTo.Size = new System.Drawing.Size(132, 40);
            this.signbookDateTimePickerTo.TabIndex = 1;
            this.signbookDateTimePickerTo.Value = new System.DateTime(2018, 4, 1, 0, 0, 0, 0);
            this.signbookDateTimePickerTo.ValueChanged += new System.EventHandler(this.signbookToDateTimePicker_ValueChanged);
            // 
            // buyerNameComboBoxInSignBook
            // 
            this.buyerNameComboBoxInSignBook.BackColor = System.Drawing.SystemColors.Window;
            this.buyerNameComboBoxInSignBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyerNameComboBoxInSignBook.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.buyerNameComboBoxInSignBook.ForeColor = System.Drawing.SystemColors.WindowText;
            this.buyerNameComboBoxInSignBook.FormattingEnabled = true;
            this.buyerNameComboBoxInSignBook.Location = new System.Drawing.Point(67, 43);
            this.buyerNameComboBoxInSignBook.Margin = new System.Windows.Forms.Padding(4);
            this.buyerNameComboBoxInSignBook.Name = "buyerNameComboBoxInSignBook";
            this.buyerNameComboBoxInSignBook.Size = new System.Drawing.Size(196, 42);
            this.buyerNameComboBoxInSignBook.TabIndex = 0;
            this.buyerNameComboBoxInSignBook.SelectedValueChanged += new System.EventHandler(this.BuyerSign_SelectedValueChanged);
            // 
            // signBookGrid
            // 
            this.signBookGrid.AllowUserToAddRows = false;
            this.signBookGrid.AllowUserToDeleteRows = false;
            this.signBookGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signBookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.signBookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column25,
            this.Column12,
            this.Column13,
            this.Column15,
            this.Column14,
            this.total});
            this.signBookGrid.Location = new System.Drawing.Point(16, 106);
            this.signBookGrid.Margin = new System.Windows.Forms.Padding(4);
            this.signBookGrid.Name = "signBookGrid";
            this.signBookGrid.RowHeadersWidth = 51;
            this.signBookGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.signBookGrid.Size = new System.Drawing.Size(1083, 530);
            this.signBookGrid.TabIndex = 2;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 20F;
            this.Column6.HeaderText = "Trans ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column25
            // 
            this.Column25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column25.FillWeight = 25F;
            this.Column25.HeaderText = "ของ";
            this.Column25.MinimumWidth = 6;
            this.Column25.Name = "Column25";
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.FillWeight = 45F;
            this.Column12.HeaderText = "วันที่";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText = "ชื่อสินค้า";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column15.FillWeight = 20F;
            this.Column15.HeaderText = "จำนวน";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column14.FillWeight = 20F;
            this.Column14.HeaderText = "ราคาต่อหน่วย";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.FillWeight = 25F;
            this.total.HeaderText = "รวมทั้งสิ้น";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            // 
            // stockTab
            // 
            this.stockTab.Controls.Add(this.importStockBtn);
            this.stockTab.Controls.Add(this.exportStock);
            this.stockTab.Controls.Add(this.searchProductTextbox);
            this.stockTab.Controls.Add(this.findProductButton);
            this.stockTab.Controls.Add(this.totalLabelForStockTab);
            this.stockTab.Controls.Add(this.label6);
            this.stockTab.Controls.Add(this.addProductButton);
            this.stockTab.Controls.Add(this.addToStockButton);
            this.stockTab.Controls.Add(this.stockGrid);
            this.stockTab.Location = new System.Drawing.Point(4, 43);
            this.stockTab.Margin = new System.Windows.Forms.Padding(4);
            this.stockTab.Name = "stockTab";
            this.stockTab.Size = new System.Drawing.Size(1121, 690);
            this.stockTab.TabIndex = 4;
            this.stockTab.Text = "สินค้าใน stock";
            this.stockTab.UseVisualStyleBackColor = true;
            // 
            // importStockBtn
            // 
            this.importStockBtn.Location = new System.Drawing.Point(809, 31);
            this.importStockBtn.Margin = new System.Windows.Forms.Padding(4);
            this.importStockBtn.Name = "importStockBtn";
            this.importStockBtn.Size = new System.Drawing.Size(113, 39);
            this.importStockBtn.TabIndex = 30;
            this.importStockBtn.Text = "Import";
            this.importStockBtn.UseVisualStyleBackColor = true;
            this.importStockBtn.Click += new System.EventHandler(this.importStockBtn_Click);
            // 
            // exportStock
            // 
            this.exportStock.Location = new System.Drawing.Point(952, 31);
            this.exportStock.Margin = new System.Windows.Forms.Padding(4);
            this.exportStock.Name = "exportStock";
            this.exportStock.Size = new System.Drawing.Size(113, 39);
            this.exportStock.TabIndex = 29;
            this.exportStock.Text = "Export";
            this.exportStock.UseVisualStyleBackColor = true;
            this.exportStock.Click += new System.EventHandler(this.exportStock_Click);
            // 
            // searchProductTextbox
            // 
            this.searchProductTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchProductTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchProductTextbox.Font = new System.Drawing.Font("CordiaUPC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductTextbox.Location = new System.Drawing.Point(55, 70);
            this.searchProductTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchProductTextbox.MaxLength = 50;
            this.searchProductTextbox.Name = "searchProductTextbox";
            this.searchProductTextbox.Size = new System.Drawing.Size(347, 40);
            this.searchProductTextbox.TabIndex = 10;
            // 
            // findProductButton
            // 
            this.findProductButton.Location = new System.Drawing.Point(445, 70);
            this.findProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.findProductButton.Name = "findProductButton";
            this.findProductButton.Size = new System.Drawing.Size(100, 39);
            this.findProductButton.TabIndex = 11;
            this.findProductButton.Text = "หา";
            this.findProductButton.UseVisualStyleBackColor = true;
            this.findProductButton.Click += new System.EventHandler(this.findProductButton_Click);
            // 
            // totalLabelForStockTab
            // 
            this.totalLabelForStockTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabelForStockTab.AutoSize = true;
            this.totalLabelForStockTab.Location = new System.Drawing.Point(61, 651);
            this.totalLabelForStockTab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabelForStockTab.Name = "totalLabelForStockTab";
            this.totalLabelForStockTab.Size = new System.Drawing.Size(66, 34);
            this.totalLabelForStockTab.TabIndex = 28;
            this.totalLabelForStockTab.Text = "label14";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 651);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 34);
            this.label6.TabIndex = 27;
            this.label6.Text = "Total";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(952, 107);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(113, 39);
            this.addProductButton.TabIndex = 12;
            this.addProductButton.Text = "เพิ่มสินค้า";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // addToStockButton
            // 
            this.addToStockButton.Location = new System.Drawing.Point(809, 107);
            this.addToStockButton.Margin = new System.Windows.Forms.Padding(4);
            this.addToStockButton.Name = "addToStockButton";
            this.addToStockButton.Size = new System.Drawing.Size(113, 39);
            this.addToStockButton.TabIndex = 13;
            this.addToStockButton.Text = "จดเข้า stock";
            this.addToStockButton.UseVisualStyleBackColor = true;
            this.addToStockButton.Click += new System.EventHandler(this.stockInButton_Click);
            // 
            // stockGrid
            // 
            this.stockGrid.AllowUserToAddRows = false;
            this.stockGrid.AllowUserToDeleteRows = false;
            this.stockGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.stockGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stockGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column20,
            this.Column22,
            this.Column30,
            this.Column31,
            this.Column23,
            this.Column24,
            this.newProductGridTypeColumn});
            this.stockGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.stockGrid.Location = new System.Drawing.Point(9, 165);
            this.stockGrid.Margin = new System.Windows.Forms.Padding(4);
            this.stockGrid.MultiSelect = false;
            this.stockGrid.Name = "stockGrid";
            this.stockGrid.RowHeadersWidth = 51;
            this.stockGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockGrid.Size = new System.Drawing.Size(1087, 468);
            this.stockGrid.TabIndex = 23;
            this.stockGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockGrid_CellClick);
            this.stockGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockGrid_CellContentClick);
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column20.FillWeight = 30F;
            this.Column20.HeaderText = "ชนิด";
            this.Column20.MinimumWidth = 6;
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            // 
            // Column22
            // 
            this.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column22.FillWeight = 120F;
            this.Column22.HeaderText = "รายการสินค้า";
            this.Column22.MinimumWidth = 6;
            this.Column22.Name = "Column22";
            this.Column22.ReadOnly = true;
            // 
            // Column30
            // 
            this.Column30.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column30.FillWeight = 20F;
            this.Column30.HeaderText = "ราคาต่อชิ้น";
            this.Column30.MinimumWidth = 6;
            this.Column30.Name = "Column30";
            this.Column30.ReadOnly = true;
            // 
            // Column31
            // 
            this.Column31.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column31.FillWeight = 18F;
            this.Column31.HeaderText = "ใน stock";
            this.Column31.MinimumWidth = 6;
            this.Column31.Name = "Column31";
            this.Column31.ReadOnly = true;
            // 
            // Column23
            // 
            this.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column23.FillWeight = 18F;
            this.Column23.HeaderText = "ราคาต้นทุน";
            this.Column23.MinimumWidth = 6;
            this.Column23.Name = "Column23";
            this.Column23.ReadOnly = true;
            // 
            // Column24
            // 
            this.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column24.FillWeight = 18F;
            this.Column24.HeaderText = "กำไรต่อชิ้น";
            this.Column24.MinimumWidth = 6;
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            // 
            // newProductGridTypeColumn
            // 
            this.newProductGridTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newProductGridTypeColumn.FillWeight = 25F;
            this.newProductGridTypeColumn.HeaderText = "ที่ซื้อ";
            this.newProductGridTypeColumn.MinimumWidth = 6;
            this.newProductGridTypeColumn.Name = "newProductGridTypeColumn";
            this.newProductGridTypeColumn.ReadOnly = true;
            this.newProductGridTypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // EtcTab
            // 
            this.EtcTab.Controls.Add(this.totalLabelGroupBoxInEtcTab);
            this.EtcTab.Controls.Add(this.etcComboBox);
            this.EtcTab.Controls.Add(this.accountingGroupbox);
            this.EtcTab.Controls.Add(this.addNewBuyerGroupBox);
            this.EtcTab.Controls.Add(this.needToBuyGrid);
            this.EtcTab.Location = new System.Drawing.Point(4, 43);
            this.EtcTab.Margin = new System.Windows.Forms.Padding(4);
            this.EtcTab.Name = "EtcTab";
            this.EtcTab.Padding = new System.Windows.Forms.Padding(4);
            this.EtcTab.Size = new System.Drawing.Size(1121, 690);
            this.EtcTab.TabIndex = 3;
            this.EtcTab.Text = "อื่นๆ";
            this.EtcTab.UseVisualStyleBackColor = true;
            this.EtcTab.TextChanged += new System.EventHandler(this.findItemButton_Click);
            // 
            // totalLabelGroupBoxInEtcTab
            // 
            this.totalLabelGroupBoxInEtcTab.Controls.Add(this.removeProductButton);
            this.totalLabelGroupBoxInEtcTab.Controls.Add(this.totalItems);
            this.totalLabelGroupBoxInEtcTab.Controls.Add(this.totalLabel);
            this.totalLabelGroupBoxInEtcTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.totalLabelGroupBoxInEtcTab.Location = new System.Drawing.Point(4, 644);
            this.totalLabelGroupBoxInEtcTab.Margin = new System.Windows.Forms.Padding(4);
            this.totalLabelGroupBoxInEtcTab.Name = "totalLabelGroupBoxInEtcTab";
            this.totalLabelGroupBoxInEtcTab.Padding = new System.Windows.Forms.Padding(4);
            this.totalLabelGroupBoxInEtcTab.Size = new System.Drawing.Size(1113, 42);
            this.totalLabelGroupBoxInEtcTab.TabIndex = 22;
            this.totalLabelGroupBoxInEtcTab.TabStop = false;
            // 
            // removeProductButton
            // 
            this.removeProductButton.Location = new System.Drawing.Point(1007, 5);
            this.removeProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(100, 36);
            this.removeProductButton.TabIndex = 20;
            this.removeProductButton.Text = "แก้ไข/ลบสินค้า";
            this.removeProductButton.UseVisualStyleBackColor = true;
            // 
            // totalItems
            // 
            this.totalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalItems.AutoSize = true;
            this.totalItems.Location = new System.Drawing.Point(57, 6);
            this.totalItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalItems.Name = "totalItems";
            this.totalItems.Size = new System.Drawing.Size(66, 34);
            this.totalItems.TabIndex = 16;
            this.totalItems.Text = "label14";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(8, 6);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(49, 34);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Total";
            // 
            // etcComboBox
            // 
            this.etcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.etcComboBox.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.etcComboBox.FormattingEnabled = true;
            this.etcComboBox.Items.AddRange(new object[] {
            "เพิ่มคนซื้อ",
            "ดู stock ที่ขาด",
            "ตัดวัน/ดูยอดเงินสด"});
            this.etcComboBox.Location = new System.Drawing.Point(47, 52);
            this.etcComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.etcComboBox.Name = "etcComboBox";
            this.etcComboBox.Size = new System.Drawing.Size(305, 42);
            this.etcComboBox.TabIndex = 0;
            this.etcComboBox.TextChanged += new System.EventHandler(this.etcComboBox_TextChanged);
            // 
            // accountingGroupbox
            // 
            this.accountingGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountingGroupbox.AutoSize = true;
            this.accountingGroupbox.Controls.Add(this.totalReconciliationLabelResult);
            this.accountingGroupbox.Controls.Add(this.totalReconciliationLabel);
            this.accountingGroupbox.Controls.Add(this.reconciliationGrid);
            this.accountingGroupbox.Controls.Add(this.accountingDateTimePicker);
            this.accountingGroupbox.Location = new System.Drawing.Point(47, 116);
            this.accountingGroupbox.Margin = new System.Windows.Forms.Padding(4);
            this.accountingGroupbox.Name = "accountingGroupbox";
            this.accountingGroupbox.Padding = new System.Windows.Forms.Padding(4);
            this.accountingGroupbox.Size = new System.Drawing.Size(644, 594);
            this.accountingGroupbox.TabIndex = 21;
            this.accountingGroupbox.TabStop = false;
            // 
            // totalReconciliationLabelResult
            // 
            this.totalReconciliationLabelResult.AutoSize = true;
            this.totalReconciliationLabelResult.Location = new System.Drawing.Point(389, 44);
            this.totalReconciliationLabelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalReconciliationLabelResult.Name = "totalReconciliationLabelResult";
            this.totalReconciliationLabelResult.Size = new System.Drawing.Size(66, 34);
            this.totalReconciliationLabelResult.TabIndex = 21;
            this.totalReconciliationLabelResult.Text = "label17";
            // 
            // totalReconciliationLabel
            // 
            this.totalReconciliationLabel.AutoSize = true;
            this.totalReconciliationLabel.Location = new System.Drawing.Point(323, 46);
            this.totalReconciliationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalReconciliationLabel.Name = "totalReconciliationLabel";
            this.totalReconciliationLabel.Size = new System.Drawing.Size(49, 34);
            this.totalReconciliationLabel.TabIndex = 22;
            this.totalReconciliationLabel.Text = "Total";
            // 
            // reconciliationGrid
            // 
            this.reconciliationGrid.AllowUserToAddRows = false;
            this.reconciliationGrid.AllowUserToDeleteRows = false;
            this.reconciliationGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reconciliationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reconciliationGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reconciliationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reconciliationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column26,
            this.Column27,
            this.Column28,
            this.Column29,
            this.Column32,
            this.Column34});
            this.reconciliationGrid.Location = new System.Drawing.Point(8, 101);
            this.reconciliationGrid.Margin = new System.Windows.Forms.Padding(4);
            this.reconciliationGrid.Name = "reconciliationGrid";
            this.reconciliationGrid.RowHeadersWidth = 51;
            this.reconciliationGrid.Size = new System.Drawing.Size(605, 480);
            this.reconciliationGrid.TabIndex = 14;
            this.reconciliationGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gotCash_CellDoubleClick);
            this.reconciliationGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gotCash_CellValueChanged);
            // 
            // Column26
            // 
            this.Column26.HeaderText = "วันที่";
            this.Column26.MinimumWidth = 6;
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            // 
            // Column27
            // 
            this.Column27.HeaderText = "ควรจะได้";
            this.Column27.MinimumWidth = 6;
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            // 
            // Column28
            // 
            this.Column28.HeaderText = "รายรับ";
            this.Column28.MinimumWidth = 6;
            this.Column28.Name = "Column28";
            // 
            // Column29
            // 
            this.Column29.HeaderText = "ส่วนต่าง";
            this.Column29.MinimumWidth = 6;
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            // 
            // Column32
            // 
            this.Column32.HeaderText = "รายจ่าย";
            this.Column32.MinimumWidth = 6;
            this.Column32.Name = "Column32";
            // 
            // Column34
            // 
            this.Column34.HeaderText = "ผล";
            this.Column34.MinimumWidth = 6;
            this.Column34.Name = "Column34";
            this.Column34.ReadOnly = true;
            // 
            // accountingDateTimePicker
            // 
            this.accountingDateTimePicker.CustomFormat = "MM-yyyy";
            this.accountingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.accountingDateTimePicker.Location = new System.Drawing.Point(485, 41);
            this.accountingDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.accountingDateTimePicker.Name = "accountingDateTimePicker";
            this.accountingDateTimePicker.Size = new System.Drawing.Size(127, 40);
            this.accountingDateTimePicker.TabIndex = 12;
            this.accountingDateTimePicker.ValueChanged += new System.EventHandler(this.accountingDateTimePicker_ValueChanged);
            // 
            // addNewBuyerGroupBox
            // 
            this.addNewBuyerGroupBox.Controls.Add(this.newBuyerTextInput);
            this.addNewBuyerGroupBox.Controls.Add(this.button1);
            this.addNewBuyerGroupBox.Font = new System.Drawing.Font("CordiaUPC", 14.25F);
            this.addNewBuyerGroupBox.Location = new System.Drawing.Point(47, 110);
            this.addNewBuyerGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.addNewBuyerGroupBox.Name = "addNewBuyerGroupBox";
            this.addNewBuyerGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.addNewBuyerGroupBox.Size = new System.Drawing.Size(553, 97);
            this.addNewBuyerGroupBox.TabIndex = 11;
            this.addNewBuyerGroupBox.TabStop = false;
            // 
            // newBuyerTextInput
            // 
            this.newBuyerTextInput.Location = new System.Drawing.Point(20, 32);
            this.newBuyerTextInput.Margin = new System.Windows.Forms.Padding(4);
            this.newBuyerTextInput.Name = "newBuyerTextInput";
            this.newBuyerTextInput.Size = new System.Drawing.Size(225, 40);
            this.newBuyerTextInput.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "เพิ่มคนซื้อ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addNewBuyer_Click);
            // 
            // needToBuyGrid
            // 
            this.needToBuyGrid.AllowUserToAddRows = false;
            this.needToBuyGrid.AllowUserToDeleteRows = false;
            this.needToBuyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.needToBuyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.needToBuyGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.needToBuyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.needToBuyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19});
            this.needToBuyGrid.Location = new System.Drawing.Point(0, 126);
            this.needToBuyGrid.Margin = new System.Windows.Forms.Padding(4);
            this.needToBuyGrid.Name = "needToBuyGrid";
            this.needToBuyGrid.RowHeadersWidth = 51;
            this.needToBuyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.needToBuyGrid.Size = new System.Drawing.Size(1115, 524);
            this.needToBuyGrid.TabIndex = 1;
            this.needToBuyGrid.Visible = false;
            // 
            // Column16
            // 
            this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column16.HeaderText = "ชื่อ";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column17.FillWeight = 30F;
            this.Column17.HeaderText = "ราคาต่อหน่วย";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column18.FillWeight = 30F;
            this.Column18.HeaderText = "ใน stock";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column19.FillWeight = 30F;
            this.Column19.HeaderText = "ควรมี";
            this.Column19.MinimumWidth = 6;
            this.Column19.Name = "Column19";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AcceptButton = this.addToSystemButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 737);
            this.Controls.Add(this.tab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KR SAHAKORN";
            ((System.ComponentModel.ISupportInitialize)(this.sellGrid)).EndInit();
            this.tab.ResumeLayout(false);
            this.sellTab.ResumeLayout(false);
            this.sellTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.cashTab.ResumeLayout(false);
            this.cashTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBookGrid)).EndInit();
            this.SignTab.ResumeLayout(false);
            this.SignTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signBookGrid)).EndInit();
            this.stockTab.ResumeLayout(false);
            this.stockTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).EndInit();
            this.EtcTab.ResumeLayout(false);
            this.EtcTab.PerformLayout();
            this.totalLabelGroupBoxInEtcTab.ResumeLayout(false);
            this.totalLabelGroupBoxInEtcTab.PerformLayout();
            this.accountingGroupbox.ResumeLayout(false);
            this.accountingGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconciliationGrid)).EndInit();
            this.addNewBuyerGroupBox.ResumeLayout(false);
            this.addNewBuyerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.needToBuyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView sellGrid;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage sellTab;
        private System.Windows.Forms.ComboBox buyerNameComboBox;
        private System.Windows.Forms.Button findItemButton;
        private System.Windows.Forms.Button addToSystemButton;
        private System.Windows.Forms.Label buyerLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.TextBox itemTobeBoughtTextbox;
        private System.Windows.Forms.TabPage cashTab;
        private System.Windows.Forms.TabPage SignTab;
        private System.Windows.Forms.TabPage EtcTab;
        private System.Windows.Forms.DataGridView cashBookGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView signBookGrid;
        private System.Windows.Forms.ComboBox buyerNameComboBoxInSignBook;
        private System.Windows.Forms.ComboBox etcComboBox;
        private System.Windows.Forms.DataGridView needToBuyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ขายโดย;
        private System.Windows.Forms.Button cancelItem;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.GroupBox addNewBuyerGroupBox;
        private System.Windows.Forms.TextBox newBuyerTextInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label buyerTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker signbookDateTimePickerTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalItems;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.Label sellDateLabel;
        private System.Windows.Forms.DataGridView reconciliationGrid;
        private System.Windows.Forms.DateTimePicker accountingDateTimePicker;
        private System.Windows.Forms.GroupBox accountingGroupbox;
        private System.Windows.Forms.GroupBox totalLabelGroupBoxInEtcTab;
        private System.Windows.Forms.Button removeProductButton;
        private System.Windows.Forms.DateTimePicker sellDatePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker signbookDateTimePickerFrom;
        private System.Windows.Forms.Button cashbookChangeOrDeleteButton;
        private System.Windows.Forms.Button signbookChangeOrDeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ให้เป;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column37;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column32;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column34;
        private System.Windows.Forms.Label totalReconciliationLabel;
        private System.Windows.Forms.Label totalReconciliationLabelResult;
        private System.Windows.Forms.TabPage stockTab;
        private System.Windows.Forms.DataGridView stockGrid;
        private System.Windows.Forms.Button addToStockButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label totalLabelForStockTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button findProductButton;
        private System.Windows.Forms.TextBox searchProductTextbox;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button exportStock;
        private System.Windows.Forms.Button importStockBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column30;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column31;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn newProductGridTypeColumn;
        private System.Windows.Forms.Button exportSignBookButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostColumn;
    }
}


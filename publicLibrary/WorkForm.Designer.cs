namespace publicLibrary
{
    partial class WorkForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.submitLendsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.itemIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemQuantityHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemCountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.addBookButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subscriberNameTextBox = new System.Windows.Forms.TextBox();
            this.workerNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateLendList = new System.Windows.Forms.Button();
            this.lendsListViewRefreshButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lendsSearchButton = new System.Windows.Forms.Button();
            this.lendsSearchComboBox = new System.Windows.Forms.ComboBox();
            this.lendsSearchInput = new System.Windows.Forms.TextBox();
            this.lendsSearchByLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lendsListView = new System.Windows.Forms.ListView();
            this.itemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subscriberNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libraryDatabaseDataSet = new publicLibrary.LibraryDatabaseDataSet();
            this.lendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendsTableAdapter = new publicLibrary.LibraryDatabaseDataSetTableAdapters.LendsTableAdapter();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BOOKS = new System.Windows.Forms.TabPage();
            this.booksDataGridViewUpdateButton = new System.Windows.Forms.Button();
            this.booksDataGridViewRefreshButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).BeginInit();
            this.BOOKS.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.BOOKS);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 342);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.submitLendsButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.itemsListView);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(954, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADD LEND";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // submitLendsButton
            // 
            this.submitLendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitLendsButton.Location = new System.Drawing.Point(276, 202);
            this.submitLendsButton.Name = "submitLendsButton";
            this.submitLendsButton.Size = new System.Drawing.Size(100, 23);
            this.submitLendsButton.TabIndex = 10;
            this.submitLendsButton.Text = "finish";
            this.submitLendsButton.UseVisualStyleBackColor = true;
            this.submitLendsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "books:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "info:";
            // 
            // itemsListView
            // 
            this.itemsListView.BackColor = System.Drawing.Color.White;
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemIdHeader,
            this.itemNameHeader,
            this.itemQuantityHeader,
            this.itemCountHeader});
            this.itemsListView.ForeColor = System.Drawing.SystemColors.MenuText;
            this.itemsListView.GridLines = true;
            this.itemsListView.Location = new System.Drawing.Point(388, 40);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(403, 185);
            this.itemsListView.TabIndex = 2;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // itemIdHeader
            // 
            this.itemIdHeader.Text = "id";
            this.itemIdHeader.Width = 40;
            // 
            // itemNameHeader
            // 
            this.itemNameHeader.Text = "name";
            this.itemNameHeader.Width = 200;
            // 
            // itemQuantityHeader
            // 
            this.itemQuantityHeader.Text = "quantity";
            // 
            // itemCountHeader
            // 
            this.itemCountHeader.Text = "left in stock";
            this.itemCountHeader.Width = 99;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.addBookButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.itemQuantityTextBox);
            this.panel2.Controls.Add(this.itemNameTextBox);
            this.panel2.Location = new System.Drawing.Point(175, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 86);
            this.panel2.TabIndex = 1;
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.White;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Location = new System.Drawing.Point(101, 55);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(100, 23);
            this.addBookButton.TabIndex = 9;
            this.addBookButton.Text = "add";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "book name:";
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.Location = new System.Drawing.Point(101, 29);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemQuantityTextBox.TabIndex = 6;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(101, 3);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNameTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subscriberNameTextBox);
            this.panel1.Controls.Add(this.workerNameTextBox);
            this.panel1.Location = new System.Drawing.Point(175, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 64);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "subscriber name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "worker name: ";
            // 
            // subscriberNameTextBox
            // 
            this.subscriberNameTextBox.Location = new System.Drawing.Point(101, 29);
            this.subscriberNameTextBox.Name = "subscriberNameTextBox";
            this.subscriberNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.subscriberNameTextBox.TabIndex = 4;
            // 
            // workerNameTextBox
            // 
            this.workerNameTextBox.Location = new System.Drawing.Point(101, 3);
            this.workerNameTextBox.Name = "workerNameTextBox";
            this.workerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerNameTextBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updateLendList);
            this.tabPage2.Controls.Add(this.lendsListViewRefreshButton);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.lendsListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(954, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LENDS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updateLendList
            // 
            this.updateLendList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateLendList.Location = new System.Drawing.Point(211, 248);
            this.updateLendList.Name = "updateLendList";
            this.updateLendList.Size = new System.Drawing.Size(75, 23);
            this.updateLendList.TabIndex = 3;
            this.updateLendList.Text = "update";
            this.updateLendList.UseVisualStyleBackColor = true;
            this.updateLendList.Click += new System.EventHandler(this.updateLendList_Click);
            // 
            // lendsListViewRefreshButton
            // 
            this.lendsListViewRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendsListViewRefreshButton.Location = new System.Drawing.Point(211, 67);
            this.lendsListViewRefreshButton.Name = "lendsListViewRefreshButton";
            this.lendsListViewRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.lendsListViewRefreshButton.TabIndex = 2;
            this.lendsListViewRefreshButton.Text = "refresh";
            this.lendsListViewRefreshButton.UseVisualStyleBackColor = true;
            this.lendsListViewRefreshButton.Click += new System.EventHandler(this.lendsListViewRefreshButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.lendsSearchButton);
            this.panel3.Controls.Add(this.lendsSearchComboBox);
            this.panel3.Controls.Add(this.lendsSearchInput);
            this.panel3.Controls.Add(this.lendsSearchByLabel);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(47, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 107);
            this.panel3.TabIndex = 1;
            // 
            // lendsSearchButton
            // 
            this.lendsSearchButton.BackColor = System.Drawing.Color.White;
            this.lendsSearchButton.Enabled = false;
            this.lendsSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendsSearchButton.Location = new System.Drawing.Point(103, 70);
            this.lendsSearchButton.Name = "lendsSearchButton";
            this.lendsSearchButton.Size = new System.Drawing.Size(121, 23);
            this.lendsSearchButton.TabIndex = 3;
            this.lendsSearchButton.Text = "search";
            this.lendsSearchButton.UseVisualStyleBackColor = false;
            this.lendsSearchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // lendsSearchComboBox
            // 
            this.lendsSearchComboBox.FormattingEnabled = true;
            this.lendsSearchComboBox.Items.AddRange(new object[] {
            "item",
            "subscriber ",
            "end date\t"});
            this.lendsSearchComboBox.Location = new System.Drawing.Point(103, 15);
            this.lendsSearchComboBox.Name = "lendsSearchComboBox";
            this.lendsSearchComboBox.Size = new System.Drawing.Size(121, 21);
            this.lendsSearchComboBox.TabIndex = 4;
            this.lendsSearchComboBox.TextChanged += new System.EventHandler(this.searchComboBox_TextChanged);
            // 
            // lendsSearchInput
            // 
            this.lendsSearchInput.Enabled = false;
            this.lendsSearchInput.Location = new System.Drawing.Point(103, 44);
            this.lendsSearchInput.Name = "lendsSearchInput";
            this.lendsSearchInput.Size = new System.Drawing.Size(121, 20);
            this.lendsSearchInput.TabIndex = 3;
            // 
            // lendsSearchByLabel
            // 
            this.lendsSearchByLabel.Location = new System.Drawing.Point(19, 47);
            this.lendsSearchByLabel.Name = "lendsSearchByLabel";
            this.lendsSearchByLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lendsSearchByLabel.Size = new System.Drawing.Size(78, 13);
            this.lendsSearchByLabel.TabIndex = 2;
            this.lendsSearchByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lendsSearchByLabel.Click += new System.EventHandler(this.searchByLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "search by:";
            // 
            // lendsListView
            // 
            this.lendsListView.CheckBoxes = true;
            this.lendsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.itemNameColumn,
            this.quantityColumn,
            this.subscriberNameColumn,
            this.endDateColumn});
            this.lendsListView.GridLines = true;
            this.lendsListView.Location = new System.Drawing.Point(293, 67);
            this.lendsListView.Name = "lendsListView";
            this.lendsListView.Size = new System.Drawing.Size(632, 204);
            this.lendsListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lendsListView.TabIndex = 0;
            this.lendsListView.UseCompatibleStateImageBehavior = false;
            this.lendsListView.View = System.Windows.Forms.View.Details;
            this.lendsListView.SelectedIndexChanged += new System.EventHandler(this.lendsListView_SelectedIndexChanged);
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.Text = "item name";
            this.itemNameColumn.Width = 195;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "quantity";
            this.quantityColumn.Width = 49;
            // 
            // subscriberNameColumn
            // 
            this.subscriberNameColumn.Text = "subscriber";
            this.subscriberNameColumn.Width = 116;
            // 
            // endDateColumn
            // 
            this.endDateColumn.Text = "end date";
            this.endDateColumn.Width = 222;
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "LibraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lendsBindingSource
            // 
            this.lendsBindingSource.DataMember = "Lends";
            this.lendsBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // lendsTableAdapter
            // 
            this.lendsTableAdapter.ClearBeforeFill = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 19;
            // 
            // BOOKS
            // 
            this.BOOKS.Controls.Add(this.dataGridView1);
            this.BOOKS.Controls.Add(this.booksDataGridViewUpdateButton);
            this.BOOKS.Controls.Add(this.booksDataGridViewRefreshButton);
            this.BOOKS.Controls.Add(this.panel4);
            this.BOOKS.Location = new System.Drawing.Point(4, 22);
            this.BOOKS.Name = "BOOKS";
            this.BOOKS.Padding = new System.Windows.Forms.Padding(3);
            this.BOOKS.Size = new System.Drawing.Size(954, 316);
            this.BOOKS.TabIndex = 2;
            this.BOOKS.Text = "BOOKS";
            this.BOOKS.UseVisualStyleBackColor = true;
            // 
            // booksDataGridViewUpdateButton
            // 
            this.booksDataGridViewUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksDataGridViewUpdateButton.Location = new System.Drawing.Point(211, 248);
            this.booksDataGridViewUpdateButton.Name = "booksDataGridViewUpdateButton";
            this.booksDataGridViewUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.booksDataGridViewUpdateButton.TabIndex = 7;
            this.booksDataGridViewUpdateButton.Text = "update";
            this.booksDataGridViewUpdateButton.UseVisualStyleBackColor = true;
            // 
            // booksDataGridViewRefreshButton
            // 
            this.booksDataGridViewRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksDataGridViewRefreshButton.Location = new System.Drawing.Point(211, 67);
            this.booksDataGridViewRefreshButton.Name = "booksDataGridViewRefreshButton";
            this.booksDataGridViewRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.booksDataGridViewRefreshButton.TabIndex = 6;
            this.booksDataGridViewRefreshButton.Text = "refresh";
            this.booksDataGridViewRefreshButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(47, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 107);
            this.panel4.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(103, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "search";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "item",
            "subscriber ",
            "end date\t"});
            this.comboBox1.Location = new System.Drawing.Point(103, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(103, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(19, 47);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 2;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "search by:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.count,
            this.publisher,
            this.author,
            this.genre,
            this.language});
            this.dataGridView1.Location = new System.Drawing.Point(292, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 204);
            this.dataGridView1.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 30;
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 120;
            this.name.Name = "name";
            this.name.Width = 120;
            // 
            // count
            // 
            this.count.HeaderText = "count";
            this.count.MinimumWidth = 30;
            this.count.Name = "count";
            this.count.Width = 50;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "publisher";
            this.publisher.MinimumWidth = 120;
            this.publisher.Name = "publisher";
            this.publisher.Width = 120;
            // 
            // author
            // 
            this.author.HeaderText = "author";
            this.author.MinimumWidth = 120;
            this.author.Name = "author";
            this.author.Width = 120;
            // 
            // genre
            // 
            this.genre.HeaderText = "genre";
            this.genre.MinimumWidth = 30;
            this.genre.Name = "genre";
            this.genre.Width = 80;
            // 
            // language
            // 
            this.language.HeaderText = "language";
            this.language.MinimumWidth = 30;
            this.language.Name = "language";
            this.language.Width = 70;
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 366);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkForm";
            this.Load += new System.EventHandler(this.WorkForm_Load);
            this.Shown += new System.EventHandler(this.WorkForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).EndInit();
            this.BOOKS.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button submitLendsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subscriberNameTextBox;
        private System.Windows.Forms.TextBox workerNameTextBox;
        private System.Windows.Forms.ColumnHeader itemIdHeader;
        private System.Windows.Forms.ColumnHeader itemNameHeader;
        private System.Windows.Forms.ColumnHeader itemQuantityHeader;
        private System.Windows.Forms.ColumnHeader itemCountHeader;
        private LibraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource lendsBindingSource;
        private LibraryDatabaseDataSetTableAdapters.LendsTableAdapter lendsTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox lendsSearchInput;
        private System.Windows.Forms.Label lendsSearchByLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lendsListView;
        private System.Windows.Forms.ColumnHeader itemNameColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader subscriberNameColumn;
        private System.Windows.Forms.ColumnHeader endDateColumn;
        private System.Windows.Forms.ComboBox lendsSearchComboBox;
        private System.Windows.Forms.Button lendsListViewRefreshButton;
        private System.Windows.Forms.Button lendsSearchButton;
        private System.Windows.Forms.Button updateLendList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage BOOKS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.Button booksDataGridViewUpdateButton;
        private System.Windows.Forms.Button booksDataGridViewRefreshButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
namespace publicLibrary
{
    partial class DatabaseForm
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
            System.Windows.Forms.TabPage authorsTab;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.label4 = new System.Windows.Forms.Label();
            this.authorsSubmit2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DELauthorIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.authorsDataGridView = new System.Windows.Forms.DataGridView();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDatabaseDataSet = new publicLibrary.LibraryDatabaseDataSet();
            this.authorsSubmit1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.authorIdTextBox = new System.Windows.Forms.TextBox();
            this.databaseTabControl = new System.Windows.Forms.TabControl();
            this.itemsTab = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.itemLanguageTextBox = new System.Windows.Forms.TextBox();
            this.itemGenreTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.itemAuthorIdTextBox = new System.Windows.Forms.TextBox();
            this.itemPublisherIdTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.itemDaysTextBox = new System.Windows.Forms.TextBox();
            this.itemCountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemsSubmit2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DELitemIdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemAllowedLendDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsSubmit1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.lendsTab = new System.Windows.Forms.TabPage();
            this.refreshLendsDataGridViewButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lendEndDateTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lendStartDateTextBox = new System.Windows.Forms.TextBox();
            this.lendQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lendItemIdTextBox = new System.Windows.Forms.TextBox();
            this.lendWorkerIdTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lendsSubmit2 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.DELlendIdTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.lendsDataGridView = new System.Windows.Forms.DataGridView();
            this.lendIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriberIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendFinishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lendsSubmit1 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lendSubscriberIdTextBox = new System.Windows.Forms.TextBox();
            this.lendIdTextBox = new System.Windows.Forms.TextBox();
            this.publishersTab = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.publisherContactTextBox = new System.Windows.Forms.TextBox();
            this.publisherAddressTextBox = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.publishersSubmit2 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.DELpublisherIdTextBox = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.publishersDataGridView = new System.Windows.Forms.DataGridView();
            this.publisherIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishersSubmit1 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.publisherNameTextBox = new System.Windows.Forms.TextBox();
            this.publisherIdTextBox = new System.Windows.Forms.TextBox();
            this.subscribersTab = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.subscriberEmailTextBox = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.subscriberPhoneTextBox = new System.Windows.Forms.TextBox();
            this.subscriberAddressTextBox = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.subscribersSubmit2 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.DELsubscriberIdTextBox = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.subscribersDataGridView = new System.Windows.Forms.DataGridView();
            this.subscriberIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriberAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriberPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriberEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscribersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subscribersSubmit1 = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.subscriberNameTextBox = new System.Windows.Forms.TextBox();
            this.subscriberIdTextBox = new System.Windows.Forms.TextBox();
            this.workersTab = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.workerStartDateTextBox = new System.Windows.Forms.TextBox();
            this.workerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.workerEmailTextBox = new System.Windows.Forms.TextBox();
            this.workerAddressTextBox = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.workerRankTextBox = new System.Windows.Forms.TextBox();
            this.workerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.workersSubmit2 = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.DELworkersIdTextBox = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.workerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersSubmit1 = new System.Windows.Forms.Button();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.workerNameTextBox = new System.Windows.Forms.TextBox();
            this.workerIdTextBox = new System.Windows.Forms.TextBox();
            this.authorsTableAdapter = new publicLibrary.LibraryDatabaseDataSetTableAdapters.AuthorsTableAdapter();
            this.itemsTableAdapter = new publicLibrary.LibraryDatabaseDataSetTableAdapters.ItemsTableAdapter();
            this.lendsTableAdapter = new publicLibrary.LibraryDatabaseDataSetTableAdapters.LendsTableAdapter();
            this.publishersTableAdapter = new publicLibrary.LibraryDatabaseDataSetTableAdapters.PublishersTableAdapter();
            this.subscribersTableAdapter = new publicLibrary.LibraryDatabaseDataSetTableAdapters.SubscribersTableAdapter();
            this.workersTableAdapter = new publicLibrary.LibraryDatabaseDataSetTableAdapters.WorkersTableAdapter();
            this.refreshAuthorsDataGridViewButton = new System.Windows.Forms.Button();
            this.refreshItemsDataGridViewButton = new System.Windows.Forms.Button();
            this.refreshPublishersDataGridViewButton = new System.Windows.Forms.Button();
            this.refreshSubscribersDataGridViewButton = new System.Windows.Forms.Button();
            this.refreshWorkersDataGridViewButton = new System.Windows.Forms.Button();
            authorsTab = new System.Windows.Forms.TabPage();
            authorsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            this.databaseTabControl.SuspendLayout();
            this.itemsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.lendsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lendsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).BeginInit();
            this.publishersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            this.subscribersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).BeginInit();
            this.workersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // authorsTab
            // 
            authorsTab.Controls.Add(this.refreshAuthorsDataGridViewButton);
            authorsTab.Controls.Add(this.label4);
            authorsTab.Controls.Add(this.authorsSubmit2);
            authorsTab.Controls.Add(this.label6);
            authorsTab.Controls.Add(this.DELauthorIdTextBox);
            authorsTab.Controls.Add(this.label3);
            authorsTab.Controls.Add(this.authorsDataGridView);
            authorsTab.Controls.Add(this.authorsSubmit1);
            authorsTab.Controls.Add(this.label2);
            authorsTab.Controls.Add(this.label1);
            authorsTab.Controls.Add(this.authorNameTextBox);
            authorsTab.Controls.Add(this.authorIdTextBox);
            authorsTab.Location = new System.Drawing.Point(4, 22);
            authorsTab.Name = "authorsTab";
            authorsTab.Padding = new System.Windows.Forms.Padding(3);
            authorsTab.Size = new System.Drawing.Size(1042, 381);
            authorsTab.TabIndex = 0;
            authorsTab.Text = "AUTHORS";
            authorsTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "DELETE";
            // 
            // authorsSubmit2
            // 
            this.authorsSubmit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorsSubmit2.Location = new System.Drawing.Point(70, 183);
            this.authorsSubmit2.Name = "authorsSubmit2";
            this.authorsSubmit2.Size = new System.Drawing.Size(100, 23);
            this.authorsSubmit2.TabIndex = 11;
            this.authorsSubmit2.Text = "submit";
            this.authorsSubmit2.UseVisualStyleBackColor = true;
            this.authorsSubmit2.Click += new System.EventHandler(this.authorsSubmit2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "id";
            // 
            // DELauthorIdTextBox
            // 
            this.DELauthorIdTextBox.Location = new System.Drawing.Point(70, 157);
            this.DELauthorIdTextBox.Name = "DELauthorIdTextBox";
            this.DELauthorIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.DELauthorIdTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADD / UPDATE";
            // 
            // authorsDataGridView
            // 
            this.authorsDataGridView.AutoGenerateColumns = false;
            this.authorsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.authorsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.authorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIdDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn});
            this.authorsDataGridView.DataSource = this.authorsBindingSource;
            this.authorsDataGridView.GridColor = System.Drawing.Color.Black;
            this.authorsDataGridView.Location = new System.Drawing.Point(176, 43);
            this.authorsDataGridView.Name = "authorsDataGridView";
            this.authorsDataGridView.Size = new System.Drawing.Size(843, 317);
            this.authorsDataGridView.TabIndex = 5;
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "authorId";
            this.authorIdDataGridViewTextBoxColumn.HeaderText = "authorId";
            this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "authorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "authorName";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "LibraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsSubmit1
            // 
            this.authorsSubmit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorsSubmit1.Location = new System.Drawing.Point(70, 95);
            this.authorsSubmit1.Name = "authorsSubmit1";
            this.authorsSubmit1.Size = new System.Drawing.Size(100, 23);
            this.authorsSubmit1.TabIndex = 4;
            this.authorsSubmit1.Text = "submit";
            this.authorsSubmit1.UseVisualStyleBackColor = true;
            this.authorsSubmit1.Click += new System.EventHandler(this.authorsSubmit1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(70, 69);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorNameTextBox.TabIndex = 1;
            // 
            // authorIdTextBox
            // 
            this.authorIdTextBox.Location = new System.Drawing.Point(70, 43);
            this.authorIdTextBox.Name = "authorIdTextBox";
            this.authorIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorIdTextBox.TabIndex = 0;
            this.authorIdTextBox.Leave += new System.EventHandler(this.authorIdTextBox_Leave);
            // 
            // databaseTabControl
            // 
            this.databaseTabControl.Controls.Add(authorsTab);
            this.databaseTabControl.Controls.Add(this.itemsTab);
            this.databaseTabControl.Controls.Add(this.lendsTab);
            this.databaseTabControl.Controls.Add(this.publishersTab);
            this.databaseTabControl.Controls.Add(this.subscribersTab);
            this.databaseTabControl.Controls.Add(this.workersTab);
            this.databaseTabControl.Location = new System.Drawing.Point(12, 11);
            this.databaseTabControl.Name = "databaseTabControl";
            this.databaseTabControl.SelectedIndex = 0;
            this.databaseTabControl.ShowToolTips = true;
            this.databaseTabControl.Size = new System.Drawing.Size(1050, 407);
            this.databaseTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.databaseTabControl.TabIndex = 0;
            // 
            // itemsTab
            // 
            this.itemsTab.Controls.Add(this.refreshItemsDataGridViewButton);
            this.itemsTab.Controls.Add(this.label15);
            this.itemsTab.Controls.Add(this.label16);
            this.itemsTab.Controls.Add(this.itemLanguageTextBox);
            this.itemsTab.Controls.Add(this.itemGenreTextBox);
            this.itemsTab.Controls.Add(this.label13);
            this.itemsTab.Controls.Add(this.label14);
            this.itemsTab.Controls.Add(this.itemAuthorIdTextBox);
            this.itemsTab.Controls.Add(this.itemPublisherIdTextBox);
            this.itemsTab.Controls.Add(this.label11);
            this.itemsTab.Controls.Add(this.label12);
            this.itemsTab.Controls.Add(this.itemDaysTextBox);
            this.itemsTab.Controls.Add(this.itemCountTextBox);
            this.itemsTab.Controls.Add(this.label5);
            this.itemsTab.Controls.Add(this.itemsSubmit2);
            this.itemsTab.Controls.Add(this.label7);
            this.itemsTab.Controls.Add(this.DELitemIdTextBox);
            this.itemsTab.Controls.Add(this.label8);
            this.itemsTab.Controls.Add(this.itemsDataGridView);
            this.itemsTab.Controls.Add(this.itemsSubmit1);
            this.itemsTab.Controls.Add(this.label9);
            this.itemsTab.Controls.Add(this.label10);
            this.itemsTab.Controls.Add(this.itemNameTextBox);
            this.itemsTab.Controls.Add(this.itemIdTextBox);
            this.itemsTab.Location = new System.Drawing.Point(4, 22);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTab.Size = new System.Drawing.Size(1042, 381);
            this.itemsTab.TabIndex = 1;
            this.itemsTab.Text = "ITEMS";
            this.itemsTab.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "language";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "genre";
            // 
            // itemLanguageTextBox
            // 
            this.itemLanguageTextBox.Location = new System.Drawing.Point(70, 225);
            this.itemLanguageTextBox.Name = "itemLanguageTextBox";
            this.itemLanguageTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemLanguageTextBox.TabIndex = 33;
            // 
            // itemGenreTextBox
            // 
            this.itemGenreTextBox.Location = new System.Drawing.Point(70, 199);
            this.itemGenreTextBox.Name = "itemGenreTextBox";
            this.itemGenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemGenreTextBox.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "author";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "publisher";
            // 
            // itemAuthorIdTextBox
            // 
            this.itemAuthorIdTextBox.Location = new System.Drawing.Point(70, 173);
            this.itemAuthorIdTextBox.Name = "itemAuthorIdTextBox";
            this.itemAuthorIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemAuthorIdTextBox.TabIndex = 29;
            // 
            // itemPublisherIdTextBox
            // 
            this.itemPublisherIdTextBox.Location = new System.Drawing.Point(70, 147);
            this.itemPublisherIdTextBox.Name = "itemPublisherIdTextBox";
            this.itemPublisherIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemPublisherIdTextBox.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "days";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "count";
            // 
            // itemDaysTextBox
            // 
            this.itemDaysTextBox.Location = new System.Drawing.Point(70, 121);
            this.itemDaysTextBox.Name = "itemDaysTextBox";
            this.itemDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemDaysTextBox.TabIndex = 25;
            // 
            // itemCountTextBox
            // 
            this.itemCountTextBox.Location = new System.Drawing.Point(70, 95);
            this.itemCountTextBox.Name = "itemCountTextBox";
            this.itemCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemCountTextBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "DELETE";
            // 
            // itemsSubmit2
            // 
            this.itemsSubmit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsSubmit2.Location = new System.Drawing.Point(70, 337);
            this.itemsSubmit2.Name = "itemsSubmit2";
            this.itemsSubmit2.Size = new System.Drawing.Size(100, 23);
            this.itemsSubmit2.TabIndex = 22;
            this.itemsSubmit2.Text = "submit";
            this.itemsSubmit2.UseVisualStyleBackColor = true;
            this.itemsSubmit2.Click += new System.EventHandler(this.itemsSubmit2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "id";
            // 
            // DELitemIdTextBox
            // 
            this.DELitemIdTextBox.Location = new System.Drawing.Point(70, 311);
            this.DELitemIdTextBox.Name = "DELitemIdTextBox";
            this.DELitemIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.DELitemIdTextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ADD / UPDATE";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AutoGenerateColumns = false;
            this.itemsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemCountDataGridViewTextBoxColumn,
            this.itemAllowedLendDaysDataGridViewTextBoxColumn,
            this.publisherIdDataGridViewTextBoxColumn,
            this.authorIdDataGridViewTextBoxColumn1,
            this.itemGenreDataGridViewTextBoxColumn,
            this.itemLanguageDataGridViewTextBoxColumn});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            this.itemsDataGridView.Location = new System.Drawing.Point(176, 43);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(843, 317);
            this.itemsDataGridView.TabIndex = 18;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "itemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "itemId";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "itemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "itemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemCountDataGridViewTextBoxColumn
            // 
            this.itemCountDataGridViewTextBoxColumn.DataPropertyName = "itemCount";
            this.itemCountDataGridViewTextBoxColumn.HeaderText = "itemCount";
            this.itemCountDataGridViewTextBoxColumn.Name = "itemCountDataGridViewTextBoxColumn";
            // 
            // itemAllowedLendDaysDataGridViewTextBoxColumn
            // 
            this.itemAllowedLendDaysDataGridViewTextBoxColumn.DataPropertyName = "itemAllowedLendDays";
            this.itemAllowedLendDaysDataGridViewTextBoxColumn.HeaderText = "itemAllowedLendDays";
            this.itemAllowedLendDaysDataGridViewTextBoxColumn.Name = "itemAllowedLendDaysDataGridViewTextBoxColumn";
            // 
            // publisherIdDataGridViewTextBoxColumn
            // 
            this.publisherIdDataGridViewTextBoxColumn.DataPropertyName = "publisherId";
            this.publisherIdDataGridViewTextBoxColumn.HeaderText = "publisherId";
            this.publisherIdDataGridViewTextBoxColumn.Name = "publisherIdDataGridViewTextBoxColumn";
            // 
            // authorIdDataGridViewTextBoxColumn1
            // 
            this.authorIdDataGridViewTextBoxColumn1.DataPropertyName = "authorId";
            this.authorIdDataGridViewTextBoxColumn1.HeaderText = "authorId";
            this.authorIdDataGridViewTextBoxColumn1.Name = "authorIdDataGridViewTextBoxColumn1";
            // 
            // itemGenreDataGridViewTextBoxColumn
            // 
            this.itemGenreDataGridViewTextBoxColumn.DataPropertyName = "itemGenre";
            this.itemGenreDataGridViewTextBoxColumn.HeaderText = "itemGenre";
            this.itemGenreDataGridViewTextBoxColumn.Name = "itemGenreDataGridViewTextBoxColumn";
            // 
            // itemLanguageDataGridViewTextBoxColumn
            // 
            this.itemLanguageDataGridViewTextBoxColumn.DataPropertyName = "itemLanguage";
            this.itemLanguageDataGridViewTextBoxColumn.HeaderText = "itemLanguage";
            this.itemLanguageDataGridViewTextBoxColumn.Name = "itemLanguageDataGridViewTextBoxColumn";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // itemsSubmit1
            // 
            this.itemsSubmit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsSubmit1.Location = new System.Drawing.Point(70, 251);
            this.itemsSubmit1.Name = "itemsSubmit1";
            this.itemsSubmit1.Size = new System.Drawing.Size(100, 23);
            this.itemsSubmit1.TabIndex = 17;
            this.itemsSubmit1.Text = "submit";
            this.itemsSubmit1.UseVisualStyleBackColor = true;
            this.itemsSubmit1.Click += new System.EventHandler(this.itemsSubmit1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "id";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(70, 69);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemNameTextBox.TabIndex = 14;
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(70, 43);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemIdTextBox.TabIndex = 13;
            this.itemIdTextBox.Leave += new System.EventHandler(this.itemIdTextBox_Leave);
            // 
            // lendsTab
            // 
            this.lendsTab.Controls.Add(this.refreshLendsDataGridViewButton);
            this.lendsTab.Controls.Add(this.label18);
            this.lendsTab.Controls.Add(this.lendEndDateTextBox);
            this.lendsTab.Controls.Add(this.label19);
            this.lendsTab.Controls.Add(this.label20);
            this.lendsTab.Controls.Add(this.lendStartDateTextBox);
            this.lendsTab.Controls.Add(this.lendQuantityTextBox);
            this.lendsTab.Controls.Add(this.label21);
            this.lendsTab.Controls.Add(this.label22);
            this.lendsTab.Controls.Add(this.lendItemIdTextBox);
            this.lendsTab.Controls.Add(this.lendWorkerIdTextBox);
            this.lendsTab.Controls.Add(this.label23);
            this.lendsTab.Controls.Add(this.lendsSubmit2);
            this.lendsTab.Controls.Add(this.label24);
            this.lendsTab.Controls.Add(this.DELlendIdTextBox);
            this.lendsTab.Controls.Add(this.label25);
            this.lendsTab.Controls.Add(this.lendsDataGridView);
            this.lendsTab.Controls.Add(this.lendsSubmit1);
            this.lendsTab.Controls.Add(this.label26);
            this.lendsTab.Controls.Add(this.label27);
            this.lendsTab.Controls.Add(this.lendSubscriberIdTextBox);
            this.lendsTab.Controls.Add(this.lendIdTextBox);
            this.lendsTab.Location = new System.Drawing.Point(4, 22);
            this.lendsTab.Name = "lendsTab";
            this.lendsTab.Padding = new System.Windows.Forms.Padding(3);
            this.lendsTab.Size = new System.Drawing.Size(1042, 381);
            this.lendsTab.TabIndex = 2;
            this.lendsTab.Text = "LENDS";
            this.lendsTab.UseVisualStyleBackColor = true;
            // 
            // refreshLendsDataGridViewButton
            // 
            this.refreshLendsDataGridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshLendsDataGridViewButton.Location = new System.Drawing.Point(176, 13);
            this.refreshLendsDataGridViewButton.Name = "refreshLendsDataGridViewButton";
            this.refreshLendsDataGridViewButton.Size = new System.Drawing.Size(100, 23);
            this.refreshLendsDataGridViewButton.TabIndex = 58;
            this.refreshLendsDataGridViewButton.Text = "refresh";
            this.refreshLendsDataGridViewButton.UseVisualStyleBackColor = true;
            this.refreshLendsDataGridViewButton.Click += new System.EventHandler(this.refreshLendDataGridViewButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 202);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "end date";
            // 
            // lendEndDateTextBox
            // 
            this.lendEndDateTextBox.Location = new System.Drawing.Point(70, 199);
            this.lendEndDateTextBox.Name = "lendEndDateTextBox";
            this.lendEndDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.lendEndDateTextBox.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 176);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 54;
            this.label19.Text = "start date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 53;
            this.label20.Text = "quantity";
            // 
            // lendStartDateTextBox
            // 
            this.lendStartDateTextBox.Location = new System.Drawing.Point(70, 173);
            this.lendStartDateTextBox.Name = "lendStartDateTextBox";
            this.lendStartDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.lendStartDateTextBox.TabIndex = 52;
            // 
            // lendQuantityTextBox
            // 
            this.lendQuantityTextBox.Location = new System.Drawing.Point(70, 147);
            this.lendQuantityTextBox.Name = "lendQuantityTextBox";
            this.lendQuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.lendQuantityTextBox.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "item";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(25, 98);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "worker";
            // 
            // lendItemIdTextBox
            // 
            this.lendItemIdTextBox.Location = new System.Drawing.Point(70, 121);
            this.lendItemIdTextBox.Name = "lendItemIdTextBox";
            this.lendItemIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.lendItemIdTextBox.TabIndex = 48;
            // 
            // lendWorkerIdTextBox
            // 
            this.lendWorkerIdTextBox.Location = new System.Drawing.Point(70, 95);
            this.lendWorkerIdTextBox.Name = "lendWorkerIdTextBox";
            this.lendWorkerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.lendWorkerIdTextBox.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(67, 260);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "DELETE";
            // 
            // lendsSubmit2
            // 
            this.lendsSubmit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendsSubmit2.Location = new System.Drawing.Point(70, 311);
            this.lendsSubmit2.Name = "lendsSubmit2";
            this.lendsSubmit2.Size = new System.Drawing.Size(100, 23);
            this.lendsSubmit2.TabIndex = 45;
            this.lendsSubmit2.Text = "submit";
            this.lendsSubmit2.UseVisualStyleBackColor = true;
            this.lendsSubmit2.Click += new System.EventHandler(this.lendsSubmit2_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(49, 288);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "id";
            // 
            // DELlendIdTextBox
            // 
            this.DELlendIdTextBox.Location = new System.Drawing.Point(70, 285);
            this.DELlendIdTextBox.Name = "DELlendIdTextBox";
            this.DELlendIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.DELlendIdTextBox.TabIndex = 43;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(67, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 13);
            this.label25.TabIndex = 42;
            this.label25.Text = "ADD / UPDATE";
            // 
            // lendsDataGridView
            // 
            this.lendsDataGridView.AutoGenerateColumns = false;
            this.lendsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.lendsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lendsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lendIdDataGridViewTextBoxColumn,
            this.subscriberIdDataGridViewTextBoxColumn,
            this.workerIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn1,
            this.itemQuantityDataGridViewTextBoxColumn,
            this.lendStartDateDataGridViewTextBoxColumn,
            this.lendFinishDateDataGridViewTextBoxColumn});
            this.lendsDataGridView.DataSource = this.lendsBindingSource;
            this.lendsDataGridView.Location = new System.Drawing.Point(176, 43);
            this.lendsDataGridView.Name = "lendsDataGridView";
            this.lendsDataGridView.Size = new System.Drawing.Size(843, 317);
            this.lendsDataGridView.TabIndex = 41;
            // 
            // lendIdDataGridViewTextBoxColumn
            // 
            this.lendIdDataGridViewTextBoxColumn.DataPropertyName = "lendId";
            this.lendIdDataGridViewTextBoxColumn.HeaderText = "lendId";
            this.lendIdDataGridViewTextBoxColumn.Name = "lendIdDataGridViewTextBoxColumn";
            // 
            // subscriberIdDataGridViewTextBoxColumn
            // 
            this.subscriberIdDataGridViewTextBoxColumn.DataPropertyName = "subscriberId";
            this.subscriberIdDataGridViewTextBoxColumn.HeaderText = "subscriberId";
            this.subscriberIdDataGridViewTextBoxColumn.Name = "subscriberIdDataGridViewTextBoxColumn";
            // 
            // workerIdDataGridViewTextBoxColumn
            // 
            this.workerIdDataGridViewTextBoxColumn.DataPropertyName = "workerId";
            this.workerIdDataGridViewTextBoxColumn.HeaderText = "workerId";
            this.workerIdDataGridViewTextBoxColumn.Name = "workerIdDataGridViewTextBoxColumn";
            // 
            // itemIdDataGridViewTextBoxColumn1
            // 
            this.itemIdDataGridViewTextBoxColumn1.DataPropertyName = "itemId";
            this.itemIdDataGridViewTextBoxColumn1.HeaderText = "itemId";
            this.itemIdDataGridViewTextBoxColumn1.Name = "itemIdDataGridViewTextBoxColumn1";
            // 
            // itemQuantityDataGridViewTextBoxColumn
            // 
            this.itemQuantityDataGridViewTextBoxColumn.DataPropertyName = "itemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.HeaderText = "itemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.Name = "itemQuantityDataGridViewTextBoxColumn";
            // 
            // lendStartDateDataGridViewTextBoxColumn
            // 
            this.lendStartDateDataGridViewTextBoxColumn.DataPropertyName = "lendStartDate";
            this.lendStartDateDataGridViewTextBoxColumn.HeaderText = "lendStartDate";
            this.lendStartDateDataGridViewTextBoxColumn.Name = "lendStartDateDataGridViewTextBoxColumn";
            // 
            // lendFinishDateDataGridViewTextBoxColumn
            // 
            this.lendFinishDateDataGridViewTextBoxColumn.DataPropertyName = "lendFinishDate";
            this.lendFinishDateDataGridViewTextBoxColumn.HeaderText = "lendFinishDate";
            this.lendFinishDateDataGridViewTextBoxColumn.Name = "lendFinishDateDataGridViewTextBoxColumn";
            // 
            // lendsBindingSource
            // 
            this.lendsBindingSource.DataMember = "Lends";
            this.lendsBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // lendsSubmit1
            // 
            this.lendsSubmit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendsSubmit1.Location = new System.Drawing.Point(70, 225);
            this.lendsSubmit1.Name = "lendsSubmit1";
            this.lendsSubmit1.Size = new System.Drawing.Size(100, 23);
            this.lendsSubmit1.TabIndex = 40;
            this.lendsSubmit1.Text = "submit";
            this.lendsSubmit1.UseVisualStyleBackColor = true;
            this.lendsSubmit1.Click += new System.EventHandler(this.lendsSubmit1_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 72);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 39;
            this.label26.Text = "subscriber";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(49, 46);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(15, 13);
            this.label27.TabIndex = 38;
            this.label27.Text = "id";
            // 
            // lendSubscriberIdTextBox
            // 
            this.lendSubscriberIdTextBox.Location = new System.Drawing.Point(70, 69);
            this.lendSubscriberIdTextBox.Name = "lendSubscriberIdTextBox";
            this.lendSubscriberIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.lendSubscriberIdTextBox.TabIndex = 37;
            // 
            // lendIdTextBox
            // 
            this.lendIdTextBox.Location = new System.Drawing.Point(70, 43);
            this.lendIdTextBox.Name = "lendIdTextBox";
            this.lendIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.lendIdTextBox.TabIndex = 36;
            this.lendIdTextBox.Leave += new System.EventHandler(this.lendIdTextBox_Leave);
            // 
            // publishersTab
            // 
            this.publishersTab.Controls.Add(this.refreshPublishersDataGridViewButton);
            this.publishersTab.Controls.Add(this.label31);
            this.publishersTab.Controls.Add(this.label32);
            this.publishersTab.Controls.Add(this.publisherContactTextBox);
            this.publishersTab.Controls.Add(this.publisherAddressTextBox);
            this.publishersTab.Controls.Add(this.label33);
            this.publishersTab.Controls.Add(this.publishersSubmit2);
            this.publishersTab.Controls.Add(this.label34);
            this.publishersTab.Controls.Add(this.DELpublisherIdTextBox);
            this.publishersTab.Controls.Add(this.label35);
            this.publishersTab.Controls.Add(this.publishersDataGridView);
            this.publishersTab.Controls.Add(this.publishersSubmit1);
            this.publishersTab.Controls.Add(this.label36);
            this.publishersTab.Controls.Add(this.label37);
            this.publishersTab.Controls.Add(this.publisherNameTextBox);
            this.publishersTab.Controls.Add(this.publisherIdTextBox);
            this.publishersTab.Location = new System.Drawing.Point(4, 22);
            this.publishersTab.Name = "publishersTab";
            this.publishersTab.Padding = new System.Windows.Forms.Padding(3);
            this.publishersTab.Size = new System.Drawing.Size(1042, 381);
            this.publishersTab.TabIndex = 3;
            this.publishersTab.Text = "PUBLISHERS";
            this.publishersTab.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(21, 124);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(43, 13);
            this.label31.TabIndex = 50;
            this.label31.Text = "contact";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 98);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 13);
            this.label32.TabIndex = 49;
            this.label32.Text = "address";
            // 
            // publisherContactTextBox
            // 
            this.publisherContactTextBox.Location = new System.Drawing.Point(70, 121);
            this.publisherContactTextBox.Name = "publisherContactTextBox";
            this.publisherContactTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherContactTextBox.TabIndex = 48;
            // 
            // publisherAddressTextBox
            // 
            this.publisherAddressTextBox.Location = new System.Drawing.Point(70, 95);
            this.publisherAddressTextBox.Name = "publisherAddressTextBox";
            this.publisherAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherAddressTextBox.TabIndex = 47;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(67, 183);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(49, 13);
            this.label33.TabIndex = 46;
            this.label33.Text = "DELETE";
            // 
            // publishersSubmit2
            // 
            this.publishersSubmit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishersSubmit2.Location = new System.Drawing.Point(70, 234);
            this.publishersSubmit2.Name = "publishersSubmit2";
            this.publishersSubmit2.Size = new System.Drawing.Size(100, 23);
            this.publishersSubmit2.TabIndex = 45;
            this.publishersSubmit2.Text = "submit";
            this.publishersSubmit2.UseVisualStyleBackColor = true;
            this.publishersSubmit2.Click += new System.EventHandler(this.publishersSubmit2_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(49, 211);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(15, 13);
            this.label34.TabIndex = 44;
            this.label34.Text = "id";
            // 
            // DELpublisherIdTextBox
            // 
            this.DELpublisherIdTextBox.Location = new System.Drawing.Point(70, 208);
            this.DELpublisherIdTextBox.Name = "DELpublisherIdTextBox";
            this.DELpublisherIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.DELpublisherIdTextBox.TabIndex = 43;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(67, 18);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(97, 13);
            this.label35.TabIndex = 42;
            this.label35.Text = "ADD / UPDATE";
            // 
            // publishersDataGridView
            // 
            this.publishersDataGridView.AutoGenerateColumns = false;
            this.publishersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.publishersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.publishersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publishersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisherIdDataGridViewTextBoxColumn1,
            this.publisherNameDataGridViewTextBoxColumn,
            this.publisherAddressDataGridViewTextBoxColumn,
            this.publisherContactDataGridViewTextBoxColumn});
            this.publishersDataGridView.DataSource = this.publishersBindingSource;
            this.publishersDataGridView.Location = new System.Drawing.Point(176, 43);
            this.publishersDataGridView.Name = "publishersDataGridView";
            this.publishersDataGridView.Size = new System.Drawing.Size(843, 317);
            this.publishersDataGridView.TabIndex = 41;
            // 
            // publisherIdDataGridViewTextBoxColumn1
            // 
            this.publisherIdDataGridViewTextBoxColumn1.DataPropertyName = "publisherId";
            this.publisherIdDataGridViewTextBoxColumn1.HeaderText = "publisherId";
            this.publisherIdDataGridViewTextBoxColumn1.Name = "publisherIdDataGridViewTextBoxColumn1";
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            this.publisherNameDataGridViewTextBoxColumn.DataPropertyName = "publisherName";
            this.publisherNameDataGridViewTextBoxColumn.HeaderText = "publisherName";
            this.publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            // 
            // publisherAddressDataGridViewTextBoxColumn
            // 
            this.publisherAddressDataGridViewTextBoxColumn.DataPropertyName = "publisherAddress";
            this.publisherAddressDataGridViewTextBoxColumn.HeaderText = "publisherAddress";
            this.publisherAddressDataGridViewTextBoxColumn.Name = "publisherAddressDataGridViewTextBoxColumn";
            // 
            // publisherContactDataGridViewTextBoxColumn
            // 
            this.publisherContactDataGridViewTextBoxColumn.DataPropertyName = "publisherContact";
            this.publisherContactDataGridViewTextBoxColumn.HeaderText = "publisherContact";
            this.publisherContactDataGridViewTextBoxColumn.Name = "publisherContactDataGridViewTextBoxColumn";
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // publishersSubmit1
            // 
            this.publishersSubmit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publishersSubmit1.Location = new System.Drawing.Point(70, 147);
            this.publishersSubmit1.Name = "publishersSubmit1";
            this.publishersSubmit1.Size = new System.Drawing.Size(100, 23);
            this.publishersSubmit1.TabIndex = 40;
            this.publishersSubmit1.Text = "submit";
            this.publishersSubmit1.UseVisualStyleBackColor = true;
            this.publishersSubmit1.Click += new System.EventHandler(this.publishersSubmit1_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(31, 72);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(33, 13);
            this.label36.TabIndex = 39;
            this.label36.Text = "name";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(49, 46);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(15, 13);
            this.label37.TabIndex = 38;
            this.label37.Text = "id";
            // 
            // publisherNameTextBox
            // 
            this.publisherNameTextBox.Location = new System.Drawing.Point(70, 69);
            this.publisherNameTextBox.Name = "publisherNameTextBox";
            this.publisherNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherNameTextBox.TabIndex = 37;
            // 
            // publisherIdTextBox
            // 
            this.publisherIdTextBox.Location = new System.Drawing.Point(70, 43);
            this.publisherIdTextBox.Name = "publisherIdTextBox";
            this.publisherIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherIdTextBox.TabIndex = 36;
            this.publisherIdTextBox.Leave += new System.EventHandler(this.publisherIdTextBox_Leave);
            // 
            // subscribersTab
            // 
            this.subscribersTab.Controls.Add(this.refreshSubscribersDataGridViewButton);
            this.subscribersTab.Controls.Add(this.label30);
            this.subscribersTab.Controls.Add(this.subscriberEmailTextBox);
            this.subscribersTab.Controls.Add(this.label38);
            this.subscribersTab.Controls.Add(this.label39);
            this.subscribersTab.Controls.Add(this.subscriberPhoneTextBox);
            this.subscribersTab.Controls.Add(this.subscriberAddressTextBox);
            this.subscribersTab.Controls.Add(this.label40);
            this.subscribersTab.Controls.Add(this.subscribersSubmit2);
            this.subscribersTab.Controls.Add(this.label41);
            this.subscribersTab.Controls.Add(this.DELsubscriberIdTextBox);
            this.subscribersTab.Controls.Add(this.label42);
            this.subscribersTab.Controls.Add(this.subscribersDataGridView);
            this.subscribersTab.Controls.Add(this.subscribersSubmit1);
            this.subscribersTab.Controls.Add(this.label43);
            this.subscribersTab.Controls.Add(this.label44);
            this.subscribersTab.Controls.Add(this.subscriberNameTextBox);
            this.subscribersTab.Controls.Add(this.subscriberIdTextBox);
            this.subscribersTab.Location = new System.Drawing.Point(4, 22);
            this.subscribersTab.Name = "subscribersTab";
            this.subscribersTab.Padding = new System.Windows.Forms.Padding(3);
            this.subscribersTab.Size = new System.Drawing.Size(1042, 381);
            this.subscribersTab.TabIndex = 4;
            this.subscribersTab.Text = "SUBSCRIBERS";
            this.subscribersTab.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(33, 150);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(31, 13);
            this.label30.TabIndex = 53;
            this.label30.Text = "email";
            // 
            // subscriberEmailTextBox
            // 
            this.subscriberEmailTextBox.Location = new System.Drawing.Point(70, 147);
            this.subscriberEmailTextBox.Name = "subscriberEmailTextBox";
            this.subscriberEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.subscriberEmailTextBox.TabIndex = 51;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(27, 124);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(37, 13);
            this.label38.TabIndex = 50;
            this.label38.Text = "phone";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(20, 98);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 13);
            this.label39.TabIndex = 49;
            this.label39.Text = "address";
            // 
            // subscriberPhoneTextBox
            // 
            this.subscriberPhoneTextBox.Location = new System.Drawing.Point(70, 121);
            this.subscriberPhoneTextBox.Name = "subscriberPhoneTextBox";
            this.subscriberPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.subscriberPhoneTextBox.TabIndex = 48;
            // 
            // subscriberAddressTextBox
            // 
            this.subscriberAddressTextBox.Location = new System.Drawing.Point(70, 95);
            this.subscriberAddressTextBox.Name = "subscriberAddressTextBox";
            this.subscriberAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.subscriberAddressTextBox.TabIndex = 47;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(67, 208);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(49, 13);
            this.label40.TabIndex = 46;
            this.label40.Text = "DELETE";
            // 
            // subscribersSubmit2
            // 
            this.subscribersSubmit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscribersSubmit2.Location = new System.Drawing.Point(70, 259);
            this.subscribersSubmit2.Name = "subscribersSubmit2";
            this.subscribersSubmit2.Size = new System.Drawing.Size(100, 23);
            this.subscribersSubmit2.TabIndex = 45;
            this.subscribersSubmit2.Text = "submit";
            this.subscribersSubmit2.UseVisualStyleBackColor = true;
            this.subscribersSubmit2.Click += new System.EventHandler(this.subscribersSubmit2_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(49, 236);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(15, 13);
            this.label41.TabIndex = 44;
            this.label41.Text = "id";
            // 
            // DELsubscriberIdTextBox
            // 
            this.DELsubscriberIdTextBox.Location = new System.Drawing.Point(70, 233);
            this.DELsubscriberIdTextBox.Name = "DELsubscriberIdTextBox";
            this.DELsubscriberIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.DELsubscriberIdTextBox.TabIndex = 43;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(67, 18);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(97, 13);
            this.label42.TabIndex = 42;
            this.label42.Text = "ADD / UPDATE";
            // 
            // subscribersDataGridView
            // 
            this.subscribersDataGridView.AutoGenerateColumns = false;
            this.subscribersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.subscribersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subscribersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subscribersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscriberIdDataGridViewTextBoxColumn1,
            this.subscriberNameDataGridViewTextBoxColumn,
            this.subscriberAddressDataGridViewTextBoxColumn,
            this.subscriberPhoneDataGridViewTextBoxColumn,
            this.subscriberEmailDataGridViewTextBoxColumn});
            this.subscribersDataGridView.DataSource = this.subscribersBindingSource;
            this.subscribersDataGridView.Location = new System.Drawing.Point(176, 43);
            this.subscribersDataGridView.Name = "subscribersDataGridView";
            this.subscribersDataGridView.Size = new System.Drawing.Size(843, 317);
            this.subscribersDataGridView.TabIndex = 41;
            // 
            // subscriberIdDataGridViewTextBoxColumn1
            // 
            this.subscriberIdDataGridViewTextBoxColumn1.DataPropertyName = "subscriberId";
            this.subscriberIdDataGridViewTextBoxColumn1.HeaderText = "subscriberId";
            this.subscriberIdDataGridViewTextBoxColumn1.Name = "subscriberIdDataGridViewTextBoxColumn1";
            // 
            // subscriberNameDataGridViewTextBoxColumn
            // 
            this.subscriberNameDataGridViewTextBoxColumn.DataPropertyName = "subscriberName";
            this.subscriberNameDataGridViewTextBoxColumn.HeaderText = "subscriberName";
            this.subscriberNameDataGridViewTextBoxColumn.Name = "subscriberNameDataGridViewTextBoxColumn";
            // 
            // subscriberAddressDataGridViewTextBoxColumn
            // 
            this.subscriberAddressDataGridViewTextBoxColumn.DataPropertyName = "subscriberAddress";
            this.subscriberAddressDataGridViewTextBoxColumn.HeaderText = "subscriberAddress";
            this.subscriberAddressDataGridViewTextBoxColumn.Name = "subscriberAddressDataGridViewTextBoxColumn";
            // 
            // subscriberPhoneDataGridViewTextBoxColumn
            // 
            this.subscriberPhoneDataGridViewTextBoxColumn.DataPropertyName = "subscriberPhone";
            this.subscriberPhoneDataGridViewTextBoxColumn.HeaderText = "subscriberPhone";
            this.subscriberPhoneDataGridViewTextBoxColumn.Name = "subscriberPhoneDataGridViewTextBoxColumn";
            // 
            // subscriberEmailDataGridViewTextBoxColumn
            // 
            this.subscriberEmailDataGridViewTextBoxColumn.DataPropertyName = "subscriberEmail";
            this.subscriberEmailDataGridViewTextBoxColumn.HeaderText = "subscriberEmail";
            this.subscriberEmailDataGridViewTextBoxColumn.Name = "subscriberEmailDataGridViewTextBoxColumn";
            // 
            // subscribersBindingSource
            // 
            this.subscribersBindingSource.DataMember = "Subscribers";
            this.subscribersBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // subscribersSubmit1
            // 
            this.subscribersSubmit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subscribersSubmit1.Location = new System.Drawing.Point(70, 173);
            this.subscribersSubmit1.Name = "subscribersSubmit1";
            this.subscribersSubmit1.Size = new System.Drawing.Size(100, 23);
            this.subscribersSubmit1.TabIndex = 40;
            this.subscribersSubmit1.Text = "submit";
            this.subscribersSubmit1.UseVisualStyleBackColor = true;
            this.subscribersSubmit1.Click += new System.EventHandler(this.subscribersSubmit1_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(31, 72);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(33, 13);
            this.label43.TabIndex = 39;
            this.label43.Text = "name";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(49, 46);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(15, 13);
            this.label44.TabIndex = 38;
            this.label44.Text = "id";
            // 
            // subscriberNameTextBox
            // 
            this.subscriberNameTextBox.Location = new System.Drawing.Point(70, 69);
            this.subscriberNameTextBox.Name = "subscriberNameTextBox";
            this.subscriberNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.subscriberNameTextBox.TabIndex = 37;
            // 
            // subscriberIdTextBox
            // 
            this.subscriberIdTextBox.Location = new System.Drawing.Point(70, 43);
            this.subscriberIdTextBox.Name = "subscriberIdTextBox";
            this.subscriberIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.subscriberIdTextBox.TabIndex = 36;
            this.subscriberIdTextBox.Leave += new System.EventHandler(this.subscriberIdTextBox_Leave);
            // 
            // workersTab
            // 
            this.workersTab.Controls.Add(this.refreshWorkersDataGridViewButton);
            this.workersTab.Controls.Add(this.label17);
            this.workersTab.Controls.Add(this.label28);
            this.workersTab.Controls.Add(this.workerStartDateTextBox);
            this.workersTab.Controls.Add(this.workerPhoneTextBox);
            this.workersTab.Controls.Add(this.label29);
            this.workersTab.Controls.Add(this.label45);
            this.workersTab.Controls.Add(this.workerEmailTextBox);
            this.workersTab.Controls.Add(this.workerAddressTextBox);
            this.workersTab.Controls.Add(this.label46);
            this.workersTab.Controls.Add(this.label47);
            this.workersTab.Controls.Add(this.workerRankTextBox);
            this.workersTab.Controls.Add(this.workerPasswordTextBox);
            this.workersTab.Controls.Add(this.label48);
            this.workersTab.Controls.Add(this.workersSubmit2);
            this.workersTab.Controls.Add(this.label49);
            this.workersTab.Controls.Add(this.DELworkersIdTextBox);
            this.workersTab.Controls.Add(this.label50);
            this.workersTab.Controls.Add(this.workersDataGridView);
            this.workersTab.Controls.Add(this.workersSubmit1);
            this.workersTab.Controls.Add(this.label51);
            this.workersTab.Controls.Add(this.label52);
            this.workersTab.Controls.Add(this.workerNameTextBox);
            this.workersTab.Controls.Add(this.workerIdTextBox);
            this.workersTab.Location = new System.Drawing.Point(4, 22);
            this.workersTab.Name = "workersTab";
            this.workersTab.Padding = new System.Windows.Forms.Padding(3);
            this.workersTab.Size = new System.Drawing.Size(1042, 381);
            this.workersTab.TabIndex = 5;
            this.workersTab.Text = "WORKERS";
            this.workersTab.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 58;
            this.label17.Text = "start date";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(27, 202);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 13);
            this.label28.TabIndex = 57;
            this.label28.Text = "phone";
            // 
            // workerStartDateTextBox
            // 
            this.workerStartDateTextBox.Location = new System.Drawing.Point(70, 225);
            this.workerStartDateTextBox.Name = "workerStartDateTextBox";
            this.workerStartDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerStartDateTextBox.TabIndex = 56;
            // 
            // workerPhoneTextBox
            // 
            this.workerPhoneTextBox.Location = new System.Drawing.Point(70, 199);
            this.workerPhoneTextBox.Name = "workerPhoneTextBox";
            this.workerPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerPhoneTextBox.TabIndex = 55;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(33, 176);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 13);
            this.label29.TabIndex = 54;
            this.label29.Text = "email";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(20, 150);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(44, 13);
            this.label45.TabIndex = 53;
            this.label45.Text = "address";
            // 
            // workerEmailTextBox
            // 
            this.workerEmailTextBox.Location = new System.Drawing.Point(70, 173);
            this.workerEmailTextBox.Name = "workerEmailTextBox";
            this.workerEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerEmailTextBox.TabIndex = 52;
            // 
            // workerAddressTextBox
            // 
            this.workerAddressTextBox.Location = new System.Drawing.Point(70, 147);
            this.workerAddressTextBox.Name = "workerAddressTextBox";
            this.workerAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerAddressTextBox.TabIndex = 51;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(36, 124);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(28, 13);
            this.label46.TabIndex = 50;
            this.label46.Text = "rank";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(12, 98);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(52, 13);
            this.label47.TabIndex = 49;
            this.label47.Text = "password";
            // 
            // workerRankTextBox
            // 
            this.workerRankTextBox.Location = new System.Drawing.Point(70, 121);
            this.workerRankTextBox.Name = "workerRankTextBox";
            this.workerRankTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerRankTextBox.TabIndex = 48;
            // 
            // workerPasswordTextBox
            // 
            this.workerPasswordTextBox.Location = new System.Drawing.Point(70, 95);
            this.workerPasswordTextBox.Name = "workerPasswordTextBox";
            this.workerPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerPasswordTextBox.TabIndex = 47;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(67, 286);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(49, 13);
            this.label48.TabIndex = 46;
            this.label48.Text = "DELETE";
            // 
            // workersSubmit2
            // 
            this.workersSubmit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workersSubmit2.Location = new System.Drawing.Point(70, 337);
            this.workersSubmit2.Name = "workersSubmit2";
            this.workersSubmit2.Size = new System.Drawing.Size(100, 23);
            this.workersSubmit2.TabIndex = 45;
            this.workersSubmit2.Text = "submit";
            this.workersSubmit2.UseVisualStyleBackColor = true;
            this.workersSubmit2.Click += new System.EventHandler(this.workersSubmit2_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(49, 314);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(15, 13);
            this.label49.TabIndex = 44;
            this.label49.Text = "id";
            // 
            // DELworkersIdTextBox
            // 
            this.DELworkersIdTextBox.Location = new System.Drawing.Point(70, 311);
            this.DELworkersIdTextBox.Name = "DELworkersIdTextBox";
            this.DELworkersIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.DELworkersIdTextBox.TabIndex = 43;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(67, 18);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(97, 13);
            this.label50.TabIndex = 42;
            this.label50.Text = "ADD / UPDATE";
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.AutoGenerateColumns = false;
            this.workersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.workersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerIdDataGridViewTextBoxColumn1,
            this.workerNameDataGridViewTextBoxColumn,
            this.workerPasswordDataGridViewTextBoxColumn,
            this.workerRankDataGridViewTextBoxColumn,
            this.workerAddressDataGridViewTextBoxColumn,
            this.workerEmailDataGridViewTextBoxColumn,
            this.workerPhoneDataGridViewTextBoxColumn,
            this.workerStartDateDataGridViewTextBoxColumn});
            this.workersDataGridView.DataSource = this.workersBindingSource;
            this.workersDataGridView.Location = new System.Drawing.Point(176, 43);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.Size = new System.Drawing.Size(843, 317);
            this.workersDataGridView.TabIndex = 41;
            // 
            // workerIdDataGridViewTextBoxColumn1
            // 
            this.workerIdDataGridViewTextBoxColumn1.DataPropertyName = "workerId";
            this.workerIdDataGridViewTextBoxColumn1.HeaderText = "workerId";
            this.workerIdDataGridViewTextBoxColumn1.Name = "workerIdDataGridViewTextBoxColumn1";
            // 
            // workerNameDataGridViewTextBoxColumn
            // 
            this.workerNameDataGridViewTextBoxColumn.DataPropertyName = "workerName";
            this.workerNameDataGridViewTextBoxColumn.HeaderText = "workerName";
            this.workerNameDataGridViewTextBoxColumn.Name = "workerNameDataGridViewTextBoxColumn";
            // 
            // workerPasswordDataGridViewTextBoxColumn
            // 
            this.workerPasswordDataGridViewTextBoxColumn.DataPropertyName = "workerPassword";
            this.workerPasswordDataGridViewTextBoxColumn.HeaderText = "workerPassword";
            this.workerPasswordDataGridViewTextBoxColumn.Name = "workerPasswordDataGridViewTextBoxColumn";
            // 
            // workerRankDataGridViewTextBoxColumn
            // 
            this.workerRankDataGridViewTextBoxColumn.DataPropertyName = "workerRank";
            this.workerRankDataGridViewTextBoxColumn.HeaderText = "workerRank";
            this.workerRankDataGridViewTextBoxColumn.Name = "workerRankDataGridViewTextBoxColumn";
            // 
            // workerAddressDataGridViewTextBoxColumn
            // 
            this.workerAddressDataGridViewTextBoxColumn.DataPropertyName = "workerAddress";
            this.workerAddressDataGridViewTextBoxColumn.HeaderText = "workerAddress";
            this.workerAddressDataGridViewTextBoxColumn.Name = "workerAddressDataGridViewTextBoxColumn";
            // 
            // workerEmailDataGridViewTextBoxColumn
            // 
            this.workerEmailDataGridViewTextBoxColumn.DataPropertyName = "workerEmail";
            this.workerEmailDataGridViewTextBoxColumn.HeaderText = "workerEmail";
            this.workerEmailDataGridViewTextBoxColumn.Name = "workerEmailDataGridViewTextBoxColumn";
            // 
            // workerPhoneDataGridViewTextBoxColumn
            // 
            this.workerPhoneDataGridViewTextBoxColumn.DataPropertyName = "workerPhone";
            this.workerPhoneDataGridViewTextBoxColumn.HeaderText = "workerPhone";
            this.workerPhoneDataGridViewTextBoxColumn.Name = "workerPhoneDataGridViewTextBoxColumn";
            // 
            // workerStartDateDataGridViewTextBoxColumn
            // 
            this.workerStartDateDataGridViewTextBoxColumn.DataPropertyName = "workerStartDate";
            this.workerStartDateDataGridViewTextBoxColumn.HeaderText = "workerStartDate";
            this.workerStartDateDataGridViewTextBoxColumn.Name = "workerStartDateDataGridViewTextBoxColumn";
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // workersSubmit1
            // 
            this.workersSubmit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workersSubmit1.Location = new System.Drawing.Point(70, 251);
            this.workersSubmit1.Name = "workersSubmit1";
            this.workersSubmit1.Size = new System.Drawing.Size(100, 23);
            this.workersSubmit1.TabIndex = 40;
            this.workersSubmit1.Text = "submit";
            this.workersSubmit1.UseVisualStyleBackColor = true;
            this.workersSubmit1.Click += new System.EventHandler(this.workersSubmit1_Click);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(31, 72);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(33, 13);
            this.label51.TabIndex = 39;
            this.label51.Text = "name";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(49, 46);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(15, 13);
            this.label52.TabIndex = 38;
            this.label52.Text = "id";
            // 
            // workerNameTextBox
            // 
            this.workerNameTextBox.Location = new System.Drawing.Point(70, 69);
            this.workerNameTextBox.Name = "workerNameTextBox";
            this.workerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerNameTextBox.TabIndex = 37;
            // 
            // workerIdTextBox
            // 
            this.workerIdTextBox.Location = new System.Drawing.Point(70, 43);
            this.workerIdTextBox.Name = "workerIdTextBox";
            this.workerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.workerIdTextBox.TabIndex = 36;
            this.workerIdTextBox.Leave += new System.EventHandler(this.workerIdTextBox_Leave);
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // lendsTableAdapter
            // 
            this.lendsTableAdapter.ClearBeforeFill = true;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // subscribersTableAdapter
            // 
            this.subscribersTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // refreshAuthorsDataGridViewButton
            // 
            this.refreshAuthorsDataGridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshAuthorsDataGridViewButton.Location = new System.Drawing.Point(176, 13);
            this.refreshAuthorsDataGridViewButton.Name = "refreshAuthorsDataGridViewButton";
            this.refreshAuthorsDataGridViewButton.Size = new System.Drawing.Size(100, 23);
            this.refreshAuthorsDataGridViewButton.TabIndex = 13;
            this.refreshAuthorsDataGridViewButton.Text = "refresh";
            this.refreshAuthorsDataGridViewButton.UseVisualStyleBackColor = true;
            this.refreshAuthorsDataGridViewButton.Click += new System.EventHandler(this.refreshAuthorsDataGridViewButton_Click);
            // 
            // refreshItemsDataGridViewButton
            // 
            this.refreshItemsDataGridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshItemsDataGridViewButton.Location = new System.Drawing.Point(176, 13);
            this.refreshItemsDataGridViewButton.Name = "refreshItemsDataGridViewButton";
            this.refreshItemsDataGridViewButton.Size = new System.Drawing.Size(100, 23);
            this.refreshItemsDataGridViewButton.TabIndex = 36;
            this.refreshItemsDataGridViewButton.Text = "refresh";
            this.refreshItemsDataGridViewButton.UseVisualStyleBackColor = true;
            this.refreshItemsDataGridViewButton.Click += new System.EventHandler(this.refreshItemsDataGridViewButton_Click);
            // 
            // refreshPublishersDataGridViewButton
            // 
            this.refreshPublishersDataGridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshPublishersDataGridViewButton.Location = new System.Drawing.Point(176, 13);
            this.refreshPublishersDataGridViewButton.Name = "refreshPublishersDataGridViewButton";
            this.refreshPublishersDataGridViewButton.Size = new System.Drawing.Size(100, 23);
            this.refreshPublishersDataGridViewButton.TabIndex = 51;
            this.refreshPublishersDataGridViewButton.Text = "refresh";
            this.refreshPublishersDataGridViewButton.UseVisualStyleBackColor = true;
            this.refreshPublishersDataGridViewButton.Click += new System.EventHandler(this.refreshPublishersDataGridViewButton_Click);
            // 
            // refreshSubscribersDataGridViewButton
            // 
            this.refreshSubscribersDataGridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshSubscribersDataGridViewButton.Location = new System.Drawing.Point(176, 13);
            this.refreshSubscribersDataGridViewButton.Name = "refreshSubscribersDataGridViewButton";
            this.refreshSubscribersDataGridViewButton.Size = new System.Drawing.Size(100, 23);
            this.refreshSubscribersDataGridViewButton.TabIndex = 54;
            this.refreshSubscribersDataGridViewButton.Text = "refresh";
            this.refreshSubscribersDataGridViewButton.UseVisualStyleBackColor = true;
            this.refreshSubscribersDataGridViewButton.Click += new System.EventHandler(this.refreshSubscribersDataGridViewButton_Click);
            // 
            // refreshWorkersDataGridViewButton
            // 
            this.refreshWorkersDataGridViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshWorkersDataGridViewButton.Location = new System.Drawing.Point(176, 13);
            this.refreshWorkersDataGridViewButton.Name = "refreshWorkersDataGridViewButton";
            this.refreshWorkersDataGridViewButton.Size = new System.Drawing.Size(100, 23);
            this.refreshWorkersDataGridViewButton.TabIndex = 59;
            this.refreshWorkersDataGridViewButton.Text = "refresh";
            this.refreshWorkersDataGridViewButton.UseVisualStyleBackColor = true;
            this.refreshWorkersDataGridViewButton.Click += new System.EventHandler(this.refreshWorkersDataGridViewButton_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 426);
            this.Controls.Add(this.databaseTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            authorsTab.ResumeLayout(false);
            authorsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            this.databaseTabControl.ResumeLayout(false);
            this.itemsTab.ResumeLayout(false);
            this.itemsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.lendsTab.ResumeLayout(false);
            this.lendsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lendsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendsBindingSource)).EndInit();
            this.publishersTab.ResumeLayout(false);
            this.publishersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            this.subscribersTab.ResumeLayout(false);
            this.subscribersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).EndInit();
            this.workersTab.ResumeLayout(false);
            this.workersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl databaseTabControl;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.TabPage itemsTab;
        private System.Windows.Forms.TextBox authorIdTextBox;
        private System.Windows.Forms.Button authorsSubmit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView authorsDataGridView;
        private LibraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LibraryDatabaseDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button authorsSubmit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DELauthorIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox itemLanguageTextBox;
        private System.Windows.Forms.TextBox itemGenreTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox itemAuthorIdTextBox;
        private System.Windows.Forms.TextBox itemPublisherIdTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox itemDaysTextBox;
        private System.Windows.Forms.TextBox itemCountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button itemsSubmit2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DELitemIdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.Button itemsSubmit1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private LibraryDatabaseDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemAllowedLendDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage lendsTab;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox lendEndDateTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox lendStartDateTextBox;
        private System.Windows.Forms.TextBox lendQuantityTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox lendItemIdTextBox;
        private System.Windows.Forms.TextBox lendWorkerIdTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button lendsSubmit2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox DELlendIdTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView lendsDataGridView;
        private System.Windows.Forms.Button lendsSubmit1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox lendSubscriberIdTextBox;
        private System.Windows.Forms.TextBox lendIdTextBox;
        private System.Windows.Forms.BindingSource lendsBindingSource;
        private LibraryDatabaseDataSetTableAdapters.LendsTableAdapter lendsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriberIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lendFinishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage publishersTab;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox publisherContactTextBox;
        private System.Windows.Forms.TextBox publisherAddressTextBox;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button publishersSubmit2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox DELpublisherIdTextBox;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridView publishersDataGridView;
        private System.Windows.Forms.Button publishersSubmit1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox publisherNameTextBox;
        private System.Windows.Forms.TextBox publisherIdTextBox;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private LibraryDatabaseDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage subscribersTab;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox subscriberEmailTextBox;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox subscriberPhoneTextBox;
        private System.Windows.Forms.TextBox subscriberAddressTextBox;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button subscribersSubmit2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox DELsubscriberIdTextBox;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DataGridView subscribersDataGridView;
        private System.Windows.Forms.Button subscribersSubmit1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox subscriberNameTextBox;
        private System.Windows.Forms.TextBox subscriberIdTextBox;
        private System.Windows.Forms.BindingSource subscribersBindingSource;
        private LibraryDatabaseDataSetTableAdapters.SubscribersTableAdapter subscribersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriberIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriberAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriberPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriberEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage workersTab;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox workerStartDateTextBox;
        private System.Windows.Forms.TextBox workerPhoneTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox workerEmailTextBox;
        private System.Windows.Forms.TextBox workerAddressTextBox;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox workerPasswordTextBox;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button workersSubmit2;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox DELworkersIdTextBox;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.Button workersSubmit1;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox workerNameTextBox;
        private System.Windows.Forms.TextBox workerIdTextBox;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private LibraryDatabaseDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerRankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox workerRankTextBox;
        private System.Windows.Forms.Button refreshLendsDataGridViewButton;
        private System.Windows.Forms.Button refreshAuthorsDataGridViewButton;
        private System.Windows.Forms.Button refreshItemsDataGridViewButton;
        private System.Windows.Forms.Button refreshPublishersDataGridViewButton;
        private System.Windows.Forms.Button refreshSubscribersDataGridViewButton;
        private System.Windows.Forms.Button refreshWorkersDataGridViewButton;
    }
}
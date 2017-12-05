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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 246);
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
            this.tabPage1.Size = new System.Drawing.Size(617, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADD LEND";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // submitLendsButton
            // 
            this.submitLendsButton.Location = new System.Drawing.Point(158, 178);
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
            this.label2.Location = new System.Drawing.Point(7, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "books:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "info:";
            // 
            // itemsListView
            // 
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemIdHeader,
            this.itemNameHeader,
            this.itemQuantityHeader,
            this.itemCountHeader});
            this.itemsListView.Location = new System.Drawing.Point(270, 16);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(308, 185);
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
            this.itemNameHeader.Width = 96;
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
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.addBookButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.itemQuantityTextBox);
            this.panel2.Controls.Add(this.itemNameTextBox);
            this.panel2.Location = new System.Drawing.Point(57, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 86);
            this.panel2.TabIndex = 1;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(101, 55);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(100, 23);
            this.addBookButton.TabIndex = 9;
            this.addBookButton.Text = "add";
            this.addBookButton.UseVisualStyleBackColor = true;
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
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subscriberNameTextBox);
            this.panel1.Controls.Add(this.workerNameTextBox);
            this.panel1.Location = new System.Drawing.Point(57, 16);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(579, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LENDS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 244);
            this.Controls.Add(this.tabControl1);
            this.Name = "WorkForm";
            this.Text = "WorkForm";
            this.Shown += new System.EventHandler(this.WorkForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}
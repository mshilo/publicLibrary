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
            this.databaseTabControl = new System.Windows.Forms.TabControl();
            this.authorsPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.authorIdTextBox = new System.Windows.Forms.TextBox();
            this.authorNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authorsSubmit1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryDatabaseDataSet = new publicLibrary.LibraryDatabaseDataSet();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new publicLibrary.LibraryDatabaseDataSetTableAdapters.AuthorsTableAdapter();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseTabControl.SuspendLayout();
            this.authorsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseTabControl
            // 
            this.databaseTabControl.Controls.Add(this.authorsPage);
            this.databaseTabControl.Controls.Add(this.tabPage2);
            this.databaseTabControl.Location = new System.Drawing.Point(0, 0);
            this.databaseTabControl.Name = "databaseTabControl";
            this.databaseTabControl.SelectedIndex = 0;
            this.databaseTabControl.Size = new System.Drawing.Size(735, 349);
            this.databaseTabControl.TabIndex = 0;
            // 
            // authorsPage
            // 
            this.authorsPage.Controls.Add(this.dataGridView1);
            this.authorsPage.Controls.Add(this.authorsSubmit1);
            this.authorsPage.Controls.Add(this.label2);
            this.authorsPage.Controls.Add(this.label1);
            this.authorsPage.Controls.Add(this.authorNameTextBox);
            this.authorsPage.Controls.Add(this.authorIdTextBox);
            this.authorsPage.Location = new System.Drawing.Point(4, 22);
            this.authorsPage.Name = "authorsPage";
            this.authorsPage.Padding = new System.Windows.Forms.Padding(3);
            this.authorsPage.Size = new System.Drawing.Size(727, 323);
            this.authorsPage.TabIndex = 0;
            this.authorsPage.Text = "AUTHORS";
            this.authorsPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // authorIdTextBox
            // 
            this.authorIdTextBox.Location = new System.Drawing.Point(57, 6);
            this.authorIdTextBox.Name = "authorIdTextBox";
            this.authorIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorIdTextBox.TabIndex = 0;
            this.authorIdTextBox.Leave += new System.EventHandler(this.authorIdTextBox_Leave);
            // 
            // authorNameTextBox
            // 
            this.authorNameTextBox.Location = new System.Drawing.Point(57, 32);
            this.authorNameTextBox.Name = "authorNameTextBox";
            this.authorNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "name";
            // 
            // authorsSubmit1
            // 
            this.authorsSubmit1.Location = new System.Drawing.Point(57, 58);
            this.authorsSubmit1.Name = "authorsSubmit1";
            this.authorsSubmit1.Size = new System.Drawing.Size(100, 23);
            this.authorsSubmit1.TabIndex = 4;
            this.authorsSubmit1.Text = "submit";
            this.authorsSubmit1.UseVisualStyleBackColor = true;
            this.authorsSubmit1.Click += new System.EventHandler(this.authorsSubmit1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIdDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.authorsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(163, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 311);
            this.dataGridView1.TabIndex = 5;
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "LibraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
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
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 348);
            this.Controls.Add(this.databaseTabControl);
            this.Name = "DatabaseForm";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            this.databaseTabControl.ResumeLayout(false);
            this.authorsPage.ResumeLayout(false);
            this.authorsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl databaseTabControl;
        private System.Windows.Forms.TabPage authorsPage;
        private System.Windows.Forms.TextBox authorNameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox authorIdTextBox;
        private System.Windows.Forms.Button authorsSubmit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LibraryDatabaseDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
    }
}
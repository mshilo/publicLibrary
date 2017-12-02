using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace publicLibrary
{
    public partial class DatabaseForm : Form
    {
        DbAuthors authors = new DbAuthors();
        DbItems items = new DbItems();

        TextBox[] authorsInput = new TextBox[2];

        public DatabaseForm()
        {
            InitializeComponent();

            authorsInput[0] = authorIdTextBox;
            authorsInput[1] = authorNameTextBox;
        }


        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.libraryDatabaseDataSet.Workers);
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Subscribers' table. You can move, or remove it, as needed.
            this.subscribersTableAdapter.Fill(this.libraryDatabaseDataSet.Subscribers);
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.libraryDatabaseDataSet.Publishers);
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Lends' table. You can move, or remove it, as needed.
            this.lendsTableAdapter.Fill(this.libraryDatabaseDataSet.Lends);
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.libraryDatabaseDataSet.Items);
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.libraryDatabaseDataSet.Authors);
        }

        #region DATAGRIDVIEW TAB FUNCTIONS
        private void UpdateDatabase<Tdb, Titem>(Tdb db, Titem item) where Tdb : DbMain where Titem : BaseItem
        {
            if (!db.Found(item.Id))
                db.Insert(item);
            else
                db.Update(item);
        }

        private void DeleteFromDatabase<Tdb, Titem>(Tdb db, Titem item) where Tdb : DbMain where Titem : BaseItem
        {
            if (db.Found(item.Id))
                db.Delete(item.Id);
        }

        private void TextBoxLeave<Tdb> (Tdb db, TextBox tb, TextBox[] input) where Tdb : DbMain
        {
            MessageBox.Show(tb.Text);
            MessageBox.Show(db.Found(int.Parse(tb.Text)).ToString());
            MessageBox.Show(db.GetInfo(1).Tables[0].Rows[0][1].ToString());
            if (tb.Text != "" && db.Found(int.Parse(tb.Text)))
            {
                DataSet ds = db.GetInfo(int.Parse(tb.Text));
                DataTable dt = ds.Tables[0];

                int i = 0;
                foreach (DataColumn dc in dt.Columns)
                {
                    if (i != 0)
                        input[i].Text = dt.Rows[0][i].ToString();
                    i++;
                }
            }
            else
            {
                foreach (TextBox var in input.Skip(1))
                {
                    var.Text = "";
                }
            }
        }

        private void ClearTextBoxes(TextBox[] txts)
        {
            foreach (var item in txts)
            {
                item.Text = "";
            }
        }
        #endregion

        #region AUTHORS
        // add/update
        private void authorsSubmit1_Click(object sender, EventArgs e)
        {
            Author a = new Author();
            a.Id = int.Parse(authorIdTextBox.Text);
            a.Name = authorNameTextBox.Text;

            UpdateDatabase(authors, a);

            authorsRefreshDataGridView();
        }
        // delete
        private void authorsSubmit2_Click(object sender, EventArgs e)
        {
            authors.Delete(int.Parse(DELauthorIdTextBox.Text));
            authorsRefreshDataGridView();
        }
        // refresh grid
        public void authorsRefreshDataGridView()
        {
            dataGridView1.DataSource = authors.GetAllRecord("AUTHORS").Tables[0];
        }
        // textbox autocomplete
        private void authorIdTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(authors, authorsInput[0], authorsInput);
        }
        #endregion

        private void itemsSubmit1_Click(object sender, EventArgs e)
        {
            Item i = new Item();
            i.Id = int.Parse(itemIdTextBox.Text);
            i.Name = itemNameTextBox.Text;
            i.Count = int.Parse(itemCountTextBox.Text);
            i.AllowedLendDays = int.Parse(itemDaysTextBox.Text);
            i.PublisherId = int.Parse(itemPublisherIdTextBox.Text);
            i.AuthorId = int.Parse(itemAuthorIdTextBox.Text);
            i.Genre = itemGenreTextBox.Text;
            i.Language = itemLanguageTextBox.Text;

            items.Insert(i);

            itemsDataGridView.DataSource = items.GetAllRecord("ITEMS").Tables[0];
        }
    }
}

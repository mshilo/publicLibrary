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

        TextBox[] authorsInput = new TextBox[2];

        public DatabaseForm()
        {
            InitializeComponent();

            authorsInput[0] = authorIdTextBox;
            authorsInput[1] = authorNameTextBox;
        }


        private void DatabaseForm_Load(object sender, EventArgs e)
        {
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
        private void authorsSubmit1_Click(object sender, EventArgs e)
        {
            Author a = new Author();
            a.Id = int.Parse(authorIdTextBox.Text);
            a.Name = authorNameTextBox.Text;

            UpdateDatabase(authors, a);

            authorsRefreshDataGridView();
        }

        public void authorsRefreshDataGridView()
        {
            dataGridView1.DataSource = authors.GetAllRecord("AUTHORS").Tables[0];
        }

        private void authorIdTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(authors, authorsInput[0], authorsInput);
        }
        #endregion

    }
}

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
        DbLends lends = new DbLends();
        DbPublishers publishers = new DbPublishers();
        DbSubscribers subscribers = new DbSubscribers();
        DbWorkers workers = new DbWorkers();

        TextBox[] authorsInput = new TextBox[2];
        TextBox[] itemsInput = new TextBox[8];
        TextBox[] lendsInput = new TextBox[7];
        TextBox[] publishersInput = new TextBox[4];
        TextBox[] subscribersInput = new TextBox[5];
        TextBox[] workersInput = new TextBox[8];

        public DatabaseForm()
        {
            InitializeComponent();

            authorsInput[0] = authorIdTextBox;
            authorsInput[1] = authorNameTextBox;

            itemsInput[0] = itemIdTextBox;
            itemsInput[1] = itemNameTextBox;
            itemsInput[2] = itemCountTextBox;
            itemsInput[3] = itemDaysTextBox;
            itemsInput[4] = itemPublisherIdTextBox;
            itemsInput[5] = itemAuthorIdTextBox;
            itemsInput[6] = itemGenreTextBox;
            itemsInput[7] = itemLanguageTextBox;

            lendsInput[0] = lendIdTextBox;
            lendsInput[1] = lendSubscriberIdTextBox;
            lendsInput[2] = lendWorkerIdTextBox;
            lendsInput[3] = lendItemIdTextBox;
            lendsInput[4] = lendQuantityTextBox;
            lendsInput[5] = lendStartDateTextBox;
            lendsInput[6] = lendEndDateTextBox;

            publishersInput[0] = publisherIdTextBox;
            publishersInput[1] = publisherNameTextBox;
            publishersInput[2] = publisherAddressTextBox;
            publishersInput[3] = publisherContactTextBox;

            subscribersInput[0] = subscriberIdTextBox;
            subscribersInput[1] = subscriberNameTextBox;
            subscribersInput[2] = subscriberAddressTextBox;
            subscribersInput[3] = subscriberPhoneTextBox;
            subscribersInput[4] = subscriberEmailTextBox;

            workersInput[0] = workerIdTextBox;
            workersInput[1] = workerNameTextBox;
            workersInput[2] = workerPasswordTextBox;
            workersInput[3] = workerRankTextBox;
            workersInput[4] = workerAddressTextBox;
            workersInput[5] = workerEmailTextBox;
            workersInput[6] = workerPhoneTextBox;
            workersInput[7] = workerStartDateTextBox;
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

        private void TextBoxLeave<Tdb>(Tdb db, TextBox tb, TextBox[] input) where Tdb : DbMain
        {
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
            authorsDataGridView.DataSource = authors.GetAllRecord("AUTHORS").Tables[0];
        }
        // textbox autocomplete
        private void authorIdTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(authors, authorsInput[0], authorsInput);
        }
        #endregion

        #region ITEMS
        // add/update
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

            UpdateDatabase(items, i);
            itemsRefreshDataGridView();
        }
        // delete 
        private void itemsSubmit2_Click(object sender, EventArgs e)
        {
            items.Delete(int.Parse(DELitemIdTextBox.Text));
            itemsRefreshDataGridView();
        }
        // refresh grid
        public void itemsRefreshDataGridView()
        {
            itemsDataGridView.DataSource = authors.GetAllRecord("ITEMS").Tables[0];
        }
        // textbox autocomplete
        private void itemIdTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(items, itemsInput[0], itemsInput);
        }
        #endregion

        #region LENDS 
        // add/update
        private void lendsSubmit1_Click(object sender, EventArgs e)
        {
            Lend l = new Lend();
            l.Id = int.Parse(lendsInput[0].Text);
            l.SUbscriberId = int.Parse(lendsInput[1].Text);
            l.WorkerId = int.Parse(lendsInput[2].Text);
            l.ItemId = int.Parse(lendsInput[3].Text);
            l.ItemQuantity = int.Parse(lendsInput[4].Text);
            l.StartDate = DateTime.Parse(lendsInput[5].Text);
            l.EndDate = DateTime.Parse(lendsInput[6].Text);

            UpdateDatabase(lends, l);
            lendsRefreshDataGridView();
        }
        // delete
        private void lendsSubmit2_Click(object sender, EventArgs e)
        {
            lends.Delete(int.Parse(DELlendIdTextBox.Text));
            lendsRefreshDataGridView();
        }
        // refresh grid
        public void lendsRefreshDataGridView()
        {
            lendsDataGridView.DataSource = lends.GetAllRecord("LENDS").Tables[0];
        }

        // textbox autocomplete
        private void lendIdTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(lends, lendsInput[0], lendsInput);
        }

        #endregion

        #region PUBLISHERS
        // add/update
        private void publishersSubmit1_Click(object sender, EventArgs e)
        {
            Publisher p = new Publisher();
            p.Id = int.Parse(publishersInput[0].Text);
            p.Name = publishersInput[1].Text;
            p.Address = publishersInput[2].Text;
            p.Contact = publishersInput[3].Text;

            UpdateDatabase(publishers, p);
            publishersRefreshDataGridView();
        }
        // delete
        private void publishersSubmit2_Click(object sender, EventArgs e)
        {
            publishers.Delete(int.Parse(DELpublisherIdTextBox.Text));
            publishersRefreshDataGridView();
        }
        // refresh grid
        public void publishersRefreshDataGridView()
        {
            publishersDataGridView.DataSource = publishers.GetAllRecord("PUBLISHERS").Tables[0];
        }
        // textbox autocomplete
        private void publisherIdTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(publishers, publishersInput[0], publishersInput);
        }

        #endregion

        #region SUBSCRIBERS
        // add/update
        private void subscribersSubmit1_Click(object sender, EventArgs e)
        {
            Subscriber s = new Subscriber();
            s.Id = int.Parse(subscribersInput[0].Text);
            s.Name = subscribersInput[1].Text;
            s.Address = subscribersInput[2].Text;
            s.PhoneNumber = subscribersInput[3].Text;
            s.Email = subscribersInput[4].Text;

            UpdateDatabase(subscribers, s);
            subscribersRefreshDataGridView();
        }
        // delete
        private void subscribersSubmit2_Click(object sender, EventArgs e)
        {
            subscribers.Delete(int.Parse(DELsubscriberIdTextBox.Text));
            subscribersRefreshDataGridView();
        }
        // refresh grid
        public void subscribersRefreshDataGridView ()
        {
            subscribersDataGridView.DataSource = subscribers.GetAllRecord("SUBSCRIBERS").Tables[0];
        }
        // textbox autocomplete
        private void subscriberIdTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(subscribers, subscribersInput[0], subscribersInput);
        }

        #endregion

        #region WORKERS 
        // add/update
        private void workersSubmit1_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();
            w.Id = int.Parse(workersInput[0].Text);
            w.Name = workersInput[1].Text;
            w.Password = workersInput[2].Text;
            w.Rank = int.Parse(workersInput[3].Text);
            w.Address = workersInput[4].Text;
            w.Email = workersInput[5].Text;
            w.PhoneNumber = workersInput[6].Text;
            w.StartDate = DateTime.Parse(workersInput[7].Text);

            UpdateDatabase(workers, w);
            workersRefreshDataGridView();
        }
        // delete
        private void workersSubmit2_Click(object sender, EventArgs e)
        {
            workers.Delete(int.Parse(DELworkersIdTextBox.Text));
            workersRefreshDataGridView();
        }
        // refresh grid
        public void workersRefreshDataGridView()
        {
            workersDataGridView.DataSource = workers.GetAllRecord("WORKERS").Tables[0];
        }
        // textbox autocomplete
        private void workerIdTextBox_Leave(object sender, EventArgs e)
        {
            TextBoxLeave(workers, workersInput[0], workersInput);
        }
        #endregion


    }
}

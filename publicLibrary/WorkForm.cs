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
    public partial class WorkForm : Form
    {

        DbItems items = new DbItems();
        DbWorkers workers = new DbWorkers();
        DbSubscribers subscribers = new DbSubscribers();
        DbLends lends = new DbLends();
        DbPublishers publishers = new DbPublishers();
        DbAuthors authors = new DbAuthors();

        List<Lend> lendsList;
        List<ListViewItem> lvis;

        public WorkForm()
        {
            InitializeComponent();
            lendsList = new List<Lend>();
        }

        private void WorkForm_Shown(object sender, EventArgs e)
        {
            workerNameTextBox.Text = User.Name;
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Lends' table. You can move, or remove it, as needed.
            this.lendsTableAdapter.Fill(this.libraryDatabaseDataSet.Lends);

            DataSetToListView(lends.GetAllRecord("LENDS"));
        }

        #region ADD LEND

        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (items.Found(itemNameTextBox.Text))
            {
                object[] array = items.GetInfo(itemNameTextBox.Text).Tables[0].Rows[0].ItemArray;
                int id = (int)array[0];
                string name = (string)array[1];
                int quantity = int.Parse(itemQuantityTextBox.Text);
                int inStock = (int)array[2];
                int lendDays = int.Parse((string)array[3]);

                //itemsList.Add(new string[3]);
                //itemsList[itemsList.Count - 1][0] = id.ToString();
                //itemsList[itemsList.Count - 1][1] = (inStock - quantity).ToString();
                //itemsList[itemsList.Count - 1][2] = (string)array[3];


                if (inStock - quantity >= 0)
                {
                    int lendId = 0;
                    if (lends.GetAllRecord("LENDS").Tables[0] != null)
                        lendId = lends.GetAllRecord("LENDS").Tables[0].Rows.Count + lendsList.Count;

                    lendsList.Add(
                        new Lend()
                        {
                            Id = lendId,
                            SUbscriberId = (int)subscribers.GetInfo(subscriberNameTextBox.Text).Tables[0].Rows[0].ItemArray[0],
                            WorkerId = (int)workers.GetInfo(User.Name).Tables[0].Rows[0].ItemArray[0],
                            ItemId = id,
                            ItemQuantity = quantity,
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(lendDays)
                        }
                        );

                    inStock -= quantity;

                    ListViewItem lvi = new ListViewItem(id.ToString());
                    lvi.SubItems.Add(name);
                    lvi.SubItems.Add(quantity.ToString());
                    lvi.SubItems.Add(inStock.ToString());
                    itemsListView.Items.Add(lvi);
                    itemsListView.Update();

                }
                else
                {
                    MessageBox.Show("none in stock");
                }

                itemNameTextBox.Text = "";
                itemQuantityTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("item doesnt exist");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in lendsList)
            {
                lends.Insert(item);
                items.UpdateStock(item.ItemId, -item.ItemQuantity);
            }

            DataSetToListView(lends.GetAllRecord("LENDS"));
            lendsListViewRefreshButton_Click(null, null);

            subscriberNameTextBox.Text = "";
            itemsListView.Items.Clear();
            itemsListView.Refresh();

        }

        #endregion

        #region LENDS

        private void searchByLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchComboBox_TextChanged(object sender, EventArgs e)
        {
            if (lendsSearchComboBox.Text != "" && lendsSearchComboBox.Items.Contains(lendsSearchComboBox.Text))
            {
                lendsSearchByLabel.Text = lendsSearchComboBox.Text + ":";
                lendsSearchInput.Enabled = true;
                lendsSearchButton.Enabled = true;
            }
            else
            {
                lendsSearchByLabel.Text = "";
                lendsSearchInput.Enabled = false;
                lendsSearchButton.Enabled = false;
            }
        }

        private void DataSetToListView(DataSet ds)
        {
            DataTable dt = ds.Tables[0];
            lvis = new List<ListViewItem>();
            ListViewItem lvi;

            foreach (DataRow dr in dt.Rows)
            {
                lvi = new ListViewItem();
                lvi.SubItems.Add((string)items.GetInfo((int)dr[3]).Tables[0].Rows[0][1]);
                lvi.SubItems.Add(((int)dr[4]).ToString());
                lvi.SubItems.Add((string)subscribers.GetInfo((int)dr[1]).Tables[0].Rows[0][1]);
                lvi.SubItems.Add(((DateTime)(dr[6])).Date.ToString());

                lvis.Add(lvi);
            }

            lendsListViewRefreshButton_Click(null, null);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString = lendsSearchInput.Text;
            string sql = "";
            int id = 0;

            switch (lendsSearchComboBox.Text)
            {
                case "item":
                    sql = string.Format("SELECT * FROM Items WHERE itemName='{0}'", searchString);
                    if (items.Found(searchString))
                        id = (int)(items.GetQuery(sql).Tables[0].Rows[0][0]);
                    sql = string.Format("SELECT * FROM Lends WHERE itemId={0}", id);
                    DataSetToListView(lends.GetQuery(sql));
                    break;
                case "subscriber":
                    sql = string.Format("SELECT * FROM Subscribers WHERE subscriberName='{0}'", searchString);
                    if (subscribers.Found(searchString))
                        id = (int)(subscribers.GetQuery(sql).Tables[0].Rows[0][0]);
                    sql = string.Format("SELECT * FROM Lends WHERE subscriberId={0}", id);
                    DataSetToListView(lends.GetQuery(sql));
                    break;
                case "end date":
                    sql = string.Format("SELECT * FROM Lends WHERE  lendFinishDate LIKE '%{0}%'", searchString);
                    DataSetToListView(lends.GetQuery(sql));
                    break;
                default:
                    break;
            }
        }

        public List<ListViewItem> SortListViewItemsByDate(List<ListViewItem> litems)
        {
            ListViewItem temp;
            List<ListViewItem> temps = litems;
            for (int i = 0; i < litems.Count; i++)
            {
                for (int j = 1; j < litems.Count; j++)
                {
                    if (DateTime.Parse(temps[j].SubItems[4].Text) < DateTime.Parse(temps[j - 1].SubItems[4].Text))
                    {
                        temp = temps[j - 1];
                        temps[j - 1] = temps[j];
                        temps[j] = temp;
                    }
                }
            }

            return temps;
        }

        private void lendsListViewRefreshButton_Click(object sender, EventArgs e)
        {
            lendsListView.Items.Clear();
            lvis = SortListViewItemsByDate(lvis);
            foreach (var item in lvis)
            {
                lendsListView.Items.Add(item);
                if (DateTime.Now > DateTime.Parse(item.SubItems[4].Text))
                    lendsListView.Items[lendsListView.Items.Count - 1].BackColor = Color.Tomato;
            }

            lendsListView.Refresh();
        }

        private void updateLendList_Click(object sender, EventArgs e)
        {
            List<ListViewItem> lvitems = new List<ListViewItem>();

            for (int i = 0; i < lendsListView.Items.Count; i++)
            {
                if (lendsListView.Items[i].Checked == true)
                {
                    lvitems.Add(lendsListView.Items[i]);
                }
            }

            foreach (var item in lvitems)
                lvis.Remove(item);


            foreach (var item in lvitems)
            {
                // update item quantity
                items.UpdateStock(int.Parse(items.GetInfo(item.SubItems[1].Text).Tables[0].Rows[0][0].ToString()), int.Parse(item.SubItems[2].Text));
                // remove entry from lends table
                lends.Remove(
                    int.Parse(items.GetInfo(item.SubItems[1].Text).Tables[0].Rows[0][0].ToString()),
                    int.Parse(subscribers.GetInfo(item.SubItems[3].Text).Tables[0].Rows[0][0].ToString()),
                    int.Parse(item.SubItems[2].Text)
                    );
            }
            lendsListViewRefreshButton_Click(null, null);
        }

        #endregion

        private void lendsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            booksDataGridView.DataSource = null;
            string searchString = "";
            string sql = "";
            DataSet temp;

            switch (booksSearchComboBox.Text)
            {
                case "name":
                    searchString = booksSearchInput.Text;
                    UpdateBooksDataGridView(items.GetInfo(searchString));
                    break;

                case "publisher":
                    if (publishers.Found(booksSearchInput.Text))
                    {
                        temp = publishers.GetInfo(booksSearchInput.Text);
                        UpdateBooksDataGridView(items.GetInfoByPublisher((int)temp.Tables[0].Rows[0].ItemArray[0]));
                    }
                    break;

                case "author":
                    if (authors.Found(booksSearchInput.Text))
                    {
                        temp = authors.GetInfo(booksSearchInput.Text);
                        UpdateBooksDataGridView(items.GetInfoByAuthor((int)temp.Tables[0].Rows[0][0]));
                    }
                    break;

                case "genre":
                    searchString = booksSearchInput.Text;
                    UpdateBooksDataGridView(items.GetInfoByGenre(searchString));
                    break;

                case "language":
                    searchString = booksSearchInput.Text;
                    UpdateBooksDataGridView(items.GetInfoByGenre(searchString));
                    break;

                default:
                    break;
            }
        }

        private void UpdateBooksDataGridView (DataSet ds)
        {
            DataTable d1 = ds.Tables[0];
            DataTable d2 = new DataTable();

            DataRow row;

            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "id";
            d2.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "name";
            d2.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "count";
            d2.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "publisher";
            d2.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "author";
            d2.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "genre";
            d2.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "language";
            d2.Columns.Add(column);

            foreach (DataRow i in d1.Rows)
            {
                row = d2.NewRow();
                row["id"]        = (int)i[0];
                row["name"]      = (string)i[1];
                row["count"]     = (int)i[2];
                row["publisher"] = (string)publishers.GetInfo((int)i[4]).Tables[0].Rows[0][1];
                row["author"]    = (string)authors.GetInfo((int)i[5]).Tables[0].Rows[0][1];
                row["genre"]     = (string)i[6];
                row["language"]  = (string)i[7];
                d2.Rows.Add(row);
            }


            booksDataGridView.DataSource = d2;
            booksDataGridView.Refresh();
        }

        private void lendsSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void booksSearchComboBox_TextChanged(object sender, EventArgs e)
        {
            if (booksSearchComboBox.Text != "" && booksSearchComboBox.Items.Contains(booksSearchComboBox.Text))
            {
                booksSearchByLabel.Text = booksSearchComboBox.Text + ":";
                booksSearchInput.Enabled = true;
                booksSearchButton.Enabled = true;
            }
            else
            {
                booksSearchByLabel.Text = "";
                booksSearchInput.Enabled = false;
                booksSearchButton.Enabled = false;
            }
        }
    }
}

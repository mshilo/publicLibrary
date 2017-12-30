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

        List<Lend> lendsList;
        List<ListViewItem> lvis;

        public WorkForm()
        {
            InitializeComponent();
            lendsList = new List<Lend>();
        }

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

        private void searchByLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchComboBox_TextChanged(object sender, EventArgs e)
        {
            if (searchComboBox.Text != "" && searchComboBox.Items.Contains(searchComboBox.Text))
            {
                searchByLabel.Text = searchComboBox.Text + ":";
                searchInput.Enabled = true;
                searchButton.Enabled = true;
            }
            else
            {
                searchByLabel.Text = "";
                searchInput.Enabled = false;
                searchButton.Enabled = false;
            }
        }

        private void DataSetToListView (DataSet ds)
        {
            // TODO: sort dt by date
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

            lendsListViewRefreshButton_Click(null,null);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchString = searchInput.Text;
            string sql = "";
            int id = 0;

            switch (searchComboBox.Text)
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

        public List<ListViewItem> SortListViewItemsByDate (List<ListViewItem> litems)
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
            // DOTO: return every lend that has been marked to the library
            List<ListViewItem> lvitems = new List<ListViewItem>();

            for (int i =0; i < lendsListView.Items.Count; i++)
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

        private void lendsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

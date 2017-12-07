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

        // TODO: put a dataGridView with the Lends table sorted by closest date in the VIEW LENDS tab 

        DbItems items = new DbItems();
        DbWorkers workers = new DbWorkers();
        DbSubscribers subscribers = new DbSubscribers();
        DbLends lends = new DbLends();
        List<Lend> lendsList;

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
                            WorkerId = (int)workers.GetInfo(Program.WorkerName).Tables[0].Rows[0].ItemArray[0],
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
                items.UpdateStock(item.ItemId, item.ItemQuantity);
            }

            subscriberNameTextBox.Text = "";
            itemsListView.Items.Clear();
            itemsListView.Refresh();

            MessageBox.Show("DONE");
        }

        private void WorkForm_Shown(object sender, EventArgs e)
        {
            workerNameTextBox.Text = Program.WorkerName;
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {

        }
    }
}

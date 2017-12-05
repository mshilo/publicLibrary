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
    public partial class MainForm : Form
    {
        DbWorkers db = new DbWorkers();

        public MainForm()
        {
            InitializeComponent();
        }

        private void launchDatabaseFormButton_Click(object sender, EventArgs e)
        {
            DatabaseForm dbForm = new DatabaseForm();
            Item i = new Item();
            dbForm.Show();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string s = workerPasswordTextBox.Text;
            if (db.LogIn(s) != "invalid password")
            {
                Program.WorkerName = db.LogIn(s);
                nameLabel.Text = "welcome " + db.LogIn(s);
                workerPasswordTextBox.Enabled = false;
                logInButton.Enabled = false;
            }
        }

        private void launchWorkFormButton_Click(object sender, EventArgs e)
        {
            WorkForm wForm = new WorkForm();
            wForm.Show();
        }
    }
}

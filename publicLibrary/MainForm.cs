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
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
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
            if (db.LogIn(s) != null)
            {
                string[] userInfo = db.LogIn(s);

                User.Name = userInfo[0];
                User.Password = s;
                User.Rank = int.Parse(userInfo[2]);
                User.ID = int.Parse(userInfo[3]);

                nameLabel.Text = "welcome " + User.Name;

                workerPasswordTextBox.Enabled = false;
                logInButton.Enabled = false;

                launchWorkFormButton.Enabled = true;
                launchDatabaseFormButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("invalid password");
            }
        }

        private void launchWorkFormButton_Click(object sender, EventArgs e)
        {
            WorkForm wForm = new WorkForm();
            wForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

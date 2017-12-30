namespace publicLibrary
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.launchDatabaseFormButton = new System.Windows.Forms.Button();
            this.launchWorkFormButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.workerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // launchDatabaseFormButton
            // 
            resources.ApplyResources(this.launchDatabaseFormButton, "launchDatabaseFormButton");
            this.launchDatabaseFormButton.Name = "launchDatabaseFormButton";
            this.launchDatabaseFormButton.UseVisualStyleBackColor = true;
            this.launchDatabaseFormButton.Click += new System.EventHandler(this.launchDatabaseFormButton_Click);
            // 
            // launchWorkFormButton
            // 
            resources.ApplyResources(this.launchWorkFormButton, "launchWorkFormButton");
            this.launchWorkFormButton.Name = "launchWorkFormButton";
            this.launchWorkFormButton.UseVisualStyleBackColor = true;
            this.launchWorkFormButton.Click += new System.EventHandler(this.launchWorkFormButton_Click);
            // 
            // logInButton
            // 
            resources.ApplyResources(this.logInButton, "logInButton");
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logInButton.Name = "logInButton";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // workerPasswordTextBox
            // 
            resources.ApplyResources(this.workerPasswordTextBox, "workerPasswordTextBox");
            this.workerPasswordTextBox.Name = "workerPasswordTextBox";
            this.workerPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.workerPasswordTextBox);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.launchWorkFormButton);
            this.Controls.Add(this.launchDatabaseFormButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchDatabaseFormButton;
        private System.Windows.Forms.Button launchWorkFormButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox workerPasswordTextBox;
        private System.Windows.Forms.Label nameLabel;
    }
}


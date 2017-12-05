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
            this.launchDatabaseFormButton = new System.Windows.Forms.Button();
            this.launchWorkFormButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.workerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // launchDatabaseFormButton
            // 
            this.launchDatabaseFormButton.Location = new System.Drawing.Point(12, 197);
            this.launchDatabaseFormButton.Name = "launchDatabaseFormButton";
            this.launchDatabaseFormButton.Size = new System.Drawing.Size(260, 23);
            this.launchDatabaseFormButton.TabIndex = 0;
            this.launchDatabaseFormButton.Text = "database form";
            this.launchDatabaseFormButton.UseVisualStyleBackColor = true;
            this.launchDatabaseFormButton.Click += new System.EventHandler(this.launchDatabaseFormButton_Click);
            // 
            // launchWorkFormButton
            // 
            this.launchWorkFormButton.Location = new System.Drawing.Point(12, 226);
            this.launchWorkFormButton.Name = "launchWorkFormButton";
            this.launchWorkFormButton.Size = new System.Drawing.Size(260, 23);
            this.launchWorkFormButton.TabIndex = 1;
            this.launchWorkFormButton.Text = "work form";
            this.launchWorkFormButton.UseVisualStyleBackColor = true;
            this.launchWorkFormButton.Click += new System.EventHandler(this.launchWorkFormButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(197, 12);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 23);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.UseWaitCursor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // workerPasswordTextBox
            // 
            this.workerPasswordTextBox.Location = new System.Drawing.Point(12, 14);
            this.workerPasswordTextBox.Name = "workerPasswordTextBox";
            this.workerPasswordTextBox.PasswordChar = '*';
            this.workerPasswordTextBox.Size = new System.Drawing.Size(179, 20);
            this.workerPasswordTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 48);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.workerPasswordTextBox);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.launchWorkFormButton);
            this.Controls.Add(this.launchDatabaseFormButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
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


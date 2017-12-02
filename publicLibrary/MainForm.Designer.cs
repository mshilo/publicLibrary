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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.launchWorkFormButton);
            this.Controls.Add(this.launchDatabaseFormButton);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launchDatabaseFormButton;
        private System.Windows.Forms.Button launchWorkFormButton;
    }
}


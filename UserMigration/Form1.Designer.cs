namespace UserMigration
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.copyChromeDataCheckBox = new System.Windows.Forms.CheckBox();
            this.copyFireFoxCheckBox = new System.Windows.Forms.CheckBox();
            this.copyUsersFolderCheckBox = new System.Windows.Forms.CheckBox();
            this.migrateButton = new System.Windows.Forms.Button();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.Controls.Add(this.userComboBox);
            this.backgroundPanel.Controls.Add(this.copyChromeDataCheckBox);
            this.backgroundPanel.Controls.Add(this.copyFireFoxCheckBox);
            this.backgroundPanel.Controls.Add(this.copyUsersFolderCheckBox);
            this.backgroundPanel.Controls.Add(this.migrateButton);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(253, 174);
            this.backgroundPanel.TabIndex = 6;
            // 
            // copyChromeDataCheckBox
            // 
            this.copyChromeDataCheckBox.AutoSize = true;
            this.copyChromeDataCheckBox.Location = new System.Drawing.Point(51, 62);
            this.copyChromeDataCheckBox.Name = "copyChromeDataCheckBox";
            this.copyChromeDataCheckBox.Size = new System.Drawing.Size(134, 17);
            this.copyChromeDataCheckBox.TabIndex = 15;
            this.copyChromeDataCheckBox.Text = "Copy Old Chrome Data";
            this.copyChromeDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyFireFoxCheckBox
            // 
            this.copyFireFoxCheckBox.AutoSize = true;
            this.copyFireFoxCheckBox.Location = new System.Drawing.Point(51, 85);
            this.copyFireFoxCheckBox.Name = "copyFireFoxCheckBox";
            this.copyFireFoxCheckBox.Size = new System.Drawing.Size(129, 17);
            this.copyFireFoxCheckBox.TabIndex = 14;
            this.copyFireFoxCheckBox.Text = "Copy Old Firefox Data";
            this.copyFireFoxCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyUsersFolderCheckBox
            // 
            this.copyUsersFolderCheckBox.AutoSize = true;
            this.copyUsersFolderCheckBox.Checked = true;
            this.copyUsersFolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyUsersFolderCheckBox.Location = new System.Drawing.Point(51, 39);
            this.copyUsersFolderCheckBox.Name = "copyUsersFolderCheckBox";
            this.copyUsersFolderCheckBox.Size = new System.Drawing.Size(119, 17);
            this.copyUsersFolderCheckBox.TabIndex = 13;
            this.copyUsersFolderCheckBox.Text = "Copy Previous User";
            this.copyUsersFolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // migrateButton
            // 
            this.migrateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.migrateButton.Location = new System.Drawing.Point(32, 110);
            this.migrateButton.Margin = new System.Windows.Forms.Padding(2);
            this.migrateButton.Name = "migrateButton";
            this.migrateButton.Size = new System.Drawing.Size(172, 53);
            this.migrateButton.TabIndex = 11;
            this.migrateButton.Text = "Migrate";
            this.migrateButton.UseVisualStyleBackColor = true;
            this.migrateButton.Click += new System.EventHandler(this.migrateButton_ClickAsync);
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(13, 13);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(228, 21);
            this.userComboBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 174);
            this.Controls.Add(this.backgroundPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(269, 213);
            this.MinimumSize = new System.Drawing.Size(269, 213);
            this.Name = "Form1";
            this.Text = "UserMigration";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.CheckBox copyChromeDataCheckBox;
        private System.Windows.Forms.CheckBox copyFireFoxCheckBox;
        private System.Windows.Forms.CheckBox copyUsersFolderCheckBox;
        private System.Windows.Forms.Button migrateButton;
        private System.Windows.Forms.ComboBox userComboBox;
    }
}


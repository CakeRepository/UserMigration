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
            this.migrateButton = new System.Windows.Forms.Button();
            this.userFoldersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // migrateButton
            // 
            this.migrateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.migrateButton.Location = new System.Drawing.Point(63, 117);
            this.migrateButton.Margin = new System.Windows.Forms.Padding(2);
            this.migrateButton.Name = "migrateButton";
            this.migrateButton.Size = new System.Drawing.Size(213, 48);
            this.migrateButton.TabIndex = 1;
            this.migrateButton.Text = "Migrate";
            this.migrateButton.UseVisualStyleBackColor = true;
            this.migrateButton.Click += new System.EventHandler(this.migrateButton_Click);
            // 
            // userFoldersComboBox
            // 
            this.userFoldersComboBox.FormattingEnabled = true;
            this.userFoldersComboBox.Location = new System.Drawing.Point(63, 54);
            this.userFoldersComboBox.Name = "userFoldersComboBox";
            this.userFoldersComboBox.Size = new System.Drawing.Size(213, 21);
            this.userFoldersComboBox.TabIndex = 2;
            this.userFoldersComboBox.SelectedIndexChanged += new System.EventHandler(this.userFoldersComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 211);
            this.Controls.Add(this.userFoldersComboBox);
            this.Controls.Add(this.migrateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "UserMigration";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button migrateButton;
        private System.Windows.Forms.ComboBox userFoldersComboBox;
    }
}


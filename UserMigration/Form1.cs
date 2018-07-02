using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMigration
{
    public partial class Form1 : Form
    {
        List<string> FoldersToCopy = new List<string>() { "Desktop", "Favorites"};
        private string chromeLocation = @"C:\Users\";
        private string chromeLocationAfterUser = @"\AppData\Local\Google\Chrome\User Data\Default";
        string userName = WindowsIdentity.GetCurrent().Name;
        private string[] CurrentUser;
        public Form1()
        {
            InitializeComponent();
             CurrentUser = userName.Split('\\');
        }
        private void migrateButton_Click(object sender, EventArgs e)
        {
            SetFullAccessPermission(@"c:\users\" + oldUserNameTextBox.Text, userName);


            foreach (var folder in FoldersToCopy)
            {
                SetFullAccessPermission(@"c:\users\" + oldUserNameTextBox.Text + @"\" + folder, userName);
                Copy(@"C:\users\" + oldUserNameTextBox.Text + @"\" + folder, @"C:\users\"+ CurrentUser[1] + @"\" + folder);
            }

            try
            {
                string dirSource = chromeLocation + oldUserNameTextBox.Text + chromeLocationAfterUser;
                string dirDestination = @"C:\users\"+ CurrentUser[1] + @"\appdata\local\Google\chrome\User Data\Default";

                Copy(dirSource,dirDestination);
            }
            catch
            {
                MessageBox.Show("Error Copying Chrome if Chrome is open please close");
            }
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            foreach (string dirPath in Directory.GetDirectories(sourceDirectory, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(sourceDirectory, targetDirectory));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourceDirectory, "*.*",
                SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(sourceDirectory, targetDirectory), true);
        }
        public static void SetFullAccessPermission(string directoryPath, string username)
        {
            DirectorySecurity dir_security = Directory.GetAccessControl(directoryPath);

            FileSystemAccessRule full_access_rule = new FileSystemAccessRule(username,
                FileSystemRights.FullControl, InheritanceFlags.ContainerInherit |
                                              InheritanceFlags.ObjectInherit, PropagationFlags.None,
                AccessControlType.Allow);

            dir_security.AddAccessRule(full_access_rule);

            Directory.SetAccessControl(directoryPath, dir_security);
        }
    }
}

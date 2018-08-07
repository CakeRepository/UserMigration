using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
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
        private string oldUser;
        public Form1()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            CurrentUser = userName.Split('\\');
            folderInit();
        }
        
        async Task<int> doWork()
        {

            SetFullAccessPermission(@"c:\users\" + oldUser, userName);
            if (copyUsersFolderCheckBox.Checked)
            {
                foreach (var folder in FoldersToCopy)
                {
                    SetFullAccessPermission(@"c:\users\" + oldUser + @"\" + folder, userName);
                    Copy(@"C:\users\" + oldUser + @"\" + folder, @"C:\users\" + CurrentUser[1] + @"\" + folder);
                }
            }
            if (copyChromeDataCheckBox.Checked)
            {
                try
                {
                    string dirSource = chromeLocation + oldUser + chromeLocationAfterUser;
                    string dirDestination = @"C:\users\" + CurrentUser[1] + @"\appdata\local\Google\chrome\User Data\Default";

                    Copy(dirSource, dirDestination);
                }
                catch
                {
                    MessageBox.Show("Error Copying Chrome if Chrome is open please close");
                }
            }
            if (copyFireFoxCheckBox.Checked)
            {
                transferFirefox();
            }
            return 0;
        }
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            foreach (string dirPath in Directory.GetDirectories(sourceDirectory, "*",
                SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(sourceDirectory, targetDirectory));
            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourceDirectory, "*.*",
                SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourceDirectory, targetDirectory), true);
            }
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

        void folderInit()
        {
            string[] dirsIndirectory = Directory.GetDirectories(@"c:\users");
            var folders = dirSplitByFolder(dirsIndirectory);
            foreach (var folder in folders)
            {
                userComboBox.Items.Add(folder);
            }
        }
        
        string[] dirSplitByFolder(string[] directories)
        {
            string[] dir = new string[directories.Length];
            for (int i = 0; i < directories.Length; i++)
            {
                var splitDir = directories[i].Split('\\');
                dir[i] = splitDir[2];
            }
            return dir; 
        }

        private void transferFirefox()
        {
            var newFirefoxLocation =  @"C:\Users\"+ CurrentUser[1] + @"\AppData\Roaming\Mozilla\Firefox";
            var oldFirefoxLocation = @"C:\Users\" + oldUser + @"\AppData\Roaming\Mozilla\Firefox";
            //Copies ini
            Copy(oldFirefoxLocation,newFirefoxLocation);
        }

        private async void migrateButton_ClickAsync(object sender, EventArgs e)
        {
            oldUser = userComboBox.Text;
            Panel p = new Panel();
            p.Dock = DockStyle.Fill;
            p.BackColor = Color.White;
            p.Visible = true;

            Label loading = new Label();
            loading.Text = "Loading";
            loading.Dock = DockStyle.Top;
            p.Controls.Add(loading);
            
            backgroundPanel.Controls.Add(p);
            p.BringToFront();
            migrateButton.Enabled = false;
            await Task.Run(() => doWork());
            migrateButton.Enabled = true;

            p.Dispose();
        }
    }
}

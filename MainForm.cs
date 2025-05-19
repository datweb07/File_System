using System;
using System.Windows.Forms;

namespace File_System
{
    public partial class MainForm : Form
    {
        // Khai báo các biến cho FAT và Inode-based FS
        public FAT fat;
        public InodeBasedFS inodeFS;

        public MainForm()
        {
            InitializeComponent();
            fat = new FAT();
            inodeFS = new InodeBasedFS();
            UpdateDisplay();
        }

        public void btnCreateFATFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtFATFileName.Text;
                int size = int.Parse(txtFATFileSize.Text);
                if (fat.CreateFile(fileName, size))
                {
                    MessageBox.Show("File created successfully in FAT!");
                    UpdateDisplay();
                }
                else
                {
                    MessageBox.Show("Failed to create file in FAT: Not enough space!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void btnCreateInodeFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtInodeFileName.Text;
                int size = int.Parse(txtInodeFileSize.Text);
                if (inodeFS.CreateFile(fileName, size))
                {
                    MessageBox.Show("File created successfully in Inode-based FS!");
                    UpdateDisplay();
                }
                else
                {
                    MessageBox.Show("Failed to create file in Inode-based FS: Not enough space!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void UpdateDisplay()
        {
            txtFATInfo.Text = fat.GetFileSystemInfo();         // Hiển thị thông tin FAT
            txtInodeInfo.Text = inodeFS.GetFileSystemInfo();   // Hiển thị thông tin Inode-based FS
        }
    }
}

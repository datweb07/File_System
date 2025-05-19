using System;
using System.Windows.Forms;

namespace File_System
{
    public partial class MainForm : Form
    {
        public FAT fat;
        public InodeBasedFS inodeFS;

        public MainForm()
        {
            InitializeComponent();
            fat = new FAT();
            inodeFS = new InodeBasedFS();
            UpdateDisplay();
        }

        private void btnCreateFATFile_Click(object sender, EventArgs e)
        {
            string name = txtFATFileName.Text;
            int size = int.Parse(txtFATFileSize.Text);
            if (txtFATFileName.Text == "")
            {
                throw new Exception();
            }
            if (fat.CreateFile(name, size))
                MessageBox.Show("FAT file created.");
            else
                MessageBox.Show("FAT: Not enough space.");
            UpdateDisplay();
        }

        private void btnCreateInodeFile_Click(object sender, EventArgs e)
        {
            string name = txtInodeFileName.Text;
            int size = int.Parse(txtInodeFileSize.Text);
            if (inodeFS.CreateFile(name, size))
                MessageBox.Show("Inode file created.");
            else
                MessageBox.Show("Inode FS: Not enough space.");
            UpdateDisplay();
        }

        private void btnDeleteFATFile_Click(object sender, EventArgs e)
        {
            if (lstFatFiles.SelectedItem != null)
            {
                fat.DeleteFile(lstFatFiles.SelectedItem.ToString());
                UpdateDisplay();
            }
        }

        private void btnDeleteInodeFile_Click(object sender, EventArgs e)
        {
            if (lstInodeFiles.SelectedItem != null)
            {
                inodeFS.DeleteFile(lstInodeFiles.SelectedItem.ToString());
                UpdateDisplay();
            }
        }

        private void btnShowMemFat_Click(object sender, EventArgs e)
        {
            lblFatMemory.Text = fat.GetMemory();
        }

        private void btnShowMemInode_Click(object sender, EventArgs e)
        {
            lblInodeMemory.Text = inodeFS.GetMemory();
        }

        private void btnReadFATFile_Click(object sender, EventArgs e)
        {
            if (lstFatFiles.SelectedItem != null)
            {
                string content = fat.ReadFile(lstFatFiles.SelectedItem.ToString());
                MessageBox.Show("FAT File Content: " + content);
            }
        }

        private void btnReadInodeFile_Click(object sender, EventArgs e)
        {
            if (lstInodeFiles.SelectedItem != null)
            {
                string content = inodeFS.ReadFile(lstInodeFiles.SelectedItem.ToString());
                MessageBox.Show("Inode File Content: " + content);
            }
        }

        private void btnWriteFATFile_Click(object sender, EventArgs e)
        {
            if (lstFatFiles.SelectedItem != null)
            {
                fat.WriteToFile(lstFatFiles.SelectedItem.ToString(), txtWriteFATContent.Text);
                MessageBox.Show("Written to FAT file.");
            }
        }

        private void btnWriteInodeFile_Click(object sender, EventArgs e)
        {
            if (lstInodeFiles.SelectedItem != null)
            {
                inodeFS.WriteToFile(lstInodeFiles.SelectedItem.ToString(), txtWriteInodeContent.Text);
                MessageBox.Show("Written to Inode file.");
            }
        }

        private void UpdateDisplay()
        {
            lblFATInfo.Text = fat.GetFileSystemInfo();
            lblInodeInfo.Text = inodeFS.GetFileSystemInfo();
            lstFatFiles.DataSource = null;
            lstFatFiles.DataSource = fat.GetFileList();
            lstInodeFiles.DataSource = null;
            lstInodeFiles.DataSource = inodeFS.GetFileList();
        }
    }
}

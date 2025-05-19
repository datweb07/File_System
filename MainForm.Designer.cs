using System.Windows.Forms;

namespace File_System
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupFAT = new System.Windows.Forms.GroupBox();
            this.lblFATInfo = new System.Windows.Forms.Label();
            this.lblFatMemory = new System.Windows.Forms.Label();
            this.btnDeleteFATFile = new System.Windows.Forms.Button();
            this.btnShowMemFat = new System.Windows.Forms.Button();
            this.btnCreateFATFile = new System.Windows.Forms.Button();
            this.txtFATFileSize = new System.Windows.Forms.TextBox();
            this.txtFATFileName = new System.Windows.Forms.TextBox();
            this.labelFATFileSize = new System.Windows.Forms.Label();
            this.labelFATFileName = new System.Windows.Forms.Label();
            this.lstFatFiles = new System.Windows.Forms.ListBox();
            this.btnReadFATFile = new System.Windows.Forms.Button();
            this.btnWriteFATFile = new System.Windows.Forms.Button();
            this.txtWriteFATContent = new System.Windows.Forms.TextBox();
            this.groupInode = new System.Windows.Forms.GroupBox();
            this.lblInodeInfo = new System.Windows.Forms.Label();
            this.btnShowMemInode = new System.Windows.Forms.Button();
            this.lblInodeMemory = new System.Windows.Forms.Label();
            this.btnDeleteInodeFile = new System.Windows.Forms.Button();
            this.btnCreateInodeFile = new System.Windows.Forms.Button();
            this.txtInodeFileSize = new System.Windows.Forms.TextBox();
            this.txtInodeFileName = new System.Windows.Forms.TextBox();
            this.labelInodeFileSize = new System.Windows.Forms.Label();
            this.labelInodeFileName = new System.Windows.Forms.Label();
            this.lstInodeFiles = new System.Windows.Forms.ListBox();
            this.btnReadInodeFile = new System.Windows.Forms.Button();
            this.btnWriteInodeFile = new System.Windows.Forms.Button();
            this.txtWriteInodeContent = new System.Windows.Forms.TextBox();
            this.groupFAT.SuspendLayout();
            this.groupInode.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFAT
            // 
            this.groupFAT.Controls.Add(this.lblFATInfo);
            this.groupFAT.Controls.Add(this.lblFatMemory);
            this.groupFAT.Controls.Add(this.btnDeleteFATFile);
            this.groupFAT.Controls.Add(this.btnShowMemFat);
            this.groupFAT.Controls.Add(this.btnCreateFATFile);
            this.groupFAT.Controls.Add(this.txtFATFileSize);
            this.groupFAT.Controls.Add(this.txtFATFileName);
            this.groupFAT.Controls.Add(this.labelFATFileSize);
            this.groupFAT.Controls.Add(this.labelFATFileName);
            this.groupFAT.Controls.Add(this.lstFatFiles);
            this.groupFAT.Controls.Add(this.btnReadFATFile);
            this.groupFAT.Controls.Add(this.btnWriteFATFile);
            this.groupFAT.Controls.Add(this.txtWriteFATContent);
            this.groupFAT.Location = new System.Drawing.Point(12, 12);
            this.groupFAT.Name = "groupFAT";
            this.groupFAT.Size = new System.Drawing.Size(350, 487);
            this.groupFAT.TabIndex = 0;
            this.groupFAT.TabStop = false;
            this.groupFAT.Text = "FAT File System";
            // 
            // lblFATInfo
            // 
            this.lblFATInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFATInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFATInfo.Location = new System.Drawing.Point(20, 100);
            this.lblFATInfo.Name = "lblFATInfo";
            this.lblFATInfo.Size = new System.Drawing.Size(310, 72);
            this.lblFATInfo.TabIndex = 2;
            // 
            // lblFatMemory
            // 
            this.lblFatMemory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblFatMemory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFatMemory.Location = new System.Drawing.Point(20, 410);
            this.lblFatMemory.Name = "lblFatMemory";
            this.lblFatMemory.Size = new System.Drawing.Size(210, 74);
            this.lblFatMemory.TabIndex = 10;
            // 
            // btnDeleteFATFile
            // 
            this.btnDeleteFATFile.Location = new System.Drawing.Point(255, 258);
            this.btnDeleteFATFile.Name = "btnDeleteFATFile";
            this.btnDeleteFATFile.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFATFile.TabIndex = 6;
            this.btnDeleteFATFile.Text = "Delete FAT";
            this.btnDeleteFATFile.UseVisualStyleBackColor = true;
            this.btnDeleteFATFile.Click += new System.EventHandler(this.btnDeleteFATFile_Click);
            // 
            // btnShowMemFat
            // 
            this.btnShowMemFat.Location = new System.Drawing.Point(245, 444);
            this.btnShowMemFat.Name = "btnShowMemFat";
            this.btnShowMemFat.Size = new System.Drawing.Size(84, 23);
            this.btnShowMemFat.TabIndex = 3;
            this.btnShowMemFat.Text = "ShowMapFat";
            this.btnShowMemFat.Click += new System.EventHandler(this.btnShowMemFat_Click);
            // 
            // btnCreateFATFile
            // 
            this.btnCreateFATFile.Location = new System.Drawing.Point(245, 66);
            this.btnCreateFATFile.Name = "btnCreateFATFile";
            this.btnCreateFATFile.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFATFile.TabIndex = 1;
            this.btnCreateFATFile.Text = "Create File";
            this.btnCreateFATFile.Click += new System.EventHandler(this.btnCreateFATFile_Click);
            // 
            // txtFATFileSize
            // 
            this.txtFATFileSize.Location = new System.Drawing.Point(120, 66);
            this.txtFATFileSize.Name = "txtFATFileSize";
            this.txtFATFileSize.Size = new System.Drawing.Size(100, 20);
            this.txtFATFileSize.TabIndex = 2;
            // 
            // txtFATFileName
            // 
            this.txtFATFileName.Location = new System.Drawing.Point(120, 30);
            this.txtFATFileName.Name = "txtFATFileName";
            this.txtFATFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFATFileName.TabIndex = 3;
            // 
            // labelFATFileSize
            // 
            this.labelFATFileSize.Location = new System.Drawing.Point(20, 66);
            this.labelFATFileSize.Name = "labelFATFileSize";
            this.labelFATFileSize.Size = new System.Drawing.Size(100, 23);
            this.labelFATFileSize.TabIndex = 4;
            this.labelFATFileSize.Text = "File Size:";
            // 
            // labelFATFileName
            // 
            this.labelFATFileName.Location = new System.Drawing.Point(20, 30);
            this.labelFATFileName.Name = "labelFATFileName";
            this.labelFATFileName.Size = new System.Drawing.Size(100, 23);
            this.labelFATFileName.TabIndex = 5;
            this.labelFATFileName.Text = "File Name:";
            // 
            // lstFatFiles
            // 
            this.lstFatFiles.Location = new System.Drawing.Point(20, 196);
            this.lstFatFiles.Name = "lstFatFiles";
            this.lstFatFiles.Size = new System.Drawing.Size(310, 56);
            this.lstFatFiles.TabIndex = 6;
            // 
            // btnReadFATFile
            // 
            this.btnReadFATFile.Location = new System.Drawing.Point(20, 258);
            this.btnReadFATFile.Name = "btnReadFATFile";
            this.btnReadFATFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadFATFile.TabIndex = 7;
            this.btnReadFATFile.Text = "Read Selected";
            this.btnReadFATFile.Click += new System.EventHandler(this.btnReadFATFile_Click);
            // 
            // btnWriteFATFile
            // 
            this.btnWriteFATFile.Location = new System.Drawing.Point(132, 374);
            this.btnWriteFATFile.Name = "btnWriteFATFile";
            this.btnWriteFATFile.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFATFile.TabIndex = 8;
            this.btnWriteFATFile.Text = "Write";
            this.btnWriteFATFile.Click += new System.EventHandler(this.btnWriteFATFile_Click);
            // 
            // txtWriteFATContent
            // 
            this.txtWriteFATContent.Location = new System.Drawing.Point(20, 308);
            this.txtWriteFATContent.Multiline = true;
            this.txtWriteFATContent.Name = "txtWriteFATContent";
            this.txtWriteFATContent.Size = new System.Drawing.Size(310, 60);
            this.txtWriteFATContent.TabIndex = 9;
            // 
            // groupInode
            // 
            this.groupInode.Controls.Add(this.lblInodeInfo);
            this.groupInode.Controls.Add(this.btnShowMemInode);
            this.groupInode.Controls.Add(this.lblInodeMemory);
            this.groupInode.Controls.Add(this.btnDeleteInodeFile);
            this.groupInode.Controls.Add(this.btnCreateInodeFile);
            this.groupInode.Controls.Add(this.txtInodeFileSize);
            this.groupInode.Controls.Add(this.txtInodeFileName);
            this.groupInode.Controls.Add(this.labelInodeFileSize);
            this.groupInode.Controls.Add(this.labelInodeFileName);
            this.groupInode.Controls.Add(this.lstInodeFiles);
            this.groupInode.Controls.Add(this.btnReadInodeFile);
            this.groupInode.Controls.Add(this.btnWriteInodeFile);
            this.groupInode.Controls.Add(this.txtWriteInodeContent);
            this.groupInode.Location = new System.Drawing.Point(370, 12);
            this.groupInode.Name = "groupInode";
            this.groupInode.Size = new System.Drawing.Size(350, 487);
            this.groupInode.TabIndex = 1;
            this.groupInode.TabStop = false;
            this.groupInode.Text = "Inode File System";
            // 
            // lblInodeInfo
            // 
            this.lblInodeInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInodeInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInodeInfo.Location = new System.Drawing.Point(20, 100);
            this.lblInodeInfo.Name = "lblInodeInfo";
            this.lblInodeInfo.Size = new System.Drawing.Size(310, 72);
            this.lblInodeInfo.TabIndex = 3;
            // 
            // btnShowMemInode
            // 
            this.btnShowMemInode.Location = new System.Drawing.Point(245, 444);
            this.btnShowMemInode.Name = "btnShowMemInode";
            this.btnShowMemInode.Size = new System.Drawing.Size(95, 23);
            this.btnShowMemInode.TabIndex = 12;
            this.btnShowMemInode.Text = "ShowMapInode";
            this.btnShowMemInode.Click += new System.EventHandler(this.btnShowMemInode_Click);
            // 
            // lblInodeMemory
            // 
            this.lblInodeMemory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInodeMemory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInodeMemory.Location = new System.Drawing.Point(23, 410);
            this.lblInodeMemory.Name = "lblInodeMemory";
            this.lblInodeMemory.Size = new System.Drawing.Size(210, 74);
            this.lblInodeMemory.TabIndex = 11;
            // 
            // btnDeleteInodeFile
            // 
            this.btnDeleteInodeFile.Location = new System.Drawing.Point(245, 258);
            this.btnDeleteInodeFile.Name = "btnDeleteInodeFile";
            this.btnDeleteInodeFile.Size = new System.Drawing.Size(85, 23);
            this.btnDeleteInodeFile.TabIndex = 10;
            this.btnDeleteInodeFile.Text = "Delete Inode";
            this.btnDeleteInodeFile.UseVisualStyleBackColor = true;
            this.btnDeleteInodeFile.Click += new System.EventHandler(this.btnDeleteInodeFile_Click);
            // 
            // btnCreateInodeFile
            // 
            this.btnCreateInodeFile.Location = new System.Drawing.Point(245, 66);
            this.btnCreateInodeFile.Name = "btnCreateInodeFile";
            this.btnCreateInodeFile.Size = new System.Drawing.Size(75, 23);
            this.btnCreateInodeFile.TabIndex = 1;
            this.btnCreateInodeFile.Text = "Create File";
            this.btnCreateInodeFile.Click += new System.EventHandler(this.btnCreateInodeFile_Click);
            // 
            // txtInodeFileSize
            // 
            this.txtInodeFileSize.Location = new System.Drawing.Point(120, 66);
            this.txtInodeFileSize.Name = "txtInodeFileSize";
            this.txtInodeFileSize.Size = new System.Drawing.Size(100, 20);
            this.txtInodeFileSize.TabIndex = 2;
            // 
            // txtInodeFileName
            // 
            this.txtInodeFileName.Location = new System.Drawing.Point(120, 30);
            this.txtInodeFileName.Name = "txtInodeFileName";
            this.txtInodeFileName.Size = new System.Drawing.Size(100, 20);
            this.txtInodeFileName.TabIndex = 3;
            // 
            // labelInodeFileSize
            // 
            this.labelInodeFileSize.Location = new System.Drawing.Point(20, 66);
            this.labelInodeFileSize.Name = "labelInodeFileSize";
            this.labelInodeFileSize.Size = new System.Drawing.Size(100, 23);
            this.labelInodeFileSize.TabIndex = 4;
            this.labelInodeFileSize.Text = "File Size:";
            // 
            // labelInodeFileName
            // 
            this.labelInodeFileName.Location = new System.Drawing.Point(20, 30);
            this.labelInodeFileName.Name = "labelInodeFileName";
            this.labelInodeFileName.Size = new System.Drawing.Size(100, 23);
            this.labelInodeFileName.TabIndex = 5;
            this.labelInodeFileName.Text = "File Name:";
            // 
            // lstInodeFiles
            // 
            this.lstInodeFiles.Location = new System.Drawing.Point(20, 196);
            this.lstInodeFiles.Name = "lstInodeFiles";
            this.lstInodeFiles.Size = new System.Drawing.Size(310, 56);
            this.lstInodeFiles.TabIndex = 6;
            // 
            // btnReadInodeFile
            // 
            this.btnReadInodeFile.Location = new System.Drawing.Point(20, 258);
            this.btnReadInodeFile.Name = "btnReadInodeFile";
            this.btnReadInodeFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadInodeFile.TabIndex = 7;
            this.btnReadInodeFile.Text = "Read Selected";
            this.btnReadInodeFile.Click += new System.EventHandler(this.btnReadInodeFile_Click);
            // 
            // btnWriteInodeFile
            // 
            this.btnWriteInodeFile.Location = new System.Drawing.Point(145, 374);
            this.btnWriteInodeFile.Name = "btnWriteInodeFile";
            this.btnWriteInodeFile.Size = new System.Drawing.Size(75, 23);
            this.btnWriteInodeFile.TabIndex = 8;
            this.btnWriteInodeFile.Text = "Write";
            this.btnWriteInodeFile.Click += new System.EventHandler(this.btnWriteInodeFile_Click);
            // 
            // txtWriteInodeContent
            // 
            this.txtWriteInodeContent.Location = new System.Drawing.Point(20, 308);
            this.txtWriteInodeContent.Multiline = true;
            this.txtWriteInodeContent.Name = "txtWriteInodeContent";
            this.txtWriteInodeContent.Size = new System.Drawing.Size(310, 60);
            this.txtWriteInodeContent.TabIndex = 9;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1316, 693);
            this.Controls.Add(this.groupFAT);
            this.Controls.Add(this.groupInode);
            this.Name = "MainForm";
            this.Text = "File System Simulator";
            this.groupFAT.ResumeLayout(false);
            this.groupFAT.PerformLayout();
            this.groupInode.ResumeLayout(false);
            this.groupInode.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupFAT;
        private System.Windows.Forms.Button btnCreateFATFile;
        private System.Windows.Forms.TextBox txtFATFileSize;
        private System.Windows.Forms.TextBox txtFATFileName;
        private System.Windows.Forms.Label labelFATFileSize;
        private System.Windows.Forms.Label labelFATFileName;
        private System.Windows.Forms.Button btnReadFATFile;
        private System.Windows.Forms.Button btnWriteFATFile;
        private System.Windows.Forms.TextBox txtWriteFATContent;

        private System.Windows.Forms.GroupBox groupInode;
        private System.Windows.Forms.Button btnCreateInodeFile;
        private System.Windows.Forms.TextBox txtInodeFileSize;
        private System.Windows.Forms.TextBox txtInodeFileName;
        private System.Windows.Forms.Label labelInodeFileSize;
        private System.Windows.Forms.Label labelInodeFileName;
        private System.Windows.Forms.ListBox lstInodeFiles;
        private System.Windows.Forms.Button btnReadInodeFile;
        private System.Windows.Forms.Button btnWriteInodeFile;
        private System.Windows.Forms.TextBox txtWriteInodeContent;
        private System.Windows.Forms.Button btnShowMemFat;
        private Button btnDeleteFATFile;
        private Button btnDeleteInodeFile;
        private Label lblFatMemory;
        private Label lblInodeMemory;
        private Button btnShowMemInode;
        private Label lblFATInfo;
        private ListBox lstFatFiles;
        private Label lblInodeInfo;
    }

}





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
            this.txtFATInfo = new System.Windows.Forms.TextBox();
            this.btnCreateFATFile = new System.Windows.Forms.Button();
            this.txtFATFileSize = new System.Windows.Forms.TextBox();
            this.txtFATFileName = new System.Windows.Forms.TextBox();
            this.labelFATFileSize = new System.Windows.Forms.Label();
            this.labelFATFileName = new System.Windows.Forms.Label();
            this.groupInode = new System.Windows.Forms.GroupBox();
            this.txtInodeInfo = new System.Windows.Forms.TextBox();
            this.btnCreateInodeFile = new System.Windows.Forms.Button();
            this.txtInodeFileSize = new System.Windows.Forms.TextBox();
            this.txtInodeFileName = new System.Windows.Forms.TextBox();
            this.labelInodeFileSize = new System.Windows.Forms.Label();
            this.labelInodeFileName = new System.Windows.Forms.Label();
            this.groupFAT.SuspendLayout();
            this.groupInode.SuspendLayout();
            this.SuspendLayout();

            // groupFAT
            this.groupFAT.Controls.Add(this.txtFATInfo);
            this.groupFAT.Controls.Add(this.btnCreateFATFile);
            this.groupFAT.Controls.Add(this.txtFATFileSize);
            this.groupFAT.Controls.Add(this.txtFATFileName);
            this.groupFAT.Controls.Add(this.labelFATFileSize);
            this.groupFAT.Controls.Add(this.labelFATFileName);
            this.groupFAT.Location = new System.Drawing.Point(12, 12);
            this.groupFAT.Name = "groupFAT";
            this.groupFAT.Size = new System.Drawing.Size(350, 300);
            this.groupFAT.TabIndex = 0;
            this.groupFAT.TabStop = false;
            this.groupFAT.Text = "FAT File System";

            // txtFATInfo
            this.txtFATInfo.Location = new System.Drawing.Point(20, 100);
            this.txtFATInfo.Multiline = true;
            this.txtFATInfo.Name = "txtFATInfo";
            this.txtFATInfo.ReadOnly = true;
            this.txtFATInfo.Size = new System.Drawing.Size(310, 180);
            this.txtFATInfo.TabIndex = 5;

            // btnCreateFATFile
            this.btnCreateFATFile.Location = new System.Drawing.Point(245, 66);
            this.btnCreateFATFile.Name = "btnCreateFATFile";
            this.btnCreateFATFile.Size = new System.Drawing.Size(85, 23);
            this.btnCreateFATFile.TabIndex = 4;
            this.btnCreateFATFile.Text = "Create File";
            this.btnCreateFATFile.UseVisualStyleBackColor = true;
            this.btnCreateFATFile.Click += new System.EventHandler(this.btnCreateFATFile_Click);

            // txtFATFileSize
            this.txtFATFileSize.Location = new System.Drawing.Point(120, 66);
            this.txtFATFileSize.Name = "txtFATFileSize";
            this.txtFATFileSize.Size = new System.Drawing.Size(100, 20);
            this.txtFATFileSize.TabIndex = 3;

            // txtFATFileName
            this.txtFATFileName.Location = new System.Drawing.Point(120, 30);
            this.txtFATFileName.Name = "txtFATFileName";
            this.txtFATFileName.Size = new System.Drawing.Size(210, 20);
            this.txtFATFileName.TabIndex = 2;

            // labelFATFileSize
            this.labelFATFileSize.AutoSize = true;
            this.labelFATFileSize.Location = new System.Drawing.Point(20, 66);
            this.labelFATFileSize.Name = "labelFATFileSize";
            this.labelFATFileSize.Size = new System.Drawing.Size(53, 13);
            this.labelFATFileSize.TabIndex = 1;
            this.labelFATFileSize.Text = "File Size:";

            // labelFATFileName
            this.labelFATFileName.AutoSize = true;
            this.labelFATFileName.Location = new System.Drawing.Point(20, 30);
            this.labelFATFileName.Name = "labelFATFileName";
            this.labelFATFileName.Size = new System.Drawing.Size(58, 13);
            this.labelFATFileName.TabIndex = 0;
            this.labelFATFileName.Text = "File Name:";

            // groupInode
            this.groupInode.Controls.Add(this.txtInodeInfo);
            this.groupInode.Controls.Add(this.btnCreateInodeFile);
            this.groupInode.Controls.Add(this.txtInodeFileSize);
            this.groupInode.Controls.Add(this.txtInodeFileName);
            this.groupInode.Controls.Add(this.labelInodeFileSize);
            this.groupInode.Controls.Add(this.labelInodeFileName);
            this.groupInode.Location = new System.Drawing.Point(368, 12);
            this.groupInode.Name = "groupInode";
            this.groupInode.Size = new System.Drawing.Size(350, 300);
            this.groupInode.TabIndex = 1;
            this.groupInode.TabStop = false;
            this.groupInode.Text = "Inode-based File System";

            // txtInodeInfo
            this.txtInodeInfo.Location = new System.Drawing.Point(20, 100);
            this.txtInodeInfo.Multiline = true;
            this.txtInodeInfo.Name = "txtInodeInfo";
            this.txtInodeInfo.ReadOnly = true;
            this.txtInodeInfo.Size = new System.Drawing.Size(310, 180);
            this.txtInodeInfo.TabIndex = 5;

            // btnCreateInodeFile
            this.btnCreateInodeFile.Location = new System.Drawing.Point(245, 66);
            this.btnCreateInodeFile.Name = "btnCreateInodeFile";
            this.btnCreateInodeFile.Size = new System.Drawing.Size(85, 23);
            this.btnCreateInodeFile.TabIndex = 4;
            this.btnCreateInodeFile.Text = "Create File";
            this.btnCreateInodeFile.UseVisualStyleBackColor = true;
            this.btnCreateInodeFile.Click += new System.EventHandler(this.btnCreateInodeFile_Click);

            // txtInodeFileSize
            this.txtInodeFileSize.Location = new System.Drawing.Point(120, 66);
            this.txtInodeFileSize.Name = "txtInodeFileSize";
            this.txtInodeFileSize.Size = new System.Drawing.Size(100, 20);
            this.txtInodeFileSize.TabIndex = 3;

            // txtInodeFileName
            this.txtInodeFileName.Location = new System.Drawing.Point(120, 30);
            this.txtInodeFileName.Name = "txtInodeFileName";
            this.txtInodeFileName.Size = new System.Drawing.Size(210, 20);
            this.txtInodeFileName.TabIndex = 2;

            // labelInodeFileSize
            this.labelInodeFileSize.AutoSize = true;
            this.labelInodeFileSize.Location = new System.Drawing.Point(20, 66);
            this.labelInodeFileSize.Name = "labelInodeFileSize";
            this.labelInodeFileSize.Size = new System.Drawing.Size(53, 13);
            this.labelInodeFileSize.TabIndex = 1;
            this.labelInodeFileSize.Text = "File Size:";

            // labelInodeFileName
            this.labelInodeFileName.AutoSize = true;
            this.labelInodeFileName.Location = new System.Drawing.Point(20, 30);
            this.labelInodeFileName.Name = "labelInodeFileName";
            this.labelInodeFileName.Size = new System.Drawing.Size(58, 13);
            this.labelInodeFileName.TabIndex = 0;
            this.labelInodeFileName.Text = "File Name:";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 324);
            this.Controls.Add(this.groupInode);
            this.Controls.Add(this.groupFAT);
            this.Name = "MainForm";
            this.Text = "File System Simulator";
            this.groupFAT.ResumeLayout(false);
            this.groupFAT.PerformLayout();
            this.groupInode.ResumeLayout(false);
            this.groupInode.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupFAT;
        private System.Windows.Forms.TextBox txtFATInfo;
        private System.Windows.Forms.Button btnCreateFATFile;
        private System.Windows.Forms.TextBox txtFATFileSize;
        private System.Windows.Forms.TextBox txtFATFileName;
        private System.Windows.Forms.Label labelFATFileSize;
        private System.Windows.Forms.Label labelFATFileName;
        private System.Windows.Forms.GroupBox groupInode;
        private System.Windows.Forms.TextBox txtInodeInfo;
        private System.Windows.Forms.Button btnCreateInodeFile;
        private System.Windows.Forms.TextBox txtInodeFileSize;
        private System.Windows.Forms.TextBox txtInodeFileName;
        private System.Windows.Forms.Label labelInodeFileSize;
        private System.Windows.Forms.Label labelInodeFileName;
    }
}


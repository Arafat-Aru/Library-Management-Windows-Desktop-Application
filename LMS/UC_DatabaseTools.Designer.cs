namespace LMS
{
    partial class UC_DatabaseTools
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.btnExecuteBackup = new System.Windows.Forms.Button();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.lblRestorePath = new System.Windows.Forms.Label();
            this.txtRestorePath = new System.Windows.Forms.TextBox();
            this.btnBrowseRestore = new System.Windows.Forms.Button();
            this.btnExecuteRestore = new System.Windows.Forms.Button();
            this.grpIndex = new System.Windows.Forms.GroupBox();
            this.lblIndexDesc = new System.Windows.Forms.Label();
            this.btnRebuildIndexes = new System.Windows.Forms.Button();
            this.lblLogHeader = new System.Windows.Forms.Label();
            this.txtStatusLog = new System.Windows.Forms.TextBox();
            this.grpBackup.SuspendLayout();
            this.grpRestore.SuspendLayout();
            this.grpIndex.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Database Maintenance && Tools";
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnExecuteBackup);
            this.grpBackup.Controls.Add(this.lblBackupPath);
            this.grpBackup.Controls.Add(this.btnBrowseBackup);
            this.grpBackup.Controls.Add(this.txtBackupPath);
            this.grpBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBackup.Location = new System.Drawing.Point(25, 50);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(862, 115);
            this.grpBackup.TabIndex = 4;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Database Backup (.bak)";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(160, 28);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(550, 27);
            this.txtBackupPath.TabIndex = 0;
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Location = new System.Drawing.Point(720, 26);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(120, 28);
            this.btnBrowseBackup.TabIndex = 1;
            this.btnBrowseBackup.Text = "Browse...";
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.Location = new System.Drawing.Point(11, 31);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(143, 20);
            this.lblBackupPath.TabIndex = 3;
            this.lblBackupPath.Text = "Target Folder / File:";
            // 
            // btnExecuteBackup
            // 
            this.btnExecuteBackup.Location = new System.Drawing.Point(160, 68);
            this.btnExecuteBackup.Name = "btnExecuteBackup";
            this.btnExecuteBackup.Size = new System.Drawing.Size(190, 34);
            this.btnExecuteBackup.TabIndex = 4;
            this.btnExecuteBackup.Text = "Create Backup Now";
            this.btnExecuteBackup.UseVisualStyleBackColor = true;
            this.btnExecuteBackup.Click += new System.EventHandler(this.btnExecuteBackup_Click);
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.btnExecuteRestore);
            this.grpRestore.Controls.Add(this.btnBrowseRestore);
            this.grpRestore.Controls.Add(this.txtRestorePath);
            this.grpRestore.Controls.Add(this.lblRestorePath);
            this.grpRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRestore.Location = new System.Drawing.Point(25, 175);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(862, 115);
            this.grpRestore.TabIndex = 7;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "Database Restore";
            // 
            // lblRestorePath
            // 
            this.lblRestorePath.Location = new System.Drawing.Point(6, 31);
            this.lblRestorePath.Name = "lblRestorePath";
            this.lblRestorePath.Size = new System.Drawing.Size(154, 20);
            this.lblRestorePath.TabIndex = 0;
            this.lblRestorePath.Text = "Select Backup (.bak):";
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Location = new System.Drawing.Point(160, 28);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.Size = new System.Drawing.Size(550, 27);
            this.txtRestorePath.TabIndex = 2;
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.Location = new System.Drawing.Point(720, 26);
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.Size = new System.Drawing.Size(120, 28);
            this.btnBrowseRestore.TabIndex = 3;
            this.btnBrowseRestore.Text = "Browse...";
            this.btnBrowseRestore.UseVisualStyleBackColor = true;
            this.btnBrowseRestore.Click += new System.EventHandler(this.btnBrowseRestore_Click);
            // 
            // btnExecuteRestore
            // 
            this.btnExecuteRestore.Location = new System.Drawing.Point(160, 68);
            this.btnExecuteRestore.Name = "btnExecuteRestore";
            this.btnExecuteRestore.Size = new System.Drawing.Size(190, 34);
            this.btnExecuteRestore.TabIndex = 4;
            this.btnExecuteRestore.Text = "Restore Database";
            this.btnExecuteRestore.UseVisualStyleBackColor = true;
            this.btnExecuteRestore.Click += new System.EventHandler(this.btnExecuteRestore_Click);
            // 
            // grpIndex
            // 
            this.grpIndex.Controls.Add(this.txtStatusLog);
            this.grpIndex.Controls.Add(this.lblLogHeader);
            this.grpIndex.Controls.Add(this.btnRebuildIndexes);
            this.grpIndex.Controls.Add(this.lblIndexDesc);
            this.grpIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIndex.Location = new System.Drawing.Point(25, 300);
            this.grpIndex.Name = "grpIndex";
            this.grpIndex.Size = new System.Drawing.Size(862, 255);
            this.grpIndex.TabIndex = 8;
            this.grpIndex.TabStop = false;
            this.grpIndex.Text = "Index Maintenance && Activity Log";
            // 
            // lblIndexDesc
            // 
            this.lblIndexDesc.Location = new System.Drawing.Point(20, 28);
            this.lblIndexDesc.Name = "lblIndexDesc";
            this.lblIndexDesc.Size = new System.Drawing.Size(442, 20);
            this.lblIndexDesc.TabIndex = 0;
            this.lblIndexDesc.Text = "Optimize database tables and resolve query fragmentation:";
            // 
            // btnRebuildIndexes
            // 
            this.btnRebuildIndexes.Location = new System.Drawing.Point(20, 81);
            this.btnRebuildIndexes.Name = "btnRebuildIndexes";
            this.btnRebuildIndexes.Size = new System.Drawing.Size(185, 36);
            this.btnRebuildIndexes.TabIndex = 1;
            this.btnRebuildIndexes.Text = "Rebuild All Indexes";
            this.btnRebuildIndexes.UseVisualStyleBackColor = true;
            this.btnRebuildIndexes.Click += new System.EventHandler(this.btnRebuildIndexes_Click);
            // 
            // lblLogHeader
            // 
            this.lblLogHeader.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogHeader.Location = new System.Drawing.Point(208, 58);
            this.lblLogHeader.Name = "lblLogHeader";
            this.lblLogHeader.Size = new System.Drawing.Size(200, 20);
            this.lblLogHeader.TabIndex = 2;
            this.lblLogHeader.Text = "Operation Output / Status Log:";
            // 
            // txtStatusLog
            // 
            this.txtStatusLog.Location = new System.Drawing.Point(211, 81);
            this.txtStatusLog.Multiline = true;
            this.txtStatusLog.Name = "txtStatusLog";
            this.txtStatusLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusLog.Size = new System.Drawing.Size(500, 95);
            this.txtStatusLog.TabIndex = 3;
            // 
            // UC_DatabaseTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpIndex);
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpBackup);
            this.Name = "UC_DatabaseTools";
            this.Size = new System.Drawing.Size(912, 573);
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.grpIndex.ResumeLayout(false);
            this.grpIndex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnBrowseBackup;
        private System.Windows.Forms.Button btnExecuteBackup;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.TextBox txtRestorePath;
        private System.Windows.Forms.Label lblRestorePath;
        private System.Windows.Forms.Button btnExecuteRestore;
        private System.Windows.Forms.Button btnBrowseRestore;
        private System.Windows.Forms.GroupBox grpIndex;
        private System.Windows.Forms.Button btnRebuildIndexes;
        private System.Windows.Forms.Label lblIndexDesc;
        private System.Windows.Forms.TextBox txtStatusLog;
        private System.Windows.Forms.Label lblLogHeader;
    }
}

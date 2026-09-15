using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class UC_DatabaseTools : UserControl
    {
        private const string TargetDatabaseName = "LibraryManagementDB";
        //Master Database Connection string
        private readonly string masterConnectionString = @"Data Source=LAPTOP-7VKDU2HH\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;";
        public UC_DatabaseTools()
        {
            InitializeComponent();
        }
        private void AppendLog(string message)
        {
            txtStatusLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
            txtStatusLog.SelectionStart = txtStatusLog.Text.Length;
            txtStatusLog.ScrollToCaret();
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Default to a folder where SQL Server typically has access, or C:\Backups
                string defaultDir = @"C:\Backups";
                if (!Directory.Exists(defaultDir))
                {
                    Directory.CreateDirectory(defaultDir);
                }

                folderDialog.SelectedPath = defaultDir;
                folderDialog.Description = "Select target folder to store database backup (.bak)";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFileName = $"{TargetDatabaseName}_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                    txtBackupPath.Text = Path.Combine(folderDialog.SelectedPath, backupFileName);
                }
            }
        }

        private void btnExecuteBackup_Click(object sender, EventArgs e)
        {
            string backupFilePath = txtBackupPath.Text.Trim();

            if (string.IsNullOrEmpty(backupFilePath))
            {
                MessageBox.Show("Please choose a destination backup path first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $@"BACKUP DATABASE [{TargetDatabaseName}] 
                             TO DISK = @path 
                             WITH FORMAT, MEDIANAME = 'LMSBackup', NAME = 'Full LibraryManagementDB Backup';";

            try
            {
                AppendLog("Initiating full database backup...");
                btnExecuteBackup.Enabled = false;

                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.AddWithValue("@path", backupFilePath);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                AppendLog($"Backup created successfully at: {backupFilePath}");
                MessageBox.Show("Database backup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                AppendLog($"Backup failed: {ex.Message}");
                MessageBox.Show("Backup failed: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnExecuteBackup.Enabled = true;
            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL Server Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
                openFileDialog.Title = "Select Backup File to Restore";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRestorePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnExecuteRestore_Click(object sender, EventArgs e)
        {
            string restoreFilePath = txtRestorePath.Text.Trim();

            if (string.IsNullOrEmpty(restoreFilePath) || !File.Exists(restoreFilePath))
            {
                MessageBox.Show("Please select a valid .bak backup file.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Restoring will overwrite current database records and reset active user sessions. Do you want to proceed?",
                "Confirm Database Restore",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            // Closes active connections, applies restore, then resets database to multi-user mode
            string query = $@"
                ALTER DATABASE [{TargetDatabaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [{TargetDatabaseName}] FROM DISK = @path WITH REPLACE;
                ALTER DATABASE [{TargetDatabaseName}] SET MULTI_USER;";

            try
            {
                AppendLog("Resetting database connections and starting restore...");
                btnExecuteRestore.Enabled = false;

                using (SqlConnection conn = new SqlConnection(masterConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandTimeout = 180;
                        cmd.Parameters.AddWithValue("@path", restoreFilePath);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                AppendLog("Database restored successfully. System returned to MULTI_USER mode.");
                MessageBox.Show("Database restoration completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                AppendLog($"Restore failed: {ex.Message}");
                MessageBox.Show("Restore failed: " + ex.Message, "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnExecuteRestore.Enabled = true;
            }
        }

        private void btnRebuildIndexes_Click(object sender, EventArgs e)
        {
            string query = "EXEC sp_MSforeachtable @command1='ALTER INDEX ALL ON ? REBUILD';";

            try
            {
                AppendLog("Rebuilding all table indexes across LibraryManagementDB...");
                btnRebuildIndexes.Enabled = false;

                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandTimeout = 120;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                AppendLog("All indexes rebuilt successfully. Query fragmentation optimized.");
                MessageBox.Show("Index maintenance completed successfully!", "Optimization Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                AppendLog($"Index maintenance failed: {ex.Message}");
                MessageBox.Show("Failed to rebuild indexes: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRebuildIndexes.Enabled = true;
            }
        }
    }
}
    


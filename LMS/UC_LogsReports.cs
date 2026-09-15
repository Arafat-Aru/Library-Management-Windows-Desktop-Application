using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class UC_LogsReports : UserControl
    {
        public UC_LogsReports()
        {
            InitializeComponent();
            InitializeFilterOptions();
            LoadAuditLogs();
        }
        private void InitializeFilterOptions()
        {
            // Set default date range to last 30 days
            dtpFromDate.Value = DateTime.Now.AddDays(-30);
            dtpToDate.Value = DateTime.Now;

            // Audit Log Actions
            cmbActionFilter.Items.Clear();
            cmbActionFilter.Items.AddRange(new object[] { "All", "LOGIN", "USER_CREATE", "USER_UPDATE", "SETTINGS_UPDATE", "INDEX_MAINTENANCE", "BACKUP", "RESTORE" });
            cmbActionFilter.SelectedIndex = 0;

            // Report Types
            cmbReportType.Items.Clear();
            cmbReportType.Items.AddRange(new object[] {
                "Most Borrowed Books",
                "Active Members & Borrow History",
                "Overdue Loans & Pending Fines",
                "System User Inventory & Roles"
            });
            cmbReportType.SelectedIndex = 0;
        }
        

        private void btnFilterLogs_Click(object sender, EventArgs e)
        {
            LoadAuditLogs();
        }
        private void LoadAuditLogs()
        {
            string query = @"
        SELECT 
            a.LogId,
            ISNULL(u.FullName, 'System / Anonymous') AS [User Name],
            ISNULL(u.Email, 'N/A') AS [User Email],
            a.Action,
            a.Details,
            a.Timestamp
        FROM AuditLogs a
        LEFT JOIN Users u ON a.UserId = u.UserId
        WHERE a.Timestamp >= @fromDate AND a.Timestamp <= @toDate ";

            if (cmbActionFilter.SelectedIndex > 0)
            {
                query += " AND a.Action = @action ";
            }

            query += " ORDER BY a.Timestamp DESC";

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fromDate", dtpFromDate.Value.Date);
                        cmd.Parameters.AddWithValue("@toDate", dtpToDate.Value.Date.AddDays(1).AddTicks(-1));

                        if (cmbActionFilter.SelectedIndex > 0)
                        {
                            cmd.Parameters.AddWithValue("@action", cmbActionFilter.SelectedItem.ToString());
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvAuditLogs.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve audit records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetLogs_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now.AddDays(-30);
            dtpToDate.Value = DateTime.Now;
            cmbActionFilter.SelectedIndex = 0;
            LoadAuditLogs();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string selectedReport = cmbReportType.SelectedItem?.ToString();
            string query = string.Empty;

            switch (selectedReport)
            {
                case "Most Borrowed Books":
                    query = @"
                        SELECT TOP 20 b.BookName AS [Title], b.Author, b.Category, COUNT(i.IssueID) AS TimesIssued
                        FROM IssueBooks i
                        INNER JOIN Books b ON i.BookID = b.BookID
                        GROUP BY b.BookName, b.Author, b.Category
                        ORDER BY TimesIssued DESC;";
                    break;

                case "Active Members & Borrow History":
                    query = @"
                        SELECT m.MemberID, m.FullName, m.Email, m.Phone, COUNT(i.IssueID) AS TotalLoansTaken
                        FROM Members m
                        LEFT JOIN IssueBooks i ON m.MemberID = i.MemberID
                        GROUP BY m.MemberID, m.FullName, m.Email, m.Phone
                        ORDER BY TotalLoansTaken DESC;";
                    break;
                case "Overdue Loans & Pending Fines":
                    query = @"
                    SELECT 
                        i.IssueID, 
                        m.FullName AS [Member Name], 
                        b.BookName AS [Book Title], 
                        i.DueDate, 
                        i.ReturnDate,
                        CASE 
                            WHEN i.ReturnDate IS NULL AND i.DueDate < GETDATE() THEN DATEDIFF(day, i.DueDate, GETDATE())
                            WHEN i.ReturnDate > i.DueDate THEN DATEDIFF(day, i.DueDate, i.ReturnDate)
                            ELSE 0 
                        END AS [Overdue Days],
                        ISNULL(fp.FineAmount, 0) AS [Fine Paid],
                        CASE 
                            WHEN fp.PaymentDate IS NOT NULL THEN 'Paid on ' + CONVERT(varchar, fp.PaymentDate, 23)
                            WHEN i.ReturnDate IS NULL AND i.DueDate < GETDATE() THEN 'Pending (Unreturned)'
                            WHEN i.ReturnDate > i.DueDate AND fp.PaymentDate IS NULL THEN 'Pending Payment'
                            ELSE 'Cleared'
                        END AS [Fine Status]
                    FROM IssueBooks i
                    INNER JOIN Members m ON i.MemberID = m.MemberID
                    INNER JOIN Books b ON i.BookID = b.BookID
                    LEFT JOIN FinePayments fp ON i.IssueID = fp.IssueID
                    WHERE (i.ReturnDate IS NULL AND i.DueDate < GETDATE()) 
                       OR (i.ReturnDate > i.DueDate)
                       OR (fp.FineAmount > 0);";
                    break;

                case "System User Inventory & Roles":
                    query = @"
                    SELECT UserID, FullName, Email, Role, IsActive
                    FROM Users
                    ORDER BY Role, FullName;";
                    break;
            }

            if (string.IsNullOrEmpty(query)) return;

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvReports.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

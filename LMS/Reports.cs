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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            dtpFromDate.Value = DateTime.Today.AddDays(-30);
            dtpToDate.Value = DateTime.Today;

            LoadReport();
        }
        private void LoadReport()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "SELECT IssueID, BookID, MemberID, IssueDate, DueDate, ReturnDate " +
                                   "FROM IssueBooks " +
                                   "WHERE IssueDate BETWEEN @FromDate AND @ToDate " +
                                   "ORDER BY IssueDate DESC";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@FromDate", dtpFromDate.Value.Date);
                    cmd.Parameters.AddWithValue("@ToDate", dtpToDate.Value.Date);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvReport.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No circulation records found for this date range.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Value.Date > dtpToDate.Value.Date)
            {
                MessageBox.Show("From Date cannot be greater than To Date.");
                return;
            }

            LoadReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

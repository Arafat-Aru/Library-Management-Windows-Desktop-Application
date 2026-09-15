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
    public partial class FineManagement : Form
    {
        public FineManagement()
        {
            InitializeComponent();
            dtpPaymentDate.Value = DateTime.Today;

            if (cmbPaymentStatus.Items.Count > 0)
            {
                cmbPaymentStatus.SelectedIndex = 0;
            }

            LoadFinePayments();
        }
        private void LoadFinePayments()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = @"SELECT FineID, IssueID, MemberID,
                                            FineAmount, PaymentDate,
                                            PaymentStatus
                                     FROM FinePayments";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvFinePayments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading fine payments: " + ex.Message);
            }
        }

        private void btnCollectFine_Click(object sender, EventArgs e)
        {
            if (txtIssueID.Text == "")
            {
                MessageBox.Show("Please enter Issue ID.");
                txtIssueID.Focus();
                return;
            }

            if (txtMemberID.Text == "")
            {
                MessageBox.Show("Please enter Member ID.");
                txtMemberID.Focus();
                return;
            }

            if (txtFineAmount.Text == "")
            {
                MessageBox.Show("Please enter Fine Amount.");
                txtFineAmount.Focus();
                return;
            }

            int issueID;
            int memberID;
            decimal fineAmount;

            if (!int.TryParse(txtIssueID.Text, out issueID))
            {
                MessageBox.Show("Issue ID must be a number.");
                txtIssueID.Focus();
                return;
            }

            if (!int.TryParse(txtMemberID.Text, out memberID))
            {
                MessageBox.Show("Member ID must be a number.");
                txtMemberID.Focus();
                return;
            }

            if (!decimal.TryParse(txtFineAmount.Text, out fineAmount))
            {
                MessageBox.Show("Fine Amount must be a number.");
                txtFineAmount.Focus();
                return;
            }

            if (fineAmount <= 0)
            {
                MessageBox.Show("Fine Amount must be greater than 0.");
                txtFineAmount.Focus();
                return;
            }

            if (cmbPaymentStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select Payment Status.");
                cmbPaymentStatus.Focus();
                return;
            }

            string paymentStatus = cmbPaymentStatus.SelectedItem.ToString();

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string issueQuery = @"SELECT MemberID
                                  FROM IssueBooks
                                  WHERE IssueID=@IssueID";

                    SqlCommand issueCmd = new SqlCommand(issueQuery, con);

                    issueCmd.Parameters.AddWithValue("@IssueID", issueID);

                    object result = issueCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Issue ID not found.");
                        return;
                    }

                    int issueMemberID = Convert.ToInt32(result);

                    if (issueMemberID != memberID)
                    {
                        MessageBox.Show("Member ID does not match the Issue ID.");
                        return;
                    }

                    string query = @"INSERT INTO FinePayments
                            (IssueID, MemberID, FineAmount,
                             PaymentDate, PaymentStatus)
                            VALUES
                            (@IssueID, @MemberID, @FineAmount,
                             @PaymentDate, @PaymentStatus)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@IssueID", issueID);
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                    cmd.Parameters.AddWithValue("@FineAmount", fineAmount);
                    cmd.Parameters.AddWithValue("@PaymentDate",
                        dtpPaymentDate.Value.Date);
                    cmd.Parameters.AddWithValue("@PaymentStatus",
                        paymentStatus);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fine Payment Saved Successfully!");

                    LoadFinePayments();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving fine payment: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtIssueID.Clear();
            txtMemberID.Clear();
            txtFineAmount.Clear();

            dtpPaymentDate.Value = DateTime.Today;

            if (cmbPaymentStatus.Items.Count > 0)
            {
                cmbPaymentStatus.SelectedIndex = 0;
            }

            txtIssueID.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFinePayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFinePayments.Rows[e.RowIndex];

                txtIssueID.Text =
                    row.Cells["IssueID"].Value.ToString();

                txtMemberID.Text =
                    row.Cells["MemberID"].Value.ToString();

                txtFineAmount.Text =
                    row.Cells["FineAmount"].Value.ToString();

                dtpPaymentDate.Value =
                    Convert.ToDateTime(row.Cells["PaymentDate"].Value);

                cmbPaymentStatus.Text =
                    row.Cells["PaymentStatus"].Value.ToString();
            }
        }
    }
}

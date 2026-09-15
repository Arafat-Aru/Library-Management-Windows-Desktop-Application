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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
            LoadIssuedBooks();
        }
        private void LoadIssuedBooks()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "SELECT IssueID, BookID, MemberID, IssueDate, DueDate, ReturnDate FROM IssueBooks";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvIssuedBooks.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading issued books: " + ex.Message);
            }
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            if (txtIssueID.Text == "")
            {
                MessageBox.Show("Please enter Issue ID.");
                txtIssueID.Focus();
                return;
            }

            int issueID;

            if (!int.TryParse(txtIssueID.Text, out issueID))
            {
                MessageBox.Show("Issue ID must be a number.");
                txtIssueID.Focus();
                return;
            }

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    // Check whether the issue record exists
                    string checkQuery = @"SELECT BookID, ReturnDate
                                  FROM IssueBooks
                                  WHERE IssueID=@IssueID";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@IssueID", issueID);

                    SqlDataReader reader = checkCmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Issue ID not found.");
                        return;
                    }

                    int bookID = Convert.ToInt32(reader["BookID"]);

                    if (reader["ReturnDate"] != DBNull.Value)
                    {
                        reader.Close();
                        MessageBox.Show("This book has already been returned.");
                        return;
                    }

                    reader.Close();

                    // Update Return Date
                    string returnQuery = @"UPDATE IssueBooks
                                   SET ReturnDate=@ReturnDate
                                   WHERE IssueID=@IssueID";

                    SqlCommand returnCmd = new SqlCommand(returnQuery, con);

                    returnCmd.Parameters.AddWithValue("@ReturnDate",
                        dtpReturnDate.Value.Date);

                    returnCmd.Parameters.AddWithValue("@IssueID", issueID);

                    returnCmd.ExecuteNonQuery();

                    // Increase book quantity
                    string updateBookQuery = @"UPDATE Books
                                       SET Quantity = Quantity + 1
                                       WHERE BookID=@BookID";

                    SqlCommand updateBookCmd =
                        new SqlCommand(updateBookQuery, con);

                    updateBookCmd.Parameters.AddWithValue("@BookID", bookID);

                    updateBookCmd.ExecuteNonQuery();

                    MessageBox.Show("Book Returned Successfully!");

                    LoadIssuedBooks();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtIssueID.Clear();
            txtBookID.Clear();
            txtMemberID.Clear();

            dtpReturnDate.Value = DateTime.Today;

            txtIssueID.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvIssuedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvIssuedBooks.Rows[e.RowIndex];

                txtIssueID.Text = row.Cells["IssueID"].Value.ToString();
                txtBookID.Text = row.Cells["BookID"].Value.ToString();
                txtMemberID.Text = row.Cells["MemberID"].Value.ToString();

                if (row.Cells["ReturnDate"].Value != DBNull.Value &&
                    row.Cells["ReturnDate"].Value != null)
                {
                    dtpReturnDate.Value =
                        Convert.ToDateTime(row.Cells["ReturnDate"].Value);
                }
                else
                {
                    dtpReturnDate.Value = DateTime.Today;
                }
            }
        }
    }
}


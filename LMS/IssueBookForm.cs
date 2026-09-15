using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS
{
    public partial class IssueBook : Form
    {
        public IssueBook()
        {
            InitializeComponent();
            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(7);
            dtpReturnDate.Checked = false;

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

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Please enter Book ID.");
                txtBookID.Focus();
                return;
            }

            if (txtMemberID.Text == "")
            {
                MessageBox.Show("Please enter Member ID.");
                txtMemberID.Focus();
                return;
            }

            int bookID;
            int memberID;

            if (!int.TryParse(txtBookID.Text, out bookID))
            {
                MessageBox.Show("Book ID must be a number.");
                txtBookID.Focus();
                return;
            }

            if (!int.TryParse(txtMemberID.Text, out memberID))
            {
                MessageBox.Show("Member ID must be a number.");
                txtMemberID.Focus();
                return;
            }

            if (dtpDueDate.Value.Date < dtpIssueDate.Value.Date)
            {
                MessageBox.Show("Due Date cannot be before Issue Date.");
                return;
            }

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    // Check whether the book exists
                    string bookQuery = "SELECT Quantity FROM Books WHERE BookID=@BookID";

                    SqlCommand bookCmd = new SqlCommand(bookQuery, con);
                    bookCmd.Parameters.AddWithValue("@BookID", bookID);

                    object result = bookCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Book ID not found.");
                        return;
                    }

                    int quantity = Convert.ToInt32(result);

                    if (quantity <= 0)
                    {
                        MessageBox.Show("This book is not available.");
                        return;
                    }

                    // Check whether member exists
                    string memberQuery = "SELECT COUNT(*) FROM Members WHERE MemberID=@MemberID";

                    SqlCommand memberCmd = new SqlCommand(memberQuery, con);
                    memberCmd.Parameters.AddWithValue("@MemberID", memberID);

                    int memberExists = Convert.ToInt32(memberCmd.ExecuteScalar());

                    if (memberExists == 0)
                    {
                        MessageBox.Show("Member ID not found.");
                        return;
                    }

                    // Insert issue record
                    string query = @"INSERT INTO IssueBooks
                            (BookID, MemberID, IssueDate, DueDate, ReturnDate)
                            VALUES
                            (@BookID, @MemberID, @IssueDate, @DueDate, @ReturnDate)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                    cmd.Parameters.AddWithValue("@IssueDate", dtpIssueDate.Value.Date);
                    cmd.Parameters.AddWithValue("@DueDate", dtpDueDate.Value.Date);

                    if (dtpReturnDate.Checked)
                    {
                        cmd.Parameters.AddWithValue("@ReturnDate",
                            dtpReturnDate.Value.Date);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ReturnDate", DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();

                    // Reduce available quantity by 1
                    string updateQuery = @"UPDATE Books
                                   SET Quantity = Quantity - 1
                                   WHERE BookID=@BookID";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);

                    updateCmd.Parameters.AddWithValue("@BookID", bookID);

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Book Issued Successfully!");

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
            txtBookID.Clear();
            txtMemberID.Clear();

            txtBookTitle.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
            txtAvailableQty.Clear();

            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(7);
            dtpReturnDate.Checked = false;

            txtBookID.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBookID_Leave(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                txtBookTitle.Clear();
                txtAuthor.Clear();
                txtCategory.Clear();
                txtAvailableQty.Clear();
                return;
            }

            int bookID;

            if (!int.TryParse(txtBookID.Text, out bookID))
            {
                MessageBox.Show("Please enter a valid Book ID.");
                txtBookID.Focus();
                return;
            }

            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "SELECT BookName, Author, Category, Quantity FROM Books WHERE BookID=@BookID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@BookID", bookID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtBookTitle.Text = reader["BookName"].ToString();
                        txtAuthor.Text = reader["Author"].ToString();
                        txtCategory.Text = reader["Category"].ToString();
                        txtAvailableQty.Text = reader["Quantity"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found.");

                        txtBookTitle.Clear();
                        txtAuthor.Clear();
                        txtCategory.Clear();
                        txtAvailableQty.Clear();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

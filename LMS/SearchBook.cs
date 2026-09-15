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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
            cmbSearchBy.SelectedIndex = 0;
            LoadBooks();
        }
        // Load all books
        private void LoadBooks()
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "SELECT BookID, BookName, Author, Category, Quantity FROM Books";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvSearchResults.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            cmbSearchBy.SelectedIndex = 0;

            LoadBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter something to search.");
                    return;
                }

                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "";

                    if (cmbSearchBy.Text == "Book ID")
                    {
                        query = "SELECT BookID, BookName, Author, Category, Quantity " +
                                "FROM Books WHERE BookID LIKE @Search";
                    }
                    else if (cmbSearchBy.Text == "Book Name")
                    {
                        query = "SELECT BookID, BookName, Author, Category, Quantity " +
                                "FROM Books WHERE BookName LIKE @Search";
                    }
                    else if (cmbSearchBy.Text == "Author")
                    {
                        query = "SELECT BookID, BookName, Author, Category, Quantity " +
                                "FROM Books WHERE Author LIKE @Search";
                    }
                    else if (cmbSearchBy.Text == "Category")
                    {
                        query = "SELECT BookID, BookName, Author, Category, Quantity " +
                                "FROM Books WHERE Category LIKE @Search";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text.Trim() + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No book found.");
                        dgvSearchResults.DataSource = null;
                    }
                    else
                    {
                        dgvSearchResults.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

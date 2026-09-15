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
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "INSERT INTO Books (BookID, BookName, Author, Category, Quantity) VALUES (@BookID, @BookName, @Author, @Category, @Quantity)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@BookID", txtBookID.Text);
                    cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book Added Successfully!");

                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadBooks()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Books";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvBooks.DataSource = dt;
            }
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "UPDATE Books SET BookName=@BookName, Author=@Author, Category=@Category, Quantity=@Quantity WHERE BookID=@BookID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@BookID", int.Parse(txtBookID.Text));
                    cmd.Parameters.AddWithValue("@BookName", txtBookName.Text);
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Category", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Book Updated Successfully!");
                        LoadBooks();
                    }
                    else
                    {
                        MessageBox.Show("Book ID not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "DELETE FROM Books WHERE BookID=@BookID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@BookID", txtBookID.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book Deleted Successfully!");

                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBookID.Text = dgvBooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBookName.Text = dgvBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAuthor.Text = dgvBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCategory.Text = dgvBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtQuantity.Text = dgvBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }
}

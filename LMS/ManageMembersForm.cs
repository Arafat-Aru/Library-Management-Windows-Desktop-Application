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
    public partial class ManageMembersForm : Form
    {
        public ManageMembersForm()
        {
            InitializeComponent();
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }
        private void LoadMembers()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Members";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvMembers.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "INSERT INTO Members (MemberID, MemberName, Email, PhoneNumber, Address) VALUES (@MemberID, @MemberName, @Email, @PhoneNumber, @Address)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@MemberID", int.Parse(txtMemberID.Text));
                    cmd.Parameters.AddWithValue("@MemberName", txtMemberName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Member Added Successfully!");

                    LoadMembers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    string query = "UPDATE Members SET MemberName=@MemberName, Email=@Email, PhoneNumber=@PhoneNumber, Address=@Address WHERE MemberID=@MemberID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@MemberID", int.Parse(txtMemberID.Text));
                    cmd.Parameters.AddWithValue("@MemberName", txtMemberName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Member Updated Successfully!");
                        LoadMembers();
                    }
                    else
                    {
                        MessageBox.Show("Member ID not found!");
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

                    string query = "DELETE FROM Members WHERE MemberID=@MemberID";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@MemberID", int.Parse(txtMemberID.Text));

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Member Deleted Successfully!");
                        LoadMembers();
                    }
                    else
                    {
                        MessageBox.Show("Member ID not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemberID.Clear();
            txtMemberName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMemberID.Text = dgvMembers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMemberName.Text = dgvMembers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEmail.Text = dgvMembers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dgvMembers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAddress.Text = dgvMembers.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }
    }

}

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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //TestConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string identifier = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(identifier) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username/email and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Checks credentials using either FullName or Email matching the database
            string query = @"SELECT UserId, FullName, Role, IsActive 
                             FROM Users 
                             WHERE (FullName = @id OR Email = @id) AND Password = @pwd";

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", identifier);
                        cmd.Parameters.AddWithValue("@pwd", password);

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool isActive = Convert.ToBoolean(reader["IsActive"]);
                                string role = reader["Role"].ToString();

                                if (!isActive)
                                {
                                    MessageBox.Show("Your account has been deactivated. Contact the administrator.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    return;
                                }

                                this.Hide();

                                // Route user based on role
                                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                                    role.Equals("System Administrator", StringComparison.OrdinalIgnoreCase))
                                {
                                    DashboardForm adminDashboard = new DashboardForm();
                                    adminDashboard.FormClosed += (s, args) => this.Close();
                                    adminDashboard.Show();
                                }
                                else if (role.Equals("Librarian", StringComparison.OrdinalIgnoreCase) ||
                                         role.Equals("Librarian / Staff", StringComparison.OrdinalIgnoreCase) ||
                                         role.IndexOf("Librarian", StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    LibrarianDashboard librarianDashboard = new LibrarianDashboard();
                                    librarianDashboard.FormClosed += (s, args) => this.Close();
                                    librarianDashboard.Show();
                                }
                                else
                                {
                                    MessageBox.Show($"Role '{role}' is not supported yet.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username/email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtPassword.Clear();
                                txtPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to Exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMS
{
    public partial class UC_UserManagement : UserControl
    {
        public UC_UserManagement()
        {
            InitializeComponent();
        }

        private void UC_UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // Fetch all users from SQL Server into DataGridView
        public void LoadUsers()
        {
            string query = "SELECT UserId, FullName, Email, Role, IsActive FROM Users";

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvUsers.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Users: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Feature 4: Create User Account
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            string fullName = txtNewUsername.Text.Trim();
            string password = txtNewPassword.Text.Trim();
            string email = txtNewEmail.Text.Trim();
            string role = cmbRole.SelectedItem != null ? cmbRole.SelectedItem.ToString() : "";

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields before creating an account.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"INSERT INTO Users (FullName, Password, Email, Role, IsActive) 
                             VALUES (@fullName, @password, @email, @role, 1)";

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fullName", fullName);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@role", role);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadUsers();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("A user with this detail already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Feature 5: AssignUserRole(userId, newRole)
        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user from the table first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select the target role.", "Role Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            string newRole = cmbRole.SelectedItem.ToString();
            string query = "UPDATE Users SET Role = @newRole WHERE UserId = @userId";

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newRole", newRole);
                        cmd.Parameters.AddWithValue("@userId", selectedUserId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Role updated to '{newRole}' successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update role: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Feature 6: DeactivateUserAccount(userId)
        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to deactivate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
            string fullName = dgvUsers.SelectedRows[0].Cells["FullName"].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to deactivate '{fullName}'?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            string query = "UPDATE Users SET IsActive = 0 WHERE UserId = @userId";

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", selectedUserId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Account '{fullName}' deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to deactivate account: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Refresh Table
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // Autofill inputs when clicking any row
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtNewUsername.Text = row.Cells["FullName"].Value?.ToString();
                txtNewEmail.Text = row.Cells["Email"].Value?.ToString();
                cmbRole.SelectedItem = row.Cells["Role"].Value?.ToString();
            }
        }

        private void ClearForm()
        {
            txtNewUsername.Clear();
            txtNewPassword.Clear();
            txtNewEmail.Clear();
            cmbRole.SelectedIndex = -1;
        }
    }
}


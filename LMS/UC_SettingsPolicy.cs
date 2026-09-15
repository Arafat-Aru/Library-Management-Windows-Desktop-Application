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
    public partial class UC_SettingsPolicy : UserControl
    {
        public UC_SettingsPolicy()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void UC_SettingsPolicy_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
        public void LoadSettings()
        {
            string query = "SELECT SettingKey, SettingValue, Category, UpdatedAt FROM SystemSettings";

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvSettings.DataSource = dt;

                        // Auto-fill individual textboxes with existing database values
                        foreach (DataRow row in dt.Rows)
                        {
                            string key = row["SettingKey"].ToString();
                            string val = row["SettingValue"].ToString();

                            switch (key)
                            {
                                case "DailyFineRate":
                                    txtDailyFine.Text = val;
                                    break;
                                case "GracePeriodDays":
                                    txtGracePeriod.Text = val;
                                    break;
                                case "StudentMaxLoanDays":
                                    txtStudentLoanDays.Text = val;
                                    break;
                                case "FacultyMaxLoanDays":
                                    txtFacultyLoanDays.Text = val;
                                    break;
                                case "MaxBooksAllowed":
                                    txtMaxBooks.Text = val;
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load policies: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePolicies_Click(object sender, EventArgs e)
        {
            string dailyFine = txtDailyFine.Text.Trim();
            string gracePeriod = txtGracePeriod.Text.Trim();
            string studentLoanDays = txtStudentLoanDays.Text.Trim();
            string facultyLoanDays = txtFacultyLoanDays.Text.Trim();
            string maxBooks = txtMaxBooks.Text.Trim();

            if (string.IsNullOrEmpty(dailyFine) || string.IsNullOrEmpty(gracePeriod) ||
                string.IsNullOrEmpty(studentLoanDays) || string.IsNullOrEmpty(facultyLoanDays) ||
                string.IsNullOrEmpty(maxBooks))
            {
                MessageBox.Show("Please ensure all policy fields are filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"
                UPDATE SystemSettings SET SettingValue = @dailyFine, UpdatedAt = GETDATE() WHERE SettingKey = 'DailyFineRate';
                UPDATE SystemSettings SET SettingValue = @gracePeriod, UpdatedAt = GETDATE() WHERE SettingKey = 'GracePeriodDays';
                UPDATE SystemSettings SET SettingValue = @studentLoan, UpdatedAt = GETDATE() WHERE SettingKey = 'StudentMaxLoanDays';
                UPDATE SystemSettings SET SettingValue = @facultyLoan, UpdatedAt = GETDATE() WHERE SettingKey = 'FacultyMaxLoanDays';
                UPDATE SystemSettings SET SettingValue = @maxBooks, UpdatedAt = GETDATE() WHERE SettingKey = 'MaxBooksAllowed';";

            try
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dailyFine", dailyFine);
                        cmd.Parameters.AddWithValue("@gracePeriod", gracePeriod);
                        cmd.Parameters.AddWithValue("@studentLoan", studentLoanDays);
                        cmd.Parameters.AddWithValue("@facultyLoan", facultyLoanDays);
                        cmd.Parameters.AddWithValue("@maxBooks", maxBooks);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("System settings and fine policies updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update settings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshSettings_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }

}

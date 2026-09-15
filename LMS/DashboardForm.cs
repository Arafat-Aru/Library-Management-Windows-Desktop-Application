using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
       private void LoadUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UC_UserManagement());
        }

        private void btnNavUsers_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_UserManagement());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnNavSettings_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_SettingsPolicy());
        }

        private void btnNavDatabase_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_DatabaseTools());
        }

        private void btnNavReports_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_LogsReports());
        }
    }
}

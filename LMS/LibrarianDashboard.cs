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
    public partial class LibrarianDashboard : Form
    {
        public LibrarianDashboard()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            ManageBooksForm form = new ManageBooksForm();
            form.ShowDialog();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            ManageMembersForm form = new ManageMembersForm();
            form.ShowDialog();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            IssueBook form = new IssueBook();
            form.Show();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBook form = new ReturnBook();
            form.Show();
        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            FineManagement form = new FineManagement();
            form.Show();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            SearchBook searchBook = new SearchBook();
            searchBook.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                this.Hide();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}

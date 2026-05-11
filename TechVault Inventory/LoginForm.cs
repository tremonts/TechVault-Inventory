using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechVaultManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(221, 230, 237);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbUserType.Text == "Admin")
            {
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Hide();
            }
            else if (cmbUserType.Text == "Customer")
            {
                CustomerDashboard customer = new CustomerDashboard();
                customer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select user type");
            }
        }
    }
}
using System;
using System.Windows.Forms;
using ToDoListProcess.DL; 
using System;
using System.Windows.Forms;
using ToDoListProcess.DL; 

namespace TodoList
{
    public partial class Form1 : Form
    {
        private readonly DbUserManager userManager = new DbUserManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            bool isValid = userManager.Authenticate(username, password);
            if (isValid)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                Dashboard dashboard = new Dashboard(username);
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password..");
                tbPassword.Clear();
                tbUsername.Focus();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register loginForm = new Register();
            loginForm.Show();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



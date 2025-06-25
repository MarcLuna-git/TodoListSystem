using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListProcess.DL; 
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using TodoList;
namespace TodoList
{
    public partial class Register : Form
    {
        private readonly DbUserManager userManager = new DbUserManager();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool registered = userManager.Register(username, password);
            if (registered)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                tbUsername.Clear();

            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

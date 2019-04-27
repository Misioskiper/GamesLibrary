using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bibliotekaGier
{
    public partial class LoginForm : Form
    {
        private string _login = "user";
        private string _password = "user1234";
        public LoginForm()
        {
            InitializeComponent();
            wrongPasswordLabel.Visible = false;
            passwordTextBox.PasswordChar = '*';
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            var isUserNameValid = loginTextBox.Text.Equals(_login);
            var isPasswordValid = passwordTextBox.Text.Equals(_password);
            if(isUserNameValid && isPasswordValid)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                wrongPasswordLabel.Visible = true;
                loginTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }
        }
    }
}

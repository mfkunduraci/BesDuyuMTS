using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BesDuyuMTS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        MainPage mainPage = new MainPage();
        RegisterPage registerPage = new RegisterPage();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please enter username and password!");
                return;
            }
            if (usernameBox.Text == "admin" && passwordBox.Text == "password")
            {
                this.Hide();
                mainPage.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerPage.Show();

        }
    }
}

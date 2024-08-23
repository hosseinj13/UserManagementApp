using System;
using System.Drawing;
using System.Windows.Forms;
using MyWinFormsApp.Services; 
using MyWinFormsApp.Models;  

namespace MyWinFormsApp.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;

        public LoginForm(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string identifier = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                var user = _userService.ValidateUser(identifier, password);
                if (user != null)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while logging in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFormFields();
            }
        }

        private void ClearFormFields()
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWinFormsApp.Models;
using MyWinFormsApp.Services;
using MyWinFormsApp.Utils;

namespace MyWinFormsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly IUserService _userService;

        public MainForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _userService.GetAllUsers();
            usersDataGridView.DataSource = users;
            usersDataGridView.Columns["Password"].Visible = false;
            usersDataGridView.AutoResizeColumns();
        }

        private async void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Username = usernameTextBox.Text,
                    Password = passwordTextBox.Text,
                    Email = emailTextBox.Text,
                    PhoneNumber = phoneNumberTextBox.Text,
                };

                if (!Validation.IsEmailValid(user.Email))
                {
                    MessageBox.Show(
                        "Invalid email format.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                _userService.CreateUser(user);
                MessageBox.Show(
                    "User added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearFormFields();
                LoadUsers();

                await Task.Delay(5000);

                var loginForm = new LoginForm(_userService);
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while adding the user: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                ClearFormFields();
            }
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (usersDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a user to update.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                var selectedUser = (User)usersDataGridView.SelectedRows[0].DataBoundItem;
                selectedUser.FirstName = firstNameTextBox.Text;
                selectedUser.LastName = lastNameTextBox.Text;
                selectedUser.Username = usernameTextBox.Text;
                selectedUser.Password = passwordTextBox.Text;
                selectedUser.Email = emailTextBox.Text;
                selectedUser.PhoneNumber = phoneNumberTextBox.Text;

                if (!Validation.IsEmailValid(selectedUser.Email))
                {
                    MessageBox.Show(
                        "Invalid email format.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                _userService.UpdateUser(selectedUser);
                MessageBox.Show(
                    "User updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ClearFormFields();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while updating the user: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                ClearFormFields();
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (usersDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a user to delete.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                var selectedUser = (User)usersDataGridView.SelectedRows[0].DataBoundItem;
                var confirmation = MessageBox.Show(
                    $"Are you sure you want to delete user {selectedUser.Username}?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmation == DialogResult.Yes)
                {
                    _userService.DeleteUser(selectedUser.Id);
                    MessageBox.Show(
                        "User deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    ClearFormFields(); // پاک کردن فیلدها پس از حذف
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while deleting the user: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                ClearFormFields(); // پاک کردن فیلدها در صورت خطا
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var loginForm = new LoginForm(_userService);
                loginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred during login: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void usersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count > 0)
            {
                var selectedUser = (User)usersDataGridView.SelectedRows[0].DataBoundItem;
                firstNameTextBox.Text = selectedUser.FirstName;
                lastNameTextBox.Text = selectedUser.LastName;
                usernameTextBox.Text = selectedUser.Username;
                passwordTextBox.Text = selectedUser.Password;
                emailTextBox.Text = selectedUser.Email;
                phoneNumberTextBox.Text = selectedUser.PhoneNumber;
            }
        }

        private void ClearFormFields()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            emailTextBox.Clear();
            phoneNumberTextBox.Clear();
        }
    }
}

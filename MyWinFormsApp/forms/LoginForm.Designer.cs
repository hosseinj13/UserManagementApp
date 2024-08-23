namespace MyWinFormsApp.Forms
{
    partial class LoginForm
    {
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label messageLabel;

        private void InitializeComponent()
        {
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(50, 30);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.PlaceholderText = "Username, Email or PhoneNumber";
            
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(50, 70);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.PlaceholderText = "Password";
            
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(100, 110);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);


            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(100, 150); 
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(100, 30);
            this.signupButton.TabIndex = 3;
            this.signupButton.Text = "Signup";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.SignupButton_Click);
            
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(50, 150);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 3;
            
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.messageLabel);
            this.Name = "LoginForm";
            this.Text = "User Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

         private void SignupButton_Click(object sender, EventArgs e)
          {
            var mainForm = new MainForm(_userService); 
            mainForm.Show(); 
            this.Hide(); 
          }
    }
}

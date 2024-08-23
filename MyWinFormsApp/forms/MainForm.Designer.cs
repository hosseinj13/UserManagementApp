namespace MyWinFormsApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private TextBox phoneNumberTextBox;
        private Button addUserButton;
        private Button updateUserButton;
        private Button deleteUserButton;
        private Button loginButton;
        private DataGridView usersDataGridView;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label usernameLabel;
        private Label passwordLabel;
        private Label emailLabel;
        private Label phoneNumberLabel;
        private Panel formPanel;
        private Panel buttonsPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // Labels
            this.firstNameLabel = new Label();
            this.lastNameLabel = new Label();
            this.usernameLabel = new Label();
            this.passwordLabel = new Label();
            this.emailLabel = new Label();
            this.phoneNumberLabel = new Label();

            // TextBoxes
            this.firstNameTextBox = new TextBox();
            this.lastNameTextBox = new TextBox();
            this.usernameTextBox = new TextBox();
            this.passwordTextBox = new TextBox();
            this.emailTextBox = new TextBox();
            this.phoneNumberTextBox = new TextBox();

            // Buttons
            this.addUserButton = new Button();
            this.updateUserButton = new Button();
            this.deleteUserButton = new Button();
            this.loginButton = new Button();

            // DataGridView
            this.usersDataGridView = new DataGridView();

            // Panels
            this.formPanel = new Panel();
            this.buttonsPanel = new Panel();

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.usersDataGridView);
            this.Name = "MainForm";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.MainForm_Load);

            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.firstNameLabel);
            this.formPanel.Controls.Add(this.lastNameLabel);
            this.formPanel.Controls.Add(this.usernameLabel);
            this.formPanel.Controls.Add(this.passwordLabel);
            this.formPanel.Controls.Add(this.emailLabel);
            this.formPanel.Controls.Add(this.phoneNumberLabel);
            this.formPanel.Controls.Add(this.firstNameTextBox);
            this.formPanel.Controls.Add(this.lastNameTextBox);
            this.formPanel.Controls.Add(this.usernameTextBox);
            this.formPanel.Controls.Add(this.passwordTextBox);
            this.formPanel.Controls.Add(this.emailTextBox);
            this.formPanel.Controls.Add(this.phoneNumberTextBox);
            this.formPanel.Location = new System.Drawing.Point(12, 12);
            this.formPanel.Size = new System.Drawing.Size(776, 200);
            this.formPanel.BackColor = System.Drawing.Color.LightSteelBlue;

            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.addUserButton);
            this.buttonsPanel.Controls.Add(this.updateUserButton);
            this.buttonsPanel.Controls.Add(this.deleteUserButton);
             this.buttonsPanel.Controls.Add(this.loginButton);
            this.buttonsPanel.Location = new System.Drawing.Point(12, 220);
            this.buttonsPanel.Size = new System.Drawing.Size(776, 50);
            this.buttonsPanel.BackColor = System.Drawing.Color.LightGray;

            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(10, 20);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.Text = "First Name";

            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(100, 20);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 0;

            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(10, 50);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.Text = "Last Name";

            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(100, 50);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 1;

            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(10, 80);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.Text = "Username";

            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(100, 80);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.usernameTextBox.TabIndex = 2;

            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(10, 110);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.Text = "Password";

            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(100, 110);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;

            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(10, 140);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.Text = "Email";

            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(100, 140);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 4;

            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(10, 170);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLabel.Text = "Phone Number";

            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(100, 170);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 5;

            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(10, 10);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(100, 30);
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false; 
            this.addUserButton.BackColor = System.Drawing.Color.ForestGreen; 
            this.addUserButton.ForeColor = System.Drawing.Color.White; 
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat; 
            this.addUserButton.Click += new System.EventHandler(this.AddUserButton_Click);

            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(120, 10);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(100, 30);
            this.updateUserButton.Text = "Update User";
            this.updateUserButton.UseVisualStyleBackColor = false; 
            this.updateUserButton.BackColor = System.Drawing.Color.DarkOrange; 
            this.updateUserButton.ForeColor = System.Drawing.Color.White; 
            this.updateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat; 
            this.updateUserButton.Click += new System.EventHandler(this.UpdateUserButton_Click);

            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(230, 10);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(100, 30);
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false; 
            this.deleteUserButton.BackColor = System.Drawing.Color.Crimson; 
            this.deleteUserButton.ForeColor = System.Drawing.Color.White; 
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);


            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(340, 10); 
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false; 
            this.loginButton.BackColor = System.Drawing.Color.SteelBlue; 
            this.loginButton.ForeColor = System.Drawing.Color.White; 
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat; 
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);

            

            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AllowUserToAddRows = false;
            this.usersDataGridView.AllowUserToDeleteRows = false;
            this.usersDataGridView.AllowUserToResizeColumns = false;
            this.usersDataGridView.AllowUserToResizeRows = false;
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.usersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(12, 280);
            this.usersDataGridView.MultiSelect = false;
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.ReadOnly = true;
            this.usersDataGridView.RowHeadersVisible = false;
            this.usersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDataGridView.Size = new System.Drawing.Size(776, 308);
            this.usersDataGridView.TabIndex = 0;
            this.usersDataGridView.SelectionChanged += new System.EventHandler(this.usersDataGridView_SelectionChanged);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.usersDataGridView);
            this.Name = "MainForm";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

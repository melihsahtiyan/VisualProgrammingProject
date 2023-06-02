namespace WindowsApplication.Pages
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            lblPassword = new Label();
            passwordTxtBox = new TextBox();
            lblEmail = new Label();
            emailTxtBox = new TextBox();
            failedTxtLbl = new Label();
            txtAccount = new Label();
            RegisterLinkLbl = new LinkLabel();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.AutoSize = true;
            btnLogin.Location = new Point(473, 390);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.Control;
            lblPassword.Location = new Point(376, 301);
            lblPassword.Margin = new Padding(3);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 28);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Anchor = AnchorStyles.None;
            passwordTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxtBox.Location = new Point(490, 298);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.Size = new Size(180, 34);
            passwordTxtBox.TabIndex = 7;
            passwordTxtBox.TextChanged += passwordTxtBox_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.Control;
            lblEmail.Location = new Point(411, 261);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Anchor = AnchorStyles.None;
            emailTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTxtBox.Location = new Point(490, 258);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(180, 34);
            emailTxtBox.TabIndex = 5;
            emailTxtBox.TextChanged += emailTxtBox_TextChanged;
            // 
            // failedTxtLbl
            // 
            failedTxtLbl.Anchor = AnchorStyles.None;
            failedTxtLbl.AutoSize = true;
            failedTxtLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            failedTxtLbl.ForeColor = Color.Firebrick;
            failedTxtLbl.Location = new Point(333, 433);
            failedTxtLbl.Name = "failedTxtLbl";
            failedTxtLbl.RightToLeft = RightToLeft.No;
            failedTxtLbl.Size = new Size(415, 28);
            failedTxtLbl.TabIndex = 9;
            failedTxtLbl.Text = "Login failed. Please check email and password!";
            failedTxtLbl.Visible = false;
            // 
            // txtAccount
            // 
            txtAccount.Anchor = AnchorStyles.None;
            txtAccount.AutoSize = true;
            txtAccount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccount.ForeColor = SystemColors.Control;
            txtAccount.Location = new Point(375, 350);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(250, 25);
            txtAccount.TabIndex = 10;
            txtAccount.Text = "Haven't craeted an account?";
            // 
            // RegisterLinkLbl
            // 
            RegisterLinkLbl.Anchor = AnchorStyles.None;
            RegisterLinkLbl.AutoSize = true;
            RegisterLinkLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterLinkLbl.LinkColor = Color.FromArgb(50, 150, 255);
            RegisterLinkLbl.Location = new Point(625, 350);
            RegisterLinkLbl.Name = "RegisterLinkLbl";
            RegisterLinkLbl.Size = new Size(79, 25);
            RegisterLinkLbl.TabIndex = 11;
            RegisterLinkLbl.TabStop = true;
            RegisterLinkLbl.Text = "Register";
            RegisterLinkLbl.LinkClicked += RegisterLinkLbl_LinkClicked;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1082, 749);
            Controls.Add(RegisterLinkLbl);
            Controls.Add(txtAccount);
            Controls.Add(failedTxtLbl);
            Controls.Add(lblPassword);
            Controls.Add(passwordTxtBox);
            Controls.Add(lblEmail);
            Controls.Add(emailTxtBox);
            Controls.Add(btnLogin);
            Name = "LoginScreen";
            Text = "LoginScreen";
            Load += LoginScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblPassword;
        private TextBox passwordTxtBox;
        private Label lblEmail;
        private TextBox emailTxtBox;
        private Label failedTxtLbl;
        private Label txtAccount;
        private LinkLabel RegisterLinkLbl;
    }
}
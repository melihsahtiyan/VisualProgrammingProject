namespace WindowsApplication.Pages
{
    partial class RegisterScreen
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
            registerButton = new Button();
            lblEmail = new Label();
            lblPassword = new Label();
            lblName = new Label();
            addressLbl = new Label();
            lblTaxNumber = new Label();
            LoginLinkLbl = new LinkLabel();
            txtAccount = new Label();
            failedTxtLbl = new Label();
            lblPhone = new Label();
            checkBoxCustomer = new CheckBox();
            checkBoxSupplier = new CheckBox();
            emailTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            nameTxtBox = new TextBox();
            phoneTxtBox = new TextBox();
            taxNumberTxtBox = new TextBox();
            addressTxtBox = new TextBox();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.None;
            registerButton.ForeColor = SystemColors.ActiveCaptionText;
            registerButton.Location = new Point(518, 506);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(120, 40);
            registerButton.TabIndex = 0;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.Control;
            lblEmail.Location = new Point(434, 151);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.None;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.Control;
            lblPassword.Location = new Point(399, 191);
            lblPassword.Margin = new Padding(3);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = SystemColors.Control;
            lblName.Location = new Point(426, 231);
            lblName.Margin = new Padding(3);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 28);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // addressLbl
            // 
            addressLbl.Anchor = AnchorStyles.None;
            addressLbl.AutoSize = true;
            addressLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressLbl.ForeColor = SystemColors.Control;
            addressLbl.Location = new Point(407, 271);
            addressLbl.Margin = new Padding(3);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(86, 28);
            addressLbl.TabIndex = 8;
            addressLbl.Text = "Address:";
            // 
            // lblTaxNumber
            // 
            lblTaxNumber.Anchor = AnchorStyles.None;
            lblTaxNumber.AutoSize = true;
            lblTaxNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTaxNumber.ForeColor = SystemColors.Control;
            lblTaxNumber.Location = new Point(373, 310);
            lblTaxNumber.Margin = new Padding(3);
            lblTaxNumber.Name = "lblTaxNumber";
            lblTaxNumber.Size = new Size(120, 28);
            lblTaxNumber.TabIndex = 10;
            lblTaxNumber.Text = "Tax Number:";
            // 
            // LoginLinkLbl
            // 
            LoginLinkLbl.Anchor = AnchorStyles.None;
            LoginLinkLbl.AutoSize = true;
            LoginLinkLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LoginLinkLbl.LinkColor = Color.FromArgb(50, 150, 255);
            LoginLinkLbl.Location = new Point(626, 463);
            LoginLinkLbl.Name = "LoginLinkLbl";
            LoginLinkLbl.Size = new Size(59, 25);
            LoginLinkLbl.TabIndex = 13;
            LoginLinkLbl.TabStop = true;
            LoginLinkLbl.Text = "Login";
            // 
            // txtAccount
            // 
            txtAccount.Anchor = AnchorStyles.None;
            txtAccount.AutoSize = true;
            txtAccount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccount.ForeColor = SystemColors.Control;
            txtAccount.Location = new Point(403, 463);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(228, 25);
            txtAccount.TabIndex = 12;
            txtAccount.Text = "Already have an account?";
            // 
            // failedTxtLbl
            // 
            failedTxtLbl.Anchor = AnchorStyles.None;
            failedTxtLbl.AutoSize = true;
            failedTxtLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            failedTxtLbl.ForeColor = Color.Firebrick;
            failedTxtLbl.Location = new Point(360, 575);
            failedTxtLbl.Name = "failedTxtLbl";
            failedTxtLbl.RightToLeft = RightToLeft.No;
            failedTxtLbl.Size = new Size(409, 28);
            failedTxtLbl.TabIndex = 14;
            failedTxtLbl.Text = "Registration failed. Please check informations!";
            failedTxtLbl.Visible = false;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.None;
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.ForeColor = SystemColors.Control;
            lblPhone.Location = new Point(420, 349);
            lblPhone.Margin = new Padding(3);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(71, 28);
            lblPhone.TabIndex = 16;
            lblPhone.Text = "Phone:";
            // 
            // checkBoxCustomer
            // 
            checkBoxCustomer.AutoSize = true;
            checkBoxCustomer.Location = new Point(599, 397);
            checkBoxCustomer.Name = "checkBoxCustomer";
            checkBoxCustomer.Size = new Size(94, 24);
            checkBoxCustomer.TabIndex = 17;
            checkBoxCustomer.Text = "Customer";
            checkBoxCustomer.UseVisualStyleBackColor = true;
            checkBoxCustomer.CheckedChanged += checkBoxCustomer_CheckedChanged;
            // 
            // checkBoxSupplier
            // 
            checkBoxSupplier.AutoSize = true;
            checkBoxSupplier.Location = new Point(485, 397);
            checkBoxSupplier.Name = "checkBoxSupplier";
            checkBoxSupplier.Size = new Size(86, 24);
            checkBoxSupplier.TabIndex = 18;
            checkBoxSupplier.Text = "Supplier";
            checkBoxSupplier.UseVisualStyleBackColor = true;
            checkBoxSupplier.CheckedChanged += checkBoxSupplier_CheckedChanged;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Anchor = AnchorStyles.None;
            emailTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTxtBox.Location = new Point(513, 145);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(180, 34);
            emailTxtBox.TabIndex = 19;
            emailTxtBox.TextChanged += emailTxtBox_TextChanged_1;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Anchor = AnchorStyles.None;
            passwordTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxtBox.Location = new Point(513, 187);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(180, 34);
            passwordTxtBox.TabIndex = 20;
            passwordTxtBox.UseSystemPasswordChar = true;
            passwordTxtBox.TextChanged += passwordTxtBox_TextChanged_1;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Anchor = AnchorStyles.None;
            nameTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTxtBox.Location = new Point(513, 226);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(180, 34);
            nameTxtBox.TabIndex = 21;
            nameTxtBox.TextChanged += nameTxtBox_TextChanged;
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.Anchor = AnchorStyles.None;
            phoneTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTxtBox.Location = new Point(513, 343);
            phoneTxtBox.MaxLength = 11;
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.Size = new Size(180, 34);
            phoneTxtBox.TabIndex = 24;
            phoneTxtBox.TextChanged += phoneTxtBox_TextChanged;
            // 
            // taxNumberTxtBox
            // 
            taxNumberTxtBox.Anchor = AnchorStyles.None;
            taxNumberTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            taxNumberTxtBox.Location = new Point(513, 304);
            taxNumberTxtBox.Name = "taxNumberTxtBox";
            taxNumberTxtBox.Size = new Size(180, 34);
            taxNumberTxtBox.TabIndex = 23;
            taxNumberTxtBox.TextChanged += taxNumberTxtBox_TextChanged;
            // 
            // addressTxtBox
            // 
            addressTxtBox.Anchor = AnchorStyles.None;
            addressTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressTxtBox.Location = new Point(513, 265);
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(180, 34);
            addressTxtBox.TabIndex = 22;
            addressTxtBox.TextChanged += addressTxtBox_TextChanged;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1066, 712);
            Controls.Add(phoneTxtBox);
            Controls.Add(taxNumberTxtBox);
            Controls.Add(addressTxtBox);
            Controls.Add(nameTxtBox);
            Controls.Add(passwordTxtBox);
            Controls.Add(emailTxtBox);
            Controls.Add(checkBoxSupplier);
            Controls.Add(checkBoxCustomer);
            Controls.Add(lblPhone);
            Controls.Add(failedTxtLbl);
            Controls.Add(LoginLinkLbl);
            Controls.Add(txtAccount);
            Controls.Add(lblTaxNumber);
            Controls.Add(addressLbl);
            Controls.Add(lblName);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(registerButton);
            ForeColor = SystemColors.Control;
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            Load += RegisterScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblName;
        private Label addressLbl;
        private Label lblTaxNumber;
        private LinkLabel LoginLinkLbl;
        private Label txtAccount;
        private Label failedTxtLbl;
        private Label lblPhone;
        private CheckBox checkBoxCustomer;
        private CheckBox checkBoxSupplier;
        private TextBox emailTxtBox;
        private TextBox passwordTxtBox;
        private TextBox nameTxtBox;
        private TextBox phoneTxtBox;
        private TextBox taxNumberTxtBox;
        private TextBox addressTxtBox;
    }
}
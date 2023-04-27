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
            emailTxtBox = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            passwordTxtBox = new TextBox();
            lblFirstName = new Label();
            firstNameTxtBox = new TextBox();
            lastNameLbl = new Label();
            lastNameTxtBox = new TextBox();
            lblIdentityNumber = new Label();
            IdentityNumberTxtBox = new TextBox();
            birthDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // registerButton
            // 
            registerButton.Location = new Point(470, 388);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(120, 40);
            registerButton.TabIndex = 0;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTxtBox.Location = new Point(493, 72);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(180, 34);
            emailTxtBox.TabIndex = 1;
            emailTxtBox.TextChanged += emailTxtBox_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(414, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(379, 115);
            lblPassword.Margin = new Padding(3);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTxtBox.Location = new Point(493, 112);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.Size = new Size(180, 34);
            passwordTxtBox.TabIndex = 3;
            passwordTxtBox.TextChanged += passwordTxtBox_TextChanged;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(366, 155);
            lblFirstName.Margin = new Padding(3);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 28);
            lblFirstName.TabIndex = 6;
            lblFirstName.Text = "First Name:";
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTxtBox.Location = new Point(493, 152);
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.Size = new Size(180, 34);
            firstNameTxtBox.TabIndex = 5;
            firstNameTxtBox.TextChanged += textBox2_TextChanged;
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLbl.Location = new Point(366, 195);
            lastNameLbl.Margin = new Padding(3);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(107, 28);
            lastNameLbl.TabIndex = 8;
            lastNameLbl.Text = "Last Name:";
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTxtBox.Location = new Point(493, 192);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(180, 34);
            lastNameTxtBox.TabIndex = 7;
            lastNameTxtBox.TextChanged += lastNameTxtBox_TextChanged;
            // 
            // lblIdentityNumber
            // 
            lblIdentityNumber.AutoSize = true;
            lblIdentityNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentityNumber.Location = new Point(312, 235);
            lblIdentityNumber.Margin = new Padding(3);
            lblIdentityNumber.Name = "lblIdentityNumber";
            lblIdentityNumber.Size = new Size(160, 28);
            lblIdentityNumber.TabIndex = 10;
            lblIdentityNumber.Text = "Identity Number:";
            // 
            // IdentityNumberTxtBox
            // 
            IdentityNumberTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdentityNumberTxtBox.Location = new Point(493, 232);
            IdentityNumberTxtBox.Name = "IdentityNumberTxtBox";
            IdentityNumberTxtBox.Size = new Size(180, 34);
            IdentityNumberTxtBox.TabIndex = 9;
            IdentityNumberTxtBox.TextChanged += IdentityNumberTxtBox_TextChanged;
            // 
            // birthDatePicker
            // 
            birthDatePicker.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            birthDatePicker.Location = new Point(366, 300);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(307, 27);
            birthDatePicker.TabIndex = 11;
            birthDatePicker.ValueChanged += birthDatePicker_ValueChanged;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 624);
            Controls.Add(birthDatePicker);
            Controls.Add(lblIdentityNumber);
            Controls.Add(IdentityNumberTxtBox);
            Controls.Add(lastNameLbl);
            Controls.Add(lastNameTxtBox);
            Controls.Add(lblFirstName);
            Controls.Add(firstNameTxtBox);
            Controls.Add(lblPassword);
            Controls.Add(passwordTxtBox);
            Controls.Add(lblEmail);
            Controls.Add(emailTxtBox);
            Controls.Add(registerButton);
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerButton;
        private TextBox emailTxtBox;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox passwordTxtBox;
        private Label lblFirstName;
        private TextBox firstNameTxtBox;
        private Label lastNameLbl;
        private TextBox lastNameTxtBox;
        private Label lblIdentityNumber;
        private TextBox IdentityNumberTxtBox;
        private DateTimePicker birthDatePicker;
    }
}
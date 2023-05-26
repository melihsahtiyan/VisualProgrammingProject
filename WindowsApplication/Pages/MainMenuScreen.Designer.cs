namespace WindowsApplication.Pages
{
    partial class MainMenuScreen
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
            lblWelcomeText = new Label();
            productListButton = new Button();
            stockListButton = new Button();
            btnOrderPage = new Button();
            productPortfolioTextLabel = new Label();
            SuspendLayout();
            // 
            // lblWelcomeText
            // 
            lblWelcomeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblWelcomeText.AutoSize = true;
            lblWelcomeText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcomeText.ForeColor = SystemColors.Control;
            lblWelcomeText.Location = new Point(380, 26);
            lblWelcomeText.Name = "lblWelcomeText";
            lblWelcomeText.Size = new Size(150, 41);
            lblWelcomeText.TabIndex = 0;
            lblWelcomeText.Text = "Welcome ";
            lblWelcomeText.Click += label1_Click;
            // 
            // productListButton
            // 
            productListButton.Location = new Point(330, 490);
            productListButton.Name = "productListButton";
            productListButton.Size = new Size(120, 40);
            productListButton.TabIndex = 1;
            productListButton.Text = "Product Page";
            productListButton.UseVisualStyleBackColor = true;
            productListButton.Click += productListButton_Click;
            // 
            // stockListButton
            // 
            stockListButton.Location = new Point(479, 490);
            stockListButton.Name = "stockListButton";
            stockListButton.Size = new Size(120, 40);
            stockListButton.TabIndex = 2;
            stockListButton.Text = "Stock Page";
            stockListButton.UseVisualStyleBackColor = true;
            stockListButton.Click += stockListButton_Click;
            // 
            // btnOrderPage
            // 
            btnOrderPage.Location = new Point(628, 490);
            btnOrderPage.Name = "btnOrderPage";
            btnOrderPage.Size = new Size(120, 40);
            btnOrderPage.TabIndex = 3;
            btnOrderPage.Text = "Order Page";
            btnOrderPage.UseVisualStyleBackColor = true;
            btnOrderPage.Click += btnOrderPage_Click;
            // 
            // productPortfolioTextLabel
            // 
            productPortfolioTextLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            productPortfolioTextLabel.AutoSize = true;
            productPortfolioTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productPortfolioTextLabel.ForeColor = SystemColors.Control;
            productPortfolioTextLabel.Location = new Point(71, 179);
            productPortfolioTextLabel.Name = "productPortfolioTextLabel";
            productPortfolioTextLabel.Size = new Size(347, 28);
            productPortfolioTextLabel.TabIndex = 4;
            productPortfolioTextLabel.Text = "Number of Products in your portfolio: ";
            productPortfolioTextLabel.Click += productPortfolioTextLabel_Click;
            // 
            // MainMenuScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1082, 710);
            Controls.Add(productPortfolioTextLabel);
            Controls.Add(btnOrderPage);
            Controls.Add(stockListButton);
            Controls.Add(productListButton);
            Controls.Add(lblWelcomeText);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainMenuScreen";
            Text = "MainMenuScreen";
            Load += MainMenuScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcomeText;
        private Button productListButton;
        private Button stockListButton;
        private Button btnOrderPage;
        private Label productPortfolioTextLabel;
    }
}
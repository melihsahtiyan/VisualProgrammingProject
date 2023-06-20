namespace WindowsApplication.Pages
{
    partial class OrderScreen
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
            label1 = new Label();
            orderListScreenButton = new Button();
            approveOrderButton = new Button();
            cancelOrderButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(568, 45);
            label1.Name = "label1";
            label1.Size = new Size(931, 82);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Order screen\r\nYou can order someting, or approve your order, or cancel your order.\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // orderListScreenButton
            // 
            orderListScreenButton.Location = new Point(792, 452);
            orderListScreenButton.Name = "orderListScreenButton";
            orderListScreenButton.Size = new Size(120, 50);
            orderListScreenButton.TabIndex = 1;
            orderListScreenButton.Text = "Order List Screen";
            orderListScreenButton.UseVisualStyleBackColor = true;
            orderListScreenButton.Click += orderListScreenButton_Click;
            // 
            // approveOrderButton
            // 
            approveOrderButton.Location = new Point(1014, 452);
            approveOrderButton.Name = "approveOrderButton";
            approveOrderButton.Size = new Size(120, 50);
            approveOrderButton.TabIndex = 2;
            approveOrderButton.Text = "Approve your order";
            approveOrderButton.UseVisualStyleBackColor = true;
            // 
            // cancelOrderButton
            // 
            cancelOrderButton.Location = new Point(1240, 452);
            cancelOrderButton.Name = "cancelOrderButton";
            cancelOrderButton.Size = new Size(120, 50);
            cancelOrderButton.TabIndex = 3;
            cancelOrderButton.Text = "Cancel your order";
            cancelOrderButton.UseVisualStyleBackColor = true;
            // 
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1902, 1033);
            Controls.Add(cancelOrderButton);
            Controls.Add(approveOrderButton);
            Controls.Add(orderListScreenButton);
            Controls.Add(label1);
            Name = "OrderScreen";
            Text = "OrderScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button orderListScreenButton;
        private Button approveOrderButton;
        private Button cancelOrderButton;
    }
}
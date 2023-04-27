namespace WindowsApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productTextLabel = new Label();
            txtChangeButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // productTextLabel
            // 
            productTextLabel.Location = new Point(0, 0);
            productTextLabel.Name = "productTextLabel";
            productTextLabel.Size = new Size(100, 23);
            productTextLabel.TabIndex = 2;
            // 
            // txtChangeButton
            // 
            txtChangeButton.Location = new Point(684, 362);
            txtChangeButton.Name = "txtChangeButton";
            txtChangeButton.Size = new Size(94, 29);
            txtChangeButton.TabIndex = 1;
            txtChangeButton.Text = "click!";
            txtChangeButton.UseVisualStyleBackColor = true;
            txtChangeButton.Click += txtChangeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(666, 208);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "productTxtLabel";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 708);
            Controls.Add(label1);
            Controls.Add(txtChangeButton);
            Controls.Add(productTextLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productTextLabel;
        private Button txtChangeButton;
        private Label label1;
    }
}
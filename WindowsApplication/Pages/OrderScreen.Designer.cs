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
            orderDataGridView = new DataGridView();
            lblFactoryText = new Label();
            Id = new DataGridViewTextBoxColumn();
            CustomerFactoryName = new DataGridViewTextBoxColumn();
            ManufaturerFactoryName = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // orderDataGridView
            // 
            orderDataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            orderDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, CustomerFactoryName, ManufaturerFactoryName, ProductName, Quantity });
            orderDataGridView.Location = new Point(256, 215);
            orderDataGridView.Margin = new Padding(6);
            orderDataGridView.Name = "orderDataGridView";
            orderDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            orderDataGridView.RowTemplate.Height = 29;
            orderDataGridView.Size = new Size(758, 410);
            orderDataGridView.TabIndex = 0;
            orderDataGridView.CellContentClick += orderDataGridView_CellContentClick;
            // 
            // lblFactoryText
            // 
            lblFactoryText.AutoSize = true;
            lblFactoryText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFactoryText.ForeColor = SystemColors.Control;
            lblFactoryText.Location = new Point(439, 59);
            lblFactoryText.Name = "lblFactoryText";
            lblFactoryText.Size = new Size(99, 28);
            lblFactoryText.TabIndex = 1;
            lblFactoryText.Text = "Orders of ";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // CustomerFactoryName
            // 
            CustomerFactoryName.HeaderText = "Customer Factory Name";
            CustomerFactoryName.MinimumWidth = 6;
            CustomerFactoryName.Name = "CustomerFactoryName";
            // 
            // ManufaturerFactoryName
            // 
            ManufaturerFactoryName.HeaderText = "Manufaturer Factory Name";
            ManufaturerFactoryName.MinimumWidth = 6;
            ManufaturerFactoryName.Name = "ManufaturerFactoryName";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1248, 699);
            Controls.Add(lblFactoryText);
            Controls.Add(orderDataGridView);
            ForeColor = SystemColors.Control;
            Name = "OrderScreen";
            Text = "OrderScreen";
            Load += OrderScreen_Load;
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView orderDataGridView;
        private Label lblFactoryText;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CustomerFactoryName;
        private DataGridViewTextBoxColumn ManufaturerFactoryName;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
    }
}
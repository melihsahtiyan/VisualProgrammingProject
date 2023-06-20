namespace WindowsApplication.Pages
{
    partial class ProductListScreen
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
            productDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            previousPageBtn = new Button();
            addStockPanel = new Panel();
            volumeLabel = new Label();
            volumeTextBox = new TextBox();
            weightLabel = new Label();
            weightTextBox = new TextBox();
            productNameTextBo = new TextBox();
            descriptionTextBox = new TextBox();
            addBtn = new Button();
            priceLabel = new Label();
            descriptionLabel = new Label();
            priceTextBox = new TextBox();
            productNameLabel = new Label();
            label1 = new Label();
            addProductLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            addStockPanel.SuspendLayout();
            SuspendLayout();
            // 
            // productDataGridView
            // 
            productDataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            productDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, Description, Price, Weight, Volume });
            productDataGridView.Location = new Point(117, 209);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 51;
            productDataGridView.RowTemplate.Height = 29;
            productDataGridView.Size = new Size(1201, 727);
            productDataGridView.TabIndex = 0;
            productDataGridView.CellContentClick += ProductDataGridViewCellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Weight
            // 
            Weight.HeaderText = "Weight";
            Weight.MinimumWidth = 6;
            Weight.Name = "Weight";
            // 
            // Volume
            // 
            Volume.HeaderText = "Volume";
            Volume.MinimumWidth = 6;
            Volume.Name = "Volume";
            // 
            // previousPageBtn
            // 
            previousPageBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            previousPageBtn.Location = new Point(43, 31);
            previousPageBtn.Name = "previousPageBtn";
            previousPageBtn.Size = new Size(41, 94);
            previousPageBtn.TabIndex = 1;
            previousPageBtn.Text = "<";
            previousPageBtn.UseVisualStyleBackColor = true;
            previousPageBtn.Click += previousPageBtn_Click;
            // 
            // addStockPanel
            // 
            addStockPanel.BackColor = Color.FromArgb(64, 64, 64);
            addStockPanel.Controls.Add(addProductLabel);
            addStockPanel.Controls.Add(volumeLabel);
            addStockPanel.Controls.Add(volumeTextBox);
            addStockPanel.Controls.Add(weightLabel);
            addStockPanel.Controls.Add(weightTextBox);
            addStockPanel.Controls.Add(productNameTextBo);
            addStockPanel.Controls.Add(descriptionTextBox);
            addStockPanel.Controls.Add(addBtn);
            addStockPanel.Controls.Add(priceLabel);
            addStockPanel.Controls.Add(descriptionLabel);
            addStockPanel.Controls.Add(priceTextBox);
            addStockPanel.Controls.Add(productNameLabel);
            addStockPanel.Location = new Point(1380, 209);
            addStockPanel.Name = "addStockPanel";
            addStockPanel.Size = new Size(467, 727);
            addStockPanel.TabIndex = 13;
            // 
            // volumeLabel
            // 
            volumeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            volumeLabel.AutoSize = true;
            volumeLabel.ForeColor = SystemColors.Control;
            volumeLabel.Location = new Point(35, 419);
            volumeLabel.Name = "volumeLabel";
            volumeLabel.Size = new Size(87, 28);
            volumeLabel.TabIndex = 17;
            volumeLabel.Text = "Volume: ";
            // 
            // volumeTextBox
            // 
            volumeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            volumeTextBox.Location = new Point(189, 419);
            volumeTextBox.Name = "volumeTextBox";
            volumeTextBox.Size = new Size(228, 34);
            volumeTextBox.TabIndex = 5;
            volumeTextBox.TextChanged += volumeTextBox_TextChanged;
            // 
            // weightLabel
            // 
            weightLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            weightLabel.AutoSize = true;
            weightLabel.ForeColor = SystemColors.Control;
            weightLabel.Location = new Point(35, 364);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(84, 28);
            weightLabel.TabIndex = 15;
            weightLabel.Text = "Weight: ";
            // 
            // weightTextBox
            // 
            weightTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            weightTextBox.Location = new Point(189, 364);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(228, 34);
            weightTextBox.TabIndex = 4;
            weightTextBox.TextChanged += weightTextBox_TextChanged;
            // 
            // productNameTextBo
            // 
            productNameTextBo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            productNameTextBo.Location = new Point(189, 189);
            productNameTextBo.Name = "productNameTextBo";
            productNameTextBo.Size = new Size(228, 34);
            productNameTextBo.TabIndex = 0;
            productNameTextBo.TextChanged += productNameTextBo_TextChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(189, 248);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(228, 34);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addBtn.Location = new Point(158, 528);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(147, 50);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceLabel.AutoSize = true;
            priceLabel.ForeColor = SystemColors.Control;
            priceLabel.Location = new Point(35, 307);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(63, 28);
            priceLabel.TabIndex = 11;
            priceLabel.Text = "Price: ";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descriptionLabel.AutoSize = true;
            descriptionLabel.ForeColor = SystemColors.Control;
            descriptionLabel.Location = new Point(35, 248);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(121, 28);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description: ";
            // 
            // priceTextBox
            // 
            priceTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceTextBox.Location = new Point(189, 307);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(228, 34);
            priceTextBox.TabIndex = 3;
            priceTextBox.TextChanged += priceTextBox_TextChanged;
            // 
            // productNameLabel
            // 
            productNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            productNameLabel.AutoSize = true;
            productNameLabel.ForeColor = SystemColors.Control;
            productNameLabel.Location = new Point(35, 189);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(138, 28);
            productNameLabel.TabIndex = 9;
            productNameLabel.Text = "Product name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(688, 44);
            label1.Name = "label1";
            label1.Size = new Size(486, 60);
            label1.TabIndex = 18;
            label1.Text = "PRODUCT PORTFOLIO";
            // 
            // addProductLabel
            // 
            addProductLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addProductLabel.AutoSize = true;
            addProductLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            addProductLabel.ForeColor = SystemColors.Control;
            addProductLabel.Location = new Point(52, 57);
            addProductLabel.Name = "addProductLabel";
            addProductLabel.Size = new Size(365, 37);
            addProductLabel.TabIndex = 18;
            addProductLabel.Text = "Add Product to the Protfolio";
            // 
            // ProductListScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1902, 1033);
            Controls.Add(label1);
            Controls.Add(addStockPanel);
            Controls.Add(previousPageBtn);
            Controls.Add(productDataGridView);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "ProductListScreen";
            Text = "ProductListScreen";
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            addStockPanel.ResumeLayout(false);
            addStockPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productDataGridView;
        private Button previousPageBtn;
        private Panel addStockPanel;
        private Label volumeLabel;
        private TextBox volumeTextBox;
        private Label weightLabel;
        private TextBox weightTextBox;
        private TextBox productNameTextBo;
        private TextBox descriptionTextBox;
        private Button addBtn;
        private Label priceLabel;
        private Label descriptionLabel;
        private TextBox priceTextBox;
        private Label productNameLabel;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn Volume;
        private Label addProductLabel;
    }
}
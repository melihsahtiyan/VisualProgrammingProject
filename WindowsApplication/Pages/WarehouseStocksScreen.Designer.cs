namespace WindowsApplication.Pages
{
    partial class WarehouseStocksScreen
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
            warehouseProductsDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            WarehouseName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductDescription = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            previousPageBtn = new Button();
            label1 = new Label();
            warehouseComboBox = new ComboBox();
            productsComboBox = new ComboBox();
            addBtn = new Button();
            warehouseLbl = new Label();
            productLabel = new Label();
            quantityLabel = new Label();
            addStockPanel = new Panel();
            label2 = new Label();
            quantityTextBox = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)warehouseProductsDataGridView).BeginInit();
            addStockPanel.SuspendLayout();
            SuspendLayout();
            // 
            // warehouseProductsDataGridView
            // 
            warehouseProductsDataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            warehouseProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            warehouseProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            warehouseProductsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, WarehouseName, Address, Phone, ProductName, ProductDescription, Price, Quantity });
            warehouseProductsDataGridView.Location = new Point(75, 178);
            warehouseProductsDataGridView.Name = "warehouseProductsDataGridView";
            warehouseProductsDataGridView.RowHeadersWidth = 51;
            warehouseProductsDataGridView.RowTemplate.Height = 29;
            warehouseProductsDataGridView.Size = new Size(1221, 777);
            warehouseProductsDataGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // WarehouseName
            // 
            WarehouseName.HeaderText = "Warehouse Name";
            WarehouseName.MinimumWidth = 6;
            WarehouseName.Name = "WarehouseName";
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Product Name";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            // 
            // ProductDescription
            // 
            ProductDescription.HeaderText = "Product Description";
            ProductDescription.MinimumWidth = 6;
            ProductDescription.Name = "ProductDescription";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // previousPageBtn
            // 
            previousPageBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            previousPageBtn.Location = new Point(75, 28);
            previousPageBtn.Name = "previousPageBtn";
            previousPageBtn.Size = new Size(41, 94);
            previousPageBtn.TabIndex = 2;
            previousPageBtn.Text = "<";
            previousPageBtn.UseVisualStyleBackColor = true;
            previousPageBtn.Click += previousPageBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(701, 28);
            label1.Name = "label1";
            label1.Size = new Size(127, 50);
            label1.TabIndex = 3;
            label1.Text = "Stocks";
            label1.Click += label1_Click;
            // 
            // warehouseComboBox
            // 
            warehouseComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            warehouseComboBox.FormattingEnabled = true;
            warehouseComboBox.Location = new Point(158, 292);
            warehouseComboBox.Name = "warehouseComboBox";
            warehouseComboBox.Size = new Size(284, 36);
            warehouseComboBox.TabIndex = 4;
            warehouseComboBox.SelectedIndexChanged += warehouseComboBox_SelectedIndexChanged;
            // 
            // productsComboBox
            // 
            productsComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            productsComboBox.Enabled = false;
            productsComboBox.FormattingEnabled = true;
            productsComboBox.Location = new Point(158, 354);
            productsComboBox.Name = "productsComboBox";
            productsComboBox.Size = new Size(284, 36);
            productsComboBox.TabIndex = 6;
            productsComboBox.SelectedIndexChanged += productsComboBox_SelectedIndexChanged;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(175, 508);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(118, 36);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // warehouseLbl
            // 
            warehouseLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            warehouseLbl.AutoSize = true;
            warehouseLbl.ForeColor = SystemColors.Control;
            warehouseLbl.Location = new Point(41, 292);
            warehouseLbl.Name = "warehouseLbl";
            warehouseLbl.Size = new Size(118, 28);
            warehouseLbl.TabIndex = 9;
            warehouseLbl.Text = "Warehouse: ";
            // 
            // productLabel
            // 
            productLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            productLabel.AutoSize = true;
            productLabel.ForeColor = SystemColors.Control;
            productLabel.Location = new Point(41, 351);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(90, 28);
            productLabel.TabIndex = 10;
            productLabel.Text = "Product: ";
            // 
            // quantityLabel
            // 
            quantityLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            quantityLabel.AutoSize = true;
            quantityLabel.ForeColor = SystemColors.Control;
            quantityLabel.Location = new Point(41, 420);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(97, 28);
            quantityLabel.TabIndex = 11;
            quantityLabel.Text = "Quantity: ";
            // 
            // addStockPanel
            // 
            addStockPanel.BackColor = Color.FromArgb(64, 64, 64);
            addStockPanel.Controls.Add(quantityTextBox);
            addStockPanel.Controls.Add(label2);
            addStockPanel.Controls.Add(warehouseComboBox);
            addStockPanel.Controls.Add(addBtn);
            addStockPanel.Controls.Add(quantityLabel);
            addStockPanel.Controls.Add(productsComboBox);
            addStockPanel.Controls.Add(productLabel);
            addStockPanel.Controls.Add(warehouseLbl);
            addStockPanel.Location = new Point(1360, 178);
            addStockPanel.Name = "addStockPanel";
            addStockPanel.Size = new Size(486, 777);
            addStockPanel.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(80, 110);
            label2.Name = "label2";
            label2.Size = new Size(337, 38);
            label2.TabIndex = 12;
            label2.Text = "Add stock to warehouses";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(158, 420);
            quantityTextBox.Mask = "00000";
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.PromptChar = ' ';
            quantityTextBox.Size = new Size(284, 34);
            quantityTextBox.TabIndex = 13;
            quantityTextBox.ValidatingType = typeof(int);
            quantityTextBox.MaskInputRejected += quantityTextBox_MaskInputRejected;
            // 
            // WarehouseStocksScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1902, 1033);
            Controls.Add(addStockPanel);
            Controls.Add(label1);
            Controls.Add(previousPageBtn);
            Controls.Add(warehouseProductsDataGridView);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "WarehouseStocksScreen";
            Text = "WarehouseStocksScreen";
            Load += WarehouseStocksScreen_Load;
            ((System.ComponentModel.ISupportInitialize)warehouseProductsDataGridView).EndInit();
            addStockPanel.ResumeLayout(false);
            addStockPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView warehouseProductsDataGridView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn WarehouseName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductDescription;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private Button previousPageBtn;
        private Label label1;
        private ComboBox warehouseComboBox;
        private ComboBox productsComboBox;
        private Button addBtn;
        private Label warehouseLbl;
        private Label productLabel;
        private Label quantityLabel;
        private Panel addStockPanel;
        private Label label2;
        private MaskedTextBox quantityTextBox;
    }
}
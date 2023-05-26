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
            ((System.ComponentModel.ISupportInitialize)warehouseProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // warehouseProductsDataGridView
            // 
            warehouseProductsDataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            warehouseProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            warehouseProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            warehouseProductsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, WarehouseName, Address, Phone, ProductName, ProductDescription, Price, Quantity });
            warehouseProductsDataGridView.Location = new Point(75, 220);
            warehouseProductsDataGridView.Name = "warehouseProductsDataGridView";
            warehouseProductsDataGridView.RowHeadersWidth = 51;
            warehouseProductsDataGridView.RowTemplate.Height = 29;
            warehouseProductsDataGridView.Size = new Size(1165, 462);
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
            // WarehouseStocksScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1320, 694);
            Controls.Add(warehouseProductsDataGridView);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "WarehouseStocksScreen";
            Text = "WarehouseStocksScreen";
            Load += WarehouseStocksScreen_Load;
            ((System.ComponentModel.ISupportInitialize)warehouseProductsDataGridView).EndInit();
            ResumeLayout(false);
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
    }
}
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
            factoryComboBox = new ComboBox();
            productsComboBox = new ComboBox();
            quantityTextBox = new TextBox();
            addBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)warehouseProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // warehouseProductsDataGridView
            // 
            warehouseProductsDataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            warehouseProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            warehouseProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            warehouseProductsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, WarehouseName, Address, Phone, ProductName, ProductDescription, Price, Quantity });
            warehouseProductsDataGridView.Location = new Point(75, 312);
            warehouseProductsDataGridView.Name = "warehouseProductsDataGridView";
            warehouseProductsDataGridView.RowHeadersWidth = 51;
            warehouseProductsDataGridView.RowTemplate.Height = 29;
            warehouseProductsDataGridView.Size = new Size(1391, 462);
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
            // 
            // warehouseComboBox
            // 
            warehouseComboBox.Enabled = false;
            warehouseComboBox.FormattingEnabled = true;
            warehouseComboBox.Location = new Point(486, 176);
            warehouseComboBox.Name = "warehouseComboBox";
            warehouseComboBox.Size = new Size(174, 36);
            warehouseComboBox.TabIndex = 4;
            warehouseComboBox.SelectedIndexChanged += warehouseComboBox_SelectedIndexChanged;
            // 
            // factoryComboBox
            // 
            factoryComboBox.FormattingEnabled = true;
            factoryComboBox.Location = new Point(289, 176);
            factoryComboBox.Name = "factoryComboBox";
            factoryComboBox.Size = new Size(174, 36);
            factoryComboBox.TabIndex = 5;
            factoryComboBox.SelectedIndexChanged += factoryComboBox_SelectedIndexChanged;
            // 
            // productsComboBox
            // 
            productsComboBox.Enabled = false;
            productsComboBox.FormattingEnabled = true;
            productsComboBox.Location = new Point(685, 176);
            productsComboBox.Name = "productsComboBox";
            productsComboBox.Size = new Size(174, 36);
            productsComboBox.TabIndex = 6;
            productsComboBox.SelectedIndexChanged += productsComboBox_SelectedIndexChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Enabled = false;
            quantityTextBox.Location = new Point(886, 176);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(174, 34);
            quantityTextBox.TabIndex = 7;
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(1125, 176);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(118, 36);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // WarehouseStocksScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1546, 878);
            Controls.Add(addBtn);
            Controls.Add(quantityTextBox);
            Controls.Add(productsComboBox);
            Controls.Add(factoryComboBox);
            Controls.Add(warehouseComboBox);
            Controls.Add(label1);
            Controls.Add(previousPageBtn);
            Controls.Add(warehouseProductsDataGridView);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "WarehouseStocksScreen";
            Text = "WarehouseStocksScreen";
            Load += WarehouseStocksScreen_Load;
            ((System.ComponentModel.ISupportInitialize)warehouseProductsDataGridView).EndInit();
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
        private ComboBox factoryComboBox;
        private ComboBox productsComboBox;
        private TextBox quantityTextBox;
        private Button addBtn;
    }
}
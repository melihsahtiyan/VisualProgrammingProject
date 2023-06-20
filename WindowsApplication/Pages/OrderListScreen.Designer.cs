namespace WindowsApplication.Pages
{
    partial class OrderListScreen
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            orderDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            CustomerFactoryName = new DataGridViewTextBoxColumn();
            ManufaturerFactoryName = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            DateOfOrder = new DataGridViewTextBoxColumn();
            EstimatedDepartureDate = new DataGridViewTextBoxColumn();
            DepartureDate = new DataGridViewTextBoxColumn();
            EstimatedDeliveryDate = new DataGridViewTextBoxColumn();
            FromWhichCity = new DataGridViewTextBoxColumn();
            ToWhichCity = new DataGridViewTextBoxColumn();
            ApprovedByCustomer = new DataGridViewTextBoxColumn();
            ApprovedByManufacturer = new DataGridViewTextBoxColumn();
            lblFactoryText = new Label();
            previousPageBtn = new Button();
            addStockPanel = new Panel();
            customerWarehouseComboBox = new ComboBox();
            label4 = new Label();
            quantityTextBox = new MaskedTextBox();
            label2 = new Label();
            productComboBox = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            factoryComboBox = new ComboBox();
            addBtn = new Button();
            warehouseComboBox = new ComboBox();
            warehouseLabel = new Label();
            factoryLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).BeginInit();
            addStockPanel.SuspendLayout();
            SuspendLayout();
            // 
            // orderDataGridView
            // 
            orderDataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            orderDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            orderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            orderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, CustomerFactoryName, ManufaturerFactoryName, ProductName, Quantity, DateOfOrder, EstimatedDepartureDate, DepartureDate, EstimatedDeliveryDate, FromWhichCity, ToWhichCity, ApprovedByCustomer, ApprovedByManufacturer });
            orderDataGridView.Location = new Point(96, 198);
            orderDataGridView.Margin = new Padding(6);
            orderDataGridView.Name = "orderDataGridView";
            orderDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            orderDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            orderDataGridView.RowTemplate.Height = 29;
            orderDataGridView.Size = new Size(1296, 738);
            orderDataGridView.TabIndex = 0;
            orderDataGridView.CellContentClick += orderDataGridView_CellContentClick;
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
            // DateOfOrder
            // 
            DateOfOrder.HeaderText = "Date of Order";
            DateOfOrder.MinimumWidth = 6;
            DateOfOrder.Name = "DateOfOrder";
            // 
            // EstimatedDepartureDate
            // 
            EstimatedDepartureDate.HeaderText = "Estimated Departure Date";
            EstimatedDepartureDate.MinimumWidth = 6;
            EstimatedDepartureDate.Name = "EstimatedDepartureDate";
            // 
            // DepartureDate
            // 
            DepartureDate.HeaderText = "DepartureDate";
            DepartureDate.MinimumWidth = 6;
            DepartureDate.Name = "DepartureDate";
            // 
            // EstimatedDeliveryDate
            // 
            EstimatedDeliveryDate.HeaderText = "Estimated Delivery Date";
            EstimatedDeliveryDate.MinimumWidth = 6;
            EstimatedDeliveryDate.Name = "EstimatedDeliveryDate";
            // 
            // FromWhichCity
            // 
            FromWhichCity.HeaderText = "From Which City";
            FromWhichCity.MinimumWidth = 6;
            FromWhichCity.Name = "FromWhichCity";
            // 
            // ToWhichCity
            // 
            ToWhichCity.HeaderText = "ToWhichCity";
            ToWhichCity.MinimumWidth = 6;
            ToWhichCity.Name = "ToWhichCity";
            // 
            // ApprovedByCustomer
            // 
            ApprovedByCustomer.HeaderText = "Approved By Customer";
            ApprovedByCustomer.MinimumWidth = 6;
            ApprovedByCustomer.Name = "ApprovedByCustomer";
            // 
            // ApprovedByManufacturer
            // 
            ApprovedByManufacturer.HeaderText = "Approved By Manufacturer";
            ApprovedByManufacturer.MinimumWidth = 6;
            ApprovedByManufacturer.Name = "ApprovedByManufacturer";
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
            lblFactoryText.Click += lblFactoryText_Click;
            // 
            // previousPageBtn
            // 
            previousPageBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            previousPageBtn.ForeColor = SystemColors.ActiveCaptionText;
            previousPageBtn.Location = new Point(60, 59);
            previousPageBtn.Name = "previousPageBtn";
            previousPageBtn.Size = new Size(41, 94);
            previousPageBtn.TabIndex = 2;
            previousPageBtn.Text = "<";
            previousPageBtn.UseVisualStyleBackColor = true;
            previousPageBtn.Click += previousPageBtn_Click;
            // 
            // addStockPanel
            // 
            addStockPanel.BackColor = Color.FromArgb(64, 64, 64);
            addStockPanel.Controls.Add(customerWarehouseComboBox);
            addStockPanel.Controls.Add(label4);
            addStockPanel.Controls.Add(quantityTextBox);
            addStockPanel.Controls.Add(label2);
            addStockPanel.Controls.Add(productComboBox);
            addStockPanel.Controls.Add(label3);
            addStockPanel.Controls.Add(label1);
            addStockPanel.Controls.Add(factoryComboBox);
            addStockPanel.Controls.Add(addBtn);
            addStockPanel.Controls.Add(warehouseComboBox);
            addStockPanel.Controls.Add(warehouseLabel);
            addStockPanel.Controls.Add(factoryLbl);
            addStockPanel.Location = new Point(1440, 198);
            addStockPanel.Name = "addStockPanel";
            addStockPanel.Size = new Size(427, 738);
            addStockPanel.TabIndex = 14;
            // 
            // customerWarehouseComboBox
            // 
            customerWarehouseComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            customerWarehouseComboBox.FormattingEnabled = true;
            customerWarehouseComboBox.Location = new Point(90, 458);
            customerWarehouseComboBox.Name = "customerWarehouseComboBox";
            customerWarehouseComboBox.Size = new Size(259, 28);
            customerWarehouseComboBox.TabIndex = 20;
            customerWarehouseComboBox.SelectedIndexChanged += customerWarehouseComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(54, 405);
            label4.Name = "label4";
            label4.Size = new Size(338, 28);
            label4.TabIndex = 21;
            label4.Text = "Which warehouse you want to deliver";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Enabled = false;
            quantityTextBox.Location = new Point(142, 316);
            quantityTextBox.Margin = new Padding(8);
            quantityTextBox.Mask = "00000000";
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(60, 27);
            quantityTextBox.TabIndex = 19;
            quantityTextBox.ValidatingType = typeof(int);
            quantityTextBox.MaskInputRejected += quantityTextBox_MaskInputRejected;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(25, 312);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 18;
            label2.Text = "Quantity: ";
            // 
            // productComboBox
            // 
            productComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            productComboBox.Enabled = false;
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(142, 255);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(259, 28);
            productComboBox.TabIndex = 14;
            productComboBox.SelectedIndexChanged += productComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(25, 252);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 17;
            label3.Text = "Product: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(142, 35);
            label1.Name = "label1";
            label1.Size = new Size(207, 38);
            label1.TabIndex = 12;
            label1.Text = "Add new order";
            // 
            // factoryComboBox
            // 
            factoryComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            factoryComboBox.FormattingEnabled = true;
            factoryComboBox.Location = new Point(142, 139);
            factoryComboBox.Name = "factoryComboBox";
            factoryComboBox.Size = new Size(259, 28);
            factoryComboBox.TabIndex = 4;
            factoryComboBox.SelectedIndexChanged += factoryComboBox_SelectedIndexChanged;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = SystemColors.ControlText;
            addBtn.Location = new Point(142, 633);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(155, 48);
            addBtn.TabIndex = 8;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // warehouseComboBox
            // 
            warehouseComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            warehouseComboBox.Enabled = false;
            warehouseComboBox.FormattingEnabled = true;
            warehouseComboBox.Location = new Point(142, 201);
            warehouseComboBox.Name = "warehouseComboBox";
            warehouseComboBox.Size = new Size(259, 28);
            warehouseComboBox.TabIndex = 6;
            warehouseComboBox.SelectedIndexChanged += warehousesComboBox_SelectedIndexChanged;
            // 
            // warehouseLabel
            // 
            warehouseLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            warehouseLabel.AutoSize = true;
            warehouseLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            warehouseLabel.ForeColor = SystemColors.Control;
            warehouseLabel.Location = new Point(25, 198);
            warehouseLabel.Name = "warehouseLabel";
            warehouseLabel.Size = new Size(113, 28);
            warehouseLabel.TabIndex = 10;
            warehouseLabel.Text = "Warehouse:";
            // 
            // factoryLbl
            // 
            factoryLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            factoryLbl.AutoSize = true;
            factoryLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            factoryLbl.ForeColor = SystemColors.Control;
            factoryLbl.Location = new Point(25, 139);
            factoryLbl.Name = "factoryLbl";
            factoryLbl.Size = new Size(85, 28);
            factoryLbl.TabIndex = 9;
            factoryLbl.Text = "Factory: ";
            // 
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1902, 1033);
            Controls.Add(addStockPanel);
            Controls.Add(previousPageBtn);
            Controls.Add(lblFactoryText);
            Controls.Add(orderDataGridView);
            ForeColor = SystemColors.Control;
            Name = "OrderScreen";
            Text = "OrderScreen";
            Load += OrderScreen_Load;
            ((System.ComponentModel.ISupportInitialize)orderDataGridView).EndInit();
            addStockPanel.ResumeLayout(false);
            addStockPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView orderDataGridView;
        private Label lblFactoryText;
        private Button previousPageBtn;
        private Panel addStockPanel;
        private ComboBox factoryComboBox;
        private Button addBtn;
        private ComboBox warehouseComboBox;
        private Label warehouseLabel;
        private Label factoryLbl;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn CustomerFactoryName;
        private DataGridViewTextBoxColumn ManufaturerFactoryName;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn DateOfOrder;
        private DataGridViewTextBoxColumn EstimatedDepartureDate;
        private DataGridViewTextBoxColumn DepartureDate;
        private DataGridViewTextBoxColumn EstimatedDeliveryDate;
        private DataGridViewTextBoxColumn FromWhichCity;
        private DataGridViewTextBoxColumn ToWhichCity;
        private DataGridViewTextBoxColumn ApprovedByCustomer;
        private DataGridViewTextBoxColumn ApprovedByManufacturer;
        private Label label2;
        private ComboBox productComboBox;
        private Label label3;
        private MaskedTextBox quantityTextBox;
        private ComboBox customerWarehouseComboBox;
        private Label label4;
    }
}
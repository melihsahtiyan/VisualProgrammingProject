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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            previousPageBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, Description, Price, Weight });
            dataGridView1.Location = new Point(144, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(808, 416);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // ProductListScreen
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1126, 717);
            Controls.Add(previousPageBtn);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "ProductListScreen";
            Text = "ProductListScreen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Weight;
        private Button previousPageBtn;
    }
}
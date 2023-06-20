using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Domain.Dtos;
using Domain.Entities;
using Int32 = System.Int32;

namespace WindowsApplication.Pages
{
    public partial class WarehouseStocksScreen : Form
    {
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IWarehouseService _warehouseService;
        private readonly IOrdersService _orderService;
        private readonly IWarehouseProductsService _warehouseProductsService;

        public WarehouseProducts warehouseProducts = new WarehouseProducts();
        private string factoryName = UserSession.Username;
        string warehouseName { get; set; }
        string productName { get; set; }

        public WarehouseStocksScreen(IWarehouseProductsService warehouseProductsService, IProductService productService,
            IFactoryService factoryService, IOrdersService orderService, IWarehouseService warehouseService)
        {
            InitializeComponent();
            _warehouseService = warehouseService;
            _warehouseProductsService = warehouseProductsService;
            _productService = productService;
            _factoryService = factoryService;
            _orderService = orderService;

            FillTheTableWithStocks();
        }

        private void WarehouseStocksScreen_Load(object sender, EventArgs e)
        {

        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {

            var screen = new MainMenuScreen(_productService, _factoryService, _orderService,
                _warehouseProductsService, _warehouseService);
            this.Hide();
            screen.Show();
        }

        private void warehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            warehouseName = warehouseComboBox.SelectedItem.ToString();
            warehouseProducts.WarehouseId = _warehouseService.GetAllByWarehouseName(warehouseName).Data.Id;
            var products = _productService.GetAll().Data;
            productsComboBox.Items.Clear();
            foreach (var product in products)
            {
                productsComboBox.Items.Add(product.Name);
            }
            productsComboBox.Enabled = true;
        }

        private void productsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productName = productsComboBox.SelectedItem.ToString();
            warehouseProducts.ProductId = _productService.GetByName(productName).Data.Id;
            quantityTextBox.Enabled = true;
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            var keyPressEvent = e as KeyPressEventArgs;
            if (keyPressEvent != null)
            {
                if (!char.IsControl(keyPressEvent.KeyChar) && !char.IsDigit(keyPressEvent.KeyChar))
                {
                    var quantity = Int32.Parse(quantityTextBox.Text);
                    if (quantity > 0)
                    {
                        addBtn.Enabled = true;
                        warehouseProducts.Quantity = quantity;
                    }
                }
            }
        }

        private void quantityTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            warehouseProducts.Quantity = Int32.Parse(quantityTextBox.Text);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var result = new WarehouseProductsForCreateDto()
            {
                WarehouseId = warehouseProducts.WarehouseId,
                ProductId = warehouseProducts.ProductId,
                Quantity = warehouseProducts.Quantity
            };

            _warehouseProductsService.Add(result);

            FillTheTableWithStocks();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void FillTheTableWithStocks()
        {
            warehouseProductsDataGridView.Rows.Clear();
            var warehouseProducts = _warehouseProductsService.GetWarehouseProductsDetails().Data;
            foreach (var warehouseProduct in warehouseProducts)
            {
                warehouseProductsDataGridView.Rows.Add(warehouseProduct.Id, warehouseProduct.WarehouseName,
                    warehouseProduct.Address, warehouseProduct.Phone, warehouseProduct.ProductName,
                    warehouseProduct.ProductDescription,
                    warehouseProduct.Price, warehouseProduct.Quantity);
            }

            warehouseComboBox.Items.Clear();

            var warehouses = _warehouseService.GetAllByFactoryName(factoryName);
            foreach (var warehouse in warehouses.Data)
            {
                warehouseComboBox.Items.Add(warehouse.Name);
            }
        }
    }
}

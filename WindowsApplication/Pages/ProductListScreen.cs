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

namespace WindowsApplication.Pages
{
    public partial class ProductListScreen : Form
    {
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IOrdersService _orderService;
        private readonly IWarehouseProductsService _warehouseProductsService;
        private readonly IWarehouseService _warehouseService;

        public ProductForCreateDto Product = new ProductForCreateDto();

        public ProductListScreen(IProductService productService, IFactoryService factoryService,
            IOrdersService orderService, IWarehouseProductsService warehouseProductsService,
            IWarehouseService warehouseService)
        {
            _productService = productService;
            InitializeComponent();

            FillTable();

            _factoryService = factoryService;
            _orderService = orderService;
            _warehouseProductsService = warehouseProductsService;
            _warehouseService = warehouseService;
        }

        private void ProductDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            var screen = new MainMenuScreen(_productService, _factoryService, _orderService,
                _warehouseProductsService, _warehouseService);
            this.Hide();
            screen.Show();
        }

        private void productNameTextBo_TextChanged(object sender, EventArgs e)
        {
            Product.Name = productNameTextBo.Text;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            Product.Description = descriptionTextBox.Text;
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (priceTextBox.Text != "")
                try
                {
                    Product.Price = Convert.ToDecimal(priceTextBox.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (weightTextBox.Text != "")
                try
                {
                    Product.Weight = Convert.ToDecimal(weightTextBox.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
        }

        private void volumeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (weightTextBox.Text != "")
                try
                {
                    Product.Volume = Convert.ToDecimal(volumeTextBox.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(Product);
                FillTable();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void FillTable()
        {
            productDataGridView.Rows.Clear();
            var products = _productService.GetAll().Data;
            foreach (var product in products)
            {
                productDataGridView.Rows.Add(product.Id, product.Name, product.Description, product.Price, product.Weight, product.Volume);
            }
        }
    }
}

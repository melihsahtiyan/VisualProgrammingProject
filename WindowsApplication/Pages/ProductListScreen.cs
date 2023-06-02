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

namespace WindowsApplication.Pages
{
    public partial class ProductListScreen : Form
    {
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IOrdersService _orderService;
        private readonly IWarehouseProductsService _warehouseProductsService;
        private readonly IWarehouseService _warehouseService;

        public ProductListScreen(IProductService productService, IFactoryService factoryService,
            IOrdersService orderService, IWarehouseProductsService warehouseProductsService,
            IWarehouseService warehouseService)
        {
            _productService = productService;
            InitializeComponent();

            var products = _productService.GetAll().Data;
            foreach (var product in products)
            {
                dataGridView1.Rows.Add(product.Id, product.Name, product.Description, product.Price, product.Weight);
            }
            _factoryService = factoryService;
            _orderService = orderService;
            _warehouseProductsService = warehouseProductsService;
            _warehouseService = warehouseService;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            var screen = new MainMenuScreen(_productService, _factoryService, _orderService,
                _warehouseProductsService, _warehouseService);
            this.Hide();
            screen.Show();
        }
    }
}

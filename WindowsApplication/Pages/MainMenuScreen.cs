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
using Business.Concrete;
using Persistence.Repositories;

namespace WindowsApplication.Pages
{
    public partial class MainMenuScreen : Form
    {
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IOrdersService _ordersService;
        private readonly IWarehouseProductsService _warehouseProductsService;
        private readonly IWarehouseService _warehouseService;

        public MainMenuScreen(IProductService productService, IFactoryService factoryService,
            IOrdersService ordersService, IWarehouseProductsService warehouseProductsService,
            IWarehouseService warehouseService)
        {
            InitializeComponent();
            lblWelcomeText.Text = "Welcome " + UserSession.Username;
            _productService = productService;
            _factoryService = factoryService;
            _ordersService = ordersService;
            _warehouseProductsService = warehouseProductsService;
            productPortfolioTextLabel.Text += _productService.GetAll().Data.Count;
            _warehouseService = warehouseService;
        }

        private void MainMenuScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productListButton_Click(object sender, EventArgs e)
        {
            var screen = new ProductListScreen(_productService, _factoryService, _ordersService,
                _warehouseProductsService, _warehouseService);
            this.Hide();
            screen.Show();
        }

        private void productPortfolioTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderPage_Click(object sender, EventArgs e)
        {
            var screen = new OrderScreen(_ordersService, _productService, _factoryService, _warehouseProductsService,
                _warehouseService);
            this.Hide();
            screen.Show();
        }

        private void stockListButton_Click(object sender, EventArgs e)
        {
            var screen = new WarehouseStocksScreen(_warehouseProductsService, _productService, _factoryService,
                _ordersService, _warehouseService);
            this.Hide();
            screen.Show();
        }
    }
}

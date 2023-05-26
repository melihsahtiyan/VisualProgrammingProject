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
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IOrdersService _ordersService;
        private readonly IWarehouseProductsService _warehouseProductsService;

        public MainMenuScreen(IUserService userService, IProductService productService, IFactoryService factoryService,
            IOrdersService ordersService,IWarehouseProductsService warehouseProductsService)
        {
            InitializeComponent();
            lblWelcomeText.Text = "Welcome " + UserSession.Username;
            _userService = userService;
            _productService = productService;
            _factoryService = factoryService;
            _ordersService = ordersService;
            _warehouseProductsService = warehouseProductsService;
            productPortfolioTextLabel.Text += _productService.GetAll().Data.Count;
        }

        private void MainMenuScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productListButton_Click(object sender, EventArgs e)
        {
            var screen = new ProductListScreen(_productService);
            this.Hide();
            screen.Show();
        }

        private void productPortfolioTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnOrderPage_Click(object sender, EventArgs e)
        {
            var screen = new OrderScreen(_ordersService, _productService, _factoryService);
            this.Hide();
            screen.Show();
        }

        private void stockListButton_Click(object sender, EventArgs e)
        {
            var screen = new WarehouseStocksScreen(_warehouseProductsService);
            this.Hide();
            screen.Show();
        }
    }
}

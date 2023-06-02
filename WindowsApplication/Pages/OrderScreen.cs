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
using Business.Services;
using Domain.Entities;

namespace WindowsApplication.Pages
{
    public partial class OrderScreen : Form
    {
        private readonly IOrdersService _orderService;
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IWarehouseProductsService _warehouseProductsService;
        private readonly IWarehouseService _warehouseService;
        public Factory Factory { get; set; }

        public OrderScreen(IOrdersService ordersService, IProductService productService,
            IFactoryService factoryService, IWarehouseProductsService warehouseProductsService,
            IWarehouseService warehouseService)
        {
            _orderService = ordersService;
            _productService = productService;
            _factoryService = factoryService;
            Factory = _factoryService.GetByEmail(UserSession.Email).Data;
            InitializeComponent();
            lblFactoryText.Text = Factory.IsCustomer == true
                ? "Customer Factory: " + Factory.Name
                : "Manufacturing Factory: " + Factory.Name;

            var orders = _orderService.GetOrderDetails().Data;
            foreach (var order in orders)
            {
                orderDataGridView.Rows.Add(order.Id, order.CustomerFactoryName, order.ManufacturerFactoryName,
                    order.ProductName, order.Quantity);
            }
            _warehouseProductsService = warehouseProductsService;
            _warehouseService = warehouseService;
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {

        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

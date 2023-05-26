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
        private readonly IOrdersService _ordersService;
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        public Factory Factory { get; set; }

        public OrderScreen(IOrdersService ordersService, IProductService productService,
            IFactoryService factoryService)
        {
            _ordersService = ordersService;
            _productService = productService;
            _factoryService = factoryService;
            Factory = _factoryService.GetByEmail(UserSession.Email).Data;
            InitializeComponent();
            lblFactoryText.Text = Factory.IsCustomer == true
                ? "Customer Factory: " + Factory.Name
                : "Manufacturing Factory: " + Factory.Name;

            var orders = _ordersService.GetOrderDetails().Data;
            foreach (var order in orders)
            {
                orderDataGridView.Rows.Add(order.Id, order.CustomerFactoryName, order.ManufacturerFactoryName,
                    order.ProductName, order.Quantity);
            }
        }

        private void OrderScreen_Load(object sender, EventArgs e)
        {

        }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

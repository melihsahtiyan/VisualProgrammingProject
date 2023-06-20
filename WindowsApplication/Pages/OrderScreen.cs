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
    public partial class OrderScreen : Form
    {
        private readonly IOrdersService _orderService;
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IWarehouseProductsService _warehouseProductsService;
        private readonly IWarehouseService _warehouseService;

        public OrderScreen(IFactoryService factoryService, IWarehouseProductsService warehouseProductsService,
            IWarehouseService warehouseService, IOrdersService orderService, IProductService productService)
        {
            _factoryService = factoryService;
            _warehouseProductsService = warehouseProductsService;
            _warehouseService = warehouseService;
            _orderService = orderService;
            _productService = productService;

            InitializeComponent();
        }

        private void orderListScreenButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var screen = new OrderListScreen(_orderService, _productService, _factoryService, _warehouseProductsService,
                _warehouseService);
            screen.Show();
        }
    }
}

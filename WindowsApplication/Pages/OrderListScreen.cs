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
using Domain.Dtos;
using Domain.Entities;

namespace WindowsApplication.Pages
{
    public partial class OrderListScreen : Form
    {
        private readonly IOrdersService _orderService;
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IWarehouseProductsService _warehouseProductsService;
        private readonly IWarehouseService _warehouseService;
        public Factory Factory = new Factory();
        public OrdersForCreateDto Order = new OrdersForCreateDto();

        public OrderListScreen(IOrdersService ordersService, IProductService productService,
            IFactoryService factoryService, IWarehouseProductsService warehouseProductsService,
            IWarehouseService warehouseService)
        {
            _orderService = ordersService;
            _productService = productService;
            _factoryService = factoryService;
            _warehouseProductsService = warehouseProductsService;
            _warehouseService = warehouseService;
            Factory = _factoryService.GetByEmail(UserSession.Email).Data;
            Order.CustomerFactoryId = Factory.Id;
            InitializeComponent();
            lblFactoryText.Text = Factory.IsCustomer == true
                ? "Customer Factory: " + Factory.Name
                : "Manufacturing Factory: " + Factory.Name;

            FillTable();

            FillFactories();

            FillCustomerWarehouses(Factory.Id);

        }

        private void OrderScreen_Load(object sender, EventArgs e)
        { }

        private void orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            var screen = new MainMenuScreen(_productService, _factoryService, _orderService,
                _warehouseProductsService, _warehouseService);
            this.Hide();
            screen.Show();
        }

        private void lblFactoryText_Click(object sender, EventArgs e)
        { }

        private void quantityTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                Order.Quantity = Convert.ToInt32(quantityTextBox.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }


        private void warehousesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.ManufacturerWarehouseId = _warehouseService.GetAllByWarehouseName(warehouseComboBox.SelectedItem.ToString()).Data.Id;
            productComboBox.Items.Clear();
            FillProducts(Order.ManufacturerWarehouseId);
            productComboBox.Enabled = true;
        }

        private void factoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.ManufacturingFactoryId = _factoryService.GetByName(factoryComboBox.SelectedItem.ToString()).Data.Id;
            warehouseComboBox.Items.Clear();
            FillWarehouses(factoryComboBox.SelectedItem.ToString());
            warehouseComboBox.Enabled = true;
        }
        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.ProductId = _productService.GetByName(productComboBox.SelectedItem.ToString()).Data.Id;
            quantityTextBox.Enabled = true;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _orderService.Add(Order);
                FillTable();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        private void customerWarehouseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.CustomerWarehouseId = _warehouseService.GetAllByWarehouseName(customerWarehouseComboBox.SelectedItem.ToString()).Data.Id;
        }
        private void FillTable()
        {
            orderDataGridView.Rows.Clear();
            var orders = _orderService.GetOrderDetails().Data;
            foreach (var order in orders)
            {
                orderDataGridView.Rows.Add(order.Id, order.CustomerFactoryName, order.ManufacturerFactoryName,
                    order.ProductName, order.Quantity, order.DateOfOrder, order.EstimatedDepartureDate,
                    order.DepartureDate, order.EstimatedDeliveryDate, order.DeliveryDate, order.FromWhere,
                    order.ToWhere, order.ApprovedByCustomer, order.ApprovedByManufacturer);
            }
        }

        private void FillFactories()
        {
            factoryComboBox.Items.Clear();
            var factories = _factoryService.GetAllManufacturer().Data;
            foreach (var factory in factories)
            {
                factoryComboBox.Items.Add(factory.Name);
            }
        }

        private void FillWarehouses(string factoryName)
        {
            var warehouses = _warehouseService.GetAllByFactoryName(factoryName).Data;
            foreach (var warehouse in warehouses)
            {
                warehouseComboBox.Items.Add(warehouse.Name);
            }
        }
        private void FillCustomerWarehouses(int factoryId)
        {
            var warehouses = _warehouseService.GetAllByFactoryId(factoryId).Data;
            foreach (var warehouse in warehouses)
            {
                customerWarehouseComboBox.Items.Add(warehouse.Name);
            }
        }

        private void FillProducts(int warehouseId)
        {
            var products = _productService.GetAllByWarehouseId(warehouseId).Data;
            foreach (var product in products)
            {
                productComboBox.Items.Add(product.Name);
            }
        }
    }
}

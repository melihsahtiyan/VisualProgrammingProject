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
using Core.Domain.Dtos;

namespace WindowsApplication.Pages
{
    public partial class RegisterScreen : Form
    {
        private UserForRegisterDto _userForRegisterDto = new UserForRegisterDto();
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IOrdersService _ordersService;
        private readonly IWarehouseProductsService _warehouseProductsService;
        private string ProductName;

        public RegisterScreen(IAuthService authService, IUserService userService,
            IProductService productService, IFactoryService factoryService, IOrdersService ordersService,
            IWarehouseProductsService warehouseProductsService)
        {
            _authService = authService;
            _userService = userService;
            _productService = productService;
            _factoryService = factoryService;
            _ordersService = ordersService;
            _warehouseProductsService = warehouseProductsService;
            InitializeComponent();
            _warehouseProductsService = warehouseProductsService;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var result = _authService.Register(_userForRegisterDto);
            if (!result.Success)
            {
                failedTxtLbl.Visible = true;
            }
            else
            {
                failedTxtLbl.Visible = false;
                this.Hide();
                LoginScreen screen = new LoginScreen(_authService, _userService,
                    _productService, _factoryService, _ordersService,_warehouseProductsService);
                screen.Show();
            }
        }


        private void RegisterScreen_Load(object sender, EventArgs e)
        {

        }


        private void checkBoxSupplier_CheckedChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.IsSupplier = checkBoxSupplier.Checked;
        }

        private void checkBoxCustomer_CheckedChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.IsCustomer = checkBoxCustomer.Checked;
        }

        private void emailTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            _userForRegisterDto.Email = emailTxtBox.Text;
        }

        private void passwordTxtBox_TextChanged_1(object sender, EventArgs e)
        {
            _userForRegisterDto.Password = passwordTxtBox.Text;
        }

        private void nameTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.Name = nameTxtBox.Text;
        }

        private void addressTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.Address = addressTxtBox.Text;
        }

        private void taxNumberTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.TaxNumber = taxNumberTxtBox.Text;
        }

        private void phoneTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.Phone = phoneTxtBox.Text;
        }
    }
}

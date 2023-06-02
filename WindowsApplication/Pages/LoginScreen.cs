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
    public partial class LoginScreen : Form
    {
        private UserForLoginDto _userForLoginDto = new UserForLoginDto();
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly IProductService _productService;
        private readonly IFactoryService _factoryService;
        private readonly IOrdersService _ordersService;
        private readonly IWarehouseProductsService _warehouseProductsService;
        private readonly IWarehouseService _warehouseService;

        public LoginScreen(IAuthService authService, IUserService userService,
            IProductService productService, IFactoryService factoryService, IOrdersService ordersService,
            IWarehouseProductsService warehouseProductsService, IWarehouseService warehouseService)
        {
            _authService = authService;
            _userService = userService;
            _productService = productService;
            _factoryService = factoryService;
            _ordersService = ordersService;
            _warehouseProductsService = warehouseProductsService;
            _warehouseService = warehouseService;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = _authService.Login(_userForLoginDto);
            if (!result.Success)
            {
                failedTxtLbl.Visible = true;
            }
            else
            {
                UserSession.Email = _userForLoginDto.Email;
                UserSession.Username = _userService.GetByEmail(_userForLoginDto.Email).Data.Name;
                failedTxtLbl.Visible = false;
                this.Hide();
                MainMenuScreen screen = new MainMenuScreen(
                    _productService, _factoryService, _ordersService, _warehouseProductsService, _warehouseService);
                screen.Show();
            }
        }

        private void emailTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForLoginDto.Email = emailTxtBox.Text;
        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForLoginDto.Password = passwordTxtBox.Text;
        }

        private void RegisterLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterScreen screen = new RegisterScreen(_authService, _userService,
                _productService, _factoryService, _ordersService, _warehouseProductsService, _warehouseService);
            this.Hide();
            screen.Show();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

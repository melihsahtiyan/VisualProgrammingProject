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
        public RegisterScreen(IAuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            _authService.Register(_userForRegisterDto);
        }

        private void emailTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.Email = emailTxtBox.Text;
        }

        private void birthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.DateOfBirth = birthDatePicker.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.FirstName = firstNameTxtBox.Text;
        }

        private void lastNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.LastName = lastNameTxtBox.Text;
        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.Password = passwordTxtBox.Text;
        }

        private void IdentityNumberTxtBox_TextChanged(object sender, EventArgs e)
        {
            _userForRegisterDto.IdentityNumber = IdentityNumberTxtBox.Text;
        }
    }
}

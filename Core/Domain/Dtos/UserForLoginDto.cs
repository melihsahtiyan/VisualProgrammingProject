using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Abstract;

namespace Core.Domain.Dtos
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

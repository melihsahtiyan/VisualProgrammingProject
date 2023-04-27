using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Dtos;

namespace Business.Abstract
{
    public interface IAuthService
    {
        void Register(UserForRegisterDto user);
        Task Login(UserForLoginDto user);
    }
}

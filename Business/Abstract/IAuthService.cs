using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Dtos;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IResult Register(UserForRegisterDto user);
        IResult RegisterList(List<UserForRegisterDto> users);
        IResult Login(UserForLoginDto user);
    }
}

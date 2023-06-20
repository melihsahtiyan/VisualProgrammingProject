using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Services;
using Core.Domain.Concrete;
using Core.Domain.Dtos;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Domain.Entities;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IFactoryRepository _factoryRepository;
        public AuthManager(IUserRepository userRepository, IFactoryRepository factoryRepository)
        {
            _userRepository = userRepository;
            _factoryRepository = factoryRepository;
        }
        public IResult Register(UserForRegisterDto user)
        {
            var result = _factoryRepository.Get(u => u.Email == user.Email);
            if (result == null)
            {
                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);
                var factoryToAdd = new Factory
                {
                    Name = user.Name,
                    Email = user.Email,
                    Country = user.Country,
                    Phone = user.Phone,
                    TaxNumber = user.TaxNumber,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    IsCustomer = user.IsCustomer,
                    IsSupplier = user.IsSupplier,
                    Status = true
                };
                _factoryRepository.Add(factoryToAdd);
                return new SuccessResult("User registered");
            }
            return new ErrorResult("User already exists");
        }

        public IResult RegisterList(List<UserForRegisterDto> users)
        {
            foreach (var user in users)
            {
                var result = Register(user);
                if (!result.Success)
                {
                    return new ErrorResult("Users not registered");
                }
            }
            return new SuccessResult("Users registered");
        }

        public IResult Login(UserForLoginDto user)
        {
            var userToCheck = _userRepository.Get(u => u.Email == user.Email);

            if (userToCheck == null)
            {
                return new ErrorResult("User not found");
            }

            if (!HashingHelper.VerifyPasswordHash(user.Password, userToCheck.PasswordHash,
                    userToCheck.PasswordSalt))
            {
                return new ErrorResult("Login failed");
            }

            return new SuccessResult("Login successful");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Services;
using Core.Domain.Concrete;
using Core.Domain.Dtos;
using Core.Utilities.Security.Hashing;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserRepository _userRepository;
        public AuthManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Register(UserForRegisterDto user)
        {
            var result = _userRepository.Get(u => u.Email == user.Email);
            if (result == null)
            {
                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(user.Password, out passwordHash, out passwordSalt);
                var userToAdd = new User
                {
                    Email = user.Email, 
                    PasswordHash = passwordHash, 
                    PasswordSalt = passwordSalt,
                    BirthDate = user.DateOfBirth, 
                    IdentityNumber = user.IdentityNumber, 
                    FirstName = user.FirstName,
                    LastName = user.LastName, 
                    Status = true
                };
                _userRepository.Add(userToAdd);
            }
        }

        public async Task Login(UserForLoginDto user)
        {
            byte[] passwordHash, passwordSalt;
            var userToCheck = await _userRepository.GetAsync(u => u.Email == user.Email);
            if (userToCheck != null)
            {
                HashingHelper.VerifyPasswordHash(user.Password, userToCheck.PasswordHash, userToCheck.PasswordHash);
                
            }
        }
    }
}

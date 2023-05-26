using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Services;
using Core.Domain.Concrete;
using Core.Persistence.Paging;
using Core.Utilities.Results;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IResult Add(User user)
        {
            var userToCheck = CheckIfUserExistsAndBring(user.Id);
            if (userToCheck != null)
            {
                return new ErrorResult("User exists!");
            }
            _userRepository.Add(user);
            return new SuccessResult("User added!");
        }

        public IResult Update(User user)
        {
            var userToCheck = CheckIfUserExistsAndBring(user.Id);
            if (userToCheck == null)
            {
                return new ErrorResult("User not found!");
            }
            _userRepository.Update(user);
            return new SuccessResult("User updated!");
        }

        public IResult Delete(User user)
        {
            var userToCheck = CheckIfUserExistsAndBring(user.Id);
            if (userToCheck == null)
            {
                return new ErrorResult("User not found!");
            }
            _userRepository.Delete(user);
            return new SuccessResult("User deleted!");
        }

        public IDataResult<User> GetById(int id)
        {
            var result = CheckIfUserExistsAndBring(id);
            if (result == null)
            {
                return new ErrorDataResult<User>("User not found!");
            }
            return new SuccessDataResult<User>(result, "User found!");
        }

        public IDataResult<User> GetByEmail(string email)
        {
            var result = _userRepository.Get(u => u.Email == email);
            if (result == null)
            {
                return new ErrorDataResult<User>("User not found!");
            }
            return new SuccessDataResult<User>(result, "User found!");
        }

        public IDataResult<List<User>> GetAll()
        {
            var result = _userRepository.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<User>>("Users not found!");
            }
            return new SuccessDataResult<List<User>>(result, "Users found!");
        }

        private User CheckIfUserExistsAndBring(int Id)
        {
            var result = _userRepository.Get(u => u.Id == Id);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;
using Core.Persistence.Paging;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<User> GetById(int id);
        IDataResult<User> GetByEmail(string email);
        IDataResult<List<User>> GetAll();

    }
}

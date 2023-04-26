using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Concrete;
using Core.Persistence.EntityFramework;

namespace Business.Services;
public interface IUserRepository : IAsyncRepository<User>, IRepository<User>
{
}
using Core.Utilities.Results;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFactoryService
    {
        IDataResult<List<Factory>> GetAll();
        IDataResult<Factory> GetById(int id);
        IDataResult<Factory> GetByEmail(string email);
        IDataResult<Factory> GetByName(string factoryName);
        IResult Add(Factory factory);
        IResult Update(Factory factory);
        IResult Delete(int id);
    }
}

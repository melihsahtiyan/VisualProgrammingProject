using Core.Utilities.Results;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dtos;

namespace Business.Abstract
{
    public interface IFactoryService
    {
        IDataResult<List<FactoryListDto>> GetAll();
        IDataResult<List<Factory>> GetAllManufacturer();
        IDataResult<List<Factory>> GetAllCustomer();
        IDataResult<Factory> GetById(int id);
        IDataResult<Factory> GetByEmail(string email);
        IDataResult<Factory> GetByName(string factoryName);
        IResult Add(FactoryForCreateDto factory);
        IResult Update(Factory factory);
        IResult Delete(int id);
    }
}

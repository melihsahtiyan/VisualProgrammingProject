using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Domain.Entities;

namespace Business.Concrete
{
    public class WarehouseManager : IWarehouseService
    {
        public IDataResult<List<Warehouse>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Warehouse> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Add(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }
    }
}

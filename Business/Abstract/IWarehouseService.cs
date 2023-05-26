using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Domain.Entities;

namespace Business.Abstract
{
    public interface IWarehouseService
    {
        IDataResult<List<Warehouse>> GetAll();
        IDataResult<Warehouse> GetById(int id);
        IResult Add(Warehouse warehouse);
        IResult Update(Warehouse warehouse);
        IResult Delete(Warehouse warehouse);
    }
}

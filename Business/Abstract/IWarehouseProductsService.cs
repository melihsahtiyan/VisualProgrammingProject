using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Domain.Dtos;
using Domain.Entities;

namespace Business.Abstract
{
    public interface IWarehouseProductsService
    {
        IDataResult<List<WarehouseProducts>> GetAll();
        IDataResult<List<WarehouseProductsDetailDto>> GetWarehouseProductsDetails();
        IDataResult<WarehouseProducts> GetById(int id);
        IResult Add(WarehouseProducts warehouseProducts);
        IResult Update(WarehouseProducts warehouseProducts);
        IResult Delete(WarehouseProducts warehouseProducts);
    }
}

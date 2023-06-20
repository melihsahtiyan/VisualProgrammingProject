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
    public interface IWarehouseService
    {
        IDataResult<List<Warehouse>> GetAll();
        IDataResult<Warehouse> GetById(int id);
        IDataResult<List<Warehouse>> GetAllByFactoryId(int id);
        IDataResult<List<Warehouse>> GetAllByFactoryIdAndWarehouseId(int factoryId, int warehouseId);
        IDataResult<List<Warehouse>> GetAllByWarehouseId(int id);
        IDataResult<List<Warehouse>> GetAllByFactoryName(string factoryName);
        IDataResult<Warehouse> GetAllByWarehouseName(string warehouseName);
        IResult Add(WarehouseForCreateDto warehouse);
        IResult AddRange(List<WarehouseForCreateDto> warehouses);
        IResult Update(WarehouseForCreateDto warehouse);
        IResult Delete(Warehouse warehouse);
    }
}

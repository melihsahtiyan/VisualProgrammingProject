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
        IDataResult<List<WarehouseProductsDetailDto>> GetWarehouseProductsDetailsByWarehouseId(int id);
        IDataResult<List<WarehouseProductsDetailDto>> GetWarehouseProductsDetailsByProductId(int id);
        IDataResult<List<WarehouseProductsDetailDto>> GetWarehouseProductsDetailsByFactoryId(int id);
        IDataResult<List<WarehouseProducts>> GetAllByProductIdAndWarehouseIdAndFactoryId(int productId,
            int warehouseId, int factoryId);
        IDataResult<List<WarehouseProductsDetailDto>> GetAllDetailsByProductIdAndWarehouseIdAndFactoryId(int productId,
            int warehouseId, int factoryId);
        IDataResult<List<WarehouseProductsDetailDto>> GetAllDetailsByProductIdAndFactoryId(int productId, int factoryId);
        IDataResult<int> GetTotalStockByFactoryIdAndProductId(int factoryId, int productId);
    }
}

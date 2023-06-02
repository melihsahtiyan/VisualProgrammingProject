using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.EntityFramework;
using Core.Utilities.Results;
using Domain.Dtos;
using Domain.Entities;

namespace Business.Services
{
    public interface IWarehouseProductsRepository : IAsyncRepository<WarehouseProducts>, IRepository<WarehouseProducts>
    {
        List<WarehouseProductsDetailDto> GetWarehouseProductsDetails();
        List<WarehouseProductsDetailDto> GetWarehouseProductsDetailsByWarehouseId(int id);
        List<WarehouseProductsDetailDto> GetWarehouseProductsDetailsByProductId(int id);
        List<WarehouseProductsDetailDto> GetWarehouseProductsDetailsByFactoryId(int id);
        List<WarehouseProducts> GetAllByProductIdAndWarehouseIdAndFactoryId(int productId, 
            int warehouseId, int factoryId);
        List<WarehouseProductsDetailDto> GetAllDetailsByProductIdAndWarehouseIdAndFactoryId(int productId, 
            int warehouseId, int factoryId);
        List<WarehouseProductsDetailDto> GetAllDetailsByProductIdAndFactoryId(int productId, int factoryId);
        int GetTotalStockByFactoryIdAndProductId(int factoryId, int productId);
    }
}

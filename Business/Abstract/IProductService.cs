using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using Domain.Dtos;
using Domain.Entities;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<IPaginate<Product>> GetAllAsyncByDynamic(DynamicQueryDto request);
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByWarehouseId(int warehouseId);
        IDataResult<Product> GetByName(string name);
        Product GetById(int id);
        void AddAsync(Product product);
        void UpdateAsync(Product product);
        void DeleteAsync(Product product);
    }
}

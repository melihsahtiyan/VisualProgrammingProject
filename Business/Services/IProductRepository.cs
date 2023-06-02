using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.EntityFramework;
using Domain.Dtos;
using Domain.Entities;

namespace Business.Services
{
    public interface IProductRepository : IAsyncRepository<Product>, IRepository<Product>
    {
        List<Product> GetAllByWarehouseId(int warehouseId);
    }
}

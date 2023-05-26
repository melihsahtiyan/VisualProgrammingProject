using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services;
using Core.Persistence.EntityFramework;
using Domain.Dtos;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class WarehouseProductsRepository : EfRepositoryBase<WarehouseProducts, BaseDbContext>,
    IWarehouseProductsRepository
{
    public WarehouseProductsRepository(BaseDbContext context) : base(context)
    { }

    public List<WarehouseProductsDetailDto> GetWarehouseProductsDetails()
    {
        var result = (from wp in Context.WarehouseProducts
                      join w in Context.Warehouses on wp.WarehouseId equals w.Id
                      join p in Context.Products on wp.ProductId equals p.Id
                      select new WarehouseProductsDetailDto
                      {
                          Id = wp.Id,
                          WarehouseName = w.Name,
                          Address = w.Address,
                          Phone = w.Phone,
                          ProductName = p.Name,
                          ProductDescription = p.Description,
                          Price = p.Price,
                          Quantity = wp.Quantity
                      }).ToList();
        return result;
    }
}


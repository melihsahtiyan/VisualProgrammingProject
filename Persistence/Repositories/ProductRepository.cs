﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services;
using Core.Persistence.EntityFramework;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class ProductRepository : EfRepositoryBase<Product, BaseDbContext>, IProductRepository
    {
        public ProductRepository(BaseDbContext context) : base(context)
        {
        }

        public List<Product> GetAllByWarehouseId(int warehouseId)
        {
            var result = Context.WarehouseProducts.Where(wp => wp.WarehouseId == warehouseId)
                .Select(wp => wp.Product).ToList();
            return result;
        }
    }
}

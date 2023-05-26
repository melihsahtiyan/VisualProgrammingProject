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

namespace Persistence.Repositories
{
    public class OrdersRepository : EfRepositoryBase<Orders, BaseDbContext>,
        IOrdersRepository

    {
        public OrdersRepository(BaseDbContext context) : base(context)
        {
        }

        public List<OrderDetailDto> GetOrderDetails()
        {
            var result = (from o in Context.Orders
                                   join pf in Context.Factories on o.CustomerFactoryId equals pf.Id
                                   join mf in Context.Factories on o.ManufacturingFactoryId equals mf.Id
                                   join p in Context.Products on o.ProductId equals p.Id
                                   select new OrderDetailDto
                                                  {
                    Id = o.Id,
                    CustomerFactoryName = pf.Name,
                    ManufacturerFactoryName = mf.Name,
                    ProductName = p.Name,
                    Quantity = o.Quantity
                }).ToList();

            return result;
        }
    }
}

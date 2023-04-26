using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services;
using Core.Persistence.EntityFramework;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class WarehouseRepository : EfRepositoryBase<Warehouse, BaseDbContext>, IWarehouseRepository
{
    public WarehouseRepository(BaseDbContext context) : base(context)
    {

    }
}
using System;
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
    public class FactoryRepository : EfRepositoryBase<Factory, BaseDbContext>, IFactoryRepository
    {
        public FactoryRepository(BaseDbContext context) : base(context)
        {
        }
    }
}

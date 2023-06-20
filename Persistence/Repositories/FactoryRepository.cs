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
    public class FactoryRepository : EfRepositoryBase<Factory, BaseDbContext>, IFactoryRepository
    {
        public FactoryRepository(BaseDbContext context) : base(context)
        {
        }

        public List<FactoryListDto> GetAllFactories()
        {
            var result = (from factories in Context.Factories
                    select new FactoryListDto
                    {
                        Id = factories.Id,
                        Email = factories.Email,
                        Password = "12345",
                        TaxNumber = factories.TaxNumber,
                        Phone = factories.Phone,
                        Address = factories.Country,
                        Name = factories.Name,
                        IsCustomer = factories.IsCustomer,
                        IsSupplier = factories.IsSupplier
                    }).ToList();

            return result;
        }
    }
}

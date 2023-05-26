using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)

        {
            services.AddDbContext<BaseDbContext>(options =>
                options.UseNpgsql(
                    "Host=localhost;Username=postgres;Password=12345;Database=VisualProgrammingMidtermProject;"));
            services.AddScoped<IFactoryRepository, FactoryRepository>();
            services.AddScoped<IWarehouseRepository, WarehouseRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IWarehouseProductsRepository, WarehouseProductsRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();
            services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
            services.AddScoped<IOrdersRepository, OrdersRepository>();
            return services;
        }
    }
}

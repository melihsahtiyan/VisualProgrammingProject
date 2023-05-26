using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IWarehouseService, WarehouseManager>();
            services.AddScoped<IWarehouseProductsService, WarehouseProductsManager>();
            services.AddScoped<IFactoryService, FactoryManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddScoped<IUserService, UserManager>();
            //services.AddScoped<IUserOperationClaimService, UserOperationClaimManager>();
            //services.AddScoped<IOperationClaimService, OperationClaimManager>();
            services.AddScoped<IOrdersService, OrdersManager>();
            return services;
        }
    }
}

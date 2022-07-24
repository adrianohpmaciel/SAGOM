using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SAGOM.Domain.Interfaces;
using SAGOM.Infra.Data.Context;
using SAGOM.Infra.Data.Repositories;
using SAGOM.Infra.Data.Identity;
using Microsoft.AspNetCore.Identity;
using SAGOM.Domain.AccountInterfaces;

namespace SAGOM.Infra.Data.RepositoriesInfrastructure
{

    public static class RepositoriesInjectionAPI
    {

        public static IServiceCollection AddReposirotiesInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SagomDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(SagomDbContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<SagomDbContext>()
                .AddDefaultTokenProviders();

            //services.AddScoped<IBillRepository, BillRepository>();            
            //services.AddScoped<ICostumerRepository, CostumerRepository>();
            //services.AddScoped<ICostumerServiceRepository, CostumerServiceRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductServiceOrderRepository, ProductServiceOrderRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            //services.AddScoped<IServiceOrderRepository, ServiceOrderRepository>();
            //services.AddScoped<IServiceServiceOrderRepository, ServiceServiceOrderRepository>();
            //services.AddScoped<IToolRepository, ToolRepository>();
            //services.AddScoped<IVehicleRepository, VehicleRepository>();

            services.AddScoped<IAuthenticateRepository, AuthenticateRepository>();

            return services;
        }
    }
}

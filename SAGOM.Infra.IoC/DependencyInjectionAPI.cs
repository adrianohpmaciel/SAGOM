using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SAGOM.Application.Interfaces;
using SAGOM.Application.Mappings;
using SAGOM.Application.Services;
using SAGOM.Domain.Interfaces;
using SAGOM.Infra.Data.Context;
using SAGOM.Infra.Data.Repositories;
using SAGOM.Infra.Data.Identity;
using SAGOM.Domain.Account;
using Microsoft.AspNetCore.Identity;

namespace SAGOM.Infra.IoC
{
    public static class DependencyInjectionAPI
    {

        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SagomDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly(typeof(SagomDbContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<SagomDbContext>()
                .AddDefaultTokenProviders();

            //services.AddScoped<IBillRepository, BillRepository>();
            //services.AddScoped<ICompanyRepository, CompanyRepository>();
            //services.AddScoped<ICostumerRepository, CostumerRepository>();
            //services.AddScoped<ICostumerServiceRepository, CostumerServiceRepository>();
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            //services.AddScoped<IPersonRepository, PersonRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductServiceOrderRepository, ProductServiceOrderRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            //services.AddScoped<IServiceOrderRepository, ServiceOrderRepository>();
            //services.AddScoped<IServiceServiceOrderRepository, ServiceServiceOrderRepository>();
            //services.AddScoped<IToolRepository, ToolRepository>();
            //services.AddScoped<IVehicleRepository, VehicleRepository>();

            //services.AddScoped<IBillService, BillService>();
            //services.AddScoped<ICompanyService, CompanyService>();
            //services.AddScoped<Application.Interfaces.ICostumerService, Application.Services.CostumerService>();
            //services.AddScoped<ICostumerServiceService, CostumerServiceService>();
            //services.AddScoped<IEmployeeService, EmployeeService>();
            //services.AddScoped<IPersonService, PersonService>();
            //services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRoleService, RoleService>();
            //services.AddScoped<IServiceOrderService, ServiceOrderService>();
            //services.AddScoped<IToolService, ToolService>();
            //services.AddScoped<IVehicleService, VehicleService>();

            services.AddScoped<IAuthenticate, AuthenticateService>();
            services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}

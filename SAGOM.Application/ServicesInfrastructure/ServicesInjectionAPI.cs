using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SAGOM.Application.Interfaces;
using SAGOM.Application.Interfaces.UserInterfaces;
using SAGOM.Application.Mappings;
using SAGOM.Application.Services;
using SAGOM.Application.Services.UserServices;
using SAGOM.Infra.Data.RepositoriesInfrastructure;

namespace SAGOM.Application.ServicesInfrastructure
{

    public static class ServicesInjectionAPI
    {

        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddReposirotiesInfrastructureAPI(configuration);

            //services.AddScoped<IBillService, BillService>();
            //services.AddScoped<Application.Interfaces.ICostumerService, Application.Services.CostumerService>();
            //services.AddScoped<ICostumerServiceService, CostumerServiceService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ICompanyService, CompanyService>();
            //services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRoleService, RoleService>();
            //services.AddScoped<IServiceOrderService, ServiceOrderService>();
            //services.AddScoped<IToolService, ToolService>();
            //services.AddScoped<IVehicleService, VehicleService>();

            services.AddScoped<IAuthenticateService, AuthenticateService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}

using SAGOM.Domain.AccountInterfaces;
using SAGOM.Infra.Data.Identity;
//using SAGOM.Infra.IoC;
using SAGOM.Application;
using System.ComponentModel;
using System.Reflection;
using SAGOM.Application.ServicesInfrastructure;

namespace SAGOM.WebAPI
{
    public class Program
    {
        static public void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddInfrastructureAPI(builder.Configuration);

            //var services2 =
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(c =>
            {
                c.CustomSchemaIds(x =>
                {
                    if (x.GetCustomAttributes<DisplayNameAttribute>().SingleOrDefault() != null)
                    {
                        return x.GetCustomAttributes<DisplayNameAttribute>().SingleOrDefault().DisplayName;
                    }
                    else
                        return x.Name;
                });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }

}


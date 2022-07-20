using SAGOM.Infra.IoC;
using System.ComponentModel;
using System.Reflection;

namespace SAGOM.WebAPI
{
    public class Program
    {
        static public void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var buildarar = builder.Configuration.GetConnectionString("\"(\\\"Server=LAPTOP-N8EBDQKA; Database=SagomDb; Trusted_Connection=True;\\\"\"");
            // Add services to the container.
            builder.Services.AddInfrastructureAPI(builder.Configuration);

            //var services2 =
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.CustomSchemaIds(x => x.GetCustomAttributes<DisplayNameAttribute>().SingleOrDefault().DisplayName);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }

}


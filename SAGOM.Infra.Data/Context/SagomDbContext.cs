using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SAGOM.Domain.Entities;
using SAGOM.Infra.Data.Identity;

namespace SAGOM.Infra.Data.Context
{
    public  class SagomDbContext : IdentityDbContext<ApplicationUser>
    {
        public  DbSet<CostumerService> CostumerServices { get; set; } = null!;
        public  DbSet<Role> Roles { get; set; } = null!;
        public  DbSet<Costumer> Costumers { get; set; } = null!;
        public  DbSet<Employee> Employees { get; set; } = null!;
        public  DbSet<Bill> Bills { get; set; } = null!;
        public  DbSet<Company> Companies { get; set; } = null!;
        public  DbSet<Tool> Tools { get; set; } = null!;
        public  DbSet<ServiceOrder> ServiceOrders { get; set; } = null!;
        public  DbSet<Person> Persons { get; set; } = null!;
        public  DbSet<Product> Products { get; set; } = null!;
        public  DbSet<ProductServiceOrder> ProductServiceOrders { get; set; } = null!;
        public  DbSet<Service> Services { get; set; } = null!;
        public  DbSet<ServiceServiceOrder> ServiceServiceOrders { get; set; } = null!;
        public  DbSet<Vehicle> Vehicles { get; set; } = null!;

        public SagomDbContext()
        {
        }

        public SagomDbContext(DbContextOptions<SagomDbContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-N8EBDQKA; Database=SagomDb; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(SagomDbContext).Assembly);
        }


    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public class ServiceServiceOrderConfiguration : IEntityTypeConfiguration<ServiceServiceOrder>
    {
        public void Configure(EntityTypeBuilder<ServiceServiceOrder> builder)
        {
            builder.ToTable("Servico_Ordem_de_Servico");

            builder.HasIndex(e => e.Id, "UQ__Servico___3213E83E1A824DDA")
                    .IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.IdServiceOrder).HasColumnName("id_ordem_servico");

            builder.Property(e => e.IdService).HasColumnName("id_servico");

            builder.HasOne(d => d.IdServiceOrderNavigation)
                    .WithMany(p => p.ServiceServiceOrders)
                    .HasForeignKey(d => d.IdServiceOrder)
                    .HasConstraintName("FK_Servico_Ordem_de_Servico.id_ordem_servico");

            builder.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.ServiceServiceOrders)
                    .HasForeignKey(d => d.IdService)
                    .HasConstraintName("FK_Servico_Ordem_de_Servico.id_servico");
        }
    }
}

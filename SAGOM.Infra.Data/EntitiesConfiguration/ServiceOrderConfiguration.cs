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
    public class ServiceOrderConfiguration : IEntityTypeConfiguration<ServiceOrder>
    {
        public void Configure(EntityTypeBuilder<ServiceOrder> builder)
        {
            builder.ToTable("Ordem_de_Servico");

            builder.HasIndex(e => e.Id, "UQ__Ordem_de__3213E83E8AF8C1A8")
                .IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("data");

            builder.Property(e => e.UpdateDateLastStatus)
                .HasColumnType("date")
                .HasColumnName("data_ultima_alteracao_status");

            builder.Property(e => e.IdCostumerService).HasColumnName("id_atendimento");

            builder.Property(e => e.Reason)
                .IsUnicode(false)
                .HasColumnName("motivo");

            builder.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("status");

            builder.HasOne(d => d.IdCostumerServiceNavigation)
                .WithMany(p => p.ServiceOrders)
                .HasForeignKey(d => d.IdCostumerService)
                .HasConstraintName("FK_Ordem_de_Servico.id_atendimento");

        }
    }
}

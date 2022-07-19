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
    public class CostumerServiceConfiguration : IEntityTypeConfiguration<CostumerService>
    {
        public void Configure(EntityTypeBuilder<CostumerService> builder)
        {
            builder.ToTable("Atendimento");

            builder.HasIndex(e => e.Id, "UQ__Atendime__3213E83ECF37128A")
                    .IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("data");

            builder.Property(e => e.UpdateDateLastStatus)
                    .HasColumnType("date")
                    .HasColumnName("data_ultima_alteracao_status");

            builder.Property(e => e.ProblemDescription)
                    .IsUnicode(false)
                    .HasColumnName("descricao_problema");

            builder.Property(e => e.IdCostumer).HasColumnName("id_cliente");

            builder.Property(e => e.IdEmployee).HasColumnName("id_colaborador");

            builder.Property(e => e.IdBill).HasColumnName("id_conta");

            builder.Property(e => e.IdVehicle).HasColumnName("id_veiculo");

            builder.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

            builder.HasOne(d => d.IdCostumerNavigation)
                    .WithMany(p => p.CostumerServices)
                    .HasForeignKey(d => d.IdCostumer)
                    .HasConstraintName("FK_Atendimento.id_cliente");

            builder.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.CostumerServices)
                    .HasForeignKey(d => d.IdEmployee)
                    .HasConstraintName("FK_Atendimento.id_colaborador");

            builder.HasOne(d => d.IdVehicleNavigation)
                    .WithMany(p => p.CostumerServices)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.IdVehicle)
                    .HasConstraintName("FK_Atendimento.id_veiculo");            
        }
    }
}

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
    public class ToolConfiguration : IEntityTypeConfiguration<Tool>
    {
        public void Configure(EntityTypeBuilder<Tool> builder)
        {
            builder.HasIndex(e => e.Id, "UQ__Ferramen__3213E83E49A210E9")
                .IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.PurchaseDate)
                .HasColumnType("date")
                .HasColumnName("data_de_compra");

            builder.Property(e => e.DiscardDate)
                .HasColumnType("date")
                .HasColumnName("data_de_descarte");

            builder.Property(e => e.Description)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("descricao");

            builder.Property(e => e.IdEmployee).HasColumnName("id_colaborador");

            builder.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nome");

            builder.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("status");

            builder.Property(e => e.Price)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("valor");

            builder.HasOne(d => d.IdEmployeeNavigation)
                .WithMany(p => p.Tools)
                .HasForeignKey(d => d.IdEmployee)
                .HasConstraintName("FK_Ferramenta.id_colaborador");

        }
    }
}

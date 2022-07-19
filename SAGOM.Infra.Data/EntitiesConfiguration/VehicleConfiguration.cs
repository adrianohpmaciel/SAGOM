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
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(e => new { e.LicensePlate, e.Country })
                .HasName("PK__Veiculo__6432AF2D5F8CD547");

            builder.ToTable("Veiculo");

            builder.HasIndex(e => e.Id, "UQ__Veiculo__3213E83ED5ABF8C8")
                .IsUnique();

            builder.Property(e => e.LicensePlate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("placa")
                .IsFixedLength();

            builder.Property(e => e.Country)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("país");

            builder.Property(e => e.Year).HasColumnName("ano");

            builder.Property(e => e.State)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estado");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            builder.Property(e => e.IdCostumer).HasColumnName("id_cliente");

            builder.Property(e => e.BrandName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("marca");

            builder.Property(e => e.ModelName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("modelo");

            builder.HasOne(d => d.IdCostumerNavigation)
                .WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.IdCostumer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Veiculo.id_cliente");

        }
    }
}

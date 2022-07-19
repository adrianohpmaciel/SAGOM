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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.ToTable("Produto");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Description)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("descricao");

            builder.Property(e => e.Name)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("nome");

            builder.Property(e => e.Quantity).HasColumnName("quantidade");

            builder.Property(e => e.UnitPrice)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("valor_Unitario");

        }
    }
}

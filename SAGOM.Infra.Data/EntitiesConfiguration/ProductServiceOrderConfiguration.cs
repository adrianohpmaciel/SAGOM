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
    public class ProductServiceOrderConfiguration : IEntityTypeConfiguration<ProductServiceOrder>
    {
        public void Configure(EntityTypeBuilder<ProductServiceOrder> builder)
        {
            builder.ToTable("Produto_Ordem_de_Servico");

            builder.HasIndex(e => e.Id, "UQ__Produto___3213E83E6CB98995")
                .IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.IdServiceOrder).HasColumnName("id_ordem_servico");

            builder.Property(e => e.IdProduct).HasColumnName("id_produto");

            builder.Property(e => e.Quantity).HasColumnName("quantidade");

            builder.HasOne(d => d.IdServiceOrderNavigation)
                .WithMany(p => p.ProductServiceOrders)
                .HasForeignKey(d => d.IdServiceOrder)
                .HasConstraintName("FK_Produto_Ordem_de_Servico.id_ordem_servico");

            builder.HasOne(d => d.IdProductNavigation)
                .WithMany(p => p.ProductServiceOrders)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("FK_Produto_Ordem_de_Servico.id_produto");
        }
    }
}

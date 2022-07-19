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
    public class CostumerConfiguration : IEntityTypeConfiguration<Costumer>
    {
        public void Configure(EntityTypeBuilder<Costumer> builder)
        {
            builder.ToTable("Cliente");

            builder.HasIndex(e => e.Id, "UQ__Cliente__3213E83E69D0E29A")
                .IsUnique();

            builder.HasIndex(e => e.Cpf, "UQ__Cliente__D836E71F87F53EB2")
                .IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("cpf")
                .IsFixedLength();

            builder.HasOne(d => d.CpfNavigation)
                .WithOne(p => p.Costumer)
                .HasForeignKey<Costumer>(d => d.Cpf)
                .HasConstraintName("FK_Cliente.cpf");
        }
    }
}

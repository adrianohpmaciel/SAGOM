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
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Cargo");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Description)
                   .HasMaxLength(100)
                   .IsUnicode(false)
                   .HasColumnName("descricao");

            builder.Property(e => e.Name)
                   .HasMaxLength(30)
                   .IsUnicode(false)
                   .HasColumnName("nome");

        }
    }
}
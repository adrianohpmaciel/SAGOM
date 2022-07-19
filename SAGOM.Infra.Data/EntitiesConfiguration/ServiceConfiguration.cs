﻿using Microsoft.EntityFrameworkCore;
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
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Servico");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Description)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

            builder.Property(e => e.Name)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");

            builder.Property(e => e.Price)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("valor");
        }
    }
}

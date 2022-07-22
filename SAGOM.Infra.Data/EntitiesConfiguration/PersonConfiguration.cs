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
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(e => e.Cpf)
                    .HasName("PK__Pessoa__D836E71EE3ED5CB1");

            builder.HasIndex(e => e.Email)
                    .HasName("UQ__Pessoa__AB6E6164E6B6D964")
                    .IsUnique();

            builder.ToTable("Pessoa");

            builder.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf")
                    .IsFixedLength();

            builder.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("email");

            builder.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("endereco");

            builder.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nome");

            builder.Property(e => e.LastName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("sobrenome");

            builder.Property(e => e.CellPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
        }
    }
}

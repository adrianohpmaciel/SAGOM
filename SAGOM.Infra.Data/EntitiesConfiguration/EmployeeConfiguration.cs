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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Colaborador");

            builder.HasIndex(e => e.Id, "UQ__Colabora__3213E83E38672861")
                .IsUnique();

            builder.HasIndex(e => e.Cpf, "UQ__Colabora__D836E71F0FEE059D")
                .IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.CnpjCompany)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("cnpj_empresa")
                .IsFixedLength();

            builder.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("cpf")
                .IsFixedLength();

            builder.Property(e => e.IdRole).HasColumnName("id_cargo");

            builder.Property(e => e.Salary)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("salario");

            builder.HasOne(d => d.CnpjCompanyNavigation)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.CnpjCompany)
                .HasConstraintName("FK_Colaborador.cnpj_empresa");

            builder.HasOne(d => d.CpfNavigation)
                .WithOne(p => p.Employee)
                .HasForeignKey<Employee>(d => d.Cpf)
                .HasConstraintName("FK_Colaborador.cpf");

            builder.HasOne(d => d.IdRoleNavigation)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Colaborador.id_cargo");
        }
    }
}

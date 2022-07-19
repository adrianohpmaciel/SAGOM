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
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Conta");

            builder.HasIndex(e => e.Id, "UQ__Conta__3213E83EB19ED64D")
                    .IsUnique();

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.CnpjPayer)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("cnpj_pagante")
                .IsFixedLength();

            builder.Property(e => e.CnpjReceiver)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("cnpj_recebedor")
                .IsFixedLength();

            builder.Property(e => e.CpfPayer)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("cpf_pagante")
                .IsFixedLength();

            builder.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("data");

            builder.Property(e => e.PaymentDate)
                .HasColumnType("date")
                .HasColumnName("data_pagamento");

            builder.Property(e => e.DueDate)
                .HasColumnType("date")
                .HasColumnName("data_vencimento");

            builder.Property(e => e.Description)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descricao");

            builder.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("status");

            builder.Property(e => e.Amount)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("valor");

            builder.HasOne(d => d.CnpjReceiverNavigation)
                .WithMany(p => p.Bills)
                .HasForeignKey(d => d.CnpjReceiver)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Conta.cnpj_recebedor");

        }
    }
}

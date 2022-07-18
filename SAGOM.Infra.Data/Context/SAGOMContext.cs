using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SAGOM.Infra.Data.EntitiesConfiguration;

namespace SAGOM.Infra.Data.Context
{
    public partial class SAGOMContext : DbContext
    {
        public SAGOMContext()
        {
        }

        public SAGOMContext(DbContextOptions<SAGOMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Atendimento> Atendimentos { get; set; } = null!;
        public virtual DbSet<Cargo> Cargos { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Colaborador> Colaboradors { get; set; } = null!;
        public virtual DbSet<Conta> Conta { get; set; } = null!;
        public virtual DbSet<Empresa> Empresas { get; set; } = null!;
        public virtual DbSet<Ferramenta> Ferramenta { get; set; } = null!;
        public virtual DbSet<OrdemDeServico> OrdemDeServicos { get; set; } = null!;
        public virtual DbSet<Pessoa> Pessoas { get; set; } = null!;
        public virtual DbSet<Produto> Produtos { get; set; } = null!;
        public virtual DbSet<ProdutoOrdemDeServico> ProdutoOrdemDeServicos { get; set; } = null!;
        public virtual DbSet<Servico> Servicos { get; set; } = null!;
        public virtual DbSet<ServicoOrdemDeServico> ServicoOrdemDeServicos { get; set; } = null!;
        public virtual DbSet<Veiculo> Veiculos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-N8EBDQKA;Database = SAGOM; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atendimento>(entity =>
            {
                entity.ToTable("Atendimento");

                entity.HasIndex(e => e.Id, "UQ__Atendime__3213E83E084F92DC")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("data");

                entity.Property(e => e.DataUltimaAlteracaoStatus)
                    .HasColumnType("date")
                    .HasColumnName("data_ultima_alteracao_status");

                entity.Property(e => e.DescricaoProblema)
                    .IsUnicode(false)
                    .HasColumnName("descricao_problema");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdColaborador).HasColumnName("id_colaborador");

                entity.Property(e => e.IdConta).HasColumnName("id_conta");

                entity.Property(e => e.IdVeiculo).HasColumnName("id_veiculo");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Atendimentos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_Atendimento.id_cliente");

                entity.HasOne(d => d.IdColaboradorNavigation)
                    .WithMany(p => p.Atendimentos)
                    .HasForeignKey(d => d.IdColaborador)
                    .HasConstraintName("FK_Atendimento.id_colaborador");

                entity.HasOne(d => d.IdVeiculoNavigation)
                    .WithMany(p => p.Atendimentos)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.IdVeiculo)
                    .HasConstraintName("FK_Atendimento.id_veiculo");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.ToTable("Cargo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.HasIndex(e => e.Id, "UQ__Cliente__3213E83E71AB27F4")
                    .IsUnique();

                entity.HasIndex(e => e.Cpf, "UQ__Cliente__D836E71F075765C8")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf")
                    .IsFixedLength();

                entity.HasOne(d => d.CpfNavigation)
                    .WithOne(p => p.Cliente)
                    .HasForeignKey<Cliente>(d => d.Cpf)
                    .HasConstraintName("FK_Cliente.cpf");
            });

            modelBuilder.Entity<Colaborador>(entity =>
            {
                entity.ToTable("Colaborador");

                entity.HasIndex(e => e.Id, "UQ__Colabora__3213E83E9527BBA8")
                    .IsUnique();

                entity.HasIndex(e => e.Cpf, "UQ__Colabora__D836E71F3DAD9746")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CnpjEmpresa)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("cnpj_empresa")
                    .IsFixedLength();

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf")
                    .IsFixedLength();

                entity.Property(e => e.IdCargo).HasColumnName("id_cargo");

                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("salario");

                entity.HasOne(d => d.CnpjEmpresaNavigation)
                    .WithMany(p => p.Colaboradors)
                    .HasForeignKey(d => d.CnpjEmpresa)
                    .HasConstraintName("FK_Colaborador.cnpj_empresa");

                entity.HasOne(d => d.CpfNavigation)
                    .WithOne(p => p.Colaborador)
                    .HasForeignKey<Colaborador>(d => d.Cpf)
                    .HasConstraintName("FK_Colaborador.cpf");

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Colaboradors)
                    .HasForeignKey(d => d.IdCargo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Colaborador.id_cargo");
            });

            modelBuilder.Entity<Conta>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ__Conta__3213E83E338441C1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CnpjPagante)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("cnpj_pagante")
                    .IsFixedLength();

                entity.Property(e => e.CnpjRecebedor)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("cnpj_recebedor")
                    .IsFixedLength();

                entity.Property(e => e.CpfPagante)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf_pagante")
                    .IsFixedLength();

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("data");

                entity.Property(e => e.DataPagamento)
                    .HasColumnType("date")
                    .HasColumnName("data_pagamento");

                entity.Property(e => e.DataVencimento)
                    .HasColumnType("date")
                    .HasColumnName("data_vencimento");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.CnpjRecebedorNavigation)
                    .WithMany(p => p.Conta)
                    .HasForeignKey(d => d.CnpjRecebedor)
                    .HasConstraintName("FK_Conta.cnpj_recebedor");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.Cnpj)
                    .HasName("PK__Empresa__35BD3E49439F8317");

                entity.ToTable("Empresa");

                entity.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("cnpj")
                    .IsFixedLength();

                entity.Property(e => e.Endereço)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("endereço");

                entity.Property(e => e.NomeFantasia)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome_fantasia");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Ferramenta>(entity =>
            {
                entity.HasIndex(e => e.Id, "UQ__Ferramen__3213E83E5B7C6F26")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataDeCompra)
                    .HasColumnType("date")
                    .HasColumnName("data_de_compra");

                entity.Property(e => e.DataDeDescarte)
                    .HasColumnType("date")
                    .HasColumnName("data_de_descarte");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdColaborador).HasColumnName("id_colaborador");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("valor");

                entity.HasOne(d => d.IdColaboradorNavigation)
                    .WithMany(p => p.Ferramenta)
                    .HasForeignKey(d => d.IdColaborador)
                    .HasConstraintName("FK_Ferramenta.id_colaborador");
            });

            modelBuilder.Entity<OrdemDeServico>(entity =>
            {
                entity.ToTable("Ordem_de_Servico");

                entity.HasIndex(e => e.Id, "UQ__Ordem_de__3213E83E687406FA")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("data");

                entity.Property(e => e.DataUltimaAlteracaoStatus)
                    .HasColumnType("date")
                    .HasColumnName("data_ultima_alteracao_status");

                entity.Property(e => e.IdAtendimento).HasColumnName("id_atendimento");

                entity.Property(e => e.Motivo)
                    .IsUnicode(false)
                    .HasColumnName("motivo");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.HasOne(d => d.IdAtendimentoNavigation)
                    .WithMany(p => p.OrdemDeServicos)
                    .HasForeignKey(d => d.IdAtendimento)
                    .HasConstraintName("FK_Ordem_de_Servico.id_atendimento");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.Cpf)
                    .HasName("PK__Pessoa__D836E71E53157238");

                entity.ToTable("Pessoa");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf")
                    .IsFixedLength();

                entity.Property(e => e.Nome)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Sobrenome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("sobrenome");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("Produto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("valor_Unitario");
            });

            modelBuilder.Entity<ProdutoOrdemDeServico>(entity =>
            {
                entity.ToTable("Produto_Ordem_de_Servico");

                entity.HasIndex(e => e.Id, "UQ__Produto___3213E83E73B8A2E3")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdOrdemServico).HasColumnName("id_ordem_servico");

                entity.Property(e => e.IdProduto).HasColumnName("id_produto");

                entity.Property(e => e.Quantidade).HasColumnName("quantidade");

                entity.HasOne(d => d.IdOrdemServicoNavigation)
                    .WithMany(p => p.ProdutoOrdemDeServicos)
                    .HasForeignKey(d => d.IdOrdemServico)
                    .HasConstraintName("FK_Produto_Ordem_de_Servico.id_ordem_servico");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.ProdutoOrdemDeServicos)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("FK_Produto_Ordem_de_Servico.id_produto");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.ToTable("Servico");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Valor)
                    .HasColumnType("decimal(9, 4)")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<ServicoOrdemDeServico>(entity =>
            {
                entity.ToTable("Servico_Ordem_de_Servico");

                entity.HasIndex(e => e.Id, "UQ__Servico___3213E83E81549D80")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdOrdemServico).HasColumnName("id_ordem_servico");

                entity.Property(e => e.IdServico).HasColumnName("id_servico");

                entity.HasOne(d => d.IdOrdemServicoNavigation)
                    .WithMany(p => p.ServicoOrdemDeServicos)
                    .HasForeignKey(d => d.IdOrdemServico)
                    .HasConstraintName("FK_Servico_Ordem_de_Servico.id_ordem_servico");

                entity.HasOne(d => d.IdServicoNavigation)
                    .WithMany(p => p.ServicoOrdemDeServicos)
                    .HasForeignKey(d => d.IdServico)
                    .HasConstraintName("FK_Servico_Ordem_de_Servico.id_servico");
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.HasKey(e => new { e.Placa, e.País })
                    .HasName("PK__Veiculo__6432AF2DD2D495CF");

                entity.ToTable("Veiculo");

                entity.HasIndex(e => e.Id, "UQ__Veiculo__3213E83EAD733E24")
                    .IsUnique();

                entity.Property(e => e.Placa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("placa")
                    .IsFixedLength();

                entity.Property(e => e.País)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("país");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Estado)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.Marca)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("marca");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("modelo");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Veiculos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Veiculo.id_cliente");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

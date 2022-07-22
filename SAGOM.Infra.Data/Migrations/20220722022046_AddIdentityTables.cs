using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAGOM.Infra.Data.Migrations
{
    public partial class AddIdentityTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Cargo",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nome = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
            //        descricao = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cargo", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Empresa",
            //    columns: table => new
            //    {
            //        cnpj = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false),
            //        nome_fantasia = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
            //        endereço = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        telefone = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Empresa__35BD3E491A4AD40A", x => x.cnpj);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Pessoa",
            //    columns: table => new
            //    {
            //        cpf = table.Column<string>(type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: false),
            //        nome = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
            //        sobrenome = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
            //        endereco = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        telefone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Pessoa__D836E71EE3ED5CB1", x => x.cpf);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Produto",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nome = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
            //        descricao = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
            //        quantidade = table.Column<int>(type: "int", nullable: false),
            //        valor_Unitario = table.Column<decimal>(type: "decimal(9,4)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Produto", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Servico",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nome = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
            //        descricao = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
            //        valor = table.Column<decimal>(type: "decimal(9,4)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Servico", x => x.id);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "Conta",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        cnpj_recebedor = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: false),
            //        cnpj_pagante = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: true),
            //        cpf_pagante = table.Column<string>(type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: true),
            //        descricao = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
            //        valor = table.Column<decimal>(type: "decimal(9,4)", nullable: false),
            //        data = table.Column<DateTime>(type: "date", nullable: false),
            //        data_vencimento = table.Column<DateTime>(type: "date", nullable: false),
            //        data_pagamento = table.Column<DateTime>(type: "date", nullable: true),
            //        status = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Conta", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Conta.cnpj_recebedor",
            //            column: x => x.cnpj_recebedor,
            //            principalTable: "Empresa",
            //            principalColumn: "cnpj");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cliente",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        cpf = table.Column<string>(type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cliente", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Cliente.cpf",
            //            column: x => x.cpf,
            //            principalTable: "Pessoa",
            //            principalColumn: "cpf");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Colaborador",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        cpf = table.Column<string>(type: "char(11)", unicode: false, fixedLength: true, maxLength: 11, nullable: true),
            //        id_cargo = table.Column<int>(type: "int", nullable: false),
            //        salario = table.Column<decimal>(type: "decimal(9,4)", nullable: true),
            //        cnpj_empresa = table.Column<string>(type: "char(14)", unicode: false, fixedLength: true, maxLength: 14, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Colaborador", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Colaborador.cnpj_empresa",
            //            column: x => x.cnpj_empresa,
            //            principalTable: "Empresa",
            //            principalColumn: "cnpj");
            //        table.ForeignKey(
            //            name: "FK_Colaborador.cpf",
            //            column: x => x.cpf,
            //            principalTable: "Pessoa",
            //            principalColumn: "cpf");
            //        table.ForeignKey(
            //            name: "FK_Colaborador.id_cargo",
            //            column: x => x.id_cargo,
            //            principalTable: "Cargo",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Veiculo",
            //    columns: table => new
            //    {
            //        placa = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: false),
            //        país = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        estado = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
            //        ano = table.Column<short>(type: "smallint", nullable: true),
            //        marca = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
            //        modelo = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
            //        id_cliente = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Veiculo__6432AF2D5F8CD547", x => new { x.placa, x.país });
            //        table.UniqueConstraint("AK_Veiculo_id", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Veiculo.id_cliente",
            //            column: x => x.id_cliente,
            //            principalTable: "Cliente",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Ferramenta",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        nome = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
            //        descricao = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
            //        valor = table.Column<decimal>(type: "decimal(9,4)", nullable: true),
            //        data_de_compra = table.Column<DateTime>(type: "date", nullable: true),
            //        data_de_descarte = table.Column<DateTime>(type: "date", nullable: true),
            //        status = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
            //        id_colaborador = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Ferramenta", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Ferramenta.id_colaborador",
            //            column: x => x.id_colaborador,
            //            principalTable: "Colaborador",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Atendimento",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        id_cliente = table.Column<int>(type: "int", nullable: true),
            //        id_colaborador = table.Column<int>(type: "int", nullable: true),
            //        id_veiculo = table.Column<int>(type: "int", nullable: true),
            //        data = table.Column<DateTime>(type: "date", nullable: false),
            //        data_ultima_alteracao_status = table.Column<DateTime>(type: "date", nullable: true),
            //        descricao_problema = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        status = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
            //        id_conta = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Atendimento", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Atendimento.id_cliente",
            //            column: x => x.id_cliente,
            //            principalTable: "Cliente",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "FK_Atendimento.id_colaborador",
            //            column: x => x.id_colaborador,
            //            principalTable: "Colaborador",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "FK_Atendimento.id_veiculo",
            //            column: x => x.id_veiculo,
            //            principalTable: "Veiculo",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Ordem_de_Servico",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        id_atendimento = table.Column<int>(type: "int", nullable: true),
            //        data = table.Column<DateTime>(type: "date", nullable: false),
            //        data_ultima_alteracao_status = table.Column<DateTime>(type: "date", nullable: true),
            //        motivo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        status = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Ordem_de_Servico", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Ordem_de_Servico.id_atendimento",
            //            column: x => x.id_atendimento,
            //            principalTable: "Atendimento",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Produto_Ordem_de_Servico",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        id_produto = table.Column<int>(type: "int", nullable: true),
            //        id_ordem_servico = table.Column<int>(type: "int", nullable: true),
            //        quantidade = table.Column<short>(type: "smallint", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Produto_Ordem_de_Servico", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Produto_Ordem_de_Servico.id_ordem_servico",
            //            column: x => x.id_ordem_servico,
            //            principalTable: "Ordem_de_Servico",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "FK_Produto_Ordem_de_Servico.id_produto",
            //            column: x => x.id_produto,
            //            principalTable: "Produto",
            //            principalColumn: "id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Servico_Ordem_de_Servico",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        id_servico = table.Column<int>(type: "int", nullable: true),
            //        id_ordem_servico = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Servico_Ordem_de_Servico", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Servico_Ordem_de_Servico.id_ordem_servico",
            //            column: x => x.id_ordem_servico,
            //            principalTable: "Ordem_de_Servico",
            //            principalColumn: "id");
            //        table.ForeignKey(
            //            name: "FK_Servico_Ordem_de_Servico.id_servico",
            //            column: x => x.id_servico,
            //            principalTable: "Servico",
            //            principalColumn: "id");
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Atendimento_id_cliente",
            //    table: "Atendimento",
            //    column: "id_cliente");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Atendimento_id_colaborador",
            //    table: "Atendimento",
            //    column: "id_colaborador");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Atendimento_id_veiculo",
            //    table: "Atendimento",
            //    column: "id_veiculo");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Atendime__3213E83ECF37128A",
            //    table: "Atendimento",
            //    column: "id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Cliente__3213E83E69D0E29A",
            //    table: "Cliente",
            //    column: "id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Cliente__D836E71F87F53EB2",
            //    table: "Cliente",
            //    column: "cpf",
            //    unique: true,
            //    filter: "[cpf] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Colaborador_cnpj_empresa",
            //    table: "Colaborador",
            //    column: "cnpj_empresa");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Colaborador_id_cargo",
            //    table: "Colaborador",
            //    column: "id_cargo");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Colabora__3213E83E38672861",
            //    table: "Colaborador",
            //    column: "id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Colabora__D836E71F0FEE059D",
            //    table: "Colaborador",
            //    column: "cpf",
            //    unique: true,
            //    filter: "[cpf] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Conta_cnpj_recebedor",
            //    table: "Conta",
            //    column: "cnpj_recebedor");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Conta__3213E83EB19ED64D",
            //    table: "Conta",
            //    column: "id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Ferramenta_id_colaborador",
            //    table: "Ferramenta",
            //    column: "id_colaborador");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Ferramen__3213E83E49A210E9",
            //    table: "Ferramenta",
            //    column: "id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Ordem_de_Servico_id_atendimento",
            //    table: "Ordem_de_Servico",
            //    column: "id_atendimento");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Ordem_de__3213E83E8AF8C1A8",
            //    table: "Ordem_de_Servico",
            //    column: "id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Produto_Ordem_de_Servico_id_ordem_servico",
            //    table: "Produto_Ordem_de_Servico",
            //    column: "id_ordem_servico");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Produto_Ordem_de_Servico_id_produto",
            //    table: "Produto_Ordem_de_Servico",
            //    column: "id_produto");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Produto___3213E83E6CB98995",
            //    table: "Produto_Ordem_de_Servico",
            //    column: "id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Servico_Ordem_de_Servico_id_ordem_servico",
            //    table: "Servico_Ordem_de_Servico",
            //    column: "id_ordem_servico");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Servico_Ordem_de_Servico_id_servico",
            //    table: "Servico_Ordem_de_Servico",
            //    column: "id_servico");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Servico___3213E83E1A824DDA",
            //    table: "Servico_Ordem_de_Servico",
            //    column: "id",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Veiculo_id_cliente",
            //    table: "Veiculo",
            //    column: "id_cliente");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__Veiculo__3213E83ED5ABF8C8",
            //    table: "Veiculo",
            //    column: "id",
            //    unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Conta");

            migrationBuilder.DropTable(
                name: "Ferramenta");

            migrationBuilder.DropTable(
                name: "Produto_Ordem_de_Servico");

            migrationBuilder.DropTable(
                name: "Servico_Ordem_de_Servico");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Ordem_de_Servico");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Atendimento");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}

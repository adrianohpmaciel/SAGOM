CREATE TABLE [Pessoa] (
  [cpf] CHAR(11),
  [email] NVARCHAR(256) UNIQUE,
  [nome] VARCHAR(20) NOT NULL,
  [sobrenome] VARCHAR(60) NOT NULL,
  [endereco] VARCHAR(100) NOT NULL,
  [telefone] VARCHAR(15) NOT NULL,
  PRIMARY KEY ([cpf])
);

CREATE TABLE [Cliente] (
  [id] INT IDENTITY(1,1) UNIQUE,
  [cpf] CHAR(11) UNIQUE,
  PRIMARY KEY ([id]),
  CONSTRAINT [FK_Cliente.cpf]
    FOREIGN KEY ([cpf])
      REFERENCES [Pessoa]([cpf])
);

CREATE TABLE [Empresa] (
  [cnpj] CHAR(14),
  [nome_fantasia] VARCHAR(60),
  [endereço] VARCHAR(100),
  [telefone] VARCHAR(30),
  PRIMARY KEY ([cnpj])
);

CREATE TABLE [Cargo] (
  [id] INT IDENTITY(1,1),
  [nome] VARCHAR(30) NOT NULL,
  [descricao] VARCHAR(100),
  PRIMARY KEY ([id])
);

CREATE TABLE [Colaborador] (
  [id] INT IDENTITY(1,1) UNIQUE,
  [cpf] CHAR(11) UNIQUE,
  [id_cargo] INT NOT NULL,
  [salario] DECIMAL(9,4),
  [cnpj_empresa] CHAR(14),
  PRIMARY KEY ([id]),
  CONSTRAINT [FK_Colaborador.cnpj_empresa]
    FOREIGN KEY ([cnpj_empresa])
      REFERENCES [Empresa]([cnpj]),
  CONSTRAINT [FK_Colaborador.id_cargo]
    FOREIGN KEY ([id_cargo])
      REFERENCES [Cargo]([id]),
  CONSTRAINT [FK_Colaborador.cpf]
    FOREIGN KEY ([cpf])
      REFERENCES [Pessoa]([cpf])
);

CREATE TABLE [Veiculo] (
  [id] INT IDENTITY(1,1) UNIQUE,
  [placa] CHAR(10),
  [país] VARCHAR(20),
  [estado] VARCHAR(30),
  [ano] SMALLINT,
  [marca] VARCHAR(30),
  [modelo] VARCHAR(60),
  [id_cliente] INT NOT NULL,
  PRIMARY KEY ([placa], [país]),
  CONSTRAINT [FK_Veiculo.id_cliente]
    FOREIGN KEY ([id_cliente])
      REFERENCES [Cliente]([id])
);

CREATE TABLE [Atendimento] (
  [id] INT IDENTITY(1,1) UNIQUE,
  [id_cliente] INT,
  [id_colaborador] INT,
  [id_veiculo] INT,
  [data] DATE NOT NULL,
  [data_ultima_alteracao_status] DATE,
  [descricao_problema] VARCHAR(MAX),
  [status] VARCHAR(30),
  [id_conta] INT,
  PRIMARY KEY ([id]),
  CONSTRAINT [FK_Atendimento.id_cliente]
    FOREIGN KEY ([id_cliente])
      REFERENCES [Cliente]([id]),
  CONSTRAINT [FK_Atendimento.id_colaborador]
    FOREIGN KEY ([id_colaborador])
      REFERENCES [Colaborador]([id]),
  CONSTRAINT [FK_Atendimento.id_veiculo]
    FOREIGN KEY ([id_veiculo])
      REFERENCES [Veiculo]([id])
);

CREATE TABLE [Ordem_de_Servico] (
  [id] INT IDENTITY(1,1) UNIQUE,
  [id_atendimento] INT,
  [data] DATE NOT NULL,
  [data_ultima_alteracao_status] DATE,
  [motivo] VARCHAR(MAX),
  [status] VARCHAR(30),
  PRIMARY KEY ([id]),
  CONSTRAINT [FK_Ordem_de_Servico.id_atendimento]
    FOREIGN KEY ([id_atendimento])
      REFERENCES [Atendimento]([id])
);

CREATE TABLE [Servico] (
  [id] INT IDENTITY(1,1),
  [nome] VARCHAR(60) NOT NULL,
  [descricao] VARCHAR(120),
  [valor] DECIMAL(9,4) NOT NULL,
  PRIMARY KEY ([id])
);

CREATE TABLE [Servico_Ordem_de_Servico] (
  [id] INT IDENTITY(1,1) UNIQUE,
  [id_servico] INT,
  [id_ordem_servico] INT,
  PRIMARY KEY ([id]),
  CONSTRAINT [FK_Servico_Ordem_de_Servico.id_ordem_servico]
    FOREIGN KEY ([id_ordem_servico])
      REFERENCES [Ordem_de_Servico]([id]),
  CONSTRAINT [FK_Servico_Ordem_de_Servico.id_servico]
    FOREIGN KEY ([id_servico])
      REFERENCES [Servico]([id])
);

CREATE TABLE [Ferramenta] (
  [id] INT IDENTITY(1,1) UNIQUE,
  [nome] VARCHAR(60) NOT NULL,
  [descricao] VARCHAR(120),
  [valor] DECIMAL(9,4),
  [data_de_compra] DATE,
  [data_de_descarte] DATE,
  [status] VARCHAR(30) NOT NULL,
  [id_colaborador] INT,
  PRIMARY KEY ([id]),
  CONSTRAINT [FK_Ferramenta.id_colaborador]
    FOREIGN KEY ([id_colaborador])
      REFERENCES [Colaborador]([id])
);

CREATE TABLE [Conta] (
  [id] INT IDENTITY(1,1) UNIQUE,
  [cnpj_recebedor] CHAR(14) NOT NULL,
  [cnpj_pagante] CHAR(14) ,
  [cpf_pagante] CHAR(11),
  [descricao] VARCHAR(20),
  [valor] DECIMAL(9,4) NOT NULL,
  [data] DATE NOT NULL,
  [data_vencimento] DATE NOT NULL,
  [data_pagamento] DATE,
  [status] VARCHAR(30) NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [FK_Conta.cnpj_recebedor]
    FOREIGN KEY ([cnpj_recebedor])
      REFERENCES [Empresa]([cnpj])
);

CREATE TABLE [Produto] (
  [id] INT IDENTITY(1,1),
  [nome] VARCHAR(60) NOT NULL,
  [descricao] VARCHAR(120),
  [quantidade] INT NOT NULL,
  [valor_Unitario] DECIMAL(9,4) NOT NULL,
  PRIMARY KEY ([id])
);

CREATE TABLE [Produto_Ordem_de_Servico] (
  [id] INT IDENTITY(1,1) UNIQUE,
  [id_produto] INT,
  [id_ordem_servico] INT,
  [quantidade] SMALLINT NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [FK_Produto_Ordem_de_Servico.id_ordem_servico]
    FOREIGN KEY ([id_ordem_servico])
      REFERENCES [Ordem_de_Servico]([id]),
  CONSTRAINT [FK_Produto_Ordem_de_Servico.id_produto]
    FOREIGN KEY ([id_produto])
      REFERENCES [Produto]([id])
);

-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/13/2022 10:53:17
-- Generated from EDMX file: C:\Users\rafae\OneDrive\Ambiente de Trabalho\TESP\2º semestre\DA\Projeto\PSI_DA_PLTV-B\app\Projeto\Projeto\RestGestModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GestaoRestaurantesDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Restaurante'
CREATE TABLE [dbo].[Restaurante] (
    [IdRestaurante] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [MoradaIdMorada] int  NOT NULL
);
GO

-- Creating table 'Morada'
CREATE TABLE [dbo].[Morada] (
    [IdMorada] int IDENTITY(1,1) NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(8)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pessoa'
CREATE TABLE [dbo].[Pessoa] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telemovel] nchar(9)  NOT NULL,
    [MoradaIdMorada] int  NOT NULL
);
GO

-- Creating table 'Pedido'
CREATE TABLE [dbo].[Pedido] (
    [IdPedido] int IDENTITY(1,1) NOT NULL,
    [ValorTotal] float  NOT NULL,
    [EstadoIdEstado] int  NOT NULL,
    [RestauranteIdRestaurante] int  NOT NULL,
    [TrabalhadorIdPessoa] int  NOT NULL,
    [ClienteIdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pagamento'
CREATE TABLE [dbo].[Pagamento] (
    [IdPagamento] int IDENTITY(1,1) NOT NULL,
    [Valor] float  NOT NULL,
    [MetodoPagamentoIdMetodoPagamento] int  NOT NULL,
    [PedidoIdPedido] int  NOT NULL
);
GO

-- Creating table 'MetodoPagamento'
CREATE TABLE [dbo].[MetodoPagamento] (
    [IdMetodoPagamento] int IDENTITY(1,1) NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL,
    [MetodoPagament] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Estado'
CREATE TABLE [dbo].[Estado] (
    [IdEstado] int IDENTITY(1,1) NOT NULL,
    [Estadoo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ItemMenu'
CREATE TABLE [dbo].[ItemMenu] (
    [IdItemMenu] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] nvarchar(max)  NOT NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Preco] float  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL,
    [CategoriaIdCategoria] int  NOT NULL
);
GO

-- Creating table 'Categoria'
CREATE TABLE [dbo].[Categoria] (
    [IdCategoria] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pessoa_Trabalhador'
CREATE TABLE [dbo].[Pessoa_Trabalhador] (
    [Salario] float  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [RestauranteIdRestaurante] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'Pessoa_Cliente'
CREATE TABLE [dbo].[Pessoa_Cliente] (
    [TotalGasto] float  NOT NULL,
    [NumContribuinte] nvarchar(9)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'RestauranteItemMenu'
CREATE TABLE [dbo].[RestauranteItemMenu] (
    [Restaurante_IdRestaurante] int  NOT NULL,
    [ItemMenu_IdItemMenu] int  NOT NULL
);
GO

-- Creating table 'ItemMenuPedido'
CREATE TABLE [dbo].[ItemMenuPedido] (
    [ItemMenu_IdItemMenu] int  NOT NULL,
    [Pedido_IdPedido] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdRestaurante] in table 'Restaurante'
ALTER TABLE [dbo].[Restaurante]
ADD CONSTRAINT [PK_Restaurante]
    PRIMARY KEY CLUSTERED ([IdRestaurante] ASC);
GO

-- Creating primary key on [IdMorada] in table 'Morada'
ALTER TABLE [dbo].[Morada]
ADD CONSTRAINT [PK_Morada]
    PRIMARY KEY CLUSTERED ([IdMorada] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoa'
ALTER TABLE [dbo].[Pessoa]
ADD CONSTRAINT [PK_Pessoa]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPedido] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [PK_Pedido]
    PRIMARY KEY CLUSTERED ([IdPedido] ASC);
GO

-- Creating primary key on [IdPagamento] in table 'Pagamento'
ALTER TABLE [dbo].[Pagamento]
ADD CONSTRAINT [PK_Pagamento]
    PRIMARY KEY CLUSTERED ([IdPagamento] ASC);
GO

-- Creating primary key on [IdMetodoPagamento] in table 'MetodoPagamento'
ALTER TABLE [dbo].[MetodoPagamento]
ADD CONSTRAINT [PK_MetodoPagamento]
    PRIMARY KEY CLUSTERED ([IdMetodoPagamento] ASC);
GO

-- Creating primary key on [IdEstado] in table 'Estado'
ALTER TABLE [dbo].[Estado]
ADD CONSTRAINT [PK_Estado]
    PRIMARY KEY CLUSTERED ([IdEstado] ASC);
GO

-- Creating primary key on [IdItemMenu] in table 'ItemMenu'
ALTER TABLE [dbo].[ItemMenu]
ADD CONSTRAINT [PK_ItemMenu]
    PRIMARY KEY CLUSTERED ([IdItemMenu] ASC);
GO

-- Creating primary key on [IdCategoria] in table 'Categoria'
ALTER TABLE [dbo].[Categoria]
ADD CONSTRAINT [PK_Categoria]
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoa_Trabalhador'
ALTER TABLE [dbo].[Pessoa_Trabalhador]
ADD CONSTRAINT [PK_Pessoa_Trabalhador]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'Pessoa_Cliente'
ALTER TABLE [dbo].[Pessoa_Cliente]
ADD CONSTRAINT [PK_Pessoa_Cliente]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [Restaurante_IdRestaurante], [ItemMenu_IdItemMenu] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [PK_RestauranteItemMenu]
    PRIMARY KEY CLUSTERED ([Restaurante_IdRestaurante], [ItemMenu_IdItemMenu] ASC);
GO

-- Creating primary key on [ItemMenu_IdItemMenu], [Pedido_IdPedido] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [PK_ItemMenuPedido]
    PRIMARY KEY CLUSTERED ([ItemMenu_IdItemMenu], [Pedido_IdPedido] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RestauranteIdRestaurante] in table 'Pessoa_Trabalhador'
ALTER TABLE [dbo].[Pessoa_Trabalhador]
ADD CONSTRAINT [FK_RestauranteTrabalhador]
    FOREIGN KEY ([RestauranteIdRestaurante])
    REFERENCES [dbo].[Restaurante]
        ([IdRestaurante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteTrabalhador'
CREATE INDEX [IX_FK_RestauranteTrabalhador]
ON [dbo].[Pessoa_Trabalhador]
    ([RestauranteIdRestaurante]);
GO

-- Creating foreign key on [Restaurante_IdRestaurante] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_Restaurante]
    FOREIGN KEY ([Restaurante_IdRestaurante])
    REFERENCES [dbo].[Restaurante]
        ([IdRestaurante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenu_IdItemMenu] in table 'RestauranteItemMenu'
ALTER TABLE [dbo].[RestauranteItemMenu]
ADD CONSTRAINT [FK_RestauranteItemMenu_ItemMenu]
    FOREIGN KEY ([ItemMenu_IdItemMenu])
    REFERENCES [dbo].[ItemMenu]
        ([IdItemMenu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteItemMenu_ItemMenu'
CREATE INDEX [IX_FK_RestauranteItemMenu_ItemMenu]
ON [dbo].[RestauranteItemMenu]
    ([ItemMenu_IdItemMenu]);
GO

-- Creating foreign key on [EstadoIdEstado] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_EstadoPedido]
    FOREIGN KEY ([EstadoIdEstado])
    REFERENCES [dbo].[Estado]
        ([IdEstado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoPedido'
CREATE INDEX [IX_FK_EstadoPedido]
ON [dbo].[Pedido]
    ([EstadoIdEstado]);
GO

-- Creating foreign key on [MetodoPagamentoIdMetodoPagamento] in table 'Pagamento'
ALTER TABLE [dbo].[Pagamento]
ADD CONSTRAINT [FK_MetodoPagamentoPagamento]
    FOREIGN KEY ([MetodoPagamentoIdMetodoPagamento])
    REFERENCES [dbo].[MetodoPagamento]
        ([IdMetodoPagamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MetodoPagamentoPagamento'
CREATE INDEX [IX_FK_MetodoPagamentoPagamento]
ON [dbo].[Pagamento]
    ([MetodoPagamentoIdMetodoPagamento]);
GO

-- Creating foreign key on [RestauranteIdRestaurante] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_RestaurantePedido]
    FOREIGN KEY ([RestauranteIdRestaurante])
    REFERENCES [dbo].[Restaurante]
        ([IdRestaurante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantePedido'
CREATE INDEX [IX_FK_RestaurantePedido]
ON [dbo].[Pedido]
    ([RestauranteIdRestaurante]);
GO

-- Creating foreign key on [ItemMenu_IdItemMenu] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_ItemMenu]
    FOREIGN KEY ([ItemMenu_IdItemMenu])
    REFERENCES [dbo].[ItemMenu]
        ([IdItemMenu])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Pedido_IdPedido] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_Pedido]
    FOREIGN KEY ([Pedido_IdPedido])
    REFERENCES [dbo].[Pedido]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuPedido_Pedido'
CREATE INDEX [IX_FK_ItemMenuPedido_Pedido]
ON [dbo].[ItemMenuPedido]
    ([Pedido_IdPedido]);
GO

-- Creating foreign key on [PedidoIdPedido] in table 'Pagamento'
ALTER TABLE [dbo].[Pagamento]
ADD CONSTRAINT [FK_PedidoPagamento]
    FOREIGN KEY ([PedidoIdPedido])
    REFERENCES [dbo].[Pedido]
        ([IdPedido])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoPagamento'
CREATE INDEX [IX_FK_PedidoPagamento]
ON [dbo].[Pagamento]
    ([PedidoIdPedido]);
GO

-- Creating foreign key on [CategoriaIdCategoria] in table 'ItemMenu'
ALTER TABLE [dbo].[ItemMenu]
ADD CONSTRAINT [FK_ItemMenuCategoria]
    FOREIGN KEY ([CategoriaIdCategoria])
    REFERENCES [dbo].[Categoria]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuCategoria'
CREATE INDEX [IX_FK_ItemMenuCategoria]
ON [dbo].[ItemMenu]
    ([CategoriaIdCategoria]);
GO

-- Creating foreign key on [TrabalhadorIdPessoa] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_TrabalhadorPedido]
    FOREIGN KEY ([TrabalhadorIdPessoa])
    REFERENCES [dbo].[Pessoa_Trabalhador]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrabalhadorPedido'
CREATE INDEX [IX_FK_TrabalhadorPedido]
ON [dbo].[Pedido]
    ([TrabalhadorIdPessoa]);
GO

-- Creating foreign key on [ClienteIdPessoa] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_ClientePedido]
    FOREIGN KEY ([ClienteIdPessoa])
    REFERENCES [dbo].[Pessoa_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientePedido'
CREATE INDEX [IX_FK_ClientePedido]
ON [dbo].[Pedido]
    ([ClienteIdPessoa]);
GO

-- Creating foreign key on [MoradaIdMorada] in table 'Pessoa'
ALTER TABLE [dbo].[Pessoa]
ADD CONSTRAINT [FK_MoradaPessoa]
    FOREIGN KEY ([MoradaIdMorada])
    REFERENCES [dbo].[Morada]
        ([IdMorada])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoradaPessoa'
CREATE INDEX [IX_FK_MoradaPessoa]
ON [dbo].[Pessoa]
    ([MoradaIdMorada]);
GO

-- Creating foreign key on [MoradaIdMorada] in table 'Restaurante'
ALTER TABLE [dbo].[Restaurante]
ADD CONSTRAINT [FK_MoradaRestaurante]
    FOREIGN KEY ([MoradaIdMorada])
    REFERENCES [dbo].[Morada]
        ([IdMorada])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoradaRestaurante'
CREATE INDEX [IX_FK_MoradaRestaurante]
ON [dbo].[Restaurante]
    ([MoradaIdMorada]);
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoa_Trabalhador'
ALTER TABLE [dbo].[Pessoa_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoa]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'Pessoa_Cliente'
ALTER TABLE [dbo].[Pessoa_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[Pessoa]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
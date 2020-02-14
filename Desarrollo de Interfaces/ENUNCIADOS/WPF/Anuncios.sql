
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2019 13:25:31
-- Generated from EDMX file: G:\Material Docente\Curso 2017-18\DESARROLLO_INTERFACES\UD 5 WPF\Soluciones\WPFAnuncios\WPFAnuncios\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DaniDB];
GO
IF SCHEMA_ID(N'WPFAnuncios') IS NULL EXECUTE(N'CREATE SCHEMA [WPFAnuncios]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[WPFAnuncios].[FK_Anuncios_Anuncios]', 'F') IS NOT NULL
    ALTER TABLE [WPFAnuncios].[Anuncios] DROP CONSTRAINT [FK_Anuncios_Anuncios];
GO
IF OBJECT_ID(N'[WPFAnuncios].[FK_Anuncios_Categorias]', 'F') IS NOT NULL
    ALTER TABLE [WPFAnuncios].[Anunciantes] DROP CONSTRAINT [FK_Anuncios_Categorias];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[WPFAnuncios].[Anunciantes]', 'U') IS NOT NULL
    DROP TABLE [WPFAnuncios].[Anunciantes];
GO
IF OBJECT_ID(N'[WPFAnuncios].[Anuncios]', 'U') IS NOT NULL
    DROP TABLE [WPFAnuncios].[Anuncios];
GO
IF OBJECT_ID(N'[WPFAnuncios].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [WPFAnuncios].[Categorias];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Anunciantes'
CREATE TABLE [WPFAnuncios].[Anunciantes] (
    [IdAnunciante] int  NOT NULL,
    [IdCategoria] int  NULL,
    [Marca] varchar(25)  NULL,
    [Direccion] varchar(25)  NULL,
    [Telefono] nchar(10)  NULL
);
GO

-- Creating table 'Anuncios'
CREATE TABLE [WPFAnuncios].[Anuncios] (
    [IdAnuncio] int  NOT NULL,
    [IdAnunciante] int  NULL,
    [Slogan] varchar(100)  NULL,
    [Foto] varbinary(max)  NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [WPFAnuncios].[Categorias] (
    [IdCategoria] int  NOT NULL,
    [Nombre] nchar(10)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdAnunciante] in table 'Anunciantes'
ALTER TABLE [WPFAnuncios].[Anunciantes]
ADD CONSTRAINT [PK_Anunciantes]
    PRIMARY KEY CLUSTERED ([IdAnunciante] ASC);
GO

-- Creating primary key on [IdAnuncio] in table 'Anuncios'
ALTER TABLE [WPFAnuncios].[Anuncios]
ADD CONSTRAINT [PK_Anuncios]
    PRIMARY KEY CLUSTERED ([IdAnuncio] ASC);
GO

-- Creating primary key on [IdCategoria] in table 'Categorias'
ALTER TABLE [WPFAnuncios].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([IdCategoria] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdAnunciante] in table 'Anuncios'
ALTER TABLE [WPFAnuncios].[Anuncios]
ADD CONSTRAINT [FK_Anuncios_Anuncios]
    FOREIGN KEY ([IdAnunciante])
    REFERENCES [WPFAnuncios].[Anunciantes]
        ([IdAnunciante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Anuncios_Anuncios'
CREATE INDEX [IX_FK_Anuncios_Anuncios]
ON [WPFAnuncios].[Anuncios]
    ([IdAnunciante]);
GO

-- Creating foreign key on [IdCategoria] in table 'Anunciantes'
ALTER TABLE [WPFAnuncios].[Anunciantes]
ADD CONSTRAINT [FK_Anuncios_Categorias]
    FOREIGN KEY ([IdCategoria])
    REFERENCES [WPFAnuncios].[Categorias]
        ([IdCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Anuncios_Categorias'
CREATE INDEX [IX_FK_Anuncios_Categorias]
ON [WPFAnuncios].[Anunciantes]
    ([IdCategoria]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
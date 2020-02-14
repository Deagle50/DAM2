
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/20/2019 13:41:00
-- Generated from EDMX file: G:\Material Docente\Curso 2017-18\DESARROLLO_INTERFACES\UD 5 WPF\Soluciones\Inmobiliaria\Inmobiliaria\ModeloDatos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DANIDB];
GO
IF SCHEMA_ID(N'WPFInmobiliaria') IS NULL EXECUTE(N'CREATE SCHEMA [WPFInmobiliaria]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[WPFInmobiliaria].[FK_Imagenes_Inmuebles]', 'F') IS NOT NULL
    ALTER TABLE [WPFInmobiliaria].[Imagenes] DROP CONSTRAINT [FK_Imagenes_Inmuebles];
GO
IF OBJECT_ID(N'[WPFInmobiliaria].[FK_Inmuebles_Tipos]', 'F') IS NOT NULL
    ALTER TABLE [WPFInmobiliaria].[Inmuebles] DROP CONSTRAINT [FK_Inmuebles_Tipos];
GO
IF OBJECT_ID(N'[WPFInmobiliaria].[FK_Inmuebles_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [WPFInmobiliaria].[Inmuebles] DROP CONSTRAINT [FK_Inmuebles_Usuarios];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[WPFInmobiliaria].[Imagenes]', 'U') IS NOT NULL
    DROP TABLE [WPFInmobiliaria].[Imagenes];
GO
IF OBJECT_ID(N'[WPFInmobiliaria].[Inmuebles]', 'U') IS NOT NULL
    DROP TABLE [WPFInmobiliaria].[Inmuebles];
GO
IF OBJECT_ID(N'[WPFInmobiliaria].[Tipos]', 'U') IS NOT NULL
    DROP TABLE [WPFInmobiliaria].[Tipos];
GO
IF OBJECT_ID(N'[WPFInmobiliaria].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [WPFInmobiliaria].[Usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Imagenes'
CREATE TABLE [WPFInmobiliaria].[Imagenes] (
    [IdFoto] int  NOT NULL,
    [Foto] varbinary(max)  NULL,
    [Texto] varchar(50)  NULL,
    [IdInmueble] char(5)  NULL
);
GO

-- Creating table 'Inmuebles'
CREATE TABLE [WPFInmobiliaria].[Inmuebles] (
    [Id] char(5)  NOT NULL,
    [Descripcion] varchar(25)  NULL,
    [Superficie] float  NULL,
    [IdUsuario] varchar(10)  NULL,
    [Tipo] int  NULL
);
GO

-- Creating table 'Tipos'
CREATE TABLE [WPFInmobiliaria].[Tipos] (
    [IdTipo] int  NOT NULL,
    [Descripcion] varchar(25)  NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [WPFInmobiliaria].[Usuarios] (
    [Usuario] varchar(10)  NOT NULL,
    [Password] varchar(10)  NULL,
    [Nombre] varchar(25)  NULL,
    [Apellido] varchar(25)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdFoto] in table 'Imagenes'
ALTER TABLE [WPFInmobiliaria].[Imagenes]
ADD CONSTRAINT [PK_Imagenes]
    PRIMARY KEY CLUSTERED ([IdFoto] ASC);
GO

-- Creating primary key on [Id] in table 'Inmuebles'
ALTER TABLE [WPFInmobiliaria].[Inmuebles]
ADD CONSTRAINT [PK_Inmuebles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IdTipo] in table 'Tipos'
ALTER TABLE [WPFInmobiliaria].[Tipos]
ADD CONSTRAINT [PK_Tipos]
    PRIMARY KEY CLUSTERED ([IdTipo] ASC);
GO

-- Creating primary key on [Usuario] in table 'Usuarios'
ALTER TABLE [WPFInmobiliaria].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Usuario] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdInmueble] in table 'Imagenes'
ALTER TABLE [WPFInmobiliaria].[Imagenes]
ADD CONSTRAINT [FK_Imagenes_Inmuebles]
    FOREIGN KEY ([IdInmueble])
    REFERENCES [WPFInmobiliaria].[Inmuebles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Imagenes_Inmuebles'
CREATE INDEX [IX_FK_Imagenes_Inmuebles]
ON [WPFInmobiliaria].[Imagenes]
    ([IdInmueble]);
GO

-- Creating foreign key on [Tipo] in table 'Inmuebles'
ALTER TABLE [WPFInmobiliaria].[Inmuebles]
ADD CONSTRAINT [FK_Inmuebles_Tipos]
    FOREIGN KEY ([Tipo])
    REFERENCES [WPFInmobiliaria].[Tipos]
        ([IdTipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Inmuebles_Tipos'
CREATE INDEX [IX_FK_Inmuebles_Tipos]
ON [WPFInmobiliaria].[Inmuebles]
    ([Tipo]);
GO

-- Creating foreign key on [IdUsuario] in table 'Inmuebles'
ALTER TABLE [WPFInmobiliaria].[Inmuebles]
ADD CONSTRAINT [FK_Inmuebles_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [WPFInmobiliaria].[Usuarios]
        ([Usuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Inmuebles_Usuarios'
CREATE INDEX [IX_FK_Inmuebles_Usuarios]
ON [WPFInmobiliaria].[Inmuebles]
    ([IdUsuario]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
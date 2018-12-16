
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2018 22:32:38
-- Generated from EDMX file: C:\Users\User\Desktop\CaseSystemApp\CaseSystemApp\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CaseSystem];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ServerDataBase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DataBaseSet] DROP CONSTRAINT [FK_ServerDataBase];
GO
IF OBJECT_ID(N'[dbo].[FK_DataBaseTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TableSet] DROP CONSTRAINT [FK_DataBaseTable];
GO
IF OBJECT_ID(N'[dbo].[FK_TableColumn]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColumnSet] DROP CONSTRAINT [FK_TableColumn];
GO
IF OBJECT_ID(N'[dbo].[FK_MaskColumn]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColumnSet] DROP CONSTRAINT [FK_MaskColumn];
GO
IF OBJECT_ID(N'[dbo].[FK_ColumnType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColumnSet] DROP CONSTRAINT [FK_ColumnType];
GO
IF OBJECT_ID(N'[dbo].[FK_ColumnConnection]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionSet] DROP CONSTRAINT [FK_ColumnConnection];
GO
IF OBJECT_ID(N'[dbo].[FK_ConnectionColumn]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConnectionSet] DROP CONSTRAINT [FK_ConnectionColumn];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ServerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServerSet];
GO
IF OBJECT_ID(N'[dbo].[DataBaseSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DataBaseSet];
GO
IF OBJECT_ID(N'[dbo].[TableSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TableSet];
GO
IF OBJECT_ID(N'[dbo].[ColumnSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ColumnSet];
GO
IF OBJECT_ID(N'[dbo].[MaskSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MaskSet];
GO
IF OBJECT_ID(N'[dbo].[TypeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeSet];
GO
IF OBJECT_ID(N'[dbo].[ConnectionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConnectionSet];
GO
IF OBJECT_ID(N'[dbo].[SysDiagramsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SysDiagramsSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ServerSet'
CREATE TABLE [dbo].[ServerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL
);
GO

-- Creating table 'DataBaseSet'
CREATE TABLE [dbo].[DataBaseSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Server_Id] int  NOT NULL
);
GO

-- Creating table 'TableSet'
CREATE TABLE [dbo].[TableSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [DataBase_Id] int  NOT NULL
);
GO

-- Creating table 'ColumnSet'
CREATE TABLE [dbo].[ColumnSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [DefaultValue] bit  NULL,
    [NotNull] nvarchar(max)  NOT NULL,
    [Unique] bit  NULL,
    [Increment] bit  NOT NULL,
    [Key] bit  NOT NULL,
    [Table_Id] int  NOT NULL,
    [Mask_Id] int  NULL,
    [Type_Id] int  NOT NULL
);
GO

-- Creating table 'MaskSet'
CREATE TABLE [dbo].[MaskSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MinValue] int  NULL,
    [MaxValue] int  NULL,
    [StringValue] int  NULL,
    [MaxLenghtValue] nvarchar(max)  NULL
);
GO

-- Creating table 'TypeSet'
CREATE TABLE [dbo].[TypeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [SqlNameType] nvarchar(max)  NULL
);
GO

-- Creating table 'ConnectionSet'
CREATE TABLE [dbo].[ConnectionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [ForeignKeyColumn] int  NULL,
    [PrimaryKeyColumn] int  NULL,
    [Column_Id] int  NOT NULL,
    [Column1_Id] int  NOT NULL
);
GO

-- Creating table 'SysDiagramsSet'
CREATE TABLE [dbo].[SysDiagramsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Principal_id] int  NULL,
    [Version] int  NULL,
    [Definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ServerSet'
ALTER TABLE [dbo].[ServerSet]
ADD CONSTRAINT [PK_ServerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DataBaseSet'
ALTER TABLE [dbo].[DataBaseSet]
ADD CONSTRAINT [PK_DataBaseSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TableSet'
ALTER TABLE [dbo].[TableSet]
ADD CONSTRAINT [PK_TableSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ColumnSet'
ALTER TABLE [dbo].[ColumnSet]
ADD CONSTRAINT [PK_ColumnSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MaskSet'
ALTER TABLE [dbo].[MaskSet]
ADD CONSTRAINT [PK_MaskSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeSet'
ALTER TABLE [dbo].[TypeSet]
ADD CONSTRAINT [PK_TypeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConnectionSet'
ALTER TABLE [dbo].[ConnectionSet]
ADD CONSTRAINT [PK_ConnectionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SysDiagramsSet'
ALTER TABLE [dbo].[SysDiagramsSet]
ADD CONSTRAINT [PK_SysDiagramsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Server_Id] in table 'DataBaseSet'
ALTER TABLE [dbo].[DataBaseSet]
ADD CONSTRAINT [FK_ServerDataBase]
    FOREIGN KEY ([Server_Id])
    REFERENCES [dbo].[ServerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServerDataBase'
CREATE INDEX [IX_FK_ServerDataBase]
ON [dbo].[DataBaseSet]
    ([Server_Id]);
GO

-- Creating foreign key on [DataBase_Id] in table 'TableSet'
ALTER TABLE [dbo].[TableSet]
ADD CONSTRAINT [FK_DataBaseTable]
    FOREIGN KEY ([DataBase_Id])
    REFERENCES [dbo].[DataBaseSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DataBaseTable'
CREATE INDEX [IX_FK_DataBaseTable]
ON [dbo].[TableSet]
    ([DataBase_Id]);
GO

-- Creating foreign key on [Table_Id] in table 'ColumnSet'
ALTER TABLE [dbo].[ColumnSet]
ADD CONSTRAINT [FK_TableColumn]
    FOREIGN KEY ([Table_Id])
    REFERENCES [dbo].[TableSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TableColumn'
CREATE INDEX [IX_FK_TableColumn]
ON [dbo].[ColumnSet]
    ([Table_Id]);
GO

-- Creating foreign key on [Mask_Id] in table 'ColumnSet'
ALTER TABLE [dbo].[ColumnSet]
ADD CONSTRAINT [FK_MaskColumn]
    FOREIGN KEY ([Mask_Id])
    REFERENCES [dbo].[MaskSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaskColumn'
CREATE INDEX [IX_FK_MaskColumn]
ON [dbo].[ColumnSet]
    ([Mask_Id]);
GO

-- Creating foreign key on [Type_Id] in table 'ColumnSet'
ALTER TABLE [dbo].[ColumnSet]
ADD CONSTRAINT [FK_ColumnType]
    FOREIGN KEY ([Type_Id])
    REFERENCES [dbo].[TypeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ColumnType'
CREATE INDEX [IX_FK_ColumnType]
ON [dbo].[ColumnSet]
    ([Type_Id]);
GO

-- Creating foreign key on [Column_Id] in table 'ConnectionSet'
ALTER TABLE [dbo].[ConnectionSet]
ADD CONSTRAINT [FK_ColumnConnection]
    FOREIGN KEY ([Column_Id])
    REFERENCES [dbo].[ColumnSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ColumnConnection'
CREATE INDEX [IX_FK_ColumnConnection]
ON [dbo].[ConnectionSet]
    ([Column_Id]);
GO

-- Creating foreign key on [Column1_Id] in table 'ConnectionSet'
ALTER TABLE [dbo].[ConnectionSet]
ADD CONSTRAINT [FK_ConnectionColumn]
    FOREIGN KEY ([Column1_Id])
    REFERENCES [dbo].[ColumnSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConnectionColumn'
CREATE INDEX [IX_FK_ConnectionColumn]
ON [dbo].[ConnectionSet]
    ([Column1_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
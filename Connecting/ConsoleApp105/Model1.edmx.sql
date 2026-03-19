
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/19/2026 11:48:19
-- Generated from EDMX file: C:\Users\Милена Ангелова\OneDrive\Desktop\clothes\Clothing-Store-System\Connecting\ConsoleApp105\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [drehi];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__ReceiptsP__Produ__2D27B809]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReceiptsProducts] DROP CONSTRAINT [FK__ReceiptsP__Produ__2D27B809];
GO
IF OBJECT_ID(N'[dbo].[FK__ReceiptsP__Recei__2C3393D0]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReceiptsProducts] DROP CONSTRAINT [FK__ReceiptsP__Recei__2C3393D0];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Receipts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Receipts];
GO
IF OBJECT_ID(N'[dbo].[ReceiptsProducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReceiptsProducts];
GO
IF OBJECT_ID(N'[dbo].[StaffInformation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StaffInformation];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProductNumber] int  NOT NULL,
    [ProductType] varchar(50)  NOT NULL,
    [Size] varchar(5)  NOT NULL,
    [Quantity] int  NULL,
    [Price] decimal(18,2)  NULL,
    [Manufacturer] varchar(50)  NULL,
    [Distributor] varchar(50)  NULL,
    [DeliveryDate] datetime  NOT NULL,
    [Gender] char(1)  NOT NULL
);
GO

-- Creating table 'Receipts'
CREATE TABLE [dbo].[Receipts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CompanyName] varchar(80)  NOT NULL,
    [Bulstat] varchar(9)  NOT NULL,
    [TaxRegistryNumber] varchar(8)  NOT NULL
);
GO

-- Creating table 'ReceiptsProducts'
CREATE TABLE [dbo].[ReceiptsProducts] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ReceiptID] int  NULL,
    [ProductID] int  NULL
);
GO

-- Creating table 'StaffInformation'
CREATE TABLE [dbo].[StaffInformation] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FirstName] varchar(30)  NOT NULL,
    [Surname] varchar(30)  NOT NULL,
    [LastName] varchar(30)  NOT NULL,
    [EGN] varchar(10)  NOT NULL,
    [Experience] int  NOT NULL,
    [Position] varchar(50)  NOT NULL,
    [Salary] decimal(18,2)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Receipts'
ALTER TABLE [dbo].[Receipts]
ADD CONSTRAINT [PK_Receipts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ReceiptsProducts'
ALTER TABLE [dbo].[ReceiptsProducts]
ADD CONSTRAINT [PK_ReceiptsProducts]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'StaffInformation'
ALTER TABLE [dbo].[StaffInformation]
ADD CONSTRAINT [PK_StaffInformation]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProductID] in table 'ReceiptsProducts'
ALTER TABLE [dbo].[ReceiptsProducts]
ADD CONSTRAINT [FK__ReceiptsP__Produ__2D27B809]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[Products]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ReceiptsP__Produ__2D27B809'
CREATE INDEX [IX_FK__ReceiptsP__Produ__2D27B809]
ON [dbo].[ReceiptsProducts]
    ([ProductID]);
GO

-- Creating foreign key on [ReceiptID] in table 'ReceiptsProducts'
ALTER TABLE [dbo].[ReceiptsProducts]
ADD CONSTRAINT [FK__ReceiptsP__Recei__2C3393D0]
    FOREIGN KEY ([ReceiptID])
    REFERENCES [dbo].[Receipts]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ReceiptsP__Recei__2C3393D0'
CREATE INDEX [IX_FK__ReceiptsP__Recei__2C3393D0]
ON [dbo].[ReceiptsProducts]
    ([ReceiptID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
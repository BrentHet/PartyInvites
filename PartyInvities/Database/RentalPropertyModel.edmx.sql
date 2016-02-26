
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/25/2016 19:52:16
-- Generated from EDMX file: D:\Data\Work\Learn\PartyInvites\PartyInvities\Database\RentalPropertyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RealEstate];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RentalPropertyPostalAddress]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RentalProperties] DROP CONSTRAINT [FK_RentalPropertyPostalAddress];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[RentalProperties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RentalProperties];
GO
IF OBJECT_ID(N'[dbo].[PostalAddresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PostalAddresses];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RentalProperties'
CREATE TABLE [dbo].[RentalProperties] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [ShortDescription] nvarchar(1024)  NOT NULL,
    [AddressID] smallint  NOT NULL,
    [YearBuilt] smallint  NOT NULL,
    [MonthlyHOAFee] decimal(18,0)  NOT NULL,
    [Building] smallint  NOT NULL,
    [PostalAddress_Id] smallint  NOT NULL
);
GO

-- Creating table 'PostalAddresses'
CREATE TABLE [dbo].[PostalAddresses] (
    [Id] smallint IDENTITY(1,1) NOT NULL,
    [StreetNumberAndName] nvarchar(128)  NOT NULL,
    [Unit] nvarchar(6)  NOT NULL,
    [City] nvarchar(35)  NOT NULL,
    [ZipCode] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'RentalProperties'
ALTER TABLE [dbo].[RentalProperties]
ADD CONSTRAINT [PK_RentalProperties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PostalAddresses'
ALTER TABLE [dbo].[PostalAddresses]
ADD CONSTRAINT [PK_PostalAddresses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PostalAddress_Id] in table 'RentalProperties'
ALTER TABLE [dbo].[RentalProperties]
ADD CONSTRAINT [FK_RentalPropertyPostalAddress]
    FOREIGN KEY ([PostalAddress_Id])
    REFERENCES [dbo].[PostalAddresses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RentalPropertyPostalAddress'
CREATE INDEX [IX_FK_RentalPropertyPostalAddress]
ON [dbo].[RentalProperties]
    ([PostalAddress_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------

-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/15/2020 17:17:27
-- Generated from EDMX file: D:\FIT5120\YourLifeSaver0\YourLifeSaver\Models\quiz.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [quiz];
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

-- Creating table 'quizs'
CREATE TABLE [dbo].[quizs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Result] nvarchar(max)  NOT NULL,
    [Count] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'quizs'
ALTER TABLE [dbo].[quizs]
ADD CONSTRAINT [PK_quizs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
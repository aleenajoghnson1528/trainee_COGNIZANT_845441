
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 12:36:49
-- Generated from EDMX file: D:\aleena\feb17th\exammanagementsystem\exammanagementsystem\modelfirstentityone.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [examination];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_fknew]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_fknew];
GO
IF OBJECT_ID(N'[dbo].[FK_fknewc]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Exams] DROP CONSTRAINT [FK_fknewc];
GO
IF OBJECT_ID(N'[dbo].[FK_fknewcs]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Exams] DROP CONSTRAINT [FK_fknewcs];
GO
IF OBJECT_ID(N'[dbo].[FK_fk]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_fk];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO
IF OBJECT_ID(N'[dbo].[Schools]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schools];
GO
IF OBJECT_ID(N'[dbo].[Course_offering]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Course_offering];
GO
IF OBJECT_ID(N'[dbo].[Exams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Exams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Sid] int IDENTITY(1,1) NOT NULL,
    [Sname] nvarchar(max)  NOT NULL,
    [school_id] int  NOT NULL,
    [Course_id] int  NOT NULL
);
GO

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [School_id] int IDENTITY(1,1) NOT NULL,
    [School_name] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Course_offering'
CREATE TABLE [dbo].[Course_offering] (
    [Course_id] int IDENTITY(1,1) NOT NULL,
    [semester] int  NOT NULL,
    [year] datetime  NOT NULL,
    [room] int  NOT NULL,
    [Cname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Exams'
CREATE TABLE [dbo].[Exams] (
    [Eid] int IDENTITY(1,1) NOT NULL,
    [Ename] nvarchar(max)  NOT NULL,
    [Place] nvarchar(max)  NOT NULL,
    [Course_id] int  NOT NULL,
    [Exam_date] datetime  NOT NULL,
    [Sid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Sid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Sid] ASC);
GO

-- Creating primary key on [School_id] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([School_id] ASC);
GO

-- Creating primary key on [Course_id] in table 'Course_offering'
ALTER TABLE [dbo].[Course_offering]
ADD CONSTRAINT [PK_Course_offering]
    PRIMARY KEY CLUSTERED ([Course_id] ASC);
GO

-- Creating primary key on [Eid] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [PK_Exams]
    PRIMARY KEY CLUSTERED ([Eid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Course_id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_fknew]
    FOREIGN KEY ([Course_id])
    REFERENCES [dbo].[Course_offering]
        ([Course_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fknew'
CREATE INDEX [IX_FK_fknew]
ON [dbo].[Students]
    ([Course_id]);
GO

-- Creating foreign key on [Course_id] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [FK_fknewc]
    FOREIGN KEY ([Course_id])
    REFERENCES [dbo].[Course_offering]
        ([Course_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fknewc'
CREATE INDEX [IX_FK_fknewc]
ON [dbo].[Exams]
    ([Course_id]);
GO

-- Creating foreign key on [Sid] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [FK_fknewcs]
    FOREIGN KEY ([Sid])
    REFERENCES [dbo].[Students]
        ([Sid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fknewcs'
CREATE INDEX [IX_FK_fknewcs]
ON [dbo].[Exams]
    ([Sid]);
GO

-- Creating foreign key on [school_id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_fk]
    FOREIGN KEY ([school_id])
    REFERENCES [dbo].[Schools]
        ([School_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_fk'
CREATE INDEX [IX_FK_fk]
ON [dbo].[Students]
    ([school_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
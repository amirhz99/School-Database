
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2019 14:12:56
-- Generated from EDMX file: C:\Users\Sepehr\Desktop\SCHOOL_DATABASE\SCHOOL_DATABASE\UniversityModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [UniversityDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DepartmentCourse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Courses] DROP CONSTRAINT [FK_DepartmentCourse];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartmentTeacher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherSet] DROP CONSTRAINT [FK_DepartmentTeacher];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartmentStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_DepartmentStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_TeacherCourse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Courses] DROP CONSTRAINT [FK_TeacherCourse];
GO
IF OBJECT_ID(N'[dbo].[FK_TakesStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_TakesStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_TakesCourse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CourseSet] DROP CONSTRAINT [FK_TakesCourse];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseTeacher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeacherSet] DROP CONSTRAINT [FK_CourseTeacher];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseStudentStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_CourseStudentStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseDepartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DepartmentSet] DROP CONSTRAINT [FK_CourseDepartment];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO
IF OBJECT_ID(N'[dbo].[Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO
IF OBJECT_ID(N'[dbo].[TeacherSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeacherSet];
GO
IF OBJECT_ID(N'[dbo].[DepartmentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DepartmentSet];
GO
IF OBJECT_ID(N'[dbo].[CourseSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CourseSet];
GO
IF OBJECT_ID(N'[dbo].[TakesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TakesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int  NOT NULL,
    [Password] nvarchar(50)  NULL,
    [Name] nvarchar(max)  NULL,
    [Average] int  NULL,
    [PassUnit] int  NULL,
    [DeptName] nvarchar(max)  NOT NULL,
    [Department_Id] int  NOT NULL,
    [Takes_StudentId] int  NOT NULL,
    [CourseStudent_Id] int  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Id] int  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Unit] int  NULL,
    [Capacity] int  NULL,
    [Status] nvarchar(max)  NULL,
    [Student] int  NULL,
    [Semester] int  NULL,
    [TeacherId] nvarchar(max)  NOT NULL,
    [DeptName] nvarchar(max)  NOT NULL,
    [Department_Id] int  NOT NULL,
    [Teacher_Id] int  NOT NULL
);
GO

-- Creating table 'TeacherSet'
CREATE TABLE [dbo].[TeacherSet] (
    [Id] int  NOT NULL,
    [Password] nvarchar(50)  NULL,
    [Name] nvarchar(max)  NULL,
    [DeptName] int  NULL,
    [Department_Id] int  NOT NULL,
    [Course1_Id] int  NOT NULL
);
GO

-- Creating table 'DepartmentSet'
CREATE TABLE [dbo].[DepartmentSet] (
    [Id] int  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Course1_Id] int  NOT NULL
);
GO

-- Creating table 'CourseSet'
CREATE TABLE [dbo].[CourseSet] (
    [Id] int  NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Unit] int  NULL,
    [Capacity] int  NULL,
    [Status] nvarchar(max)  NULL,
    [Semester] int  NULL,
    [TeacherId] nvarchar(max)  NOT NULL,
    [DeptName] nvarchar(max)  NOT NULL,
    [Takes_StudentId] int  NOT NULL
);
GO

-- Creating table 'TakesSet'
CREATE TABLE [dbo].[TakesSet] (
    [StudentId] int  NOT NULL,
    [CourseId] nvarchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TeacherSet'
ALTER TABLE [dbo].[TeacherSet]
ADD CONSTRAINT [PK_TeacherSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DepartmentSet'
ALTER TABLE [dbo].[DepartmentSet]
ADD CONSTRAINT [PK_DepartmentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CourseSet'
ALTER TABLE [dbo].[CourseSet]
ADD CONSTRAINT [PK_CourseSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [StudentId] in table 'TakesSet'
ALTER TABLE [dbo].[TakesSet]
ADD CONSTRAINT [PK_TakesSet]
    PRIMARY KEY CLUSTERED ([StudentId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Department_Id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_DepartmentCourse]
    FOREIGN KEY ([Department_Id])
    REFERENCES [dbo].[DepartmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentCourse'
CREATE INDEX [IX_FK_DepartmentCourse]
ON [dbo].[Courses]
    ([Department_Id]);
GO

-- Creating foreign key on [Department_Id] in table 'TeacherSet'
ALTER TABLE [dbo].[TeacherSet]
ADD CONSTRAINT [FK_DepartmentTeacher]
    FOREIGN KEY ([Department_Id])
    REFERENCES [dbo].[DepartmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentTeacher'
CREATE INDEX [IX_FK_DepartmentTeacher]
ON [dbo].[TeacherSet]
    ([Department_Id]);
GO

-- Creating foreign key on [Department_Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_DepartmentStudent]
    FOREIGN KEY ([Department_Id])
    REFERENCES [dbo].[DepartmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentStudent'
CREATE INDEX [IX_FK_DepartmentStudent]
ON [dbo].[Students]
    ([Department_Id]);
GO

-- Creating foreign key on [Teacher_Id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_TeacherCourse]
    FOREIGN KEY ([Teacher_Id])
    REFERENCES [dbo].[TeacherSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeacherCourse'
CREATE INDEX [IX_FK_TeacherCourse]
ON [dbo].[Courses]
    ([Teacher_Id]);
GO

-- Creating foreign key on [Takes_StudentId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_TakesStudent]
    FOREIGN KEY ([Takes_StudentId])
    REFERENCES [dbo].[TakesSet]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TakesStudent'
CREATE INDEX [IX_FK_TakesStudent]
ON [dbo].[Students]
    ([Takes_StudentId]);
GO

-- Creating foreign key on [Takes_StudentId] in table 'CourseSet'
ALTER TABLE [dbo].[CourseSet]
ADD CONSTRAINT [FK_TakesCourse]
    FOREIGN KEY ([Takes_StudentId])
    REFERENCES [dbo].[TakesSet]
        ([StudentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TakesCourse'
CREATE INDEX [IX_FK_TakesCourse]
ON [dbo].[CourseSet]
    ([Takes_StudentId]);
GO

-- Creating foreign key on [Course1_Id] in table 'TeacherSet'
ALTER TABLE [dbo].[TeacherSet]
ADD CONSTRAINT [FK_CourseTeacher]
    FOREIGN KEY ([Course1_Id])
    REFERENCES [dbo].[CourseSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseTeacher'
CREATE INDEX [IX_FK_CourseTeacher]
ON [dbo].[TeacherSet]
    ([Course1_Id]);
GO

-- Creating foreign key on [CourseStudent_Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_CourseStudentStudent]
    FOREIGN KEY ([CourseStudent_Id])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseStudentStudent'
CREATE INDEX [IX_FK_CourseStudentStudent]
ON [dbo].[Students]
    ([CourseStudent_Id]);
GO

-- Creating foreign key on [Course1_Id] in table 'DepartmentSet'
ALTER TABLE [dbo].[DepartmentSet]
ADD CONSTRAINT [FK_CourseDepartment]
    FOREIGN KEY ([Course1_Id])
    REFERENCES [dbo].[CourseSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseDepartment'
CREATE INDEX [IX_FK_CourseDepartment]
ON [dbo].[DepartmentSet]
    ([Course1_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
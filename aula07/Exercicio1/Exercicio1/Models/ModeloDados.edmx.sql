
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/02/2021 00:13:30
-- Generated from EDMX file: C:\Users\leo_n\source\LP4EL-Exercicios\aula07\Exercicio1\Exercicio1\Models\ModeloDados.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ConsultorioDB];
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

-- Creating table 'Medico'
CREATE TABLE [dbo].[Medico] (
    [IdMedico] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CRM] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [IdEspecialidade] int  NOT NULL
);
GO

-- Creating table 'Especialidade'
CREATE TABLE [dbo].[Especialidade] (
    [IdEspecialidade] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Consulta'
CREATE TABLE [dbo].[Consulta] (
    [IdMedico] int  NOT NULL,
    [IdPaciente] int  NOT NULL,
    [Dia] datetime  NOT NULL,
    [Hora] time  NOT NULL
);
GO

-- Creating table 'Paciente'
CREATE TABLE [dbo].[Paciente] (
    [IdPaciente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CPF] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Deficiente] bit  NOT NULL,
    [DataNascimento] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdMedico] in table 'Medico'
ALTER TABLE [dbo].[Medico]
ADD CONSTRAINT [PK_Medico]
    PRIMARY KEY CLUSTERED ([IdMedico] ASC);
GO

-- Creating primary key on [IdEspecialidade] in table 'Especialidade'
ALTER TABLE [dbo].[Especialidade]
ADD CONSTRAINT [PK_Especialidade]
    PRIMARY KEY CLUSTERED ([IdEspecialidade] ASC);
GO

-- Creating primary key on [IdMedico], [IdPaciente] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [PK_Consulta]
    PRIMARY KEY CLUSTERED ([IdMedico], [IdPaciente] ASC);
GO

-- Creating primary key on [IdPaciente] in table 'Paciente'
ALTER TABLE [dbo].[Paciente]
ADD CONSTRAINT [PK_Paciente]
    PRIMARY KEY CLUSTERED ([IdPaciente] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEspecialidade] in table 'Medico'
ALTER TABLE [dbo].[Medico]
ADD CONSTRAINT [FK_MedicoEspecialidade]
    FOREIGN KEY ([IdEspecialidade])
    REFERENCES [dbo].[Especialidade]
        ([IdEspecialidade])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedicoEspecialidade'
CREATE INDEX [IX_FK_MedicoEspecialidade]
ON [dbo].[Medico]
    ([IdEspecialidade]);
GO

-- Creating foreign key on [IdMedico] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_MedicoConsulta]
    FOREIGN KEY ([IdMedico])
    REFERENCES [dbo].[Medico]
        ([IdMedico])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPaciente] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_PacienteConsulta]
    FOREIGN KEY ([IdPaciente])
    REFERENCES [dbo].[Paciente]
        ([IdPaciente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteConsulta'
CREATE INDEX [IX_FK_PacienteConsulta]
ON [dbo].[Consulta]
    ([IdPaciente]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
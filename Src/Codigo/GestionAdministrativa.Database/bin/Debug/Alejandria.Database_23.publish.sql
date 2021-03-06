﻿/*
Deployment script for Alejandria.Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Alejandria.Database"
:setvar DefaultFilePrefix "Alejandria.Database"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [dbo].[Cajas]...';


GO
CREATE TABLE [dbo].[Cajas] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [SucursalId]             INT              NOT NULL,
    [OperadorId]             UNIQUEIDENTIFIER NULL,
    [Fecha]                  DATETIME         NOT NULL,
    [FCierre]                DATETIME         NULL,
    [Inicio]                 REAL             NULL,
    [Ingresos]               REAL             NULL,
    [Egresos]                REAL             NULL,
    [Saldo]                  REAL             NULL,
    [Cheques]                REAL             NULL,
    [Bonos]                  REAL             NULL,
    [PcAlta]                 NVARCHAR (20)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [SucursalAltaId]         INT              NULL,
    [FechaModificacion]      DATETIME         NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    [SucursalModificacionId] INT              NULL,
    CONSTRAINT [PK_Cajas] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[FK_Cajas_Operador]...';


GO
ALTER TABLE [dbo].[Cajas] WITH NOCHECK
    ADD CONSTRAINT [FK_Cajas_Operador] FOREIGN KEY ([OperadorId]) REFERENCES [dbo].[Operadores] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Cajas_OperadorAlta]...';


GO
ALTER TABLE [dbo].[Cajas] WITH NOCHECK
    ADD CONSTRAINT [FK_Cajas_OperadorAlta] FOREIGN KEY ([OperadorAltaId]) REFERENCES [dbo].[Operadores] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Cajas_OperadorModificacion]...';


GO
ALTER TABLE [dbo].[Cajas] WITH NOCHECK
    ADD CONSTRAINT [FK_Cajas_OperadorModificacion] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [dbo].[Operadores] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Cajas_Sucursal]...';


GO
ALTER TABLE [dbo].[Cajas] WITH NOCHECK
    ADD CONSTRAINT [FK_Cajas_Sucursal] FOREIGN KEY ([SucursalId]) REFERENCES [dbo].[Sucursales] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Cajas_SucursalAlta]...';


GO
ALTER TABLE [dbo].[Cajas] WITH NOCHECK
    ADD CONSTRAINT [FK_Cajas_SucursalAlta] FOREIGN KEY ([SucursalAltaId]) REFERENCES [dbo].[Sucursales] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Cajas_SucursalModificacion]...';


GO
ALTER TABLE [dbo].[Cajas] WITH NOCHECK
    ADD CONSTRAINT [FK_Cajas_SucursalModificacion] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [dbo].[Sucursales] ([Id]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Cajas] WITH CHECK CHECK CONSTRAINT [FK_Cajas_Operador];

ALTER TABLE [dbo].[Cajas] WITH CHECK CHECK CONSTRAINT [FK_Cajas_OperadorAlta];

ALTER TABLE [dbo].[Cajas] WITH CHECK CHECK CONSTRAINT [FK_Cajas_OperadorModificacion];

ALTER TABLE [dbo].[Cajas] WITH CHECK CHECK CONSTRAINT [FK_Cajas_Sucursal];

ALTER TABLE [dbo].[Cajas] WITH CHECK CHECK CONSTRAINT [FK_Cajas_SucursalAlta];

ALTER TABLE [dbo].[Cajas] WITH CHECK CHECK CONSTRAINT [FK_Cajas_SucursalModificacion];


GO
PRINT N'Update complete.';


GO

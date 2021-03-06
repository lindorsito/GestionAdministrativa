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
PRINT N'Creating [dbo].[ClientesCuentasCorriente]...';


GO
CREATE TABLE [dbo].[ClientesCuentasCorriente] (
    [Id]                     UNIQUEIDENTIFIER NOT NULL,
    [VentaId]                UNIQUEIDENTIFIER NOT NULL,
    [ClienteId]              UNIQUEIDENTIFIER NULL,
    [Cuota]                  TINYINT          NOT NULL,
    [Fecha]                  DATETIME         NULL,
    [FechaVencimiento]       DATETIME         NULL,
    [FechaUltimoPago]        DATETIME         NULL,
    [Importe]                REAL             NULL,
    [Pagado]                 REAL             NULL,
    [FechaGeneracion]        DATETIME         NULL,
    [Observaciones]          VARCHAR (255)    NULL,
    [FechaAlta]              DATETIME         NULL,
    [SucursalAltaId]         INT              NULL,
    [OperadorAltaId]         UNIQUEIDENTIFIER NULL,
    [FechaModificacion]      DATETIME         NULL,
    [SucursalModificacionId] INT              NULL,
    [OperadorModificacionId] UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_ClientesCuentasCorriente] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[FK_ClientesCuentasCorriente_Clientes]...';


GO
ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH NOCHECK
    ADD CONSTRAINT [FK_ClientesCuentasCorriente_Clientes] FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ClientesCuentasCorriente_SucursalAltaId]...';


GO
ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH NOCHECK
    ADD CONSTRAINT [FK_ClientesCuentasCorriente_SucursalAltaId] FOREIGN KEY ([SucursalAltaId]) REFERENCES [dbo].[Sucursales] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ClientesCuentasCorriente_OperadorAltaId]...';


GO
ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH NOCHECK
    ADD CONSTRAINT [FK_ClientesCuentasCorriente_OperadorAltaId] FOREIGN KEY ([OperadorAltaId]) REFERENCES [dbo].[Operadores] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ClientesCuentasCorriente_SucursalModificacionId]...';


GO
ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH NOCHECK
    ADD CONSTRAINT [FK_ClientesCuentasCorriente_SucursalModificacionId] FOREIGN KEY ([SucursalModificacionId]) REFERENCES [dbo].[Sucursales] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ClientesCuentasCorriente_OperadorModificacionId]...';


GO
ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH NOCHECK
    ADD CONSTRAINT [FK_ClientesCuentasCorriente_OperadorModificacionId] FOREIGN KEY ([OperadorModificacionId]) REFERENCES [dbo].[Operadores] ([Id]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH CHECK CHECK CONSTRAINT [FK_ClientesCuentasCorriente_Clientes];

ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH CHECK CHECK CONSTRAINT [FK_ClientesCuentasCorriente_SucursalAltaId];

ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH CHECK CHECK CONSTRAINT [FK_ClientesCuentasCorriente_OperadorAltaId];

ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH CHECK CHECK CONSTRAINT [FK_ClientesCuentasCorriente_SucursalModificacionId];

ALTER TABLE [dbo].[ClientesCuentasCorriente] WITH CHECK CHECK CONSTRAINT [FK_ClientesCuentasCorriente_OperadorModificacionId];


GO
PRINT N'Update complete.';


GO

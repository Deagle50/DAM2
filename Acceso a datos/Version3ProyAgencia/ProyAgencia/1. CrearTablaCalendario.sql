USE [PRU_IgnacioGonzalo]
GO
CREATE SCHEMA AGENCIA
GO

CREATE TABLE AGENCIA.[Calendario](
	[agno] [smallint] NULL,
	[diaAgno] [smallint] NULL,
	[diaMes] [tinyint] NULL,
	[mes] [tinyint] NULL,
	[diaSemana] [tinyint] NULL,
	[nombreDia] [varchar](10) NULL,
	[nombreMes] [varchar](10) NULL,
	[festivo] [bit] NULL,
	[DescFestivo] [varchar](30) NULL
) ON [PRIMARY]
GO



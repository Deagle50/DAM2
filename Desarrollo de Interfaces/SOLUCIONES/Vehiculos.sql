USE [DaniDB]
GO
/****** Object:  Table [GUI1].[Inspecciones]    Script Date: 28/11/2019 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GUI1].[Inspecciones](
	[IdRevision] [int] NOT NULL,
	[IdVehiculo] [int] NOT NULL,
	[Fecha] [date] NULL,
	[Realizada] [bit] NULL,
 CONSTRAINT [PK_Inspecciones] PRIMARY KEY CLUSTERED 
(
	[IdRevision] ASC,
	[IdVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GUI1].[Vehiculos]    Script Date: 28/11/2019 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GUI1].[Vehiculos](
	[IdVehiculo] [int] NOT NULL,
	[Descripcion] [varchar](25) NULL,
	[Antelacion] [int] NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[IdVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [GUI1].[Inspecciones]  WITH CHECK ADD  CONSTRAINT [FK_Inspecciones_Inspecciones1] FOREIGN KEY([IdVehiculo])
REFERENCES [GUI1].[Vehiculos] ([IdVehiculo])
GO
ALTER TABLE [GUI1].[Inspecciones] CHECK CONSTRAINT [FK_Inspecciones_Inspecciones1]
GO

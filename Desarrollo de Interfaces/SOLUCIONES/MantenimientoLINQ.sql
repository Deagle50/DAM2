USE [DaniDB]
GO
/****** Object:  Table [Mantenimiento].[Equipos]    Script Date: 13/12/2019 11:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Mantenimiento].[Equipos](
	[CodInstalacion] [nvarchar](4) NULL,
	[Procesador] [nvarchar](15) NOT NULL,
	[Velocidad] [smallint] NULL,
	[CDROM] [tinyint] NULL,
	[Memoria] [smallint] NOT NULL,
	[TarjetaRed] [nvarchar](15) NULL,
	[DiscoDuro] [real] NOT NULL,
	[Uso] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Mantenimiento].[Instalaciones]    Script Date: 13/12/2019 11:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Mantenimiento].[Instalaciones](
	[CodInstalacion] [nvarchar](4) NULL,
	[CodEquipo] [nvarchar](4) NOT NULL,
	[CodSoftware] [nvarchar](4) NOT NULL,
	[FechaInstalacion] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Mantenimiento].[Software]    Script Date: 13/12/2019 11:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Mantenimiento].[Software](
	[CodSoftware] [nvarchar](4) NULL,
	[Nombre] [nvarchar](15) NOT NULL,
	[MemoriaRequerida] [smallint] NULL,
	[ProcesadorRequerido] [smallint] NULL,
	[DiscoRequerido] [smallint] NULL,
	[Version] [nvarchar](4) NOT NULL,
	[Distribuidor] [nvarchar](15) NOT NULL,
	[Precio] [money] NULL,
	[Categoria] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Mantenimiento].[Usuarios]    Script Date: 13/12/2019 11:54:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Mantenimiento].[Usuarios](
	[CodUsuario] [nvarchar](4) NULL,
	[Nombre] [nvarchar](15) NOT NULL,
	[Apellido] [nvarchar](15) NOT NULL,
	[Telefono] [nvarchar](9) NOT NULL,
	[Direccion] [nvarchar](25) NULL,
	[CodEquipo] [nvarchar](4) NOT NULL
) ON [PRIMARY]
GO
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0001', N'pentium III', 400, 40, 64, N'Ethernet 10 Mb', 6.2, 1)
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0002', N'pentium II', 266, 30, 16, N'Pnp Isa  100 Mb', 4, 0)
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0003', N'PENTIUM', 120, 8, 16, NULL, 1.2, 0)
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0004', N'INTEL 4086 DX', 66, 4, 8, NULL, 1.2, 0)
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0005', N'PENTIUM III', 400, 40, 128, N'Ethernet 10 Mb', 13, 1)
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0006', N'PENTIUM II', 266, 30, 48, N'Pnp Isa 100 Mb', 13, 1)
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0007', N'PENTIUM III', 500, 30, 256, N'Pnp Isa 100 Mb', 13, 1)
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0008', N'PENTIUM', 133, 8, 16, N'Ethernet 10 Mb', 1, 0)
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0009', N'INTEL 486 DX', 66, 8, 8, NULL, 1, 0)
INSERT [Mantenimiento].[Equipos] ([CodInstalacion], [Procesador], [Velocidad], [CDROM], [Memoria], [TarjetaRed], [DiscoDuro], [Uso]) VALUES (N'0010', N'PENTIUM III', 450, 6, 128, N'Ethernet 10 Mb', 13, 1)
INSERT [Mantenimiento].[Software] ([CodSoftware], [Nombre], [MemoriaRequerida], [ProcesadorRequerido], [DiscoRequerido], [Version], [Distribuidor], [Precio], [Categoria]) VALUES (N'0001', N'office', 16, 40, 250, N'97', N'Microsoft', 59000.0000, 0)
INSERT [Mantenimiento].[Software] ([CodSoftware], [Nombre], [MemoriaRequerida], [ProcesadorRequerido], [DiscoRequerido], [Version], [Distribuidor], [Precio], [Categoria]) VALUES (N'0002', N'visual foxpro', 32, 90, 180, N'5.0', N'microsoft', 120000.0000, 0)
INSERT [Mantenimiento].[Software] ([CodSoftware], [Nombre], [MemoriaRequerida], [ProcesadorRequerido], [DiscoRequerido], [Version], [Distribuidor], [Precio], [Categoria]) VALUES (N'0003', N'Netscape', 8, 40, 50, N'5.0', N'Netscape', 7500.0000, 0)
INSERT [Mantenimiento].[Software] ([CodSoftware], [Nombre], [MemoriaRequerida], [ProcesadorRequerido], [DiscoRequerido], [Version], [Distribuidor], [Precio], [Categoria]) VALUES (N'0004', N'WINDOWS', 16, 66, 150, N'98', N'MICROSOFT', 18000.0000, 1)
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0001', N'agustin', N'maldonado', N'943292880', N'Av. José Elosegi, 10', N'0001')
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0002', N'ANTXON', N'SARRIEGI', N'943210107', N'Zubieta, 12', N'0001')
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0003', N'jon', N'arizkorreta', N'943459898', N'Zabaleta,16', N'0003')
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0004', N'ander', N'bengoetxea', N'943390665', N'Julio Urkijo, 19', N'0003')
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0005', N'miguel', N'del río', N'943424140', N'Prim,12', N'0006')
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0006', N'usoa', N'alvarez', N'943353435', N'Oleta, 9', N'0006')
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0007', N'María', N'gómez', N'943454545', N'Easo,14', N'0006')
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0008', N'ane', N'garciandia', N'943393231', N'Larratxo,2', N'0006')
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0009', N'joseba', N'etxeberria', N'943151515', N'Pío Baroja, 10', N'0003')
INSERT [Mantenimiento].[Usuarios] ([CodUsuario], [Nombre], [Apellido], [Telefono], [Direccion], [CodEquipo]) VALUES (N'0010', N'martín', N'mitxelena', N'943565455', N'Viteri,15', N'0001')

USE [DaniDB]
GO
/****** Object:  Table [GUI1].[Documentos]    Script Date: 28/11/2019 18:06:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GUI1].[Documentos](
	[IdDocumento] [int] NOT NULL,
	[Titulo] [varchar](25) NULL,
	[FechaCreacion] [date] NULL,
 CONSTRAINT [PK_GUI1.Documentos] PRIMARY KEY CLUSTERED 
(
	[IdDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [GUI1].[Revisiones]    Script Date: 28/11/2019 18:06:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GUI1].[Revisiones](
	[IdDocumento] [int] NOT NULL,
	[NumRevision] [int] NOT NULL,
	[FechaRevision] [date] NULL,
	[Aprobada] [bit] NULL,
 CONSTRAINT [PK_Revisiones] PRIMARY KEY CLUSTERED 
(
	[IdDocumento] ASC,
	[NumRevision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [GUI1].[Revisiones]  WITH CHECK ADD  CONSTRAINT [FK_Revisiones_Documentos] FOREIGN KEY([IdDocumento])
REFERENCES [GUI1].[Documentos] ([IdDocumento])
GO
ALTER TABLE [GUI1].[Revisiones] CHECK CONSTRAINT [FK_Revisiones_Documentos]
GO

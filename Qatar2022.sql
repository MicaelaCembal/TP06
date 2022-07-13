USE [Qatar2022]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 7/7/2022 13:53:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[IdEquipo] [int] NOT NULL,
	[Nombre] [nchar](10) NULL,
	[Escudo] [varchar](200) NULL,
	[Camiseta] [varchar](200) NULL,
	[Continente] [varchar](50) NULL,
	[CopasGanadas] [int] NULL,
 CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED 
(
	[IdEquipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 7/7/2022 13:53:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[IdJugador] [int] NOT NULL,
	[IdEquipo] [int] NOT NULL,
	[Nombre] [varchar](100) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Foto] [varchar](200) NULL,
	[EquipoActual] [varchar](50) NULL,
 CONSTRAINT [PK_Jugadores] PRIMARY KEY CLUSTERED 
(
	[IdJugador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

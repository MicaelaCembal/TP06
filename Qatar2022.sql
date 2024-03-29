USE [Qatar2022]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 11/8/2022 15:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[IdEquipo] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Jugadores]    Script Date: 11/8/2022 15:39:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[IdJugador] [int] IDENTITY(1,1) NOT NULL,
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
SET IDENTITY_INSERT [dbo].[Equipos] ON 

INSERT [dbo].[Equipos] ([IdEquipo], [Nombre], [Escudo], [Camiseta], [Continente], [CopasGanadas]) VALUES (1, N'Argentina ', N'Escudo1.png', N'Camiseta1.png', N'America', 2)
INSERT [dbo].[Equipos] ([IdEquipo], [Nombre], [Escudo], [Camiseta], [Continente], [CopasGanadas]) VALUES (2, N'Brasil    ', N'Escudo2.png', N'Camiseta2.png', N'America', 5)
INSERT [dbo].[Equipos] ([IdEquipo], [Nombre], [Escudo], [Camiseta], [Continente], [CopasGanadas]) VALUES (3, N'México    ', N'Escudo3.png', N'Camiseta3.png', N'America', 1)
INSERT [dbo].[Equipos] ([IdEquipo], [Nombre], [Escudo], [Camiseta], [Continente], [CopasGanadas]) VALUES (7, N'Francia   ', N'Escudo4.png', N'Camiseta4.png', N'Europa', 2)
INSERT [dbo].[Equipos] ([IdEquipo], [Nombre], [Escudo], [Camiseta], [Continente], [CopasGanadas]) VALUES (8, N'Italia    ', N'Escudo5.png', N'Camiseta5.png', N'Europa', 4)
INSERT [dbo].[Equipos] ([IdEquipo], [Nombre], [Escudo], [Camiseta], [Continente], [CopasGanadas]) VALUES (9, N'Alemania  ', N'Escudo6.png', N'Camiseta6.png', N'Europa', 4)
SET IDENTITY_INSERT [dbo].[Equipos] OFF
GO

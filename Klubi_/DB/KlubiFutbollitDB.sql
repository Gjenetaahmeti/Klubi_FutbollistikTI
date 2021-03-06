USE [master]
GO
/****** Object:  Database [Gjeneta]    Script Date: 5/6/2020 6:03:20 PM ******/
CREATE DATABASE [Gjeneta]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gjeneta', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Gjeneta.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Gjeneta_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Gjeneta_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Gjeneta] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gjeneta].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gjeneta] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gjeneta] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gjeneta] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gjeneta] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gjeneta] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gjeneta] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Gjeneta] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gjeneta] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gjeneta] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gjeneta] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gjeneta] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gjeneta] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gjeneta] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gjeneta] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gjeneta] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Gjeneta] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gjeneta] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gjeneta] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gjeneta] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gjeneta] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gjeneta] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gjeneta] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gjeneta] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gjeneta] SET  MULTI_USER 
GO
ALTER DATABASE [Gjeneta] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gjeneta] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gjeneta] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gjeneta] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Gjeneta] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Gjeneta]
GO
/****** Object:  User [ahmeti]    Script Date: 5/6/2020 6:03:20 PM ******/
CREATE USER [ahmeti] FOR LOGIN [ahmeti] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Delegati]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delegati](
	[DelegatiID] [int] IDENTITY(1,1) NOT NULL,
	[NdeshjaID] [int] NULL,
	[PersoniID] [int] NULL,
	[Roli] [nvarchar](50) NULL,
	[RaportPasNdeshjes] [text] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Delegati] PRIMARY KEY CLUSTERED 
(
	[DelegatiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Formacioni]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formacioni](
	[FormacioniId] [int] IDENTITY(1,1) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Formacioni] PRIMARY KEY CLUSTERED 
(
	[FormacioniId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Golashenuesi]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Golashenuesi](
	[GolaShenuesiId] [int] IDENTITY(1,1) NOT NULL,
	[LojtariId] [int] NOT NULL,
	[Golat] [int] NOT NULL,
	[NdeshjaId] [int] NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Golashenuesi] PRIMARY KEY CLUSTERED 
(
	[GolaShenuesiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KategoriteKlubore]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KategoriteKlubore](
	[KategoriaId] [int] IDENTITY(1,1) NOT NULL,
	[Emertimi] [varchar](150) NULL,
	[Prej] [int] NULL,
	[Deri] [int] NULL,
	[InsertBy] [int] NOT NULL,
	[InsertDate] [date] NOT NULL,
	[LUD] [date] NOT NULL,
	[LUN] [int] NOT NULL,
	[LUB] [int] NOT NULL,
	[KlubiId] [int] NULL,
 CONSTRAINT [PK_KategoriteKlubore] PRIMARY KEY CLUSTERED 
(
	[KategoriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Klubet]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Klubet](
	[KlubiId] [int] IDENTITY(1,1) NOT NULL,
	[Emertimi] [varchar](150) NOT NULL,
	[Vendi] [varchar](50) NOT NULL,
	[Kryetari] [varchar](50) NOT NULL,
	[IThemeluar] [date] NOT NULL,
	[StadiumiId] [int] NOT NULL,
	[LigaId] [int] NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Klubet] PRIMARY KEY CLUSTERED 
(
	[KlubiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ligat]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ligat](
	[LigaId] [int] IDENTITY(1,1) NOT NULL,
	[Emertimi] [varchar](150) NOT NULL,
	[VitiKalendarik] [int] NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Ligat] PRIMARY KEY CLUSTERED 
(
	[LigaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ndeshjet]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ndeshjet](
	[NdeshjaId] [int] IDENTITY(1,1) NOT NULL,
	[DataENdeshjes] [datetime] NOT NULL,
	[Sezoni] [char](10) NOT NULL,
	[RaportiIAmbulances] [text] NOT NULL,
	[RaportiIPolicise] [text] NOT NULL,
	[KlubiVendasId] [int] NOT NULL,
	[KlubiNikoqirId] [int] NOT NULL,
	[FormacioniId] [int] NOT NULL,
	[StadiumiId] [int] NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Ndeshjet] PRIMARY KEY CLUSTERED 
(
	[NdeshjaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personeli]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personeli](
	[PersoneliId] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [varchar](50) NOT NULL,
	[Mbiemri] [varchar](50) NULL,
	[EmriIPerdoruesit] [varchar](50) NULL,
	[Fjalekalimi] [varchar](50) NULL,
	[NumriFanelles] [int] NULL,
	[Specializimi] [varchar](50) NULL,
	[Titulli] [varchar](50) NULL,
	[VendiIPunes] [varchar](50) NULL,
	[AntariGrupit] [varchar](50) NULL,
	[NderrimiIPunes] [varchar](50) NULL,
	[Thirrja] [varchar](50) NULL,
	[Gjinia] [nchar](10) NULL,
	[Ditelindja] [date] NULL,
	[Vendlindja] [varchar](50) NULL,
	[GrupiIGjakut] [varchar](20) NULL,
	[Shteti] [varchar](50) NULL,
	[Vendbanimi] [varchar](50) NULL,
	[Telefoni] [varchar](50) NULL,
	[Email] [varchar](150) NULL,
	[Gjatesia] [decimal](18, 2) NULL,
	[Pesha] [decimal](18, 3) NULL,
	[KlubiId] [int] NULL,
	[RoliId] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Personeli] PRIMARY KEY CLUSTERED 
(
	[PersoneliId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Referat]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Referat](
	[ReferiID] [int] IDENTITY(1,1) NOT NULL,
	[Pozita] [varchar](50) NOT NULL,
	[InsertBy] [int] NOT NULL,
	[InsertDate] [date] NOT NULL,
	[LUB] [int] NOT NULL,
	[LUD] [date] NOT NULL,
	[LUN] [int] NOT NULL,
	[PersoneliId] [int] NULL,
	[NdeshjaId] [int] NULL,
 CONSTRAINT [PK_Referat] PRIMARY KEY CLUSTERED 
(
	[ReferiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rolet]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rolet](
	[RoliId] [int] IDENTITY(1,1) NOT NULL,
	[EmriIRolit] [varchar](50) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [int] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Rolet] PRIMARY KEY CLUSTERED 
(
	[RoliId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Stadiumet]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Stadiumet](
	[StadiumId] [int] IDENTITY(1,1) NOT NULL,
	[Emertimi] [varchar](250) NOT NULL,
	[Vendi] [varchar](50) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[StadiumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Statusi_Lojtarit]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statusi_Lojtarit](
	[StatusiID] [int] IDENTITY(1,1) NOT NULL,
	[Pergjegjes] [nvarchar](50) NULL,
	[Rezerve] [nvarchar](50) NULL,
	[Huazim] [nvarchar](50) NULL,
	[Shoqerues] [nvarchar](50) NULL,
	[InsertBy] [int] NULL,
	[UInkuadrua] [bit] NULL,
	[ULargua] [bit] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
	[LojtariId] [int] NULL,
	[FormacionId] [int] NULL,
	[Vleresimi] [decimal](18, 1) NULL,
 CONSTRAINT [PK_Statusi_Lojtarit] PRIMARY KEY CLUSTERED 
(
	[StatusiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ushtrimet]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ushtrimet](
	[UshtrimId] [int] IDENTITY(1,1) NOT NULL,
	[Dita] [varchar](50) NULL,
	[Ora] [varchar](50) NULL,
	[KlubiId] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Ushtrimet] PRIMARY KEY CLUSTERED 
(
	[UshtrimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Delegati] ON 

INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, 1, 11, N'test', N'test', 2, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), 1)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (2, NULL, NULL, N'Delegate', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (3, NULL, NULL, N'Delegate', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (5, NULL, NULL, N'Delegate', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (6, NULL, NULL, N'po', N'po', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (7, NULL, 20, N'ew', N'ew', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (8, 1, 11, N'pergjegjes', N'ska', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (9, 1, 25, N'delegat', N'ska', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (10, 1, 25, N'delegat', N'ska', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (11, 1, 17, N'ndihmese', N'ska', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (12, NULL, 27, N'oo', N'oo', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (13, NULL, 28, N'kryetar', N'po', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (14, NULL, 29, N'deff', N'test', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (15, NULL, 11, N'drejtor', N'test', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (16, NULL, 9, N'drejtor egzekutiv', N'ska', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (17, NULL, 33, N'po', N'po', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Delegati] ([DelegatiID], [NdeshjaID], [PersoniID], [Roli], [RaportPasNdeshjes], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (18, NULL, 36, N'po', N'po', 1, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Delegati] OFF
SET IDENTITY_INSERT [dbo].[Formacioni] ON 

INSERT [dbo].[Formacioni] ([FormacioniId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, 2, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), 1)
INSERT [dbo].[Formacioni] ([FormacioniId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (3, 2, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), 1)
INSERT [dbo].[Formacioni] ([FormacioniId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (4, 2, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Formacioni] OFF
SET IDENTITY_INSERT [dbo].[Golashenuesi] ON 

INSERT [dbo].[Golashenuesi] ([GolaShenuesiId], [LojtariId], [Golat], [NdeshjaId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, 1, 3, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Golashenuesi] ([GolaShenuesiId], [LojtariId], [Golat], [NdeshjaId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (2, 5, 2, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Golashenuesi] ([GolaShenuesiId], [LojtariId], [Golat], [NdeshjaId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (3, 1, 2, 1, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Golashenuesi] OFF
SET IDENTITY_INSERT [dbo].[KategoriteKlubore] ON 

INSERT [dbo].[KategoriteKlubore] ([KategoriaId], [Emertimi], [Prej], [Deri], [InsertBy], [InsertDate], [LUD], [LUN], [LUB], [KlubiId]) VALUES (1, N'Senior', 18, 35, 2, CAST(N'1999-01-01' AS Date), CAST(N'1999-01-01' AS Date), 1, 2, 1)
INSERT [dbo].[KategoriteKlubore] ([KategoriaId], [Emertimi], [Prej], [Deri], [InsertBy], [InsertDate], [LUD], [LUN], [LUB], [KlubiId]) VALUES (2, N'Senior', 18, 35, 2, CAST(N'1999-01-01' AS Date), CAST(N'1999-01-01' AS Date), 1, 2, 2)
SET IDENTITY_INSERT [dbo].[KategoriteKlubore] OFF
SET IDENTITY_INSERT [dbo].[Klubet] ON 

INSERT [dbo].[Klubet] ([KlubiId], [Emertimi], [Vendi], [Kryetari], [IThemeluar], [StadiumiId], [LigaId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, N'Drita FC', N'Drita FC', N'arnis hasani', CAST(N'1993-01-01' AS Date), 2, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Klubet] ([KlubiId], [Emertimi], [Vendi], [Kryetari], [IThemeluar], [StadiumiId], [LigaId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (2, N'Prishtina FC', N'Prishtina FC', N'altin loshi', CAST(N'1999-01-01' AS Date), 1, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Klubet] ([KlubiId], [Emertimi], [Vendi], [Kryetari], [IThemeluar], [StadiumiId], [LigaId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (5, N'Peja', N'Peja', N'Gjeneta ahmeti', CAST(N'2020-05-15' AS Date), 1, 1, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Klubet] OFF
SET IDENTITY_INSERT [dbo].[Ligat] ON 

INSERT [dbo].[Ligat] ([LigaId], [Emertimi], [VitiKalendarik], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, N'Superliga e Kosoves', 2020, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Ligat] OFF
SET IDENTITY_INSERT [dbo].[Ndeshjet] ON 

INSERT [dbo].[Ndeshjet] ([NdeshjaId], [DataENdeshjes], [Sezoni], [RaportiIAmbulances], [RaportiIPolicise], [KlubiVendasId], [KlubiNikoqirId], [FormacioniId], [StadiumiId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, CAST(N'2020-01-01 00:00:00.000' AS DateTime), N'D         ', N'123', N'123', 2, 1, 1, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Ndeshjet] ([NdeshjaId], [DataENdeshjes], [Sezoni], [RaportiIAmbulances], [RaportiIPolicise], [KlubiVendasId], [KlubiNikoqirId], [FormacioniId], [StadiumiId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (2, CAST(N'2020-05-06 00:00:00.000' AS DateTime), N'vere      ', N'ska', N'ska', 1, 2, 1, 2, 1, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Ndeshjet] OFF
SET IDENTITY_INSERT [dbo].[Personeli] ON 

INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, N'Arnis', N'Hasani', N'arnooHasani', N'arnishasani123', 7, N'master', NULL, NULL, NULL, NULL, NULL, N'1         ', CAST(N'1999-09-07' AS Date), N'Prishtin', N'A', N'Kosove', N'Batllav', N'0333', N'arno', CAST(30.00 AS Decimal(18, 2)), CAST(21.000 AS Decimal(18, 3)), 1, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (2, N'Gjeneta', N'Ahmeti', N'gjenetaahmeti.com', N'123', 21, N'master', N'', NULL, NULL, NULL, NULL, N'F         ', CAST(N'1997-11-17' AS Date), N'Landau', N'B negativ', N'Gjermani', N'Kosove', N'123123', N'123', CAST(1.00 AS Decimal(18, 2)), CAST(1.000 AS Decimal(18, 3)), 1, 2, 1, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (4, N'X', N'ahmeti', N'engjellahmet', N'123', NULL, N'master', NULL, NULL, NULL, NULL, NULL, N'M         ', CAST(N'1995-06-25' AS Date), N'Trier', N'B', N'Gjermani', N'Kosove', N'123123', N'123', CAST(1.00 AS Decimal(18, 2)), CAST(1.000 AS Decimal(18, 3)), 1, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (5, N'Y', N'ahmeti', N'engjellahmet', N'123', NULL, N'master', NULL, NULL, NULL, NULL, NULL, N'M         ', CAST(N'1995-06-25' AS Date), N'Trier', N'B', N'Gjermani', N'Kosove', N'123123', N'123', CAST(1.00 AS Decimal(18, 2)), CAST(1.000 AS Decimal(18, 3)), 2, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (6, N'Z', N'ahmeti', N'engjellahmet', N'123', NULL, N'master', NULL, NULL, NULL, NULL, NULL, N'M         ', CAST(N'1995-06-25' AS Date), N'Trier', N'B', N'Gjermani', N'Kosove', N'123123', N'123', CAST(1.00 AS Decimal(18, 2)), CAST(1.000 AS Decimal(18, 3)), 2, 1, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (7, N'refer 1', N'ahmeti', N'engjellahmet', N'123', NULL, N'master', NULL, NULL, NULL, NULL, NULL, N'M         ', CAST(N'1995-06-25' AS Date), N'Trier', N'B', N'Gjermani', N'Kosove', N'123123', N'123', CAST(1.00 AS Decimal(18, 2)), CAST(1.000 AS Decimal(18, 3)), NULL, 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (8, N'refer 2', N'ahmeti', N'engjellahmet', N'123', NULL, N'master', NULL, NULL, NULL, NULL, NULL, N'M         ', CAST(N'1995-06-25' AS Date), N'Trier', N'B', N'Gjermani', N'Kosove', N'123123', N'123', CAST(1.00 AS Decimal(18, 2)), CAST(1.000 AS Decimal(18, 3)), NULL, 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (9, N'arno', N'hasani', N'arno', N'hasani', NULL, N'po', N'po', NULL, NULL, NULL, NULL, N'm         ', CAST(N'2001-01-01' AS Date), N'ko', N'B', N'po', N'jhj', N'h', N'jkkj', CAST(1.00 AS Decimal(18, 2)), CAST(1.000 AS Decimal(18, 3)), NULL, 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (10, N'refer 4', N'ahmeti', N'engjellahmet', N'123', NULL, N'master', NULL, NULL, NULL, NULL, NULL, N'M         ', CAST(N'1995-06-25' AS Date), N'Trier', N'B', N'Gjermani', N'Kosove', N'123123', N'123', CAST(1.00 AS Decimal(18, 2)), CAST(1.000 AS Decimal(18, 3)), NULL, 4, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (11, N'delegat', N'ahmeti', N'engjellahmet', N'123', NULL, N'master', N'', NULL, NULL, NULL, NULL, N'M         ', CAST(N'1995-06-25' AS Date), N'Trier', N'B', N'Gjermani', N'Kosove', N'123123', N'123', CAST(1.00 AS Decimal(18, 2)), CAST(1.000 AS Decimal(18, 3)), NULL, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (12, N'altin', N'loshi', N'po', N'oo', 7, N'o', N'o', NULL, NULL, NULL, NULL, N'oo        ', CAST(N'2001-01-01' AS Date), N'oo', N'A', N'o', N'oo', N'oo', N'oo', CAST(30.00 AS Decimal(18, 2)), CAST(21.000 AS Decimal(18, 3)), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (13, N'ALTIN', N'loshi', N'kj', N'kkj', 21, NULL, NULL, NULL, NULL, NULL, NULL, N'ma        ', CAST(N'1999-02-02' AS Date), N'mitro', N'klkj', N'lkj', N'lkl', N'klj', N'klj', CAST(21.00 AS Decimal(18, 2)), CAST(23.000 AS Decimal(18, 3)), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (14, N'Nol', N'Ahmeti', N'Noli', N'noli123', 2, NULL, NULL, NULL, NULL, NULL, NULL, N'mashkull  ', CAST(N'1995-01-01' AS Date), N'Germany', N'B', N'Kosovar', N'Stanishor', N'111', N'nolii', CAST(1.00 AS Decimal(18, 2)), CAST(57.000 AS Decimal(18, 3)), NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (16, N'Gjeneta', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (17, N'Gjeneta', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (18, N'Gjeneta', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (20, N'po', N'po', N'po', N'po', NULL, N'po', N'po', NULL, NULL, NULL, NULL, N'po        ', CAST(N'1992-01-01' AS Date), N'po', NULL, N'po', N'po', N'po', N'po', NULL, NULL, 1, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (25, N'arno', N'hasani', N'arno', N'hasani', NULL, N'po', N'po', NULL, NULL, NULL, NULL, N'm         ', CAST(N'2001-01-01' AS Date), N'ko', NULL, N'po', N'jhj', N'h', N'jkkj', NULL, NULL, 1, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (26, N'agga', N'jh', N'jh', N'jh', NULL, N'j', N'h', NULL, NULL, NULL, NULL, N'jh        ', CAST(N'1997-01-01' AS Date), N'jh', NULL, N'jh', N'jh', N'jh', N'jh', NULL, NULL, 1, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (27, N'altin', N'loshi', N'po', N'oo', NULL, N'o', N'o', NULL, NULL, NULL, NULL, N'oo        ', CAST(N'2001-01-01' AS Date), N'oo', NULL, N'o', N'oo', N'oo', N'oo', NULL, NULL, 1, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (28, N'arnis', N'hasani', N'arnoo', N'hasani', NULL, N'po', N'pergjgjes', NULL, NULL, NULL, NULL, N'mashkull  ', CAST(N'2005-02-04' AS Date), N'batllave', NULL, N'kosove', N'prishtine', N'045688315', N'arno.hasani', NULL, NULL, 1, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (29, N'delegat', N'ahmeti', N'engjellahmet', N'123', NULL, N'master', N'', NULL, NULL, NULL, NULL, N'M         ', CAST(N'1995-06-25' AS Date), N'Trier', NULL, N'Gjermani', N'Kosove', N'123123', N'123', NULL, NULL, 1, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (30, N'gjeneta', N'ahmeti', N'gjeneta', N'gjenetahmeti', 27, NULL, NULL, NULL, NULL, NULL, NULL, N'femer     ', CAST(N'1997-11-11' AS Date), N'Gjilan', N'b negativ', N'kosove', N'prishtine', N'5555', N'gjeneta', CAST(22.00 AS Decimal(18, 2)), CAST(21.000 AS Decimal(18, 3)), 1, NULL, 1, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (31, N'Arnis', N'hasani', N'arnoo', N'arnohasani', NULL, N'ska', N'po', NULL, NULL, NULL, NULL, N'po        ', CAST(N'1997-11-11' AS Date), N'kosove', NULL, N'p', N'op', N'po', N'op', NULL, NULL, 1, 2, 1, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (32, N'altin', N'loshi', N'loshi', N'loshialtin', 21, NULL, NULL, NULL, NULL, NULL, NULL, N'm         ', CAST(N'1999-01-01' AS Date), N'mitro', N'a', N'kosovar', N'mitro', N'888', N'jhjkh', CAST(34.00 AS Decimal(18, 2)), CAST(34.000 AS Decimal(18, 3)), 1, NULL, 1, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (33, N'po', N'p', N'op', N'po', NULL, N'po', N'po', NULL, NULL, NULL, NULL, N'po        ', CAST(N'1999-01-01' AS Date), N'po', NULL, N'po', N'p', N'o', N'po', NULL, NULL, 1, 5, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (34, N'po', N'po', N'po', N'po', NULL, N'po', N'po', NULL, NULL, NULL, NULL, N'po        ', CAST(N'1992-01-01' AS Date), N'po', NULL, N'po', N'po', N'po', N'po', NULL, NULL, 1, 5, 1, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (35, N'altin', N'po', N'p', N'opo', NULL, N'p', N'op', NULL, NULL, NULL, NULL, N'op        ', CAST(N'1998-02-02' AS Date), N'op', NULL, N'o', N'p', N'po', N'po', NULL, NULL, 1, 5, 1, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1)
INSERT [dbo].[Personeli] ([PersoneliId], [Emri], [Mbiemri], [EmriIPerdoruesit], [Fjalekalimi], [NumriFanelles], [Specializimi], [Titulli], [VendiIPunes], [AntariGrupit], [NderrimiIPunes], [Thirrja], [Gjinia], [Ditelindja], [Vendlindja], [GrupiIGjakut], [Shteti], [Vendbanimi], [Telefoni], [Email], [Gjatesia], [Pesha], [KlubiId], [RoliId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (36, N'altin', N'po', N'po', N'po', NULL, N'po', N'po', NULL, NULL, NULL, NULL, N'p         ', CAST(N'1999-01-01' AS Date), N'po', NULL, N'po', N'po', N'po', N'po', NULL, NULL, 1, 5, 1, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Personeli] OFF
SET IDENTITY_INSERT [dbo].[Referat] ON 

INSERT [dbo].[Referat] ([ReferiID], [Pozita], [InsertBy], [InsertDate], [LUB], [LUD], [LUN], [PersoneliId], [NdeshjaId]) VALUES (1, N'Anesor i djathe', 2, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), 1, 7, 1)
INSERT [dbo].[Referat] ([ReferiID], [Pozita], [InsertBy], [InsertDate], [LUB], [LUD], [LUN], [PersoneliId], [NdeshjaId]) VALUES (2, N'Anesor i majte', 2, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), 1, 8, 1)
INSERT [dbo].[Referat] ([ReferiID], [Pozita], [InsertBy], [InsertDate], [LUB], [LUD], [LUN], [PersoneliId], [NdeshjaId]) VALUES (3, N'refer', 2, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), 1, 9, 1)
INSERT [dbo].[Referat] ([ReferiID], [Pozita], [InsertBy], [InsertDate], [LUB], [LUD], [LUN], [PersoneliId], [NdeshjaId]) VALUES (4, N'virtual', 2, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), 1, 10, 1)
SET IDENTITY_INSERT [dbo].[Referat] OFF
SET IDENTITY_INSERT [dbo].[Rolet] ON 

INSERT [dbo].[Rolet] ([RoliId], [EmriIRolit], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, N'Lojtare', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Rolet] ([RoliId], [EmriIRolit], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (2, N'Trajner', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Rolet] ([RoliId], [EmriIRolit], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (3, N'Mjek', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Rolet] ([RoliId], [EmriIRolit], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (4, N'Refer', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Rolet] ([RoliId], [EmriIRolit], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (5, N'Delegat', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Rolet] OFF
SET IDENTITY_INSERT [dbo].[Stadiumet] ON 

INSERT [dbo].[Stadiumet] ([StadiumId], [Emertimi], [Vendi], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, N'Fadil Vokrri', N'Prishtine', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Stadiumet] ([StadiumId], [Emertimi], [Vendi], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (2, N'Bezi', N'Gjilan', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Stadiumet] OFF
SET IDENTITY_INSERT [dbo].[Statusi_Lojtarit] ON 

INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (4, N'Kapiten', N'jo', N'jo', N'jo', 1, NULL, NULL, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1, 1, 1, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (5, N'Sulmues', N'jo', N'jo', N'jo', 2, NULL, NULL, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), NULL, 4, 1, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (6, N'Kapiten', N'jo', N'jo', N'jo', 2, NULL, NULL, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), NULL, 5, 1, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (7, N'Sulmues', N'jo', N'jo', N'jo', 2, NULL, NULL, CAST(N'1999-01-01' AS Date), 2, CAST(N'1999-01-01' AS Date), NULL, 6, 1, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (12, N'mbrojtje', N'ska', N'ska', N'ska', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 7, 4, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (14, N'mbrojtes', N'jo', N'jo', N'po', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 25, 1, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (15, N'Portiere', N'po', N'po', N'po', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, 1, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (18, N'po', N'jo', N'jo', N'jo', 1, NULL, NULL, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1, 1, 1, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (19, N'po', N'jo', N'jo', N'jo', 1, NULL, NULL, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1, 2, 1, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (20, N'portiere', N'jo', N'jo', N'jo', 1, NULL, NULL, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1, 2, 1, NULL)
INSERT [dbo].[Statusi_Lojtarit] ([StatusiID], [Pergjegjes], [Rezerve], [Huazim], [Shoqerues], [InsertBy], [UInkuadrua], [ULargua], [InsertDate], [LUB], [LUD], [LUN], [LojtariId], [FormacionId], [Vleresimi]) VALUES (30, N'portier', N'jo', N'jo', N'jo', 1, NULL, NULL, CAST(N'2020-06-05' AS Date), 1, CAST(N'2020-06-05' AS Date), 1, 26, 1, NULL)
SET IDENTITY_INSERT [dbo].[Statusi_Lojtarit] OFF
SET IDENTITY_INSERT [dbo].[Ushtrimet] ON 

INSERT [dbo].[Ushtrimet] ([UshtrimId], [Dita], [Ora], [KlubiId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (1, N'E Marte', N'21:00', 1, 2, CAST(N'2020-05-06' AS Date), 1, CAST(N'2020-05-06' AS Date), 2)
INSERT [dbo].[Ushtrimet] ([UshtrimId], [Dita], [Ora], [KlubiId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (2, N'E Ejte', N'13:40', 1, 2, CAST(N'2020-05-06' AS Date), 1, CAST(N'2020-05-06' AS Date), 2)
INSERT [dbo].[Ushtrimet] ([UshtrimId], [Dita], [Ora], [KlubiId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (14, N'e hene', N'20:20', 1, 1, CAST(N'1998-01-01' AS Date), 2, CAST(N'1997-01-01' AS Date), 2)
INSERT [dbo].[Ushtrimet] ([UshtrimId], [Dita], [Ora], [KlubiId], [InsertBy], [InsertDate], [LUB], [LUD], [LUN]) VALUES (15, N'e marte', N'14:50', 1, 1, CAST(N'1998-01-01' AS Date), 2, CAST(N'1997-01-01' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Ushtrimet] OFF
ALTER TABLE [dbo].[Delegati]  WITH CHECK ADD  CONSTRAINT [FK_Delegati_Ndeshjet] FOREIGN KEY([NdeshjaID])
REFERENCES [dbo].[Ndeshjet] ([NdeshjaId])
GO
ALTER TABLE [dbo].[Delegati] CHECK CONSTRAINT [FK_Delegati_Ndeshjet]
GO
ALTER TABLE [dbo].[Delegati]  WITH CHECK ADD  CONSTRAINT [FK_Delegati_Personeli] FOREIGN KEY([PersoniID])
REFERENCES [dbo].[Personeli] ([PersoneliId])
GO
ALTER TABLE [dbo].[Delegati] CHECK CONSTRAINT [FK_Delegati_Personeli]
GO
ALTER TABLE [dbo].[Golashenuesi]  WITH CHECK ADD  CONSTRAINT [FK_Golashenuesi_Ndeshjet] FOREIGN KEY([NdeshjaId])
REFERENCES [dbo].[Ndeshjet] ([NdeshjaId])
GO
ALTER TABLE [dbo].[Golashenuesi] CHECK CONSTRAINT [FK_Golashenuesi_Ndeshjet]
GO
ALTER TABLE [dbo].[Golashenuesi]  WITH CHECK ADD  CONSTRAINT [FK_Golashenuesi_Personeli] FOREIGN KEY([LojtariId])
REFERENCES [dbo].[Personeli] ([PersoneliId])
GO
ALTER TABLE [dbo].[Golashenuesi] CHECK CONSTRAINT [FK_Golashenuesi_Personeli]
GO
ALTER TABLE [dbo].[KategoriteKlubore]  WITH CHECK ADD  CONSTRAINT [FK_KategoriteKlubore_Klubet] FOREIGN KEY([KlubiId])
REFERENCES [dbo].[Klubet] ([KlubiId])
GO
ALTER TABLE [dbo].[KategoriteKlubore] CHECK CONSTRAINT [FK_KategoriteKlubore_Klubet]
GO
ALTER TABLE [dbo].[Klubet]  WITH CHECK ADD  CONSTRAINT [FK_Klubet_Ligat] FOREIGN KEY([LigaId])
REFERENCES [dbo].[Ligat] ([LigaId])
GO
ALTER TABLE [dbo].[Klubet] CHECK CONSTRAINT [FK_Klubet_Ligat]
GO
ALTER TABLE [dbo].[Klubet]  WITH CHECK ADD  CONSTRAINT [FK_Klubet_Stadiumet] FOREIGN KEY([StadiumiId])
REFERENCES [dbo].[Stadiumet] ([StadiumId])
GO
ALTER TABLE [dbo].[Klubet] CHECK CONSTRAINT [FK_Klubet_Stadiumet]
GO
ALTER TABLE [dbo].[Ndeshjet]  WITH CHECK ADD  CONSTRAINT [FK_Ndeshjet_Formacioni] FOREIGN KEY([FormacioniId])
REFERENCES [dbo].[Formacioni] ([FormacioniId])
GO
ALTER TABLE [dbo].[Ndeshjet] CHECK CONSTRAINT [FK_Ndeshjet_Formacioni]
GO
ALTER TABLE [dbo].[Ndeshjet]  WITH CHECK ADD  CONSTRAINT [FK_Ndeshjet_Klubet] FOREIGN KEY([KlubiVendasId])
REFERENCES [dbo].[Klubet] ([KlubiId])
GO
ALTER TABLE [dbo].[Ndeshjet] CHECK CONSTRAINT [FK_Ndeshjet_Klubet]
GO
ALTER TABLE [dbo].[Ndeshjet]  WITH CHECK ADD  CONSTRAINT [FK_Ndeshjet_Klubet1] FOREIGN KEY([KlubiNikoqirId])
REFERENCES [dbo].[Klubet] ([KlubiId])
GO
ALTER TABLE [dbo].[Ndeshjet] CHECK CONSTRAINT [FK_Ndeshjet_Klubet1]
GO
ALTER TABLE [dbo].[Ndeshjet]  WITH CHECK ADD  CONSTRAINT [FK_Ndeshjet_Stadiumet] FOREIGN KEY([StadiumiId])
REFERENCES [dbo].[Stadiumet] ([StadiumId])
GO
ALTER TABLE [dbo].[Ndeshjet] CHECK CONSTRAINT [FK_Ndeshjet_Stadiumet]
GO
ALTER TABLE [dbo].[Personeli]  WITH CHECK ADD  CONSTRAINT [FK_Personeli_Klubet] FOREIGN KEY([KlubiId])
REFERENCES [dbo].[Klubet] ([KlubiId])
GO
ALTER TABLE [dbo].[Personeli] CHECK CONSTRAINT [FK_Personeli_Klubet]
GO
ALTER TABLE [dbo].[Personeli]  WITH CHECK ADD  CONSTRAINT [FK_Personeli_Rolet] FOREIGN KEY([RoliId])
REFERENCES [dbo].[Rolet] ([RoliId])
GO
ALTER TABLE [dbo].[Personeli] CHECK CONSTRAINT [FK_Personeli_Rolet]
GO
ALTER TABLE [dbo].[Referat]  WITH CHECK ADD  CONSTRAINT [FK_Referat_Ndeshjet] FOREIGN KEY([NdeshjaId])
REFERENCES [dbo].[Ndeshjet] ([NdeshjaId])
GO
ALTER TABLE [dbo].[Referat] CHECK CONSTRAINT [FK_Referat_Ndeshjet]
GO
ALTER TABLE [dbo].[Referat]  WITH CHECK ADD  CONSTRAINT [FK_Referat_Personeli] FOREIGN KEY([PersoneliId])
REFERENCES [dbo].[Personeli] ([PersoneliId])
GO
ALTER TABLE [dbo].[Referat] CHECK CONSTRAINT [FK_Referat_Personeli]
GO
ALTER TABLE [dbo].[Statusi_Lojtarit]  WITH CHECK ADD  CONSTRAINT [FK_Statusi_Lojtarit_Formacioni] FOREIGN KEY([FormacionId])
REFERENCES [dbo].[Formacioni] ([FormacioniId])
GO
ALTER TABLE [dbo].[Statusi_Lojtarit] CHECK CONSTRAINT [FK_Statusi_Lojtarit_Formacioni]
GO
ALTER TABLE [dbo].[Statusi_Lojtarit]  WITH CHECK ADD  CONSTRAINT [FK_Statusi_Lojtarit_Personeli] FOREIGN KEY([LojtariId])
REFERENCES [dbo].[Personeli] ([PersoneliId])
GO
ALTER TABLE [dbo].[Statusi_Lojtarit] CHECK CONSTRAINT [FK_Statusi_Lojtarit_Personeli]
GO
ALTER TABLE [dbo].[Ushtrimet]  WITH CHECK ADD  CONSTRAINT [FK_Ushtrimet_Klubet] FOREIGN KEY([KlubiId])
REFERENCES [dbo].[Klubet] ([KlubiId])
GO
ALTER TABLE [dbo].[Ushtrimet] CHECK CONSTRAINT [FK_Ushtrimet_Klubet]
GO
/****** Object:  StoredProcedure [dbo].[Delegat]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Delegat]
@Emri varchar(50),
@Mbiemri varchar(50),
@EmriIPerdoruesit varchar(50),
@Fjalekalimi varchar(50),
@Specializimi varchar(50),
@Titulli varchar(50),
@Gjinia nchar(10),
@Ditelindja date,
@Vendlindja  varchar(50),
@Shteti varchar(50),
@Vendbanimi  varchar(50),
@Telefoni varchar(50),
@Email  varchar(50),
@PersoneliID int,
@KlubiID int,
@RoliID int,
@Roli varchar(150),
@RaportiPasNdeshjes text,
@InsertBy int,
@InsertDate date,
@LUB int,
@LUD date,
@LUN int
as
begin
	if(@PersoneliID=0)
	begin
		insert into Personeli(Emri,Mbiemri,EmriIPerdoruesit,Fjalekalimi,Specializimi,Titulli,Gjinia,Ditelindja,Vendlindja,Shteti,Vendbanimi,Telefoni,Email,
		KlubiId,RoliId,InsertBy,InsertDate,LUB,LUD,LUN)
		values(@Emri,@Mbiemri,@EmriIPerdoruesit,@Fjalekalimi,@Specializimi,@Titulli,@Gjinia,@Ditelindja,@Vendlindja,@Shteti,@Vendbanimi,@Telefoni,@Email,
		@KlubiID,@RoliID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)

		set @PersoneliID = (select max(PersoneliId) from Personeli)

		insert into Delegati(Roli, RaportPasNdeshjes, PersoniID,InsertBy,InsertDate,LUB,LUD,LUN) 
		values (@Roli, @RaportiPasNdeshjes, @PersoneliID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)
	end
	else
	begin
		update Personeli set
		Emri=@Emri,
		Mbiemri=@Mbiemri,
		EmriIPerdoruesit=@EmriIPerdoruesit,
		Fjalekalimi=@Fjalekalimi,
		Specializimi=@Specializimi,
		Titulli=@Titulli,
		Gjinia=@Gjinia,
		Ditelindja=@Ditelindja,
		Vendlindja=@Vendlindja,
		Shteti=@Shteti,
		Vendbanimi=@Vendbanimi,
		Telefoni=@Telefoni,
		Email=@Email,
			InsertBy=@InsertBy,
	InsertDate=@InsertDate,
	LUB=@LUB,
	LUD=@LUD,
	LUN=@LUN
		where PersoneliId= @PersoneliID

		insert into Delegati(Roli, RaportPasNdeshjes, PersoniID) values (@Roli, @RaportiPasNdeshjes, @PersoneliID)
	end
	

end



GO
/****** Object:  StoredProcedure [dbo].[usp_Delegat_FshijDelegatMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Delegat_FshijDelegatMeID](
@DelegatID int)
as begin
	delete from Personeli
	where PersoneliId=@DelegatID
	end

GO
/****** Object:  StoredProcedure [dbo].[usp_Delegat_GjejDelegatMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE proc [dbo].[usp_Delegat_GjejDelegatMeID](
@DelegatID int)
as
begin
	select	p.Emri,p.Mbiemri,p.EmriIPerdoruesit,p.Fjalekalimi,p.Specializimi,p.Titulli,p.Gjinia,p.Ditelindja,p.Vendlindja,p.Shteti,p.Vendbanimi
	,p.Telefoni,p.Email, p.InsertBy,p.InsertDate,p.LUB,p.LUD,p.LUN
	from Personeli as p
	where PersoneliId=@DelegatID
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_delegat_merrkejtDelegat2]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_delegat_merrkejtDelegat2]
as begin

		select d.DelegatiID, p.PersoneliID,p.Emri,p.Mbiemri,p.EmriIPerdoruesit,p.Fjalekalimi,p.Specializimi,p.Titulli,p.Gjinia,p.Ditelindja,p.Vendlindja,p.Shteti,p.Vendbanimi
	,p.Telefoni,p.Email,d.Roli,d.RaportPasNdeshjes

	from Personeli as p join Delegati d
	on p.PersoneliId=d.PersoniID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Delegat_ShfaqTeGjitheDelegat]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Delegat_ShfaqTeGjitheDelegat]
as begin
select p.PersoneliId,p.Emri, p.Mbiemri,p.EmriIPerdoruesit, p.Fjalekalimi,p.Specializimi,p.Titulli,
  p.Gjinia, p.Ditelindja,
	p.Vendlindja, p.Shteti,p.Vendbanimi,p.Telefoni,p.Email,p.KlubiId,p.RoliId
from Personeli as p 
where KlubiId =1 and RoliId=5
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Delegat_ShtooseEditoDelegat]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Delegat_ShtooseEditoDelegat](
@Emri varchar(50),
@Mbiemri varchar(50),
@EmriIPerdoruesit varchar(50),
@Fjalekalimi varchar(50),
@Specializimi varchar(50),
@Titulli varchar(50),
@Gjinia nchar(10),
@Ditelindja date,
@Vendlindja  varchar(50),
@Shteti varchar(50),
@Vendbanimi  varchar(50),
@Telefoni varchar(50),
@Email  varchar(50),
@PersoneliID int,
@KlubiID int,
@RoliID int,
@InsertBy int,
@InsertDate date,
@LUB int,
@LUD date,
@LUN int
)
as
begin
if(@PersoneliID=0)
begin
	insert into Personeli(Emri,Mbiemri,EmriIPerdoruesit,Fjalekalimi,Specializimi,Titulli,Gjinia,Ditelindja,Vendlindja,Shteti,Vendbanimi,Telefoni,Email,
	KlubiId,RoliId,InsertBy,InsertDate,LUB,LUD,LUN)
	values(@Emri,@Mbiemri,@EmriIPerdoruesit,@Fjalekalimi,@Specializimi,@Titulli,@Gjinia,@Ditelindja,@Vendlindja,@Shteti,@Vendbanimi,@Telefoni,@Email,
	@KlubiID,@RoliID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)
	end
	else
	begin
	update Personeli set
	Emri=@Emri,
	Mbiemri=@Mbiemri,
	EmriIPerdoruesit=@EmriIPerdoruesit,
	Fjalekalimi=@Fjalekalimi,
	Specializimi=@Specializimi,
	Titulli=@Titulli,
	Gjinia=@Gjinia,
	Ditelindja=@Ditelindja,
	Vendlindja=@Vendlindja,
	Shteti=@Shteti,
	Vendbanimi=@Vendbanimi,
	Telefoni=@Telefoni,
	Email=@Email,
	InsertBy=@InsertBy,
	InsertDate=@InsertDate,
	LUB=@LUB,
	LUD=@LUD,
	LUN=@LUN
	where PersoneliId= @PersoneliID
	end
end



GO
/****** Object:  StoredProcedure [dbo].[usp_Formacioni_FshijMeIDFormacion]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Formacioni_FshijMeIDFormacion]
(
@StatusiID INT
)
as
begin 
delete from Statusi_Lojtarit where StatusiID=@StatusiID

end

GO
/****** Object:  StoredProcedure [dbo].[usp_Formacioni_MerriFormacionID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Formacioni_MerriFormacionID]
(
 @StatusiID INT
)
as
begin 
select s.StatusiID,s.Pergjegjes,s.Rezerve,s.Huazim,s.Shoqerues,s.LojtariId,s.FormacionId,s.InsertBy,s.InsertDate,s.LUB,s.LUD,s.LUN
 from Statusi_Lojtarit as s
where StatusiID=@StatusiID
end


GO
/****** Object:  StoredProcedure [dbo].[usp_Formacioni_MerriKrejtFormacion]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[usp_Formacioni_MerriKrejtFormacion]

as
begin 
select s.StatusiID,s.Pergjegjes,s.Rezerve,s.Huazim,s.Shoqerues,s.LojtariId,s.FormacionId,
s.InsertBy,s.InsertDate,s.LUB,s.LUD,s.LUN
 from Statusi_Lojtarit as s

end

GO
/****** Object:  StoredProcedure [dbo].[usp_Formacioni_ShtooseEditoFormacion]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Formacioni_ShtooseEditoFormacion](
@Pergjegjes nvarchar(50),
@Rezerve nvarchar(50),
@Huazim nvarchar(50),
@Shoqerues nvarchar(50),
@StatusiID int,
@LojtariID int,
@FormacioniID int,
@InsertBy int,
@InsertDate date,
@LUB int,
@LUD date,
@LUN int)
as
begin
	if(@StatusiID=0)
	begin
		insert into Statusi_Lojtarit(Pergjegjes,Rezerve,Huazim,Shoqerues,LojtariId,FormacionId,InsertBy,InsertDate,LUB,LUD,LUN)
		values(@Pergjegjes,@Rezerve,@Huazim,@Shoqerues,@LojtariID,@FormacioniID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)

		set @StatusiID = (select max(StatusiID) from Statusi_Lojtarit)

		insert into Formacioni(FormacioniId) values (@FormacioniID)
	end

	else
	begin
		update Statusi_Lojtarit set
		Pergjegjes=@Pergjegjes,
		Rezerve=@Rezerve,
		Huazim=@Huazim,
		Shoqerues=@Shoqerues,
		InsertBy=@InsertBy,
		InsertDate=@InsertDate,
		LUB=@LUB,
		LUD=@LUD,
		LUN=@LUN

		where StatusiID= @StatusiID

		insert into Formacioni(FormacioniId) values (@FormacioniID)
	end
	end

GO
/****** Object:  StoredProcedure [dbo].[usp_FshijLojtarMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_FshijLojtarMeID] (
@LojtariID int)
as
begin
	delete from Personeli
	where PersoneliId=@LojtariID
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_FshijMeId_Ndeshje]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_FshijMeId_Ndeshje](
@NdeshjaID int
)
as begin
delete from Ndeshjet
where NdeshjaId=@NdeshjaID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_FshijTrajnerMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_FshijTrajnerMeID](
@TrajneriID int)
as begin
	delete from Personeli
	where PersoneliId=@TrajneriID
	end

GO
/****** Object:  StoredProcedure [dbo].[usp_GjejLojtarMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_GjejLojtarMeID] (
@LojtariID int)
as
begin
	select p.Emri, p.Mbiemri,p.EmriIPerdoruesit, p.Fjalekalimi, p.NumriFanelles, p.Gjinia, p.Ditelindja,
	p.Vendlindja,p.GrupiIGjakut, p.Shteti,p.Vendbanimi,p.Telefoni,p.Email,p.Pesha,p.Gjatesia,p.InsertBy,p.InsertDate,p.LUB,p.LUD,p.LUN
	 from Personeli as p
	where PersoneliId=@LojtariID 
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_GjejTrajnerMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_GjejTrajnerMeID](
@TrajneriID int)
as
begin
	select	p.Emri,p.Mbiemri,p.EmriIPerdoruesit,p.Fjalekalimi,p.Specializimi,p.Titulli,p.Gjinia,p.Ditelindja,p.Vendlindja,p.Shteti,p.Vendbanimi
	,p.Telefoni,p.Email,p.InsertBy,p.InsertDate,p.LUB,p.LUD,p.LUN
	from Personeli as p
	where PersoneliId=@TrajneriID
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Golashenuesi_FshijGolashenuesin]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Golashenuesi_FshijGolashenuesin](
@GolashenuesiID int)
as begin
delete from Golashenuesi
where GolaShenuesiId=@GolashenuesiID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Golashenuesi_MerrGolashenuesMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Golashenuesi_MerrGolashenuesMeID](
@GolashenuesiID int
)
as begin 
select * from Golashenuesi
where GolaShenuesiId=@GolashenuesiID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Golashenuesi_MerrTeGjithListen]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Golashenuesi_MerrTeGjithListen]
as begin
select * from Golashenuesi
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Golashenuesi_ShtooseEdito]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Golashenuesi_ShtooseEdito](
@GolashenuesiID int,
@LojtariID int,
@Golat int,
@NdeshjaID int,
@InsertBy int,
@InsertDate date,
@LUB int ,
@LUD date,
@LUN int
)
as
begin
if(@GolashenuesiID=0)
begin
	insert into Golashenuesi(LojtariID,Golat,NdeshjaId,InsertBy,InsertDate,LUB,LUD,LUN)
	values (@LojtariID,@Golat,@NdeshjaID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)
	end
	else
	begin
	Update Golashenuesi set
	LojtariID=@LojtariID,
	Golat=@Golat,
	NdeshjaId=@NdeshjaID,
	InsertBy=@InsertBy,
	InsertDate=@InsertDate,
	LUB=@LUB,
	LUD=@LUD,
	LUN=@LUN
	where GolaShenuesiId=@GolashenuesiID
	end
	end

GO
/****** Object:  StoredProcedure [dbo].[usp_Klub_FshijKlubMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Klub_FshijKlubMeID](
@KlubiID int)
as begin
	delete from Klubet
	where KlubiId=@KlubiID
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Klub_GjejKlubMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Klub_GjejKlubMeID] (
@KlubiID int)
as
begin
	select * from Klubet
	where KlubiId=@KlubiID 
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Klub_ShtoOseEditoKlub]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Klub_ShtoOseEditoKlub](
@Emertimi varchar(50),
@Vendi varchar(50),
@Kryetari varchar(50),
@Ithemeluar date,
@KlubiID INT,
@StadiumiID INT,
@LigaID int,
@InsertBy int,
@InsertDate date,
@LUB int,
@LUD date,
@LUN int
)
as 
begin 
if(@KlubiID =0)
begin 
insert into Klubet(Emertimi,Vendi,Kryetari,IThemeluar,StadiumiId,LigaId,InsertBy,InsertDate,LUB,LUD,LUN)
values(@Emertimi,@Vendi,@Kryetari,@Ithemeluar,@StadiumiID,@LigaID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)
end
else
begin update Klubet set

Emertimi=@Emertimi,
Vendi=@Vendi,
Kryetari=@Kryetari,
IThemeluar=@Ithemeluar,
InsertBy=@InsertBy,
InsertDate=@InsertDate,
LUB=@LUB,
LUD=@LUD,
LUN=@LUN
where KlubiId=@KlubiID
end
end








GO
/****** Object:  StoredProcedure [dbo].[usp_Klubet_MerriKrejtKlubet]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Klubet_MerriKrejtKlubet]
as begin
select * from Klubet
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Lojtare_ShtoLojtare]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Lojtare_ShtoLojtare](
@Emri nvarchar(50),
@Mbiemri nvarchar(50),
@EmriIPerdoruesit nvarchar(50),
@Fjalkalimi nvarchar(50),
@NumriIFanelles int,
@Gjinia nchar(10),
@Ditelindja date,
@Vendlindja nvarchar(50),
@GrupiIGjakut nvarchar(50),
@Shteti nvarchar(50),
@Vendbanimi nvarchar(50),
@Telefoni nvarchar(50),
@Mail nvarchar(50),
@Pesha decimal,
@Gjatesia decimal,
@PersoneliID int,
@klubiID int,
@InsertBy int,
@InsertDate date,
@LUB int,
@LUD date,
@LUN int
)
as begin 
if(@PersoneliID = 0)
begin
insert into Personeli(Emri,Mbiemri,EmriIPerdoruesit,Fjalekalimi,NumriFanelles,Gjinia,
                      Ditelindja,Vendlindja,GrupiIGjakut,Shteti,Vendbanimi,Telefoni,Email,Pesha,Gjatesia,KlubiId,InsertBy,InsertDate,LUB,LUD,LUN)
	values(@Emri,@Mbiemri,@EmriIPerdoruesit,@Fjalkalimi,@NumriIFanelles,@Gjinia,@Ditelindja,@Vendlindja,
	@GrupiIGjakut,@Shteti,@Vendbanimi,@Telefoni,@Mail,@Pesha,@Gjatesia,@klubiID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)
	
	end
	else 
	begin 
	update Personeli set
	Emri=@Emri,
	Mbiemri=@Mbiemri,
	EmriIPerdoruesit=@EmriIPerdoruesit,
	Fjalekalimi=@Fjalkalimi,
	NumriFanelles=@NumriIFanelles,
	Gjinia=@Gjinia,
	Ditelindja=@Ditelindja,
	Vendlindja=@Vendlindja,
	GrupiIGjakut=@GrupiIGjakut,
	Shteti=@Shteti,
	Vendbanimi=@Vendbanimi,
	Telefoni=@Telefoni,
	Email=@Mail,
	Pesha=@Pesha,
	Gjatesia=@Gjatesia,
	InsertBy=@InsertBy,
	InsertDate=@InsertDate,
	LUB=@LUB,
	LUD=@LUD,
	LUN=@LUN

	where PersoneliId= @PersoneliID
	end
end




GO
/****** Object:  StoredProcedure [dbo].[usp_MerrLojtart]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_MerrLojtart]
as begin
select p.Emri, p.PersoneliId
from Personeli as p
where KlubiID=1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_MerrNdeshjenMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_MerrNdeshjenMeID](
@NdeshjaID int
)
as begin
select * from Ndeshjet
where NdeshjaId=@NdeshjaID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_MerrNdeshjet_PerComboBox]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_MerrNdeshjet_PerComboBox]
as
begin
select n.NdeshjaId
from Ndeshjet as n
where NdeshjaId>=1
end
GO
/****** Object:  StoredProcedure [dbo].[usp_MerrTeGjitha_Ndeshjet]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_MerrTeGjitha_Ndeshjet]
as begin
select * from Ndeshjet
end

GO
/****** Object:  StoredProcedure [dbo].[usp_MerrUsernamedhePass]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_MerrUsernamedhePass]
as
begin
	select p.EmriIPerdoruesit,p.Fjalekalimi
	from Personeli p 
	
end

GO
/****** Object:  StoredProcedure [dbo].[usp_Referat_FshijReferMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Referat_FshijReferMeID](
@ReferiID int)
as 
begin
delete from Personeli
where PersoneliId=@ReferiID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Referat_GjejMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Referat_GjejMeID](@ReferatID int)
as begin
select p.PersoneliID,r.ReferiID,p.Emri,p.Mbiemri,p.EmriIPerdoruesit,p.Fjalekalimi,p.Specializimi,p.Titulli,p.Gjinia,p.Ditelindja,p.Vendlindja,p.Shteti,p.Vendbanimi
	,p.Telefoni,p.Email,r.Pozita,p.InsertBy,p.InsertDate,p.LUB,p.LUD,p.LUN

	from Personeli as p join Referat r
	on p.PersoneliId=r.PersoneliId
	where r.ReferiID=@ReferatID
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Referat_ShtooseEdito]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Referat_ShtooseEdito](
@Emri varchar(50),
@Mbiemri varchar(50),
@EmriIPerdoruesit varchar(50),
@Fjalekalimi varchar(50),
@Specializimi varchar(50),
@Titulli varchar(50),
@Gjinia nchar(10),
@Ditelindja date,
@Vendlindja  varchar(50),
@Shteti varchar(50),
@Vendbanimi  varchar(50),
@Telefoni varchar(50),
@Email  varchar(50),
@RoliID int,
@PersoneliID int,
@Pozita varchar(150),
@NdeshjaID int,
@InsertBy int,
@InsertDate date,
@LUB int,
@LUD date,
@LUN int
)
as
begin
	if(@PersoneliID=0)
	begin
		insert into Personeli(Emri,Mbiemri,EmriIPerdoruesit,Fjalekalimi,Specializimi,Titulli,
		Gjinia,Ditelindja,Vendlindja,Shteti,Vendbanimi,Telefoni,Email,RoliId,InsertBy,InsertDate,LUB,LUD,LUN)
		values(@Emri,@Mbiemri,@EmriIPerdoruesit,@Fjalekalimi,@Specializimi,@Titulli,
		@Gjinia,@Ditelindja,@Vendlindja,@Shteti,@Vendbanimi,@Telefoni,@Email,@RoliID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)

		set @PersoneliID = (select max(PersoneliId) from Personeli)

		insert into Referat(Pozita, PersoneliId, NdeshjaId) values (@Pozita, @PersoneliID, @NdeshjaID)
	end
	else
	begin
		update Personeli set
		Emri=@Emri,
		Mbiemri=@Mbiemri,
		EmriIPerdoruesit=@EmriIPerdoruesit,
		Fjalekalimi=@Fjalekalimi,
		Specializimi=@Specializimi,
		Titulli=@Titulli,
		Gjinia=@Gjinia,
		Ditelindja=@Ditelindja,
		Vendlindja=@Vendlindja,
		Shteti=@Shteti,
		Vendbanimi=@Vendbanimi,
		Telefoni=@Telefoni,
		Email=@Email,
		RoliId=@RoliID,
	InsertBy=@InsertBy,
	InsertDate=@InsertDate,
	LUB=@LUB,
	LUD=@LUD,
	LUN=@LUN
		where PersoneliId= @PersoneliID
		insert into Referat(Pozita,PersoneliId , NdeshjaId) 
		values (@Pozita, @PersoneliID,@NdeshjaID)
	end
end


GO
/****** Object:  StoredProcedure [dbo].[usp_ShfaqTeGjitheTrajner]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_ShfaqTeGjitheTrajner]
as begin
select p.PersoneliId,p.Emri, p.Mbiemri,p.EmriIPerdoruesit, p.Fjalekalimi,p.Specializimi,p.Titulli,
  p.Gjinia, p.Ditelindja,
	p.Vendlindja, p.Shteti,p.Vendbanimi,p.Telefoni,p.Email,p.KlubiId,p.RoliId,p.InsertBy,p.InsertDate,p.LUB,p.LUD,p.LUN
from Personeli as p 
where KlubiId =1 and RoliId=2
end
GO
/****** Object:  StoredProcedure [dbo].[usp_ShfaqTeGjithLojtaret]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_ShfaqTeGjithLojtaret]
as
begin
	select p.PersoneliId,p.Emri, p.Mbiemri,p.EmriIPerdoruesit, p.Fjalekalimi, p.NumriFanelles, p.Gjinia, p.Ditelindja,
	p.Vendlindja,p.GrupiIGjakut, p.Shteti,p.Vendbanimi,p.Telefoni,p.Email,p.Pesha,p.Gjatesia,p.KlubiId,p.InsertBy,p.InsertDate,p.LUB,p.LUD,p.LUN
	 from Personeli as p
where KlubiId is not null
end
GO
/****** Object:  StoredProcedure [dbo].[usp_ShtooseEdito_Ndeshje]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_ShtooseEdito_Ndeshje](
@NdeshjaID int,
@DataENdeshjes datetime,
@Sezoni char(10),
@RaportiIAmbulances text,
@RaportiIPolicis text,
@KlubiVendasID int,
@KlubiNikoqirID int,
@FormacioniID int,
@StadiumiID int,
@InsertBy int,
@InsertDate date,
@LUB int ,
@LUD date,
@LUN int
)
as begin
if(@NdeshjaID=0)
begin
insert into Ndeshjet(DataENdeshjes,Sezoni,RaportiIAmbulances,RaportiIPolicise,KlubiVendasId,KlubiNikoqirId
,FormacioniId,StadiumiId,InsertBy,InsertDate,LUB,LUD,LUN)
values (@DataENdeshjes,@Sezoni,@RaportiIAmbulances,@RaportiIPolicis,@KlubiVendasID,@KlubiNikoqirID,
@FormacioniID,@StadiumiID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)
end
else
begin
update Ndeshjet set
DataENdeshjes=@DataENdeshjes,
Sezoni=@Sezoni,
RaportiIAmbulances=@RaportiIAmbulances,
RaportiIPolicise=@RaportiIPolicis,
InsertBy=@InsertBy,
InsertDate=@InsertDate,
LUB=@LUB,
LUD=@LUD,
LUN=@LUN
where NdeshjaId=@NdeshjaID
end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_ShtooseEditoTrajner]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_ShtooseEditoTrajner](
@Emri varchar(50),
@Mbiemri varchar(50),
@EmriIPerdoruesit varchar(50),
@Fjalekalimi varchar(50),
@Specializimi varchar(50),
@Titulli varchar(50),
@Gjinia nchar(10),
@Ditelindja date,
@Vendlindja  varchar(50),
@Shteti varchar(50),
@Vendbanimi  varchar(50),
@Telefoni varchar(50),
@Email  varchar(50),
@PersoneliID int,
@KlubiID int,
@RoliID int,
@InsertBy int,
@InsertDate date,
@LUB int,
@LUD date,
@LUN int
)
as
begin
if(@PersoneliID=0)
begin
	insert into Personeli(Emri,Mbiemri,EmriIPerdoruesit,Fjalekalimi,Specializimi,Titulli,Gjinia,Ditelindja,Vendlindja,Shteti,Vendbanimi,Telefoni,Email,
	KlubiId,RoliId,InsertBy,InsertDate,LUB,LUD,LUN)
	values(@Emri,@Mbiemri,@EmriIPerdoruesit,@Fjalekalimi,@Specializimi,@Titulli,@Gjinia,@Ditelindja,@Vendlindja,@Shteti,@Vendbanimi,@Telefoni,@Email,
	@KlubiID,@RoliID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)
	end
	else
	begin
	update Personeli set
	Emri=@Emri,
	Mbiemri=@Mbiemri,
	EmriIPerdoruesit=@EmriIPerdoruesit,
	Fjalekalimi=@Fjalekalimi,
	Specializimi=@Specializimi,
	Titulli=@Titulli,
	Gjinia=@Gjinia,
	Ditelindja=@Ditelindja,
	Vendlindja=@Vendlindja,
	Shteti=@Shteti,
	Vendbanimi=@Vendbanimi,
	Telefoni=@Telefoni,
	Email=@Email,
	InsertBy=@InsertBy,
	InsertDate=@InsertDate,
	LUB=@LUB,
	LUD=@LUD,
	LUN=@LUN

	where PersoneliId= @PersoneliID
	end
end

GO
/****** Object:  StoredProcedure [dbo].[usp_Ushtrim_FshijUshtrimMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Ushtrim_FshijUshtrimMeID](
@UshtrimID int)
as begin
	delete from Ushtrimet
	where UshtrimId=@UshtrimID
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Ushtrim_GjejMeIDUshtrim]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Ushtrim_GjejMeIDUshtrim] (
@UshtrimeID int)
as
begin
	select * from Ushtrimet
	where UshtrimId=@UshtrimeID 
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Ushtrime_MerriTeGjithaUshtrimet]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Ushtrime_MerriTeGjithaUshtrimet]
as begin
select * from Ushtrimet
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Ushtrime_ShtoOseEdito]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_Ushtrime_ShtoOseEdito](
@UshtrimiID int,
@Dita varchar(50),
@Ora varchar(50),
@KlubiID int,
@InsertBy int,
@InsertDate date,
@LUB INT,
@LUD date,
@LUN INT
)
as 
begin 
if(@UshtrimiID =0)
begin 
insert into Ushtrimet(Dita,Ora,KlubiId,InsertBy,InsertDate,LUB,LUD,LUN)
values(@Dita,@Ora,@KlubiID,@InsertBy,@InsertDate,@LUB,@LUD,@LUN)
end
else
begin update Ushtrimet set

Dita=@Dita,
Ora=@Ora,
InsertBy=@InsertBy,
InsertDate=@InsertDate,
LUB=@LUB,
LUD=@LUD,
LUN=@LUN
where UshtrimId=@UshtrimiID
end
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Vlersimet_FshijVlersimetMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Vlersimet_FshijVlersimetMeID](
@StatusiID int
)
as begin
delete from Statusi_Lojtarit
where StatusiID =@StatusiID
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Vlersimet_MerrTeGjithaVlersimet]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Vlersimet_MerrTeGjithaVlersimet]
as begin
select p.StatusiID,p.LojtariId,p.Vleresimi,p.InsertBy,p.InsertDate,p.LUB,p.LUD,p.LUN 
	from Statusi_Lojtarit as p
	where Vleresimi is not null
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Vlersimet_MerrVlersimetMeID]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Vlersimet_MerrVlersimetMeID](
@StatusiID int
)
as begin
	select p.LojtariId,p.Vleresimi 
	from Statusi_Lojtarit as p
	where p.StatusiID=@StatusiID
	end
GO
/****** Object:  StoredProcedure [dbo].[usp_Vlersimet_ShtooseEdito]    Script Date: 5/6/2020 6:03:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Vlersimet_ShtooseEdito](
@StatusiID int,
@LojtariID int,
@Vlersimi decimal,
@InsertBY int,
@InsertDate date,
@LUB int,
@LUD date,
@LUN int
)
as
begin
	if(@StatusiID=0)
	begin
		insert into Statusi_Lojtarit(LojtariId,Vleresimi,InsertBy,InsertDate,LUB,LUD,LUN)
		values(@LojtariID, @Vlersimi,@InsertBY,@InsertDate,@LUB,@LUD,@LUN)
	end
	else
		begin
			update Statusi_Lojtarit set
			LojtariId=@LojtariID,
			Vleresimi=@Vlersimi,
			InsertBy=@InsertBY,
			InsertDate=@InsertDate,
			LUB=@LUB,
			LUD=@LUD,
			LUN=@LUN
			where StatusiID=@StatusiID
		end
end






GO
USE [master]
GO
ALTER DATABASE [Gjeneta] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [KlubiFutbollistikTI1]    Script Date: 4/14/2020 10:58:37 PM ******/
CREATE DATABASE [KlubiFutbollistikTI1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KlubiFutbollistikTI1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\KlubiFutbollistikTI1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'KlubiFutbollistikTI1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\KlubiFutbollistikTI1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KlubiFutbollistikTI1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET ARITHABORT OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET  MULTI_USER 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET DELAYED_DURABILITY = DISABLED 
GO
USE [KlubiFutbollistikTI1]
GO
/****** Object:  Table [dbo].[Delegati]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delegati](
	[NdeshjaID] [int] NULL,
	[PersoniID] [int] NULL,
	[Roli] [nvarchar](50) NULL,
	[RaportPasNdeshjes] [text] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Formacioni]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formacioni](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LojtariID] [int] NOT NULL,
	[Roli] [nvarchar](50) NULL,
	[NumriILojtareve] [int] NULL,
	[StatusiID] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK__Formacio__DE714DBF821250D1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Golashenues]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Golashenues](
	[NdeshjaID] [int] NOT NULL,
	[KlubiID] [int] NULL,
	[LojtariID] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NdeshjaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kategoria]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoria](
	[KategoriaID] [int] NOT NULL,
	[Prej] [int] NULL,
	[Deri] [int] NULL,
	[PersoniID] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[KategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Klubi]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klubi](
	[KlubiID] [int] NOT NULL,
	[Emertimi] [nvarchar](50) NULL,
	[Vendi] [nvarchar](50) NULL,
	[Stadiumi] [nvarchar](50) NULL,
	[Kryetari] [nvarchar](50) NULL,
	[LigaID] [int] NULL,
	[KlubiNikoqir] [nvarchar](50) NULL,
	[KlubiMysafir] [nvarchar](50) NULL,
	[Rezultati] [text] NULL,
	[Themeluar] [date] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[KlubiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kontrolla_Mjekesore]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kontrolla_Mjekesore](
	[KontrollaID] [int] NOT NULL,
	[KontrollaData] [date] NULL,
	[Kontrolla] [varchar](50) NULL,
	[PersoniID] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[KontrollaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Liga]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Liga](
	[LigaID] [int] NOT NULL,
	[KlubiID] [int] NULL,
	[VitiKalendarik] [date] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[LigaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lojtari]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lojtari](
	[LojtariID] [int] NOT NULL,
	[PersoniID] [int] NULL,
	[KategoriaID] [int] NULL,
	[KlubiID] [int] NULL,
	[KontrollaMjekesoreID] [int] NULL,
	[Pesha] [decimal](18, 0) NULL,
	[Gjatesia] [decimal](18, 0) NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[LojtariID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lojtari_I_Ndeshjes]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lojtari_I_Ndeshjes](
	[NdeshjaID] [int] NOT NULL,
	[KlubiID] [int] NULL,
	[LojtariID] [int] NULL,
	[Pozita] [nvarchar](50) NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NdeshjaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ndeshja]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ndeshja](
	[NdeshjaID] [int] NOT NULL,
	[DataNdeshjes] [date] NULL,
	[VitiKalendarik] [date] NULL,
	[Sezoni] [nvarchar](50) NULL,
	[KlubiID] [int] NULL,
	[FormacioniID] [int] NULL,
	[Stadiumi] [nvarchar](50) NULL,
	[RaportiAmbulances] [text] NULL,
	[RaportiPolicor] [text] NULL,
	[LigaID] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NdeshjaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personeli]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeli](
	[PersoniID] [int] NOT NULL,
	[Emri] [nvarchar](50) NULL,
	[Mbiemri] [nvarchar](50) NULL,
	[Specializimi] [nvarchar](50) NULL,
	[Titulli] [nvarchar](50) NULL,
	[VendiIPunes] [nvarchar](50) NULL,
	[Gjinia] [bit] NULL,
	[Ditelindja] [date] NULL,
	[Vendlindja] [nvarchar](50) NULL,
	[GrupiIGjakut] [nvarchar](50) NULL,
	[Shteti] [nvarchar](50) NULL,
	[Vendbanimi] [nvarchar](50) NULL,
	[Telefoni] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[AnetareteGrupit] [nvarchar](50) NULL,
	[NderrimiIPunes] [nvarchar](50) NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUN] [int] NULL,
	[LUD] [date] NULL,
 CONSTRAINT [PK_tbl_Personeli] PRIMARY KEY CLUSTERED 
(
	[PersoniID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pozita]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pozita](
	[PozitaID] [int] NOT NULL,
	[Pozita] [nvarchar](50) NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PozitaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Raporti]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raporti](
	[VlersimiID] [int] NOT NULL,
	[KlubiID] [int] NULL,
	[NdeshjaID] [int] NULL,
	[PersoniIDNikoqir] [int] NULL,
	[PersoniIDMysafir] [int] NULL,
	[TekstiNikoqir] [text] NULL,
	[TekstiMysafir] [text] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[VlersimiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Referi]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Referi](
	[ReferiID] [int] NOT NULL,
	[NdeshjaID] [int] NULL,
	[PersoniID] [int] NULL,
	[PozitaID] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReferiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] NOT NULL,
	[EmriIRolit] [nvarchar](50) NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StafiKategorive]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StafiKategorive](
	[KategoriaID] [int] NOT NULL,
	[PersoniID] [int] NULL,
	[Pozita] [int] NULL,
	[KontrataDerMe] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[KategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Statusi_Lojtarit]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statusi_Lojtarit](
	[StatusiID] [int] NOT NULL,
	[Pergjegjes] [nvarchar](50) NULL,
	[Rezerve] [nvarchar](50) NULL,
	[Huazim] [nvarchar](50) NULL,
	[Shoqerues] [nvarchar](50) NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StatusiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Te_Larguar]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Te_Larguar](
	[Ndeshja] [int] NOT NULL,
	[KlubiID] [int] NULL,
	[LojtariID] [int] NULL,
	[Nderrim] [nvarchar](50) NULL,
	[Largim] [nvarchar](50) NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ndeshja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] NOT NULL,
	[EmriIPerdoruesit] [nvarchar](50) NULL,
	[PasswordiPerdoruesit] [nvarchar](50) NULL,
	[DataSkadimit] [date] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserRolesID] [int] NOT NULL,
	[UserID] [int] NULL,
	[RoleID] [int] NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserRolesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vlersimi]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vlersimi](
	[VlersimiID] [int] NOT NULL,
	[KlubiID] [int] NULL,
	[LojtariID] [int] NULL,
	[Nota] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [date] NULL,
	[LUB] [int] NULL,
	[LUD] [date] NULL,
	[LUN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[VlersimiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Delegati]  WITH CHECK ADD  CONSTRAINT [FK_Delegati_Ndeshja] FOREIGN KEY([NdeshjaID])
REFERENCES [dbo].[Ndeshja] ([NdeshjaID])
GO
ALTER TABLE [dbo].[Delegati] CHECK CONSTRAINT [FK_Delegati_Ndeshja]
GO
ALTER TABLE [dbo].[Delegati]  WITH CHECK ADD  CONSTRAINT [FK_Delegati_Personeli] FOREIGN KEY([PersoniID])
REFERENCES [dbo].[Personeli] ([PersoniID])
GO
ALTER TABLE [dbo].[Delegati] CHECK CONSTRAINT [FK_Delegati_Personeli]
GO
ALTER TABLE [dbo].[Formacioni]  WITH CHECK ADD  CONSTRAINT [FK_Formacioni_Lojtari] FOREIGN KEY([LojtariID])
REFERENCES [dbo].[Lojtari] ([LojtariID])
GO
ALTER TABLE [dbo].[Formacioni] CHECK CONSTRAINT [FK_Formacioni_Lojtari]
GO
ALTER TABLE [dbo].[Formacioni]  WITH CHECK ADD  CONSTRAINT [FK_Formacioni_Statusi_Lojtarit] FOREIGN KEY([StatusiID])
REFERENCES [dbo].[Statusi_Lojtarit] ([StatusiID])
GO
ALTER TABLE [dbo].[Formacioni] CHECK CONSTRAINT [FK_Formacioni_Statusi_Lojtarit]
GO
ALTER TABLE [dbo].[Golashenues]  WITH CHECK ADD  CONSTRAINT [FK_Golashenues_Klubi] FOREIGN KEY([KlubiID])
REFERENCES [dbo].[Klubi] ([KlubiID])
GO
ALTER TABLE [dbo].[Golashenues] CHECK CONSTRAINT [FK_Golashenues_Klubi]
GO
ALTER TABLE [dbo].[Golashenues]  WITH CHECK ADD  CONSTRAINT [FK_Golashenues_Lojtari] FOREIGN KEY([LojtariID])
REFERENCES [dbo].[Lojtari] ([LojtariID])
GO
ALTER TABLE [dbo].[Golashenues] CHECK CONSTRAINT [FK_Golashenues_Lojtari]
GO
ALTER TABLE [dbo].[Kategoria]  WITH CHECK ADD  CONSTRAINT [FK_Kategoria_StafiKategorive] FOREIGN KEY([KategoriaID])
REFERENCES [dbo].[StafiKategorive] ([KategoriaID])
GO
ALTER TABLE [dbo].[Kategoria] CHECK CONSTRAINT [FK_Kategoria_StafiKategorive]
GO
ALTER TABLE [dbo].[Klubi]  WITH CHECK ADD  CONSTRAINT [FK_Klubi_Liga] FOREIGN KEY([LigaID])
REFERENCES [dbo].[Liga] ([LigaID])
GO
ALTER TABLE [dbo].[Klubi] CHECK CONSTRAINT [FK_Klubi_Liga]
GO
ALTER TABLE [dbo].[Kontrolla_Mjekesore]  WITH CHECK ADD  CONSTRAINT [FK_Kontrolla_Mjekesore_Personeli] FOREIGN KEY([PersoniID])
REFERENCES [dbo].[Personeli] ([PersoniID])
GO
ALTER TABLE [dbo].[Kontrolla_Mjekesore] CHECK CONSTRAINT [FK_Kontrolla_Mjekesore_Personeli]
GO
ALTER TABLE [dbo].[Lojtari]  WITH CHECK ADD  CONSTRAINT [FK_Lojtari_Kategoria] FOREIGN KEY([KategoriaID])
REFERENCES [dbo].[Kategoria] ([KategoriaID])
GO
ALTER TABLE [dbo].[Lojtari] CHECK CONSTRAINT [FK_Lojtari_Kategoria]
GO
ALTER TABLE [dbo].[Lojtari]  WITH CHECK ADD  CONSTRAINT [FK_Lojtari_Klubi] FOREIGN KEY([KlubiID])
REFERENCES [dbo].[Klubi] ([KlubiID])
GO
ALTER TABLE [dbo].[Lojtari] CHECK CONSTRAINT [FK_Lojtari_Klubi]
GO
ALTER TABLE [dbo].[Lojtari]  WITH CHECK ADD  CONSTRAINT [FK_Lojtari_Kontrolla_Mjekesore] FOREIGN KEY([KontrollaMjekesoreID])
REFERENCES [dbo].[Kontrolla_Mjekesore] ([KontrollaID])
GO
ALTER TABLE [dbo].[Lojtari] CHECK CONSTRAINT [FK_Lojtari_Kontrolla_Mjekesore]
GO
ALTER TABLE [dbo].[Lojtari]  WITH CHECK ADD  CONSTRAINT [FK_Lojtari_Personeli] FOREIGN KEY([PersoniID])
REFERENCES [dbo].[Personeli] ([PersoniID])
GO
ALTER TABLE [dbo].[Lojtari] CHECK CONSTRAINT [FK_Lojtari_Personeli]
GO
ALTER TABLE [dbo].[Lojtari_I_Ndeshjes]  WITH CHECK ADD  CONSTRAINT [FK_Lojtari_I_Ndeshjes_Lojtari] FOREIGN KEY([LojtariID])
REFERENCES [dbo].[Lojtari] ([LojtariID])
GO
ALTER TABLE [dbo].[Lojtari_I_Ndeshjes] CHECK CONSTRAINT [FK_Lojtari_I_Ndeshjes_Lojtari]
GO
ALTER TABLE [dbo].[Ndeshja]  WITH CHECK ADD  CONSTRAINT [FK_Ndeshja_Golashenues] FOREIGN KEY([NdeshjaID])
REFERENCES [dbo].[Golashenues] ([NdeshjaID])
GO
ALTER TABLE [dbo].[Ndeshja] CHECK CONSTRAINT [FK_Ndeshja_Golashenues]
GO
ALTER TABLE [dbo].[Ndeshja]  WITH CHECK ADD  CONSTRAINT [FK_Ndeshja_Klubi] FOREIGN KEY([KlubiID])
REFERENCES [dbo].[Klubi] ([KlubiID])
GO
ALTER TABLE [dbo].[Ndeshja] CHECK CONSTRAINT [FK_Ndeshja_Klubi]
GO
ALTER TABLE [dbo].[Ndeshja]  WITH CHECK ADD  CONSTRAINT [FK_Ndeshja_Liga] FOREIGN KEY([LigaID])
REFERENCES [dbo].[Liga] ([LigaID])
GO
ALTER TABLE [dbo].[Ndeshja] CHECK CONSTRAINT [FK_Ndeshja_Liga]
GO
ALTER TABLE [dbo].[Ndeshja]  WITH CHECK ADD  CONSTRAINT [FK_Ndeshja_Lojtari_I_Ndeshjes] FOREIGN KEY([NdeshjaID])
REFERENCES [dbo].[Lojtari_I_Ndeshjes] ([NdeshjaID])
GO
ALTER TABLE [dbo].[Ndeshja] CHECK CONSTRAINT [FK_Ndeshja_Lojtari_I_Ndeshjes]
GO
ALTER TABLE [dbo].[Raporti]  WITH CHECK ADD  CONSTRAINT [FK_Raporti_Klubi] FOREIGN KEY([KlubiID])
REFERENCES [dbo].[Klubi] ([KlubiID])
GO
ALTER TABLE [dbo].[Raporti] CHECK CONSTRAINT [FK_Raporti_Klubi]
GO
ALTER TABLE [dbo].[Raporti]  WITH CHECK ADD  CONSTRAINT [FK_Raporti_Vlersimi] FOREIGN KEY([VlersimiID])
REFERENCES [dbo].[Vlersimi] ([VlersimiID])
GO
ALTER TABLE [dbo].[Raporti] CHECK CONSTRAINT [FK_Raporti_Vlersimi]
GO
ALTER TABLE [dbo].[Referi]  WITH CHECK ADD  CONSTRAINT [FK_Referi_Ndeshja] FOREIGN KEY([NdeshjaID])
REFERENCES [dbo].[Ndeshja] ([NdeshjaID])
GO
ALTER TABLE [dbo].[Referi] CHECK CONSTRAINT [FK_Referi_Ndeshja]
GO
ALTER TABLE [dbo].[Referi]  WITH CHECK ADD  CONSTRAINT [FK_Referi_Personeli] FOREIGN KEY([PersoniID])
REFERENCES [dbo].[Personeli] ([PersoniID])
GO
ALTER TABLE [dbo].[Referi] CHECK CONSTRAINT [FK_Referi_Personeli]
GO
ALTER TABLE [dbo].[Referi]  WITH CHECK ADD  CONSTRAINT [FK_Referi_Pozita] FOREIGN KEY([PozitaID])
REFERENCES [dbo].[Pozita] ([PozitaID])
GO
ALTER TABLE [dbo].[Referi] CHECK CONSTRAINT [FK_Referi_Pozita]
GO
ALTER TABLE [dbo].[Te_Larguar]  WITH CHECK ADD  CONSTRAINT [FK_Te_Larguar_Klubi] FOREIGN KEY([KlubiID])
REFERENCES [dbo].[Klubi] ([KlubiID])
GO
ALTER TABLE [dbo].[Te_Larguar] CHECK CONSTRAINT [FK_Te_Larguar_Klubi]
GO
ALTER TABLE [dbo].[Te_Larguar]  WITH CHECK ADD  CONSTRAINT [FK_Te_Larguar_Lojtari] FOREIGN KEY([LojtariID])
REFERENCES [dbo].[Lojtari] ([LojtariID])
GO
ALTER TABLE [dbo].[Te_Larguar] CHECK CONSTRAINT [FK_Te_Larguar_Lojtari]
GO
ALTER TABLE [dbo].[Te_Larguar]  WITH CHECK ADD  CONSTRAINT [FK_Te_Larguar_Ndeshja] FOREIGN KEY([Ndeshja])
REFERENCES [dbo].[Ndeshja] ([NdeshjaID])
GO
ALTER TABLE [dbo].[Te_Larguar] CHECK CONSTRAINT [FK_Te_Larguar_Ndeshja]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Role]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_User]
GO
ALTER TABLE [dbo].[Vlersimi]  WITH CHECK ADD  CONSTRAINT [FK_Vlersimi_Klubi] FOREIGN KEY([KlubiID])
REFERENCES [dbo].[Klubi] ([KlubiID])
GO
ALTER TABLE [dbo].[Vlersimi] CHECK CONSTRAINT [FK_Vlersimi_Klubi]
GO
ALTER TABLE [dbo].[Vlersimi]  WITH CHECK ADD  CONSTRAINT [FK_Vlersimi_Lojtari] FOREIGN KEY([LojtariID])
REFERENCES [dbo].[Lojtari] ([LojtariID])
GO
ALTER TABLE [dbo].[Vlersimi] CHECK CONSTRAINT [FK_Vlersimi_Lojtari]
GO
/****** Object:  StoredProcedure [dbo].[usp_Personel_FshijPersonel]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Personel_FshijPersonel]
(
	@PersoniID int
)
as
begin 
	delete from Personeli where PersoniID=@PersoniID 
end


GO
/****** Object:  StoredProcedure [dbo].[usp_Personel_GetAllPersonel]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[usp_Personel_GetAllPersonel]
as
begin
select * from Personeli
end


GO
/****** Object:  StoredProcedure [dbo].[usp_Personel_ShtoPersonel]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE[dbo].[usp_Personel_ShtoPersonel](
@Emri nvarchar(50),
@Mbiemri nvarchar(50), 
@Specializimi nvarchar(50),
@Titulli nvarchar(50),
@VendiIPunes nvarchar(50),
@Gjinia bit,
@Ditelindja date,
@Vendlindja nvarchar(50),
@GrupiIGjakut nvarchar(50),
@Shteti nvarchar(50),
@Vendbanimi nvarchar(50),
@Telefoni nvarchar(50),
@Mail nvarchar(50),
@AnetareteGrupit nvarchar(50),
@NderrimiIPunes nvarchar(50),
@InsertBy int,
@InsertDate date,
@LUB int,
@LUN INT,
@LUD date)
as
begin
	insert into Personeli(Emri, Mbiemri, Specializimi, Titulli, VendiIPunes,Gjinia,Ditelindja,Vendlindja,GrupiIGjakut,Shteti,
	Vendbanimi,Telefoni,Mail,AnetareteGrupit,NderrimiIPunes,InsertBy,InsertDate,LUB,LUN,LUD)
	 
	values (@Emri, @Mbiemri,  @Specializimi, @Titulli, @VendiIPunes,@Gjinia,@Ditelindja,@Vendlindja,@GrupiIGjakut,@Shteti,
	 @Vendbanimi,@Telefoni,@Mail,@AnetareteGrupit,@NderrimiIPunes,@InsertBy,@InsertDate,@LUB,@LUN,@LUD)
end


GO
/****** Object:  StoredProcedure [dbo].[usp_Personel_UpdatePersonel]    Script Date: 4/14/2020 10:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Personel_UpdatePersonel]
(
@Emri nvarchar(50),
@Mbiemri nvarchar(50), 
@Specializimi nvarchar(50),
@Titulli nvarchar(50),
@VendiIPunes nvarchar(50),
@Gjinia bit,
@Ditelindja date,
@Vendlindja nvarchar(50),
@GrupiIGjakut nvarchar(50),
@Shteti nvarchar(50),
@Vendbanimi nvarchar(50),
@Telefoni nvarchar(50),
@Mail nvarchar(50),
@AnetareteGrupit nvarchar(50),
@NderrimiIPunes nvarchar(50),
@InsertBy int,
@InsertDate date,
@LUB int,
@LUN INT,
@LUD date
)
as
begin
	update Personeli
	set Emri=@Emri, 
	Mbiemri= @Mbiemri,
	Specializimi =@Specializimi,
	Titulli = @Titulli,
	 VendiIPunes=@VendiIPunes,
	 Gjinia=@Gjinia,
	 Ditelindja=@Ditelindja,
	 Vendlindja=@Vendlindja,
	 GrupiIGjakut=@GrupiIGjakut,
	 Shteti =@Shteti,
	Vendbanimi=@Vendbanimi,
	Telefoni=@Telefoni,
	Mail=@Mail,
	AnetareteGrupit=@AnetareteGrupit,
	NderrimiIPunes=@NderrimiIPunes,
	InsertBy=@InsertBy,
	InsertDate=@InsertDate,
	LUB=@LUB,
	LUN=@LUN,
	LUD=@LUD
end


GO
USE [master]
GO
ALTER DATABASE [KlubiFutbollistikTI1] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [EarthDatabase]    Script Date: 24/08/2014 18:59:56 ******/
CREATE DATABASE [EarthDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EarthDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EarthDatabase.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EarthDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\EarthDatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EarthDatabase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EarthDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EarthDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EarthDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EarthDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EarthDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EarthDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [EarthDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EarthDatabase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EarthDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EarthDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EarthDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EarthDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EarthDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EarthDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EarthDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EarthDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EarthDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EarthDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EarthDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EarthDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EarthDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EarthDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EarthDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EarthDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EarthDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EarthDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [EarthDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EarthDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EarthDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EarthDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [EarthDatabase]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 24/08/2014 18:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AddressName] [nvarchar](100) NOT NULL,
	[TownId] [int] NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Continents]    Script Date: 24/08/2014 18:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Continents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Continents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 24/08/2014 18:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ContinentId] [int] NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[People]    Script Date: 24/08/2014 18:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Towns]    Script Date: 24/08/2014 18:59:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Towns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_Towns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] ([Id], [AddressName], [TownId]) VALUES (1, N'George Dimitrov', 1)
INSERT [dbo].[Addresses] ([Id], [AddressName], [TownId]) VALUES (2, N'Brandenburg Gate', 3)
SET IDENTITY_INSERT [dbo].[Addresses] OFF
SET IDENTITY_INSERT [dbo].[Continents] ON 

INSERT [dbo].[Continents] ([Id], [Name]) VALUES (1, N'Europe')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (2, N'Africa')
INSERT [dbo].[Continents] ([Id], [Name]) VALUES (3, N'Asia')
SET IDENTITY_INSERT [dbo].[Continents] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([id], [Name], [ContinentId]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[Countries] ([id], [Name], [ContinentId]) VALUES (2, N'China', 3)
INSERT [dbo].[Countries] ([id], [Name], [ContinentId]) VALUES (3, N'Egypt', 2)
INSERT [dbo].[Countries] ([id], [Name], [ContinentId]) VALUES (4, N'Germany', 1)
INSERT [dbo].[Countries] ([id], [Name], [ContinentId]) VALUES (5, N'France', 1)
INSERT [dbo].[Countries] ([id], [Name], [ContinentId]) VALUES (6, N'Japan', 3)
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[People] ON 

INSERT [dbo].[People] ([Id], [FirstName], [LastName], [AddressId]) VALUES (1, N'Me', N'Me', 1)
INSERT [dbo].[People] ([Id], [FirstName], [LastName], [AddressId]) VALUES (2, N'Angela', N'Merkel', 2)
SET IDENTITY_INSERT [dbo].[People] OFF
SET IDENTITY_INSERT [dbo].[Towns] ON 

INSERT [dbo].[Towns] ([Id], [Name], [CountryId]) VALUES (1, N'Chirpan', 1)
INSERT [dbo].[Towns] ([Id], [Name], [CountryId]) VALUES (2, N'Sofia', 1)
INSERT [dbo].[Towns] ([Id], [Name], [CountryId]) VALUES (3, N'Berlin', 4)
SET IDENTITY_INSERT [dbo].[Towns] OFF
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_Towns] FOREIGN KEY([TownId])
REFERENCES [dbo].[Towns] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_Towns]
GO
ALTER TABLE [dbo].[Countries]  WITH CHECK ADD  CONSTRAINT [FK_Countries_Continents] FOREIGN KEY([ContinentId])
REFERENCES [dbo].[Continents] ([Id])
GO
ALTER TABLE [dbo].[Countries] CHECK CONSTRAINT [FK_Countries_Continents]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [FK_People_Addresses] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([Id])
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [FK_People_Addresses]
GO
ALTER TABLE [dbo].[Towns]  WITH CHECK ADD  CONSTRAINT [FK_Towns_Countries] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Countries] ([id])
GO
ALTER TABLE [dbo].[Towns] CHECK CONSTRAINT [FK_Towns_Countries]
GO
USE [master]
GO
ALTER DATABASE [EarthDatabase] SET  READ_WRITE 
GO

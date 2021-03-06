USE [master]
GO
/****** Object:  Database [OSSRB]    Script Date: 17.9.2020. 06:44:47 ******/
CREATE DATABASE [OSSRB]
GO
ALTER DATABASE [OSSRB] SET COMPATIBILITY_LEVEL = 140
GO
ALTER DATABASE [OSSRB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OSSRB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OSSRB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OSSRB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OSSRB] SET ARITHABORT OFF 
GO
ALTER DATABASE [OSSRB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OSSRB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OSSRB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OSSRB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OSSRB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OSSRB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OSSRB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OSSRB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OSSRB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OSSRB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OSSRB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OSSRB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OSSRB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OSSRB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OSSRB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OSSRB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OSSRB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OSSRB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OSSRB] SET  MULTI_USER 
GO
ALTER DATABASE [OSSRB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OSSRB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OSSRB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OSSRB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OSSRB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OSSRB] SET QUERY_STORE = OFF
GO
USE [OSSRB]
GO
/****** Object:  Table [dbo].[Delegat]    Script Date: 17.9.2020. 06:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delegat](
	[delegatID] [int] NOT NULL,
	[ime] [varchar](50) NULL,
	[prezime] [varchar](50) NULL,
	[korisnickoIme] [varchar](50) NULL,
	[korisnickaSifra] [varchar](50) NULL,
 CONSTRAINT [PK_Delegat] PRIMARY KEY CLUSTERED 
(
	[delegatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hala]    Script Date: 17.9.2020. 06:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hala](
	[halaID] [int] NOT NULL,
	[naziv] [varchar](150) NULL,
	[kapacitet] [int] NULL,
	[adresa] [varchar](50) NULL,
 CONSTRAINT [PK_Hala] PRIMARY KEY CLUSTERED 
(
	[halaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kolo]    Script Date: 17.9.2020. 06:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kolo](
	[koloID] [int] NOT NULL,
	[naziv] [varchar](150) NULL,
	[datumOd] [datetime] NULL,
	[datumDo] [datetime] NULL,
	[ligaID] [int] NULL,
	[delegatID] [int] NULL,
 CONSTRAINT [PK_Kolo] PRIMARY KEY CLUSTERED 
(
	[koloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Liga]    Script Date: 17.9.2020. 06:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Liga](
	[ligaID] [int] NOT NULL,
	[naziv] [varchar](150) NULL,
	[sponzor] [varchar](150) NULL,
 CONSTRAINT [PK_Liga] PRIMARY KEY CLUSTERED 
(
	[ligaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mec]    Script Date: 17.9.2020. 06:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mec](
	[mecID] [int] NOT NULL,
	[koloID] [int] NOT NULL,
	[datumVreme] [datetime] NULL,
	[domacinID] [int] NULL,
	[gostID] [int] NULL,
	[setovaDomacin] [int] NULL,
	[setovaGost] [int] NULL,
	[status] [varchar](50) NULL,
	[halaID] [int] NULL,
 CONSTRAINT [PK_Mec] PRIMARY KEY CLUSTERED 
(
	[mecID] ASC,
	[koloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Set]    Script Date: 17.9.2020. 06:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Set](
	[setID] [int] NOT NULL,
	[mecID] [int] NOT NULL,
	[koloID] [int] NOT NULL,
	[poenaDomacin] [int] NULL,
	[poenaGost] [int] NULL,
 CONSTRAINT [PK_Set] PRIMARY KEY CLUSTERED 
(
	[setID] ASC,
	[mecID] ASC,
	[koloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tim]    Script Date: 17.9.2020. 06:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tim](
	[timID] [int] NOT NULL,
	[naziv] [varchar](150) NULL,
	[mesto] [varchar](50) NULL,
	[ligaID] [int] NULL,
	[delegatID] [int] NULL,
 CONSTRAINT [PK_Tim] PRIMARY KEY CLUSTERED 
(
	[timID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Delegat] ([delegatID], [ime], [prezime], [korisnickoIme], [korisnickaSifra]) VALUES (1, N'Aleksandra', N'Stepanovic', N'beba', N'beba')
INSERT [dbo].[Delegat] ([delegatID], [ime], [prezime], [korisnickoIme], [korisnickaSifra]) VALUES (2, N'Aleksandra', N'Stepanovic', N'aleksandras', N'aleksandras')
INSERT [dbo].[Hala] ([halaID], [naziv], [kapacitet], [adresa]) VALUES (1, N'SC Vizura', 500, N'Tošin bunar 224a, Beograd')
INSERT [dbo].[Hala] ([halaID], [naziv], [kapacitet], [adresa]) VALUES (2, N'SC Voždovac', 2300, N'Crnotravska 4, Beograd')
INSERT [dbo].[Hala] ([halaID], [naziv], [kapacitet], [adresa]) VALUES (3, N'Dudova šuma', 2500, N'Ferenca Sepa 3, Subotica')
INSERT [dbo].[Hala] ([halaID], [naziv], [kapacitet], [adresa]) VALUES (4, N'Hala sportova Lajkovac', 850, N'Vuka Karadžica 21, Lajkovac')
INSERT [dbo].[Hala] ([halaID], [naziv], [kapacitet], [adresa]) VALUES (5, N'SKC Obrenovac', 2800, N'Kralja Aleksandra I 63, Obrenovac')
INSERT [dbo].[Kolo] ([koloID], [naziv], [datumOd], [datumDo], [ligaID], [delegatID]) VALUES (2, N'2. kolo regularnog dela Superlige Srbije za seniorke', CAST(N'2020-09-11T00:00:00.000' AS DateTime), CAST(N'2020-09-14T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Kolo] ([koloID], [naziv], [datumOd], [datumDo], [ligaID], [delegatID]) VALUES (3, N'3. kolo regularnog dela Superlige Srbije za seniorke', CAST(N'2020-09-18T00:00:00.000' AS DateTime), CAST(N'2020-09-20T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Kolo] ([koloID], [naziv], [datumOd], [datumDo], [ligaID], [delegatID]) VALUES (4, N'4. kolo regularnog dela Superlige Srbije za seniorke', CAST(N'2020-09-25T00:00:00.000' AS DateTime), CAST(N'2020-09-27T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[Liga] ([ligaID], [naziv], [sponzor]) VALUES (1, N'Superliga Srbije za seniorke', N'Banka Postanska Stedionica')
INSERT [dbo].[Liga] ([ligaID], [naziv], [sponzor]) VALUES (2, N'Superliga Srbije za seniore', N'Banka Postanska Stedionica')
INSERT [dbo].[Liga] ([ligaID], [naziv], [sponzor]) VALUES (3, N'Prva A liga Srbije za seniorke', N'Banka Postanska Stedionica')
INSERT [dbo].[Liga] ([ligaID], [naziv], [sponzor]) VALUES (4, N'Prva A liga Srbije za seniore', N'Banka Postanska Stedionica')
INSERT [dbo].[Liga] ([ligaID], [naziv], [sponzor]) VALUES (5, N'Prva B liga Srbije za seniorke', N'OSSRB')
INSERT [dbo].[Liga] ([ligaID], [naziv], [sponzor]) VALUES (6, N'Prva B liga Srbije za seniore', N'OSSRB')
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (1, 2, CAST(N'2020-09-11T18:00:00.000' AS DateTime), 1, 2, 3, 1, N'odigran', 2)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (1, 3, CAST(N'2020-09-19T19:00:00.000' AS DateTime), 10, 2, 0, 0, N'zakazan', 5)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (1, 4, CAST(N'2020-09-25T20:00:00.000' AS DateTime), 1, 3, 0, 0, N'zakazan', 2)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (2, 2, CAST(N'2020-09-12T19:00:00.000' AS DateTime), 3, 5, 0, 0, N'zakazan', 2)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (2, 3, CAST(N'2020-09-19T17:00:00.000' AS DateTime), 3, 6, 0, 0, N'zakazan', 3)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (2, 4, CAST(N'2020-09-26T20:00:00.000' AS DateTime), 10, 6, 0, 0, N'zakazan', 5)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (3, 2, CAST(N'2020-09-12T20:00:00.000' AS DateTime), 4, 6, 0, 0, N'zakazan', 4)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (3, 3, CAST(N'2020-09-18T18:00:00.000' AS DateTime), 7, 5, 0, 0, N'zakazan', 3)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (4, 2, CAST(N'2020-09-13T20:00:00.000' AS DateTime), 10, 9, 0, 0, N'zakazan', 5)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (4, 3, CAST(N'2020-09-18T19:00:00.000' AS DateTime), 4, 8, 0, 0, N'zakazan', 4)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (5, 2, CAST(N'2020-09-12T18:30:00.000' AS DateTime), 7, 8, 0, 0, N'zakazan', 1)
INSERT [dbo].[Mec] ([mecID], [koloID], [datumVreme], [domacinID], [gostID], [setovaDomacin], [setovaGost], [status], [halaID]) VALUES (5, 3, CAST(N'2020-09-20T19:00:00.000' AS DateTime), 1, 9, 0, 0, N'zakazan', 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (1, N'ZOK Crvena Zvezda', N'Beograd', 1, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (2, N'GZOK Srem', N'Sremska Mitrovica', 1, 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (3, N'ZOK Spartak', N'Subotica', 1, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (4, N'ZOK Zeleznicar', N'Lajkovac', 1, 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (5, N'ZOK Ub', N'Ub', 1, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (6, N'ZOK Partizan Soccer', N'Beograd', 1, 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (7, N'OK Beograd', N'Beograd', 1, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (8, N'ZOK Jedinstvo', N'Stara Pazova', 1, 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (9, N'ZOK Klek', N'Zrenjanin', 1, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (10, N'OK Tent', N'Obrenovac', 1, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (11, N'OK Crvena Zvezda', N'Beograd', 2, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (12, N'OK Borac Starcevo', N'Starcevo', 2, 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (13, N'OK Mladi Radnik', N'Pozarevac', 2, 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (14, N'MOK Spartak', N'Subotica', 2, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (15, N'OK Nis', N'Nis', 2, 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (16, N'OK Novi Pazar', N'Novi Pazar', 2, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (17, N'OK Partizan Beograd', N'Beograd', 2, 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (18, N'OK Ribnica', N'Kraljevo', 2, 1)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (19, N'SPD MOK Radnicki Doo', N'Kragujevac', 2, 2)
INSERT [dbo].[Tim] ([timID], [naziv], [mesto], [ligaID], [delegatID]) VALUES (20, N'OK Vojvodina NS Seme', N'Novi Sad', 2, 1)
ALTER TABLE [dbo].[Kolo]  WITH CHECK ADD  CONSTRAINT [FK_Kolo_Delegat] FOREIGN KEY([delegatID])
REFERENCES [dbo].[Delegat] ([delegatID])
GO
ALTER TABLE [dbo].[Kolo] CHECK CONSTRAINT [FK_Kolo_Delegat]
GO
ALTER TABLE [dbo].[Kolo]  WITH CHECK ADD  CONSTRAINT [FK_Kolo_Liga] FOREIGN KEY([ligaID])
REFERENCES [dbo].[Liga] ([ligaID])
GO
ALTER TABLE [dbo].[Kolo] CHECK CONSTRAINT [FK_Kolo_Liga]
GO
ALTER TABLE [dbo].[Mec]  WITH CHECK ADD  CONSTRAINT [FK_Mec_Hala] FOREIGN KEY([halaID])
REFERENCES [dbo].[Hala] ([halaID])
GO
ALTER TABLE [dbo].[Mec] CHECK CONSTRAINT [FK_Mec_Hala]
GO
ALTER TABLE [dbo].[Mec]  WITH CHECK ADD  CONSTRAINT [FK_Mec_Kolo] FOREIGN KEY([koloID])
REFERENCES [dbo].[Kolo] ([koloID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mec] CHECK CONSTRAINT [FK_Mec_Kolo]
GO
ALTER TABLE [dbo].[Mec]  WITH CHECK ADD  CONSTRAINT [FK_Mec_Tim] FOREIGN KEY([domacinID])
REFERENCES [dbo].[Tim] ([timID])
GO
ALTER TABLE [dbo].[Mec] CHECK CONSTRAINT [FK_Mec_Tim]
GO
ALTER TABLE [dbo].[Mec]  WITH CHECK ADD  CONSTRAINT [FK_Mec_Tim1] FOREIGN KEY([gostID])
REFERENCES [dbo].[Tim] ([timID])
GO
ALTER TABLE [dbo].[Mec] CHECK CONSTRAINT [FK_Mec_Tim1]
GO
ALTER TABLE [dbo].[Set]  WITH CHECK ADD  CONSTRAINT [FK_Set_Mec] FOREIGN KEY([mecID], [koloID])
REFERENCES [dbo].[Mec] ([mecID], [koloID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Set] CHECK CONSTRAINT [FK_Set_Mec]
GO
ALTER TABLE [dbo].[Tim]  WITH CHECK ADD  CONSTRAINT [FK_Tim_Delegat] FOREIGN KEY([delegatID])
REFERENCES [dbo].[Delegat] ([delegatID])
GO
ALTER TABLE [dbo].[Tim] CHECK CONSTRAINT [FK_Tim_Delegat]
GO
ALTER TABLE [dbo].[Tim]  WITH CHECK ADD  CONSTRAINT [FK_Tim_Liga] FOREIGN KEY([ligaID])
REFERENCES [dbo].[Liga] ([ligaID])
GO
ALTER TABLE [dbo].[Tim] CHECK CONSTRAINT [FK_Tim_Liga]
GO
USE [master]
GO
ALTER DATABASE [OSSRB] SET  READ_WRITE 
GO

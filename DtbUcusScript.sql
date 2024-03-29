USE [DtbUcus]
GO
/****** Object:  Trigger [YerGuncelle_Idyer2Guncelle]    Script Date: 29.12.2019 18:57:39 ******/
DROP TRIGGER [dbo].[YerGuncelle_Idyer2Guncelle]
GO
/****** Object:  Trigger [YerEkle_Idyer2Guncelle]    Script Date: 29.12.2019 18:57:39 ******/
DROP TRIGGER [dbo].[YerEkle_Idyer2Guncelle]
GO
/****** Object:  StoredProcedure [dbo].[spYolcular]    Script Date: 29.12.2019 18:57:39 ******/
DROP PROCEDURE [dbo].[spYolcular]
GO
/****** Object:  StoredProcedure [dbo].[spUcusNumarasiListesi]    Script Date: 29.12.2019 18:57:39 ******/
DROP PROCEDURE [dbo].[spUcusNumarasiListesi]
GO
/****** Object:  StoredProcedure [dbo].[spUcusBilgileri]    Script Date: 29.12.2019 18:57:39 ******/
DROP PROCEDURE [dbo].[spUcusBilgileri]
GO
/****** Object:  StoredProcedure [dbo].[spUcaklar]    Script Date: 29.12.2019 18:57:39 ******/
DROP PROCEDURE [dbo].[spUcaklar]
GO
/****** Object:  StoredProcedure [dbo].[spHavayoluSelect]    Script Date: 29.12.2019 18:57:39 ******/
DROP PROCEDURE [dbo].[spHavayoluSelect]
GO
/****** Object:  StoredProcedure [dbo].[spHavayoluEnvanterSelect]    Script Date: 29.12.2019 18:57:39 ******/
DROP PROCEDURE [dbo].[spHavayoluEnvanterSelect]
GO
/****** Object:  StoredProcedure [dbo].[spHavaalanlari]    Script Date: 29.12.2019 18:57:39 ******/
DROP PROCEDURE [dbo].[spHavaalanlari]
GO
ALTER TABLE [dbo].[tblYolcular] DROP CONSTRAINT [FK_tblYolcular_tblUcusBilgileri]
GO
ALTER TABLE [dbo].[tblUcusBilgileri] DROP CONSTRAINT [FK_tblUcusBilgileri_tblUcusBilgileri]
GO
ALTER TABLE [dbo].[tblUcusBilgileri] DROP CONSTRAINT [FK_tblUcusBilgileri_tblUcak]
GO
ALTER TABLE [dbo].[tblUcusBilgileri] DROP CONSTRAINT [FK_tblUcusBilgileri_tblHavayollari]
GO
ALTER TABLE [dbo].[tblHavayoluEnvanter] DROP CONSTRAINT [FK_tblHavayoluEnvanter_tblUcak]
GO
ALTER TABLE [dbo].[tblHavayoluEnvanter] DROP CONSTRAINT [FK_tblHavayoluEnvanter_tblHavayollari]
GO
ALTER TABLE [dbo].[tblHavayollari] DROP CONSTRAINT [FK_tblHavayollari_tblHavayollari]
GO
/****** Object:  Table [dbo].[tblYolcular]    Script Date: 29.12.2019 18:57:39 ******/
DROP TABLE [dbo].[tblYolcular]
GO
/****** Object:  Table [dbo].[tblUcusBilgileri]    Script Date: 29.12.2019 18:57:39 ******/
DROP TABLE [dbo].[tblUcusBilgileri]
GO
/****** Object:  Table [dbo].[tblUcak]    Script Date: 29.12.2019 18:57:39 ******/
DROP TABLE [dbo].[tblUcak]
GO
/****** Object:  Table [dbo].[tblKalkisVaris]    Script Date: 29.12.2019 18:57:39 ******/
DROP TABLE [dbo].[tblKalkisVaris]
GO
/****** Object:  Table [dbo].[tblHavayoluEnvanter]    Script Date: 29.12.2019 18:57:39 ******/
DROP TABLE [dbo].[tblHavayoluEnvanter]
GO
/****** Object:  Table [dbo].[tblHavayollari]    Script Date: 29.12.2019 18:57:39 ******/
DROP TABLE [dbo].[tblHavayollari]
GO
USE [master]
GO
/****** Object:  Database [DtbUcus]    Script Date: 29.12.2019 18:57:39 ******/
DROP DATABASE [DtbUcus]
GO
/****** Object:  Database [DtbUcus]    Script Date: 29.12.2019 18:57:39 ******/
CREATE DATABASE [DtbUcus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DtbUcus', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.LOCALHOST\MSSQL\DATA\DtbUcus.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DtbUcus_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.LOCALHOST\MSSQL\DATA\DtbUcus_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DtbUcus] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DtbUcus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DtbUcus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DtbUcus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DtbUcus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DtbUcus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DtbUcus] SET ARITHABORT OFF 
GO
ALTER DATABASE [DtbUcus] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DtbUcus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DtbUcus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DtbUcus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DtbUcus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DtbUcus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DtbUcus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DtbUcus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DtbUcus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DtbUcus] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DtbUcus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DtbUcus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DtbUcus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DtbUcus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DtbUcus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DtbUcus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DtbUcus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DtbUcus] SET RECOVERY FULL 
GO
ALTER DATABASE [DtbUcus] SET  MULTI_USER 
GO
ALTER DATABASE [DtbUcus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DtbUcus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DtbUcus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DtbUcus] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DtbUcus] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DtbUcus', N'ON'
GO
ALTER DATABASE [DtbUcus] SET QUERY_STORE = OFF
GO
USE [DtbUcus]
GO
/****** Object:  Table [dbo].[tblHavayollari]    Script Date: 29.12.2019 18:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHavayollari](
	[Id_Havayolu] [nvarchar](10) NOT NULL,
	[Havayolu_Adi] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_tblHavayollari] PRIMARY KEY CLUSTERED 
(
	[Id_Havayolu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHavayoluEnvanter]    Script Date: 29.12.2019 18:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHavayoluEnvanter](
	[Id_Havayolu] [nvarchar](10) NULL,
	[Id_Ucak] [nvarchar](10) NULL,
	[Adet] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKalkisVaris]    Script Date: 29.12.2019 18:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKalkisVaris](
	[Id_Yer] [nvarchar](10) NOT NULL,
	[Yer_Adi] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_tblKalkisVaris] PRIMARY KEY CLUSTERED 
(
	[Id_Yer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUcak]    Script Date: 29.12.2019 18:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUcak](
	[Id_Ucak] [nvarchar](10) NOT NULL,
	[Ucak_Adi] [nvarchar](30) NOT NULL,
	[Yolcu_Sayisi] [int] NOT NULL,
 CONSTRAINT [PK_tblUcak] PRIMARY KEY CLUSTERED 
(
	[Id_Ucak] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUcusBilgileri]    Script Date: 29.12.2019 18:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUcusBilgileri](
	[Ucus_Numarasi] [nvarchar](15) NOT NULL,
	[Id_Havayolu] [nvarchar](10) NOT NULL,
	[Kalkis_Yeri_Id] [nvarchar](10) NOT NULL,
	[Varis_Yeri_Id] [nvarchar](10) NOT NULL,
	[Kalkis_Tarih] [date] NOT NULL,
	[Kalkis_Saat] [time](0) NOT NULL,
	[Varis_Tarih] [date] NOT NULL,
	[Varis_Saat] [time](0) NOT NULL,
	[Tahmini_Sure] [time](0) NOT NULL,
	[Id_Ucak] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_tblUcusBilgileri] PRIMARY KEY CLUSTERED 
(
	[Ucus_Numarasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblYolcular]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblYolcular](
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Ucus_Numarasi] [nvarchar](15) NOT NULL,
	[Koltuk_No] [nvarchar](5) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'AA', N'American Airlines (AA)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'AC', N'Air Canada (AC)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'BA', N'British Airways (BA)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'EK', N'Emirates Airlines (EK)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'IG', N'Air Italy (IG)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'KK', N'AtlasGlobal (KK)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'LH', N'Lufthansa (LH)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'PC', N'Pegasus Airlines (PC)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'QR', N'Qatar Airways (QR)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'QX', N'Sun Express (QX)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'TK', N'Turkish Airlines (TK)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'UA', N'United Airlines (UA)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'US', N'US Airways (US)')
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'PC', N'B1', 36)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'LH', N'A1', 15)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'UA', N'A2', 38)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'AA', N'B1', 42)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'AA', N'A2', 74)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'AA', N'A1', 12)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'TK', N'A2', 48)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'BA', N'B1', 42)
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'AUS', N'AUSTIN-TX (AUS)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'BOS', N'BOSTON-MA (BOS)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'CGN', N'KOLN (CGN)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'CLT', N'CHARLOTTE-NC (CLT)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'DUS', N'DUSSELDORF (DUS)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'EDI', N'EDINBURGH (EDI)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'LAX', N'LOS ANGELES-CA (LAX)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'LCY', N'LONDON (LCY)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'SAW', N'ISTANBUL (SAW)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Yer_Adi]) VALUES (N'SFO', N'SAN FRANCISCO-CA(SFO)')
INSERT [dbo].[tblUcak] ([Id_Ucak], [Ucak_Adi], [Yolcu_Sayisi]) VALUES (N'A1', N'Airbus 320-200', 159)
INSERT [dbo].[tblUcak] ([Id_Ucak], [Ucak_Adi], [Yolcu_Sayisi]) VALUES (N'A2', N'Airbus 320-200neo

', 180)
INSERT [dbo].[tblUcak] ([Id_Ucak], [Ucak_Adi], [Yolcu_Sayisi]) VALUES (N'B1', N'Boeing 737-800', 165)
INSERT [dbo].[tblUcusBilgileri] ([Ucus_Numarasi], [Id_Havayolu], [Kalkis_Yeri_Id], [Varis_Yeri_Id], [Kalkis_Tarih], [Kalkis_Saat], [Varis_Tarih], [Varis_Saat], [Tahmini_Sure], [Id_Ucak]) VALUES (N'BA2510', N'BA', N'LCY', N'EDI', CAST(N'2019-12-28' AS Date), CAST(N'17:55:00' AS Time), CAST(N'2019-12-28' AS Date), CAST(N'19:10:00' AS Time), CAST(N'01:15:00' AS Time), N'A1')
INSERT [dbo].[tblUcusBilgileri] ([Ucus_Numarasi], [Id_Havayolu], [Kalkis_Yeri_Id], [Varis_Yeri_Id], [Kalkis_Tarih], [Kalkis_Saat], [Varis_Tarih], [Varis_Saat], [Tahmini_Sure], [Id_Ucak]) VALUES (N'LS6580', N'UA', N'SAW', N'CLT', CAST(N'2020-05-05' AS Date), CAST(N'08:00:00' AS Time), CAST(N'2020-05-05' AS Date), CAST(N'18:00:00' AS Time), CAST(N'10:00:00' AS Time), N'B1')
INSERT [dbo].[tblUcusBilgileri] ([Ucus_Numarasi], [Id_Havayolu], [Kalkis_Yeri_Id], [Varis_Yeri_Id], [Kalkis_Tarih], [Kalkis_Saat], [Varis_Tarih], [Varis_Saat], [Tahmini_Sure], [Id_Ucak]) VALUES (N'PC1012', N'LH', N'CGN', N'DUS', CAST(N'2019-10-16' AS Date), CAST(N'13:35:00' AS Time), CAST(N'2019-10-16' AS Date), CAST(N'17:55:00' AS Time), CAST(N'03:20:00' AS Time), N'A2')
INSERT [dbo].[tblUcusBilgileri] ([Ucus_Numarasi], [Id_Havayolu], [Kalkis_Yeri_Id], [Varis_Yeri_Id], [Kalkis_Tarih], [Kalkis_Saat], [Varis_Tarih], [Varis_Saat], [Tahmini_Sure], [Id_Ucak]) VALUES (N'PC1035', N'PC', N'SAW', N'LCY', CAST(N'2019-10-16' AS Date), CAST(N'13:35:00' AS Time), CAST(N'2019-10-16' AS Date), CAST(N'17:55:00' AS Time), CAST(N'03:20:00' AS Time), N'B1')
INSERT [dbo].[tblUcusBilgileri] ([Ucus_Numarasi], [Id_Havayolu], [Kalkis_Yeri_Id], [Varis_Yeri_Id], [Kalkis_Tarih], [Kalkis_Saat], [Varis_Tarih], [Varis_Saat], [Tahmini_Sure], [Id_Ucak]) VALUES (N'TR4545', N'PC', N'SAW', N'CGN', CAST(N'2019-12-28' AS Date), CAST(N'15:15:00' AS Time), CAST(N'2019-12-28' AS Date), CAST(N'17:17:00' AS Time), CAST(N'02:30:00' AS Time), N'A1')
INSERT [dbo].[tblYolcular] ([Ad], [Soyad], [Ucus_Numarasi], [Koltuk_No]) VALUES (N'Ad1', N'Soyad1', N'PC1012', N'A7')
INSERT [dbo].[tblYolcular] ([Ad], [Soyad], [Ucus_Numarasi], [Koltuk_No]) VALUES (N'Serkan', N'Gözlükaya', N'LS6580', N'F6')
INSERT [dbo].[tblYolcular] ([Ad], [Soyad], [Ucus_Numarasi], [Koltuk_No]) VALUES (N'Ad2', N'Soyad2', N'PC1035', N'D23')
ALTER TABLE [dbo].[tblHavayollari]  WITH CHECK ADD  CONSTRAINT [FK_tblHavayollari_tblHavayollari] FOREIGN KEY([Id_Havayolu])
REFERENCES [dbo].[tblHavayollari] ([Id_Havayolu])
GO
ALTER TABLE [dbo].[tblHavayollari] CHECK CONSTRAINT [FK_tblHavayollari_tblHavayollari]
GO
ALTER TABLE [dbo].[tblHavayoluEnvanter]  WITH NOCHECK ADD  CONSTRAINT [FK_tblHavayoluEnvanter_tblHavayollari] FOREIGN KEY([Id_Havayolu])
REFERENCES [dbo].[tblHavayollari] ([Id_Havayolu])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHavayoluEnvanter] CHECK CONSTRAINT [FK_tblHavayoluEnvanter_tblHavayollari]
GO
ALTER TABLE [dbo].[tblHavayoluEnvanter]  WITH NOCHECK ADD  CONSTRAINT [FK_tblHavayoluEnvanter_tblUcak] FOREIGN KEY([Id_Ucak])
REFERENCES [dbo].[tblUcak] ([Id_Ucak])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHavayoluEnvanter] CHECK CONSTRAINT [FK_tblHavayoluEnvanter_tblUcak]
GO
ALTER TABLE [dbo].[tblUcusBilgileri]  WITH NOCHECK ADD  CONSTRAINT [FK_tblUcusBilgileri_tblHavayollari] FOREIGN KEY([Id_Havayolu])
REFERENCES [dbo].[tblHavayollari] ([Id_Havayolu])
GO
ALTER TABLE [dbo].[tblUcusBilgileri] CHECK CONSTRAINT [FK_tblUcusBilgileri_tblHavayollari]
GO
ALTER TABLE [dbo].[tblUcusBilgileri]  WITH NOCHECK ADD  CONSTRAINT [FK_tblUcusBilgileri_tblUcak] FOREIGN KEY([Id_Ucak])
REFERENCES [dbo].[tblUcak] ([Id_Ucak])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[tblUcusBilgileri] NOCHECK CONSTRAINT [FK_tblUcusBilgileri_tblUcak]
GO
ALTER TABLE [dbo].[tblUcusBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_tblUcusBilgileri_tblUcusBilgileri] FOREIGN KEY([Ucus_Numarasi])
REFERENCES [dbo].[tblUcusBilgileri] ([Ucus_Numarasi])
GO
ALTER TABLE [dbo].[tblUcusBilgileri] CHECK CONSTRAINT [FK_tblUcusBilgileri_tblUcusBilgileri]
GO
ALTER TABLE [dbo].[tblYolcular]  WITH CHECK ADD  CONSTRAINT [FK_tblYolcular_tblUcusBilgileri] FOREIGN KEY([Ucus_Numarasi])
REFERENCES [dbo].[tblUcusBilgileri] ([Ucus_Numarasi])
GO
ALTER TABLE [dbo].[tblYolcular] CHECK CONSTRAINT [FK_tblYolcular_tblUcusBilgileri]
GO
/****** Object:  StoredProcedure [dbo].[spHavaalanlari]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spHavaalanlari]
as
Select h.Id_Yer,h.Yer_Adi from tblKalkisVaris h
GO
/****** Object:  StoredProcedure [dbo].[spHavayoluEnvanterSelect]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spHavayoluEnvanterSelect]
as
Select hy.Havayolu_Adi, u.Ucak_Adi, he.[Adet],u.Id_Ucak,hy.Id_Havayolu,he.Id_Havayolu,he.Id_Ucak from tblHavayoluEnvanter he,tblHavayollari hy,tblUcak u where he.Id_Havayolu=hy.Id_Havayolu and he.Id_Ucak=u.Id_Ucak
GO
/****** Object:  StoredProcedure [dbo].[spHavayoluSelect]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spHavayoluSelect]
as
Select Id_Havayolu,Havayolu_Adi from tblHavayollari
GO
/****** Object:  StoredProcedure [dbo].[spUcaklar]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spUcaklar]
as
Select * from tblUcak u
GO
/****** Object:  StoredProcedure [dbo].[spUcusBilgileri]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spUcusBilgileri]
as
Select t.[Ucus_Numarasi], h.Havayolu_Adi,h.Id_Havayolu,t.Kalkis_Yeri_Id,t.Varis_Yeri_Id,k.Yer_Adi, k.Yer_Adi, t.[Kalkis_Tarih],t.[Kalkis_Saat], t.[Varis_Tarih], t.[Varis_Saat], t.[Tahmini_Sure], uc.Ucak_Adi,uc.Id_Ucak, t.Id_Havayolu,t.Kalkis_Yeri_Id ,t.Varis_Yeri_Id,k.Yer_Adi,k.Yer_Adi,k.Id_Yer from tblUcusBilgileri t inner join tblHavayollari h on h.Id_Havayolu=t.Id_Havayolu inner join tblKalkisVaris k on k.Id_Yer=t.Kalkis_Yeri_Id inner join tblUcak uc on uc.Id_Ucak=t.Id_Ucak
GO
/****** Object:  StoredProcedure [dbo].[spUcusNumarasiListesi]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spUcusNumarasiListesi]
as
Select Ucus_Numarasi,Id_Havayolu from tblUcusBilgileri
GO
/****** Object:  StoredProcedure [dbo].[spYolcular]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spYolcular]
as
Select * from tblYolcular
GO
/****** Object:  Trigger [dbo].[YerEkle_Idyer2Guncelle]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[YerEkle_Idyer2Guncelle] on [dbo].[tblKalkisVaris]
After insert
as
begin
	declare @id1_i nvarchar(10),@id2_i nvarchar(10)
	Select @id1_i = i.Id_Yer, @id2_i = i.Id_Yer2 from inserted i
	
	update tblKalkisVaris set Id_Yer2 = Id_Yer WHERE Id_Yer = @id1_i
	print 'After Insert Trigger Çalıştı'
end
GO
ALTER TABLE [dbo].[tblKalkisVaris] DISABLE TRIGGER [YerEkle_Idyer2Guncelle]
GO
/****** Object:  Trigger [dbo].[YerGuncelle_Idyer2Guncelle]    Script Date: 29.12.2019 18:57:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[YerGuncelle_Idyer2Guncelle] on [dbo].[tblKalkisVaris]
After Update
as
begin
	declare @id1_i nvarchar(10),@id2_i nvarchar(10),@id1_d nvarchar(10),@id2_d nvarchar(10)
	Select @id1_d = d.Id_Yer, @id2_d = d.Id_Yer2 from deleted d
	Select @id1_i = i.Id_Yer, @id2_i = i.Id_Yer2 from inserted i
	
	update tblKalkisVaris set Id_Yer2 = Id_Yer WHERE Id_Yer = @id1_i
	print 'After Delete Trigger Çalıştı'
end
GO
ALTER TABLE [dbo].[tblKalkisVaris] DISABLE TRIGGER [YerGuncelle_Idyer2Guncelle]
GO
USE [master]
GO
ALTER DATABASE [DtbUcus] SET  READ_WRITE 
GO

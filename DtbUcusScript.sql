USE [DtbUcus]
GO
/****** Object:  Trigger [YerGuncelle_Idyer2Guncelle]    Script Date: 12.12.2019 03:11:21 ******/
DROP TRIGGER [dbo].[YerGuncelle_Idyer2Guncelle]
GO
/****** Object:  Trigger [YerEkle_Idyer2Guncelle]    Script Date: 12.12.2019 03:11:21 ******/
DROP TRIGGER [dbo].[YerEkle_Idyer2Guncelle]
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
/****** Object:  Table [dbo].[tblYolcular]    Script Date: 12.12.2019 03:11:21 ******/
DROP TABLE [dbo].[tblYolcular]
GO
/****** Object:  Table [dbo].[tblUcusBilgileri]    Script Date: 12.12.2019 03:11:21 ******/
DROP TABLE [dbo].[tblUcusBilgileri]
GO
/****** Object:  Table [dbo].[tblUcak]    Script Date: 12.12.2019 03:11:21 ******/
DROP TABLE [dbo].[tblUcak]
GO
/****** Object:  Table [dbo].[tblKalkisVaris]    Script Date: 12.12.2019 03:11:21 ******/
DROP TABLE [dbo].[tblKalkisVaris]
GO
/****** Object:  Table [dbo].[tblHavayoluEnvanter]    Script Date: 12.12.2019 03:11:21 ******/
DROP TABLE [dbo].[tblHavayoluEnvanter]
GO
/****** Object:  Table [dbo].[tblHavayollari]    Script Date: 12.12.2019 03:11:21 ******/
DROP TABLE [dbo].[tblHavayollari]
GO
USE [master]
GO
/****** Object:  Database [DtbUcus]    Script Date: 12.12.2019 03:11:21 ******/
DROP DATABASE [DtbUcus]
GO
/****** Object:  Database [DtbUcus]    Script Date: 12.12.2019 03:11:21 ******/
CREATE DATABASE [DtbUcus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DtbUcus', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.LOCALHOST\MSSQL\DATA\DtbUcus.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DtbUcus_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.LOCALHOST\MSSQL\DATA\DtbUcus_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 COLLATE Turkish_CI_AS
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
/****** Object:  Table [dbo].[tblHavayollari]    Script Date: 12.12.2019 03:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHavayollari](
	[Id_Havayolu] [nvarchar](10) COLLATE Turkish_CI_AS NOT NULL,
	[Havayolu_Adi] [nvarchar](30) COLLATE Turkish_CI_AS NOT NULL,
 CONSTRAINT [PK_tblHavayollari] PRIMARY KEY CLUSTERED 
(
	[Id_Havayolu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHavayoluEnvanter]    Script Date: 12.12.2019 03:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHavayoluEnvanter](
	[Id_Havayolu] [nvarchar](10) COLLATE Turkish_CI_AS NULL,
	[Id_Ucak] [nvarchar](10) COLLATE Turkish_CI_AS NULL,
	[Adet] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKalkisVaris]    Script Date: 12.12.2019 03:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKalkisVaris](
	[Id_Yer] [nvarchar](10) COLLATE Turkish_CI_AS NOT NULL,
	[Id_Yer2] [nvarchar](10) COLLATE Turkish_CI_AS NULL,
	[Yer_Adi] [nvarchar](30) COLLATE Turkish_CI_AS NOT NULL,
 CONSTRAINT [PK_tblKalkisVaris] PRIMARY KEY CLUSTERED 
(
	[Id_Yer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUcak]    Script Date: 12.12.2019 03:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUcak](
	[Id_Ucak] [nvarchar](10) COLLATE Turkish_CI_AS NOT NULL,
	[Ucak_Adi] [nvarchar](30) COLLATE Turkish_CI_AS NOT NULL,
	[Yolcu_Sayisi] [int] NOT NULL,
 CONSTRAINT [PK_tblUcak] PRIMARY KEY CLUSTERED 
(
	[Id_Ucak] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUcusBilgileri]    Script Date: 12.12.2019 03:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUcusBilgileri](
	[Ucus_Numarasi] [nvarchar](15) COLLATE Turkish_CI_AS NOT NULL,
	[Id_Havayolu] [nvarchar](10) COLLATE Turkish_CI_AS NOT NULL,
	[Kalkis_Yeri_Id] [nvarchar](10) COLLATE Turkish_CI_AS NOT NULL,
	[Varis_Yeri_Id] [nvarchar](10) COLLATE Turkish_CI_AS NOT NULL,
	[Kalkis_Tarih] [date] NOT NULL,
	[Kalkis_Saat] [time](0) NOT NULL,
	[Varis_Tarih] [date] NOT NULL,
	[Varis_Saat] [time](0) NOT NULL,
	[Tahmini_Sure] [time](0) NOT NULL,
	[Id_Ucak] [nvarchar](10) COLLATE Turkish_CI_AS NOT NULL,
 CONSTRAINT [PK_tblUcusBilgileri] PRIMARY KEY CLUSTERED 
(
	[Ucus_Numarasi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblYolcular]    Script Date: 12.12.2019 03:11:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblYolcular](
	[Ad] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Soyad] [nvarchar](50) COLLATE Turkish_CI_AS NOT NULL,
	[Ucus_Numarasi] [nvarchar](15) COLLATE Turkish_CI_AS NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'DE1', N'Lufthansa(LH)')
INSERT [dbo].[tblHavayollari] ([Id_Havayolu], [Havayolu_Adi]) VALUES (N'TR1', N'Pegasus Airlines(PC)')
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'DE1', N'B1', 36)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'TR1', N'A1', 15)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'TR1', N'A2', 38)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'DE1', N'A1', 12)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'DE1', N'A2', 48)
INSERT [dbo].[tblHavayoluEnvanter] ([Id_Havayolu], [Id_Ucak], [Adet]) VALUES (N'TR1', N'B1', 42)
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Id_Yer2], [Yer_Adi]) VALUES (N'DE1', N'DE1', N'KOLN (CGN)')
INSERT [dbo].[tblKalkisVaris] ([Id_Yer], [Id_Yer2], [Yer_Adi]) VALUES (N'TR1', N'TR1', N'ISTANBUL (SAW)')
INSERT [dbo].[tblUcak] ([Id_Ucak], [Ucak_Adi], [Yolcu_Sayisi]) VALUES (N'A1', N'Airbus 320-200', 159)
INSERT [dbo].[tblUcak] ([Id_Ucak], [Ucak_Adi], [Yolcu_Sayisi]) VALUES (N'A2', N'Airbus 320-200neo

', 180)
INSERT [dbo].[tblUcak] ([Id_Ucak], [Ucak_Adi], [Yolcu_Sayisi]) VALUES (N'B1', N'Boeing 737-800', 165)
INSERT [dbo].[tblUcusBilgileri] ([Ucus_Numarasi], [Id_Havayolu], [Kalkis_Yeri_Id], [Varis_Yeri_Id], [Kalkis_Tarih], [Kalkis_Saat], [Varis_Tarih], [Varis_Saat], [Tahmini_Sure], [Id_Ucak]) VALUES (N'PC1012', N'DE1', N'DE1', N'TR1', CAST(N'2019-10-16' AS Date), CAST(N'13:35:00' AS Time), CAST(N'2019-10-16' AS Date), CAST(N'17:55:00' AS Time), CAST(N'03:20:00' AS Time), N'A2')
INSERT [dbo].[tblUcusBilgileri] ([Ucus_Numarasi], [Id_Havayolu], [Kalkis_Yeri_Id], [Varis_Yeri_Id], [Kalkis_Tarih], [Kalkis_Saat], [Varis_Tarih], [Varis_Saat], [Tahmini_Sure], [Id_Ucak]) VALUES (N'PC1035', N'TR1', N'TR1', N'DE1', CAST(N'2019-10-16' AS Date), CAST(N'13:35:00' AS Time), CAST(N'2019-10-16' AS Date), CAST(N'17:55:00' AS Time), CAST(N'03:20:00' AS Time), N'B1')
INSERT [dbo].[tblYolcular] ([Ad], [Soyad], [Ucus_Numarasi]) VALUES (N'Ad1', N'Soyad1', N'PC1012')
INSERT [dbo].[tblYolcular] ([Ad], [Soyad], [Ucus_Numarasi]) VALUES (N'Ad2', N'Soyad2', N'PC1035')
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
ALTER TABLE [dbo].[tblUcusBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_tblUcusBilgileri_tblHavayollari] FOREIGN KEY([Id_Havayolu])
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
/****** Object:  Trigger [dbo].[YerEkle_Idyer2Guncelle]    Script Date: 12.12.2019 03:11:22 ******/
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
ALTER TABLE [dbo].[tblKalkisVaris] ENABLE TRIGGER [YerEkle_Idyer2Guncelle]
GO
/****** Object:  Trigger [dbo].[YerGuncelle_Idyer2Guncelle]    Script Date: 12.12.2019 03:11:22 ******/
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
ALTER TABLE [dbo].[tblKalkisVaris] ENABLE TRIGGER [YerGuncelle_Idyer2Guncelle]
GO
USE [master]
GO
ALTER DATABASE [DtbUcus] SET  READ_WRITE 
GO

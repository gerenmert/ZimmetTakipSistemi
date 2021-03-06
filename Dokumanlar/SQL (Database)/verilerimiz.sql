USE [master]
GO
/****** Object:  Database [StokTakipDatabase]    Script Date: 26.12.2018 01:18:38 ******/
CREATE DATABASE [StokTakipDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StokTakipDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\StokTakipDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StokTakipDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\StokTakipDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StokTakipDatabase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StokTakipDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StokTakipDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StokTakipDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StokTakipDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StokTakipDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StokTakipDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [StokTakipDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [StokTakipDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StokTakipDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StokTakipDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StokTakipDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StokTakipDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'StokTakipDatabase', N'ON'
GO
ALTER DATABASE [StokTakipDatabase] SET QUERY_STORE = OFF
GO
USE [StokTakipDatabase]
GO
/****** Object:  Table [dbo].[tblAtıkKontrol]    Script Date: 26.12.2018 01:18:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAtıkKontrol](
	[AtıkID] [int] IDENTITY(1,1) NOT NULL,
	[ZimmetID] [int] NOT NULL,
	[AtilmaTarihi] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tblAtıkKontrol] PRIMARY KEY CLUSTERED 
(
	[AtıkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBolum]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBolum](
	[BolumID] [int] IDENTITY(1,1) NOT NULL,
	[BolumAdi] [nvarchar](24) NOT NULL,
	[BolumYetkilisi] [nvarchar](24) NOT NULL,
 CONSTRAINT [PK_tblBolum] PRIMARY KEY CLUSTERED 
(
	[BolumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKullanici]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKullanici](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[BolumID] [int] NOT NULL,
	[RolID] [int] NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[KullaniciSifre] [nvarchar](16) NOT NULL,
	[AktifMi] [bit] NOT NULL,
 CONSTRAINT [PK_tblKullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPersonel]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersonel](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[BolumID] [int] NOT NULL,
	[PersonelAdi] [nvarchar](24) NOT NULL,
	[PersonelSoyadi] [nvarchar](24) NOT NULL,
	[AktifMi] [bit] NOT NULL,
 CONSTRAINT [PK_tblPersonel] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRol]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRol](
	[RolID] [int] IDENTITY(1,1) NOT NULL,
	[RolAdi] [nvarchar](24) NOT NULL,
 CONSTRAINT [PK_tblRol] PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStok]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStok](
	[StokID] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](45) NOT NULL,
	[SatinAlmaTarihi] [smalldatetime] NOT NULL,
	[BirimFiyat] [decimal](18, 2) NOT NULL,
	[ToptanFiyat] [decimal](18, 2) NOT NULL,
	[UrunTipi] [nvarchar](24) NOT NULL,
	[UrunAdeti] [int] NOT NULL,
	[SatinAlinanFirmaAdi] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_tblUrun] PRIMARY KEY CLUSTERED 
(
	[StokID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblZimmet]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblZimmet](
	[ZimmetID] [int] IDENTITY(1,1) NOT NULL,
	[StokID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
	[ZimmetTarihi] [smalldatetime] NOT NULL,
	[AktifMi] [bit] NOT NULL,
 CONSTRAINT [PK_tblZimmet] PRIMARY KEY CLUSTERED 
(
	[ZimmetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblAtıkKontrol] ON 

INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (1, 3, CAST(N'2018-12-16T20:35:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (2, 7, CAST(N'2018-12-17T16:40:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (3, 1, CAST(N'2018-12-17T16:41:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (4, 1, CAST(N'2018-12-16T20:35:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (5, 1, CAST(N'2018-12-16T20:35:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (6, 13, CAST(N'2018-12-21T23:39:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (7, 11, CAST(N'2018-12-22T03:30:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (8, 22, CAST(N'2018-12-22T03:35:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (9, 21, CAST(N'2018-12-22T03:35:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (10, 22, CAST(N'2018-12-22T03:36:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (11, 20, CAST(N'2018-12-22T03:50:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (12, 22, CAST(N'2018-12-22T03:51:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (13, 22, CAST(N'2018-12-22T03:51:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (14, 9, CAST(N'2018-12-22T04:03:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (15, 15, CAST(N'2018-12-22T04:20:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (16, 10, CAST(N'2018-12-22T04:40:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (17, 24, CAST(N'2018-12-22T12:19:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (18, 26, CAST(N'2018-12-22T13:09:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (19, 27, CAST(N'2018-12-22T16:23:00' AS SmallDateTime))
INSERT [dbo].[tblAtıkKontrol] ([AtıkID], [ZimmetID], [AtilmaTarihi]) VALUES (20, 28, CAST(N'2018-12-24T16:50:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[tblAtıkKontrol] OFF
SET IDENTITY_INSERT [dbo].[tblBolum] ON 

INSERT [dbo].[tblBolum] ([BolumID], [BolumAdi], [BolumYetkilisi]) VALUES (1, N'Satın Alma', N'Mert')
INSERT [dbo].[tblBolum] ([BolumID], [BolumAdi], [BolumYetkilisi]) VALUES (2, N'Bilgi İşlem', N'Serdar')
INSERT [dbo].[tblBolum] ([BolumID], [BolumAdi], [BolumYetkilisi]) VALUES (3, N'Muhasebe', N'Çağrı')
INSERT [dbo].[tblBolum] ([BolumID], [BolumAdi], [BolumYetkilisi]) VALUES (4, N'Hukuk', N'Yunus')
INSERT [dbo].[tblBolum] ([BolumID], [BolumAdi], [BolumYetkilisi]) VALUES (5, N'İnsan Kaynakları', N'Vehbikoç')
INSERT [dbo].[tblBolum] ([BolumID], [BolumAdi], [BolumYetkilisi]) VALUES (6, N'Pazarlama', N'Nurşen')
INSERT [dbo].[tblBolum] ([BolumID], [BolumAdi], [BolumYetkilisi]) VALUES (7, N'Üretim', N'Aslı')
INSERT [dbo].[tblBolum] ([BolumID], [BolumAdi], [BolumYetkilisi]) VALUES (8, N'Operasyon', N'Çağdaş')
SET IDENTITY_INSERT [dbo].[tblBolum] OFF
SET IDENTITY_INSERT [dbo].[tblKullanici] ON 

INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (1, 1, 1, N'mert09', N'12345', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (2, 2, 2, N'serdar10', N'54321', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (3, 3, 3, N'cagri10', N'1997', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (4, 1, 3, N'yunus', N'16', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (5, 2, 3, N'vehbikoc', N'59', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (7, 2, 2, N'yunus10', N'12345', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (8, 2, 2, N'leyla', N'23456', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (9, 5, 2, N'ferit', N'34567', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (10, 2, 2, N'selman', N'654321', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (11, 2, 2, N'ahmet', N'23345', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (12, 3, 3, N'derya', N'12345', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (13, 2, 2, N'haydar', N'45678', 1)
INSERT [dbo].[tblKullanici] ([KullaniciID], [BolumID], [RolID], [KullaniciAdi], [KullaniciSifre], [AktifMi]) VALUES (14, 2, 2, N'cansel', N'12345', 1)
SET IDENTITY_INSERT [dbo].[tblKullanici] OFF
SET IDENTITY_INSERT [dbo].[tblPersonel] ON 

INSERT [dbo].[tblPersonel] ([PersonelID], [BolumID], [PersonelAdi], [PersonelSoyadi], [AktifMi]) VALUES (8, 1, N'Mert', N'Geren', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [BolumID], [PersonelAdi], [PersonelSoyadi], [AktifMi]) VALUES (9, 2, N'Serdar', N'Yorulmaz', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [BolumID], [PersonelAdi], [PersonelSoyadi], [AktifMi]) VALUES (10, 3, N'cagri', N'tas', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [BolumID], [PersonelAdi], [PersonelSoyadi], [AktifMi]) VALUES (11, 3, N'mert', N'baykır', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [BolumID], [PersonelAdi], [PersonelSoyadi], [AktifMi]) VALUES (12, 2, N'leyla', N'uslu', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [BolumID], [PersonelAdi], [PersonelSoyadi], [AktifMi]) VALUES (13, 1, N'selin', N'korkmaz', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [BolumID], [PersonelAdi], [PersonelSoyadi], [AktifMi]) VALUES (14, 5, N'Vehbikoc', N'geren', 1)
INSERT [dbo].[tblPersonel] ([PersonelID], [BolumID], [PersonelAdi], [PersonelSoyadi], [AktifMi]) VALUES (15, 6, N'Nursen', N'geren', 1)
SET IDENTITY_INSERT [dbo].[tblPersonel] OFF
SET IDENTITY_INSERT [dbo].[tblRol] ON 

INSERT [dbo].[tblRol] ([RolID], [RolAdi]) VALUES (1, N'Admin')
INSERT [dbo].[tblRol] ([RolID], [RolAdi]) VALUES (2, N'SatinAlmaPersoneli')
INSERT [dbo].[tblRol] ([RolID], [RolAdi]) VALUES (3, N'BolumYoneticisi')
SET IDENTITY_INSERT [dbo].[tblRol] OFF
SET IDENTITY_INSERT [dbo].[tblStok] ON 

INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (1, N'Asus Laptop', CAST(N'2018-12-16T04:18:00' AS SmallDateTime), CAST(4500.00 AS Decimal(18, 2)), CAST(9000.00 AS Decimal(18, 2)), N'Laptop', 0, N'Teknosa')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (2, N'lenovo laptop', CAST(N'2018-12-15T18:31:00' AS SmallDateTime), CAST(1700.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), N'laptop', 0, N'media mark')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (3, N'HP Fare', CAST(N'2018-12-16T19:57:00' AS SmallDateTime), CAST(10.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), N'Fare', 0, N'Hepsi Burada')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (4, N'HP Klavye', CAST(N'2018-12-16T20:53:00' AS SmallDateTime), CAST(50.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), N'Klavye', 6, N'N11')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (5, N'Lenova Ekran', CAST(N'2018-12-16T20:55:00' AS SmallDateTime), CAST(400.00 AS Decimal(18, 2)), CAST(4000.00 AS Decimal(18, 2)), N'Ekran', 10, N'Akçe')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (6, N'DEL PC', CAST(N'2018-12-16T21:05:00' AS SmallDateTime), CAST(5000.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), N'PC', 0, N'Vatan')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (7, N'GXT Klavye', CAST(N'2018-12-21T18:07:00' AS SmallDateTime), CAST(45.00 AS Decimal(18, 2)), CAST(180.00 AS Decimal(18, 2)), N'Klavye', 0, N'Hepsiburada')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (8, N'GXT Fare', CAST(N'2018-12-21T18:11:00' AS SmallDateTime), CAST(32.00 AS Decimal(18, 2)), CAST(160.00 AS Decimal(18, 2)), N'Fare', 5, N'Vatan Bailgisayar')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (9, N'lenova laptop', CAST(N'2018-12-21T23:37:00' AS SmallDateTime), CAST(400.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)), N'laptop', 42, N'samsung')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (10, N'geforce 920m ekran kartı', CAST(N'2018-12-22T12:37:00' AS SmallDateTime), CAST(600.78 AS Decimal(18, 2)), CAST(3604.68 AS Decimal(18, 2)), N'ekran kartı', 5, N'arçelik')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (12, N'toshiba fare', CAST(N'2018-12-22T13:06:00' AS SmallDateTime), CAST(77.89 AS Decimal(18, 2)), CAST(233.67 AS Decimal(18, 2)), N'fare', 2, N'teknosa')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (13, N'lenova adaptör', CAST(N'2018-12-22T16:22:00' AS SmallDateTime), CAST(300.56 AS Decimal(18, 2)), CAST(300.56 AS Decimal(18, 2)), N'adaptör', 0, N'letgo')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (14, N'lenova touchpad', CAST(N'2018-12-22T16:53:00' AS SmallDateTime), CAST(30.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), N'touchpad', 3, N'lenova')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (15, N'asus touchpad', CAST(N'2018-12-24T16:48:00' AS SmallDateTime), CAST(22.45 AS Decimal(18, 2)), CAST(44.90 AS Decimal(18, 2)), N'touchpad', 1, N'asus')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (17, N'lenova  oyuncu mause                         ', CAST(N'2018-12-25T15:43:00' AS SmallDateTime), CAST(23.44 AS Decimal(18, 2)), CAST(46.89 AS Decimal(18, 2)), N'mouse', 2, N'simens')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (22, N'laptop hoparlör', CAST(N'2018-12-25T23:16:00' AS SmallDateTime), CAST(12.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)), N'hoparlör', 2, N'vestel')
INSERT [dbo].[tblStok] ([StokID], [UrunAdi], [SatinAlmaTarihi], [BirimFiyat], [ToptanFiyat], [UrunTipi], [UrunAdeti], [SatinAlinanFirmaAdi]) VALUES (23, N'laptop hoparlör', CAST(N'2018-12-25T23:16:00' AS SmallDateTime), CAST(12.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)), N'hoparlör', 2, N'vestel7777777777')
SET IDENTITY_INSERT [dbo].[tblStok] OFF
SET IDENTITY_INSERT [dbo].[tblZimmet] ON 

INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (1, 1, 8, CAST(N'2018-12-16T19:35:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (2, 3, 9, CAST(N'2018-12-16T19:57:00' AS SmallDateTime), 1)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (3, 3, 8, CAST(N'2018-12-16T20:00:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (4, 6, 8, CAST(N'1989-01-18T21:11:00' AS SmallDateTime), 1)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (5, 2, 8, CAST(N'2018-12-16T22:25:00' AS SmallDateTime), 1)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (6, 1, 9, CAST(N'2018-12-16T22:26:00' AS SmallDateTime), 1)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (7, 1, 9, CAST(N'2018-12-16T22:26:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (9, 3, 10, CAST(N'2018-12-21T18:13:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (10, 4, 10, CAST(N'2018-12-21T18:14:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (11, 7, 10, CAST(N'2018-12-21T18:15:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (12, 7, 10, CAST(N'2018-12-21T18:15:00' AS SmallDateTime), 1)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (13, 7, 10, CAST(N'2018-12-21T18:17:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (15, 9, 10, CAST(N'2018-12-21T23:40:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (19, 9, 10, CAST(N'2018-12-22T00:25:00' AS SmallDateTime), 1)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (20, 9, 10, CAST(N'2018-12-22T00:29:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (21, 9, 10, CAST(N'2018-12-22T00:31:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (22, 9, 10, CAST(N'2018-12-22T00:33:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (23, 9, 10, CAST(N'2018-12-22T12:17:00' AS SmallDateTime), 1)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (24, 9, 10, CAST(N'2018-12-22T12:18:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (25, 10, 11, CAST(N'2018-12-22T13:04:00' AS SmallDateTime), 1)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (26, 12, 11, CAST(N'2018-12-22T13:07:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (27, 13, 11, CAST(N'2018-12-22T16:22:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (28, 15, 11, CAST(N'2018-12-24T16:50:00' AS SmallDateTime), 0)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (29, 7, 14, CAST(N'2018-12-25T01:48:00' AS SmallDateTime), 1)
INSERT [dbo].[tblZimmet] ([ZimmetID], [StokID], [PersonelID], [ZimmetTarihi], [AktifMi]) VALUES (30, 3, 8, CAST(N'2018-08-22T01:51:00' AS SmallDateTime), 1)
SET IDENTITY_INSERT [dbo].[tblZimmet] OFF
ALTER TABLE [dbo].[tblKullanici] ADD  CONSTRAINT [DF_tblKullanici_AktifMi]  DEFAULT ((1)) FOR [AktifMi]
GO
ALTER TABLE [dbo].[tblPersonel] ADD  CONSTRAINT [DF_tblPersonel_AktifMi]  DEFAULT ((1)) FOR [AktifMi]
GO
ALTER TABLE [dbo].[tblZimmet] ADD  CONSTRAINT [DF_tblZimmet_AktifMi]  DEFAULT ((1)) FOR [AktifMi]
GO
ALTER TABLE [dbo].[tblAtıkKontrol]  WITH CHECK ADD  CONSTRAINT [FK_tblAtıkKontrol_tblZimmet] FOREIGN KEY([ZimmetID])
REFERENCES [dbo].[tblZimmet] ([ZimmetID])
GO
ALTER TABLE [dbo].[tblAtıkKontrol] CHECK CONSTRAINT [FK_tblAtıkKontrol_tblZimmet]
GO
ALTER TABLE [dbo].[tblKullanici]  WITH CHECK ADD  CONSTRAINT [FK_tblKullanici_tblBolum] FOREIGN KEY([BolumID])
REFERENCES [dbo].[tblBolum] ([BolumID])
GO
ALTER TABLE [dbo].[tblKullanici] CHECK CONSTRAINT [FK_tblKullanici_tblBolum]
GO
ALTER TABLE [dbo].[tblKullanici]  WITH CHECK ADD  CONSTRAINT [FK_tblKullanici_tblRol] FOREIGN KEY([RolID])
REFERENCES [dbo].[tblRol] ([RolID])
GO
ALTER TABLE [dbo].[tblKullanici] CHECK CONSTRAINT [FK_tblKullanici_tblRol]
GO
ALTER TABLE [dbo].[tblPersonel]  WITH CHECK ADD  CONSTRAINT [FK_tblPersonel_tblBolum] FOREIGN KEY([BolumID])
REFERENCES [dbo].[tblBolum] ([BolumID])
GO
ALTER TABLE [dbo].[tblPersonel] CHECK CONSTRAINT [FK_tblPersonel_tblBolum]
GO
ALTER TABLE [dbo].[tblZimmet]  WITH CHECK ADD  CONSTRAINT [FK_tblZimmet_tblPersonel] FOREIGN KEY([PersonelID])
REFERENCES [dbo].[tblPersonel] ([PersonelID])
GO
ALTER TABLE [dbo].[tblZimmet] CHECK CONSTRAINT [FK_tblZimmet_tblPersonel]
GO
ALTER TABLE [dbo].[tblZimmet]  WITH CHECK ADD  CONSTRAINT [FK_tblZimmet_tblStok] FOREIGN KEY([StokID])
REFERENCES [dbo].[tblStok] ([StokID])
GO
ALTER TABLE [dbo].[tblZimmet] CHECK CONSTRAINT [FK_tblZimmet_tblStok]
GO
/****** Object:  StoredProcedure [dbo].[AtikEkle]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AtikEkle](@ZimmetID int, @AtilmaTarihi smalldatetime)
AS



DECLARE @sayi INT;
DECLARE @aktifmi BIT;
SELECT @sayi =  ZimmetID FROM tblZimmet WHERE @ZimmetID=ZimmetID;
SELECT @aktifmi=  AktifMi from tblZimmet WHERE @ZimmetID=ZimmetID;


IF @sayi > 0 BEGIN
IF @aktifmi = 1 begin 
INSERT  INTO tblAtıkKontrol(ZimmetID, AtilmaTarihi)
VALUES (@ZimmetID, @AtilmaTarihi)

UPDATE tblZimmet
SET AktifMi=0
WHERE tblZimmet.ZimmetID=@ZimmetID
END
END
GO
/****** Object:  StoredProcedure [dbo].[AtikGetir]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AtikGetir]
AS
SELECT *
FROM tblAtıkKontrol
GO
/****** Object:  StoredProcedure [dbo].[GIRIS]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GIRIS](@kullanici nvarchar(50),@sifre nvarchar(16) )
AS
SELECT  k.KullaniciAdi,k.KullaniciSifre,k.RolID
FROM tblKullanici k
WHERE k.KullaniciAdi=@kullanici and k.KullaniciSifre=@sifre
GO
/****** Object:  StoredProcedure [dbo].[KullaniciEkle]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KullaniciEkle](@BolumID int, @RolID int, @KullaniciAdi nvarchar(50), @KullaniciSifre nvarchar(16))
AS
INSERT  INTO tblKullanici(BolumID, RolID, KullaniciAdi, KullaniciSifre)
VALUES (@BolumID, @RolID, @KullaniciAdi, @KullaniciSifre)
GO
/****** Object:  StoredProcedure [dbo].[KullaniciGetir]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KullaniciGetir]
AS
SELECT *
FROM tblKullanici
GO
/****** Object:  StoredProcedure [dbo].[PersonelGetir]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PersonelGetir]
AS
SELECT *
FROM tblPersonel
GO
/****** Object:  StoredProcedure [dbo].[StokEkle]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StokEkle](@UrunAdi nvarchar(45), @SatinAlmaTarihi smalldatetime, @BirimFiyati decimal(18,2), @ToptanFiyati decimal(18,2), @UrunTipi nvarchar(24), @UrunAdeti int, @FirmaAdi nvarchar(45))
AS
INSERT  INTO tblStok(UrunAdi, UrunAdeti, SatinAlmaTarihi, BirimFiyat, ToptanFiyat, UrunTipi, SatinAlinanFirmaAdi)
VALUES (@UrunAdi, @UrunAdeti, @SatinAlmaTarihi, @BirimFiyati, @ToptanFiyati, @UrunTipi, @FirmaAdi)
GO
/****** Object:  StoredProcedure [dbo].[StokGetir]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StokGetir]
AS
SELECT *
FROM tblStok
GO
/****** Object:  StoredProcedure [dbo].[UrunGetir]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UrunGetir]
AS
SELECT *
FROM tblStok
GO
/****** Object:  StoredProcedure [dbo].[zimmetBolumListele]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[zimmetBolumListele] @BolumAdi nvarchar(24)
as
SELECT z.ZimmetID,b.BolumID,b.BolumAdi,p.PersonelID, p.PersonelAdi, p.PersonelSoyadi, s.StokID, s.UrunAdi, z.ZimmetTarihi, z.AktifMi from  tblZimmet z INNER JOIN tblPersonel p ON z.PersonelID = p.PersonelID INNER JOIN tblStok s ON z.StokID = s.StokID INNER JOIN tblBolum b ON b.BolumID = p.BolumID where b.BolumAdi LIKE '%'+ @BolumAdi + '%'
GO
/****** Object:  StoredProcedure [dbo].[ZimmetEkle]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ZimmetEkle](@PersonelID int,@StokID int, @ZimmetTarihi smalldatetime)
AS

DECLARE @adet INT;
SELECT @adet =  UrunAdeti FROM tblStok WHERE @StokID = StokID ;
DECLARE @kisi INT;
SELECT @kisi = PersonelID FROM tblPersonel WHERE @PersonelID = PersonelID;


IF @adet > 0 BEGIN
IF @kisi > 0 BEGIN
INSERT  INTO tblZimmet(PersonelID, StokID, ZimmetTarihi)
VALUES (@PersonelID, @StokID, @ZimmetTarihi)

UPDATE tblStok
SET UrunAdeti=UrunAdeti-1
WHERE tblStok.StokID=@StokID
END
END
GO
/****** Object:  StoredProcedure [dbo].[ZimmetGetir]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ZimmetGetir]
AS
SELECT z.ZimmetID, p.PersonelID, p.PersonelAdi, p.PersonelSoyadi, s.StokID, s.UrunAdi, z.ZimmetTarihi, z.AktifMi 
FROM tblZimmet z INNER JOIN tblStok s ON z.StokID = s.StokID
				 INNER JOIN tblPersonel p ON z.PersonelID = p.PersonelID
GO
/****** Object:  StoredProcedure [dbo].[zimmetKisiListele]    Script Date: 26.12.2018 01:18:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[zimmetKisiListele] @KullaniciAdi nvarchar(24)
as
SELECT z.ZimmetID, p.PersonelID, p.PersonelAdi, p.PersonelSoyadi, b.BolumAdi, s.StokID, s.UrunAdi, z.ZimmetTarihi, z.AktifMi from  tblZimmet z INNER JOIN tblPersonel p ON z.PersonelID = p.PersonelID INNER JOIN tblStok s ON z.StokID = s.StokID INNER JOIN tblBolum b ON b.BolumID = p.BolumID where (p.PersonelAdi +' '+ p.PersonelSoyadi) LIKE '%'+ @KullaniciAdi + '%'
GO
USE [master]
GO
ALTER DATABASE [StokTakipDatabase] SET  READ_WRITE 
GO

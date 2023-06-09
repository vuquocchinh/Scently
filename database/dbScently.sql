USE [master]
GO
/****** Object:  Database [Scently]    Script Date: Wed, 22-Mar-23 7:46:34 PM ******/
CREATE DATABASE [Scently]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Scently', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Scently.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Scently_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Scently_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Scently] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Scently].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Scently] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Scently] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Scently] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Scently] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Scently] SET ARITHABORT OFF 
GO
ALTER DATABASE [Scently] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Scently] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Scently] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Scently] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Scently] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Scently] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Scently] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Scently] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Scently] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Scently] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Scently] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Scently] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Scently] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Scently] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Scently] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Scently] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Scently] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Scently] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Scently] SET  MULTI_USER 
GO
ALTER DATABASE [Scently] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Scently] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Scently] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Scently] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Scently] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Scently] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Scently] SET QUERY_STORE = OFF
GO
USE [Scently]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: Wed, 22-Mar-23 7:46:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[maDon] [int] NOT NULL,
	[idSP] [int] NOT NULL,
	[soLuongSP] [int] NOT NULL,
	[giaSP] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maDon] ASC,
	[idSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: Wed, 22-Mar-23 7:46:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[idDM] [int] NOT NULL,
	[tenDM] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: Wed, 22-Mar-23 7:46:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[maDon] [int] NOT NULL,
	[thanhToan] [bit] NOT NULL,
	[giaoHang] [bit] NOT NULL,
	[ngayDat] [datetime] NOT NULL,
	[ngayGiao] [datetime] NULL,
	[taiKhoan] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: Wed, 22-Mar-23 7:46:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[idSP] [int] NOT NULL,
	[tenSP] [nvarchar](50) NOT NULL,
	[giaSP] [money] NOT NULL,
	[soLuongSP] [int] NOT NULL,
	[hinhAnhSP] [nvarchar](100) NULL,
	[thongTinSP] [nvarchar](max) NULL,
	[ngayCapNhat] [datetime] NULL,
	[idDM] [int] NOT NULL,
	[sale] [float] NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: Wed, 22-Mar-23 7:46:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[taiKhoan] [nvarchar](50) NOT NULL,
	[matKhau] [nvarchar](50) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[gioiTinh] [bit] NULL,
	[ngaySinh] [date] NULL,
	[sdt] [nvarchar](20) NULL,
	[email] [nvarchar](50) NULL,
	[diaChi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[taiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([taiKhoan], [matKhau], [ten], [gioiTinh], [ngaySinh], [sdt], [email], [diaChi]) VALUES (N'chinh123', N'Chinhvu@123', N'Vũ', NULL, NULL, NULL, N'chinhvu', NULL)
INSERT [dbo].[TaiKhoan] ([taiKhoan], [matKhau], [ten], [gioiTinh], [ngaySinh], [sdt], [email], [diaChi]) VALUES (N'chinhvu', N'Chinhvu@123', N'Chinh', NULL, NULL, NULL, N'chinhvu2002@gmail.com', NULL)
INSERT [dbo].[TaiKhoan] ([taiKhoan], [matKhau], [ten], [gioiTinh], [ngaySinh], [sdt], [email], [diaChi]) VALUES (N'hahaha123', N'Chinhvu@123', N'Vũ Quốc Chinh', NULL, NULL, NULL, N'chinhvu@gmail.com', NULL)
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [sale]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([maDon])
REFERENCES [dbo].[DonHang] ([maDon])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([idSP])
REFERENCES [dbo].[SanPham] ([idSP])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([taiKhoan])
REFERENCES [dbo].[TaiKhoan] ([taiKhoan])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([idDM])
REFERENCES [dbo].[DanhMuc] ([idDM])
GO
USE [master]
GO
ALTER DATABASE [Scently] SET  READ_WRITE 
GO

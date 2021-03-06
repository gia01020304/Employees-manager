USE [master]
GO
/****** Object:  Database [Final]    Script Date: 17/12/2017 12:13:56 CH ******/
CREATE DATABASE [Final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Final.mdf' , SIZE = 401408KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\Final_log.ldf' , SIZE = 3416064KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Final] SET ARITHABORT OFF 
GO
ALTER DATABASE [Final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Final] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Final] SET RECOVERY FULL 
GO
ALTER DATABASE [Final] SET  MULTI_USER 
GO
ALTER DATABASE [Final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Final', N'ON'
GO
USE [Final]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Final]
GO
/****** Object:  UserDefinedFunction [dbo].[Dem]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Dem]()
RETURNS INT
AS	
BEGIN
DECLARE @dem INT
SET @dem= IDENT_CURRENT('NhanVien')
	RETURN @dem
END



GO
/****** Object:  UserDefinedFunction [dbo].[DemRecord]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[DemRecord](@TenBang NVARCHAR(100))
RETURNS NVARCHAR(100)
AS	BEGIN
	DECLARE @temp NVARCHAR(100)=''
	SET @temp=@temp+' SELECT COUNT(*) FROM '+ @TenBang
	RETURN @temp

END


GO
/****** Object:  UserDefinedFunction [dbo].[GetID]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetID]()
RETURNS INT
AS	
BEGIN
DECLARE @dem INT
SET @dem= IDENT_CURRENT('NhanVien')
	RETURN @dem
END


GO
/****** Object:  UserDefinedFunction [dbo].[KiemTra]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[KiemTra](@US NVARCHAR(20))
RETURNS INT
AS	
BEGIN
	DECLARE @dem INT
	SELECT @dem=COUNT(dbo.Admin.UserName)
	FROM dbo.Admin
	WHERE dbo.Admin.UserName=@US
	IF	@dem>0
	RETURN 1
	ELSE 
	RETURN 0
	RETURN 0	
END


GO
/****** Object:  UserDefinedFunction [dbo].[test]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[test](@maPB INT)
RETURNS INT
AS	 BEGIN
DECLARE @dem INT=-1
SELECT @dem=dbo.NhanVien.Id FROM dbo.NhanVien
WHERE (dbo.NhanVien.Id_CV=1 OR dbo.NhanVien.Id_CV=4 )AND dbo.NhanVien.Id_PB=@maPB
IF @dem>-1
RETURN @dem
ELSE	
RETURN 0
RETURN 0
END


GO
/****** Object:  UserDefinedFunction [dbo].[TongLuong]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TongLuong](@MaPb INT)
RETURNS  DECIMAL
BEGIN
DECLARE @tt DECIMAL=0
SELECT @tt=SUM(dbo.MucLuong.Money)
FROM dbo.NhanVien,dbo.MucLuong,dbo.ChucVu
WHERE dbo.NhanVien.Id_CV=dbo.ChucVu.Id AND	 dbo.ChucVu.Id_ML=dbo.MucLuong.Id AND Id_PB=@MaPb
RETURN @tt
END	


GO
/****** Object:  Table [dbo].[Admin]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[UserName] [nvarchar](50) NULL,
	[PassWord] [nvarchar](6) NULL,
	[FullName] [nvarchar](200) NULL,
	[DOB] [date] NULL,
	[PhoneNumber] [int] NULL,
	[Sex] [nvarchar](10) NULL,
	[Rate] [decimal](18, 0) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Id_ML] [int] NULL,
 CONSTRAINT [PK_CV] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KTKL]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KTKL](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameKTKL] [nvarchar](100) NULL,
	[HinhThuc] [nvarchar](50) NULL,
	[Money] [int] NOT NULL,
 CONSTRAINT [PK__KTKL__3214EC070D15E899] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MucLuong]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MucLuong](
	[Id] [int] NOT NULL,
	[Money] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kh] [nvarchar](3) NOT NULL,
	[FName] [nvarchar](50) NULL,
	[LName] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DOB] [date] NULL,
	[HireDay] [date] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[Id_PB] [int] NULL,
	[Id_NQL] [int] NULL,
	[Kh_NQL] [nvarchar](3) NULL,
	[Id_CV] [int] NULL,
 CONSTRAINT [PK_NV] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Kh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NV_KTKL]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NV_KTKL](
	[Id_NV] [int] NOT NULL,
	[Kh_NV] [nvarchar](3) NOT NULL,
	[Id_KTKL] [int] NOT NULL,
 CONSTRAINT [PF_NV_KTKL] PRIMARY KEY CLUSTERED 
(
	[Id_NV] ASC,
	[Kh_NV] ASC,
	[Id_KTKL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuLuong]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuLuong](
	[Id] [int] NOT NULL,
	[TongSoTien] [int] NULL,
	[Id_NV] [int] NULL,
	[Kh_NV] [nvarchar](3) NULL,
 CONSTRAINT [PK_PL] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[Id] [int] NOT NULL,
	[NamePB] [nvarchar](50) NULL,
	[KyHieu] [nvarchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongBan_ChucVu]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan_ChucVu](
	[Id_PB] [int] NOT NULL,
	[Id_CV] [int] NOT NULL,
 CONSTRAINT [PK_PBCV] PRIMARY KEY CLUSTERED 
(
	[Id_PB] ASC,
	[Id_CV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TempNhanVien]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempNhanVien](
	[Id] [int] NOT NULL,
	[Kh] [nvarchar](3) NOT NULL,
	[FName] [nvarchar](50) NULL,
	[LName] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DOB] [date] NULL,
	[HireDay] [date] NULL,
	[QueQuan] [nvarchar](10) NULL,
	[Id_PB] [int] NULL,
	[Id_NQL] [int] NULL,
	[Kh_NQL] [nvarchar](3) NULL,
	[Id_CV] [int] NULL,
	[DayDelete] [date] NULL,
 CONSTRAINT [PK_TNV] PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[Kh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanNhan]    Script Date: 17/12/2017 12:13:56 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanNhan](
	[IdNV] [int] NOT NULL,
	[KhNV] [nvarchar](3) NOT NULL,
	[QuanHe] [nvarchar](50) NOT NULL,
	[NameTN] [nvarchar](50) NULL,
	[DOB] [date] NOT NULL,
 CONSTRAINT [PK_TN] PRIMARY KEY CLUSTERED 
(
	[IdNV] ASC,
	[KhNV] ASC,
	[QuanHe] ASC,
	[DOB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Admin] ([UserName], [PassWord], [FullName], [DOB], [PhoneNumber], [Sex], [Rate]) VALUES (N'Admin', N'1', N'Admin', CAST(N'1987-10-20' AS Date), 123456789, N'Male', CAST(23000 AS Decimal(18, 0)))
INSERT [dbo].[ChucVu] ([Id], [Name], [Id_ML]) VALUES (1, N'Trưởng Phòng Quản Lý', 1)
INSERT [dbo].[ChucVu] ([Id], [Name], [Id_ML]) VALUES (2, N'Phó Phòng Quản Lý', 2)
INSERT [dbo].[ChucVu] ([Id], [Name], [Id_ML]) VALUES (3, N'Nhân Viên Quản Lý', 3)
INSERT [dbo].[ChucVu] ([Id], [Name], [Id_ML]) VALUES (4, N'Trưởng Phòng Kế Toán', 1)
INSERT [dbo].[ChucVu] ([Id], [Name], [Id_ML]) VALUES (5, N'Phó Phòng Kế Toán', 2)
INSERT [dbo].[ChucVu] ([Id], [Name], [Id_ML]) VALUES (6, N'Nhân Viên Kế Toán', 3)
SET IDENTITY_INSERT [dbo].[KTKL] ON 

INSERT [dbo].[KTKL] ([Id], [NameKTKL], [HinhThuc], [Money]) VALUES (1, N'Hoàn thành công việc tốt', N'Thưởng', 1000000)
INSERT [dbo].[KTKL] ([Id], [NameKTKL], [HinhThuc], [Money]) VALUES (2, N'Đi làm muộn', N'Phạt', 200000)
INSERT [dbo].[KTKL] ([Id], [NameKTKL], [HinhThuc], [Money]) VALUES (3, N'Có sáng tạo công việc', N'Thưởng', 500000)
INSERT [dbo].[KTKL] ([Id], [NameKTKL], [HinhThuc], [Money]) VALUES (4, N'Không hoàn thành nhiệm vụ', N'Phạt', 500000)
INSERT [dbo].[KTKL] ([Id], [NameKTKL], [HinhThuc], [Money]) VALUES (5, N'Mất khách hàng', N'Phạt', 500000)
SET IDENTITY_INSERT [dbo].[KTKL] OFF
INSERT [dbo].[MucLuong] ([Id], [Money]) VALUES (1, CAST(20000000 AS Decimal(18, 0)))
INSERT [dbo].[MucLuong] ([Id], [Money]) VALUES (2, CAST(10000000 AS Decimal(18, 0)))
INSERT [dbo].[MucLuong] ([Id], [Money]) VALUES (3, CAST(5000000 AS Decimal(18, 0)))
INSERT [dbo].[MucLuong] ([Id], [Money]) VALUES (4, CAST(10000000 AS Decimal(18, 0)))
INSERT [dbo].[MucLuong] ([Id], [Money]) VALUES (5, CAST(8000000 AS Decimal(18, 0)))
INSERT [dbo].[MucLuong] ([Id], [Money]) VALUES (6, CAST(5000000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (1, N'PQL', N'Adam', N'Walker', N'Male', CAST(N'1987-11-20' AS Date), CAST(N'2017-12-16' AS Date), N'Bắc Giang', 123, NULL, NULL, 1)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (4, N'PKT', N'Kiều', N'Thúy', N'Female', CAST(N'1991-11-21' AS Date), CAST(N'2017-12-16' AS Date), N'TP HCM', 456, NULL, NULL, 4)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (5, N'PQL', N'Trung Nga', N'Đổ', N'Male', CAST(N'1992-11-28' AS Date), CAST(N'2015-04-21' AS Date), N'Gia Lai', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (6, N'PQL', N'Trâm Anh', N'Lê', N'Female', CAST(N'1977-09-22' AS Date), CAST(N'2010-12-19' AS Date), N'Bình Định', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (7, N'PQL', N'Huyền An', N'Phạm', N'Male', CAST(N'1979-08-30' AS Date), CAST(N'2008-08-28' AS Date), N'Thái Nguyên', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (8, N'PQL', N'Huyền Phi', N'Lê', N'Female', CAST(N'1993-04-14' AS Date), CAST(N'2010-12-04' AS Date), N'Điện Biên', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (9, N'PQL', N'Trúc Cúc', N'Đặng', N'Female', CAST(N'1988-10-02' AS Date), CAST(N'1998-05-18' AS Date), N'Đắk Lắk', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (10, N'PKT', N'DiệuXuân', N'Ngô', N'Unknown', CAST(N'1997-02-26' AS Date), CAST(N'2013-03-17' AS Date), N'Quảng Ngãi', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (11, N'PQL', N'Cát Trang', N'Lê', N'Female', CAST(N'1978-11-14' AS Date), CAST(N'2003-06-17' AS Date), N'Đắk Nông', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (12, N'PKT', N'Quế Thảo', N'Kim', N'Unknown', CAST(N'1987-06-29' AS Date), CAST(N'2007-09-13' AS Date), N'Đà Nẵng', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (13, N'PKT', N'Cát Chi', N'Vũ', N'Female', CAST(N'1977-08-22' AS Date), CAST(N'2000-04-28' AS Date), N'Bình Phước', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (14, N'PKT', N'Quế Diệu', N'Hồ', N'Female', CAST(N'1985-04-02' AS Date), CAST(N'2002-11-12' AS Date), N'Bạc Liêu', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (15, N'PKT', N'Tú Thảo', N'Hoàng', N'Unknown', CAST(N'1978-06-09' AS Date), CAST(N'1999-03-19' AS Date), N'Hà Nội', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (16, N'PKT', N'Trung Trang', N'Bùi', N'Female', CAST(N'1984-07-29' AS Date), CAST(N'2012-10-14' AS Date), N'Phú Yên', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (17, N'PKT', N'Huyền Lam', N'Hồ', N'Male', CAST(N'1981-03-02' AS Date), CAST(N'2015-09-26' AS Date), N'Đắk Nông', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (18, N'PKT', N'Trung Ca', N'Phạm', N'Female', CAST(N'1975-01-26' AS Date), CAST(N'1999-08-10' AS Date), N'Quảng Ninh', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (19, N'PQL', N'Cát Mỹ', N'Kim', N'Male', CAST(N'1976-11-26' AS Date), CAST(N'2004-11-30' AS Date), N'Đà Nẵng', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (20, N'PKT', N'Trâm Chi', N'Vũ', N'Female', CAST(N'1976-05-01' AS Date), CAST(N'2014-11-17' AS Date), N'Quảng Bình', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (21, N'PQL', N'Hoài Vân', N'Bùi', N'Male', CAST(N'1985-01-29' AS Date), CAST(N'2003-02-03' AS Date), N'Vĩnh Long', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (22, N'PKT', N'Quế Hằng', N'Võ', N'Unknown', CAST(N'1989-05-01' AS Date), CAST(N'2009-12-10' AS Date), N'Sóc Trăng', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (23, N'PKT', N'Huyền Vân', N'Hồ', N'Unknown', CAST(N'1981-11-19' AS Date), CAST(N'1998-09-08' AS Date), N'Quảng Bình', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (24, N'PQL', N'Quế Bình', N'Đình', N'Male', CAST(N'1995-04-05' AS Date), CAST(N'2009-02-24' AS Date), N'Quảng Trị', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (25, N'PKT', N'Trung Oanh', N'Kim', N'Female', CAST(N'1996-08-27' AS Date), CAST(N'2011-07-22' AS Date), N'Cao Bằng', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (26, N'PQL', N'Huyền Băng', N'Đổ', N'Male', CAST(N'1975-08-25' AS Date), CAST(N'2012-10-09' AS Date), N'Quảng Ninh', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (27, N'PKT', N'QuỳnhGiang', N'Nguyễn', N'Female', CAST(N'1984-09-22' AS Date), CAST(N'2006-06-17' AS Date), N'Bình Phước', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (28, N'PQL', N'Quế Chung', N'Hoàng', N'Male', CAST(N'1987-08-20' AS Date), CAST(N'2017-09-02' AS Date), N'Trà Vinh', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (29, N'PKT', N'Huyền Chung', N'Kim', N'Unknown', CAST(N'1977-01-16' AS Date), CAST(N'1999-04-26' AS Date), N'Kiên Giang', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (30, N'PKT', N'Trung Chi', N'Đình', N'Male', CAST(N'1997-08-30' AS Date), CAST(N'2002-01-24' AS Date), N'Trà Vinh', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (31, N'PQL', N'Trúc Mỹ', N'Vũ', N'Male', CAST(N'1984-11-12' AS Date), CAST(N'1998-06-26' AS Date), N'Hải Dương', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (32, N'PKT', N'Hoài Nga', N'Lý', N'Female', CAST(N'1989-11-02' AS Date), CAST(N'2009-03-19' AS Date), N'Hậu Giang', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (33, N'PKT', N'DiệuNga', N'Dương', N'Male', CAST(N'1988-05-19' AS Date), CAST(N'2009-11-07' AS Date), N'Trà Vinh', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (34, N'PKT', N'Trung Ca', N'Bùi', N'Female', CAST(N'1978-03-22' AS Date), CAST(N'2007-06-17' AS Date), N'Hà Nội', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (35, N'PQL', N'Cát Thảo', N'Nguyễn', N'Male', CAST(N'1980-07-18' AS Date), CAST(N'2006-12-10' AS Date), N'Hà Nam', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (36, N'PQL', N'Quế Anh', N'Đổ', N'Male', CAST(N'1987-08-28' AS Date), CAST(N'2013-09-20' AS Date), N'Bạc Liêu', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (37, N'PKT', N'Xuyến Lam', N'Bùi', N'Female', CAST(N'1993-07-06' AS Date), CAST(N'2009-01-06' AS Date), N'Bắc Ninh', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (38, N'PQL', N'Trâm Băng', N'Đình', N'Male', CAST(N'1997-08-12' AS Date), CAST(N'2015-08-04' AS Date), N'Gia Lai', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (39, N'PKT', N'Thiên Xuân', N'Lê', N'Unknown', CAST(N'1990-06-14' AS Date), CAST(N'2002-11-22' AS Date), N'Hải Dương', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (40, N'PQL', N'Trâm Diệu', N'Hồ', N'Female', CAST(N'1993-02-26' AS Date), CAST(N'2014-06-11' AS Date), N'Đắk Lắk', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (41, N'PQL', N'QuỳnhBằng', N'Hoàng', N'Male', CAST(N'1975-02-15' AS Date), CAST(N'2002-07-04' AS Date), N'Cao Bằng', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (42, N'PQL', N'Tú Vy', N'Đặng', N'Unknown', CAST(N'1992-05-30' AS Date), CAST(N'2009-08-31' AS Date), N'Bình Dương', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (43, N'PQL', N'Huyền Yến', N'Đình', N'Male', CAST(N'1975-08-23' AS Date), CAST(N'2015-03-10' AS Date), N'Bình Phước', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (44, N'PKT', N'Tú Khôi', N'Vũ', N'Male', CAST(N'1977-08-26' AS Date), CAST(N'2015-07-25' AS Date), N'Hà Nam', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (45, N'PKT', N'Nguyệt Oanh', N'Đổ', N'Male', CAST(N'1977-06-23' AS Date), CAST(N'2001-12-20' AS Date), N'Sóc Trăng', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (46, N'PKT', N'Xuyến Linh', N'Hoàng', N'Unknown', CAST(N'1980-09-05' AS Date), CAST(N'2001-03-10' AS Date), N'Quảng Trị', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (47, N'PKT', N'Trâm Khôi', N'Lê', N'Female', CAST(N'1981-12-29' AS Date), CAST(N'2014-03-23' AS Date), N'Hải Phòng', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (48, N'PQL', N'Xuyến An', N'Đổ', N'Male', CAST(N'1996-01-11' AS Date), CAST(N'2002-04-25' AS Date), N'Quảng Ngãi', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (49, N'PKT', N'Nguyệt Xuân', N'Đình', N'Male', CAST(N'1979-02-14' AS Date), CAST(N'2007-09-08' AS Date), N'Cà Mau', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (50, N'PKT', N'Trâm Ca', N'Dương', N'Female', CAST(N'1988-07-04' AS Date), CAST(N'2016-11-01' AS Date), N'Bình Thuận', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (51, N'PKT', N'Xuyến Vân', N'Ngô', N'Male', CAST(N'1992-04-01' AS Date), CAST(N'2011-04-16' AS Date), N'Bình Định', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (52, N'PKT', N'Quế Khôi', N'Trần', N'Female', CAST(N'1981-12-30' AS Date), CAST(N'2013-01-18' AS Date), N'Tuyên Quang', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (53, N'PQL', N'Trúc Anh', N'Lý', N'Unknown', CAST(N'1994-01-31' AS Date), CAST(N'2007-12-27' AS Date), N'Hải Dương', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (54, N'PKT', N'Quế Dương', N'Bùi', N'Unknown', CAST(N'1994-09-09' AS Date), CAST(N'2010-09-13' AS Date), N'Nam Định', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (55, N'PQL', N'Thiên Quyên', N'Dương', N'Unknown', CAST(N'1993-05-01' AS Date), CAST(N'2003-09-21' AS Date), N'Đồng Nai', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (56, N'PKT', N'Cát Chi', N'Đình', N'Female', CAST(N'1991-04-16' AS Date), CAST(N'2003-05-29' AS Date), N'Tiền Giang', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (57, N'PQL', N'Xuyến Nga', N'Phạm', N'Female', CAST(N'1978-04-11' AS Date), CAST(N'2008-10-15' AS Date), N'Yên Bái', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (58, N'PQL', N'Trâm Oanh', N'Vũ', N'Male', CAST(N'1995-01-17' AS Date), CAST(N'2015-12-18' AS Date), N'Hải Dương', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (59, N'PKT', N'Xuyến Chi', N'Đổ', N'Female', CAST(N'1979-02-03' AS Date), CAST(N'2017-03-31' AS Date), N'Vĩnh Long', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (60, N'PKT', N'Trâm Anh', N'Võ', N'Unknown', CAST(N'1995-04-20' AS Date), CAST(N'1998-10-26' AS Date), N'Hà Nội', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (61, N'PQL', N'DiệuDương', N'Dương', N'Male', CAST(N'1993-03-24' AS Date), CAST(N'1999-12-13' AS Date), N'Bắc Kạn', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (62, N'PKT', N'Trâm Ca', N'Bùi', N'Female', CAST(N'1980-07-05' AS Date), CAST(N'2011-10-09' AS Date), N'Bình Dương', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (63, N'PKT', N'Cát Phi', N'Hoàng', N'Unknown', CAST(N'1976-12-15' AS Date), CAST(N'2002-01-01' AS Date), N'Vũng Tàu', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (64, N'PKT', N'Trúc Hằng', N'Dương', N'Female', CAST(N'1987-06-01' AS Date), CAST(N'2004-05-26' AS Date), N'Thanh Hóa', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (65, N'PQL', N'Cát An', N'Trần', N'Male', CAST(N'1977-06-27' AS Date), CAST(N'2006-07-19' AS Date), N'Sơn La', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (66, N'PKT', N'Trúc Giang', N'Võ', N'Unknown', CAST(N'1990-05-26' AS Date), CAST(N'2002-10-14' AS Date), N'TP HCM', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (67, N'PQL', N'Xuyến Bằng', N'Võ', N'Unknown', CAST(N'1986-07-17' AS Date), CAST(N'2002-05-01' AS Date), N'Bắc Ninh', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (68, N'PKT', N'Tú Thảo', N'Hoàng', N'Male', CAST(N'1993-09-12' AS Date), CAST(N'2015-12-28' AS Date), N'Kiên Giang', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (69, N'PQL', N'Tú Vy', N'Hoàng', N'Unknown', CAST(N'1986-05-16' AS Date), CAST(N'2010-01-28' AS Date), N'Lạng Sơn', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (70, N'PKT', N'Trung Bằng', N'Hồ', N'Male', CAST(N'1978-11-07' AS Date), CAST(N'2003-11-08' AS Date), N'Gia Lai', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (71, N'PQL', N'Trung Bằng', N'Ngô', N'Male', CAST(N'1995-03-12' AS Date), CAST(N'2009-10-10' AS Date), N'Gia Lai', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (72, N'PQL', N'DiệuThảo', N'Đặng', N'Female', CAST(N'1984-04-26' AS Date), CAST(N'2009-06-18' AS Date), N'Ninh Thuận', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (73, N'PQL', N'Trung Giang', N'Phạm', N'Female', CAST(N'1994-02-22' AS Date), CAST(N'1998-03-17' AS Date), N'Quảng Ngãi', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (74, N'PKT', N'Trâm Trang', N'Võ', N'Unknown', CAST(N'1985-12-07' AS Date), CAST(N'2001-08-21' AS Date), N'Quảng Ngãi', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (75, N'PQL', N'Tú Bằng', N'Trần', N'Male', CAST(N'1991-12-27' AS Date), CAST(N'2008-04-17' AS Date), N'Hà Nam', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (76, N'PQL', N'Nguyệt Dương', N'Lê', N'Unknown', CAST(N'1990-05-29' AS Date), CAST(N'2011-02-15' AS Date), N'Quảng Bình', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (77, N'PKT', N'QuỳnhLam', N'Kim', N'Unknown', CAST(N'1975-03-30' AS Date), CAST(N'2002-12-22' AS Date), N'Cà Mau', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (78, N'PKT', N'QuỳnhChi', N'Đổ', N'Unknown', CAST(N'1990-03-24' AS Date), CAST(N'2002-05-10' AS Date), N'Phú Thọ', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (79, N'PQL', N'Tú Diệu', N'Đổ', N'Male', CAST(N'1992-09-30' AS Date), CAST(N'2008-11-04' AS Date), N'Bắc Kạn', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (80, N'PKT', N'Trâm Lam', N'Phạm', N'Male', CAST(N'1987-12-17' AS Date), CAST(N'2013-07-24' AS Date), N'Long An', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (81, N'PKT', N'QuỳnhVy', N'Vũ', N'Male', CAST(N'1978-12-24' AS Date), CAST(N'2000-01-26' AS Date), N'Hà Tĩnh', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (82, N'PKT', N'Xuyến Cúc', N'Hồ', N'Male', CAST(N'1981-03-28' AS Date), CAST(N'2016-06-28' AS Date), N'Đồng Nai', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (83, N'PKT', N'Trúc Băng', N'Trần', N'Unknown', CAST(N'1982-02-12' AS Date), CAST(N'2008-09-09' AS Date), N'Lào Cai', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (84, N'PQL', N'Hoài Bình', N'Hồ', N'Female', CAST(N'1986-01-25' AS Date), CAST(N'2013-06-24' AS Date), N'Vũng Tàu', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (85, N'PQL', N'Trúc Du', N'Trần', N'Unknown', CAST(N'1983-09-20' AS Date), CAST(N'2013-02-24' AS Date), N'Đắk Nông', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (86, N'PQL', N'QuỳnhXuân', N'Dương', N'Male', CAST(N'1981-06-24' AS Date), CAST(N'2002-01-22' AS Date), N'Phú Yên', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (87, N'PKT', N'Trúc Thảo', N'Phạm', N'Female', CAST(N'1981-06-27' AS Date), CAST(N'1998-05-27' AS Date), N'Hà Nội', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (88, N'PQL', N'Huyền Thảo', N'Hoàng', N'Female', CAST(N'1975-08-09' AS Date), CAST(N'2003-03-21' AS Date), N'Bắc Kạn', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (89, N'PKT', N'Tú Ca', N'Bùi', N'Unknown', CAST(N'1990-05-03' AS Date), CAST(N'1998-09-27' AS Date), N'TP HCM', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (90, N'PKT', N'DiệuGiang', N'Đặng', N'Unknown', CAST(N'1979-07-16' AS Date), CAST(N'2009-06-20' AS Date), N'Tuyên Quang', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (91, N'PQL', N'Nguyệt Nga', N'Bùi', N'Male', CAST(N'1995-01-10' AS Date), CAST(N'2013-01-15' AS Date), N'TP HCM', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (92, N'PKT', N'Xuyến Vân', N'Đổ', N'Female', CAST(N'1995-08-12' AS Date), CAST(N'1999-04-18' AS Date), N'Tiền Giang', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (93, N'PQL', N'Huyền Du', N'Lý', N'Unknown', CAST(N'1980-05-01' AS Date), CAST(N'2005-08-14' AS Date), N'Hậu Giang', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (94, N'PQL', N'Quế Du', N'Phạm', N'Unknown', CAST(N'1981-12-15' AS Date), CAST(N'1998-04-03' AS Date), N'Tây Ninh', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (95, N'PKT', N'QuỳnhLam', N'Lê', N'Male', CAST(N'1979-05-11' AS Date), CAST(N'2001-07-04' AS Date), N'Phú Thọ', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (96, N'PKT', N'DiệuYến', N'Nguyễn', N'Male', CAST(N'1977-04-15' AS Date), CAST(N'2007-11-23' AS Date), N'Quảng Bình', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (97, N'PQL', N'Trâm Quyên', N'Hoàng', N'Male', CAST(N'1992-04-18' AS Date), CAST(N'2015-01-08' AS Date), N'Sóc Trăng', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (98, N'PKT', N'Xuyến Yến', N'Bùi', N'Male', CAST(N'1987-09-15' AS Date), CAST(N'2011-01-24' AS Date), N'Hậu Giang', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (99, N'PKT', N'Quế Vy', N'Bùi', N'Female', CAST(N'1986-09-21' AS Date), CAST(N'2006-09-21' AS Date), N'Bắc Kạn', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (100, N'PKT', N'Nguyệt Xuân', N'Đặng', N'Male', CAST(N'1992-01-10' AS Date), CAST(N'2001-05-29' AS Date), N'Yên Bái', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (101, N'PQL', N'Trâm Băng', N'Đặng', N'Female', CAST(N'1995-08-12' AS Date), CAST(N'2015-03-27' AS Date), N'Ninh Thuận', 123, 1, N'PQL', 2)
GO
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (102, N'PKT', N'Cát An', N'Dương', N'Male', CAST(N'1980-12-02' AS Date), CAST(N'2014-01-16' AS Date), N'TP HCM', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (103, N'PKT', N'Hoài Dương', N'Bùi', N'Male', CAST(N'1988-02-06' AS Date), CAST(N'2011-07-05' AS Date), N'Cao Bằng', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (104, N'PQL', N'Trung Bình', N'Vũ', N'Female', CAST(N'1975-11-22' AS Date), CAST(N'2009-03-10' AS Date), N'Hà Nội', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (105, N'PQL', N'Quế Anh', N'Phạm', N'Male', CAST(N'1991-12-10' AS Date), CAST(N'2014-12-22' AS Date), N'Đắk Lắk', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (106, N'PKT', N'Trâm Trang', N'Dương', N'Unknown', CAST(N'1976-10-05' AS Date), CAST(N'2002-02-10' AS Date), N'Lạng Sơn', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (107, N'PKT', N'Quế Ca', N'Đình', N'Female', CAST(N'1996-08-08' AS Date), CAST(N'2003-08-11' AS Date), N'Phú Yên', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (108, N'PKT', N'Trâm Anh', N'Lê', N'Unknown', CAST(N'1983-09-25' AS Date), CAST(N'2012-06-12' AS Date), N'Bắc Kạn', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (109, N'PKT', N'Xuyến Vân', N'Dương', N'Male', CAST(N'1986-05-13' AS Date), CAST(N'2014-12-21' AS Date), N'Bình Phước', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (110, N'PKT', N'Hoài Oanh', N'Võ', N'Unknown', CAST(N'1992-08-10' AS Date), CAST(N'2000-09-28' AS Date), N'Bắc Kạn', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (111, N'PKT', N'Huyền Nga', N'Võ', N'Male', CAST(N'1979-05-14' AS Date), CAST(N'2014-09-17' AS Date), N'Lâm Đồng', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (112, N'PQL', N'Thiên Hằng', N'Vũ', N'Female', CAST(N'1979-10-27' AS Date), CAST(N'2013-10-13' AS Date), N'Đắk Lắk', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (113, N'PKT', N'Thiên Chi', N'Lý', N'Unknown', CAST(N'1990-10-09' AS Date), CAST(N'2010-12-01' AS Date), N'Hưng Yên', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (114, N'PQL', N'Tú Khôi', N'Đặng', N'Unknown', CAST(N'1979-10-23' AS Date), CAST(N'2006-01-16' AS Date), N'Kiên Giang', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (115, N'PQL', N'Trung Bằng', N'Phạm', N'Unknown', CAST(N'1997-01-09' AS Date), CAST(N'2010-02-11' AS Date), N'Ninh Thuận', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (116, N'PQL', N'Trâm Quyên', N'Lê', N'Male', CAST(N'1991-10-28' AS Date), CAST(N'2001-05-05' AS Date), N'Quảng Ninh', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (117, N'PQL', N'Huyền Yến', N'Đình', N'Male', CAST(N'1976-07-11' AS Date), CAST(N'2001-10-07' AS Date), N'Khánh Hòa', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (118, N'PQL', N'Trung Cúc', N'Nguyễn', N'Unknown', CAST(N'1991-09-04' AS Date), CAST(N'2002-04-09' AS Date), N'Bến Tre', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (119, N'PQL', N'DiệuGiang', N'Kim', N'Male', CAST(N'1991-09-01' AS Date), CAST(N'2003-03-22' AS Date), N'Đồng Nai', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (120, N'PQL', N'QuỳnhTrang', N'Lê', N'Female', CAST(N'1991-02-18' AS Date), CAST(N'1999-06-07' AS Date), N'An Giang', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (121, N'PQL', N'QuỳnhLam', N'Lê', N'Female', CAST(N'1979-04-15' AS Date), CAST(N'2016-12-15' AS Date), N'Hà Tĩnh', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (122, N'PQL', N'Trung Khôi', N'Nguyễn', N'Unknown', CAST(N'1978-04-10' AS Date), CAST(N'2016-09-11' AS Date), N'Nghệ An', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (123, N'PKT', N'Quế Linh', N'Hồ', N'Male', CAST(N'1991-01-09' AS Date), CAST(N'2001-07-31' AS Date), N'Lâm Đồng', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (124, N'PKT', N'Cát Chung', N'Đình', N'Female', CAST(N'1977-10-30' AS Date), CAST(N'2015-09-22' AS Date), N'Đồng Nai', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (125, N'PKT', N'Huyền Thảo', N'Lý', N'Female', CAST(N'1997-08-20' AS Date), CAST(N'2005-02-27' AS Date), N'Thái Bình', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (126, N'PQL', N'Trung Chi', N'Đình', N'Unknown', CAST(N'1983-10-15' AS Date), CAST(N'2006-07-09' AS Date), N'Khánh Hòa', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (127, N'PQL', N'Tú Cúc', N'Đổ', N'Male', CAST(N'1990-10-15' AS Date), CAST(N'2012-06-11' AS Date), N'Bắc Kạn', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (128, N'PQL', N'Huyền Lam', N'Bùi', N'Female', CAST(N'1996-05-23' AS Date), CAST(N'2005-08-13' AS Date), N'Nghệ An', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (129, N'PQL', N'Trung Bằng', N'Trần', N'Unknown', CAST(N'1975-07-14' AS Date), CAST(N'2008-07-11' AS Date), N'Lào Cai', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (130, N'PKT', N'QuỳnhDương', N'Hồ', N'Male', CAST(N'1991-12-10' AS Date), CAST(N'2013-10-25' AS Date), N'Lai Châu', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (131, N'PQL', N'Xuyến Du', N'Đình', N'Unknown', CAST(N'1986-10-05' AS Date), CAST(N'2014-10-08' AS Date), N'Vĩnh Long', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (132, N'PQL', N'Nguyệt Giang', N'Kim', N'Unknown', CAST(N'1991-06-27' AS Date), CAST(N'2010-06-22' AS Date), N'Vĩnh Long', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (133, N'PKT', N'Thiên Bình', N'Võ', N'Female', CAST(N'1995-10-18' AS Date), CAST(N'2016-02-06' AS Date), N'Hậu Giang', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (134, N'PQL', N'Tú Linh', N'Đình', N'Unknown', CAST(N'1995-08-17' AS Date), CAST(N'2004-08-10' AS Date), N'Bến Tre', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (135, N'PKT', N'Quế Băng', N'Trần', N'Unknown', CAST(N'1994-10-21' AS Date), CAST(N'2005-03-29' AS Date), N'Kon Tum', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (136, N'PKT', N'Thiên Yến', N'Đặng', N'Female', CAST(N'1985-07-09' AS Date), CAST(N'2005-02-19' AS Date), N'Khánh Hòa', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (137, N'PKT', N'Trúc Bình', N'Hoàng', N'Female', CAST(N'1992-05-23' AS Date), CAST(N'2012-11-02' AS Date), N'Đồng Nai', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (138, N'PQL', N'Trâm Dương', N'Ngô', N'Unknown', CAST(N'1983-09-20' AS Date), CAST(N'2005-05-03' AS Date), N'Đắk Nông', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (139, N'PQL', N'Cát Dương', N'Hoàng', N'Male', CAST(N'1991-12-02' AS Date), CAST(N'2011-04-08' AS Date), N'Ninh Thuận', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (140, N'PKT', N'Nguyệt Oanh', N'Vũ', N'Female', CAST(N'1988-06-15' AS Date), CAST(N'2014-03-13' AS Date), N'Đắk Lắk', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (141, N'PQL', N'Thiên Chung', N'Vũ', N'Unknown', CAST(N'1997-07-14' AS Date), CAST(N'2004-06-27' AS Date), N'Đà Nẵng', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (142, N'PKT', N'Trúc Linh', N'Đổ', N'Female', CAST(N'1989-07-10' AS Date), CAST(N'2000-11-05' AS Date), N'Long An', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (143, N'PKT', N'QuỳnhCa', N'Dương', N'Female', CAST(N'1985-03-15' AS Date), CAST(N'2004-09-06' AS Date), N'Hà Tĩnh', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (144, N'PQL', N'Trúc Du', N'Lê', N'Unknown', CAST(N'1989-01-04' AS Date), CAST(N'2002-12-11' AS Date), N'Tây Ninh', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (145, N'PKT', N'Huyền Linh', N'Trần', N'Male', CAST(N'1986-07-13' AS Date), CAST(N'2002-07-03' AS Date), N'Bình Phước', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (146, N'PKT', N'Huyền Mỹ', N'Nguyễn', N'Unknown', CAST(N'1980-01-02' AS Date), CAST(N'2007-08-27' AS Date), N'Thanh Hóa', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (147, N'PKT', N'Huyền Quyên', N'Vũ', N'Female', CAST(N'1982-01-04' AS Date), CAST(N'2015-04-11' AS Date), N'Trà Vinh', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (148, N'PKT', N'Cát Băng', N'Lê', N'Female', CAST(N'1981-05-20' AS Date), CAST(N'2003-12-27' AS Date), N'Cần Thơ', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (149, N'PQL', N'Quế Bình', N'Kim', N'Male', CAST(N'1981-11-16' AS Date), CAST(N'1998-10-03' AS Date), N'Ninh Thuận', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (150, N'PQL', N'Tú Giang', N'Đổ', N'Female', CAST(N'1992-12-15' AS Date), CAST(N'2000-05-04' AS Date), N'Hòa Bình', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (151, N'PQL', N'Trung Băng', N'Đặng', N'Male', CAST(N'1992-12-20' AS Date), CAST(N'2005-10-31' AS Date), N'Huế', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (152, N'PQL', N'Trúc Mỹ', N'Đổ', N'Unknown', CAST(N'1989-08-21' AS Date), CAST(N'2005-06-29' AS Date), N'Quảng Nam', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (153, N'PKT', N'Hoài Vy', N'Hoàng', N'Female', CAST(N'1989-08-28' AS Date), CAST(N'2008-12-22' AS Date), N'Bình Phước', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (154, N'PKT', N'DiệuNga', N'Đổ', N'Unknown', CAST(N'1984-01-21' AS Date), CAST(N'2004-06-12' AS Date), N'Thái Nguyên', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (155, N'PQL', N'Thiên Giang', N'Phạm', N'Male', CAST(N'1993-12-12' AS Date), CAST(N'2008-01-23' AS Date), N'Hà Tĩnh', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (156, N'PKT', N'Quế Mỹ', N'Trần', N'Male', CAST(N'1986-09-26' AS Date), CAST(N'2008-07-24' AS Date), N'Quảng Ngãi', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (157, N'PQL', N'Quế An', N'Võ', N'Unknown', CAST(N'1985-05-31' AS Date), CAST(N'2000-01-11' AS Date), N'Hà Nam', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (158, N'PKT', N'Xuyến Quyên', N'Ngô', N'Unknown', CAST(N'1997-12-29' AS Date), CAST(N'2007-07-18' AS Date), N'Bắc Kạn', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (159, N'PQL', N'DiệuKhôi', N'Nguyễn', N'Male', CAST(N'1981-12-13' AS Date), CAST(N'2000-08-06' AS Date), N'Tây Ninh', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (160, N'PKT', N'Tú Oanh', N'Hồ', N'Male', CAST(N'1982-10-30' AS Date), CAST(N'2015-01-18' AS Date), N'Bạc Liêu', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (161, N'PQL', N'Xuyến Băng', N'Đặng', N'Female', CAST(N'1981-12-19' AS Date), CAST(N'2012-09-07' AS Date), N'Quảng Ngãi', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (162, N'PKT', N'Quế Giang', N'Bùi', N'Unknown', CAST(N'1992-07-15' AS Date), CAST(N'2004-05-09' AS Date), N'Huế', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (163, N'PKT', N'Trúc Linh', N'Nguyễn', N'Unknown', CAST(N'1975-06-19' AS Date), CAST(N'2011-08-02' AS Date), N'Lạng Sơn', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (164, N'PKT', N'Huyền An', N'Dương', N'Female', CAST(N'1994-03-14' AS Date), CAST(N'2003-01-28' AS Date), N'Bắc Giang', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (165, N'PQL', N'Thiên Ca', N'Kim', N'Male', CAST(N'1989-02-01' AS Date), CAST(N'2016-03-17' AS Date), N'Đắk Nông', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (166, N'PQL', N'Tú Dương', N'Kim', N'Unknown', CAST(N'1995-06-11' AS Date), CAST(N'2004-01-20' AS Date), N'Hà Giang', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (167, N'PKT', N'Trung Diệu', N'Đặng', N'Unknown', CAST(N'1980-10-12' AS Date), CAST(N'2004-11-01' AS Date), N'Kiên Giang', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (168, N'PQL', N'Trúc Trang', N'Ngô', N'Female', CAST(N'1986-06-16' AS Date), CAST(N'2015-04-08' AS Date), N'Quảng Ninh', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (169, N'PQL', N'Xuyến Dương', N'Nguyễn', N'Female', CAST(N'1993-12-20' AS Date), CAST(N'2001-06-10' AS Date), N'Vĩnh Phúc', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (170, N'PKT', N'Huyền Băng', N'Dương', N'Female', CAST(N'1976-01-18' AS Date), CAST(N'2006-04-16' AS Date), N'Yên Bái', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (171, N'PKT', N'Quế Dương', N'Kim', N'Male', CAST(N'1983-11-02' AS Date), CAST(N'2015-08-10' AS Date), N'Tuyên Quang', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (172, N'PQL', N'QuỳnhMỹ', N'Bùi', N'Unknown', CAST(N'1989-01-10' AS Date), CAST(N'2004-12-10' AS Date), N'Hậu Giang', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (173, N'PQL', N'Nguyệt Băng', N'Võ', N'Unknown', CAST(N'1985-09-27' AS Date), CAST(N'2006-02-10' AS Date), N'Hà Giang', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (174, N'PQL', N'Quế Mỹ', N'Kim', N'Female', CAST(N'1982-09-30' AS Date), CAST(N'2016-02-26' AS Date), N'Thái Nguyên', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (175, N'PQL', N'QuỳnhHằng', N'Nguyễn', N'Female', CAST(N'1994-09-25' AS Date), CAST(N'2016-09-25' AS Date), N'Quảng Bình', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (176, N'PQL', N'Tú Vân', N'Vũ', N'Unknown', CAST(N'1992-01-17' AS Date), CAST(N'2016-08-23' AS Date), N'Quảng Nam', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (177, N'PKT', N'Xuyến Dương', N'Kim', N'Unknown', CAST(N'1975-07-10' AS Date), CAST(N'2008-07-16' AS Date), N'Hà Nội', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (178, N'PKT', N'Hoài Phi', N'Nguyễn', N'Unknown', CAST(N'1979-08-28' AS Date), CAST(N'2006-12-02' AS Date), N'Thái Bình', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (179, N'PKT', N'Hoài Nga', N'Nguyễn', N'Male', CAST(N'1988-01-11' AS Date), CAST(N'2001-09-11' AS Date), N'Phú Thọ', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (180, N'PQL', N'Tú Giang', N'Dương', N'Unknown', CAST(N'1989-07-03' AS Date), CAST(N'2008-08-06' AS Date), N'Bạc Liêu', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (181, N'PQL', N'Xuyến Dương', N'Đặng', N'Male', CAST(N'1983-04-02' AS Date), CAST(N'2007-12-18' AS Date), N'Phú Yên', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (182, N'PKT', N'Xuyến Diệu', N'Bùi', N'Male', CAST(N'1983-01-28' AS Date), CAST(N'2004-01-30' AS Date), N'Hải Phòng', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (183, N'PQL', N'Quế Phi', N'Lý', N'Female', CAST(N'1996-04-29' AS Date), CAST(N'2006-02-03' AS Date), N'Phú Yên', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (184, N'PQL', N'Tú Bằng', N'Ngô', N'Female', CAST(N'1992-07-12' AS Date), CAST(N'2010-11-30' AS Date), N'Đồng Nai', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (185, N'PQL', N'Hoài Quyên', N'Nguyễn', N'Male', CAST(N'1979-09-15' AS Date), CAST(N'2001-04-18' AS Date), N'Bạc Liêu', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (186, N'PKT', N'Trâm Linh', N'Nguyễn', N'Unknown', CAST(N'1995-11-10' AS Date), CAST(N'2013-09-13' AS Date), N'An Giang', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (187, N'PQL', N'Nguyệt Chung', N'Đổ', N'Male', CAST(N'1975-01-06' AS Date), CAST(N'2003-05-02' AS Date), N'Cần Thơ', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (188, N'PQL', N'Quế Cúc', N'Bùi', N'Female', CAST(N'1985-01-15' AS Date), CAST(N'2016-07-15' AS Date), N'Quảng Ninh', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (189, N'PQL', N'Tú Vân', N'Lý', N'Female', CAST(N'1984-06-17' AS Date), CAST(N'2005-02-25' AS Date), N'Quảng Nam', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (190, N'PKT', N'Cát Trang', N'Bùi', N'Female', CAST(N'1985-01-20' AS Date), CAST(N'2002-11-03' AS Date), N'Phú Thọ', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (191, N'PKT', N'Trúc Nga', N'Phạm', N'Female', CAST(N'1988-02-22' AS Date), CAST(N'2009-09-30' AS Date), N'Đà Nẵng', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (192, N'PQL', N'Cát Du', N'Lê', N'Unknown', CAST(N'1979-11-03' AS Date), CAST(N'1998-03-18' AS Date), N'Đồng Nai', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (193, N'PQL', N'QuỳnhAn', N'Trần', N'Female', CAST(N'1977-11-01' AS Date), CAST(N'2001-05-17' AS Date), N'Phú Thọ', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (194, N'PQL', N'Hoài Bằng', N'Lê', N'Female', CAST(N'1977-05-22' AS Date), CAST(N'2012-03-25' AS Date), N'Hòa Bình', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (195, N'PKT', N'Trung Vy', N'Ngô', N'Unknown', CAST(N'1990-01-15' AS Date), CAST(N'2015-04-08' AS Date), N'Ninh Thuận', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (196, N'PKT', N'Nguyệt Thảo', N'Đặng', N'Male', CAST(N'1982-01-13' AS Date), CAST(N'2006-01-19' AS Date), N'Bắc Ninh', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (197, N'PKT', N'QuỳnhDiệu', N'Phạm', N'Unknown', CAST(N'1994-08-20' AS Date), CAST(N'2009-09-24' AS Date), N'Nghệ An', 456, 4, N'PKT', 6)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (198, N'PQL', N'Thiên Nga', N'Kim', N'Male', CAST(N'1976-10-24' AS Date), CAST(N'2000-07-25' AS Date), N'Ninh Bình', 123, 1, N'PQL', 3)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (199, N'PKT', N'Trúc Cúc', N'Lê', N'Male', CAST(N'1978-07-24' AS Date), CAST(N'2004-07-08' AS Date), N'Cà Mau', 456, 4, N'PKT', 5)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (200, N'PQL', N'Trung Xuân', N'Bùi', N'Male', CAST(N'1997-01-07' AS Date), CAST(N'2010-03-23' AS Date), N'Hậu Giang', 123, 1, N'PQL', 2)
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (201, N'PQL', N'Trâm Khôi', N'Ngô', N'Unknown', CAST(N'1996-03-07' AS Date), CAST(N'2016-07-06' AS Date), N'Sơn La', 123, 1, N'PQL', 3)
GO
INSERT [dbo].[NhanVien] ([Id], [Kh], [FName], [LName], [GioiTinh], [DOB], [HireDay], [QueQuan], [Id_PB], [Id_NQL], [Kh_NQL], [Id_CV]) VALUES (202, N'PQL', N'DiệuVy', N'Ngô', N'Female', CAST(N'1980-03-31' AS Date), CAST(N'2012-03-21' AS Date), N'Quảng Trị', 123, 1, N'PQL', 3)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
INSERT [dbo].[NV_KTKL] ([Id_NV], [Kh_NV], [Id_KTKL]) VALUES (1, N'PQL', 1)
INSERT [dbo].[NV_KTKL] ([Id_NV], [Kh_NV], [Id_KTKL]) VALUES (1, N'PQL', 3)
INSERT [dbo].[NV_KTKL] ([Id_NV], [Kh_NV], [Id_KTKL]) VALUES (4, N'PKT', 2)
INSERT [dbo].[NV_KTKL] ([Id_NV], [Kh_NV], [Id_KTKL]) VALUES (10, N'PKT', 1)
INSERT [dbo].[NV_KTKL] ([Id_NV], [Kh_NV], [Id_KTKL]) VALUES (12, N'PKT', 2)
INSERT [dbo].[PhongBan] ([Id], [NamePB], [KyHieu]) VALUES (123, N'Phòng Quản Lý', N'PQL')
INSERT [dbo].[PhongBan] ([Id], [NamePB], [KyHieu]) VALUES (456, N'Phòng Kế Toán', N'PKT')
INSERT [dbo].[PhongBan_ChucVu] ([Id_PB], [Id_CV]) VALUES (123, 1)
INSERT [dbo].[PhongBan_ChucVu] ([Id_PB], [Id_CV]) VALUES (123, 2)
INSERT [dbo].[PhongBan_ChucVu] ([Id_PB], [Id_CV]) VALUES (123, 3)
INSERT [dbo].[PhongBan_ChucVu] ([Id_PB], [Id_CV]) VALUES (456, 4)
INSERT [dbo].[PhongBan_ChucVu] ([Id_PB], [Id_CV]) VALUES (456, 5)
INSERT [dbo].[PhongBan_ChucVu] ([Id_PB], [Id_CV]) VALUES (456, 6)
INSERT [dbo].[ThanNhan] ([IdNV], [KhNV], [QuanHe], [NameTN], [DOB]) VALUES (1, N'PQL', N'Trần Văn A', N'Con', CAST(N'2000-10-20' AS Date))
INSERT [dbo].[ThanNhan] ([IdNV], [KhNV], [QuanHe], [NameTN], [DOB]) VALUES (4, N'PKT', N'Nguyễn Thị B', N'Con', CAST(N'2010-10-29' AS Date))
ALTER TABLE [dbo].[ChucVu]  WITH CHECK ADD  CONSTRAINT [FK_CV_ML] FOREIGN KEY([Id_ML])
REFERENCES [dbo].[MucLuong] ([Id])
GO
ALTER TABLE [dbo].[ChucVu] CHECK CONSTRAINT [FK_CV_ML]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NQL_NV] FOREIGN KEY([Id_NQL], [Kh_NQL])
REFERENCES [dbo].[NhanVien] ([Id], [Kh])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NQL_NV]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NV_CV] FOREIGN KEY([Id_CV])
REFERENCES [dbo].[ChucVu] ([Id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NV_CV]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_PB_NV] FOREIGN KEY([Id_PB])
REFERENCES [dbo].[PhongBan] ([Id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_PB_NV]
GO
ALTER TABLE [dbo].[NV_KTKL]  WITH CHECK ADD  CONSTRAINT [FK_KTKL_NVKTKL] FOREIGN KEY([Id_KTKL])
REFERENCES [dbo].[KTKL] ([Id])
GO
ALTER TABLE [dbo].[NV_KTKL] CHECK CONSTRAINT [FK_KTKL_NVKTKL]
GO
ALTER TABLE [dbo].[NV_KTKL]  WITH CHECK ADD  CONSTRAINT [FK_NV_NVKTKL] FOREIGN KEY([Id_NV], [Kh_NV])
REFERENCES [dbo].[NhanVien] ([Id], [Kh])
GO
ALTER TABLE [dbo].[NV_KTKL] CHECK CONSTRAINT [FK_NV_NVKTKL]
GO
ALTER TABLE [dbo].[PhieuLuong]  WITH CHECK ADD  CONSTRAINT [FK_NV_PL] FOREIGN KEY([Id_NV], [Kh_NV])
REFERENCES [dbo].[NhanVien] ([Id], [Kh])
GO
ALTER TABLE [dbo].[PhieuLuong] CHECK CONSTRAINT [FK_NV_PL]
GO
ALTER TABLE [dbo].[PhongBan_ChucVu]  WITH CHECK ADD  CONSTRAINT [FK_CV_PBCVd] FOREIGN KEY([Id_CV])
REFERENCES [dbo].[ChucVu] ([Id])
GO
ALTER TABLE [dbo].[PhongBan_ChucVu] CHECK CONSTRAINT [FK_CV_PBCVd]
GO
ALTER TABLE [dbo].[PhongBan_ChucVu]  WITH CHECK ADD  CONSTRAINT [FK_PB_PBCV] FOREIGN KEY([Id_PB])
REFERENCES [dbo].[PhongBan] ([Id])
GO
ALTER TABLE [dbo].[PhongBan_ChucVu] CHECK CONSTRAINT [FK_PB_PBCV]
GO
ALTER TABLE [dbo].[ThanNhan]  WITH CHECK ADD  CONSTRAINT [FK_TN_NV] FOREIGN KEY([IdNV], [KhNV])
REFERENCES [dbo].[NhanVien] ([Id], [Kh])
GO
ALTER TABLE [dbo].[ThanNhan] CHECK CONSTRAINT [FK_TN_NV]
GO
USE [master]
GO
ALTER DATABASE [Final] SET  READ_WRITE 
GO

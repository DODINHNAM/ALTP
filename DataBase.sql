USE [master]
GO
/****** Object:  Database [ALTP]    Script Date: 8/31/2021 1:21:06 PM ******/
CREATE DATABASE [ALTP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ALTP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ALTP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ALTP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ALTP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ALTP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ALTP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ALTP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ALTP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ALTP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ALTP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ALTP] SET ARITHABORT OFF 
GO
ALTER DATABASE [ALTP] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ALTP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ALTP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ALTP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ALTP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ALTP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ALTP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ALTP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ALTP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ALTP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ALTP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ALTP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ALTP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ALTP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ALTP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ALTP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ALTP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ALTP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ALTP] SET  MULTI_USER 
GO
ALTER DATABASE [ALTP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ALTP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ALTP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ALTP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ALTP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ALTP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ALTP] SET QUERY_STORE = OFF
GO
USE [ALTP]
GO
/****** Object:  UserDefinedFunction [dbo].[ThongTinCauHoi]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[ThongTinCauHoi](@id int)
returns @CauHoi table
(
	CauHoi nvarchar(500),
	A nvarchar(50),
	B nvarchar(50),
	C nvarchar(50),
	D nvarchar(50),
	DapAn nvarchar(50)
)
as
	begin
		insert into @CauHoi
		select CauHoi , A , B , C , D, DapAn from cauhoi where ID = @id
		return
	end
GO
/****** Object:  Table [dbo].[cauhoi]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cauhoi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CauHoi] [nvarchar](500) NOT NULL,
	[A] [nvarchar](50) NOT NULL,
	[B] [nvarchar](50) NOT NULL,
	[C] [nvarchar](50) NOT NULL,
	[D] [nvarchar](50) NOT NULL,
	[DapAn] [nvarchar](50) NOT NULL,
	[TaiKhoan] [varchar](50) ,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[TaiKhoan] [varchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[SoDT] [numeric](18, 0) NOT NULL,
	[Quyen] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thanhtich]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thanhtich](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[Diem] [int] NOT NULL,
	[NgayChoi] [datetime] NULL,
	[TaiKhoan] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cauhoi] ON 

INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (1, N'Hello có nghĩa là?', N'Tạm biệt', N'Chúc ngủ ngon', N'Tha thứ', N'Xin chào', N'Xin chào', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (2, N'1 kg vàng, 1kg sắt, 1kg bông cái nào nặng nhất?', N'Vàng', N'Bằng nhau', N'Bông', N'Sắt', N'Bằng nhau', N'Hai')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (3, N'Ăn chưa ... lo chưa tới', N'Đủ', N'Nhiều', N'No', N'Đói', N'No', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (4, N'Trong các con vật sau đây con vật nào có sừng?', N'Voi', N'Chó', N'Mèo', N'Trâu', N'Trâu', N'Hai')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (5, N'"Lơ xe" là gì?', N'Lái xe', N'Phụ xe', N'Vá xe', N'Bán xe', N'Phụ xe', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (6, N'Bản đồ đất nước Việt Nam hình chữ gì?', N'V', N'N', N'S', N'Y', N'S', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (7, N'Công cha như núi ngất trời, nghĩa mẹ như nước ngời ngời...', N'Biển Đông', N'Biển Tây', N'Biển Nam', N'Biển Bắc', N'Biển Đông', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (8, N'Áo anh đứt chỉ đường tà, vợ anh chưa có, mẹ già chưa ...', N'May', N'Mua', N'Khâu', N'Vá', N'Khâu', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (9, N'Thạch Sanh làm nghề gì?', N'Thợ may', N'Đốn củi', N'Đào mỏ', N'Giáo viên', N'Đốn củi', N'Hai')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (10, N'Ăn bữa giỗ,... bữa cày', N'Bỏ', N'Lỗ', N'Mất', N'Thua', N'Lỗ', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (11, N'Con vật nào sau đây có ngà', N'Voi', N'Trâu', N'Tê Giác', N'Dê', N'Voi', N'Hai')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (12, N'Ngang như ...', N'Cua', N'Ghẹ', N'Đàn bà', N'Ngỗng', N'Cua', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (13, N'Loài động vật nào có da dày nhất?', N'Voi', N'Người không có râu', N'Tê giác', N'Người có râu', N'Tê giác', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (14, N'Quốc gia có diện tích lớn thứ hai thế giới?', N'Mỹ', N'Canada', N'Trung Quốc', N'Nga', N'Canada', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (15, N'Ông già Noel cưỡi con gì đi phát quà?', N'Nai', N'Hươu', N'Tuần lộc', N'Ngựa', N'Tuần lộc', N'Admin')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (16, N'Quốc gia có diện tích lớn nhất thế giới?', N'Mỹ', N'Canada', N'Trung Quốc', N'Nga', N'Nga', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (17, N'Quốc gia đông dân nhất thế giới?', N'Mỹ', N'Nga', N'Trung Quốc', N'Canada', N'Trung Quốc', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (18, N'Tổ của loài sâu khi biến thành bướm gọi là?', N'Kén', N'Ó', N'Vỏ', N'Da', N'Kén', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (19, N'Nước nào có nhiều bò, trồng nhiều chè nhất thế giới?', N'Trung Quốc', N'Việt Nam', N'Ấn Độ', N'Tây Ban Nha', N'Ấn Độ', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (20, N'Hút thuốc lá có hại cho bộ phận nào nhất?', N'Tim', N'Gan', N'Phổi', N'Ví', N'Phổi', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (21, N'Đàn đáy có mấy dây?', N'1', N'2', N'3', N'Không có dây', N'Không có dây', N'Hai')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (22, N'Nằm bên dãy Hoàng Liên Sơn, Mù Căng Chải tuyệt đẹp là huyện vùng sâu, vùng xa của tỉnh nào?', N'Yên Bái', N'Lào Cai', N'Sơn La', N'Hà Giang', N'Yên Bái', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (23, N'Vũ khí của các chiến binh Samurai là?', N'Đao', N'Kiếm', N'Súng', N'Cung', N'Kiếm', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (24, N'Chú bán ếch ở lại làm chi?', N'Bán ếch', N'Làm chi', N'Chưa rõ', N'Không biết', N'Làm chi', N'Hai')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (25, N'Hà Nội xưa có mấy cửa ô?', N'4', N'5', N'6', N'7', N'4', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (26, N'Khi rơi tự do vật bị lêch về phương nào?', N'Đông', N'Tây', N'Nam', N'Bắc', N'Đông', N'Hai')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (27, N'Số electron tối đa có thể chứa trong lớp p:', N'4', N'5', N'6', N'7', N'6', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (28, N'Từ 1 đến 150 có bao nhiêu chữ số 0?', N'14', N'15', N'16', N'17', N'16', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (29, N'Làng Bát Tràng nỗi tiếng với nghề nào?', N'Gốm', N'Đúc đồng', N'Tranh dân gian', N'Làm cốm', N'Gốm', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (30, N'Nguyên tố có nghĩa là mặt trời?', N'Heli', N'Oxi', N'Hidro', N'Cacbon', N'Heli', N'Nam')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (31, N'Chị ong nâu nâu nâu nâu, chị bay đi đâu?', N'Đi tìm mật', N'Đi đâu', N'Không biết', N'Hỏi chị ý đi', N'Đi đâu', N'Toan')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (32, N'Truyện Kiều có câu: "Chiều chiều bóng ngả về...', N'Đông', N'Tây', N'Nam', N'Bắc', N'Tây', N'Toan')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (33, N'Thủ môn duy nhất từng giành quả bóng vàng Châu Âu là người nước nào?', N'Nga', N'Anh', N'Tây Ban Nha', N'Pháp', N'Nga', N'Toan')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (34, N'Ai là người chơi đầu tiên thành triệu phú mà không cần trợ giúp?', N'John Carpenter', N'Sonali Mukherjee', N'Sunmeet Kaur Sawhney', N'Chính tôi', N'John Carpenter', N'Toan')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (35, N'Tên viết tắt của Liên đoàn bóng đá châu Á?', N'AFC', N'KFC', N'AFT', N'CAF', N'AFC', N'Toan')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (36, N'Liên đoàn bóng đá châu Á thành lập năm nào?', N'1953', N'1954', N'1955', N'1956', N'1954', N'Toan')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (38, N'55 + 55 = ', N'110', N'10 năm', N'15', N'5555', N'110', N'Toan')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (39, N'Người ta dùng axit gì để khắc lên thủy tinh?', N'HCL', N'H2SO4 (Đặc)', N'H2SO4(Loãng)', N'HF', N'HF', N'Toan')
INSERT [dbo].[cauhoi] ([ID], [CauHoi], [A], [B], [C], [D], [DapAn], [TaiKhoan]) VALUES (40, N'Chu Văn An làm quan dưới thời nào?', N'Nhà Trần', N'Nhà Lý', N'Nhà Lê', N'Nhà Hồ', N'Nhà Trần', N'Toan')
SET IDENTITY_INSERT [dbo].[cauhoi] OFF
GO
INSERT [dbo].[taikhoan] ([TaiKhoan], [Ten], [MatKhau], [SoDT], [Quyen]) VALUES (N'Admin', N'Admin', N'Admin', CAST(2222222222 AS Numeric(18, 0)), N'admin')
INSERT [dbo].[taikhoan] ([TaiKhoan], [Ten], [MatKhau], [SoDT], [Quyen]) VALUES (N'Ha', N'Phạm Văn Hà', N'Ha', CAST(4444444444 AS Numeric(18, 0)), N'guest')
INSERT [dbo].[taikhoan] ([TaiKhoan], [Ten], [MatKhau], [SoDT], [Quyen]) VALUES (N'Hai', N'Đặng Văn Hải', N'Hai', CAST(1234567890 AS Numeric(18, 0)), N'manager')
INSERT [dbo].[taikhoan] ([TaiKhoan], [Ten], [MatKhau], [SoDT], [Quyen]) VALUES (N'Nam', N'Đỗ Đình Nam', N'Nam', CAST(3333333333 AS Numeric(18, 0)), N'manager')
INSERT [dbo].[taikhoan] ([TaiKhoan], [Ten], [MatKhau], [SoDT], [Quyen]) VALUES (N'Toan', N'Trần Anh Toan', N'Toan', CAST(1111111111 AS Numeric(18, 0)), N'manager')
GO
SET IDENTITY_INSERT [dbo].[thanhtich] ON 

INSERT [dbo].[thanhtich] ([STT], [Diem], [NgayChoi], [TaiKhoan]) VALUES (1, 1000, CAST(N'2021-07-20T00:00:00.000' AS DateTime), N'Hai')
INSERT [dbo].[thanhtich] ([STT], [Diem], [NgayChoi], [TaiKhoan]) VALUES (2, 3000, CAST(N'2021-07-20T00:00:00.000' AS DateTime), N'Ha')
INSERT [dbo].[thanhtich] ([STT], [Diem], [NgayChoi], [TaiKhoan]) VALUES (3, 8000, CAST(N'2021-07-20T00:00:00.000' AS DateTime), N'Admin')
INSERT [dbo].[thanhtich] ([STT], [Diem], [NgayChoi], [TaiKhoan]) VALUES (4, 6000, CAST(N'2021-07-20T00:00:00.000' AS DateTime), N'Nam')
INSERT [dbo].[thanhtich] ([STT], [Diem], [NgayChoi], [TaiKhoan]) VALUES (5, 2000, CAST(N'2021-07-20T00:00:00.000' AS DateTime), N'Toan')
INSERT [dbo].[thanhtich] ([STT], [Diem], [NgayChoi], [TaiKhoan]) VALUES (6, 6666, CAST(N'2021-07-30T00:00:00.000' AS DateTime), N'Toan')
INSERT [dbo].[thanhtich] ([STT], [Diem], [NgayChoi], [TaiKhoan]) VALUES (7, 100, CAST(N'2021-07-30T00:00:00.000' AS DateTime), N'Toan')
INSERT [dbo].[thanhtich] ([STT], [Diem], [NgayChoi], [TaiKhoan]) VALUES (8, 100, CAST(N'2021-07-30T00:00:00.000' AS DateTime), N'Toan')
INSERT [dbo].[thanhtich] ([STT], [Diem], [NgayChoi], [TaiKhoan]) VALUES (9, 0, CAST(N'2021-07-30T00:00:00.000' AS DateTime), N'Toan')
SET IDENTITY_INSERT [dbo].[thanhtich] OFF
GO
ALTER TABLE [dbo].[cauhoi]  WITH CHECK ADD  CONSTRAINT [FK_cauhoi_taikhoan] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[taikhoan] ([TaiKhoan])
GO
ALTER TABLE [dbo].[cauhoi] CHECK CONSTRAINT [FK_cauhoi_taikhoan]
GO
ALTER TABLE [dbo].[thanhtich]  WITH CHECK ADD  CONSTRAINT [fk_thanhtich_taikhoan] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[taikhoan] ([TaiKhoan])
GO
ALTER TABLE [dbo].[thanhtich] CHECK CONSTRAINT [fk_thanhtich_taikhoan]
GO
/****** Object:  StoredProcedure [dbo].[suaCH]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaCH](@id int, @ch nvarchar(500),@a nvarchar(50),@b nvarchar(50),@c nvarchar(50),@d nvarchar(50), @da nvarchar(50), @tk varchar(50))
as
begin
	if(not exists(select * from cauhoi where ID=@id))
		print(N'Mã câu hỏi này không tồn tại')
	else
	begin
		update cauhoi set CauHoi=@ch, A=@a, B=@b, C=@c, D=@d, DapAn=@da, TaiKhoan=@tk where ID=@id
		print(N'Sửa thành công')
	end
end
GO
/****** Object:  StoredProcedure [dbo].[suaTK]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suaTK](@tk varchar(50),@ten nvarchar(50),@mk varchar(50), @sdt numeric, @quyen varchar(50))
as
begin
	if(not exists(select * from taikhoan where TaiKhoan=@tk))
		print(N'Tài khoản này không tồn tại')
	else
	begin
		update taikhoan set Ten=@ten, MatKhau=@mk, SoDT=@sdt, Quyen=@quyen where TaiKhoan=@tk
		print(N'Sửa thành công')
	end
end
GO
/****** Object:  StoredProcedure [dbo].[themCH]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themCH](@ch nvarchar(500),@a nvarchar(50),@b nvarchar(50),@c nvarchar(50),@d nvarchar(50), @da nvarchar(50), @tk varchar(50))
as
begin
	begin
		insert into cauhoi values(@ch,@a,@b,@c,@d,@da,@tk)
		print(N'Thêm thành công')
	end
end
GO
/****** Object:  StoredProcedure [dbo].[themThanhTich]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themThanhTich](@diem int,@ngaychoi datetime, @tk varchar(50))
as
begin
	begin
		insert into thanhtich values(@diem,@ngaychoi,@tk)
		print(N'Nhập thành công')
	end
end
GO
/****** Object:  StoredProcedure [dbo].[themTK]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themTK](@tk varchar(50),@ten nvarchar(50),@mk varchar(50), @sdt numeric, @quyen varchar(50))
as
begin
	if(exists(select * from taikhoan where TaiKhoan=@tk))
		print(N'Tài khoản này đã tồn tại')
	else
	begin
		insert into taikhoan values(@tk,@ten,@mk,@sdt, @quyen)
		print(N'Thêm thành công')
	end
end
GO
/****** Object:  StoredProcedure [dbo].[xoaCH]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaCH](@id int)
as
begin
	if(not exists(select * from cauhoi where ID=@id))
		print(N'Mã câu hỏi này không tồn tại')
	else
	begin
		delete from cauhoi where ID=@id
		print(N'Xóa thành công')
	end
end
GO
/****** Object:  StoredProcedure [dbo].[xoaTK]    Script Date: 8/31/2021 1:21:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaTK](@tk varchar(50))
as
begin
	if(not exists(select * from taikhoan where TaiKhoan=@tk))
		print(N'Tài khoản này không tồn tại')
	else
	begin
		alter table cauhoi nocheck constraint all
		alter table thanhtich nocheck constraint all
		delete from taikhoan where TaiKhoan=@tk
		alter table thanhtich check constraint all
		alter table cauhoi check constraint all
		print(N'Xóa thành công')
	end
end
GO
USE [master]
GO
ALTER DATABASE [ALTP] SET  READ_WRITE 
GO

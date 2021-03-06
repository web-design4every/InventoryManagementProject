USE [Quanlykho]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[Ma] [int] NOT NULL,
	[TenDVT] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Ma] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[Ma] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](max) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuChi]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuChi](
	[MaChi] [nvarchar](50) NOT NULL,
	[MaQuy] [int] NULL,
	[NguoiNhan] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[LyDo] [nvarchar](max) NULL,
	[SoTien] [float] NULL,
	[Ngay] [datetime] NULL,
 CONSTRAINT [PK_PhieuChi] PRIMARY KEY CLUSTERED 
(
	[MaChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[Ma] [nvarchar](50) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuThu]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThu](
	[MaThu] [nvarchar](50) NOT NULL,
	[MaQuy] [int] NULL,
	[NguoiNop] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[LyDo] [nvarchar](max) NULL,
	[SoTien] [float] NULL,
	[Ngay] [datetime] NULL,
 CONSTRAINT [PK_PhieuThu] PRIMARY KEY CLUSTERED 
(
	[MaThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[Ma] [nvarchar](50) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuyKho]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyKho](
	[MaSo] [int] NOT NULL,
	[QuyTien] [float] NULL,
	[Ngay] [datetime] NULL,
 CONSTRAINT [PK_QuyKho] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SoNoKhachHang]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoNoKhachHang](
	[Ma] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NULL,
	[TienNo] [float] NULL,
 CONSTRAINT [PK_SoNo] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SoNoNCC]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SoNoNCC](
	[Ma] [nvarchar](50) NOT NULL,
	[MaNCC] [nvarchar](50) NULL,
	[TienNo] [float] NULL,
 CONSTRAINT [PK_SoNoNCC] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinNoKH]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinNoKH](
	[MaPhieuXuat] [nvarchar](50) NOT NULL,
	[Ma] [nvarchar](50) NOT NULL,
	[SoTienThanhToan] [float] NULL,
	[SoTienConLai] [float] NULL,
	[NgayTao] [datetime] NULL,
 CONSTRAINT [PK_ThongTinNo] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinNoNCC]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinNoNCC](
	[MaPhieuNhap] [nvarchar](50) NOT NULL,
	[Ma] [nvarchar](50) NOT NULL,
	[SoTienThanhToan] [float] NULL,
	[SoTienConLai] [float] NULL,
	[NgayTao] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinPhieuNhap]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinPhieuNhap](
	[MaNhap] [nvarchar](50) NOT NULL,
	[MaVatLieu] [nvarchar](50) NOT NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
	[SL] [int] NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
	[TongTien] [float] NOT NULL,
 CONSTRAINT [PK_ThongTinPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaNhap] ASC,
	[MaVatLieu] ASC,
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinPhieuXuat]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinPhieuXuat](
	[MaXuat] [nvarchar](50) NOT NULL,
	[MaVatLieu] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[SL] [int] NOT NULL,
	[DonGiaXuat] [float] NOT NULL,
	[TongTien] [float] NOT NULL,
 CONSTRAINT [PK_ThongTinPhieuXuat] PRIMARY KEY CLUSTERED 
(
	[MaXuat] ASC,
	[MaVatLieu] ASC,
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VatLieu]    Script Date: 8/14/2021 6:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatLieu](
	[MaSo] [nvarchar](50) NOT NULL,
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenVatLieu] [nvarchar](50) NOT NULL,
	[MaDVT] [int] NOT NULL,
	[SLTon] [int] NOT NULL,
	[GiaXuat] [float] NOT NULL,
	[GiaNhap] [float] NOT NULL,
 CONSTRAINT [PK_VatLieu] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[DonViTinh] ([Ma], [TenDVT]) VALUES (1, N'Kg')
INSERT [dbo].[DonViTinh] ([Ma], [TenDVT]) VALUES (2, N'Cái')
INSERT [dbo].[DonViTinh] ([Ma], [TenDVT]) VALUES (3, N'Mét')
INSERT [dbo].[KhachHang] ([Ma], [Ten], [DiaChi], [SDT]) VALUES (N'01', N'Chị Lệ Thủy ', N'Mỹ Hào, Hưng Yên', N'0123123123')
INSERT [dbo].[KhachHang] ([Ma], [Ten], [DiaChi], [SDT]) VALUES (N'02', N'Công Ty TNHH Phú Tài', N'Văn Lâm,Hưng Yên', N'0989238717')
INSERT [dbo].[KhachHang] ([Ma], [Ten], [DiaChi], [SDT]) VALUES (N'03', N'Anh Hải Nam', N'Văn Lâm,Hưng Yên', N'0349878642')
INSERT [dbo].[KhachHang] ([Ma], [Ten], [DiaChi], [SDT]) VALUES (N'04', N'Anh Trung Kiên', N'Văn Lâm, Hưng Yên', N'098768974')
INSERT [dbo].[KhachHang] ([Ma], [Ten], [DiaChi], [SDT]) VALUES (N'05', N'CÔNG TY CỔ PHẦN NHỰA TÂN ĐẠI HƯNG', N'Hà Nội', N'0331234566')
INSERT [dbo].[NhaCungCap] ([Ma], [Ten], [DiaChi], [SDT]) VALUES (N'1', N'Chi nhánh công ty cổ phần Yên Mĩ', N'Huyện Yên Mỹ, Hưng Yên', N'0321.942284')
INSERT [dbo].[NhaCungCap] ([Ma], [Ten], [DiaChi], [SDT]) VALUES (N'2', N'Công ty TNHH Dệt may Thygesen', N'Tân Quang, Huyện Văn Lâm, Liên Phương, Hưng Yên', N'02213791677')
INSERT [dbo].[NhaCungCap] ([Ma], [Ten], [DiaChi], [SDT]) VALUES (N'3', N'Công Ty TNHH Vật Liệu Công Nghiệp Long Hải Minh', N'Thôn Mỹ Xá, Xã Việt Cường, Huyện Yên Mỹ,Hưng Yên', N'0934 223 218')
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'001', 2, N'Tùng Lâm', N'Giám Đốc', N'Trả lương nhân viên', 100000000, CAST(N'2021-04-02 00:00:00.000' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'002', 5, N'Tùng Lâm', N'Giám Đốc', N'Trả lương nhân viên tháng 2,2020', 123000000, CAST(N'2021-03-31 22:00:04.153' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'003', 6, N'Tùng Lâm', N'Giám Đốc', N'Nhập kho vật liệu mã số 0014', 1000000, CAST(N'2021-03-31 22:28:04.037' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'004', 8, N'Tùng Lâm', N'Giám Đốc', N'Nhập kho vật liệu mã số 0015', 30000000, CAST(N'2021-04-01 00:15:18.597' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'005', 9, N'Tùng Lâm', N'Giám Đốc', N'Trả nợ nhà cung cấp mã System.Windows.Forms.TextBox, Text: 1', 4000000, CAST(N'2021-04-01 00:53:55.860' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'006', 10, N'Tùng Lâm', N'Giám Đốc', N'Sửa Kho', 95050000, CAST(N'2021-04-01 00:57:13.137' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'007', 13, N'Tùng Lâm', N'Giám Đốc', N'Nhập kho vật liệu mã số 0016', 100000, CAST(N'2021-04-02 16:38:30.383' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'008', 14, N'Tùng Lâm', N'Giám Đốc', N'Nhập kho vật liệu mã số 0017', 250000, CAST(N'2021-04-02 23:05:02.963' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'009', 17, N'Anh Trung Kiên', N'Khách hàng', N'Trả nợ khách hàng mã 04', 200000, CAST(N'2021-04-03 07:52:52.337' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'010', 18, N'Tùng Lâm', N'Giám Đốc', N'Nhập kho vật liệu mã số 0018', 300000, CAST(N'2021-04-03 08:02:57.580' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'011', 19, N'Tùng Lâm', N'Giám Đốc', N'Nhập kho vật liệu mã số 0019', 15000000, CAST(N'2021-04-03 09:11:01.687' AS DateTime))
INSERT [dbo].[PhieuChi] ([MaChi], [MaQuy], [NguoiNhan], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'012', 21, N'Chi nhánh công ty cổ phần Yên Mĩ', N'Nhà cung cấp', N'Trả nợ nhà cung cấp mã 1', 22000, CAST(N'2021-04-03 09:13:00.190' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0001', CAST(N'2021-03-22 14:38:22.757' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0002', CAST(N'2021-03-23 11:07:22.387' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0003', CAST(N'2021-03-23 13:00:27.990' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0004', CAST(N'2021-03-23 13:56:57.127' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0005', CAST(N'2021-03-23 13:58:07.087' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0006', CAST(N'2021-03-23 13:58:34.833' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0007', CAST(N'2021-03-23 13:59:36.743' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0008', CAST(N'2021-03-23 14:00:12.883' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0009', CAST(N'2021-03-23 14:02:53.413' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0010', CAST(N'2021-03-23 14:04:09.323' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0011', CAST(N'2021-03-23 14:04:33.483' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0012', CAST(N'2021-03-23 14:38:39.613' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0013', CAST(N'2021-03-31 13:03:45.893' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0014', CAST(N'2021-03-31 22:28:56.567' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0015', CAST(N'2021-04-01 00:15:52.347' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0016', CAST(N'2021-04-02 16:38:55.340' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0017', CAST(N'2021-04-02 23:05:44.697' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0018', CAST(N'2021-04-03 08:03:34.510' AS DateTime))
INSERT [dbo].[PhieuNhap] ([Ma], [NgayTao]) VALUES (N'0019', CAST(N'2021-04-03 09:11:58.707' AS DateTime))
INSERT [dbo].[PhieuThu] ([MaThu], [MaQuy], [NguoiNop], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'001', 1, N'Chiến Thắng', N'Nhân Viên', N'Bán bải loại a', 100000000, CAST(N'2021-04-01 00:00:00.000' AS DateTime))
INSERT [dbo].[PhieuThu] ([MaThu], [MaQuy], [NguoiNop], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'002', 2, N'Tùng Lâm', N'Giám Đốc', N'Bán can nhựa', 100000, CAST(N'2021-03-31 21:46:27.050' AS DateTime))
INSERT [dbo].[PhieuThu] ([MaThu], [MaQuy], [NguoiNop], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'003', 4, N'Tùng Lâm', N'Giám Đốc', N'Bán vải lọa c', 2340000, CAST(N'2021-03-31 21:53:11.207' AS DateTime))
INSERT [dbo].[PhieuThu] ([MaThu], [MaQuy], [NguoiNop], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'004', 7, N'Tùng Lâm', N'Giám Đốc', N'Xuất kho vật liệu mã số 0004', 1500000, CAST(N'2021-03-31 22:34:00.103' AS DateTime))
INSERT [dbo].[PhieuThu] ([MaThu], [MaQuy], [NguoiNop], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'005', 11, N'Tùng Lâm', N'Giám Đốc', N'Xuất kho vật liệu mã số 0006', 20000000, CAST(N'2021-04-01 01:02:16.313' AS DateTime))
INSERT [dbo].[PhieuThu] ([MaThu], [MaQuy], [NguoiNop], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'006', 12, N'Tùng Lâm', N'Giám Đốc', N'Xuất kho vật liệu mã số 0007', 100000, CAST(N'2021-04-01 01:03:26.850' AS DateTime))
INSERT [dbo].[PhieuThu] ([MaThu], [MaQuy], [NguoiNop], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'007', 15, N'Tùng Lâm', N'Giám Đốc', N'Xuất kho vật liệu mã số 0008', 14000000, CAST(N'2021-04-02 23:06:01.050' AS DateTime))
INSERT [dbo].[PhieuThu] ([MaThu], [MaQuy], [NguoiNop], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'008', 16, N'Công ty TNHH Dệt may Thygesen', N'Nhà cung cấp', N'Thu nợ nhà cung cấp mã 2', 1000000, CAST(N'2021-04-03 07:52:08.873' AS DateTime))
INSERT [dbo].[PhieuThu] ([MaThu], [MaQuy], [NguoiNop], [DiaChi], [LyDo], [SoTien], [Ngay]) VALUES (N'009', 20, N'Tùng Lâm', N'Giám Đốc', N'Xuất kho vật liệu mã số 0009', 7000000, CAST(N'2021-04-03 09:12:11.200' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma], [NgayTao]) VALUES (N'0001', CAST(N'2021-03-29 23:01:44.603' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma], [NgayTao]) VALUES (N'0002', CAST(N'2021-03-29 23:02:28.067' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma], [NgayTao]) VALUES (N'0003', CAST(N'2021-03-29 23:03:01.080' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma], [NgayTao]) VALUES (N'0004', CAST(N'2021-03-31 22:34:43.127' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma], [NgayTao]) VALUES (N'0005', CAST(N'2021-04-01 00:59:15.017' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma], [NgayTao]) VALUES (N'0006', CAST(N'2021-04-01 01:02:59.687' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma], [NgayTao]) VALUES (N'0007', CAST(N'2021-04-01 01:03:57.770' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma], [NgayTao]) VALUES (N'0008', CAST(N'2021-04-02 23:07:04.217' AS DateTime))
INSERT [dbo].[PhieuXuat] ([Ma], [NgayTao]) VALUES (N'0009', CAST(N'2021-04-03 09:12:48.457' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (0, 1234123000, CAST(N'2020-04-30 00:00:00.000' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (1, 1334123000, CAST(N'2020-07-09 00:00:00.000' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (2, 1234123000, CAST(N'2020-08-08 00:00:00.000' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (3, 1234222976, CAST(N'2021-03-31 21:46:27.050' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (4, 1236562944, CAST(N'2021-03-31 21:53:11.207' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (5, 1113562880, CAST(N'2021-03-31 22:00:04.153' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (6, 1112562944, CAST(N'2021-03-31 22:28:04.037' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (7, 1114062976, CAST(N'2021-03-31 22:34:00.103' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (8, 1084062976, CAST(N'2021-04-01 00:15:18.597' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (9, 1080062976, CAST(N'2021-04-01 00:53:55.860' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (10, 985012992, CAST(N'2021-04-01 00:57:13.137' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (11, 1005012992, CAST(N'2021-04-01 01:02:16.313' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (12, 1005112960, CAST(N'2021-04-01 01:03:26.850' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (13, 1005012992, CAST(N'2021-04-02 16:38:30.383' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (14, 1004763008, CAST(N'2021-04-02 23:05:02.963' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (15, 1018763008, CAST(N'2021-04-02 23:06:01.050' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (16, 1019763008, CAST(N'2021-04-03 07:52:08.873' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (17, 1019563008, CAST(N'2021-04-03 07:52:52.337' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (18, 1019262976, CAST(N'2021-04-03 08:02:57.580' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (19, 1004262976, CAST(N'2021-04-03 09:11:01.687' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (20, 1011262976, CAST(N'2021-04-03 09:12:11.200' AS DateTime))
INSERT [dbo].[QuyKho] ([MaSo], [QuyTien], [Ngay]) VALUES (21, 1011240960, CAST(N'2021-04-03 09:13:00.190' AS DateTime))
INSERT [dbo].[SoNoKhachHang] ([Ma], [MaKH], [TienNo]) VALUES (N'01', N'01', 15791000)
INSERT [dbo].[SoNoKhachHang] ([Ma], [MaKH], [TienNo]) VALUES (N'02', N'02', 25001000)
INSERT [dbo].[SoNoKhachHang] ([Ma], [MaKH], [TienNo]) VALUES (N'03', N'03', 2386000)
INSERT [dbo].[SoNoKhachHang] ([Ma], [MaKH], [TienNo]) VALUES (N'04', N'04', -4683000)
INSERT [dbo].[SoNoKhachHang] ([Ma], [MaKH], [TienNo]) VALUES (N'05', N'05', 29350000)
INSERT [dbo].[SoNoNCC] ([Ma], [MaNCC], [TienNo]) VALUES (N'1', N'1', -16689500)
INSERT [dbo].[SoNoNCC] ([Ma], [MaNCC], [TienNo]) VALUES (N'2', N'2', 70055200)
INSERT [dbo].[SoNoNCC] ([Ma], [MaNCC], [TienNo]) VALUES (N'3', N'3', -44451000)
INSERT [dbo].[TaiKhoan] ([TaiKhoan], [MatKhau], [SDT]) VALUES (N'admin     ', N'123       ', N'0989437035')
INSERT [dbo].[ThongTinNoKH] ([MaPhieuXuat], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0001', N'01', 8000000, -1405000, CAST(N'2021-03-29 23:00:50.343' AS DateTime))
INSERT [dbo].[ThongTinNoKH] ([MaPhieuXuat], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0002', N'02', 100000, 537000, CAST(N'2021-03-29 23:00:50.343' AS DateTime))
INSERT [dbo].[ThongTinNoKH] ([MaPhieuXuat], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0003', N'05', 10000000, -1145000, CAST(N'2021-03-29 23:00:50.343' AS DateTime))
INSERT [dbo].[ThongTinNoKH] ([MaPhieuXuat], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0004', N'03', 1500000, 214000, CAST(N'2021-03-31 22:34:00.103' AS DateTime))
INSERT [dbo].[ThongTinNoKH] ([MaPhieuXuat], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0005', N'01', 53000000, 4840000, CAST(N'2021-03-23 11:03:55.883' AS DateTime))
INSERT [dbo].[ThongTinNoKH] ([MaPhieuXuat], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0006', N'04', 20000000, -3680000, CAST(N'2021-04-01 01:02:16.313' AS DateTime))
INSERT [dbo].[ThongTinNoKH] ([MaPhieuXuat], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0007', N'02', 100000, 24000000, CAST(N'2021-04-01 01:03:26.850' AS DateTime))
INSERT [dbo].[ThongTinNoKH] ([MaPhieuXuat], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0008', N'03', 14000000, 531000, CAST(N'2021-04-02 23:06:01.050' AS DateTime))
INSERT [dbo].[ThongTinNoKH] ([MaPhieuXuat], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0009', N'05', 7000000, 450000, CAST(N'2021-04-03 09:12:11.200' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0002', N'1', 45000000, 2700000, CAST(N'2021-03-23 11:06:49.397' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0003', N'1', 20000, -144200, CAST(N'2021-03-23 12:58:58.410' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0004', N'3', 1000, -47999000, CAST(N'2021-03-23 13:56:16.000' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0005', N'1', 100000, 10000, CAST(N'2021-03-23 13:56:16.000' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0006', N'1', 40000000, 17400000, CAST(N'2021-03-23 13:56:16.000' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0012', N'1', 100000, -5900000, CAST(N'2021-03-23 14:38:10.687' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0013', N'1', 4000000, 31700, CAST(N'2021-03-31 13:02:52.860' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0014', N'2', 1000000, -262800, CAST(N'2021-03-31 22:28:04.037' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0015', N'3', 30000000, 26400000, CAST(N'2021-04-01 00:15:18.597' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0017', N'1', 250000, -22000, CAST(N'2021-04-02 23:05:02.963' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0018', N'2', 300000, -15000, CAST(N'2021-04-03 08:02:57.580' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0019', N'1', 15000000, -885000, CAST(N'2021-04-03 09:11:01.687' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0007', N'3', 20000, -45980000, CAST(N'2021-03-23 13:56:16.000' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0008', N'1', 10000, -103000, CAST(N'2021-03-23 13:59:51.437' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0009', N'1', 24000000, 6000000, CAST(N'2021-03-23 14:01:57.837' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0010', N'3', 100000000, 76000000, CAST(N'2021-03-23 14:03:44.057' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0011', N'3', 20000000, 19714000, CAST(N'2021-03-23 14:03:44.057' AS DateTime))
INSERT [dbo].[ThongTinNoNCC] ([MaPhieuNhap], [Ma], [SoTienThanhToan], [SoTienConLai], [NgayTao]) VALUES (N'0016', N'1', 100000, -23000, CAST(N'2021-04-02 16:38:30.383' AS DateTime))
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0001', N'VL01', N'1', 27, 9000, 243000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0002', N'VL01', N'1', 4700, 9000, 42300000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0003', N'VL02', N'1', 8, 11300, 90400)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0003', N'VL04', N'1', 6, 12300, 73800)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0004', N'VL08', N'3', 4000, 12000, 48000000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0005', N'VL01', N'1', 10, 9000, 90000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0006', N'VL02', N'1', 2000, 11300, 22600000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0007', N'VL14', N'3', 2000, 23000, 46000000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0008', N'VL02', N'1', 10, 11300, 113000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0009', N'VL01', N'1', 2000, 9000, 18000000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0010', N'VL08', N'3', 2000, 12000, 24000000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0011', N'VL09', N'3', 20, 14300, 286000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0012', N'VL07', N'1', 3000, 2000, 6000000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0013', N'VL05', N'1', 33, 5100, 168300)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0013', N'VL06', N'1', 300, 12000, 3600000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0013', N'VL07', N'1', 100, 2000, 200000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0014', N'VL11', N'2', 1000, 1200, 1200000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0014', N'VL12', N'2', 19, 1200, 22800)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0014', N'VL13', N'2', 20, 2000, 40000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0015', N'VL08', N'3', 300, 12000, 3600000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0016', N'VL04', N'1', 10, 12300, 123000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0017', N'VL01', N'1', 28, 9000, 252000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0017', N'VL07', N'1', 10, 2000, 20000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0018', N'VL03', N'2', 10, 25000, 250000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0018', N'VL10', N'2', 10, 1100, 11000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0018', N'VL11', N'2', 10, 1200, 12000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0018', N'VL12', N'2', 10, 1200, 12000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0018', N'VL13', N'2', 10, 3000, 30000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0019', N'VL01', N'1', 200, 9000, 1800000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0019', N'VL04', N'1', 150, 12300, 1845000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0019', N'VL06', N'1', 1000, 12000, 12000000)
INSERT [dbo].[ThongTinPhieuNhap] ([MaNhap], [MaVatLieu], [MaNCC], [SL], [DonGiaNhap], [TongTien]) VALUES (N'0019', N'VL07', N'1', 120, 2000, 240000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0001', N'VL02', N'01', 45, 15000, 675000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0001', N'VL07', N'01', 100, 4400, 440000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0001', N'VL14', N'01', 100, 54800, 5480000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0002', N'VL11', N'02', 10, 3100, 31000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0002', N'VL12', N'02', 20, 2900, 58000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0002', N'VL14', N'02', 10, 54800, 548000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0003', N'VL04', N'05', 451, 14000, 6314000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0003', N'VL09', N'05', 121, 21000, 2541000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0004', N'VL01', N'03', 100, 14500, 1450000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0004', N'VL07', N'03', 60, 4400, 264000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0005', N'VL04', N'02', 200, 14000, 2800000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0005', N'VL05', N'02', 200, 9000, 1800000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0005', N'VL11', N'02', 300, 3100, 930000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0006', N'VL01', N'04', 1000, 14500, 14500000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0006', N'VL08', N'04', 100, 18200, 1820000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0007', N'VL09', N'02', 1000, 21000, 21000000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0007', N'VL11', N'02', 1000, 3100, 3100000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0008', N'VL06', N'03', 800, 16000, 12800000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0008', N'VL13', N'03', 300, 5770, 1731000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0009', N'VL01', N'05', 100, 14500, 1450000)
INSERT [dbo].[ThongTinPhieuXuat] ([MaXuat], [MaVatLieu], [MaKH], [SL], [DonGiaXuat], [TongTien]) VALUES (N'0009', N'VL03', N'05', 200, 30000, 6000000)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL01', N'1', N'Vải kaki loại B > 15m', 3, 10743, 14500, 9000)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL02', N'1', N'Vải kaki loại A > 15m', 3, 11171, 15000, 11300)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL03', N'2', N'Can 5 lít', 2, 2810, 30000, 25000)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL04', N'1', N'Vải kaki loại B > 15m', 3, 515, 14000, 12300)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL05', N'1', N'Vải kaki loại A,AN < 15m', 3, 1064, 9000, 5100)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL06', N'1', N'Vải kaki chun', 3, 10700, 16000, 12000)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL07', N'1', N'Vải kaki loại BCD < 15m', 3, 15382, 4400, 2000)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL08', N'3', N'Vải amiăng', 3, 18512, 18200, 13000)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL09', N'3', N'Vải thủy tinh cao su chịu nhiệt', 3, 17899, 21000, 14500)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL10', N'2', N'Bao rứa rách', 1, 4510, 2200, 1100)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL11', N'2', N'Tải dứa muối', 1, 1800, 3100, 1200)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL12', N'2', N'Can 180L có nắp', 2, 132, 2900, 1200)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL13', N'2', N'Ghỉ lò than phế liệu', 1, 961, 5770, 3000)
INSERT [dbo].[VatLieu] ([MaSo], [MaNCC], [TenVatLieu], [MaDVT], [SLTon], [GiaXuat], [GiaNhap]) VALUES (N'VL14', N'3', N'Phi 200L', 2, 1990, 54800, 23000)
ALTER TABLE [dbo].[PhieuChi]  WITH CHECK ADD  CONSTRAINT [FK_PhieuChi_QuyKho] FOREIGN KEY([MaQuy])
REFERENCES [dbo].[QuyKho] ([MaSo])
GO
ALTER TABLE [dbo].[PhieuChi] CHECK CONSTRAINT [FK_PhieuChi_QuyKho]
GO
ALTER TABLE [dbo].[PhieuThu]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThu_QuyKho] FOREIGN KEY([MaQuy])
REFERENCES [dbo].[QuyKho] ([MaSo])
GO
ALTER TABLE [dbo].[PhieuThu] CHECK CONSTRAINT [FK_PhieuThu_QuyKho]
GO
ALTER TABLE [dbo].[SoNoKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_SoNo_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([Ma])
GO
ALTER TABLE [dbo].[SoNoKhachHang] CHECK CONSTRAINT [FK_SoNo_KhachHang]
GO
ALTER TABLE [dbo].[SoNoNCC]  WITH CHECK ADD  CONSTRAINT [FK_SoNoNCC_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([Ma])
GO
ALTER TABLE [dbo].[SoNoNCC] CHECK CONSTRAINT [FK_SoNoNCC_NhaCungCap]
GO
ALTER TABLE [dbo].[ThongTinNoKH]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinNo_SoNo] FOREIGN KEY([Ma])
REFERENCES [dbo].[SoNoKhachHang] ([Ma])
GO
ALTER TABLE [dbo].[ThongTinNoKH] CHECK CONSTRAINT [FK_ThongTinNo_SoNo]
GO
ALTER TABLE [dbo].[ThongTinNoNCC]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinNoNCC_SoNoNCC1] FOREIGN KEY([Ma])
REFERENCES [dbo].[SoNoNCC] ([Ma])
GO
ALTER TABLE [dbo].[ThongTinNoNCC] CHECK CONSTRAINT [FK_ThongTinNoNCC_SoNoNCC1]
GO
ALTER TABLE [dbo].[ThongTinPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinPhieuNhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([Ma])
GO
ALTER TABLE [dbo].[ThongTinPhieuNhap] CHECK CONSTRAINT [FK_ThongTinPhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[ThongTinPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinPhieuNhap_PhieuNhap] FOREIGN KEY([MaNhap])
REFERENCES [dbo].[PhieuNhap] ([Ma])
GO
ALTER TABLE [dbo].[ThongTinPhieuNhap] CHECK CONSTRAINT [FK_ThongTinPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ThongTinPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinPhieuNhap_VatLieu] FOREIGN KEY([MaVatLieu])
REFERENCES [dbo].[VatLieu] ([MaSo])
GO
ALTER TABLE [dbo].[ThongTinPhieuNhap] CHECK CONSTRAINT [FK_ThongTinPhieuNhap_VatLieu]
GO
ALTER TABLE [dbo].[ThongTinPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinPhieuXuat_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([Ma])
GO
ALTER TABLE [dbo].[ThongTinPhieuXuat] CHECK CONSTRAINT [FK_ThongTinPhieuXuat_KhachHang]
GO
ALTER TABLE [dbo].[ThongTinPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinPhieuXuat_PhieuXuat] FOREIGN KEY([MaXuat])
REFERENCES [dbo].[PhieuXuat] ([Ma])
GO
ALTER TABLE [dbo].[ThongTinPhieuXuat] CHECK CONSTRAINT [FK_ThongTinPhieuXuat_PhieuXuat]
GO
ALTER TABLE [dbo].[ThongTinPhieuXuat]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinPhieuXuat_VatLieu] FOREIGN KEY([MaVatLieu])
REFERENCES [dbo].[VatLieu] ([MaSo])
GO
ALTER TABLE [dbo].[ThongTinPhieuXuat] CHECK CONSTRAINT [FK_ThongTinPhieuXuat_VatLieu]
GO
ALTER TABLE [dbo].[VatLieu]  WITH CHECK ADD  CONSTRAINT [FK_VatLieu_DonViTinh] FOREIGN KEY([MaDVT])
REFERENCES [dbo].[DonViTinh] ([Ma])
GO
ALTER TABLE [dbo].[VatLieu] CHECK CONSTRAINT [FK_VatLieu_DonViTinh]
GO

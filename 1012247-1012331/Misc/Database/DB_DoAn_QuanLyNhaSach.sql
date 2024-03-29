USE [DB_DoAn_QuanLyNhaSach]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[SoTienNo] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [DiaChi], [DienThoai], [Email], [SoTienNo]) VALUES (21, N'Le Bich Ngoc', NULL, NULL, NULL, 0)
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [DiaChi], [DienThoai], [Email], [SoTienNo]) VALUES (22, N'Le Bich Ngoc', NULL, NULL, NULL, 0)
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [DiaChi], [DienThoai], [Email], [SoTienNo]) VALUES (23, N'Tran Tien Lam', NULL, NULL, NULL, 0)
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [DiaChi], [DienThoai], [Email], [SoTienNo]) VALUES (24, N'Phan Tien Quang', N'1/8/19 Phan Van Hon', N'01662573900', N'ptquang160492@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
/****** Object:  Table [dbo].[TheLoaiSach]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoaiSach](
	[MaTheLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenTheLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TheLoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TheLoaiSach] ON
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [TenTheLoai]) VALUES (1, N'Kinh tế')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [TenTheLoai]) VALUES (2, N'Chính trị')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [TenTheLoai]) VALUES (3, N'CNTT')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [TenTheLoai]) VALUES (4, N'Toán học')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [TenTheLoai]) VALUES (5, N'Văn học')
INSERT [dbo].[TheLoaiSach] ([MaTheLoai], [TenTheLoai]) VALUES (6, N'Ngoại ngữ')
SET IDENTITY_INSERT [dbo].[TheLoaiSach] OFF
/****** Object:  Table [dbo].[ThamSo]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamSo](
	[SoLuongNhapMin] [int] NOT NULL,
	[SoLuongTonMax] [int] NOT NULL,
	[SoTienKhachNoMax] [int] NOT NULL,
	[SoLuongTonSauBanMin] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ThamSo] ([SoLuongNhapMin], [SoLuongTonMax], [SoTienKhachNoMax], [SoLuongTonSauBanMin]) VALUES (150, 300, 20000, 20)
/****** Object:  Table [dbo].[BaoCaoNoCong]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCaoNoCong](
	[MaBaoCaoNoCong] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [nvarchar](50) NOT NULL,
	[MaKhachHang] [int] NULL,
	[NoDau] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
	[NoCuoi] [int] NULL,
 CONSTRAINT [PK_BaoCaoNoCong] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoNoCong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BaoCaoNoCong] ON
INSERT [dbo].[BaoCaoNoCong] ([MaBaoCaoNoCong], [Thang], [MaKhachHang], [NoDau], [PhatSinh], [NoCuoi]) VALUES (7, N'Tue-15-1-2013', 21, 10, 100, 110)
SET IDENTITY_INSERT [dbo].[BaoCaoNoCong] OFF
/****** Object:  Table [dbo].[Sach]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nvarchar](50) NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[MaTheLoai] [int] NULL,
	[TacGia] [nvarchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuongTon] [int] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [TacGia], [DonGia], [SoLuongTon]) VALUES (N'112', N'Anh van 1', 6, N'Nguyen Hoang Giang', 10000, 200)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [TacGia], [DonGia], [SoLuongTon]) VALUES (N'113', N'Anh van 2', 6, N'Nguyen Hoang Giang', 10000, 200)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [TacGia], [DonGia], [SoLuongTon]) VALUES (N'125', N'Huong doi tuong', 3, N'Tran Dan Thu', 25000, 500)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [TacGia], [DonGia], [SoLuongTon]) VALUES (N'169', N'Mang may tinh', 3, N'Nguyen Thi My Trang', 15000, 200)
INSERT [dbo].[Sach] ([MaSach], [TenSach], [MaTheLoai], [TacGia], [DonGia], [SoLuongTon]) VALUES (N'221', N'Mac-LeNin', 2, N'Doan Gioi', 30000, 150)
/****** Object:  Table [dbo].[PhieuThuTien]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuTien](
	[MaPhieuThuTien] [int] IDENTITY(1,1) NOT NULL,
	[NgayThu] [nvarchar](50) NOT NULL,
	[SoTienThu] [int] NOT NULL,
	[MaKhachHang] [int] NULL,
 CONSTRAINT [PK_PhieuThuTien] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThuTien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PhieuThuTien] ON
INSERT [dbo].[PhieuThuTien] ([MaPhieuThuTien], [NgayThu], [SoTienThu], [MaKhachHang]) VALUES (1, N'Sun-13-1-2013', 20000, 24)
SET IDENTITY_INSERT [dbo].[PhieuThuTien] OFF
/****** Object:  Table [dbo].[ChiTietPhieuNhapSach]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhapSach](
	[MaChiTietPhieuNhapSach] [int] IDENTITY(1,1) NOT NULL,
	[MaSach] [nvarchar](50) NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuNhapSach] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuNhapSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhapSach] ON
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaSach], [SoLuong]) VALUES (3, N'169', 200)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaSach], [SoLuong]) VALUES (9, N'125', 500)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaSach], [SoLuong]) VALUES (13, N'112', 200)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaSach], [SoLuong]) VALUES (14, N'113', 200)
INSERT [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach], [MaSach], [SoLuong]) VALUES (15, N'221', 150)
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhapSach] OFF
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaChiTietHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaSach] [nvarchar](50) NULL,
	[SoLuongBan] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaChiTietHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON
INSERT [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon], [MaSach], [SoLuongBan], [DonGia]) VALUES (27, N'221', 7, 30000)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
/****** Object:  Table [dbo].[BaoCaoTon]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCaoTon](
	[MaBaoCaoTon] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [nvarchar](50) NOT NULL,
	[MaSach] [nvarchar](50) NULL,
	[TonDau] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
	[TonCuoi] [int] NOT NULL,
 CONSTRAINT [PK_BaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoTon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapSach]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapSach](
	[MaPhieuNhapSach] [int] IDENTITY(1,1) NOT NULL,
	[MaChiTietPhieuNhapSach] [int] NULL,
	[NgayNhap] [nvarchar](50) NOT NULL,
	[TongSoLuongNhap] [int] NOT NULL,
 CONSTRAINT [PK_PhieuNhapSach] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhapSach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PhieuNhapSach] ON
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhapSach], [MaChiTietPhieuNhapSach], [NgayNhap], [TongSoLuongNhap]) VALUES (2, 13, N'Thu-10-1-2013', 200)
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhapSach], [MaChiTietPhieuNhapSach], [NgayNhap], [TongSoLuongNhap]) VALUES (3, 14, N'Sat-12-1-2013', 200)
INSERT [dbo].[PhieuNhapSach] ([MaPhieuNhapSach], [MaChiTietPhieuNhapSach], [NgayNhap], [TongSoLuongNhap]) VALUES (4, 15, N'Fri-11-1-2013', 150)
SET IDENTITY_INSERT [dbo].[PhieuNhapSach] OFF
/****** Object:  Table [dbo].[HoaDonBanSach]    Script Date: 01/18/2013 17:45:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBanSach](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayLapHoaDon] [nvarchar](50) NOT NULL,
	[MaKhachHang] [int] NULL,
	[MaChiTietHoaDon] [int] NULL,
	[TongTien] [int] NOT NULL,
 CONSTRAINT [PK_HoaDonBanSach] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HoaDonBanSach] ON
INSERT [dbo].[HoaDonBanSach] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang], [MaChiTietHoaDon], [TongTien]) VALUES (22, N'Sat-12-1-2013', 23, 27, 210000)
SET IDENTITY_INSERT [dbo].[HoaDonBanSach] OFF
/****** Object:  ForeignKey [FK_BaoCaoNoCong_KhachHang]    Script Date: 01/18/2013 17:45:26 ******/
ALTER TABLE [dbo].[BaoCaoNoCong]  WITH CHECK ADD  CONSTRAINT [FK_BaoCaoNoCong_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[BaoCaoNoCong] CHECK CONSTRAINT [FK_BaoCaoNoCong_KhachHang]
GO
/****** Object:  ForeignKey [FK_BaoCaoTon_Sach]    Script Date: 01/18/2013 17:45:26 ******/
ALTER TABLE [dbo].[BaoCaoTon]  WITH CHECK ADD  CONSTRAINT [FK_BaoCaoTon_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[BaoCaoTon] CHECK CONSTRAINT [FK_BaoCaoTon_Sach]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_Sach]    Script Date: 01/18/2013 17:45:26 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Sach]
GO
/****** Object:  ForeignKey [FK_ChiTietPhieuNhapSach_Sach]    Script Date: 01/18/2013 17:45:26 ******/
ALTER TABLE [dbo].[ChiTietPhieuNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapSach] CHECK CONSTRAINT [FK_ChiTietPhieuNhapSach_Sach]
GO
/****** Object:  ForeignKey [FK_HoaDonBanSach_ChiTietHoaDon]    Script Date: 01/18/2013 17:45:26 ******/
ALTER TABLE [dbo].[HoaDonBanSach]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanSach_ChiTietHoaDon] FOREIGN KEY([MaChiTietHoaDon])
REFERENCES [dbo].[ChiTietHoaDon] ([MaChiTietHoaDon])
GO
ALTER TABLE [dbo].[HoaDonBanSach] CHECK CONSTRAINT [FK_HoaDonBanSach_ChiTietHoaDon]
GO
/****** Object:  ForeignKey [FK_HoaDonBanSach_KhachHang]    Script Date: 01/18/2013 17:45:26 ******/
ALTER TABLE [dbo].[HoaDonBanSach]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBanSach_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[HoaDonBanSach] CHECK CONSTRAINT [FK_HoaDonBanSach_KhachHang]
GO
/****** Object:  ForeignKey [FK_PhieuNhapSach_ChiTietPhieuNhapSach]    Script Date: 01/18/2013 17:45:26 ******/
ALTER TABLE [dbo].[PhieuNhapSach]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapSach_ChiTietPhieuNhapSach] FOREIGN KEY([MaChiTietPhieuNhapSach])
REFERENCES [dbo].[ChiTietPhieuNhapSach] ([MaChiTietPhieuNhapSach])
GO
ALTER TABLE [dbo].[PhieuNhapSach] CHECK CONSTRAINT [FK_PhieuNhapSach_ChiTietPhieuNhapSach]
GO
/****** Object:  ForeignKey [FK_PhieuThuTien_KhachHang]    Script Date: 01/18/2013 17:45:26 ******/
ALTER TABLE [dbo].[PhieuThuTien]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThuTien_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PhieuThuTien] CHECK CONSTRAINT [FK_PhieuThuTien_KhachHang]
GO
/****** Object:  ForeignKey [FK_Sach_TheLoaiSach]    Script Date: 01/18/2013 17:45:26 ******/
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TheLoaiSach] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoaiSach] ([MaTheLoai])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TheLoaiSach]
GO

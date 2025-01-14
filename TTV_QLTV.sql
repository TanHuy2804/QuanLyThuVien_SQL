USE [TTN_QLTV]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[MaSinhVien] [varchar](50) NOT NULL,
	[MaMonHoc] [varchar](50) NOT NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC,
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDG] [nchar](10) NOT NULL,
	[TenDG] [nchar](50) NOT NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT_EMAIL] [nchar](50) NULL,
	[NgaySinh] [smalldatetime] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](50) NOT NULL,
	[TenKhoa] [nvarchar](100) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](50) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
	[MaKhoa] [varchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [varchar](50) NOT NULL,
	[TenMonHoc] [nvarchar](100) NULL,
 CONSTRAINT [PK_MonhHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nchar](20) NOT NULL,
	[TenNV] [nchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT_EMAIL] [varchar](50) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[Quyenhan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [nchar](10) NOT NULL,
	[TenNXB] [nchar](100) NOT NULL,
	[DiaChi] [nchar](100) NULL,
	[SDT_EMAIL] [nchar](20) NOT NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPM] [nchar](10) NOT NULL,
	[MaDG] [nchar](10) NOT NULL,
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[NgayMuon] [smalldatetime] NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QL_PHIEUMUON]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_PHIEUMUON](
	[MaPM] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[HanTra] [smalldatetime] NOT NULL,
	[SoLuongSM] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nchar](100) NOT NULL,
	[Gia] [bigint] NULL,
	[MaNXB] [nchar](10) NULL,
	[MaTL] [nchar](10) NULL,
	[SoLuong] [int] NULL,
	[SoTrang] [int] NULL,
	[SoSachHong] [int] NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSinhVien] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgaySinh] [datetime] NULL,
	[MaLop] [varchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTL] [nchar](10) NOT NULL,
	[TenTL] [nchar](100) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRASACH]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRASACH](
	[MaPM] [nchar](10) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[NgayTra] [smalldatetime] NOT NULL,
	[PhatQuaHan] [bigint] NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DSMUON]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE view [dbo].[DSMUON] AS SELECT DISTINCT dg.TenDG,s.TenSach,pm.NgayMuon,qlpm.HanTra,ts.PhatQuaHan from PHIEUMUON pm join QL_PHIEUMUON qlpm on pm.MaPM=qlpm.MaPM join DOCGIA dg on pm.MaDG=dg.MaDG join TRASACH ts on ts.MaPM=qlpm.MaPM join SACH s on s.MaSach=qlpm.MaSach  
GO
/****** Object:  View [dbo].[View_1]    Script Date: 18/12/2022 16:35:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT dbo.PHIEUMUON.MaPM, dbo.PHIEUMUON.MaDG, dbo.PHIEUMUON.TaiKhoan, dbo.PHIEUMUON.NgayMuon, dbo.QL_PHIEUMUON.MaSach, dbo.QL_PHIEUMUON.HanTra, dbo.QL_PHIEUMUON.SoLuongSM
FROM     dbo.PHIEUMUON INNER JOIN
                  dbo.QL_PHIEUMUON ON dbo.PHIEUMUON.MaPM = dbo.QL_PHIEUMUON.MaPM
GO
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG01      ', N'Nguyễn Ngọc Tuyết Ny                              ', N'Nữ        ', N'TP.HCM                                                                                              ', N'038393419                                         ', CAST(N'2002-03-04T00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG02      ', N'Nguyễn Thị Thảo Như                               ', N'Nữ        ', N'TP.HCM                                                                                              ', N'0357401715                                        ', CAST(N'2002-11-19T00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG03      ', N'Nguyễn Tấn Huy                                    ', N'Nam       ', N'TP.HCM                                                                                              ', N'0812992644                                        ', CAST(N'2002-07-13T00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG04      ', N'Mai Văn Thoa                                      ', N'Nam       ', N'TP.HCM                                                                                              ', N'0812933986                                        ', CAST(N'2002-11-27T00:00:00' AS SmallDateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [TenDG], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh]) VALUES (N'DG05      ', N'Hồ Mỹ Như                                         ', N'Nữ        ', N'TP.HCM                                                                                              ', N'0383953419                                        ', CAST(N'2002-11-27T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNSH', N'Sinh hoc')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTP', N'Cong nghe thuc pham')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT', N'Cong nghe thong tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'HH', N'Hoa Hoc')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'18CDTH1', N'18 cao dang tin hoc 1', N'CNTT')
GO
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'ADMIN', N'123456              ', N'Nguyễn Ngọc Tuyết Ny                              ', N'Nữ        ', N'Kiên Giang                                                                                          ', N'016788584', CAST(N'2002-06-29T00:00:00' AS SmallDateTime), N'admin')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'Hieu123', N'123456              ', N'Hồ Mỹ Như                                         ', N'Nữ        ', N'TP.HCM                                                                                              ', N'08283828', CAST(N'2002-11-27T00:00:00' AS SmallDateTime), N'user')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'NV01', N'123456              ', N'Trần Quỳnh Như                                    ', N'Nữ        ', N'TP.HCM                                                                                              ', N'1234667', CAST(N'2002-11-29T00:00:00' AS SmallDateTime), N'user')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'NV02', N'1234                ', N'Nguyễn Thị Thảo Như                               ', N'Nữ        ', N'TP.HCM                                                                                              ', N'012225548', CAST(N'2002-12-19T00:00:00' AS SmallDateTime), N'user')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'NV03', N'123                 ', N'Nguyễn Hoàng Vĩnh Phước                           ', N'Nam       ', N'TP.HCM                                                                                              ', N'0111111111', CAST(N'1997-12-24T00:00:00' AS SmallDateTime), N'user')
INSERT [dbo].[NHANVIEN] ([TaiKhoan], [MatKhau], [TenNV], [GioiTinh], [DiaChi], [SDT_EMAIL], [NgaySinh], [Quyenhan]) VALUES (N'NV04', N'hoango              ', N'Hồ Yến Nhi                                        ', N'Nữ        ', N'TP.HCM                                                                                              ', N'0199438', CAST(N'2002-12-03T00:00:00' AS SmallDateTime), N'user')
GO
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT_EMAIL]) VALUES (N'NXB001    ', N'Gstar                                                                                               ', N'TP HCM                                                                                              ', N'011111245664        ')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT_EMAIL]) VALUES (N'NXB002    ', N'Tiền Phong                                                                                          ', N'Hà Nội                                                                                              ', N'011111245664        ')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChi], [SDT_EMAIL]) VALUES (N'NXB004    ', N'Nhã Nam                                                                                             ', N'Hà Nội                                                                                              ', N'01678265701         ')
GO
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [TaiKhoan], [NgayMuon]) VALUES (N'PM001     ', N'DG04      ', N'NV01', CAST(N'2022-11-14T00:00:00' AS SmallDateTime))
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [TaiKhoan], [NgayMuon]) VALUES (N'PM003     ', N'DG01      ', N'NV02', CAST(N'2022-11-13T00:00:00' AS SmallDateTime))
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDG], [TaiKhoan], [NgayMuon]) VALUES (N'PM009     ', N'DG04      ', N'NV03', CAST(N'2022-11-17T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM001     ', N'S005      ', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 3)
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM001     ', N'S002      ', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 4)
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM003     ', N'S005      ', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 4)
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM003     ', N'S007      ', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 4)
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM003     ', N'S006      ', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 1)
INSERT [dbo].[QL_PHIEUMUON] ([MaPM], [MaSach], [HanTra], [SoLuongSM]) VALUES (N'PM001     ', N'S003      ', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 3)
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S002      ', N'Công nghệ phần miềm                                                                                 ', 78000, N'NXB002    ', N'TL01      ', 76, 324, 2)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S003      ', N'Toán đại cương                                                                                      ', 45000, N'NXB001    ', N'TL02      ', 46, 350, 3)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S004      ', N'Toán đại cương                                                                                      ', 45000, N'NXB001    ', N'TL02      ', 37, 200, 0)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S005      ', N'Vật Lý đại cương                                                                                    ', 50000, N'NXB001    ', N'TL01      ', 30, 258, 2)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S006      ', N'Cấu trúc dữ liệu                                                                                    ', 680000, N'NXB001    ', N'TL01      ', 45, 234, 2)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [Gia], [MaNXB], [MaTL], [SoLuong], [SoTrang], [SoSachHong]) VALUES (N'S007      ', N'Bạch dạ hành                                                                                        ', 392944, NULL, N'TL02      ', 45, 324, 2)
GO
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL01      ', N'Công nghệ thông tin                                                                                 ')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL02      ', N'Trinh Thám                                                                                          ')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL]) VALUES (N'TL03      ', N'Tạp chí                                                                                             ')
GO
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM003     ', N'S007      ', N'NV02', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM001     ', N'S006      ', N'NV01', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM001     ', N'S002      ', N'NV01', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM003     ', N'S005      ', N'NV02', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM003     ', N'S006      ', N'NV02', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 0)
INSERT [dbo].[TRASACH] ([MaPM], [MaSach], [TaiKhoan], [NgayTra], [PhatQuaHan]) VALUES (N'PM001     ', N'S003      ', N'NV01', CAST(N'2022-12-03T00:00:00' AS SmallDateTime), 0)
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SinhVien]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_DOCGIA] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DOCGIA] ([MaDG])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_TAIKHOAN] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[NHANVIEN] ([TaiKhoan])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_TAIKHOAN]
GO
ALTER TABLE [dbo].[QL_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_QLPHIEUMUON_PHIEUMUON] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[QL_PHIEUMUON] CHECK CONSTRAINT [FK_QLPHIEUMUON_PHIEUMUON]
GO
ALTER TABLE [dbo].[QL_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_QLPHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[QL_PHIEUMUON] CHECK CONSTRAINT [FK_QLPHIEUMUON_SACH]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NXB]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_TK] FOREIGN KEY([MaTL])
REFERENCES [dbo].[THELOAI] ([MaTL])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_TK]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_PHIEUMUON] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_PHIEUMUON]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_SACH]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_TAIKHOAN] FOREIGN KEY([TaiKhoan])
REFERENCES [dbo].[NHANVIEN] ([TaiKhoan])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_TAIKHOAN]
GO
/****** Object:  StoredProcedure [dbo].[DEL_NXB]    Script Date: 18/12/2022 16:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DEL_NXB] @manxb nchar(10)
AS
BEGIN
  UPDATE dbo.SACH SET MaNXB=NULL WHERE MaNXB=@manxb
  DELETE FROM dbo.NXB WHERE MaNXB=@manxb
END
GO
/****** Object:  StoredProcedure [dbo].[DEL_Theloai]    Script Date: 18/12/2022 16:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DEL_Theloai] @matl nchar(10)
AS
BEGIN
  UPDATE dbo.SACH SET MaTL=NULL WHERE MaTL=@matl
  DELETE FROM dbo.THELOAI WHERE MaTL=@matl
END 
GO
/****** Object:  StoredProcedure [dbo].[DSSachmuon]    Script Date: 18/12/2022 16:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSSachmuon] @MaDocGia CHAR(10)
AS
begin
SELECT ql.MaSach, ql.SoLuongSM AS SL
FROM QL_PHIEUMUON ql,dbo.PHIEUMUON pm
WHERE pm.MaPM=ql.MaPM AND  MaDG= @MaDocGia
GROUP BY ql.MaSach ,ql.SoLuongSM
end
GO
/****** Object:  StoredProcedure [dbo].[TONGSACHMUON]    Script Date: 18/12/2022 16:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TONGSACHMUON] @MASACH CHAR(10)
AS
SELECT MASACH, COUNT(SOLUONGSM) SLSM
FROM QL_PHIEUMUON
WHERE MASACH= @MASACH
GROUP BY MaSach
GO
/****** Object:  StoredProcedure [dbo].[TONGSOSM]    Script Date: 18/12/2022 16:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[TONGSOSM] @MASACH CHAR(10)
AS
SELECT MASACH, COUNT(SOLUONGSM) SL
FROM QL_PHIEUMUON
WHERE MASACH= @MASACH
GROUP BY MaSach
GO
/****** Object:  StoredProcedure [dbo].[TONGSSM]    Script Date: 18/12/2022 16:35:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[TONGSSM] @MASACH CHAR(10)
AS
SELECT MASACH, SUM(SOLUONGSM) SL
FROM QL_PHIEUMUON
WHERE MASACH=@MASACH
GROUP BY MaSach
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PHIEUMUON_1"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "QL_PHIEUMUON"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO

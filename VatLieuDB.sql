USE [VatLieuDB]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteDanhMucHang]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteDanhMucHang]
	(
		@DanhMucHangID numeric(18, 0)
		
)
 AS
BEGIN
	delete from tblDanhMucHang where DanhMucHangID = @DanhMucHangID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteDonViTinh]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteDonViTinh]
(
	@DonViTinhID numeric(18,0) 
)
AS
BEGIN
	delete from tblDonViTinh   where DonViTinhID=@DonViTinhID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteDVTGia]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteDVTGia] (
	@DonViTinhGiaID numeric(18, 0) 
) AS
BEGIN
	delete from tblDonViTinhGia  where DonViTinhGiaID=@DonViTinhGiaID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteGia]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_DeleteGia]
(
	@SanPhamID numeric(18, 0) 
)
AS
BEGIN
	delete from tblGia where  SanPhamID=@SanPhamID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteKhuVuc]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_DeleteKhuVuc] (@ID numeric(18,0))
AS
BEGIN
delete from tblkhuvuc where khuvucid = @ID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteLoaiHang]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteLoaiHang] (
	@LoaiHangID numeric(18,0) 
) AS
BEGIN
	delete from tblLoaiHang	where LoaiHangID=@LoaiHangID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteNguoiDung]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_DeleteNguoiDung]
(
	@TaiKhoan nvarchar(250)
) AS
BEGIN
delete from tblnguoidung where TaiKhoan = @TaiKhoan
END


GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteSanPham]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DeleteSanPham]
	(
		@SanPhamID numeric(18, 0) 
)
AS
BEGIN
	delete from tblSanPham
where SanPhamID=@SanPhamID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_GetAllKhuVuc]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[SP_GetAllKhuVuc]
AS
BEGIN
	select * from tblkhuvuc
END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDanhMucHang]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertDanhMucHang]
	(
		
		@TenHang nvarchar(250)
)
 AS
BEGIN
	insert into tblDanhMucHang values(@TenHang)
END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDonViTinh]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertDonViTinh]
(
	
	@TenDonViTinh nvarchar(250)
)
AS
BEGIN
	insert into tblDonViTinh values (@TenDonViTinh)
END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDVTGia]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertDVTGia] (
	@LoaiTienTe nvarchar(250)
) AS
BEGIN
	insert into tblDonViTinhGia values (@LoaiTienTe)
END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertGia]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_InsertGia]
(
	@NguonGia nvarchar(250),
	@Gia money,
	@ThoiDiem datetime,
	@SanPhamID numeric(18, 0),
	@DonViTinhGiaID numeric(18, 0),
	@VAT bit
)
AS
BEGIN
	insert into tblGia values (@NguonGia,@Gia,@ThoiDiem,@SanPhamID,@DonViTinhGiaID,@VAT)
END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertKhuVuc]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertKhuVuc]
(
	@Name nvarchar(250)
)
as insert into tblkhuvuc values(@Name);


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertLoaiHang]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertLoaiHang] (
	@TenLoaiHang nvarchar(250),
	@DanhMucHangID numeric(18,0)
) AS
BEGIN
	insert into tblLoaiHang values(@TenLoaiHang,@DanhMucHangID)
END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertNguoiDung]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[SP_InsertNguoiDung]
(
	@TaiKhoan nvarchar(250),
	@MatKhau nvarchar(250),
	@HoTen	nvarchar(250),
	@Email nvarchar(250),
	@SoDienThoai nvarchar(250),
	@QuyenHan nvarchar(250)
)
AS
BEGIN
	insert into tblnguoidung values(@TaiKhoan,@MatKhau,@HoTen,@Email,@SoDienThoai,@QuyenHan)
END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertSanPham]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertSanPham]
	(
		
		@KhuVucID numeric(18, 0),
		@DonViTinhID numeric(18, 0),
		@LoaiHangID	numeric(18, 0),
		@HangSanXuat nvarchar(MAX),
		@Model	nvarchar(MAX),
		@DiemGiaoHang	nvarchar(MAX),
		@ThongSoKhac	nvarchar(MAX),
		@SanPhamID numeric(18, 0) output
)
AS
BEGIN
	insert into tblSanPham values(@KhuVucID ,@DonViTinhID ,@LoaiHangID,	@HangSanXuat ,	@Model	,	@DiemGiaoHang	,	@ThongSoKhac)
	set @SanPhamID = SCOPE_IDENTITY()
	 
END


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateDanhMucHang]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateDanhMucHang]
	(
		@DanhMucHangID numeric(18, 0),
		@TenHang nvarchar(250)
)
 AS
BEGIN
	update tblDanhMucHang set TenHang = @TenHang where DanhMucHangID = @DanhMucHangID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateDonViTinh]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateDonViTinh]
(
	@DonViTinhID numeric(18,0),
	@TenDonViTinh nvarchar(250)
)
AS
BEGIN
	update tblDonViTinh set TenDonViTinh = @TenDonViTinh where DonViTinhID=@DonViTinhID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateDVTGia]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateDVTGia] (
	@DonViTinhGiaID numeric(18, 0),
	@LoaiTienTe nvarchar(250)
) AS
BEGIN
	update tblDonViTinhGia set LoaiTienTe=@LoaiTienTe where DonViTinhGiaID=@DonViTinhGiaID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateGia]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_UpdateGia]
(
	@GiaID numeric(18, 0),
	@NguonGia nvarchar(250),
	@Gia money,
	@ThoiDiem datetime,
	@SanPhamID numeric(18, 0),
	@DonViTinhGiaID numeric(18, 0),
	@VAT bit
)
AS
BEGIN
	update tblGia set NguonGia=@NguonGia,Gia=@Gia,ThoiDiem=@ThoiDiem,SanPhamID=@SanPhamID,DonViTinhGiaID=@DonViTinhGiaID,VAT=@VAT where  GiaID=@GiaID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateKhuVuc]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UpdateKhuVuc] 
(
	@ID numeric(18,0),
	@Name nvarchar(250)
)

AS
BEGIN
	update tblkhuvuc set TenKhuVuc = @Name where KhuVucID = @ID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateLoaiHang]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateLoaiHang] (
	@LoaiHangID numeric(18,0),
	@TenLoaiHang nvarchar(250),
	@DanhMucHangID numeric(18,0)
) AS
BEGIN
	update tblLoaiHang set TenLoaiHang = @TenLoaiHang , DanhMucHangID=@DanhMucHangID
						where LoaiHangID=@LoaiHangID
END


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateNguoiDung]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UpdateNguoiDung]
(
	@TaiKhoan nvarchar(250),
	@MatKhau nvarchar(250),
	@HoTen	nvarchar(250),
	@Email nvarchar(250),
	@SoDienThoai nvarchar(250),
	@QuyenHan nvarchar(250)
) AS
BEGIN
	update tblnguoidung 
	set MatKhau = @MatKhau,
		HoTen = @Hoten,
		Email = @Email,
		SoDienThoai = @SoDienThoai,
		QuyenHan = @QuyenHan
	where TaiKhoan = @TaiKhoan
	
END


GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateSanPham]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpdateSanPham]
	(
		@SanPhamID numeric(18, 0),
		@KhuVucID numeric(18, 0),
		@DonViTinhID numeric(18, 0),
		@LoaiHangID	numeric(18, 0),
		@HangSanXuat nvarchar(MAX),
		@Model	nvarchar(MAX),
		@DiemGiaoHang	nvarchar(MAX),
		@ThongSoKhac	nvarchar(MAX)
)
AS
BEGIN
	update tblSanPham
	 set 
KhuVucID=@KhuVucID ,
DonViTinhID=@DonViTinhID ,
LoaiHangID=@LoaiHangID,	
HangSanXuat =@HangSanXuat ,
		Model	=@Model	,
DiemGiaoHang	=	@DiemGiaoHang	,
		ThongSoKhac=@ThongSoKhac
where SanPhamID=@SanPhamID
END


GO
/****** Object:  Table [dbo].[tblDanhMucHang]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDanhMucHang](
	[DanhMucHangID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[TenHang] [nvarchar](250) NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[DanhMucHangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDonViTinh]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDonViTinh](
	[DonViTinhID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[TenDonViTinh] [nvarchar](250) NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[DonViTinhID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDonViTinhGia]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDonViTinhGia](
	[DonViTinhGiaID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[LoaiTienTe] [nvarchar](250) NULL,
 CONSTRAINT [PK_tblDonViTinhGia] PRIMARY KEY CLUSTERED 
(
	[DonViTinhGiaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblGia]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGia](
	[GiaID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NguonGia] [nvarchar](250) NULL,
	[Gia] [money] NULL,
	[ThoiDiem] [datetime] NULL,
	[SanPhamID] [numeric](18, 0) NULL,
	[DonViTinhGiaID] [numeric](18, 0) NULL,
	[VAT] [bit] NULL,
 CONSTRAINT [PK_tblGia] PRIMARY KEY CLUSTERED 
(
	[GiaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKhuVuc]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhuVuc](
	[KhuVucID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[TenKhuVuc] [nvarchar](250) NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[KhuVucID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLoaiHang]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiHang](
	[LoaiHangID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[TenLoaiHang] [nvarchar](250) NULL,
	[DanhMucHangID] [numeric](18, 0) NULL,
 CONSTRAINT [PK_LoaiHang_1] PRIMARY KEY CLUSTERED 
(
	[LoaiHangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNguoiDung]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNguoiDung](
	[TaiKhoan] [nvarchar](250) NOT NULL,
	[MatKhau] [nvarchar](250) NULL,
	[HoTen] [nvarchar](250) NULL,
	[Email] [nvarchar](250) NULL,
	[SoDienThoai] [nvarchar](250) NULL,
	[QuyenHan] [nvarchar](250) NULL,
 CONSTRAINT [PK_tblNguoiDung] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSanPham]    Script Date: 09/12/2022 4:41:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSanPham](
	[SanPhamID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[KhuVucID] [numeric](18, 0) NULL,
	[DonViTinhID] [numeric](18, 0) NULL,
	[LoaiHangID] [numeric](18, 0) NULL,
	[HangSanXuat] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[DiemGiaoHang] [nvarchar](max) NULL,
	[ThongSoKhac] [nvarchar](max) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[SanPhamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblDanhMucHang] ON 

INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(1 AS Numeric(18, 0)), N'Xăng')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(2 AS Numeric(18, 0)), N'Dầu')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(3 AS Numeric(18, 0)), N'Sắt Thép')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(4 AS Numeric(18, 0)), N'Nhựa đường')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(5 AS Numeric(18, 0)), N'Bê Tông Nhựa Nóng')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(6 AS Numeric(18, 0)), N'Bê Tông Tươi')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(7 AS Numeric(18, 0)), N'Xi Măng')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(8 AS Numeric(18, 0)), N'Cát')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(9 AS Numeric(18, 0)), N'Đá')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(10 AS Numeric(18, 0)), N'Sỏi')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(11 AS Numeric(18, 0)), N'Đất')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(12 AS Numeric(18, 0)), N'Bột Khoáng')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(13 AS Numeric(18, 0)), N'Gạch Ngói,đá Grantie')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(14 AS Numeric(18, 0)), N'Dây điện cáp điện')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(15 AS Numeric(18, 0)), N'Gỗ cốp pha gỗ')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(16 AS Numeric(18, 0)), N'Cửa gỗ')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(17 AS Numeric(18, 0)), N'Kính')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(18 AS Numeric(18, 0)), N'Ống cống ly tâm')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(19 AS Numeric(18, 0)), N'Cọc bê tông cốt thép')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(20 AS Numeric(18, 0)), N'Trụ bê tông ly tâm')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(21 AS Numeric(18, 0)), N'Trụ đèn')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(22 AS Numeric(18, 0)), N'Tôn')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(23 AS Numeric(18, 0)), N'Vải địa kỹ thuật')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(24 AS Numeric(18, 0)), N'Rọ đá')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(25 AS Numeric(18, 0)), N'Máy biến áp')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(26 AS Numeric(18, 0)), N'Ống nhựa')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(27 AS Numeric(18, 0)), N'Trụ đèn tín hiệu giao')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(38 AS Numeric(18, 0)), N'Đèn Led Tín Hiệu')
INSERT [dbo].[tblDanhMucHang] ([DanhMucHangID], [TenHang]) VALUES (CAST(39 AS Numeric(18, 0)), N'Sắt')
SET IDENTITY_INSERT [dbo].[tblDanhMucHang] OFF
SET IDENTITY_INSERT [dbo].[tblDonViTinh] ON 

INSERT [dbo].[tblDonViTinh] ([DonViTinhID], [TenDonViTinh]) VALUES (CAST(1 AS Numeric(18, 0)), N'Lit')
INSERT [dbo].[tblDonViTinh] ([DonViTinhID], [TenDonViTinh]) VALUES (CAST(2 AS Numeric(18, 0)), N'Kg')
INSERT [dbo].[tblDonViTinh] ([DonViTinhID], [TenDonViTinh]) VALUES (CAST(3 AS Numeric(18, 0)), N'Ha')
INSERT [dbo].[tblDonViTinh] ([DonViTinhID], [TenDonViTinh]) VALUES (CAST(4 AS Numeric(18, 0)), N'M2')
INSERT [dbo].[tblDonViTinh] ([DonViTinhID], [TenDonViTinh]) VALUES (CAST(9 AS Numeric(18, 0)), N'jjjjj')
INSERT [dbo].[tblDonViTinh] ([DonViTinhID], [TenDonViTinh]) VALUES (CAST(11 AS Numeric(18, 0)), N'tttttt')
SET IDENTITY_INSERT [dbo].[tblDonViTinh] OFF
SET IDENTITY_INSERT [dbo].[tblDonViTinhGia] ON 

INSERT [dbo].[tblDonViTinhGia] ([DonViTinhGiaID], [LoaiTienTe]) VALUES (CAST(1 AS Numeric(18, 0)), N'VNĐ')
INSERT [dbo].[tblDonViTinhGia] ([DonViTinhGiaID], [LoaiTienTe]) VALUES (CAST(2 AS Numeric(18, 0)), N'EUR')
INSERT [dbo].[tblDonViTinhGia] ([DonViTinhGiaID], [LoaiTienTe]) VALUES (CAST(3 AS Numeric(18, 0)), N'AUD')
INSERT [dbo].[tblDonViTinhGia] ([DonViTinhGiaID], [LoaiTienTe]) VALUES (CAST(4 AS Numeric(18, 0)), N'USD')
INSERT [dbo].[tblDonViTinhGia] ([DonViTinhGiaID], [LoaiTienTe]) VALUES (CAST(5 AS Numeric(18, 0)), N'rub')
SET IDENTITY_INSERT [dbo].[tblDonViTinhGia] OFF
SET IDENTITY_INSERT [dbo].[tblGia] ON 

INSERT [dbo].[tblGia] ([GiaID], [NguonGia], [Gia], [ThoiDiem], [SanPhamID], [DonViTinhGiaID], [VAT]) VALUES (CAST(2 AS Numeric(18, 0)), N'Công Ty CP A', 20000.0000, CAST(N'2013-01-10 00:00:00.000' AS DateTime), CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), 1)
INSERT [dbo].[tblGia] ([GiaID], [NguonGia], [Gia], [ThoiDiem], [SanPhamID], [DonViTinhGiaID], [VAT]) VALUES (CAST(3 AS Numeric(18, 0)), N'Công Ty CP B', 22000.0000, CAST(N'2013-01-10 00:00:00.000' AS DateTime), CAST(2 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), 1)
INSERT [dbo].[tblGia] ([GiaID], [NguonGia], [Gia], [ThoiDiem], [SanPhamID], [DonViTinhGiaID], [VAT]) VALUES (CAST(4 AS Numeric(18, 0)), N'SIVC', 21000.0000, CAST(N'2013-01-10 00:00:00.000' AS DateTime), CAST(3 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[tblGia] OFF
SET IDENTITY_INSERT [dbo].[tblKhuVuc] ON 

INSERT [dbo].[tblKhuVuc] ([KhuVucID], [TenKhuVuc]) VALUES (CAST(1 AS Numeric(18, 0)), N'TP Hồ Chí Minh')
INSERT [dbo].[tblKhuVuc] ([KhuVucID], [TenKhuVuc]) VALUES (CAST(2 AS Numeric(18, 0)), N'Đà Nẵng')
INSERT [dbo].[tblKhuVuc] ([KhuVucID], [TenKhuVuc]) VALUES (CAST(3 AS Numeric(18, 0)), N'Hà Nội')
INSERT [dbo].[tblKhuVuc] ([KhuVucID], [TenKhuVuc]) VALUES (CAST(7 AS Numeric(18, 0)), N'Hải Phòng')
SET IDENTITY_INSERT [dbo].[tblKhuVuc] OFF
SET IDENTITY_INSERT [dbo].[tblLoaiHang] ON 

INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(1 AS Numeric(18, 0)), N'Ron 83', CAST(16 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(2 AS Numeric(18, 0)), N'Ron 92', CAST(17 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(3 AS Numeric(18, 0)), N'Ron 95', CAST(18 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(4 AS Numeric(18, 0)), N'Diesel DO', CAST(19 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(5 AS Numeric(18, 0)), N'Dầu hỏa', CAST(20 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(6 AS Numeric(18, 0)), N'mazut FO', CAST(21 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(7 AS Numeric(18, 0)), N'Sắt Thép 1', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(8 AS Numeric(18, 0)), N'Nhựa đường', CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(9 AS Numeric(18, 0)), N'Bê Tông nhựa nóng 1', CAST(3 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(10 AS Numeric(18, 0)), N'Đèn cỡ lớn', CAST(4 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(11 AS Numeric(18, 0)), N'Cát Trắng 1', CAST(5 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(15 AS Numeric(18, 0)), N'Bê Tông Tươi Loại I', CAST(12 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(17 AS Numeric(18, 0)), N'Thép II', CAST(13 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(19 AS Numeric(18, 0)), N'Rọ Đá Loại I', CAST(14 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(20 AS Numeric(18, 0)), N'Cửa gỗ loại nhất', CAST(15 AS Numeric(18, 0)))
INSERT [dbo].[tblLoaiHang] ([LoaiHangID], [TenLoaiHang], [DanhMucHangID]) VALUES (CAST(21 AS Numeric(18, 0)), N'11111111', CAST(1 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[tblLoaiHang] OFF
INSERT [dbo].[tblNguoiDung] ([TaiKhoan], [MatKhau], [HoTen], [Email], [SoDienThoai], [QuyenHan]) VALUES (N'admin', N'123', N'aaa', N'111111@gmail.com', N'111111111', N'Admin')
INSERT [dbo].[tblNguoiDung] ([TaiKhoan], [MatKhau], [HoTen], [Email], [SoDienThoai], [QuyenHan]) VALUES (N'khach', N'123', N'ddddd', N'hoanganh555@hotmail.com', N'111111111', N'Khach')
INSERT [dbo].[tblNguoiDung] ([TaiKhoan], [MatKhau], [HoTen], [Email], [SoDienThoai], [QuyenHan]) VALUES (N'nhaplieu', N'123', N'vvv', N'111111@gmail.com', N'111111111', N'NhapLieu')
SET IDENTITY_INSERT [dbo].[tblSanPham] ON 

INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), N'Công Ty VLXD A', N'Model 1', N'22/13 Nguyễn Trãi P10 Q5 TPHCM', N'Thông số 1')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'Công Ty VLXD B', N'Model 1', N'557 Trần Hưng đạo P9 Q10 TPHCM', N'Thông số 2')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(15 AS Numeric(18, 0)), N'Công Ty VLXD C', N'Model 1', N'123 Lý Chính Thắng P11 Q3 TPHCM', N'Thông số 3')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(4 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'Công Ty VLXD D', N'Model 3', N'123 Lý Chính Thắng P11 Q3 TPHCM', N'Thông số 3')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(5 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'Công Ty VLXD E', N'Model 1', N'22/13 Nguyễn Trãi P10 Q5 TPHCM', N'Thông số 1')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(6 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'Công Ty VLXD F', N'Model 2', N'557 Trần Hưng đạo P9 Q10 TPHCM', N'Thông Số 2')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(7 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(19 AS Numeric(18, 0)), N'Cty TNHH A', N'mẫu mới', N'Hà nội', N'mô tả chi tiết rọ đá')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(25 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'', N'', N'', N'')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(26 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'', N'', N'', N'')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(27 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'1', N'1', N'1', N'1')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(28 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'1', N'1', N'1', N'1')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(29 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'1', N'1', N'1', N'1')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'1', N'1', N'1', N'1')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(31 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(11 AS Numeric(18, 0)), N'1', N'1', N'1', N'1')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(32 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'1', N'1', N'1', N'1')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(33 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'1', N'11', N'1', N'1')
INSERT [dbo].[tblSanPham] ([SanPhamID], [KhuVucID], [DonViTinhID], [LoaiHangID], [HangSanXuat], [Model], [DiemGiaoHang], [ThongSoKhac]) VALUES (CAST(34 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'1', N'22', N'2', N'2')
SET IDENTITY_INSERT [dbo].[tblSanPham] OFF
ALTER TABLE [dbo].[tblGia]  WITH CHECK ADD  CONSTRAINT [FK_tblGia_tblDonViTinhGia] FOREIGN KEY([DonViTinhGiaID])
REFERENCES [dbo].[tblDonViTinhGia] ([DonViTinhGiaID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblGia] CHECK CONSTRAINT [FK_tblGia_tblDonViTinhGia]
GO
ALTER TABLE [dbo].[tblGia]  WITH CHECK ADD  CONSTRAINT [FK_tblGia_tblSanPham] FOREIGN KEY([SanPhamID])
REFERENCES [dbo].[tblSanPham] ([SanPhamID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblGia] CHECK CONSTRAINT [FK_tblGia_tblSanPham]
GO
ALTER TABLE [dbo].[tblLoaiHang]  WITH CHECK ADD  CONSTRAINT [FK_tblLoaiHang_tblDanhMucHang] FOREIGN KEY([DanhMucHangID])
REFERENCES [dbo].[tblDanhMucHang] ([DanhMucHangID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblLoaiHang] CHECK CONSTRAINT [FK_tblLoaiHang_tblDanhMucHang]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblDonViTinh] FOREIGN KEY([DonViTinhID])
REFERENCES [dbo].[tblDonViTinh] ([DonViTinhID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblDonViTinh]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblKhuVuc] FOREIGN KEY([KhuVucID])
REFERENCES [dbo].[tblKhuVuc] ([KhuVucID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblKhuVuc]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblLoaiHang] FOREIGN KEY([LoaiHangID])
REFERENCES [dbo].[tblLoaiHang] ([LoaiHangID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblLoaiHang]
GO

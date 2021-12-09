CREATE DATABASE [ThuVienCaNhan1]
GO

USE [ThuVienCaNhan1]
GO


SET ANSI_NULLS ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TheLoai](
	[MaTL] [int] IDENTITY(1,1) NOT NULL,
	[TenTL] [nvarchar](200) NOT NULL
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO

SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](200) NOT NULL,
	[NamXB] [nvarchar](10),
	[TacGia] [nvarchar](100) NOT NULL,
	[NXB] [nvarchar](100), 
	[TrangThai] [bit],
	[KeSach] [int] NOT NULL,
	[VTNgan] [int] NOT NULL,
	[MaTL] [int] NOT NULL,
	[Hinh] [nvarchar](1000)
	
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO

SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BanDoc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](1000),
	[DiaChi] [nvarchar](1000),
	[SDT] [nvarchar](100),
 CONSTRAINT [PK_BanDoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO

SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MuonTra](
	[ID] [int] NOT NULL,
	[MaSach] int NOT NULL,
	[NgayMuon] [smalldatetime],
	[NgayTra] [smalldatetime],
 CONSTRAINT [PK_MuonTra] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Theloai] ON
INSERT [dbo].[TheLoai] ([MaTL],[TenTL]) VALUES (1,N'Chính trị')
INSERT [dbo].[TheLoai] ([MaTL],[TenTL]) VALUES (2,N'Pháp luật')
INSERT [dbo].[TheLoai] ([MaTL],[TenTL]) VALUES (3,N'Văn học')
INSERT [dbo].[TheLoai] ([MaTL],[TenTL]) VALUES (4,N'Tiểu thuyết')
INSERT [dbo].[TheLoai] ([MaTL],[TenTL]) VALUES (5,N'Tâm lý')
INSERT [dbo].[TheLoai] ([MaTL],[TenTL]) VALUES (6,N'Thiếu nhi')
INSERT [dbo].[TheLoai] ([MaTL],[TenTL]) VALUES (7,N'Khoa học')
INSERT [dbo].[TheLoai] ([MaTL],[TenTL]) VALUES (8,N'Tôn giáo')
INSERT [dbo].[TheLoai] ([MaTL],[TenTL]) VALUES (9,N'Công nghệ')
------------------
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
SET IDENTITY_INSERT [dbo].[Sach] ON

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('1',N'Chính trị luận',2000,N'Aritotle',N'NXB Nông Duy Trường',0,1,2,1,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('2',N'Đất nước nhỏ, nền chính trị lớn',1999,N'Karava',N'NXB Chính trị quốc gia',0,2,1,1,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('3',N'Bố già',2005,N'Mario Puzo',N'NXB Trẻ',0,1,1,3,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('4',N'Tuổi thơ dữ dội',1968,N'Phùng Quán',N'NXB Nhi Đồng',1,1,1,3,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('5',N'Tiếng chim hót trong bụi mận gai',1968,N'J.R.R.Tolkien',N'NXB Nhi Đồng',1,1,1,3,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('6',N'Không gia đình',1968,N'Hector Malot',N'NXB Trẻ',0,1,1,3,NULL)
-------------------
SET IDENTITY_INSERT [dbo].[Sach] OFF
SET IDENTITY_INSERT [dbo].[BanDoc] ON
INSERT [dbo].[BanDoc] ([ID],[Ten],[DiaChi],[SDT]) VALUES (1,N'Phạm Hoàng Châu Kiến',N'123 Hồ Tùng Mậu',N'0917391111')
INSERT [dbo].[BanDoc] ([ID],[Ten],[DiaChi],[SDT]) VALUES (2,N'Ngọc Miên Nhi',N'12 Hồ Tùng Mậu',N'0917391441')
-------------------

INSERT [dbo].[MuonTra] ([ID],[MaSach],[NgayMuon],[NgayTra]) VALUES (1,4,'2020-2-12',NULL)
INSERT [dbo].[MuonTra] ([ID],[MaSach],[NgayMuon],[NgayTra]) VALUES (2,5,'2020-2-12','2020-2-15')

----------------------
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_TL] FOREIGN KEY([MaTL])
REFERENCES [dbo].[TheLoai] ([MaTL])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_TL]
GO

ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD  CONSTRAINT [FK_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[MuonTra] CHECK CONSTRAINT [FK_Sach]
GO


ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD  CONSTRAINT [FK_BanDoc] FOREIGN KEY([ID])
REFERENCES [dbo].[BanDoc] ([ID])
GO
ALTER TABLE [dbo].[MuonTra] CHECK CONSTRAINT [FK_BanDoc]
GO

SELECT * FROM TheLoai
SELECT * FROM Sach
SELECT * FROM BanDoc
SELECT * FROM MuonTra
go
CREATE PROCEDURE [dbo].[TK_TheLoai]
AS
SELECT t.MaTL as N'Mã thể loại',TenTL as N'Tên thể loại',count(s.MaSach)as N'Tổng sách',COUNT(m.MaSach) as N'Số lượt mượn'
FROM TheLoai t, Sach s,MuonTra m
WHERE t.MaTL = s.MaTL AND s.MaSach = m.MaSach
GROUP BY t.MaTL, TenTl

go
CREATE PROCEDURE [dbo].[TK_TacGia]
AS
SELECT TacGia as N'Tác giả', COUNT(s.MaSach) as N'Tổng sách', COUNT(s.MaSach) as N'Số lượt mượn'
FROM Sach s, MuonTra m
where s.MaSach = m.MaSach
GROUP BY TacGia

EXECUTE TK_TacGia

go
CREATE PROCEDURE [dbo].[TK_SachMuon]
AS
SELECT s.MaSach as N'Mã sách',s.TenSach as N'Tên sách',NamXB as N'Năm xuất bản',TacGia as N'Tác giả',NXB as N'Nhà xuất bản',b.Ten as N'Tên bạn đọc',b.SDT as N'Số điện thoại',b.DiaChi as N'Địa chỉ',m.NgayMuon as N'Ngày mượn',m.NgayTra as N'Ngày trả'
FROM Sach s, MuonTra m, BanDoc b
WHERE s.MaSach = m.MaSach and m.ID = b.ID and m.NgayTra is null
GROUP BY s.MaSach,s.TenSach,NamXB,TacGia,NXB,b.Ten,b.SDT,b.DiaChi,m.NgayMuon,m.NgayTra

go
CREATE PROCEDURE [dbo].[TK_ThoiGian]
AS
SELECT m.NgayMuon as N'Ngày mượn',m.NgayTra as N'Ngày trả',b.Ten as N'Tên bạn đọc',s.TenSach as N'Tên sách'
FROM MuonTra m, BanDoc b, Sach s
WHERE m.ID = b.ID and m.MaSach = s.MaSach
go
Create Procedure [dbo].[Category_GetAll]
as
Select * from TheLoai

go
Create Procedure [dbo].[Book_GetAll]
as
Select * from Sach
go
Create PROCEDURE [dbo].[Book_InsertUpdateDelete]
 @ID int output, 
 @TenSach nvarchar(200),
 @NamXB nvarchar(10),
 @TacGia nvarchar(100),
 @NhaXB nvarchar(100),
 @TrangThai bit,
 @KeSach int,
 @VTNgan int,
 @MaTL int,
 @Hinh nvarchar(200),
 @Action int 
AS
IF @Action = 0 
BEGIN
 INSERT INTO [Sach] ([TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh])
 VALUES (@TenSach, @NamXB,@TacGia,@NhaXB,@TrangThai,@KeSach,@VTNgan,@MaTL,@Hinh)
 SET @ID = @@identity 
END
ELSE IF @Action = 1 
BEGIN
 UPDATE [Sach]
 SET [TenSach] = @TenSach,[NamXB]=@NamXB,[TacGia]=@TacGia,
 [NXB]=@NhaXB,[TrangThai]=@TrangThai, [KeSach] =@KeSach, [VTNgan] =@VTNgan, [MaTL] = @MaTL, [Hinh] = @Hinh
 WHERE [MaSach] = @ID
END
ELSE IF @Action = 2 
BEGIN
 DELETE FROM [Sach] WHERE [MaSach] = @ID
END
go
Create PROCEDURE [dbo].[Category_InsertUpdateDelete]
 @MaTL int output, 
 @TenTL nvarchar(200),
 @Action int 
AS
IF @Action = 0
BEGIN
INSERT INTO [TheLoai] ([TenTL])
VALUES (@TenTL)
SET @MaTL = @@identity 
END
ELSE IF @Action = 1
BEGIN
UPDATE [TheLoai] SET [TenTL] = @TenTL
WHERE [MaTL] = @MaTL
END
ELSE IF @Action = 2
BEGIN
DELETE FROM [TheLoai] WHERE [MaTL] = @MaTL
END
go
Alter table [Sach]
add [Hinh] nvarchar (200)


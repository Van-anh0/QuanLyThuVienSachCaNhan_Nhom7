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
SET IDENTITY_INSERT [dbo].[TheLoai] Off
SET IDENTITY_INSERT [dbo].[Sach] On

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('1',N'Chính trị luận',2000,N'Aritotle',N'NXB Nông Duy Trường',0,1,2,1,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('2',N'Đất nước nhỏ, nền chính trị lớn',1999,N'Karava',N'NXB Chính trị quốc gia',0,2,1,1,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('3',N'Bố già',2005,N'Mario Puzo',N'NXB Trẻ',0,1,1,3,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('4',N'Tuổi thơ dữ dội',1968,N'Phùng Quán',N'NXB Nhi Đồng',1,1,1,3,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('5',N'Tiếng chim hót trong bụi mận gai',1968,N'J.R.R.Tolkien',N'NXB Nhi Đồng',1,1,1,3,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('6',N'Không gia đình',1968,N'Hector Malot',N'NXB Trẻ',1,1,1,3,NULL)
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('7',N'Thành phố thông minh',2010,N'Houbing Song',N'NXB Chính trị quốc gia',0,1,4,9,'D:\sach\anh7.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('8',N'Chú bé mang Pyjama sọc',2010,N'John Boyne',N'NXB Hội nhà văn',1,2,2,6,'D:\sach\anh8.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('9',N'Harry Potter và Hòn đá phù thủy',2012,N'J.K.Rowling',N'NXB Trẻ',1,2,3,6,'D:\sach\anh9.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('10',N'Thiền Sư và em bé 5 tuổi',2011,N'Thích Nhất Hạnh',Null,1,4,1,8,'D:\sach\anh10.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('11',N'Harry Potter và Phòng chứa bí mật',2012,N'J.K.Rowling',N'NXB Trẻ',1,2,3,6,'D:\sach\anh11.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('12',N'Năng lượng',2011,N'Richard Rhodes',Null,0,3,2,7,'D:\sach\anh12.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('13',N'Mô hình Hồi Quy và Khám phá Khoa học',2011,N'Nguyễn Văn Tuấn',N'NXB Tổng hợp',0,3,2,7,'D:\sach\anh13.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('14',N'Harry Potter và Hội Phường Hoàng',2012,N'J.K.Rowling',N'NXB Trẻ',1,2,3,6,'D:\sach\anh14.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('15',N'Harry Potter và Đứa trẻ bị nguyền rủa',2012,N'J.K.Rowling',N'NXB Trẻ',1,2,3,6,'D:\sach\anh15.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('16',N'Từ bước nở hoa sen',2011,N'Thích Nhất Hạnh',N'NXB Hồng Đức',1,4,1,8,'D:\sach\anh16.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('17',N'Đạo phật ngày nay',2017,N'Thích Nhất Hạnh',N'NXB Văn hóa dân tộc',0,4,1,8,'D:\sach\anh17.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('18',N'Tay thầy trong tay con',2017,N'Thích Nhất Hạnh',N'NXB Lao động',0,4,1,8,'D:\sach\anh18.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('19',N'Chuyển đổi số',2018,N'Lindsay Herbert',N'NXB Thông tin và truyền thông',0,1,2,9,'D:\sach\anh19.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('20',N'Blockchain Khởi nguồn cho nền kinh tế mới',2011,N'Melanie Swan',N'NXB Đại học kinh tế quốc dân',0,1,3,9,'D:\sach\anh20.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('21',N'Dế Mèn phiêu lưu ký',2019,N'Tô Hoài',N'NXB Kim Đồng',1,2,1,6,'D:\sach\anh21.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('22',N'Lồng kính – Tự động hóa và Chúng ta',2019,N'Nicholas Carr',N'NXB Trẻ',0,2,4,7,'D:\sach\anh22.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('23',N'Lỗ đen',2018,N'Stephen Hawking',N'NXB Trẻ',1,2,4,7,'D:\sach\anh23.jpg')


INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('24',N'Cổ tích Việt Nam – Tình nghĩa thủy chung',2015,N'Nguyễn Mạnh Thái',N'NXB Mỹ thuật',0,1,3,6,'D:\sach\anh24.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('25',N'Cổ tích Trăng Non – Cậu bé Tích Chu',2014,N'',N'NXB Phụ nữ Việt Nam ',1,1,3,6,'D:\sach\anh25.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('26',N'Thần thoại Hy Lạp',2016,N'',N'NXB Văn Học ',0,4,2,8,'D:\sach\anh26.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('27',N'Truyển cổ Grimm 1',2017,N'Jacos, Wilhelm Grimm',N'NXB Hà Nội ',1,1,2,6,'D:\sach\anh27.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('28',N'Những Nhà khám phá – Lịch sử tri kiến vạn vật và con người',2010,N'Daniel J. Boorstin',N'NXB Thế Giới',1,2,4,7,'D:\sach\anh28.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('29',N'Cuộc cách mạng Blockchain',2018,N'Don Tapscott, Alex Tapscott',N'NXB Đại học kinh tế quốc dân ',1,1,3,9,'D:\sach\anh29.jpg')


INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('30',N'Truyện cổ Grimm 2',2017,N'Jacos, Wilhelm Grimm',N'NXB Hà Nội',1,1,2,6,'D:\sach\anh30.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('31',N'Doraemon VOL.1',2017,N'Fujiko F Fujio',N'NXB Kim Đồng',1,1,4,6,'D:\sach\anh31.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('32', N'Doraemon VOL.2',2017,N'Fujiko F Fujio',N'NXB Kim Đồng',1,1,4,6,'D:\sach\anh32.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('33', N'Doraemon VOL.3',2017,N'Fujiko F Fujio',N'NXB Kim Đồng',1,1,4,6,'D:\sach\anh33.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('34', N'Doraemon VOL.4',2018,N'Fujiko F Fujio',N'NXB Kim Đồng',1,1,4,6,'D:\sach\anh34.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('35', N'Doraemon VOL.5',2018,N'Fujiko F Fujio',N'NXB Kim Đồng',1,1,4,6,'D:\sach\anh35.jpg')


INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('36', N'Doraemon VOL.6',2018,N'Fujiko F Fujio',N'NXB Kim Đồng',1,1,4,6,'D:\sach\anh36.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('37', N'Doraemon VOL.7',2019,N'Fujiko F Fujio',N'NXB Kim Đồng',1,1,4,6,'D:\sach\anh37.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('38', N'Doraemon VOL.8',2019,N'Fujiko F Fujio',N'NXB Kim Đồng',0,1,4,6,'D:\sach\anh38.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('39', N'Doraemon VOL.9',2019,N'Fujiko F Fujio',N'NXB Kim Đồng',0,1,4,6,'D:\sach\anh39.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('40', N'Doraemon VOL.10',2019,N'Fujiko F Fujio',N'NXB Kim Đồng',0,1,4,6,'D:\sach\anh40.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('41',N'Tế bào gốc',2014,N'Paul Knoepfler',N'NXB Dân trí ',0,3,2,7,'D:\sach\anh41.jpg')

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('42',N'Endurance hành trình không gian',2019,N'Scott Kelly',N'NXB Thế giới',1,4,1,7,'D:\sach\anh42.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('43',N'Những gã khổng lồ công nghệ Trung Quốc',2019,N'Rebecca A. Fannin',N'NXB Thế giới',1,2,2,9,'D:\sach\anh43.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('44',N'Máy móc-Nền tảng-Cộng đồng',2020,N'Andrew Mcafee Erik Brynjolfsson',N'NXB Thông tin và truyền thông ',0,2,2,9,'D:\sach\anh44.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('45',N'Bụt là hình hài-Bụt là tâm thức',2018,N'Thích Nhất Hạnh',N'NXB Lao động ',1,4,1,8,'D:\sach\anh45.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('46',N'Ngôn ngữ của chúa',2017,N'Francis S. Collins',N'NXB Thế giới ',0,4,2,8,'D:\sach\anh46.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('47',N'Vật liệu và thiết bị Nano',2019,N'Trương Văn Tân',N'NXB Tổng hợp Hồ Chí Minh',1,1,3,9,'D:\sach\anh47.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('48',N'6 phát minh làm nên thời đại',2018,N'Steven Johnson',N'NXB Thế giới ',1,3,2,7,'D:\sach\anh48.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('49',N'Bách khoa toàn thư Khoa học',2018,N'Chris Woodford, Steve Parker',N'NXB Lao động ',0,3,2,7,'D:\sach\anh49.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('50',N'Vật lý hạt',2014,N'Tom Whynite, Oliver Pugh',N'NXB Dân trí',0,3,2,7,'D:\sach\anh50.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('51',N'Lược sử tôn giáo',2017,N'Richard Holloway',N'NXB Thế giới',0,4,2,8,'D:\sach\anh51.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('52',N'Nhà giả kim',2017,N'Paulo Coelho',N'NXB Văn Học ',1,1,3,6,'D:\sach\anh52.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('53',N'101 Truyện cổ tích chọn lọc',2019,N'Vương Diễm Nga',N'NXB Văn Học',0,2,2,6,'D:\sach\anh53.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('54',N'Code dạo ký sự-Lập trình viên đâu phải chỉ biết code',2020,N'Phạm Huy Hoàng',N'NXB Dân trí',1,1,4,9,'D:\sach\anh54.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('55',N'Dữ liệu lớn-Cuộc cách mạng thay đổi chúng ta và thế giới',2020,N'Rob Thomas, Patrick McSharry',N'NXB Khoa học và kỹ thuật ',1,1,4,9,'D:\sach\anh55.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('56',N'Tư Duy Pháp Lý Của Luật Sư',2016,N'Plato',N'NXB Lao động',1,2,3,2,'D:\sach\tuduy.jpg')



--10 thể loại đầu chính trị
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('57',N'Qatar – Đất Nước Nhỏ, Nền Chính Trị Lớn',1968,N'Aristotle',N'Dịch giả Nông Duy Trường',0,2,1,1,'D:\sach\qatar.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('58',N'Chính trị - Khái lược những tư tưởng lớn',2019,N'DK',N'NXB Dân Trí',1,1,1,1,'D:\sach\khailuoctutuonglon.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('59',N'Bàn Về Khế Ước Xã Hội',2018,N'Jean - Jacques Rousseau',N'Nhà Xuất Bản Thế Giới',0,2,1,1,'D:\sach\kheuoc.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('60',N'Quân Vương – Thuật Cai Trị',2018,N'Niccolò Machiavelli',N'NXB Thế Giới',1,2,2,1,'D:\sach\qunvuong.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('61',N'Cộng Hòa',2018,N'Plato',N'NXB Thế Giới',0,2,2,1,'D:\sach\conghoa.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('62',N'Bàn Về Tinh Thần Pháp Luật',2016,N'Aristotle',N'NXB Thế Giới',0,2,1,1,'D:\sach\tinhthanphapluat.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('63',N'33 Chiến Lược Của Chiến Tranh',2020,N'Robert Greene',N'NXB Trẻ',1,1,2,1,'D:\sach\33chienluoc.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('64',N'Chính Trị – Nghề Nghiệp Và Sứ Mệnh',2019,N'Aristotle',N'NXB Thế Giới',0,2,1,1,'D:\sach\nghenghiepsumenh.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('65',N'Ngày Cuối Trong Đời Socrates',2018,N'Plato',N'NXB Thế Giới',1,2,2,1,'D:\sach\ngaycuoi.png')

--10 thể loại pháp luật 

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('66',N'Hiến Pháp Nước Cộng Hòa Xã Hội Chủ Nghĩa Việt Nam',2016,N'Quốc hội',N'NXB Chính Trị Quốc GIa Sự Thật',0,2,2,2,'D:\sach\hienphap.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('67',N'Bộ Luật Dân Sự',2018,N'Quốc hội',N'NXB Lao động',1,2,2,2,'D:\sach\boluat.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('68',N'Bộ Luật Hình Sự',2019,N'Quốc hội',N'NXB Thế Giới',0,2,2,2,'D:\sach\hinhsu.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('69',N'Bộ Luật Lao Động',2015,N'Quốc hội',N'NXB Lao động',1,2,2,2,'D:\sach\laodong.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('70',N'Hiến Pháp Mỹ Được Làm Ra Như Thế Nào?',2018,N'Nguyễn Cảnh Bình',N'NXB Thế Giới',0,2,2,2,'D:\sach\hienphapmy.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('71',N'25 Tình Huống Pháp Lý Đời Thường',2018,N'Plato',N'NXB Lao động',0,2,2,2,'D:\sach\25tinhhuong.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('72',N'Luật 101',2018,N'Rhonda Byrne',N'NXB Thế Giới',1,2,2,2,'D:\sach\luat101.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('73',N'Cẩm Nang Tra Cứu Pháp Luật Về Cạnh Tranh',2017,N'Nhiều tác giả',N'NXB Chính Trị Quốc Gia Sự Thật',0,2,2,2,'D:\sach\camnang.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('74',N'Các Chế Độ Hôn Nhân Và Gia Đình Việt Nam Xưa Và Nay',2018,N'Nhiều tác giả',N'NXB Lao động',1,2,2,2,'D:\sach\cacchedo.jpg')

--10 thể loại văn học 

INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('75',N'Tuổi thơ dữ dội',2016,N'Phùng Quán',N'NXB Kim Đồng',1,2,2,3,'D:\sach\tuoitho.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('76',N'Giết con chim nhại',2017,N'Harper Lee',N'NXB Văn Học',1,2,2,3,'D:\sach\gietchim.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('77',N'Tiếng chim hót trong bụi mận gai',2015,N'Miêu Công Tử',N'NXB Thanh Niên',1,2,2,3,'D:\sach\tiengchim.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('78',N'Anh chàng Hobbits',2019,N'Plato',N'NXB Lao động',1,2,2,3,'D:\sach\anhchang.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('79',N'Không gia đình',2006,N'Hector Malot',N'NXB Văn Hóa - Văn Nghệ',1,2,2,3,'D:\sach\khonggiadinh.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('80',N'Chiến tranh và Hòa bình',2015,N'Andrea Hirata',N'NXB Hội Nhà Văn',1,2,2,3,'D:\sach\chientranhhoabinh.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('81',N'Những người khốn khổ',2016,N'Victor Hugo',N'NXB Lao động',1,2,2,3,'D:\sach\nguoikhonkho.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('82',N'Ông già và biển cả',2016,N'Plato',N'NXB Văn Học',1,2,2,3,'D:\sach\onggia.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('83',N'Bắt trẻ đồng xanh',2019,N'Plato',N'NXB Lao động',1,2,2,3,'D:\sach\battredongxanh.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('84',N'Chiến binh cầu vồng',2016,N'Andrea Hirata',N'NXB Hội Nhà Văn',1,2,2,3,'D:\sach\chienbinh.jpg')


--10 thể loại tiểu thuyết
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('85',N'Anna Karenina',2016,N'Andrea Hirata',N'NXB Thế Giới',1,2,2,4,'D:\sach\anna.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('86',N'Bà Bovary',2015,N'Hector Malot',N'NXB Hội Nhà Văn',1,2,2,4,'D:\sach\babovary.png')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('87',N'Chiến tranh và Hòa bình',2019,N'Andrea Hirata',N'NXB Thế Giới',1,2,2,4,'D:\sach\chientranh.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('88',N'Lolita',2017,N'Andrea Hirata',N'NXB Hội Nhà Văn',1,2,2,4,'D:\sach\lolita.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('89',N'Những cuộc phiêu lưu của Huckleberry Finn',2016,N'Andrea Hirata',N'NXB Thế Giới',1,2,2,4,'D:\sach\nhungcuocphieuluu.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('90',N'Hamlet',2018,N'Hector Malot',N'NXB Hội Nhà Văn',1,2,2,4,'D:\sach\hamlet.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('91',N'Đại gia Gasby',2016,N'Victor Hugo',N'NXB Hội Nhà Văn',1,2,2,4,'D:\sach\daigia.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('92',N'Đi tìm thời gian đã mất',2015,N'Andrea Hirata',N'NXB Hội Nhà Văn',1,2,2,4,'D:\sach\ditim.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('93',N'Truyện ngắn của Anton Chekhov',2016,N'Victor Hugo',N'NXB Hội Nhà Văn',1,2,2,4,'D:\sach\truyenngan.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('94',N'Middlemarch',2016,N'Andrea Hirata',N'NXB Thế Giới',1,2,2,4,'D:\sach\mid.jpg')
--10 thể loại tâm lý
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('95',N'Tâm lý học hài hước',2016,N'Richard Wiseman',N'NXB Thế Giới',1,3,2,5,'D:\sach\tamly1.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('96',N'Sức mạnh của thói quen',2015,N'Charles Duhigg',N'NXB Thế Giới',0,2,2,5,'D:\sach\sucmanh.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('97',N'Thay đổi',2016,N'Chip & Dan Heath',N'NXB Thế Giới',1,3,2,5,'D:\sach\thaydoi.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('98',N'Tâm lý học đám đông',2019,N'Gustave Le Bon',N'NXB Thế Giới',0,1,2,5,'D:\sach\tamlyhoc.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('99',N'Chúng ta quyết định như thế nào?',2016,N'Jonah Lehrer',N'NXB Thế Giới',0,1,2,5,'D:\sach\chungta.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('100',N'Những đòn tâm lý thuyết phục',2018,N'Robert B.Cialdini',N'NXB Thế Giới',0,2,2,5,'D:\sach\nhungdontamly.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('101',N'Bức xúc không làm ta vô can',2016,N'Đặng Hoàng Giang',N'NXB Thế Giới',1,2,3,5,'D:\sach\bucxuckhonglamta.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('102',N'Phi lý trí',2014,N'Dan Ariely',N'NXB Thế Giới',1,2,2,5,'D:\sach\philytri.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('103',N'Đọc vị bất kỳ ai',2015,N'TS. David J.Lieberman',N'NXB Thế Giới',1,2,2,5,'D:\sach\docvi.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('104',N'Tư duy nhanh và chậm',2016,N'Daniel Kahneman',N'NXB Thế Giới',1,2,2,5,'D:\sach\tuduy.jpg')
INSERT [dbo].[Sach] ([MaSach],[TenSach],[NamXB],[TacGia],[NXB],[TrangThai],[KeSach],[VTNgan],[MaTL],[Hinh]) VALUES ('105',N'Chính trị luận',2018,N'Aristotle',N'NXB Thế Giới',0,2,1,1,'D:\sach\chinhtriluan.png')


-------------------
SET IDENTITY_INSERT [dbo].[Sach] Off
SET IDENTITY_INSERT [dbo].[BanDoc] On
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
go


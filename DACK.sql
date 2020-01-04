USE [QLHS]
GO
/****** Object:  StoredProcedure [dbo].[addBCHK]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addBCHK] @MabcHK varchar(10),@MaHK int,@MaLop varchar(10),@SL int,@TL float
as
begin
	if exists(select bcm.MaBaoCaoMon from BAOCAOTONGKETMON bcm where bcm.MaHocKi=@MaHK and bcm.MaLop=@MaLop  )
	begin 
	
	if not exists(select bHK.MaBaoCaoHK from BAOCAOTONGKETHK bHK  where bHK.MaHocKi=@MaHK and bHK.MaLop=@MaLop  )
	begin
	insert into BAOCAOTONGKETHK(MaBaoCaoHK,MaHocKi,MaLop) values(@MabcHK,@MaHK,@MaLop)
	update BAOCAOTONGKETHK set SoLuongDat=@SL , TiLeDat = @TL where MaHocKi = @MaHK and MaLop =@MaLop
	end
	else
	begin 
		update BAOCAOTONGKETHK set SoLuongDat=@SL , TiLeDat = @TL where MaHocKi = @MaHK and MaLop =@MaLop
	end
	end
end
GO
/****** Object:  StoredProcedure [dbo].[AddHK]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddHK] @mahk int ,@tenhk varchar(10)
as
begin
insert into HOCKI(MaHocKi,TenHocKi) values(@mahk,@tenhk)

end

GO
/****** Object:  StoredProcedure [dbo].[AddMH]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddMH] @mamh varchar(10)  ,@tenmh nvarchar(50)
as
begin
insert into MONHOC(MaMonHoc,TenMonHoc) values(@mamh,@tenmh)

end

GO
/****** Object:  StoredProcedure [dbo].[AddMHtoNH]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddMHtoNH] @mabc varchar(10)  ,@mahk int, @mamh varchar(10)
as
begin
insert into BAOCAOTONGKETMON(MaBaoCaoMon,MaHocKi,MaMon,SoLuongDatMon,TiLeDatMon) values(@mabc,@mahk,@mamh,0,0)

end
GO
/****** Object:  StoredProcedure [dbo].[AddU]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddU] @user varchar(10), @pass varchar(20),@per int
as
begin
insert into Userr(userName,passWord,permission) values(@user,@pass,@per)


end
GO
/****** Object:  StoredProcedure [dbo].[bang]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[bang] 
as
begin 

select DISTINCT ct.*,bd.MaMonHoc,bd.Diem15Phut,bd.Diem1Tiet,bd.DiemCuoiKi from BAOCAOTONGKETMON bcm ,CHITIETDSLOP ct,BANGDIEM bd where  bcm.MaLop = ct.MaLop and bd.MaHocSinh = ct.MaHocSinh 

end 

GO
/****** Object:  StoredProcedure [dbo].[DelU]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DelU] @id int
as
begin
delete from Userr where Id=@id


end
GO
/****** Object:  StoredProcedure [dbo].[haveHK]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[haveHK] @MaMH varchar(10)
as
begin
if exists(select bcm.MaMon from BAOCAOTONGKETMON bcm where bcm.MaMon=@MaMH  )
begin
select * from MONHOC mh ,BAOCAOTONGKETMON bcm where mh.MaMonHoc = @MaMH and mh.MaMonHoc= bcm.MaMon
end
end

GO
/****** Object:  StoredProcedure [dbo].[KTave]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KTave] @Malop varchar(10),@MaHK int
as
begin
select * from BANGDIEM bd , CHITIETDSLOP ctds where  bd.MaHocSinh = ctds.MaHocSinh and ctds.MaLop=@MaLop and bd.MaHocKi=@MaHK 
end 

GO
/****** Object:  StoredProcedure [dbo].[ktclass]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[ktclass]  @Malop varchar(10),@MaHK int
as
begin
select bd.MaHocSinh from BANGDIEM bd , CHITIETDSLOP ctds where  bd.MaHocSinh = ctds.MaHocSinh and ctds.MaLop=@MaLop and bd.MaHocKi=@MaHK  group by bd.MaHocSinh
end 
GO
/****** Object:  StoredProcedure [dbo].[mhtoclass]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mhtoclass] @MaLop varchar(10), @Mamh varchar(10),@maHK int
as
begin
update BAOCAOTONGKETMON set MaLop = @MaLop where MaMon= @Mamh and MaHocKi = @maHK
end

GO
/****** Object:  StoredProcedure [dbo].[noneHK]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[noneHK] @MaMH varchar(10)
as
begin
if not exists(select bcm.MaMon from BAOCAOTONGKETMON bcm where bcm.MaMon=@MaMH  )
begin
select * from MONHOC where MaMonHoc = @MaMH
end
end
GO
/****** Object:  StoredProcedure [dbo].[setup]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[setup] @malop varchar(10),@mamh varchar(10)
as
begin 
update BAOCAOTONGKETMON set SoLuongDatMon = 0, TiLeDatMon =0 where MaLop=@malop and MaMon=@mamh

end 
GO
/****** Object:  StoredProcedure [dbo].[TONGKET]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TONGKET]
as
begin
select bcm.MaHocKi,bcm.MaLop from DANHSACHLOP dsl , BAOCAOTONGKETMON bcm where dsl.MaLop= bcm.MaLop group by bcm.MaHocKi,bcm.MaLop
end

GO
/****** Object:  StoredProcedure [dbo].[TracuuhocsinhKL]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TracuuhocsinhKL] @MaK varchar(10)
as
begin
select DISTINCT hs.*,ds.TenLop,ct.TBHocKi1,ct.TBHocKi2 from KHOILOP kl,Hoc_sinh hs,CHITIETDSLOP ct,DANHSACHLOP ds where  kl.MaKhoiLop=ds.MaKhoiLop and ds.MaLop=ct.MaLop and ct.MaHocSinh = hs.ID and kl.TenKhoiLop =@MaK
end
GO
/****** Object:  StoredProcedure [dbo].[TracuuhocsinhLop]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TracuuhocsinhLop] @MaLop varchar(10)
as
begin
select DISTINCT hs.*,ds.TenLop,ct.TBHocKi1,ct.TBHocKi2 from KHOILOP kl,Hoc_sinh hs,CHITIETDSLOP ct,DANHSACHLOP ds where  kl.MaKhoiLop=ds.MaKhoiLop and ds.MaLop=ct.MaLop and ct.MaHocSinh = hs.ID and ds.TenLop =@MaLop
end

GO
/****** Object:  StoredProcedure [dbo].[updateD]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateD] @MaHS int,@MaMH varchar(10),@p15 float,@t1 float,@ck float
as
begin
update BANGDIEM set Diem15Phut = @p15,Diem1Tiet=@t1,DiemCuoiKi=@ck where MaHocSinh=@MaHS and MaMonHoc =@MaMH

end

GO
/****** Object:  StoredProcedure [dbo].[updateHS]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateHS] @TenL varchar(10),@MaHS int,@name nvarchar(50),@address nvarchar(50),@mail nvarchar(50),@date nvarchar(50),@sex nchar(10)
as
begin
declare @s varchar(10)
select @s =lp.MaLop from DANHSACHLOP lp where lp.TenLop = @TenL
update CHITIETDSLOP set MaLop = @s where MaHocSinh =@MaHS
update Hoc_sinh set Name = @name,Address=@address,Email=@mail,Date=@date,Sex=@sex where ID = @MaHS
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateQD]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateQD] @tt int,@td int,@sstd int,@diemdat float
as
begin
update THAMSO set TuoiToiThieu=@tt,TuoiToiDa=@td,SiSoToiDa=@sstd,DiemDatMon=@diemdat
end
GO
/****** Object:  StoredProcedure [dbo].[updateSL]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateSL] @malop varchar(10),@mamh varchar(10)
as
begin 
update BAOCAOTONGKETMON set SoLuongDatMon = SoLuongDatMon +1 where MaLop=@malop and MaMon=@mamh
end 

GO
/****** Object:  StoredProcedure [dbo].[updateTL]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateTL] @malop varchar(10),@mamh varchar(10),@tl float
as
begin 
update BAOCAOTONGKETMON set TiLeDatMon = @tl where MaLop=@malop and MaMon=@mamh
end 

GO
/****** Object:  StoredProcedure [dbo].[UpdateU]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateU] @id int, @pass varchar(20),@per int
as
begin
update Userr  set passWord =@pass , permission =@per  where Id=@id


end
GO
/****** Object:  StoredProcedure [dbo].[XoaHS]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaHS] @MaHS int
as
begin
delete from CHITIETDSLOP  where MaHocSinh = @MaHS
delete from Hoc_sinh  where ID = @MaHS

end
GO
/****** Object:  Table [dbo].[BANGDIEM]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANGDIEM](
	[MaBangDiem] [varchar](10) NOT NULL,
	[MaHocSinh] [int] NULL,
	[MaHocKi] [int] NULL,
	[MaMonHoc] [varchar](10) NULL,
	[Diem15Phut] [float] NULL,
	[Diem1Tiet] [float] NULL,
	[DiemCuoiKi] [float] NULL,
 CONSTRAINT [PK_BANGDIEM] PRIMARY KEY CLUSTERED 
(
	[MaBangDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BAOCAOTONGKETMON]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAOCAOTONGKETMON](
	[MaBaoCaoMon] [varchar](10) NOT NULL,
	[MaHocKi] [int] NULL,
	[MaLop] [varchar](10) NULL,
	[MaMon] [varchar](10) NULL,
	[SoLuongDatMon] [int] NULL,
	[TiLeDatMon] [float] NULL,
 CONSTRAINT [PK_BAOCAOTONGKETMON] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BAOCAOTONGKETHK]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAOCAOTONGKETHK](
	[MaBaoCaoHK] [varchar](10) NOT NULL,
	[MaHocKi] [int] NULL,
	[MaLop] [varchar](10) NULL,
	[SoLuongDat] [int] NULL,
	[TiLeDat] [float] NULL,
 CONSTRAINT [PK_BAOCAOTONGKETHK] PRIMARY KEY CLUSTERED 
(
	[MaBaoCaoHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETDSLOP]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETDSLOP](
	[MaChiTietDSLop] [varchar](10) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
	[MaHocSinh] [int] NOT NULL,
	[TBHocKi1] [float] NULL,
	[TBHocKi2] [float] NULL,
 CONSTRAINT [PK_CHITIETDSLOP] PRIMARY KEY CLUSTERED 
(
	[MaChiTietDSLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANHSACHLOP]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DANHSACHLOP](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [varchar](10) NULL,
	[SiSo] [int] NULL,
	[MaKhoiLop] [varchar](10) NULL,
 CONSTRAINT [PK_DANHSACHLOP] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hoc_sinh]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoc_sinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Date] [nvarchar](50) NULL,
	[Sex] [nchar](10) NULL,
 CONSTRAINT [PK_Hoc_sinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOCKI]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOCKI](
	[MaHocKi] [int] NOT NULL,
	[TenHocKi] [varchar](10) NULL,
 CONSTRAINT [PK_HOCKI] PRIMARY KEY CLUSTERED 
(
	[MaHocKi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOILOP]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOILOP](
	[MaKhoiLop] [varchar](10) NOT NULL,
	[TenKhoiLop] [varchar](10) NULL,
 CONSTRAINT [PK_KHOILOP] PRIMARY KEY CLUSTERED 
(
	[MaKhoiLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMonHoc] [varchar](10) NOT NULL,
	[TenMonHoc] [nvarchar](50) NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[TuoiToiThieu] [int] NULL,
	[TuoiToiDa] [int] NULL,
	[SiSoToiDa] [int] NULL,
	[DiemDatMon] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Userr]    Script Date: 05/01/2020 4:20:58 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Userr](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](10) NULL,
	[passWord] [varchar](20) NULL,
	[permission] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BANGDIEM] ([MaBangDiem], [MaHocSinh], [MaHocKi], [MaMonHoc], [Diem15Phut], [Diem1Tiet], [DiemCuoiKi]) VALUES (N'1007MHLy', 1007, 12019, N'MHLy', 8, 8, 9)
INSERT [dbo].[BANGDIEM] ([MaBangDiem], [MaHocSinh], [MaHocKi], [MaMonHoc], [Diem15Phut], [Diem1Tiet], [DiemCuoiKi]) VALUES (N'1007MHToan', 1007, 12019, N'MHToan', 0, 0, 0)
INSERT [dbo].[BANGDIEM] ([MaBangDiem], [MaHocSinh], [MaHocKi], [MaMonHoc], [Diem15Phut], [Diem1Tiet], [DiemCuoiKi]) VALUES (N'2007MHHoa', 2007, 22019, N'MHHoa', 5, 5, 5)
INSERT [dbo].[BANGDIEM] ([MaBangDiem], [MaHocSinh], [MaHocKi], [MaMonHoc], [Diem15Phut], [Diem1Tiet], [DiemCuoiKi]) VALUES (N'2007MHLy', 2007, 12019, N'MHLy', 10, 7.5, 6.5)
INSERT [dbo].[BANGDIEM] ([MaBangDiem], [MaHocSinh], [MaHocKi], [MaMonHoc], [Diem15Phut], [Diem1Tiet], [DiemCuoiKi]) VALUES (N'2007MHToan', 2007, 12019, N'MHToan', 7, 9, 8)
INSERT [dbo].[BANGDIEM] ([MaBangDiem], [MaHocSinh], [MaHocKi], [MaMonHoc], [Diem15Phut], [Diem1Tiet], [DiemCuoiKi]) VALUES (N'2011MHLy', 2011, 12019, N'MHLy', 0, 2, 3.5)
INSERT [dbo].[BAOCAOTONGKETMON] ([MaBaoCaoMon], [MaHocKi], [MaLop], [MaMon], [SoLuongDatMon], [TiLeDatMon]) VALUES (N'12019MHLy', 12019, N'L1', N'MHLy', 2, 66)
INSERT [dbo].[BAOCAOTONGKETMON] ([MaBaoCaoMon], [MaHocKi], [MaLop], [MaMon], [SoLuongDatMon], [TiLeDatMon]) VALUES (N'12019MHToa', 12019, N'L1', N'MHToan', 1, 50)
INSERT [dbo].[BAOCAOTONGKETMON] ([MaBaoCaoMon], [MaHocKi], [MaLop], [MaMon], [SoLuongDatMon], [TiLeDatMon]) VALUES (N'22019MHHoa', 22019, N'L1', N'MHHoa', 1, 100)
INSERT [dbo].[BAOCAOTONGKETMON] ([MaBaoCaoMon], [MaHocKi], [MaLop], [MaMon], [SoLuongDatMon], [TiLeDatMon]) VALUES (N'22019MHVan', 22019, NULL, N'MHVan', 0, 0)
INSERT [dbo].[BAOCAOTONGKETHK] ([MaBaoCaoHK], [MaHocKi], [MaLop], [SoLuongDat], [TiLeDat]) VALUES (N'12019L1', 12019, N'L1', 1, 33)
INSERT [dbo].[BAOCAOTONGKETHK] ([MaBaoCaoHK], [MaHocKi], [MaLop], [SoLuongDat], [TiLeDat]) VALUES (N'22019L1', 22019, N'L1', 1, 100)
INSERT [dbo].[CHITIETDSLOP] ([MaChiTietDSLop], [MaLop], [MaHocSinh], [TBHocKi1], [TBHocKi2]) VALUES (N'L11007', N'L1', 1007, 0, 0)
INSERT [dbo].[CHITIETDSLOP] ([MaChiTietDSLop], [MaLop], [MaHocSinh], [TBHocKi1], [TBHocKi2]) VALUES (N'L12006', N'L3', 2006, 0, 0)
INSERT [dbo].[CHITIETDSLOP] ([MaChiTietDSLop], [MaLop], [MaHocSinh], [TBHocKi1], [TBHocKi2]) VALUES (N'L12007', N'L1', 2007, 0, 0)
INSERT [dbo].[CHITIETDSLOP] ([MaChiTietDSLop], [MaLop], [MaHocSinh], [TBHocKi1], [TBHocKi2]) VALUES (N'L12011', N'L1', 2011, 0, 0)
INSERT [dbo].[CHITIETDSLOP] ([MaChiTietDSLop], [MaLop], [MaHocSinh], [TBHocKi1], [TBHocKi2]) VALUES (N'L32008', N'L3', 2008, 0, 0)
INSERT [dbo].[DANHSACHLOP] ([MaLop], [TenLop], [SiSo], [MaKhoiLop]) VALUES (N'L1', N'10A1', 30, N'k10')
INSERT [dbo].[DANHSACHLOP] ([MaLop], [TenLop], [SiSo], [MaKhoiLop]) VALUES (N'L121', N'12A2', 10, N'k12')
INSERT [dbo].[DANHSACHLOP] ([MaLop], [TenLop], [SiSo], [MaKhoiLop]) VALUES (N'L2', N'11A2', 20, N'k11')
INSERT [dbo].[DANHSACHLOP] ([MaLop], [TenLop], [SiSo], [MaKhoiLop]) VALUES (N'L3', N'10A2', 39, N'k10')
SET IDENTITY_INSERT [dbo].[Hoc_sinh] ON 

INSERT [dbo].[Hoc_sinh] ([ID], [Name], [Address], [Email], [Date], [Sex]) VALUES (1007, N'nguyen trần phú', N'bien hoa', N'phu@gmail.com', N'01/03/2002 12:44:48 SA', N'True      ')
INSERT [dbo].[Hoc_sinh] ([ID], [Name], [Address], [Email], [Date], [Sex]) VALUES (2006, N'Trần Thị Quân', N'thanh pho ho chi minh', N'quan@gmail.com', N'01/03/2003 12:44:48 SA', N'False     ')
INSERT [dbo].[Hoc_sinh] ([ID], [Name], [Address], [Email], [Date], [Sex]) VALUES (2007, N'Trần Duy Quang', N'Tân Bình', N'Quang1@gmail.com', N'01/03/2002 12:44:48 SA', N'True      ')
INSERT [dbo].[Hoc_sinh] ([ID], [Name], [Address], [Email], [Date], [Sex]) VALUES (2008, N'Trần Văn Nhất', N'Bình Định', N'Nhatt@gmail.com', N'01/03/2002 12:44:48 SA', N'True      ')
INSERT [dbo].[Hoc_sinh] ([ID], [Name], [Address], [Email], [Date], [Sex]) VALUES (2011, N'Nguyễn Minh Phong ', N'Biên Hòa', N'p@gmail.com', N'08/07/2004 10:04:09 CH', N'True      ')
SET IDENTITY_INSERT [dbo].[Hoc_sinh] OFF
INSERT [dbo].[HOCKI] ([MaHocKi], [TenHocKi]) VALUES (12019, N'1')
INSERT [dbo].[HOCKI] ([MaHocKi], [TenHocKi]) VALUES (22019, N'2')
INSERT [dbo].[KHOILOP] ([MaKhoiLop], [TenKhoiLop]) VALUES (N'k10', N'10')
INSERT [dbo].[KHOILOP] ([MaKhoiLop], [TenKhoiLop]) VALUES (N'k11', N'11')
INSERT [dbo].[KHOILOP] ([MaKhoiLop], [TenKhoiLop]) VALUES (N'k12', N'12')
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc]) VALUES (N'MHHoa', N'Hoa')
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc]) VALUES (N'MHLy', N'Ly')
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc]) VALUES (N'MHSu', N'Su')
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc]) VALUES (N'MHToan', N'Toan')
INSERT [dbo].[MONHOC] ([MaMonHoc], [TenMonHoc]) VALUES (N'MHVan', N'Van')
INSERT [dbo].[THAMSO] ([TuoiToiThieu], [TuoiToiDa], [SiSoToiDa], [DiemDatMon]) VALUES (15, 17, 40, 5)
SET IDENTITY_INSERT [dbo].[Userr] ON 

INSERT [dbo].[Userr] ([Id], [userName], [passWord], [permission]) VALUES (1, N'admin', N'phu123', 1)
INSERT [dbo].[Userr] ([Id], [userName], [passWord], [permission]) VALUES (2, N'phu', N'phu123', 2)
INSERT [dbo].[Userr] ([Id], [userName], [passWord], [permission]) VALUES (3, N'quan', N'quan123', 3)
SET IDENTITY_INSERT [dbo].[Userr] OFF
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BANGDIEM_Hoc_sinh] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[Hoc_sinh] ([ID])
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_Hoc_sinh]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BANGDIEM_HOCKI] FOREIGN KEY([MaHocKi])
REFERENCES [dbo].[HOCKI] ([MaHocKi])
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_HOCKI]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BANGDIEM_MONHOC] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MONHOC] ([MaMonHoc])
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_MONHOC]
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAOTONGKETMON_DANHSACHLOP] FOREIGN KEY([MaLop])
REFERENCES [dbo].[DANHSACHLOP] ([MaLop])
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON] CHECK CONSTRAINT [FK_BAOCAOTONGKETMON_DANHSACHLOP]
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAOTONGKETMON_HOCKI] FOREIGN KEY([MaHocKi])
REFERENCES [dbo].[HOCKI] ([MaHocKi])
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON] CHECK CONSTRAINT [FK_BAOCAOTONGKETMON_HOCKI]
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAOTONGKETMON_MONHOC] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MONHOC] ([MaMonHoc])
GO
ALTER TABLE [dbo].[BAOCAOTONGKETMON] CHECK CONSTRAINT [FK_BAOCAOTONGKETMON_MONHOC]
GO
ALTER TABLE [dbo].[BAOCAOTONGKETHK]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAOTONGKETHK_DANHSACHLOP] FOREIGN KEY([MaLop])
REFERENCES [dbo].[DANHSACHLOP] ([MaLop])
GO
ALTER TABLE [dbo].[BAOCAOTONGKETHK] CHECK CONSTRAINT [FK_BAOCAOTONGKETHK_DANHSACHLOP]
GO
ALTER TABLE [dbo].[BAOCAOTONGKETHK]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAOTONGKETHK_HOCKI] FOREIGN KEY([MaHocKi])
REFERENCES [dbo].[HOCKI] ([MaHocKi])
GO
ALTER TABLE [dbo].[BAOCAOTONGKETHK] CHECK CONSTRAINT [FK_BAOCAOTONGKETHK_HOCKI]
GO
ALTER TABLE [dbo].[CHITIETDSLOP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDSLOP_DANHSACHLOP] FOREIGN KEY([MaLop])
REFERENCES [dbo].[DANHSACHLOP] ([MaLop])
GO
ALTER TABLE [dbo].[CHITIETDSLOP] CHECK CONSTRAINT [FK_CHITIETDSLOP_DANHSACHLOP]
GO
ALTER TABLE [dbo].[CHITIETDSLOP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDSLOP_Hoc_sinh] FOREIGN KEY([MaHocSinh])
REFERENCES [dbo].[Hoc_sinh] ([ID])
GO
ALTER TABLE [dbo].[CHITIETDSLOP] CHECK CONSTRAINT [FK_CHITIETDSLOP_Hoc_sinh]
GO
ALTER TABLE [dbo].[DANHSACHLOP]  WITH CHECK ADD  CONSTRAINT [FK_DANHSACHLOP_KHOILOP] FOREIGN KEY([MaKhoiLop])
REFERENCES [dbo].[KHOILOP] ([MaKhoiLop])
GO
ALTER TABLE [dbo].[DANHSACHLOP] CHECK CONSTRAINT [FK_DANHSACHLOP_KHOILOP]
GO

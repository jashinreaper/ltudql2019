use master
go

if DB_ID('QuanLyBanHang') is not null
drop database QuanLyBanHang
create database QuanLyBanHang
go

use QuanLyBanHang
go
---------------------------------------GO-----------------------
--TAB HETHONG---------------------
--GROUP HETHONG
create table THONGTIN
(
tendonvi nvarchar(50),
diachi nvarchar(100),
dienthoai varchar(11),
fax varchar(11),
website varchar(50),
email varchar(50),
linhvuc nvarchar(30),
masothue varchar(30),
gpkd varchar(30),
)

create table LINHVUC
(
id int identity(1,1),
malinhvuc varchar(10),
tenlinhvuc nvarchar(30)
)

--GROUP BAOMAT
create table Users
(
id int identity(1,1),
userid varchar(10) primary key,
username varchar(30),
userpassword varchar(30),
userfullname nvarchar(50),
roleid varchar(10),
isactive bit
)

create table Roles
(
id int identity(1,1),
roleid varchar(10) primary key,
rolename nvarchar(30),
roledes nvarchar(100),
rfull bit,
raccess bit,
radd bit,
redit bit,
rdelete bit,
rprint bit,
rwrite bit,
rread bit,
isactive bit,
)

Create table NHATKIHETHONG(
	id int identity(1,1),
	NguoiDung nvarchar(20),
	MayTinh nvarchar(20),
	ThoiGian datetime,
	ChucNang nvarchar(30),
	HanhDong nvarchar(30),
	DoiTuong nvarchar(30)
)

--TAB HETHONG DATA


insert into Roles values('H0','Administrator','abcxyt',1,1,1,1,1,1,1,1,1)
insert into Roles values('H1','Staff','abcczxca',0,0,0,1,0,1,0,1,1)
insert into Roles values('B1','Staff2','abcczxca',0,0,0,1,0,1,0,1,0)
insert into Roles values('B2','Staff3','abcczxca',0,0,0,1,0,1,0,1,1)

insert into Users values('001','pvqui','123',N'Võ Cao Tuấn','H1',1)
insert into Users values('002','admin','1',N'Trương Bá Hổ','H1',1)

insert into LINHVUC values('A001',N'Kinh Doanh')
insert into LINHVUC values('A002',N'Thương mại')
insert into LINHVUC values('A003',N'Bất động sản')

insert into THONGTIN values('A003','A003','A003','A003','A003','A003','A003','A003','A003')

select * from Users
select * from Roles where rolename = 'Administrator'

--TAB DANHMUC----------------------

--GROUP DOI TAC
-- KHU VUC
Create table KHUVUC(
	id int identity(1,1),
	MaKhuVuc nvarchar(20) not null,
	TenKhuVuc nvarchar(20),
	GhiChu nvarchar(50),
	ConQuanLy bit

	primary key (MaKhuVuc)
)
-- KHACH HANG
CREATE TABLE KHACHHANG(
	id int identity(1,1),
	MAKH	char(10) not null,
	MaKhuVuc nvarchar(30),	
	HOTEN	nvarchar(40),
	DiaChi	nvarchar(50),
	MaSoThue nvarchar(20),
	Fax nvarchar(20),
	SODT	nvarchar(20),
	Mobile nvarchar(20),
	Email nvarchar(50),
	Website nvarchar(50),
	TaiKhoan nvarchar(50),
	NganHang nvarchar(50),
	GioiHanNo money,
	NoHienTai money,
	ChietKhau float,
	NickYahoo nvarchar(50),
	NguoiLienHe nvarchar(50),
	NickSkype nvarchar(50),
	ConQuanLy bit,
	DaiLy bit,
	KhachLe bit
	primary key (MAKH)
)
---------------------------------------------
-- NHA PHAN PHOI
CREATE TABLE NHAPHANPHOI(
	id int identity(1,1),
	MaNPP	char(10) not null,
		MaKhuVuc nvarchar(30),	
	TenNPP	nvarchar(40),
	DiaChi	nvarchar(50),
	MaSoThue nvarchar(20),
	Fax nvarchar(20),
	SODT	nvarchar(20),
	Mobile nvarchar(20),
	Email nvarchar(50),
	Website nvarchar(50),
	TaiKhoan nvarchar(50),
	NganHang nvarchar(50),
	GioiHanNo money,
	NoHienTai money,
	ChietKhau float,
	NguoiLienHe nvarchar(50),
	ChucVu nvarchar(50),
	ConQuanLy bit

	primary key (MaNPP)
)

--GROUP KHO HANG-------------------------------------------
-- KHO
CREATE TABLE KHO(
id int identity(1,1),
	MaKho	char(10) not null,
	TenKho	nvarchar(40),
	DiaChi	nvarchar(50),
	Fax nvarchar(20),
	SODT	nvarchar(20),
	Mobile nvarchar(20),
	Email nvarchar(50),
	NguoiQuanLy nvarchar(50),
	DienGiai nvarchar(50),
	ConQuanLy bit

	primary key (MaKho)
)
-- BANG DON VI
CREATE TABLE BANGDONVI(
id int identity(1,1),
	MaDV	char(10) not null,
	TenDV	nvarchar(40),
	GhiChu	nvarchar(50),
	ConQuanLy bit

	primary key (MaDV)
)
-- BANG NHOM HANG
CREATE TABLE BANGNHOMHANG(
id int identity(1,1),
	MaNH	char(10) not null,
	TenNH	nvarchar(40),
	GhiChu	nvarchar(50),
	ConQuanLy bit

	primary key (MaNH)
)

-- HANG HOA
CREATE TABLE HANGHOA(
id int identity(1,1),
	VatTu bit,
	DichVu bit,
		MaKhoHang nvarchar(30), 
	PhanLoai nvarchar(30),
	MaHH char(10) not null,
	TENHH	varchar(40),
	MaVachNSX nvarchar(20),
		MaDonVi nvarchar(20),
	XuatXu nvarchar(10),
	Thue	float,
	TonKhoToiThieu	int,
	TonKhoHienTai int,
		MaNhaCungCap nvarchar(30),
	GiaMua money,
	GiaSi money,
	GiaLe money

	primary key (MaHH)
)
---GROUP TO CHUC------------------------------------------
-- BO PHAN
CREATE TABLE BOPHAN(
id int identity(1,1),
	MaBP	char(10) not null,
	TenBP	nvarchar(40),
	GhiChu	nvarchar(50),
	ConQuanLy bit

	primary key (MaBP)
)
-- NHAN VIEN
CREATE TABLE NHANVIEN(
id int identity(1,1),
	MANV	char(10) not null,
	DocThan bit,
	ConQuanLy bit,	
	HOTEN	nvarchar(40),
	ChucVu nvarchar(40),
	DiaChi	nvarchar(100),
	SODT	nvarchar(20),
	Mobile nvarchar(20),
	Email nvarchar(50),
	DienGiai nvarchar(40),
	BoPhan nvarchar(40),
	QuanLy nvarchar(40)	

	primary key(MANV)
)


--TAB CHUCNANG
--GROUP QUAN LI BAN HANG
-- HOADON
CREATE TABLE HOADON(
id int identity(1,1),
	MaHD nvarchar(20) not null ,
	MaKH nvarchar(20),
	Gia float,
	Thue float,
	GiamGia float,
	NgayXuatHD datetime,
	Mieuta nvarchar(255),

	primary key(MaHD),
)
---------------------------------------------
-- CTHD
   CREATE TABLE CTHD(
   id int identity(1,1),
	MaHD	nvarchar(20),
		MASP	char(20),
	SL	int

	primary key(MaHD,MaSP)
)

--DATA-------------
-----------------------------------------------------
set dateformat dmy
-------------------------------
-- KHU VUC
insert into KhuVuc values('KVA',N'Khu A',N'Quản lý thiết bị điên tử',1),
							('KVB',N'Khu B',N'Quản lý đồ gia dụng',1),
							('KVC',N'Khu C',N'Quản lý đồ thủ công',1),
							('KVD',N'Khu D',N'Quản lý thiết bị di động',1),
							('KVE',N'Khu E',N'Quản lý mỹ phẩm',1),
							('KVF',N'Khu F',N'Quản lý Thực Phẩm',1)

-- Khách Hàng
insert into KHACHHANG values('KH0001','KVA',N'Nguyễn Thị Trúc',N'175/6 P.15 Điện Biên Phủ Q.Bình Thạnh Tp.HCM','0215512','023151512','05121512851','','NTT@gmail.com','www.NTT.com','215121215','VCB',1000000,Null,10,'NTT',N'Nguyễn Thị Trúc','NTT',1,1,0),
							('KH0002','KVB',N'Trần Văn Đại',N'171 P.3 Nguyễn Văn Cừ Q.5 Tp.HCM','0845222','0234874212','03215122451','','TVD@gmail.com','www.TVD.com','321512215','ARB',3000000,'',5,'TVD',N'Trần Văn Đại','TVD',1,1,0),
							('KH0003','KVC',N'Trần Thu Thủy',N'51 P.3 Nguyễn Thị Minh Khai Q.3 Tp.HCM','0321221','05421532122','03265123151','','TTT@gmail.com','www.TTT.com','5421512523','ARB',2000000,Null,5,'TTT',N'Trần Thu Thủy','TTT',1,1,0)


--Nhà Phân Phối
insert into NHAPHANPHOI values('NPP001','KVB',N'Benny',N'151 P.2 Điện Biên Phủ Q.Bình Thạnh Tp.HCM','021651321','0653165161','0216546221','',N'Benny@gmail.com',N'benny.com.vn','066548521','',3000000,Null,5,N'Trần Hoàng Long','',1),
								('NPP002','KVE',N'Thương hiệu Lancome',N'38 P.12 Hai Bà Trưng Q.Bình Thạnh Tp.HCM','0545212212','08424154542','0215612148','',N'Lancome@gmail.com',N'Lancome.com.vn','051231581','',10000000,Null,15,N'Nguyễn Thu Hồng','',1),
								('NPP003','KVA',N'LG Electronics',N'185 P.12 Cách Mạng Tháng 8 Q.5 Tp.HCM','021512321','0321516212','045842123','',N'LG@gmail.com',N'Lg.com','065416541','',200000000,Null,20,N'Phạm Quốc Đạt','',1),
								('NPP004','KVA',N'Samsung',N'154 P.12 Cách Mạng Tháng 8 Q.5 Tp.HCM','026216516','031561656212','055842123','',N'samsung@gmail.com',N'samsung.com','03541326541','',300000000,Null,15,N'Võ Hoài Trâm','',1)

--Kho

insert into KHO values('K001',N'Kho Điện Tử',N'59 P.2 Cách Mạng Tháng 8 Q.5 Tp.HCM','065165132','021651651','',N'pth@gmail.com',N'Phạm Thế Vinh',N'Quản lý',1),
						('K002',N'Kho Đồ Gia Dụng',N'512 P.2 Cách Mạng Tháng 8 Q.5 Tp.HCM','06212165','021651264','',N'nth@gmail.com',N'Nguyễn Thị Hồng',N'Quản lý',1),
						('K003',N'Kho Đồ Thủ Công',N'485 P.4 Cách Mạng Tháng 8 Q.3 Tp.HCM','062165416','032151212','',N'dtr@gmail.com',N'Đặng Thị Trân',N'Quản lý',1),
						('K004',N'Kho Thiết Bị Di Động',N'201 P.8 Cách Mạng Tháng 8 Q.5 Tp.HCM','031651651','0354512316','',N'pvt@gmail.com',N'Phan Văn Tài',N'Quản lý',1),
						('K005',N'Kho Mỹ Phẩm',N'121 P.11 Cách Mạng Tháng 8 Q.5 Tp.HCM','021561655','065121852','',N'nvd@gmail.com',N'Nguyễn Văn Đức',N'Quản lý',1),
						('K006',N'Kho Thực Phẩm',N'84 P.1 Cách Mạng Tháng 8 Q.5 Tp.HCM','0561516515','021512132','',N'dnt@gmail.com',N'Đặng Nguyên Tấn',N'Quản lý',1)

-- BANG NHOM HANG

insert into BANGNHOMHANG values('NH001',N'Điện Thoại','',1),
								('NH002',N'Son','',1),
								('NH003',N'Tủ Lạnh','',1),
								('NH004',N'Laptop','',1),
								('NH005',N'Nước Hoa','',1),
								('NH006',N'Hoa Quả','',1),
								('NH007',N'Gạo','',1),
								('NH008',N'Nồi Cơm Điện','',1)

-- BANG DON VI

insert into BANGDONVI values ('Tan',N'Tấn','',1),
								('Ta',N'Tạ','',1),
								('Yen',N'Yến','',1),
								('kg',N'Kilôgram','',1),
								('cai',N'Cái','',1),
								('g',N'Gram','',1),
								('lo',N'Lọ','',1)

--Hàng Hóa

insert into HANGHOA values	(1,0,'K004','NH001','HH00001',N'Samsung Galaxy S8','HH00001','cai',N'Mỹ',10,1000,Null,'NPP004',12000000,Null,Null),
							(1,0,'K005','NH005','HH00002',N'La Vie Est Belle','HH00002','lo',N'Pháp',5,500,Null,'NPP002',3000000,Null,Null),
							(1,0,'K001','NH003','HH00003',N'Tủ lạnh French Door','HH00003','cai',N'Hàn Quốc',15,400,Null,'NPP003',44000000,Null,Null),
							(1,0,'K002','NH008','HH00004',N'Nồi cơm điện Benny BR-19TV','HH00004','cai',N'Việt Nam',5,800,Null,'NPP001',580000,Null,Null)

-- BO PHAN
insert into BOPHAN values	('BP001',N'Đối Ngoại','',1),
							('BP002',N'Kinh Doanh','',1),
							('BP003',N'Bán Hàng','',1),
							('BP004',N'Di Chuyển Hàng Hóa','',1),
							('BP005',N'Marketing','',1),
							('BP006',N'Quản Lý Hàng Hóa','',1),
							('BP007',N'Bảo Trì Hàng Hóa','',1),
							('BP008',N'Quản Lý Sổ Sách','',1)

-------------------------------
-- NHAN VIEN
insert into nhanvien values('NV001',0,1,N'Nguyễn Như Nhựt',N'Nhân Viên',N'158 P.5 Nguyễn Thị Minh Khai Q.3 Tp.HCM','0927345678','','NNN@gmail.com','','BP002',N'Phạm Thế Hiển'),
							('NV002',0,1,N'Ngô Thanh Tuyền',N'Nhân Viên',N'32 P.2 Nguyễn Thị Minh Khai Q.3 Tp.HCM','0921651651','','NTT@gmail.com','','BP005',N'Phan Văn Đức'),
							('NV003',0,1,N'Phan Thị Hồng',N'Nhân Viên',N'68 P.8 Nguyễn Thị Minh Khai Q.3 Tp.HCM','05123216512','','PTH@gmail.com','','BP004',N'Phạm Thu Thủy'),
							('NV004',0,1,N'Đặng Xuân Bách',N'Nhân Viên',N'215 P.4 Nguyễn Thị Minh Khai Q.3 Tp.HCM','0684235162','','DXB@gmail.com','','BP001',N'Đặng Song Thái'),
							('NV005',0,1,N'Phạm Văn Quang',N'Nhân Viên',N'298 P.12 Nguyễn Thị Minh Khai Q.3 Tp.HCM','0321654651','','PVQ@gmail.com','','BP007',N'Nguyễn Thị Cẩm'),
							('NV006',0,1,N'Nguyễn Thế Ân',N'Nhân Viên',N'112 P.1 Nguyễn Thị Minh Khai Q.3 Tp.HCM','098423512','','NTA@gmail.com','','BP006',N'Đào Kim Loan')


-- HOADON
insert into hoadon values('HD00001','KH0001',950000000,10,5,'23/07/2006','')
insert into hoadon values('HD00002','KH0001',1200000000,10,5,'12/08/2006','')
insert into hoadon values('HD00003','KH0001',321000000,10,5,'23/08/2006','')
insert into hoadon values('HD00004','KH0001',5120000000,10,5,'01/09/2006','')
insert into hoadon values('HD00005','KH0001',820000000,10,5,'20/10/2006','')
insert into hoadon values('HD00006','KH0002',680000000,10,5,'16/10/2006','')
insert into hoadon values('HD00007','KH0002',5300000000,10,5,'28/10/2006','')
insert into hoadon values('HD00008','KH0002',4230000000,10,5,'28/10/2006','')
insert into hoadon values('HD00009','KH0002',3310000000,10,5,'28/10/2006','')
insert into hoadon values('HD00010','KH0002',5000000000,10,5,'01/11/2006','')
insert into hoadon values('HD00011','KH0003',621000000,10,5,'04/11/2006','')
insert into hoadon values('HD00012','KH0003',2800000000,10,5,'30/11/2006','')
insert into hoadon values('HD00013','KH0003',1350000000,10,5,'12/12/2006','')
insert into hoadon values('HD00014','KH0003',503000000,10,5,'31/12/2006','')
insert into hoadon values('HD00015','KH0003',2560000000,10,5,'01/01/2007','')
-------------------------------
-- CTHD
insert into cthd values('HD00001','HH00001',10)
insert into cthd values('HD00001','HH00002',5)
insert into cthd values('HD00001','HH00003',10)
insert into cthd values('HD00002','HH00001',20)
insert into cthd values('HD00002','HH00003',20)
insert into cthd values('HD00002','HH00002',20)
insert into cthd values('HD00003','HH00001',10)
insert into cthd values('HD00004','HH00001',20)
insert into cthd values('HD00004','HH00002',10)
insert into cthd values('HD00005','HH00003',50)
insert into cthd values('HD00006','HH00002',20)
insert into cthd values('HD00006','HH00001',30)
insert into cthd values('HD00008','HH00001',8)
insert into cthd values('HD00009','HH00002',10)
insert into cthd values('HD00010','HH00003',50)
insert into cthd values('HD00010','HH00001',50)
insert into cthd values('HD00010','HH00002',100)
insert into cthd values('HD00011','HH00003',50)
insert into cthd values('HD00012','HH00001',3)
insert into cthd values('HD00013','HH00002',5)
insert into cthd values('HD00014','HH00003',80)
insert into cthd values('HD00014','HH00001',100)
insert into cthd values('HD00014','HH00002',60)
insert into cthd values('HD00015','HH00002',30)
insert into cthd values('HD00015','HH00003',7)
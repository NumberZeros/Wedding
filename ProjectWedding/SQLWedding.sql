create database QuanLyTiecCuoi
use QuanLyTiecCuoi
set dateformat mdy
create table SANH
(
	MaSanh int identity primary key,
	TenSanh varchar(100),
	LoaiSanh varchar(100),
	SoLuongMax int,
	DonGiaMin int,
	GhiChu varchar(100),
)

create table KHACHHANG
(
	MaKH int identity primary key,
	TenCR varchar(100),
	TenCD varchar(100),
	SoDienThoai int,
)
create table DATTIEC
(
	MaDT int identity primary key,
	NgayDT datetime2 (7),
	Ca int,
	TienDC int,
	SLBan int,
	MaSanh int,
	FOREIGN KEY (MaSanh) REFERENCES SANH(MaSanh),
	SoBanDuTru int
)

create table HOADON
(
	MaHD int identity primary key,
	MaKH int,
	FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MAKH),
	MaMenu int,
	NgayThanhToan datetime2 (7)
)
create table MENU
(
	MaMenu int identity primary key,
	Ten varchar(100),
	DonGia money,
	MaHD int,
	FOREIGN KEY (MaHD) REFERENCES HOADON(MAHD),
	GhiChu varchar(100)
)
create table QUIDINH
(
	MaQD int identity primary key,
	TenQD varchar(100),
	Phat varchar(100)
)


ALTER TABLE HOADON ADD CONSTRAINT FK_MENU
 FOREIGN KEY (MaMenu) REFERENCES MENU(MaMenu)
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
	GhiChu varchar(100)
)

create table DATTIEC
(
	MaDT int identity primary key,
	NgayDT datetime2 (7),
	Ca int,
	TienDC int,
	SLBan int,
	MaCTDT int,
	SoBanDuTru int
)

create table CTDT
(
	MaCTDT int primary key,
)

create table KHACHHANG
(
	MaKH int identity primary key,
	TenCR varchar(100),
	TenCD varchar(100),
	SoDienThoai int,
)

create table HOADON
(
	MaHD int identity primary key,
	NgayThanhToan datetime2 (7)
)

create table Menu
(
	MaMenu int identity primary key,
	Ten varchar(100),
	DonGia money,
	GhiChu varchar(100),
	MaHD int,
	FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD) on update cascade,
)


alter table dattiec add CONSTRAINT FK_CTDT
 FOREIGN KEY (MaCTDT) REFERENCES CTDT(MaCTDT) on update cascade

 alter table dattiec add MaKH int

 alter table dattiec add CONSTRAINT FK_KhacHang
 FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH) on update cascade

 alter table dattiec add MaKH int

 alter table khachhang add MaHD int
 alter table KHACHHANG add CONSTRAINT FK_HOADON
 FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD) on update cascade

create table QUIDINH
(
	MaQD int identity primary key,
	TenQD varchar(100),
	Phat varchar(100)
)

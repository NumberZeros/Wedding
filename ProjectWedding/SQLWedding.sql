create database QuanLyTiecCuoi
use QuanLyTiecCuoi
set dateformat mdy
create table SANH
(
	MaSanh int identity primary key,
	TenSanh varchar(100),
	LoaiSanh int,
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
	NgayDT datetime,
	Ca int,
	TienDC money,
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
	NgayThanhToan datetime
)
create table Menu
(
	MaMenu int identity primary key,
	Ten varchar(100),
	DonGia money,
	MaHD int,
	FOREIGN KEY (MaHD) REFERENCES HOADON(MAHD),
	GhiChu varchar(100)
)
create table QuiDinh
(
	MaQD int identity primary key,
	TenQD varchar(100),
	Phat varchar(100)
)

alter table KHACHHANG ADD MaDT int 
alter table KHACHHANG ADD constraint fk_dattiec foreign key (MaDT) references DATTIEC(MaDT)
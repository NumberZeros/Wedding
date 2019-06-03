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
	NgayDT datetime,
	Ca int,
	TienDC int,
	SLBan int,
	SoBanDuTru int,
	MaSanh int,
	foreign key (MaSanh) references SANH(MaSanh) on update cascade
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
	NgayThanhToan datetime
)

create table Menu
(
	MaMenu int primary key,
	Ten varchar(100),
	DonGia money,
	GhiChu varchar(100),
	MaHD int,
	FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD) on update cascade,
)

-- thêm khóa ngoại MaHK cho bảng DATTIEC
 alter table dattiec add MaKH int
 alter table dattiec add CONSTRAINT FK_KhacHang
 FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH) on update cascade

 -- thêm khóa ngoại MaHD cho bảng KHACHHANG
 alter table khachhang add MaHD int
 alter table KHACHHANG add CONSTRAINT FK_MaHD
 FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD) on update cascade
 alter table khachhang drop FK_MaHD
 alter table khachhang drop column MaHD


 -- thêm khóa ngoại MaSanh cho bảng HOADON
 alter table HOADON add MaSanh int
 alter table HOADON add CONSTRAINT FK_MaSanh_HoaDon
 FOREIGN KEY (MaSanh) REFERENCES SANH(MaSanh) 
 alter table hoadon add maKH int
 alter table hoadon add constraint FK_MaKH_HoaDon
 foreign key (MaKH) references khachhang(MaKH)



create table QUIDINH
(
	MaQD int identity primary key,
	TenQD varchar(100),
	Phat varchar(100)
)




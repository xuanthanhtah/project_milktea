Create DATABASE QLTraSuaUwU
USE QLTraSuaUwU

GO
--Tạo bảng bàn
CREATE TABLE [BAN](
MaBan nvarchar(10) NOT NULL,
[TrangThai] nvarchar(20) NULL,
Primary Key (MaBan)
)
GO
--Tạo bảng chức vụ
CREATE TABLE CHUCVU(
MaChucVu char(10) ,
TenChucVu [nvarchar](40) NULL,
PRIMARY KEY (MaChucVu),
)

go
--Tạo bảng khách hàng
CREATE TABLE KHACHHANG(
MaKhachHang char(7),
Hoten [nvarchar](50) NULL,
GioiTinh [nvarchar](5) NULL,
SDT char(15) null,
primary key(MaKhachHang)
)
GO
--Tạo bảng hóa đơn
CREATE TABLE HOADON(
MaHoaDon char(10) ,
MaKhachHang char(7) ,
MANV int,
MaBan nvarchar(10) NOT NULL,
NgayXuatHoaDon datetime,
Tongtien bigint
PRIMARY KEY(MaHoaDon),
)


GO
CREATE TABLE CTHD(
MaHoaDon char(10) ,
MaMonAn char(10),
TenMonAn nvarchar(50),
Soluong int ,
DonGia bigint NULL ,
primary key(MaHoaDon,MaMonAn)
)


GO
--Tạo bảng Phiếu menu
CREATE TABLE MENU(
MaMonAn char(10) ,
TenMonAn nvarchar(50) ,
MoTa nvarchar(25) NULL,
DonGia bigint NULL,
MANV int,
PRIMARY KEY(MaMonAn)
)

GO
--Tạo bảng nhân viên
CREATE TABLE NHANVIEN(
MANV int identity(1,1),
HoTen nvarchar(50) NULL,
SDT char(15) null,
DiaCHi nvarchar(50) NULL,
NamSinh date NULL,
GioiTinh [nvarchar](5) NULL,
MaChucVu char(10) ,
TaiKhoan nvarchar(50) NOT NULL,
MatKhau char(50) NOT NULL,
PRIMARY KEY(MANV)
)

----Tạo bảng tài khoản
--create TABLE TAIKHOAN (
--iDTaiKhoan int identity(1,1) PRIMARY KEY,
--TaiKhoan nvarchar(50) NOT NULL,
--MatKhau char(50) NOT NULL,
--)
--Tạo khoá ngoại
GO
Alter table MENU add  foreign key(MANV) references NHANVIEN (MANV)  on update no action on delete no action 
--
go
Alter table HOADON add  foreign key(MANV) references NHANVIEN (MANV)  on update no action on delete no action 
ALTER TABLE HOADON ADD FOREIGN KEY (MaBan) references BAN (MaBan) on update no action on delete no action 
alter table HOADON Add  foreign key(MaKhachHang) references KHACHHANG (MaKhachHang)on update no action on delete no action
--
Alter table NHANVIEN add  foreign key(MaChucVu) references CHUCVU (MaChucVu)  on update no action on delete no action 
go
--
ALTER TABLE CTHD ADD FOREIGN KEY (MaHoaDon) references HOADON (MaHoaDon )on update no action on delete no action
ALTER TABLE CTHD ADD FOREIGN KEY (MaMonAn) references MENU (MaMonAn )on update no action on delete no action
go 
-----Nhap lieu
--insert into TAIKHOAN ( TaiKhoan, MatKhau)
--values('admin', '202cb962ac59075b964b07152d234b70')
--insert into TAIKHOAN ( TaiKhoan, MatKhau)
--values('nhanvien', '202cb962ac59075b964b07152d234b70')

select *from KHACHHANG

insert into KHACHHANG values('KH1',N'Lê Xuân Thành', 'nam', '0399745742')
insert into KHACHHANG values('KH2',N'Nguyễn Văn Quang', 'nam', '012346589')
insert into KHACHHANG values('KH3',N'Đào Nhật Tín', 'nam', '0123456789')
insert into KHACHHANG values('KH4',N'Nguyễn Đình Hùng', 'nam', '01010101111')

select *from CHUCVU
insert into CHUCVU values('NV', N'Nhân Viên')
insert into CHUCVU values('QL', N'Quản lý')
insert into CHUCVU values('KH', N'Khách hàng')

select *from BAN
insert into BAN values(N'Bàn 1', N'ĐangSD')
insert into BAN values(N'Bàn 2', N'ChưaSD')
insert into BAN values(N'Bàn 3', N'ĐangSD')

set dateformat DMY 
select * from NHANVIEN
INSERT INTO NHANVIEN VALUES(N'Đào Nhật Tín','0334848999',N'Tuy AN, Phú Yên','12/04/2001','Nam','NV','nhattin','202cb962ac59075b964b07152d234b70')
INSERT INTO NHANVIEN VALUES(N'Lê Xuân Thành','039484888',N'Bình Thuận','3/9/2000','Nam','QL','xuanthanh','202cb962ac59075b964b07152d234b70')
INSERT INTO NHANVIEN VALUES(N'Nguyễn Văn Quang','039999999',N'Hà Nội','9/9/2001','Nam','NV','vanquang','202cb962ac59075b964b07152d234b70')
INSERT INTO NHANVIEN VALUES(N'Nguyễn Đình Hùng','0788484879',N'Hà Nội','10/4/2001','Nam','QL','dinhhung','202cb962ac59075b964b07152d234b70')
INSERT INTO NHANVIEN VALUES(N'Bạch Nhược Yên','0884854845',N'Tuy AN, Phú Yên','12/11/2001',N'Nữ','NV','nhuocyen','202cb962ac59075b964b07152d234b70')

insert into MENU values('CF1', 'Cafe đen đá', 'cafe', 15000,1 )
insert into MENU values('TS1', 'Trà sữa chân châu', 'trasua', 20000, 1)
insert into MENU values('NN1', 'Sting', 'nuocngot', 10000, 2)
insert into MENU values('NN2', 'Redbull', 'nuocngot', 15000, 3)

SELECT * FROM HOADON
SET DATEFORMAT DMY
INSERT INTO HOADON VALUES('HD1','KH1',1, N'Bàn 1','12/9/2021',30000)
INSERT INTO HOADON VALUES('HD2','KH3',1, N'Bàn 2','12/9/2021',15000)

select * from CTHD
INSERT INTO CTHD VALUES('HD1','CF1',N'Cafe đen đá',1,15000)
INSERT INTO CTHD VALUES('HD1','NN2','Redbull',1,15000)
INSERT INTO CTHD VALUES('HD2','NN2','Redbull',1,15000)

------------------------------------------------------------------------------------------------
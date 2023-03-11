use master
go
create database QuanLyCoffeOngBau
go

use QuanLyCoffeOngBau
go

create table nhanvien(
	sdt varchar(50) primary key,
	ten_nv nvarchar(100),
	gioitinh bit,
	chucvu nvarchar(50),
	ngayvaolam date,
	diachi nvarchar(100),
	phanquyen bit,
	trangthai bit,
	matkhau varchar(100),
)


create table loaikhachhang(
	ma_loaikh varchar(100) primary key,
	ten_loaikh nvarchar(100),
	giamgia int
)


create table khachhang(
	sdt varchar(50) primary key,
	ten_kh nvarchar(100),
	diemtl int,
	password varchar(50),
	ma_loaikh varchar(100),
	FOREIGN KEY (ma_loaikh) REFERENCES loaikhachhang(ma_loaikh)
)

create table khuvuc (
	makhuvuc varchar(100) primary key,
	tenkhuvuc nvarchar(100),
	trangthai varchar(100)
)

create table ban(
	maban varchar(100) primary key,
	tenban nvarchar(100),
	makhuvuc varchar(100),
	thuoctinh varchar(100),
	FOREIGN KEY (makhuvuc) REFERENCES khuvuc(makhuvuc)
)

create table nhacungcap(
	sdt varchar(100) primary key,
	ten_nhacungcap nvarchar(100),
	diachi nvarchar(100)
)

create table loaihanghoa(
ma_loaihoang varchar(100) primary key,
tenloaihang nvarchar(100),
mota nvarchar(254)
)

create table hanghoa(
	ma_hanghoa varchar(100) primary key,
	ten_hanghoa nvarchar(100),
	ma_loaihoang varchar(100),
	hinh_anh varchar(254),
	sdt_ncc varchar(100) ,
	soluong int,
	giasp int,
	FOREIGN KEY (ma_loaihoang) REFERENCES loaihanghoa(ma_loaihoang),
	FOREIGN KEY (sdt_ncc) REFERENCES nhacungcap(sdt)
)

create table  calamviec(
	ma_clv varchar(50) primary key,
	ten_clv nvarchar(100),
	gio_BD time,
	gio_kt time,
	sotien int
)

create table hoadonbanhang(
	ma_hd_bh varchar(50) primary key,
	sdt_nv varchar(50),
	sdt_kh varchar(50),
	maban varchar(100),
	ngay_hd_bh date,
	tongtien int,
	diemtl int,
	giagiam int,
	chiphikhac int,
	trangthai nvarchar(100),
	FOREIGN KEY (sdt_nv) REFERENCES nhanvien(sdt),
	FOREIGN KEY (sdt_kh) REFERENCES khachhang(sdt)
)

create table chitietbanhang(
	ma_hd_bh varchar(50),
	ma_hanghoa varchar(100),
	soluong int,
	primary key(ma_hd_bh,ma_hanghoa),
	FOREIGN KEY (ma_hd_bh) REFERENCES hoadonbanhang(ma_hd_bh),
	FOREIGN KEY (ma_hanghoa) REFERENCES hanghoa(ma_hanghoa)
)

create table chitietluongnhanvien (
	ma_clv varchar(50),
	sdt_nv varchar(50),
	tongcalamtrongthang int,
	thanhtien int,
	kyluong nvarchar(100),
	primary key (ma_clv, sdt_nv),
	FOREIGN KEY (ma_clv) REFERENCES calamviec(ma_clv),
	FOREIGN KEY (sdt_nv) REFERENCES nhanvien(sdt)
	
)



create table hoadonnhaphang(
	ma_hd_nh varchar(50) primary key,
	sdt_nv varchar(50),
	sdt_ncc varchar(50),
	ngayhdnh date,
	thanhtien int
)

create table chitietnhaphanghoa(
	ma_hd_nh varchar(50),
	ma_hanghoa varchar(100),
	soluong int,
	thanhtien int
	primary key(ma_hd_nh,ma_hanghoa),
	FOREIGN KEY (ma_hd_nh) REFERENCES hoadonnhaphang(ma_hd_nh),
	FOREIGN KEY (ma_hanghoa) REFERENCES hanghoa(ma_hanghoa)
)

go

CREATE PROCEDURE usp_Login_KHACHHANG
(
@sdt NVARCHAR(50),  @pass NVARCHAR(50)
)
AS
BEGIN
SET NOCOUNT ON;
SELECT  *
FROM khachhang
WHERE sdt=@sdt AND password=@pass
end

go

CREATE PROCEDURE usp_Login_NhanVien
(
@sdt NVARCHAR(50),  @pass NVARCHAR(50)
)
AS
BEGIN
SET NOCOUNT ON;
SELECT  *
FROM nhanvien
WHERE sdt=@sdt AND matkhau=@pass
end

select * from Khachhang
select * from loaikhachhang
exec usp_Login_KHACHHANG @sdt = '123', @pass = '123'
go

CREATE PROCEDURE insert_khachhang
(
	 @p_sdt VARCHAR(50),
     @p_ten_kh NVARCHAR(100),
     @p_diemtl INT,
     @p_password VARCHAR(50),
     @p_ma_loaikh VARCHAR(100)
)
AS
BEGIN
	if exists ( SELECT * FROM khachhang WHERE sdt = @p_sdt)
	BEGIN
		select 'failed' stt
	end
	else
	begin
		INSERT INTO khachhang (sdt, ten_kh, diemtl, password, ma_loaikh)
		VALUES (@p_sdt, @p_ten_kh, @p_diemtl, @p_password, @p_ma_loaikh);
		select 'done' stt
	end
end

go



select * from khachhang


exec insert_khachhang @p_sdt = '333', 
@p_ten_kh = '123', @p_diemtl= 2,
@p_password = '212', @p_ma_loaikh='1'
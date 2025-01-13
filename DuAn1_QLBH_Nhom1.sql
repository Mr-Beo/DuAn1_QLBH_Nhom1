CREATE DATABASE DuAn1_QLBH_Nhom1
USE DuAn1_QLBH_Nhom1
-- Tạo bảng ChucVu
CREATE TABLE ChucVu (
    ID_ChucVu INT PRIMARY KEY,
    TenChucVu NVARCHAR(100) NOT NULL
);

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    ID_NhanVien INT PRIMARY KEY,
    ID_ChucVu INT,
    TenNhanVien NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    DiaChi NVARCHAR(255),
    Email NVARCHAR(100),
    SoDienThoai NVARCHAR(20),
    GioiTinh NVARCHAR(10),
    TaiKhoan NVARCHAR(50),
    MatKhau NVARCHAR(50),
    FOREIGN KEY (ID_ChucVu) REFERENCES ChucVu(ID_ChucVu)
);

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    ID_KhachHang INT PRIMARY KEY,
    Ten_KhachHang NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    SoDienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255)
);

-- Tạo bảng HoaDon
CREATE TABLE HoaDon (
    ID_MaHD INT PRIMARY KEY,
    ID_NhanVien INT,
    ID_KhachHang INT,
    ID_HoaDonChiTiet INT,
    MaGiamGia INT,
    ThanhTien DECIMAL(18, 2),
    NgayTao DATE,
    FOREIGN KEY (ID_NhanVien) REFERENCES NhanVien(ID_NhanVien),
    FOREIGN KEY (ID_KhachHang) REFERENCES KhachHang(ID_KhachHang),
    FOREIGN KEY (MaGiamGia) REFERENCES GiamGia(MaGiamGia)
);

-- Tạo bảng HoaDonChiTiet
CREATE TABLE HoaDonChiTiet (
    ID_HoaDonChiTiet INT PRIMARY KEY,
    ID_SanPhamChiTiet INT,
    ID_MaHD INT,
    ThanhTien DECIMAL(18, 2),
    SoLuongMua INT,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (ID_SanPhamChiTiet) REFERENCES SanPhamChiTiet(ID_SanPhamChiTiet),
    FOREIGN KEY (ID_MaHD) REFERENCES HoaDon(ID_MaHD)
);

-- Tạo bảng GiamGia
CREATE TABLE GiamGia (
    MaGiamGia INT PRIMARY KEY,
    PhamTramGiam DECIMAL(5, 2),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    MoTa NVARCHAR(255),
    SoLuong INT
);

-- Tạo bảng SanPham
CREATE TABLE SanPham (
    MaSanPham INT PRIMARY KEY,
    TenSanPham NVARCHAR(100) NOT NULL,
    TrangThai NVARCHAR(50),
    KieuLoai NVARCHAR(50),
    MaThuongHieu INT,
    FOREIGN KEY (MaThuongHieu) REFERENCES ThuongHieu(MaThuongHieu)
);

-- Tạo bảng SanPhamChiTiet
CREATE TABLE SanPhamChiTiet (
    ID_SanPhamChiTiet INT PRIMARY KEY,
    MaSanPham INT,
    MaSize INT,
    ChatLieu INT,
    MaMau INT,
    SoLuong INT,
    GiaBan DECIMAL(18, 2),
    HinhAnh NVARCHAR(255),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham),
    FOREIGN KEY (MaSize) REFERENCES Size(MaSize),
    FOREIGN KEY (ChatLieu) REFERENCES ChatLieu(ChatLieu),
    FOREIGN KEY (MaMau) REFERENCES MauSac(MaMau)
);

-- Tạo bảng ThuongHieu
CREATE TABLE ThuongHieu (
    MaThuongHieu INT PRIMARY KEY,
    TenThuongHieu NVARCHAR(100) NOT NULL,
    NamSanXuat INT,
    MoTa NVARCHAR(255)
);

-- Tạo bảng Size
CREATE TABLE Size (
    MaSize INT PRIMARY KEY,
    TenSize NVARCHAR(50) NOT NULL,
    MoTa NVARCHAR(255)
);

-- Tạo bảng ChatLieu
CREATE TABLE ChatLieu (
    ChatLieu INT PRIMARY KEY,
    TenChatLieu NVARCHAR(100) NOT NULL,
    MoTa NVARCHAR(255)
);

-- Tạo bảng MauSac
CREATE TABLE MauSac (
    MaMau INT PRIMARY KEY,
    TenMau NVARCHAR(50) NOT NULL
);
INSERT INTO ChucVu (ID_ChucVu,TenChucVu)
VALUES
(1,N'Quản Lý'),
(2,N'Nhân Viên'),
(3,N'Nhân Viên')
SELECT * FROM ChucVu
INSERT INTO NhanVien (ID_NhanVien,ID_ChucVu,TenNhanVien,NgaySinh,DiaChi,Email,SoDienThoai,GioiTinh,TaiKhoan,MatKhau)
VALUES 
(1,1,N'Lê Việt Hoàng','2004-09-24',N'Lào Cai','hoang240904@gmail.com','0899818886',N'Nam','hoang','123'),
(2,2,N'Nguyễn Khánh Chi','2004-09-02',N'Lào Cai','chi020904@gmail.com','0899818888',N'Nữ','chi','123'),
(3,3,N'Dương Văn Kha','2004-09-10',N'Bắc Giang','kha100904@gmail.com','0899818889',N'Nam','kha','123')
SELECT * FROM NhanVien
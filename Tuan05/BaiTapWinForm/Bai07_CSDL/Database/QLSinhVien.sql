-- Cơ sở dữ liệu mẫu dùng cho Bài 7: Lập trình tương tác cơ sở dữ liệu
-- Chạy file này trong SQL Server Management Studio trước khi mở các form của Bài 7

CREATE DATABASE QLSinhVien
GO

USE QLSinhVien
GO

CREATE TABLE Khoa
(
    MaKhoa  VARCHAR(10)   NOT NULL PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Lop
(
    MaLop  VARCHAR(10)   NOT NULL PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL,
    MaKhoa VARCHAR(10)   NOT NULL,
    CONSTRAINT FK_Lop_Khoa FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
)
GO

CREATE TABLE SinhVien
(
    MaSinhVien VARCHAR(10)   NOT NULL PRIMARY KEY,
    HoTen      NVARCHAR(100) NOT NULL,
    NgaySinh   DATE          NULL,
    MaLop      VARCHAR(10)   NOT NULL,
    CONSTRAINT FK_SinhVien_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
)
GO

CREATE TABLE MonHoc
(
    MaMonHoc  VARCHAR(10)   NOT NULL PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Diem
(
    MaSinhVien VARCHAR(10) NOT NULL,
    MaMonHoc   VARCHAR(10) NOT NULL,
    Diem       FLOAT       NULL,
    CONSTRAINT PK_Diem PRIMARY KEY (MaSinhVien, MaMonHoc),
    CONSTRAINT FK_Diem_SinhVien FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien),
    CONSTRAINT FK_Diem_MonHoc FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc)
)
GO

-- Dữ liệu mẫu (mỗi bảng ít nhất 5 mẫu tin)
INSERT INTO Khoa VALUES ('CNTT', N'Công nghệ thông tin')
INSERT INTO Khoa VALUES ('CNTP', N'Công nghệ thực phẩm')
INSERT INTO Khoa VALUES ('QTKD', N'Quản trị kinh doanh')
INSERT INTO Khoa VALUES ('TCKT', N'Tài chính kế toán')
INSERT INTO Khoa VALUES ('NN', N'Ngoại ngữ')
GO

INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('05DHTH1', N'Đại học Tin học 1 khóa 05', 'CNTT')
INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('05DHTH2', N'Đại học Tin học 2 khóa 05', 'CNTT')
INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('05DHTP1', N'Đại học Thực phẩm 1 khóa 05', 'CNTP')
INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('05DHQT1', N'Đại học Quản trị 1 khóa 05', 'QTKD')
INSERT INTO Lop (MaLop, TenLop, MaKhoa) VALUES ('05DHKT1', N'Đại học Kế toán 1 khóa 05', 'TCKT')
GO

INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES ('2001140001', N'Nguyễn Văn An', '1996-03-15', '05DHTH1')
INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES ('2001140002', N'Trần Thị Bình', '1996-07-21', '05DHTH1')
INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES ('2001140003', N'Lê Quang Cường', '1996-11-02', '05DHTH2')
INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES ('2005140004', N'Phạm Ngọc Dung', '1996-01-30', '05DHTP1')
INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, MaLop) VALUES ('2013140005', N'Hồ Bảo Khánh', '1996-09-09', '05DHQT1')
GO

INSERT INTO MonHoc VALUES ('CSDL', N'Cơ sở dữ liệu')
INSERT INTO MonHoc VALUES ('LTNET', N'Lập trình .NET')
INSERT INTO MonHoc VALUES ('CTDL', N'Cấu trúc dữ liệu và giải thuật')
INSERT INTO MonHoc VALUES ('MMT', N'Mạng máy tính')
INSERT INTO MonHoc VALUES ('TRR', N'Toán rời rạc')
GO

INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('2001140001', 'CSDL', 8)
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('2001140001', 'LTNET', 7.5)
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('2001140002', 'CSDL', 6)
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('2001140003', 'CTDL', 9)
INSERT INTO Diem (MaSinhVien, MaMonHoc, Diem) VALUES ('2005140004', 'TRR', 5.5)
GO

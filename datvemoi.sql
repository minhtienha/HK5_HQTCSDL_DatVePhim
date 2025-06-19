Create Database QuanLy_RapChieuPhim
USE QuanLy_RapChieuPhim

CREATE TABLE THELOAI(
MATL NVARCHAR(20),
TENTHELOAI NVARCHAR(100),
CONSTRAINT PK_TL PRIMARY KEY (MATL)
);

CREATE TABLE PHIM(
MAPHIM NVARCHAR(20),
TENPHIM NVARCHAR(200),
THOILUONG FLOAT CHECK (THOILUONG > 0),
NGAYPHATHANH DATE,
CONSTRAINT PK_PHIM PRIMARY KEY (MAPHIM)
);

CREATE TABLE PHIM_THELOAI(
MAPHIM NVARCHAR(20),
MATL NVARCHAR(20),
PRIMARY KEY (MAPHIM, MATL),
CONSTRAINT FK_TLP1 FOREIGN KEY (MAPHIM) REFERENCES PHIM(MAPHIM),
CONSTRAINT FK_TLP2 FOREIGN KEY (MATL) REFERENCES THELOAI(MATL)
);

CREATE TABLE PHONG(
MAPHONG NVARCHAR(20),
TENPHONG NVARCHAR(50),
SOCHONGOI INT CHECK (SOCHONGOI > 0),
CONSTRAINT PK_PHONG PRIMARY KEY (MAPHONG)
);

CREATE TABLE SUATCHIEU(
MASC NVARCHAR(20),
MAPHIM NVARCHAR(20),
MAPHONG NVARCHAR(20),
NGAYCHIEU DATE,
THOIGIANBD TIME,
THOIGIANKT TIME,
CONSTRAINT PK_SC PRIMARY KEY (MASC),
CONSTRAINT FK_SC1 FOREIGN KEY (MAPHIM) REFERENCES PHIM(MAPHIM),
CONSTRAINT FK_SC2 FOREIGN KEY (MAPHONG) REFERENCES PHONG(MAPHONG)
);

CREATE TABLE NHANVIEN(
MANV NVARCHAR(20),
TENNV NVARCHAR(100),
TENDN NVARCHAR(50) UNIQUE,
SODT CHAR(10) NOT NULL UNIQUE,
MATKHAU NVARCHAR(50),
GIOITINH NVARCHAR(5) CHECK (GIOITINH IN (N'Nam', N'Nữ', N'Khác')),
VAITRO NVARCHAR(50),
NGAYBD_LAMVIEC DATE,
CONSTRAINT PK_NV PRIMARY KEY (MANV)
);

CREATE TABLE TAIKHOAN (
MATK NVARCHAR(20) PRIMARY KEY,
MANV NVARCHAR(20) UNIQUE,
TENDN NVARCHAR(50) UNIQUE,
SODT CHAR(10) UNIQUE,
MATKHAU NVARCHAR(50),
VAITRO NVARCHAR(50),
CONSTRAINT FK_TK_NV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

CREATE TABLE HOADON(
MAHD NVARCHAR(20),
MANV NVARCHAR(20),
NGAYLAP DATE DEFAULT GETDATE(),
THANHTIEN FLOAT CHECK (THANHTIEN >= 0),
CONSTRAINT PK_HD PRIMARY KEY (MAHD),
CONSTRAINT FK_HD2 FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
);

CREATE TABLE VE(
MAVE NVARCHAR(20),
MASUATCHIEU NVARCHAR(20),
MAHD NVARCHAR(20),
TENGHE NVARCHAR(10),
GIAGHE FLOAT CHECK (GIAGHE > 0),
CONSTRAINT PK_VE PRIMARY KEY (MAVE),
CONSTRAINT FK_VE FOREIGN KEY (MASUATCHIEU) REFERENCES SUATCHIEU(MASC),
CONSTRAINT FK_VE2 FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)
);

CREATE TABLE THUCPHAM(
MATP NVARCHAR(5),
TENTP NVARCHAR(100),
GIATP FLOAT CHECK (GIATP > 0),
SOLUONG INT CHECK (SOLUONG >= 0),
CONSTRAINT PK_TP PRIMARY KEY (MATP)
);

CREATE TABLE CHITIETHD_TP(
MAHD NVARCHAR(20),
MATP NVARCHAR(5),
SOLUONG INT CHECK (SOLUONG > 0),
TONGGIATP FLOAT CHECK (TONGGIATP >= 0),
CONSTRAINT FK_CTTP1 FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD),
CONSTRAINT FK_CTTP2 FOREIGN KEY (MATP) REFERENCES THUCPHAM(MATP)
);



------------------------------------ Nhập dữ liệu ------------------------------------
SET DATEFORMAT dmy;
INSERT INTO THELOAI (MATL, TENTHELOAI)
VALUES
('TL01', N'Hành động'),
('TL02', N'Tình cảm'),
('TL03', N'Kinh dị'),
('TL04', N'Hoạt hình'),
('TL05', N'Phiêu lưu'),
('TL06', N'Hài');

INSERT INTO PHIM (MAPHIM, TENPHIM, THOILUONG, NGAYPHATHANH)
VALUES
('P001', N'CƯỜI XUYÊN BIÊN GIỚI', 113, '15/11/2024'),
('P002', N'VÕ SĨ GIÁC ĐẤU II', 148, '15/11/2024'),
('P003', N'LINH MIÊU', 109, '22/11/2024'),
('P004', N'ĐÔI BẠN HỌC YÊU', 118, '08/11/2024'),
('P005', N'VENOM: KÈO CUỐI', 110, '25/10/2024');

INSERT INTO PHIM_THELOAI (MAPHIM, MATL)
VALUES
('P001', 'TL06'),
('P002', 'TL01'),
('P002', 'TL05'),
('P003', 'TL03'),
('P004', 'TL02'),
('P004', 'TL06'),
('P005', 'TL01'),
('P005', 'TL05');

INSERT INTO PHONG (MAPHONG, TENPHONG, SOCHONGOI)
VALUES
('P01', N'Phòng 1', 30),
('P02', N'Phòng 2', 30),
('P03', N'Phòng 3', 30),
('P04', N'Phòng 4', 30);

-- Nhập dữ liệu cho SUATCHIEU
INSERT INTO SUATCHIEU (MASC, MAPHIM, MAPHONG, NGAYCHIEU, THOIGIANBD, THOIGIANKT)
VALUES
-- Suất chiếu cho phim 'CƯỜI XUYÊN BIÊN GIỚI'
('SC001', 'P001', 'P01', '01/12/2024', '10:00:00', '12:00:00'),
('SC002', 'P001', 'P02', '01/12/2024', '14:00:00', '16:00:00'),
('SC003', 'P001', 'P03', '01/12/2024', '18:00:00', '20:00:00'),

-- Suất chiếu cho phim 'VÕ SĨ GIÁC ĐẤU II'
('SC004', 'P002', 'P01', '02/12/2024', '10:00:00', '12:30:00'),
('SC005', 'P002', 'P02', '02/12/2024', '13:00:00', '15:30:00'),
('SC006', 'P002', 'P03', '02/12/2024', '18:00:00', '20:30:00'),

-- Suất chiếu cho phim 'LINH MIÊU'
('SC007', 'P003', 'P01', '03/12/2024', '10:00:00', '11:50:00'),
('SC008', 'P003', 'P02', '03/12/2024', '14:00:00', '15:50:00'),
('SC009', 'P003', 'P04', '03/12/2024', '18:00:00', '19:50:00'),

-- Suất chiếu cho phim 'ĐÔI BẠN HỌC YÊU'
('SC010', 'P004', 'P01', '04/12/2024', '12:00:00', '14:00:00'),
('SC011', 'P004', 'P03', '04/12/2024', '16:00:00', '18:00:00'),
('SC012', 'P004', 'P04', '04/12/2024', '20:00:00', '22:00:00'),

-- Suất chiếu cho phim 'VENOM: KÈO CUỐI'
('SC013', 'P005', 'P02', '05/12/2024', '11:00:00', '13:00:00'),
('SC014', 'P005', 'P04', '05/12/2024', '14:30:00', '16:30:00'),
('SC015', 'P005', 'P01', '05/12/2024', '18:00:00', '20:00:00'),

-- Suất chiếu cho ngày 12/12/2024
('SC016', 'P001', 'P01', '12/12/2024', '10:00:00', '12:00:00'),
('SC017', 'P001', 'P02', '12/12/2024', '12:30:00', '14:30:00'),

-- Suất chiếu cho phim 'VÕ SĨ GIÁC ĐẤU II'
('SC018', 'P002', 'P03', '12/12/2024', '15:00:00', '17:30:00'),
('SC019', 'P002', 'P01', '12/12/2024', '18:00:00', '20:30:00'),

-- Suất chiếu cho phim 'LINH MIÊU'
('SC020', 'P003', 'P02', '12/12/2024', '11:00:00', '12:50:00'),
('SC021', 'P003', 'P04', '12/12/2024', '14:00:00', '15:50:00'),

-- Suất chiếu cho phim 'ĐÔI BẠN HỌC YÊU'
('SC022', 'P004', 'P03', '12/12/2024', '16:00:00', '18:00:00'),
('SC023', 'P004', 'P01', '12/12/2024', '18:30:00', '20:30:00'),

-- Suất chiếu cho phim 'VENOM: KÈO CUỐI'
('SC024', 'P005', 'P04', '12/12/2024', '13:00:00', '15:00:00'),
('SC025', 'P005', 'P02', '12/12/2024', '16:00:00', '18:00:00');


INSERT INTO NHANVIEN (MANV, TENNV, TENDN, SODT, MATKHAU, GIOITINH, VAITRO, NGAYBD_LAMVIEC)
VALUES
('NV001', N'Lê Quang D', 'lequangd', '0922334455', '123456', N'Nam', N'Quản lý', '01/01/2020'),
('NV002', N'Phan Thi E', 'phanthie', '0988776655', '123456', N'Nữ', N'Nhân viên bán vé', '15/06/2021'),
('NV003', N'Nguyễn Thị F', 'nguyenthif', '0912345678', '123456', N'Nữ', N'Nhân viên bán đồ ăn', '10/03/2022');

INSERT INTO TAIKHOAN (MATK, MANV, TENDN, SODT, MATKHAU, VAITRO)
VALUES
('TK001', 'NV001', 'lequangd', '0922334455', '123456', N'Quản lý'),
('TK002', 'NV002', 'phanthie', '0988776655', '123456', N'Nhân viên bán vé'),
('TK003', 'NV003', 'nguyenthif', '0912345678', '123456', N'Nhân viên bán đồ ăn');

INSERT INTO THUCPHAM (MATP, TENTP, GIATP, SOLUONG)
VALUES
('TP01', N'Bắp ngọt', 59000, 100),
('TP02', N'Bắp phô mai', 74000, 100),
('TP03', N'Nước soda trái cây', 45000, 100),
('TP04', N'Coca cola', 45000, 100),
('TP05', N'7 Up', 45000, 100);


------------------------------------ Quản trị người dùng ------------------------------------

-- Tạo login
sp_addlogin 'lequangd', '123456', 'QuanLy_RapChieuPhim'
sp_addlogin 'phanthie', '123456', 'QuanLy_RapChieuPhim'
sp_addlogin 'nguyenthif', '123456', 'QuanLy_RapChieuPhim'

-- Tạo user
sp_adduser 'lequangd', 'lequangd'
sp_adduser 'phanthie', 'phanthie'
sp_adduser 'nguyenthif', 'nguyenthif'

-- Tạo nhóm quyền
sp_addrole 'Admin'
sp_addrole 'NhanVien_BanVe'
sp_addrole 'NhanVien_BanDoAn'

-- Thêm quyền vào nhóm quyền
-- Admin
GRANT SELECT, INSERT, UPDATE, DELETE ON PHIM TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON SUATCHIEU TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON PHONG TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON NHANVIEN TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON TAIKHOAN TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON HOADON TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON VE TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON THUCPHAM TO Admin;
GRANT SELECT, INSERT, UPDATE, DELETE ON CHITIETHD_TP TO Admin;

-- Nhân viên bán vé
GRANT SELECT ON PHIM TO NhanVien_BanVe;
GRANT SELECT ON SUATCHIEU TO NhanVien_BanVe;
GRANT SELECT, INSERT, UPDATE ON VE TO NhanVien_BanVe;
GRANT SELECT, INSERT ON HOADON TO NhanVien_BanVe;
GRANT SELECT(MANV, TENDN) ON NHANVIEN TO NhanVien_BanVe

-- Nhân viên bán đồ ăn
GRANT SELECT, INSERT, UPDATE ON THUCPHAM TO NhanVien_BanDoAn;
GRANT SELECT, INSERT ON HOADON TO NhanVien_BanDoAn;
GRANT INSERT, UPDATE ON CHITIETHD_TP TO NhanVien_BanDoAn;
GRANT SELECT(MANV, TENDN) ON NHANVIEN TO NhanVien_BanDoAn;

-- Add user vào nhóm quyền
sp_addrolemember 'Admin', 'lequangd'
sp_addrolemember 'NhanVien_BanVe', 'phanthie'
sp_addrolemember 'NhanVien_BanDoAn', 'nguyenthif'

EXECUTE AS USER = 'lequangd'; -- Đăng nhập như admin
SELECT * FROM PHIM; -- Thử quyền
REVERT;

-- Đăng nhập
CREATE PROCEDURE DangNhap
as
begin
	SELECT 
        CASE
            WHEN IS_MEMBER('Admin') = 1 THEN 'Admin'
            WHEN IS_MEMBER('NhanVien_BanVe') = 1 THEN 'NhanVien_BanVe'
            WHEN IS_MEMBER('NhanVien_BanDoAn') = 1 THEN 'NhanVien_BanDoAn'
            ELSE 'Unknown'
        END AS RoleName;
end

EXEC DangNhap
GRANT EXECUTE ON DangNhap TO public;

--------------------------------------------- HÀ MINH TIẾN ---------------------------------------------
-- Chức năng đặt vé
-- 1. Trigger cập nhật tổng doanh thu của hóa đơn
CREATE TRIGGER tg_CapNhatThanhTienHD
ON VE
AFTER INSERT, DELETE
AS
BEGIN
    UPDATE HOADON
    SET THANHTIEN = (SELECT SUM(GIAGHE) FROM VE WHERE MAHD = HOADON.MAHD)
    WHERE MAHD IN (SELECT MAHD FROM INSERTED UNION SELECT MAHD FROM DELETED);
END

drop trigger tg_CapNhatThanhTienHD

-- 2. Tạo hóa đơn mới
CREATE PROCEDURE proc_TaoHD
    @MAHD NVARCHAR(20),
    @MANV NVARCHAR(20),
    @NGAYLAP DATE
AS
BEGIN
    INSERT INTO HOADON (MAHD, MANV, NGAYLAP)
    VALUES (@MAHD, @MANV, @NGAYLAP);
END
GRANT EXECUTE ON proc_TaoHD TO phanthie;

drop proc proc_TaoHD

-- 3. Thêm vé vào hóa đơn
CREATE PROCEDURE proc_ThemVe
    @MAVE NVARCHAR(20),
    @MASUATCHIEU NVARCHAR(20),
    @MAHD NVARCHAR(20),
    @TENGHE INT,
	@GIAGHE DECIMAL
AS
BEGIN
    INSERT INTO VE (MAVE, MASUATCHIEU, MAHD, TENGHE, GIAGHE)
    VALUES (@MAVE, @MASUATCHIEU, @MAHD, @TENGHE, @GIAGHE);
END
GRANT EXECUTE ON proc_ThemVe TO phanthie;


-- 4. Procduce hiển thị phim
CREATE PROC proc_HienThiPhim
AS
BEGIN
	SELECT DISTINCT MAPHIM, TENPHIM
	FROM PHIM
END
GRANT EXECUTE ON proc_HienThiPhim TO phanthie;

drop proc proc_HienThiPhim
exec proc_HienThiPhim

-- 5. Procduce cập nhật ghế đã đặt nếu trùng suất chiếu
CREATE FUNCTION func_CapNhatGheTrung
(
    @ngaychieu DATE,
    @maphim NVARCHAR(50),
    @masc NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN
(
    SELECT ve.TENGHE, ve.MASUATCHIEU
    FROM VE ve
    WHERE ve.MASUATCHIEU = (
        SELECT sc.MASC
        FROM SUATCHIEU sc
        WHERE sc.MAPHIM = @maphim
          AND sc.NGAYCHIEU = @ngaychieu
          AND sc.MASC = @masc
    )
);

GRANT SELECT ON func_CapNhatGheTrung TO phanthie;



-- 6. Procduce hiển thị suất chiếu
CREATE PROCEDURE proc_GetSuatChieu
    @maPhim NVARCHAR(50),
    @ngayChieu DATE
AS
BEGIN
    SELECT 
        MASC, 
        MAPHIM, 
        NGAYCHIEU, 
        CONCAT(LEFT(THOIGIANBD, 5), ' - ', LEFT(THOIGIANKT, 5)) AS ThoiGian
    FROM 
        SUATCHIEU
    WHERE 
        MAPHIM = @maPhim
        AND NGAYCHIEU = @ngayChieu
END

GRANT EXECUTE ON proc_GetSuatChieu TO phanthie;

drop proc proc_GetSuatChieu
exec proc_GetSuatChieu 'P001', '2024-12-12'


-- 7. Function sinh mã tự động
CREATE FUNCTION func_SinhMaTuDong
(
    @tt NVARCHAR(10),  -- Tiền tố (VD: 'HD', 'KH')
    @tenBang NVARCHAR(50),  -- Tên bảng
    @ngay NVARCHAR(8)  -- Ngày định dạng 'ddMMyyyy'
)
RETURNS NVARCHAR(20)
AS
BEGIN
    DECLARE @maCuoi NVARCHAR(20)
    DECLARE @maMoi NVARCHAR(20)
    DECLARE @soThuTu INT

    -- Lấy mã cuối cùng theo tiền tố và ngày
    IF (@tenBang = 'HOADON')
    BEGIN
        SET @maCuoi = (
            SELECT TOP 1 MAHD
            FROM HOADON
            WHERE MAHD LIKE @tt + @ngay + '%' -- Điều kiện LIKE dựa trên tiền tố và ngày
            ORDER BY MAHD DESC
        );
    END
	ELSE
    BEGIN
        SET @maCuoi = (
            SELECT TOP 1 MAVE
            FROM VE
            WHERE MAVE LIKE @tt + @ngay + '%'
            ORDER BY MAVE DESC
        );
    END

    -- Kiểm tra nếu không có mã nào
    IF @maCuoi IS NULL
    BEGIN
        SET @maMoi = @tt + @ngay + '001'
    END
    ELSE
    BEGIN
        -- Tăng số thứ tự
        SET @soThuTu = CAST(SUBSTRING(@maCuoi, LEN(@tt) + LEN(@ngay) + 1, 3) AS INT) + 1
        SET @maMoi = @tt + @ngay + RIGHT('000' + CAST(@soThuTu AS NVARCHAR), 3)
    END

    RETURN @maMoi
END
GRANT EXECUTE ON func_SinhMaTuDong TO phanthie;

drop function func_SinhMaTuDong

-- 8. Hiển thị ds vé đã đặt
CREATE PROCEDURE proc_DsVeDaDat 
    @NgayChieu DATE
AS
BEGIN
    SELECT
		ve.MAHD,
        ve.MAVE, 
		sc.MASC,
        sc.NGAYCHIEU, 
        p.TENPHIM, 
		CONCAT(
			CONVERT(VARCHAR(5), sc.THOIGIANBD, 108), 
			' - ', 
			CONVERT(VARCHAR(5), sc.THOIGIANKT, 108)
		) AS THOIGIAN,
		TENGHE,
		GIAGHE
    FROM 
        VE ve, 
        SUATCHIEU sc, 
        PHIM p
    WHERE 
        ve.MASUATCHIEU = sc.MASC 
        AND p.MAPHIM = sc.MAPHIM 
        AND sc.NGAYCHIEU = @NgayChieu
END
GRANT EXECUTE ON proc_DsVeDaDat TO phanthie;
drop proc proc_DsVeDaDat
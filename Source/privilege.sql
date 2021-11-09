﻿


--Create login
exec sp_addlogin 'Meg', 'TK000021'
exec sp_addlogin 'Lily', 'TK000027'
exec sp_addlogin 'Keshi', 'TK000031'
exec sp_addlogin 'Tarah', 'TK000011'
exec sp_addlogin 'Luna', 'TK000012'
exec sp_addlogin 'Jewel', 'TK000005'
exec sp_addlogin 'Jack', 'TK000001'

--Create user
create user Meg for login Meg
create user Lily for login Lily
create user Keshi for login Keshi
create user Tarah for login Tarah
create user Luna for login Luna
create user Jewel for login Jewel
create user Jack for login Jack

--Create Role
exec sp_addrole 'DOI_TAC'
exec sp_addrole 'KHACH_HANG'
exec sp_addrole 'TAI_XE'
exec sp_addrole 'NHAN_VIEN'
exec sp_addrole 'QUAN_TRI'

--Add users to role
EXEC SP_ADDROLEMEMBER 'DOI_TAC' ,'Meg'
EXEC SP_ADDROLEMEMBER 'DOI_TAC' ,'Lily'
EXEC SP_ADDROLEMEMBER 'KHACH_HANG' ,'Keshi'
EXEC SP_ADDROLEMEMBER 'TAI_XE' ,'Tarah'
EXEC SP_ADDROLEMEMBER 'TAI_XE' ,'Luna'
EXEC SP_ADDROLEMEMBER 'NHAN_VIEN' ,'Jewel'
EXEC SP_ADDROLEMEMBER 'QUAN_TRI' ,'Jack'

--Grant authorization
--PHÂN HỆ QUẢN TRỊ
--QUẢN TRỊ NGƯỜI DÙNG
GO
CREATE VIEW CRUD_TK_NV_ADMIN
AS
SELECT * 
FROM TAI_KHOAN WHERE VAI_TRO = 'Admin' OR VAI_TRO = N'Nhân viên'
go

GRANT SELECT,INSERT,UPDATE,DELETE ON CRUD_TK_NV_ADMIN TO QUAN_TRI
GRANT SELECT, UPDATE ON TAI_KHOAN TO QUAN_TRI
--CẬP NHẬT QUYÊN NGƯỜI DÙNG


--PHÂN HỆ NHÂN VIÊN
--QUẢN LÝ ĐỐI TÁC & XÁC NHẬN HỢP ĐỒNG
GRANT SELECT,INSERT ON HOP_DONG TO NHAN_VIEN
GRANT SELECT, INSERT ON LICH_SU_HOP_DONG TO NHAN_VIEN
GRANT SELECT ON DOI_TAC TO NHAN_VIEN
GRANT UPDATE ON HOP_DONG(NGAY_KY, NGAY_HET_HAN, HOA_HONG) TO NHAN_VIEN

--PHÂN HỆ TÀI XẾ
--GÁN QUYỀN TRUY CẬP ĐẾN THÔNG TIN CÁ NHÂN
GO
CREATE VIEW UV_TTTAIXE
AS
SELECT HO_TEN, CMND, STK, BIEN_SO, SDT, EMAIL, DUONG, PHUONG, QUAN, THANH_PHO
FROM TAI_XE TX JOIN TAI_KHOAN TK ON TX.MATK = TK.MATK
WHERE TK.TENTK = CURRENT_USER --CURRENT_USER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_TTTAIXE TO TAI_XE
GRANT UPDATE ON UV_TTTAIXE(HO_TEN, CMND, SDT, EMAIL, DUONG, PHUONG, QUAN, THANH_PHO) TO TAI_XE
GO

--TIẾP NHẬN VÀ XỬ LÝ ĐƠN HÀNG
CREATE VIEW UV_DHTAIXE
AS	
	SELECT DH.*
	FROM HOAT_DONG HD JOIN KHU_VUC_HOAT_DONG KV ON HD.MAKV = KV.MAKV
		 JOIN DON_HANG DH ON DH.THANH_PHO = KV.TENKV
		 JOIN TAI_XE TX ON TX.MATX = HD.MATX
		 JOIN TAI_KHOAN TK ON TK.MATK = TX.MATK
	WHERE TK.TENTK = CURRENT_USER
GO

GRANT SELECT ON UV_DHTAIXE TO TAI_XE
GRANT INSERT ON PHIEU_GIAO_HANG TO TAI_XE
GO

CREATE VIEW UV_TTDHTAIXE
AS	
	SELECT TTDH.*
	FROM TRANG_THAI_DON_HANG TTDH JOIN PHIEU_GIAO_HANG PGH ON PGH.MADH = TTDH.MADH
		 JOIN TAI_XE TX ON TX.MATX = PGH.MATX
		 JOIN TAI_KHOAN TK ON TK.MATK = TX.MATK
	WHERE TK.TENTK = CURRENT_USER
GO

GRANT SELECT, UPDATE, INSERT ON UV_TTDHTAIXE TO TAI_XE

--THEO DÕI THU NHẬP
GO
CREATE VIEW UV_TNTAIXE
AS	
	SELECT DH.MADH, DH.PHI_VAN_CHUYEN, TK.MATK
	FROM TAI_XE TX JOIN TAI_KHOAN TK ON TX.MATK = TK.MATK
		JOIN PHIEU_GIAO_HANG PGH ON TX.MATX = PGH.MATX
		JOIN DON_HANG DH ON DH.MADH = PGH.MADH
	WHERE TK.TENTK = CURRENT_USER --CURRENT_USER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_TNTAIXE TO TAI_XE
--PHÂN HỆ ĐỐI TÁC
--GÁN QUYỀN TRUY CẬP ĐẾN THÔNG TIN CÁ NHÂN
GO
CREATE VIEW UV_TTDOITAC
AS
SELECT TK.*, DT.MADT, DT.TEN_DOI_TAC, DT.MALH, DT.SO_CHI_NHANH, DT.SO_LUONG_DON, DT.NGUOI_DAI_DIEN, DT.QUAN as 'QUAN_NDD', DT.THANH_PHO as 'TP_NDD'
FROM DOI_TAC DT JOIN TAI_KHOAN TK ON DT.MATK = TK.MATK
WHERE TK.TENTK = CURRENT_USER --CURRENT_USER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_TTDOITAC TO DOI_TAC
GRANT UPDATE ON UV_TTDOITAC(TEN_DOI_TAC, NGUOI_DAI_DIEN, SDT, EMAIL, DUONG, PHUONG, QUAN, THANH_PHO) TO DOI_TAC

--QUẢN LÝ SẢN PHẨM
GO
CREATE VIEW UV_SPDOITAC
AS
SELECT SP.*, CN.*
FROM DOI_TAC DT JOIN TAI_KHOAN TK ON DT.MATK = TK.MATK
	 JOIN CHI_NHANH CN ON CN.MADT = DT.MADT
	 JOIN PHAN_PHOI PP ON PP.MACN = CN.MACN
	 JOIN SAN_PHAM SP ON SP.MASP = PP.MASP
WHERE TK.TENTK = CURRENT_USER --CURRENT_USER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_SPDOITAC TO DOI_TAC
GRANT INSERT,UPDATE,DELETE ON UV_SPDOITAC(TENSP, MO_TA, DUONG, PHUONG, QUAN, THANH_PHO) TO DOI_TAC
--QUẢN LÝ ĐƠN ĐẶT HÀNG
GO
CREATE VIEW UV_DHDOITAC
AS
SELECT DH.*
FROM DOI_TAC DT JOIN TAI_KHOAN TK ON DT.MATK = TK.MATK
	 JOIN DON_HANG DH ON DH.MADT = DT.MADT
WHERE TK.TENTK = CURRENT_USER --CURRENT_USER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_DHDOITAC TO DOI_TAC
GO

CREATE VIEW UV_TTDHDOITAC
AS	
	SELECT TTDH.*
	FROM TRANG_THAI_DON_HANG TTDH JOIN DON_HANG DH ON DH.MADH = TTDH.MADH
		 JOIN DOI_TAC DT ON DT.MADT = DH.MADT
		 JOIN TAI_KHOAN TK ON TK.MATK = DT.MATK
	WHERE TK.TENTK = CURRENT_USER
GO

GRANT UPDATE ON UV_TTDHDOITAC(THOI_GIAN) TO DOI_TAC
GRANT SELECT ON UV_TTDHDOITAC TO DOI_TAC
--PHÂN HỆ KHÁCH HÀNG
-- KHÁCH HÀNG XEM DANH SÁCH SẢN PHẨM CỦA ĐỐI TÁC
GO
CREATE VIEW UV_XEMSP_KH
AS
SELECT DT.MADT, DT.TEN_DOI_TAC, SP.TENSP, PP.GIA, PP.SO_LUONG_TON
FROM DOI_TAC DT JOIN CHI_NHANH CN ON DT.MADT = CN.MADT
JOIN PHAN_PHOI PP ON PP.MACN = CN.MACN
JOIN SAN_PHAM SP ON SP.MASP = PP.MASP
JOIN TAI_KHOAN TK ON DT.MATK = TK.MATK
GO
GRANT SELECT ON UV_XEMSP_KH TO KHACH_HANG
GO
-- KHÁCH HÀNG XEM ĐƠN HÀNG CỦA CHÍNH MÌNH **
CREATE VIEW UV_DONHANG_KH 
AS
SELECT DH.*
FROM KHACH_HANG KH JOIN TAI_KHOAN TK ON KH.MATK = TK.MATK
JOIN DON_HANG DH ON KH.MAKH = DH.MAKH
WHERE TK.TENTK = CURRENT_USER 

-- KHÁCH HÀNG XEM TRẠNG THÁI CÁC ĐƠN HÀNG CỦA MÌNH
GO
CREATE VIEW UV_GIAOHANG_KH 
AS
SELECT TT.*
FROM KHACH_HANG KH JOIN TAI_KHOAN TK ON KH.MATK = TK.MATK
JOIN DON_HANG DH ON KH.MAKH = DH.MAKH
JOIN TRANG_THAI_DON_HANG TT ON TT.MADH = DH.MADH
WHERE TK.TENTK = CURRENT_USER 
GO

GRANT SELECT ON UV_DONHANG_KH TO KHACH_HANG
GRANT SELECT ON UV_GIAOHANG_KH TO KHACH_HANG

-- KHÁCH HÀNG TẠO ĐƠN HÀNG
GRANT INSERT ON DON_HANG TO KHACH_HANG
GRANT SELECT ON SAN_PHAM TO KHACH_HANG
GRANT INSERT ON CHI_TIET_DON_HANG TO KHACH_HANG

-- KHÁCH HÀNG TRUY CẬP ĐẾN THÔNG TIN CÁ NHÂN
GO
CREATE VIEW UV_TTKHACHHANG
AS
SELECT KH.MAKH, KH.HO_TEN, TK.*
FROM KHACH_HANG KH JOIN TAI_KHOAN TK ON KH.MATK = TK.MATK
WHERE TK.TENTK = CURRENT_USER --CURRENT_USER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_TTKHACHHANG TO KHACH_HANG
GRANT UPDATE ON UV_TTKHACHHANG(HO_TEN, SDT, EMAIL, DUONG, PHUONG, QUAN, THANH_PHO) TO KHACH_HANG




--TEST PHÂN QUYỀN --
use QLHTChuyenHang
go
-- TEST PHÂN HỆ KHÁCH HÀNG --
-- Khách hàng xem danh sách sản phẩm của đối tác, xem tình trạng đơn hàng của mình
SELECT * FROM UV_XEMSP_KH
SELECT * FROM UV_DONHANG_KH
SELECT * FROM UV_TTKHACHHANG
SELECT * FROM UV_GIAOHANG_KH

INSERT dbo.DON_HANG(MADH, MAKH, MADT, PHI_SAN_PHAM, PHI_VAN_CHUYEN, PHI_GIAM, TONG_PHI, TRANG_THAI, HINH_THUC_THANH_TOAN, DUONG, PHUONG, QUAN, THANH_PHO) VALUES ('DH000016', 'KH000001', 'DT000003', 1276139, 75840, 95380, 4186391, N'Đặt hàng', N'Thẻ ghi nợ', N'19/5 Nguyễn Đăng Giai', N'Thạnh Mỹ Lợi', N'Tân An', N'Long An')
INSERT dbo.CHI_TIET_DON_HANG(MADH, MASP, SO_LUONG, THANH_TIEN) VALUES ('DH000016', 'SP000007', 2, 6162125)
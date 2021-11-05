﻿use QLHTChuyenHang
go

--Create login
exec sp_addlogin 'DT1', 'DT1'
exec sp_addlogin 'KH1', 'KH1'
exec sp_addlogin 'TX1', 'TX1'
exec sp_addlogin 'NV1', 'NV1'
exec sp_addlogin 'QT1', 'QT1'

--Create user
create user DT1 for login DT1
create user KH1 for login KH1
create user TX1 for login TX1
create user NV1 for login NV1
create user QT1 for login QT1

--Create Role
exec sp_addrole 'DOI_TAC'
exec sp_addrole 'KHACH_HANG'
exec sp_addrole 'TAI_XE'
exec sp_addrole 'NHAN_VIEN'
exec sp_addrole 'QUAN_TRI'

--Add users to role
EXEC SP_ADDROLEMEMBER 'DOI_TAC' ,'DT1'
EXEC SP_ADDROLEMEMBER 'KHACH_HANG' ,'KH1'
EXEC SP_ADDROLEMEMBER 'TAI_XE' ,'TX1'
EXEC SP_ADDROLEMEMBER 'NHAN_VIEN' ,'NV1'
EXEC SP_ADDROLEMEMBER 'QUAN_TRI' ,'QT1'

--Grant authorization
--PHÂN HỆ QUẢN TRỊ
--QUẢN TRỊ NGƯỜI DÙNG
CREATE VIEW CRUD_TK_NV_ADMIN
AS
SELECT * 
FROM TAI_KHOAN WHERE VAI_TRO = 'Admin' OR VAI_TRO = N'Nhân viên'
go

GRANT SELECT,INSERT,UPDATE,DELETE ON CRUD_TK_NV_ADMIN TO QUAN_TRI
GRANT UPDATE ON TAI_KHOAN TO QUAN_TRI
--CẬP NHẬT QUYÊN NGƯỜI DÙNG


--PHÂN HỆ NHÂN VIÊN
--QUẢN LÝ ĐỐI TÁC & XÁC NHẬN HỢP ĐỒNG
GRANT SELECT,INSERT ON HOP_DONG TO NHAN_VIEN
GRANT SELECT, INSERT ON LICH_SU_HOP_DONG TO NHAN_VIEN
GRANT SELECT ON DOI_TAC TO NHAN_VIEN
GRANT UPDATE ON HOP_DONG(THOI_GIAN_HIEU_LUC, HOA_HONG) TO NHAN_VIEN

--PHÂN HỆ TÀI XẾ
--GÁN QUYỀN TRUY CẬP ĐẾN THÔNG TIN CÁ NHÂN
CREATE VIEW UV_TTTAIXE
AS
SELECT HO_TEN, CMND, STK, BIEN_SO, SDT, EMAIL, DIA_CHI
FROM TAI_XE TX JOIN TAI_KHOAN TK ON TX.MATK = TK.MATK
WHERE TK.TENTK = CURRENT_USER --CURRETUSER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_TTTAIXE TO TAI_XE
GRANT UPDATE ON UV_TTTAIXE(HO_TEN, CMND, SDT, EMAIL, DIA_CHI) TO TAI_XE
--TIẾP NHẬN VÀ XỬ LÝ ĐƠN HÀNG
/*
CREATE VIEW UV_DHTAIXE
AS	
	SELECT *
	FROM DON_HANG DH
	WHERE (SELECT *
			FROM HOAT_DONG HD JOIN KHU_VUC_HOAT_DONG KV ON HD.MAKV = KV.MAKV
			WHERE CHARINDEX(KV.TENKV, (SELECT DH.DIA_CHI_GIAO_HANG
										FROM DON_HANG DH2)) != 0) IS NOT NULL
	AND DH.MADH = 
GO*/

--THEO DÕI THU NHẬP
CREATE VIEW UV_TNTAIXE
AS	
	SELECT DH.MADH, DH.PHI_VAN_CHUYEN, TK.MATK
	FROM TAI_XE TX JOIN TAI_KHOAN TK ON TX.MATK = TK.MATK
		JOIN PHIEU_GIAO_HANG PGH ON TX.MATX = PGH.MATX
		JOIN DON_HANG DH ON DH.MADH = PGH.MADH
	WHERE TK.TENTK = CURRENT_USER --CURRETUSER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_TNTAIXE TO TAI_XE

--PHÂN HỆ ĐỐI TÁC
--GÁN QUYỀN TRUY CẬP ĐẾN THÔNG TIN CÁ NHÂN
CREATE VIEW UV_TTDOITAC
AS
SELECT TEN_DOI_TAC, NGUOI_DAI_DIEN, SO_CHI_NHANH, SO_LUONG_DON, SDT, EMAIL, DIA_CHI
FROM DOI_TAC DT JOIN TAI_KHOAN TK ON DT.MATK = TK.MATK
WHERE TK.TENTK = CURRENT_USER --CURRETUSER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_TTDOITAC TO DOI_TAC
GRANT UPDATE ON UV_TTDOITAC(TEN_DOI_TAC, NGUOI_DAI_DIEN, SDT, EMAIL, DIA_CHI) TO TAI_XE

--QUẢN LÝ SẢN PHẨM
CREATE VIEW UV_SPDOITAC
AS
SELECT SP.*, CN.*
FROM DOI_TAC DT JOIN TAI_KHOAN TK ON DT.MATK = TK.MATK
	 JOIN CHI_NHANH CN ON CN.MADT = DT.MADT
	 JOIN PHAN_PHOI PP ON PP.MACN = CN.MACN
	 JOIN SAN_PHAM SP ON SP.MASP = PP.MASP
WHERE TK.TENTK = CURRENT_USER --CURRETUSER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT,INSERT,UPDATE,DELETE ON UV_SPDOITAC TO DOI_TAC

--QUẢN LÝ ĐƠN ĐẶT HÀNG
CREATE VIEW UV_DHDOITAC
AS
SELECT DH.*
FROM DOI_TAC DT JOIN TAI_KHOAN TK ON DT.MATK = TK.MATK
	 JOIN DON_HANG DH ON DH.MADT = DT.MADT
WHERE TK.TENTK = CURRENT_USER --CURRETUSER LÀ TÀI KHOẢN ĐANG ĐĂNG NHẬP 
GO

GRANT SELECT ON UV_DHDOITAC TO DOI_TAC
GRANT UPDATE(TRANG_THAI) ON UV_DHDOITAC TO DOI_TAC

--PHÂN HỆ KHÁCH HÀNG
-- KHÁCH HÀNG XEM DANH SÁCH ĐỐI TÁC
CREATE VIEW UV_XEMSP_KH
AS
SELECT DT.TEN_DOI_TAC, DT.NGUOI_DAI_DIEN, DT.SO_CHI_NHANH, HH.TEN_LH
FROM DOI_TAC DT JOIN HANG_HOA HH 
ON DT.MALH = HH.MALH
JOIN TAI_KHOAN TK ON DT.MATK = TK.MATK
GO
GRANT SELECT ON UV_XEMSP_KH TO KHACH_HANG
GRANT SELECT ON TRANG_THAI_DON_HANG TO KHACH_HANG
GO
-- KHÁCH HÀNG XEM ĐƠN HÀNG CỦA CHÍNH MÌNH
CREATE VIEW UV_GIAOHANG_KH 
AS
SELECT DH.*, TT.TEN_TRANG_THAI, TT.THOI_GIAN
FROM KHACH_HANG KH JOIN TAI_KHOAN TK ON KH.MATK = TK.MATK
JOIN DON_HANG DH ON KH.MAKH = DH.MAKH
JOIN TRANG_THAI_DON_HANG TT ON TT.MADH = DH.MADH
WHERE TK.TENTK = CURRENT_USER 
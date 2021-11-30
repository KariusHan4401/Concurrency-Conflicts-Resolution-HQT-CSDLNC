USE QLHTChuyenHang
GO
-- KHÁCH HÀNG TÌM SẢN PHẨM --
-- Tài khoản: Username: Keshi ; Password: TK000031

DECLARE @FLAG INT
EXEC @FLAG = USP_KH_TIMSP N'Vở'
IF @FLAG = 1
	PRINT N'CÓ LỖI XẢY RA!'
ELSE
	PRINT N'HIỂN THỊ DANH SÁCH SẢN PHẨM'


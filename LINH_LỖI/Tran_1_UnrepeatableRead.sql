﻿USE QLHTChuyenHang
GO
-- KHÁCH HÀNG XEM THÀNH TIỀN --
DECLARE @FLAG INT
EXEC @FLAG = USP_KH_CTDH 'SP000010', 'CN000002', 2
IF @FLAG = 1
	PRINT N'CÓ LỖI XẢY RA!'
ELSE
	PRINT N'THÀNH TIỀN SẢN PHẨM'

-- SELECT * FROM UV_XEMSP_KH


-- SELECT * FROM UV_XEMSP_KH
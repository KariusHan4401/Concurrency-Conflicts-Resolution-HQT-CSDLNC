﻿USE QLHTChuyenHang
GO

-- TÀI XẾ CẬP NHẬT ĐƠN HÀNG ĐÃ GIAO
-- Tài khoản: Username: Luna, Password: TK000012

DECLARE @FLAG INT
--EXEC @FLAG = USP_TX_DAGIAOHANG N'Đã giao hàng', 'DH000008', '2021-10-25 14:00:00.000'
EXEC @FLAG = USP_TX_DAGIAOHANG N'Đã xác nhận', 'DH000015', '2021-12-09 14:00:00.000'

IF @FLAG = 1
	PRINT N'CẬP NHẬT TRẠNG THÁI THẤT BẠI'
ELSE PRINT N'CẬP NHẬT TRẠNG THÁI THÀNH CÔNG'

SELECT * FROM UV_DHTAIXE
SELECT * FROM UV_TTDHTAIXE

﻿USE QLHTChuyenHang
GO
-- ĐỐI TÁC XEM DOANH THU --
-- Đăng nhập: Username: Lily, Password: TK000027
DECLARE @RT INT
EXEC @RT = USP_DT_XEMDOANHTHU
IF @RT = 1
	PRINT N'CÓ LỖI XẢY RA!'
ELSE
	PRINT N'HIỂN THỊ DOANH THU ĐỐI TÁC'

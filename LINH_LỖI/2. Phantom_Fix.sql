﻿USE QLHTChuyenHang
GO
-- GRANT EXEC TO KHACH_HANG
ALTER PROC USP_KH_TIMSP
	@TenSP NVARCHAR(100)
AS
SET TRAN ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	BEGIN TRY
	SELECT COUNT(*) AS SL_TIM_KIEM FROM UV_XEMSP_KH
	WHERE TENSP = @TenSP

	WAITFOR DELAY '0:0:05'

	SELECT * FROM UV_XEMSP_KH
	WHERE TENSP = @TenSP

	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1	
	END CATCH
COMMIT TRAN
RETURN 0

GO
ALTER PROC USP_DT_THEMSP
	@MaCN CHAR(8),
	@MaSP CHAR(8),
	@SL_Ton INT,
	@Gia MONEY
AS
--SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
		IF @MaSP NOT IN (SELECT MASP
						FROM SAN_PHAM)
		BEGIN
			PRINT @MaSP + N' không tồn tại!!'
			ROLLBACK TRAN
			RETURN 1
		END
		IF @MaCN NOT IN (SELECT MACN
						FROM UV_CN_DOITAC
						WHERE MAHD IS NOT NULL)
		BEGIN
			PRINT @MaCN + N' không tồn tại / không thuộc quản lý của đối tác / chưa được ký hợp đồng!!'
			ROLLBACK TRAN
			RETURN 1
		END
		INSERT PHAN_PHOI
		VALUES (@MaSP, @MaCN, @SL_Ton, @Gia)

	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0

--SELECT * FROM PHAN_PHOI
--DELETE FROM PHAN_PHOI
--WHERE MASP = 'SP000010' AND MACN = 'CN000003'
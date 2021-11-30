﻿USE QLHTChuyenHang
GO
ALTER PROC USP_DT_CASE1_FIX
	@NguoiDaiDien NVARCHAR(30),
	@MaCN CHAR(8),
	@Duong NVARCHAR(50)
AS
--SET TRAN ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	BEGIN TRY
		UPDATE UV_TTDOITAC
		SET NGUOI_DAI_DIEN = @NguoiDaiDien
		--ĐỂ TEST
		WAITFOR DELAY '0:0:05'
		---------------------------------
		UPDATE UV_CN_DOITAC
		SET DUONG = @Duong
		WHERE MACN = @MaCN
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1	
	END CATCH
COMMIT TRAN
RETURN 0

GO
ALTER PROC USP_DT_CASE2_FIX
	@NguoiDaiDien NVARCHAR(30),
	@MaCN CHAR(8),
	@Duong NVARCHAR(50)
AS
-- SET TRAN ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
	BEGIN TRY
		UPDATE UV_TTDOITAC
		SET NGUOI_DAI_DIEN = @NguoiDaiDien
		--ĐỂ TEST
		WAITFOR DELAY '0:0:05'
		---------------------------------
		UPDATE UV_CN_DOITAC
		SET DUONG = @Duong
		WHERE MACN = @MaCN
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0

GO
-- CẤP QUYỀN THỰC THI PROC CHO ĐỐI TÁC
-- GRANT EXEC TO DOI_TAC
﻿USE QLHTChuyenHang
GO
-- GRANT EXECUTE TO DOI_TAC
CREATE PROC USP_DT_TTCASE1
	@NguoiDaiDien NVARCHAR(30),
	@MaCN CHAR(8),
	@Duong NVARCHAR(50)
AS
--SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
		IF @MaCN NOT IN (SELECT MACN
						FROM UV_CN_DOITAC)
			BEGIN
				PRINT @MaCN + N' không phải chi nhánh của đối tác!!'
				ROLLBACK TRAN
				RETURN 1
			END
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
		PRINT N'LỖI HỆ THỐNG ' + ERROR_MESSAGE() 
		ROLLBACK TRAN
		RETURN 1	
	END CATCH
COMMIT TRAN
RETURN 0

GO
CREATE PROC USP_DT_TTCASE2
	@NguoiDaiDien NVARCHAR(30),
	@MaCN CHAR(8),
	@Duong NVARCHAR(50)
AS
--SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
		IF @MaCN NOT IN (SELECT MACN
						FROM UV_CN_DOITAC)
			BEGIN
				PRINT @MaCN + N' không phải chi nhánh của đối tác!!'
				ROLLBACK TRAN
				RETURN 1
			END
		UPDATE UV_CN_DOITAC
		SET DUONG = @Duong
		WHERE MACN = @MaCN
		--ĐỂ TEST
		WAITFOR DELAY '0:0:05'
		---------------------------------
		UPDATE UV_TTDOITAC
		SET NGUOI_DAI_DIEN = @NguoiDaiDien
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG ' + ERROR_MESSAGE() 
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0

GO


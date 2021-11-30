﻿USE QLHTChuyenHang
GO

-- CẤP QUYỀN THỰC THI PROC CHO ĐỐI TÁC VÀ TÀI XẾ
-- GRANT EXEC TO DOI_TAC
-- GRANT EXEC TO TAI_XE


CREATE PROC USP_TX_DAGIAOHANG
	@TrangThai NVARCHAR(20),
	@MaDH CHAR(8),
	@ThoiGian DATETIME
AS
BEGIN TRAN
	BEGIN TRY
	IF EXISTS (SELECT * 
				FROM UV_TTDHTAIXE
				WHERE TEN_TRANG_THAI = @TrangThai AND MADH = @MaDH)
	BEGIN
		PRINT @MaDH + N' đã được giao trước đó!!'
		ROLLBACK TRAN
		RETURN 1
	END
	IF @MaDH NOT IN (SELECT MADH
					FROM UV_DHTAIXE)
	BEGIN
		PRINT @MaDH + N' không phải của tài xế!!'
		ROLLBACK TRAN
		RETURN 1
	END
	INSERT UV_TTDHTAIXE
	VALUES(@TrangThai, @MaDH,@ThoiGian)
	UPDATE UV_DHTAIXE
	SET TRANG_THAI = @TrangThai
	WHERE MADH = @MaDH
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG ' + ERROR_MESSAGE()
		ROLLBACK TRAN
		RETURN 1	
	END CATCH
COMMIT TRAN
RETURN 0

GO
CREATE PROC USP_DT_XEMDOANHTHU
AS
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
		SELECT SUM(PHI_SAN_PHAM - PHI_VAN_CHUYEN) AS DOANH_THU, COUNT(*) AS TONG_LUONG_DON
		FROM UV_DHDOITAC
		WHERE TRANG_THAI = N'Đã giao hàng'
		--ĐỂ TEST
		WAITFOR DELAY '0:0:05'
		---------------------------------
		SELECT MADH, MAKH, PHI_SAN_PHAM, PHI_GIAM, PHI_SAN_PHAM - PHI_GIAM AS THANH_TIEN, HINH_THUC_THANH_TOAN
		FROM UV_DHDOITAC
		WHERE TRANG_THAI = N'Đã giao hàng'
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG ' + ERROR_MESSAGE()
		ROLLBACK TRAN
		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0

GO

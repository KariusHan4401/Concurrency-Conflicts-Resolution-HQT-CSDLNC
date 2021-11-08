USE QLHTChuyenHang
GO

--TRIGGER TRÊN BẢNG DON_HANG CHO VIEC SUA
CREATE TRIGGER TG_TONGPHI_FOR_UPDATE_DONHANG
ON DON_HANG FOR UPDATE
AS
BEGIN
	UPDATE DON_HANG
	SET TONG_PHI = CASE WHEN PHI_GIAM < PHI_VAN_CHUYEN + PHI_SAN_PHAM
	THEN DON_HANG.PHI_SAN_PHAM + DON_HANG.PHI_VAN_CHUYEN - DON_HANG.PHI_GIAM
	ELSE 0
	END
	WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted)
END
GO

--TRIGGER TRÊN BẢNG CHI_TIET_DON_HANG CHO VIEC THEM SUA
GO
CREATE TRIGGER TG_THANHTIEN_FOR_INSERT_UPDATE_CTHD
ON CHI_TIET_DON_HANG FOR UPDATE, INSERT
AS
BEGIN
	UPDATE CHI_TIET_DON_HANG
	SET CHI_TIET_DON_HANG.THANH_TIEN = (SELECT SP.GIA * CTDH.SO_LUONG
										FROM SAN_PHAM SP
										WHERE SP.MASP = CTDH.MASP
										)
	FROM CHI_TIET_DON_HANG CTDH
	JOIN inserted ON inserted.MADH = CTDH.MADH AND inserted.MASP = CTDH.MASP
	
	UPDATE DON_HANG
	SET DON_HANG.PHI_SAN_PHAM = (SELECT SUM(CTDH.THANH_TIEN)
								FROM CHI_TIET_DON_HANG CTDH
								WHERE CTDH.MADH = DON_HANG.MADH
								GROUP BY CTDH.MADH
								)
	WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted)
	
	-- Gọi trigger update tổng phí trên bảng DON_HANG
	UPDATE DON_HANG
	SET DON_HANG.TONG_PHI = 0 
	WHERE DON_HANG.MADH IN (SELECT DISTINCT inserted.MADH FROM inserted)
END
GO

--TRIGGER TRÊN BẢNG CHI_TIET_DON_HANG CHO VIEC XÓA
CREATE TRIGGER TG_TONGPHI_FOR_DELETE_CTDH
ON CHI_TIET_DON_HANG FOR DELETE
AS
BEGIN
	UPDATE DON_HANG
	SET DON_HANG.PHI_SAN_PHAM -= (SELECT SUM(deleted.THANH_TIEN)
							FROM deleted
							WHERE DON_HANG.MADH = deleted.MADH
							GROUP BY deleted.MADH
							)
	WHERE DON_HANG.MADH IN (SELECT DISTINCT MADH FROM deleted)
END
GO

--TRIGGER TRÊN BẢNG CHI_TIET_DON_HANG CHO VIEC XÓA
CREATE TRIGGER TG_FOR_INSERT_UPDATE_TTDH
ON TRANG_THAI_DON_HANG FOR UPDATE, INSERT
AS
BEGIN
	IF EXISTS(SELECT * FROM inserted 
				WHERE inserted.THOI_GIAN <= (SELECT MAX(TTDH.THOI_GIAN)
													FROM TRANG_THAI_DON_HANG TTDH
													WHERE inserted.MADH = TTDH.MADH)
				)
		BEGIN
			PRINT(N'Thời gian của trạng thái mới không hợp lệ!')
			ROLLBACK
		END
END
GO
-- 1.	Khi tái ký hợp đồng, thời gian hiệu lực mới phải sau thời gian hiệu lực cũ.
CREATE TRIGGER TG_INSERT_UPDATE_HOPDONG
ON HOP_DONG FOR UPDATE, INSERT
AS
BEGIN
	IF EXISTS(SELECT * FROM inserted JOIN deleted
				ON inserted.MAHD = deleted.MAHD
				WHERE inserted.NGAY_HET_HAN < deleted.NGAY_HET_HAN OR inserted.NGAY_KY < deleted.NGAY_KY
				OR inserted.NGAY_KY > inserted.NGAY_HET_HAN
				)
		BEGIN
			PRINT(N'Thời gian hiệu lực không hợp lệ!')
			ROLLBACK
		END

	IF EXISTS(SELECT * FROM inserted JOIN DOI_TAC DT
				ON inserted.MADT = DT.MADT
				WHERE inserted.SO_CHI_NHANH_DK < DT.SO_CHI_NHANH
				)
		BEGIN
			PRINT(N'Số lượng chi nhánh đăng ký không được vượt qua số chi nhánh của đối tác!')
			ROLLBACK
		END
END
GO
CREATE TRIGGER TG_INSERT_UPDATE_LS_HOPDONG
ON LICH_SU_HOP_DONG FOR INSERT, UPDATE
AS
BEGIN
	-- Chèn thêm Hợp đồng mới thì thời hạn hợp đồng A phải sau các thời hạn hợp đồng A đã ký trước đó.
	IF EXISTS(SELECT * FROM inserted 
				WHERE inserted.NGAY_KY <= (SELECT MAX(LS.NGAY_HET_HAN)
													FROM LICH_SU_HOP_DONG LS
													WHERE inserted.MAHD = LS.MAHD)
				OR inserted.NGAY_KY > inserted.NGAY_HET_HAN
													)
		BEGIN
			PRINT(N'Thời gian hiệu lực không hợp lệ!')
			ROLLBACK
		END
END
GO

-- 2. Khi trạng thái đơn hàng là  “Đã giao / Đã hủy” thì không được phép thay đổi thông tin vận chuyển đơn hàng
ALTER TRIGGER TG_UPDATE_INSERT_DONHANG
ON DON_HANG FOR UPDATE, INSERT
AS
BEGIN
	/*IF EXISTS(SELECT * FROM deleted
				WHERE deleted.TRANG_THAI IN (N'Đã giao', N'Đã hủy')
				)
		BEGIN
			PRINT(N'Không được thay đổi thông tin của trạng thái Đã giao/Đã hủy!')
			ROLLBACK
		END*/
		--------------------
	IF EXISTS(SELECT * FROM inserted 
				JOIN DOI_TAC DT ON DT.MADT = inserted.MADT
				WHERE DT.SO_LUONG_DON < (SELECT COUNT(*)
												FROM DON_HANG DH
												WHERE inserted.MADT = DH.MADT
												GROUP BY DH.MADT
												)
				)
		BEGIN
			PRINT(N'Số lượng đơn hàng bán ra vượt mức đăng ký của đối tác!')
			ROLLBACK
		END
END
GO

-- 3. Tổng số lượng đơn hàng ở tất cả chi nhánh của đối tác không được vượt qua số lượng đơn hàng mỗi ngày đã đăng ký.
-- + Số chi nhánh đăng ký trong hợp đồng không được vượt quá số chi nhánh của đối tác khi đăng ký thông tin. 
CREATE TRIGGER TG_UPDATE_DOITAC
ON DOI_TAC FOR UPDATE
AS
BEGIN
	IF EXISTS(SELECT * FROM inserted
				WHERE inserted.SO_LUONG_DON < (SELECT COUNT(*)
												FROM DON_HANG DH
												WHERE inserted.MADT = DH.MADT
												GROUP BY DH.MADT
												)
				)
		BEGIN
			PRINT(N'Số lượng đơn hàng bán ra vượt mức đăng ký của đối tác!')
			ROLLBACK
		END

	IF EXISTS(SELECT * FROM inserted JOIN HOP_DONG HD
				ON inserted.MADT = HD.MADT
				WHERE inserted.SO_CHI_NHANH < HD.SO_CHI_NHANH_DK
				)
		BEGIN
			PRINT(N'Số lượng chi nhánh đăng ký không được vượt qua số chi nhánh của đối tác!')
			ROLLBACK
		END
END



UPDATE DON_HANG
SET TONG_PHI = 0
GO

INSERT CHI_TIET_DON_HANG VALUES('DH000000', 'SP000001', 2, 50000)
GO

DELETE FROM CHI_TIET_DON_HANG WHERE (MADH = 'DH000000' AND MASP = 'SP000001')
GO

SELECT TOP 20 *
FROM SAN_PHAM
GO

SELECT TOP 20 *
FROM CHI_TIET_DON_HANG
GO

SELECT TOP 20 *
FROM DON_HANG
GO

UPDATE TRANG_THAI_DON_HANG
SET THOI_GIAN = '2021-01-14' WHERE MADH = 'DH000004' AND TEN_TRANG_THAI = N'Đã hủy'
GO

INSERT TRANG_THAI_DON_HANG VALUES (N'Đã hủy', 'DH000201','2021-01-09')
GO

SELECT *
FROM TRANG_THAI_DON_HANG TT
WHERE TT.MADH = 'DH000201'
GO
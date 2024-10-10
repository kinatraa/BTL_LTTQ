CREATE PROC addThings 
    @tenkhachhang NVARCHAR(25), 
    @bienso NVARCHAR(10),
    @tennguyennhan NVARCHAR(25), 
    @ngaysua DATE, 
    @diachi NVARCHAR(25), 
    @sodienthoai NVARCHAR(25)
AS
BEGIN
    DECLARE @maKH NVARCHAR(25), @masuachua NVARCHAR(25), @maxe NVARCHAR(25),@lastkhachhang nvarchar(25),@lastmaxe nvarchar(25),@lastyeucau nvarchar(25),@numberPart INT;

    IF EXISTS (SELECT 1 FROM XEMAY WHERE BienSo = @bienso)
    BEGIN
        RETURN;
    END
    ELSE
    BEGIN
		SELECT @lastmaxe = (select top 1 MaXe
		FROM XEMAY
		ORDER BY MaXe DESC)

		SELECT @numberPart = CAST(SUBSTRING(@lastmaxe, 3, LEN(@lastmaxe) - 2) AS INT);

		SET @numberPart = @numberPart + 1;

        SET @maxe = 'MX' + RIGHT('000' + CAST(@numberPart AS NVARCHAR), 3);
        INSERT INTO XEMAY(MaXe, BienSo) 
        VALUES (@maxe, @bienso);

        IF EXISTS (SELECT 1 FROM KHACHHANG WHERE SoDienThoai = @sodienthoai)
        BEGIN
            SELECT @maKH = MaKhachHang FROM KHACHHANG WHERE SoDienThoai = @sodienthoai;
        END
        ELSE
        BEGIN
			SELECT @lastkhachhang = (select top 1 MaKhachHang 
			FROM KHACHHANG
			ORDER BY MaKhachHang DESC)

			SELECT @numberPart = CAST(SUBSTRING(@lastkhachhang, 3, LEN(@lastkhachhang) - 2) AS INT);

			SET @numberPart = @numberPart + 1;

           SET @maKH = 'MK' + RIGHT('000' + CAST(@numberPart AS NVARCHAR), 3);
            INSERT INTO KHACHHANG(MaKhachHang, TenKhachHang, DiaChi, SoDienThoai) 
            VALUES (@maKH, @tenkhachhang, @diachi, @sodienthoai);
        END;

		SELECT @lastyeucau = (select top 1 MaSuaChua
		FROM YEUCAUSUACHUA
		ORDER BY MaSuaChua DESC)
		SELECT @numberPart = CAST(SUBSTRING(@lastyeucau, 4, LEN(@lastyeucau) - 3) AS INT);

		SET @numberPart = @numberPart + 1;
		


       SET @masuachua = 'MSC' + RIGHT('000' + CAST(@numberPart AS NVARCHAR), 3)

        INSERT INTO YEUCAUSUACHUA(MaSuaChua, MaXe, MaKhachHang, NgaySua, NguyenNhan)
        VALUES (@masuachua, @maxe, @maKH, @ngaysua, @tennguyennhan);
    END;
END;
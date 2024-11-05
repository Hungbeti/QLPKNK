CREATE DATABASE QLPKNK
GO

USE QLPKNK
GO

CREATE TABLE Luong_co_dinh
(
	Ma VARCHAR(10) PRIMARY KEY,
	So_tien FLOAT
);

GO
CREATE TABLE Nguoi_dung
(
	Ma_nhan_vien VARCHAR(10) PRIMARY KEY,
	Ho NVARCHAR(50) NOT NULL,
	Ten NVARCHAR(50) NOT NULL,
	Gioi_tinh NVARCHAR(3) CHECK(Gioi_tinh IN (N'Nam', N'Nữ')),
	Ngay_sinh DATE,
	Email varchar(50) NOT NULL,
	Que_quan NVARCHAR(30),
	CCCD NVARCHAR(12) UNIQUE,
	Maluong VARCHAR(10),
	Hoatdong int,
	FOREIGN KEY (Maluong) REFERENCES Luong_co_dinh(Ma)
);

GO
CREATE TABLE Tai_khoan
(
	Taikhoan VARCHAR(30) PRIMARY KEY,
	Matkhau VARCHAR(30) NOT NULL,
	MaNV VARCHAR(10),
	FOREIGN KEY (MaNV) REFERENCES Nguoi_dung(Ma_nhan_vien)
);

GO
CREATE TABLE Danh_muc_ki_thuat
(
	Ten_danh_muc NVARCHAR(50) PRIMARY KEY
);

GO
CREATE TABLE Dich_vu
(
	Ten_dich_vu NVARCHAR(50) PRIMARY KEY,
	Don_vi_tinh NVARCHAR(15) CHECK (Don_vi_tinh IN (N'Cái', N'Lượt', N'2 hàm', 
	N'Vùng hàm', N'Lần', N'Răng', N'Xoang', N'Ống tủy', N'Hàm', N'Bộ', N'Máng', N'Phim', N'Đơn vị')),
	Don_gia FLOAT NOT NULL CHECK(Don_gia > 0),
	Ghi_chu NVARCHAR(150),
	Ten_danh_muc NVARCHAR(50),
	FOREIGN KEY (Ten_danh_muc) REFERENCES Danh_muc_ki_thuat(Ten_danh_muc)
);

GO
CREATE TABLE Loai_thuoc
(
	Ten_loai NVARCHAR(30) PRIMARY KEY
);

GO
CREATE TABLE Thuoc
(
	Ten_thuoc NVARCHAR(30) PRIMARY KEY,
	DVT NVARCHAR(15),
	So_luong INT NOT NULL CHECK(So_luong >= 0),
	Gia_ban FLOAT NOT NULL CHECK(Gia_ban > 0),
	Ham_luong NVARCHAR(10) NOT NULL,
	Ghi_chu NVARCHAR(150),
	Ten_loai NVARCHAR(30),
	FOREIGN KEY (Ten_loai) REFERENCES Loai_thuoc(Ten_loai)
);

GO
CREATE TABLE Loai_dung_cu
(
	Ten_loai NVARCHAR(30) PRIMARY KEY
);

GO
CREATE TABLE Dung_cu
(
	Ten_dung_cu NVARCHAR(30) PRIMARY KEY,
	Mau_sac NVARCHAR(15),
	Kich_co FLOAT,
	DVT NVARCHAR(15),
	Tri_gia FLOAT NOT NULL CHECK(Tri_gia > 0),
	So_luong INT NOT NULL CHECK(So_luong >= 0),
	Ghi_chu NVARCHAR(150),
	Loai NVARCHAR(30),
	FOREIGN KEY (Loai) REFERENCES Loai_dung_cu(Ten_loai)
);

GO
CREATE TABLE Chuyen_khoa
(
	Ten NVARCHAR(30) PRIMARY KEY
);

GO
CREATE TABLE Bac_si
(
	Ma_bac_si VARCHAR(10) PRIMARY KEY,
	Chuyen_khoa NVARCHAR(30),
	FOREIGN KEY (Ma_bac_si) REFERENCES Nguoi_dung(Ma_nhan_vien),
	FOREIGN KEY (Chuyen_khoa) REFERENCES Chuyen_khoa(Ten)
);

GO
CREATE TABLE Chu
(
	Ma_chu VARCHAR(10) PRIMARY KEY,
	FOREIGN KEY (Ma_chu) REFERENCES Nguoi_dung(Ma_nhan_vien)
);

GO
CREATE TABLE Le_tan
(
	Ma_le_tan VARCHAR(10) PRIMARY KEY,
	FOREIGN KEY (Ma_le_tan) REFERENCES Nguoi_dung(Ma_nhan_vien)
);

GO
CREATE TABLE Ca_lam
(
	Ca INT CHECK (Ca BETWEEN 1 AND 3),
	Gio_bat_dau TIME,
	Gio_ket_thuc TIME,
	PRIMARY KEY (Ca)
);

GO
CREATE TABLE Lam_viec
(
	Ngay DATE,
	Ca INT,
	Ma_bac_si VARCHAR(10),
	Cham_cong NVARCHAR(15) CHECK (Cham_cong IN (N'Có mặt', N'Vắng', N'Chưa điểm danh')),
	PRIMARY KEY (Ngay, Ma_bac_si, Ca),
	FOREIGN KEY (Ma_bac_si) REFERENCES Bac_si(Ma_bac_si),
	FOREIGN KEY (Ca) REFERENCES Ca_lam(Ca)
);

GO
CREATE TABLE Benh_nhan
(
	CCCD NVARCHAR(12) PRIMARY KEY,
	Ho NVARCHAR(50) NOT NULL,
	Ten NVARCHAR(50) NOT NULL,
	Gioi_tinh NVARCHAR(3) CHECK(Gioi_tinh IN (N'Nam', N'Nữ')),
	Ngay_sinh Date,
	Tuoi INT CHECK (Tuoi > 0)
);

GO
CREATE TABLE Nguoi_kham
(
	STT VARCHAR(15) PRIMARY KEY,
	Ngay DATE,
	Ca INT CHECK (Ca BETWEEN 1 AND 3),
	Ma_benh_nhan NVARCHAR(12),
	Ma_le_tan VARCHAR(10),
	Ma_bac_si VARCHAR(10),
	Trang_thai NVARCHAR(15) CHECK (Trang_thai IN (N'Chưa tiếp nhận', N'Đã tiếp nhận', N'Đang điều trị', N'Đã điều trị')),
	Ghi_chu NVARCHAR(150) CHECK (Ghi_chu IN (N'Tái khám', N'Xong')),
	FOREIGN KEY (Ma_bac_si) REFERENCES Bac_si(Ma_bac_si),
	FOREIGN KEY (Ma_le_tan) REFERENCES Le_tan(Ma_le_tan),
	FOREIGN KEY (Ma_benh_nhan) REFERENCES Benh_nhan(CCCD)
);

GO
CREATE TABLE Chi_tieu_dung_cu
(
	ID VARCHAR(15),
	Ten_dung_cu NVARCHAR(30),
	So_luong INT,
	Thanh_tien FLOAT,
	STT VARCHAR(15),
	PRIMARY KEY (ID, STT, Ten_dung_cu),
	FOREIGN KEY (STT) REFERENCES Nguoi_kham(STT),
	FOREIGN KEY (Ten_dung_cu) REFERENCES Dung_cu(Ten_dung_cu)
);

GO
CREATE TABLE Hoa_don_Thuoc
(
	ID VARCHAR(15),
	STT VARCHAR(15),
	Ten_thuoc NVARCHAR(30),
	So_luong INT,
	Thanh_tien FLOAT,
	Ghi_chu NVARCHAR(150),
	PRIMARY KEY (ID, STT, Ten_thuoc),
	FOREIGN KEY (STT) REFERENCES Nguoi_kham(STT),
	FOREIGN KEY (Ten_thuoc) REFERENCES Thuoc(Ten_thuoc)
);

GO
CREATE TABLE Hoa_don_Dich_vu
(
	ID VARCHAR(15),
	STT VARCHAR(15),
	Ten_dich_vu NVARCHAR(50),
	So_luong INT,
	Thanh_tien FLOAT,
	Ghi_chu NVARCHAR(150),
	PRIMARY KEY (ID, STT, Ten_dich_vu),
	FOREIGN KEY (STT) REFERENCES Nguoi_kham(STT),
	FOREIGN KEY (Ten_dich_vu) REFERENCES Dich_vu(Ten_dich_vu)
);



GO
CREATE TABLE Phuong_thuc_thanh_toan
(
	Ten NVARCHAR(30) PRIMARY KEY CHECK(Ten IN (N'Tiền mặt', N'Chuyển khoản'))
);

GO
CREATE TABLE Thanh_toan
(
	ID VARCHAR(30) PRIMARY KEY,
	STT VARCHAR(15),
	Gio DATETIME,
	Tongtien FLOAT,
	Hinhthuc NVARCHAR(30),
	Tinhtrang NVARCHAR(30) CHECK (Tinhtrang IN (N'Chưa thanh toán', N'Đã thanh toán', N'Hủy thanh toán')),
	FOREIGN KEY (STT) REFERENCES Nguoi_kham(STT),
	FOREIGN KEY (Hinhthuc) REFERENCES Phuong_thuc_thanh_toan(Ten)
);
GO
CREATE TABLE Luong_them
(
	Ma INT PRIMARY KEY,
	Tien FLOAT,
	Gio DATETIME,
	IDHD VARCHAR(30),
	FOREIGN KEY (IDHD) REFERENCES Thanh_toan(ID)
);
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
GO
INSERT INTO Luong_co_dinh (Ma, So_tien) 
VALUES ('BSNC', 9000000), ('BSNRVTP', 7500000), ('BSPH', 8500000),
       ('BSCRVNN', 9200000), ('BSRTE', 7000000), ('BSTQ', 8000000), 
       ('CPK01', 50000000), ('LT', 5000000);
GO
INSERT INTO Nguoi_dung (Ma_nhan_vien, Ho, Ten, Gioi_tinh, Ngay_sinh, Email, Que_quan, CCCD, Maluong, Hoatdong)
VALUES ('LT01', N'Nguyễn', N'An', N'Nữ', '2000-02-01', '123@gmail.com', N'Hà Nội', '123456789012', 'LT', 1),
       ('LT02', N'Lê', N'Bình', N'Nữ', '1992-07-23', N'uchihaha3169@gmail.com', N'Đà Nẵng', '123456789013', 'LT', 1),
       ('BSTQ01', N'Nguyễn Minh', N'Luân', N'Nam', '1985-11-11', N'uchihi3169@gmail.com', N'Hải Phòng', '123456789014', 'BSTQ', 1),
       ('BSTQ02', N'Trần', N'Khang', N'Nam', '1990-07-15', '456@gmail.com', N'Đà Nẵng', '123456789015', 'BSTQ', 1),
       ('BSRTE01', N'Trần Thị', N'Nhàn', N'Nữ', '1988-04-12', '456@gmail.com', N'Đồng Tháp', '123456789016', 'BSRTE', 1),
       ('CPK01', N'Nguyễn Cao', N'Kỳ', N'Nam', '1978-03-09', '789@gmail.com', N'Quảng Ngãi', '123456789017', 'CPK01', 1);
Go
INSERT INTO Tai_khoan (Taikhoan, Matkhau, MaNV)
VALUES 
       ('BSTQ01', 'a', 'BSTQ01'),
       ('LT01', 'a', 'LT01'),
	   ('CPK01','a','CPK01');
GO
INSERT INTO Danh_muc_ki_thuat VALUES (N'Khám - Hồ sơ'), (N'Nhổ răng'), (N'Tiểu phẫu thuật'), (N'Nha chu'), 
                                     (N'Chữa răng - Nội nha'), (N'Chữa tủy'), (N'Phục hình tháo lắp'), 
                                     (N'Sửa chữa hàm'), (N'Điều trị tiền phục hình'), (N'Phục hình cố định'), 
                                     (N'Điều trị răng sữa'), (N'Chỉnh hình răng mặt'), (N'Khí cụ tháo lắp'), 
                                     (N'Khí cụ cố định'), (N'Nha công cộng'), (N'Điều trị loạn năng hệ thống nhai'), 
                                     (N'X-quang răng');
GO
INSERT INTO Dich_vu values(N'Răng cửa, răng nanh',N'Cái',50000,NULL,N'Nhổ răng')
INSERT INTO Dich_vu values(N'Răng cối nhỏ',N'Cái',60000,NULL,N'Nhổ răng')
INSERT INTO Dich_vu values(N'Răng cối lớn trên',N'Cái',70000,NULL,N'Nhổ răng')
INSERT INTO Dich_vu values(N'Răng cối lớn dưới',N'Cái',90000,NULL,N'Nhổ răng')
INSERT INTO Dich_vu values(N'Nhổ răng lung lay',N'Cái',50000,NULL,N'Nhổ răng')
INSERT INTO Dich_vu values(N'Nhổ chân răng vĩnh viễn',N'Cái',60000,NULL,N'Nhổ răng')
INSERT INTO Dich_vu values(N'Răng khôn mọc lệch nhổ tiểu phẫu',N'Cái',300000,NULL,N'Tiểu phẫu thuật')
INSERT INTO Dich_vu values(N'Phẫu thuật điều chỉnh xương ổ răng',N'Cái',200000,NULL,N'Tiểu phẫu thuật')
INSERT INTO Dich_vu values(N'Phẫu thuật cắt chóp',N'Cái',300000,NULL,N'Tiểu phẫu thuật')
INSERT INTO Dich_vu values(N'Cạo vôi răng',N'2 hàm',50000,NULL,N'Nha chu')
INSERT INTO Dich_vu values(N'Điều trị viêm nha chu không phẫu thuật',N'Vùng hàm',100000,N'Nạo túi nha chu',N'Nha chu')
INSERT INTO Dich_vu values(N'Phẫu thuật lật vạt làm sạch',N'Lần',100000,NULL,N'Nha chu')
INSERT INTO Dich_vu values(N'Cắt thắng',N'Lần',100000,NULL,N'Nha chu')
INSERT INTO Dich_vu values(N'Phẫu thuật nướu',N'Răng',500000,NULL,N'Nha chu')
INSERT INTO Dich_vu values(N'Tái tạo thân răng',N'Răng',150000,NULL,N'Chữa răng - Nội nha')
INSERT INTO Dich_vu values(N'Trám composite xoang I, III',N'Xoang',100000,NULL,N'Chữa răng - Nội nha')
INSERT INTO Dich_vu values(N'Trám composite xoang II, IV, V',N'Xoang',120000,NULL,N'Chữa răng - Nội nha')
INSERT INTO Dich_vu values(N'Trám GIC',N'Xoang',100000,NULL,N'Chữa răng - Nội nha')
INSERT INTO Dich_vu values(N'Trám đắp mặt, hở kẽ',N'Cái',200000,NULL,N'Chữa răng - Nội nha')
INSERT INTO Dich_vu values(N'Trám phòng ngừa',N'Cái',80000,NULL,N'Chữa răng - Nội nha')
INSERT INTO Dich_vu values(N'Răng cửa, răng nanh (Chữa tủy)',N'Cái',250000,N'4 phim',N'Chữa tủy')
INSERT INTO Dich_vu values(N'Răng cối nhỏ (Chữa tủy)',N'Cái',300000,N'4 phim',N'Chữa tủy')
INSERT INTO Dich_vu values(N'Răng cối lớn',N'Cái',400000,N'5 phim',N'Chữa tủy')
INSERT INTO Dich_vu values(N'Chữa tủy lại(đóng thêm)',N'Ống tủy',150000,NULL,N'Chữa tủy')
INSERT INTO Dich_vu values(N'1 răng',N'Răng',100000,NULL,N'Phục hình tháo lắp')
INSERT INTO Dich_vu values(N'1 hàm toàn hàm',N'Hàm',1500000,NULL,N'Phục hình tháo lắp')
INSERT INTO Dich_vu values(N'2 hàm toàn hàm',N'Hàm',3000000,NULL,N'Phục hình tháo lắp')
INSERT INTO Dich_vu values(N'Vá hàm',N'Hàm',100000,NULL,N'Sửa chữa hàm')
INSERT INTO Dich_vu values(N'Thay nền',N'Hàm',300000,NULL,N'Sửa chữa hàm')
INSERT INTO Dich_vu values(N'Đệm hàm nhựa nấu',N'Hàm',250000,NULL,N'Sửa chữa hàm')
INSERT INTO Dich_vu values(N'Thêm, thay móc',N'Cái',50000,NULL,N'Sửa chữa hàm')
INSERT INTO Dich_vu values(N'Thêm, thay răng',N'Cái',50000,NULL,N'Sửa chữa hàm')
INSERT INTO Dich_vu values(N'Chữa đau',N'Lần',50000,NULL,N'Sửa chữa hàm')
INSERT INTO Dich_vu values(N'Móc dẻo',N'Cái',200000,NULL,N'Sửa chữa hàm')
INSERT INTO Dich_vu values(N'Hàm dẻo',N'Cái',700000,NULL,N'Sửa chữa hàm')
INSERT INTO Dich_vu values(N'Hàm khung bộ(Răng tính riêng)',N'Cái',750000,NULL,N'Sửa chữa hàm')
INSERT INTO Dich_vu values(N'Đệm hàm nhựa tự cứng(Hàm cũ)',N'Hàm',100000,NULL,N'Điều trị tiền phục hình')
INSERT INTO Dich_vu values(N'Điều chỉnh khớp cắn(Hàm cũ)',N'Hàm',100000,NULL,N'Điều trị tiền phục hình')
INSERT INTO Dich_vu values(N'Tái tạo cùi răng(có chốt)',N'Răng',150000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Mão, cầu răng kim loại toàn diện',N'Răng',350000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Mão, cầu răng kim loại - sứ',N'Răng',500000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Sứ titan',NULL,700000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Hàm khung Ti(chưa bao gồm răng)',NULL,1500000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Sứ zirconia',NULL,2500000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Sứ cercon',NULL,3500000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Điều chỉnh, gắn lại, tháo PHCĐ',N'Răng',100000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Hàm tạm',N'Răng',50000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Mão tạm',N'Răng',15000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Cầu răng tạm',N'Răng',15000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Cùi giả đúc',N'Cái',100000,NULL,N'Phục hình cố định')
INSERT INTO Dich_vu values(N'Nhổ răng sữa(tê bôi)',N'Răng',20000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Nhổ răng sữa(tê chích)',N'Răng',50000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Trám răng sữa bằng GIC',N'Răng',50000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Trám răng sữa bằng composite',N'Răng',80000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Trám dự phòng hố rãnh mặt nhai',N'Răng',80000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Đặt gel Fluor phòng ngừa',N'Hàm',50000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Lấy tủy chân răng sữa',N'Răng',200000,N'2 phim',N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Mão nhựa răng cửa(Strip crown)',N'Răng',200000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Mão kim loại làm sẵn',N'Răng',250000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Bộ giữ khoảng tháo lắp',N'Hàm',250000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Giữ khoảng cố định 1 bên',N'Cái',400000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Bộ giữ khoảng cố định 2 bên',N'Bộ',800000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Mặt phẳng nghiêng',N'Cái',500000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Tấm chặn môi',N'Cái',500000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Khí cụ đẩy môi(lip bumper)',N'Cái',1000000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Khí cụ tháo lắp điều trị cắn chéo 1 răng',N'Cái',1000000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Khí cụ Quad Helix',N'Cái',1000000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'Tiểu phẫu',N'Lần',250000,NULL,N'Điều trị răng sữa')
INSERT INTO Dich_vu values(N'1 hàm',N'Hàm',1500000,NULL,N'Khí cụ tháo lắp')
INSERT INTO Dich_vu values(N'2 hàm',N'Hàm',3000000,NULL,N'Khí cụ tháo lắp')
INSERT INTO Dich_vu values(N'Làm lại khí cụ 1 hàm',N'Hàm',300000,NULL,N'Khí cụ tháo lắp')
INSERT INTO Dich_vu values(N'Làm lại khí cụ 2 hàm',N'Hàm',600000,NULL,N'Khí cụ tháo lắp')
INSERT INTO Dich_vu values(N'Khí cụ duy trì kết quả 1 hàm',N'Hàm',300000,NULL,N'Khí cụ tháo lắp')
INSERT INTO Dich_vu values(N'1 hàm (Khí cụ cố định)',N'Hàm',10000000,NULL,N'Khí cụ cố định')
INSERT INTO Dich_vu values(N'2 hàm (Khí cụ cố định)',N'Hàm',20000000,NULL,N'Khí cụ cố định')
INSERT INTO Dich_vu values(N'2 hàm điều trị trên 2 năm',N'Hàm',26000000,NULL,N'Khí cụ cố định')
INSERT INTO Dich_vu values(N'2 hàm sử dụng mắc cài thế hệ mới',N'Hàm',28000000,NULL,N'Khí cụ cố định')
INSERT INTO Dich_vu values(N'2 hàm sử dụng mắc cài sứ',N'Hàm',28000000,NULL,N'Khí cụ cố định')
INSERT INTO Dich_vu values(N'Máng Fluor không thuốc',N'Máng',100000,N'2 hàm',N'Nha công cộng')
INSERT INTO Dich_vu values(N'1 máng nhai',N'Máng',500000,NULL,N'Điều trị loạn năng hệ thống nhai')
INSERT INTO Dich_vu values(N'Màng chỉnh khớp cắn đơn giản',N'Lần',150000,NULL,N'Điều trị loạn năng hệ thống nhai')
INSERT INTO Dich_vu values(N'Màng chỉnh khớp cắn phức tạp',N'Lần',300000,NULL,N'Điều trị loạn năng hệ thống nhai')
INSERT INTO Dich_vu values(N'Phim quanh chóp',N'Phim',30000,NULL,N'X-quang răng')
INSERT INTO Dich_vu values(N'Phim toàn cảnh',N'Phim',100000,NULL,N'X-quang răng')
GO
INSERT INTO Loai_thuoc VALUES (N'Kháng viêm'), (N'Kháng sinh'), (N'Giảm đau');
GO
INSERT INTO Thuoc values(N'Amoxicillin 500',N'Hộp',10,120000,N'500mg',NULL,N'Kháng sinh')
INSERT INTO Thuoc values(N'Amoxicillin 625',N'Hộp',10,182000,N'625mg',NULL,N'Kháng sinh')
INSERT INTO Thuoc values(N'Amoxicillin 875',N'Hộp',10,126000,N'875mg',NULL,N'Kháng sinh')
INSERT INTO Thuoc values(N'Amoxicillin 1000',N'Hộp',10,275000,N'1000mg',NULL,N'Kháng sinh')
INSERT INTO Thuoc values(N'Metronidazol 250',N'Hộp',10,30000,N'250mg',NULL,N'Kháng sinh')
INSERT INTO Thuoc values(N'Metronidazol 500',N'Hộp',10,100000,N'500mg',NULL,N'Kháng sinh')
INSERT INTO Thuoc values(N'Cephalexin',N'Hộp',10,127000,N'500mg',NULL,N'Kháng sinh')
INSERT INTO Thuoc values(N'Medrol 4',N'Hộp',10,40000,N'4mg',NULL,N'Kháng viêm')
INSERT INTO Thuoc values(N'Medrol 16',N'Hộp',10,120000,N'16mg',NULL,N'Kháng viêm')
INSERT INTO Thuoc values(N'Ibuprofen 200',N'Hộp',10,43000,N'200mg',NULL,N'Kháng viêm')
INSERT INTO Thuoc values(N'Ibuprofen 400',N'Hộp',10,88000,N'400mg',NULL,N'Kháng viêm')
INSERT INTO Thuoc values(N'Diclofenac 50',N'Hộp',10,32000,N'50mg',NULL,N'Kháng viêm')
INSERT INTO Thuoc values(N'Diclofenac 75',N'Hộp',10,55000,N'75mg',NULL,N'Kháng viêm')
INSERT INTO Thuoc values(N'Paracetamol 500',N'Hộp',10,33000,N'500mg',NULL,N'Giảm đau')
INSERT INTO Thuoc values(N'Paracetamol 650',N'Hộp',10,56000,N'650mg',NULL,N'Giảm đau')
INSERT INTO Thuoc values(N'Dexamethasone',N'Hộp',10,150000,N'4mg',NULL,N'Giảm đau')
GO
INSERT INTO Loai_dung_cu VALUES (N'Vật liệu cố định'), (N'Vật liệu tiêu hao');
GO
INSERT INTO Dung_cu values(N'Mũi cạo vôi',N'Trắng',NULL,N'Cái',400000,10,NULL,N'Vật liệu cố định')
INSERT INTO Dung_cu values(N'Kèm',N'Trắng',NULL,N'Cái',300000,10,NULL,N'Vật liệu cố định')
INSERT INTO Dung_cu values(N'Nạy',N'Đen',NULL,N'Cái',100000,10,NULL,N'Vật liệu cố định')
INSERT INTO Dung_cu values(N'Bộ dụng cụ khám răng cơ bản',N'Trắng',NULL,N'Bộ',700000,10,NULL,N'Vật liệu cố định')
INSERT INTO Dung_cu values(N'Nạo ngà',N'Trắng',NULL,N'Cái',300000,10,NULL,N'Vật liệu cố định')
INSERT INTO Dung_cu values(N'Bay trám',N'Trắng',NULL,N'Cái',500000,10,NULL,N'Vật liệu cố định')
INSERT INTO Dung_cu values(N'Cây đo túi nướu',N'Trắng',NULL,N'Cái',40000,10,NULL,N'Vật liệu cố định')
INSERT INTO Dung_cu values(N'Đèn quang trùng hợp',N'Xanh dương',NULL,N'Cái',20000000,10,NULL,N'Vật liệu cố định')
INSERT INTO Dung_cu values(N'Ống chích sắt',N'Trắng',NULL,N'Cái',200000,10,NULL,N'Vật liệu cố định')
INSERT INTO Dung_cu values(N'Composite đặc',N'Đen',NULL,N'Ống',170000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Composite lỏng',N'Đen',NULL,N'Ống',100000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Cọ bond',N'Vàng',NULL,N'Cái',120000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Gòn',N'Trắng',NULL,N'Cái',5000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Mũi khoan kim cương',N'Đen',NULL,N'Cái',1000000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Sealer trám bít',N'Trắng',NULL,N'Ống',500000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Cone giấy',N'Trắng',NULL,N'Hộp',50000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Cone chính',N'Trắng',NULL,N'Hộp',500000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'NaOCl',N'Trắng',NULL,N'Chai',450000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'NaCL',N'Trắng',NULL,N'Chai',12000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'EDTA',N'Trắng',NULL,N'Ống',150000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Trâm tay',N'Đen',NULL,N'Bộ',300000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Trâm máy',N'Vàng',NULL,N'Cái',200000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Spongel',N'Trắng',NULL,N'Hộp',12000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Mũi đánh bóng',N'Trắng',NULL,N'Cái',100000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Chổi đánh bóng',N'Trắng',NULL,N'Hộp',200000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Sò đánh bóng',N'Nâu',NULL,N'Hộp',200000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Chỉ khâu',N'Trắng',NULL,N'Hộp',40000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Thuốc tê',N'Trắng',NULL,N'Hộp',900000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Formolcoresol',N'Đỏ',NULL,N'Chai',200000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'ZnO',N'Trắng',NULL,N'Chai',70000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'MTA',N'Trắng',NULL,N'Cái',2500000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'GIC',N'Trắng',NULL,N'Chai',1000000,10,NULL,N'Vật liệu tiêu hao')
INSERT INTO Dung_cu values(N'Trám tạm',N'Trắng',NULL,N'Hộp',100000,10,NULL,N'Vật liệu tiêu hao')
GO
INSERT INTO Chuyen_khoa values(N'Nha chu')
INSERT INTO Chuyen_khoa values(N'Nhổ răng và tiểu phẫu')
INSERT INTO Chuyen_khoa values(N'Phục hình')
INSERT INTO Chuyen_khoa values(N'Chữa răng và nội nha')
INSERT INTO Chuyen_khoa values(N'Răng trẻ em')
INSERT INTO Chuyen_khoa values(N'Tổng quát')
GO
INSERT INTO Bac_si (Ma_bac_si, Chuyen_khoa) VALUES ('BSTQ01', N'Tổng quát'), ('BSTQ02', N'Tổng quát'), ('BSRTE01', N'Răng trẻ em');
GO
INSERT INTO Chu (Ma_chu) VALUES ('CPK01');
GO
INSERT INTO Le_tan (Ma_le_tan) VALUES ('LT01'), ('LT02');
GO
INSERT INTO Ca_lam (Ca, Gio_bat_dau, Gio_ket_thuc)
VALUES (1, '08:00:00', '12:00:00'), (2, '13:00:00', '17:00:00'), (3, '18:00:00', '22:00:00');
GO
INSERT INTO Lam_viec (Ngay, Ca, Ma_bac_si, Cham_cong)
VALUES ('2024-05-10', 1, 'BSTQ02', N'Có mặt'), ('2024-05-10', 3, 'BSTQ02', N'Chưa điểm danh');
Go
INSERT INTO Benh_nhan (CCCD, Ho, Ten, Gioi_tinh, Ngay_sinh, Tuoi)
VALUES ('987654321001', N'Phạm', N'Huy', N'Nam', '1979-10-15', 45),
       ('987654321002', N'Trần', N'Thảo', N'Nữ', '1996-08-07', 28);
GO
INSERT INTO Nguoi_kham (STT, Ngay, Ca, Ma_benh_nhan, Ma_le_tan, Ma_bac_si, Trang_thai, Ghi_chu)
VALUES ('KH001', '2024-11-01', 1, '987654321001', 'LT01', 'BSTQ01', N'Đang điều trị', N'Tái khám');
Go
INSERT INTO Chi_tieu_dung_cu (ID, Ten_dung_cu, So_luong, Thanh_tien, STT)
VALUES ('CT0001', N'Chỉ khâu', 1, 40000, 'KH001');
GO
INSERT INTO Hoa_don_Thuoc (ID, STT, Ten_thuoc, So_luong, Thanh_tien, Ghi_chu)
VALUES ('HDT0001', 'KH001', N'Amoxicillin 875', 1, 126000, N'Uống sau khi ăn')
GO
INSERT INTO Hoa_don_Dich_vu (ID, STT, Ten_dich_vu, So_luong, Thanh_tien, Ghi_chu)
VALUES ('HDDV0001', 'KH001', N'1 răng', 1, 100000, NULL);
GO
INSERT INTO Phuong_thuc_thanh_toan (Ten) VALUES (N'Tiền mặt'), (N'Chuyển khoản');

GO
INSERT INTO Thanh_toan (ID, STT, Gio, Tongtien, Hinhthuc, Tinhtrang)
VALUES ('TT001', 'KH001', '2024-11-01 10:00', 670000, N'Tiền mặt', N'Đã thanh toán');
GO
INSERT INTO Luong_them (Ma, Tien, Gio, IDHD)
VALUES 
(1, 200000, '2024-11-01 11:00', 'TT001'),
(2, 150000, '2024-11-02 16:00', 'TT001');

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
Go
CREATE PROCEDURE proc_check_login
    @taikhoan NVARCHAR(50),
    @matkhau NVARCHAR(50),
    @message NVARCHAR(1000) OUTPUT
AS
BEGIN
    -- Khởi tạo giá trị mặc định cho output parameter
    SET @message = '';

    -- Check if the account exists
    IF NOT EXISTS (SELECT 1 FROM Tai_khoan WHERE Taikhoan = @taikhoan)
    BEGIN
        SET @message = N'Không tìm thấy tài khoản';
        RETURN;
    END

    -- Check if the account is active
    IF NOT EXISTS (
        SELECT 1 
        FROM Tai_khoan tk 
        JOIN Nguoi_dung nd ON tk.MaNV = nd.Ma_nhan_vien
        WHERE tk.Taikhoan = @taikhoan AND nd.Hoatdong = 1
    )
    BEGIN
        SET @message = N'Tài khoản không hoạt động';
        RETURN;
    END

    -- Check if the password is correct
    IF NOT EXISTS (
        SELECT 1 
        FROM Tai_khoan 
        WHERE Taikhoan = @taikhoan AND Matkhau = @matkhau
    )
    BEGIN
        SET @message = N'Sai mật khẩu';

        RETURN;
    END
    SET @message = N'Đăng nhập thành công';
END
GO
CREATE PROCEDURE ThemThuoc
    @Ten_thuoc NVARCHAR(30),
    @DVT NVARCHAR(15),
    @So_luong INT,
    @Gia_ban FLOAT,
    @Ham_luong NVARCHAR(10),
    @Ghi_chu NVARCHAR(150),
    @Ten_loai NVARCHAR(30)
AS
BEGIN
    INSERT INTO Thuoc (Ten_thuoc, DVT, So_luong, Gia_ban, Ham_luong, Ghi_chu, Ten_loai)
    VALUES (@Ten_thuoc, @DVT, @So_luong, @Gia_ban, @Ham_luong, @Ghi_chu, @Ten_loai);
END;
GO
CREATE PROCEDURE ThemDungCu
    @Ten_dung_cu NVARCHAR(30),
	@Mau_sac NVARCHAR(15),
	@Kich_co FLOAT,
    @DVT NVARCHAR(15),
    @Tri_gia FLOAT,
    @So_luong INT,
    @Ghi_chu NVARCHAR(150),
    @Loai NVARCHAR(30)
AS
BEGIN
    INSERT INTO Dung_cu (Ten_dung_cu, Mau_sac, Kich_co, DVT, Tri_gia, So_luong,  Ghi_chu,  Loai)
    VALUES (@Ten_dung_cu, @Mau_sac, @Kich_co, @DVT, @Tri_gia, @So_luong, @Ghi_chu, @Loai);
END;
GO
CREATE PROCEDURE ThemDichVu
    @Ten_dich_vu NVARCHAR(30),
	@Don_vi_tinh NVARCHAR(15),
	@Don_gia FLOAT,
    @Ghi_chu NVARCHAR(150),
    @Ten_danh_muc NVARCHAR(30)
AS
BEGIN
    INSERT INTO Dich_vu (Ten_dich_vu, Don_vi_tinh, Don_gia, Ghi_chu, Ten_danh_muc)
    VALUES (@Ten_dich_vu, @Don_vi_tinh, @Don_gia, @Ghi_chu, @Ten_danh_muc);
END;
GO
create proc [dbo].[proc_thongtin] @taikhoan VARCHAR(30)
as
	begin
		 select Ma_nhan_vien,ho,ten,Gioi_tinh from Nguoi_dung inner join Tai_khoan on Tai_khoan.MaNV = Nguoi_dung.Ma_nhan_vien
		 where @taikhoan = Taikhoan
	end
GO
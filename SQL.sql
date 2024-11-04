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
	Que_quan NVARCHAR(30),
	CCCD NVARCHAR(12) UNIQUE,
	Maluong VARCHAR(10),
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

GO
INSERT INTO Chuyen_khoa values(N'Nha chu')
INSERT INTO Chuyen_khoa values(N'Nhổ răng và tiểu phẫu')
INSERT INTO Chuyen_khoa values(N'Phục hình')
INSERT INTO Chuyen_khoa values(N'Chữa răng và nội nha')
INSERT INTO Chuyen_khoa values(N'Răng trẻ em')
INSERT INTO Chuyen_khoa values(N'Tổng quát')

GO
INSERT INTO Loai_dung_cu values(N'Vật liệu cố định')
INSERT INTO Loai_dung_cu values(N'Vật liệu tiêu hao')

GO
INSERT INTO Loai_thuoc values(N'Kháng viêm')
INSERT INTO Loai_thuoc values(N'Kháng sinh')
INSERT INTO Loai_thuoc values(N'Giảm đau')

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
INSERT INTO Danh_muc_ki_thuat values(N'Khám - Hồ sơ')
INSERT INTO Danh_muc_ki_thuat values(N'Nhổ răng')
INSERT INTO Danh_muc_ki_thuat values(N'Tiểu phẫu thuật')
INSERT INTO Danh_muc_ki_thuat values(N'Nha chu')
INSERT INTO Danh_muc_ki_thuat values(N'Chữa răng - Nội nha')
INSERT INTO Danh_muc_ki_thuat values(N'Chữa tủy')
INSERT INTO Danh_muc_ki_thuat values(N'Phục hình tháo lắp')
INSERT INTO Danh_muc_ki_thuat values(N'Sửa chữa hàm')
INSERT INTO Danh_muc_ki_thuat values(N'Điều trị tiền phục hình')
INSERT INTO Danh_muc_ki_thuat values(N'Phục hình cố định')
INSERT INTO Danh_muc_ki_thuat values(N'Điều trị răng sữa')
INSERT INTO Danh_muc_ki_thuat values(N'Chỉnh hình răng mặt')
INSERT INTO Danh_muc_ki_thuat values(N'Khí cụ tháo lắp')
INSERT INTO Danh_muc_ki_thuat values(N'Khí cụ cố định')
INSERT INTO Danh_muc_ki_thuat values(N'Nha công cộng')
INSERT INTO Danh_muc_ki_thuat values(N'Điều trị loạn năng hệ thống nhai')
INSERT INTO Danh_muc_ki_thuat values(N'X-quang răng')

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
INSERT INTO Luong_co_dinh values('BSNC',9000000)
INSERT INTO Luong_co_dinh values('BSNRVTP',7500000)
INSERT INTO Luong_co_dinh values('BSPH',8500000)
INSERT INTO Luong_co_dinh values('BSCRVNN',9200000)
INSERT INTO Luong_co_dinh values('BSRTE',7000000)
INSERT INTO Luong_co_dinh values('BSTQ',8000000)
INSERT INTO Luong_co_dinh values('LT',5000000)
INSERT INTO Luong_co_dinh values('CPK',50000000)
Go
INSERT INTO Tai_khoan (Taikhoan, Matkhau) values ('admin@gmail.com', 'admin');
INSERT INTO Tai_khoan (Taikhoan, Matkhau) values ('a', 'a');
GO
CREATE PROCEDURE proc_check_login
    @taikhoan NVARCHAR(50),
    @matkhau NVARCHAR(50),
    @message NVARCHAR(1000) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra thông tin tài khoản và mật khẩu
    IF EXISTS (SELECT 1 FROM Tai_khoan WHERE Taikhoan = @taikhoan AND Matkhau = @matkhau)
    BEGIN
        -- Nếu tài khoản và mật khẩu hợp lệ
        SET @message = N'Đăng nhập thành công.'
    END
    ELSE
    BEGIN
        -- Nếu tài khoản hoặc mật khẩu không chính xác
        SET @message = N'Tên tài khoản hoặc mật khẩu không chính xác.'
    END
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
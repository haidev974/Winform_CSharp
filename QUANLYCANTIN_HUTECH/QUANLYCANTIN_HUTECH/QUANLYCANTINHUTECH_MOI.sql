create database QuanLyCanTinMoi
go 
use QuanLyCanTinMoi
go

Create table [PHIEU_AN]
(
	[MA_PHIEU_AN] Char(10) NOT NULL,
	[MA_THONG_KE] Char(10) NOT NULL,
	[MA_NV] Char(10) NOT NULL,
	[MA_KH] Char(10) NOT NULL,
	[NGAY_LAP] Datetime NULL,
	[TONG_TIEN] Decimal(18,2) NULL,
	[PHUONG_THUC_THANH_TOAN] Bit NULL,
Primary Key ([MA_PHIEU_AN])
) 
go

Create table [MAT_HANG]
(
	[MA_HANG] Char(10) NOT NULL,
	[MA_LOAI_HANG] Char(10) NOT NULL,
	[TEN_HANG] Nvarchar(50) NULL,
	[HAN_SU_DUNG] Nvarchar(50) NULL,
	[SO_LUONG_TON] Float NULL,
	[DON_VI_TINH] Nvarchar(50) NULL,
Primary Key ([MA_HANG])
) 
go

Create table [PHIEU_NHAP_HANG]
(
	[MA_NHAP_HANG] Char(10) NOT NULL,
	[MA_NV] Char(10) NOT NULL,
	[NGAY_NHAP_HANG] Datetime NULL,
	[TONG_TIEN_NHAP] Decimal(18,2) NULL,
Primary Key ([MA_NHAP_HANG])
) 
go

Create table [PHIEU_THONG_KE]
(
	[MA_THONG_KE] Char(10) NOT NULL,
	[MA_NV] Char(10) NOT NULL,
	[NGAY_BAT_DAU_THONG_KE] Datetime NULL,
	[NGAY_KET_THUC_THONG_KE] Datetime NULL,
	[NGAY_THONG_KE] Datetime NULL,
	[TONG_SL_BAN] Integer NULL,
	[TONG_DOANH_THU] Decimal(18,2) NULL,
	[THUE_HANG_NAM] Decimal(18,2) NULL,
Primary Key ([MA_THONG_KE])
) 
go

Create table [KHUYEN_MAI]
(
	[MA_KHUYEN_MAI] Char(10) NOT NULL,
	[TEN_KHUYEN_MAI] Nvarchar(50) NULL,
	[NGAY_BAT_DAU] Datetime NULL,
	[NGAY_KET_THUC] Datetime NULL,
Primary Key ([MA_KHUYEN_MAI])
) 
go

Create table [KHACH_HANG]
(
	[MA_KH] Char(10) NOT NULL,
	[HO_TEN_KH] Nvarchar(100) NULL,
	[DIA_CHI] Nvarchar(200) NULL,
	[SDT] Char(10) NULL,
	[EMAIL] Nvarchar(50) NULL,
Primary Key ([MA_KH])
) 
go

Create table [LOAI_HANG]
(
	[MA_LOAI_HANG] Char(10) NOT NULL,
	[TEN_LOAI_HANG] Nvarchar(50) NULL,
Primary Key ([MA_LOAI_HANG])
) 
go

Create table [CHI_TIET_PHIEU_AN]
(
	[MA_PHIEU_AN] Char(10) NOT NULL,
	[MA_KHUYEN_MAI] Char(10) NOT NULL,
	[MA_HANG] Char(10) NOT NULL,
	[GIA_BAN] Decimal(18,2) NULL,
	[DON_VI_TINH] Nvarchar(10) NULL,
	[SO_LUONG_MUA] Float NULL,
Primary Key ([MA_PHIEU_AN],[MA_HANG])
) 
go

Create table [CHI_TIET_NHAP_HANG]
(
	[MA_NHAP_HANG] Char(10) NOT NULL,
	[MA_HANG] Char(10) NOT NULL,
	[SO_LUONG_NHAP] Float NULL,
	[GIA_MUA] Decimal(18,2) NULL,
	[DON_VI_TINH] Nvarchar(50) NULL,
Primary Key ([MA_NHAP_HANG],[MA_HANG])
) 
go

Create table [CHUC_VU]
(
	[MA_CV] Char(10) NOT NULL,
	[TEN_CV] Nvarchar(50) NULL,
	[LUONG_CB] Decimal(18,2) NULL,
	[HE_SO_LUONG] Float NULL,
	[TRO_CAP] Decimal(18,2) NULL,
Primary Key ([MA_CV])
) 
go

Create table [NHAN_VIEN]
(
	[MA_NV] Char(10) NOT NULL,
	[MA_CV] Char(10) NOT NULL,
	[HO_VA_TEN_NV] Nvarchar(100) NULL,
	[NTNS] Datetime NULL,
	[PHAI] Bit NULL,
	[SDT] Char(10) NULL,
	[EMAIL] Nvarchar(50) NULL,
	[TRANG_THAI_LAM_VIEC] Bit NULL,
	[CA_LV] Nvarchar(20) NULL,
	[NGAY_BAT_DAU_LAM_VIEC] Datetime NULL,
	[NGAY_KET_THUC_LAM_VIEC] Datetime NULL,
	[MAT_KHAU] Nchar(50) NULL,
Primary Key ([MA_NV])
) 
go


Alter table [CHI_TIET_PHIEU_AN] add  foreign key([MA_PHIEU_AN]) references [PHIEU_AN] ([MA_PHIEU_AN])  on update no action on delete no action 
go
Alter table [CHI_TIET_PHIEU_AN] add  foreign key([MA_HANG]) references [MAT_HANG] ([MA_HANG])  on update no action on delete no action 
go
Alter table [CHI_TIET_NHAP_HANG] add  foreign key([MA_HANG]) references [MAT_HANG] ([MA_HANG])  on update no action on delete no action 
go
Alter table [CHI_TIET_NHAP_HANG] add  foreign key([MA_NHAP_HANG]) references [PHIEU_NHAP_HANG] ([MA_NHAP_HANG])  on update no action on delete no action 
go
Alter table [PHIEU_AN] add  foreign key([MA_THONG_KE]) references [PHIEU_THONG_KE] ([MA_THONG_KE])  on update no action on delete no action 
go
Alter table [CHI_TIET_PHIEU_AN] add  foreign key([MA_KHUYEN_MAI]) references [KHUYEN_MAI] ([MA_KHUYEN_MAI])  on update no action on delete no action 
go
Alter table [PHIEU_AN] add  foreign key([MA_KH]) references [KHACH_HANG] ([MA_KH])  on update no action on delete no action 
go
Alter table [MAT_HANG] add  foreign key([MA_LOAI_HANG]) references [LOAI_HANG] ([MA_LOAI_HANG])  on update no action on delete no action 
go
Alter table [NHAN_VIEN] add  foreign key([MA_CV]) references [CHUC_VU] ([MA_CV])  on update no action on delete no action 
go
Alter table [PHIEU_THONG_KE] add  foreign key([MA_NV]) references [NHAN_VIEN] ([MA_NV])  on update no action on delete no action 
go
Alter table [PHIEU_NHAP_HANG] add  foreign key([MA_NV]) references [NHAN_VIEN] ([MA_NV])  on update no action on delete no action 
go
Alter table [PHIEU_AN] add  foreign key([MA_NV]) references [NHAN_VIEN] ([MA_NV])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go

INSERT INTO LOAI_HANG (MA_LOAI_HANG, TEN_LOAI_HANG) VALUES
('LH001', N'Thức uống'),
('LH002', N'Đồ ăn nhanh'),
('LH003', N'Bánh ngọt'),
('LH004', N'Trái cây'),
('LH005', N'Món ăn truyền thống'),
('LH006', N'Đồ ăn nhẹ'),
('LH007', N'Salad'),
('LH008', N'Món chay'),
('LH009', N'Món ăn vặt'),
('LH010', N'Súp'),
('LH011', N'Nước trái cây'),
('LH012', N'Nước ép'),
('LH013', N'Bánh mì'),
('LH014', N'Mì ăn liền'),
('LH015', N'Cà phê'),
('LH016', N'Trà'),
('LH017', N'Nước khoáng'),
('LH018', N'Thịt nướng'),
('LH019', N'Món hải sản'),
('LH020', N'Kem');

INSERT INTO MAT_HANG (MA_HANG, MA_LOAI_HANG, TEN_HANG, HAN_SU_DUNG, SO_LUONG_TON, DON_VI_TINH) VALUES
('MH001', 'LH001', N'Nước ngọt', '2025-12-31', 100, N'Chai'),
('MH002', 'LH001', N'Trà sữa', '2025-12-31', 50, N'Ly'),
('MH003', 'LH002', N'Burger', '2024-11-30', 80, N'Chiếc'),
('MH004', 'LH002', N'Khoai tây chiên', '2024-11-30', 60, N'Phần'),
('MH005', 'LH003', N'Bánh kem', '2024-12-25', 30, N'Cái'),
('MH006', 'LH004', N'Xoài', '2024-10-31', 200, N'Kg'),
('MH007', 'LH005', N'Phở', '2024-10-15', 40, N'Bát'),
('MH008', 'LH001', N'Nước dừa', '2025-06-30', 150, N'Chai'),
('MH009', 'LH001', N'Nước chanh', '2025-03-15', 75, N'Ly'),
('MH010', 'LH002', N'Pizza', '2024-12-10', 20, N'Chiếc'),
('MH011', 'LH002', N'Bánh mì kẹp', '2024-11-20', 45, N'Cái'),
('MH012', 'LH003', N'Bánh quy', '2025-01-01', 100, N'Hộp'),
('MH013', 'LH004', N'Nho', '2024-10-30', 80, N'Kg'),
('MH014', 'LH004', N'Chuối', '2024-12-05', 120, N'Kg'),
('MH015', 'LH005', N'Cơm tấm', '2024-10-20', 35, N'Đĩa'),
('MH016', 'LH005', N'Bánh xèo', '2024-10-25', 50, N'Cái'),
('MH017', 'LH005', N'Gỏi cuốn', '2024-12-01', 60, N'Phần'),
('MH018', 'LH005', N'Chả giò', '2024-11-15', 70, N'Phần'),
('MH019', 'LH005', N'Bún bò Huế', '2024-10-22', 30, N'Bát'),
('MH020', 'LH005', N'Mì Quảng', '2024-11-05', 40, N'Bát');


INSERT INTO KHUYEN_MAI (MA_KHUYEN_MAI, TEN_KHUYEN_MAI, NGAY_BAT_DAU, NGAY_KET_THUC) VALUES
('KM001', N'Giảm giá 10%', '2024-10-01', '2024-10-31'),
('KM002', N'Mua 1 tặng 1', '2024-10-15', '2024-10-30'),
('KM003', N'Giảm giá 15% cho đồ ăn nhanh', '2024-11-01', '2024-11-15'),
('KM004', N'Mua 2 tặng 1', '2024-11-05', '2024-11-20'),
('KM005', N'Giảm giá 5.000 VNĐ cho nước ngọt', '2024-11-10', '2024-11-30'),
('KM006', N'Giảm giá 20% cho bánh ngọt', '2024-11-15', '2024-12-05'),
('KM007', N'Giảm giá 10% cho món ăn truyền thống', '2024-11-20', '2024-12-15'),
('KM008', N'Giảm giá 1.000 VNĐ cho trà sữa', '2024-11-25', '2024-12-10'),
('KM009', N'Mua 1 bánh xèo tặng 1 nước', '2024-12-01', '2024-12-20'),
('KM010', N'Giảm giá 25% cho pizza', '2024-12-05', '2024-12-31'),
('KM011', N'Giảm giá 10% cho tất cả món ăn', '2024-12-10', '2024-12-30'),
('KM012', N'Tặng thêm 1 phần ăn cho đơn trên 50.000 VNĐ', '2024-12-15', '2024-12-25'),
('KM013', N'Giảm giá 30% cho kem', '2024-12-20', '2025-01-05'),
('KM014', N'Giảm giá 5% cho đồ uống', '2025-01-01', '2025-01-15'),
('KM015', N'Tặng 1 phần tráng miệng cho đơn trên 100.000 VNĐ', '2025-01-10', '2025-01-20'),
('KM016', N'Mua 3 tặng 1 cho đồ ăn nhẹ', '2025-01-15', '2025-01-31'),
('KM017', N'Giảm giá 10% cho món ăn chay', '2025-01-20', '2025-02-10'),
('KM018', N'Giảm giá 20% cho món ăn vặt', '2025-01-25', '2025-02-15'),
('KM019', N'Mua 2 nước tặng 1 bánh ngọt', '2025-02-01', '2025-02-28'),
('KM020', N'Giảm giá 15% cho món súp', '2025-02-05', '2025-02-28');


INSERT INTO KHACH_HANG (MA_KH, HO_TEN_KH, DIA_CHI, SDT, EMAIL) VALUES
('KH001', N'Nguyễn Văn A', N'Hà Nội', '0123456789', 'vana@example.com'),
('KH002', N'Trần Thị B', N'Hồ Chí Minh', '0987654321', 'thib@example.com'),
('KH003', N'Lê Văn C', N'Đà Nẵng', '0912345678', 'vanc@example.com'),
('KH004', N'Nguyễn Thị D', N'Hải Phòng', '0901234567', 'thid@example.com'),
('KH005', N'Phạm Văn E', N'Cần Thơ', '0981122334', 'vane@example.com'),
('KH006', N'Vũ Thị F', N'Nha Trang', '0123123456', 'thif@example.com'),
('KH007', N'Trần Văn G', N'Biên Hòa', '0934567890', 'vang@example.com'),
('KH008', N'Nguyễn Thị H', N'Thái Nguyên', '0919876543', 'h@example.com'),
('KH009', N'Lê Văn I', N'Nam Định', '0945678901', 'vi@example.com'),
('KH010', N'Nguyễn Văn J', N'Bắc Ninh', '0961234567', 'vanj@example.com'),
('KH011', N'Phạm Thị K', N'Vĩnh Long', '0912345679', 'thik@example.com'),
('KH012', N'Đỗ Văn L', N'Hà Tĩnh', '0981234567', 'val@example.com'),
('KH013', N'Nguyễn Thị M', N'Quảng Ninh', '0902345678', 'm@example.com'),
('KH014', N'Lê Văn N', N'Kon Tum', '0941234567', 'vanm@example.com'),
('KH015', N'Nguyễn Văn O', N'Phú Quốc', '0987654322', 'vano@example.com'),
('KH016', N'Trần Thị P', N'Bến Tre', '0913456789', 'thip@example.com'),
('KH017', N'Phạm Văn Q', N'Sóc Trăng', '0932345678', 'vanq@example.com'),
('KH018', N'Nguyễn Thị R', N'Đắk Lắk', '0918765432', 'vir@example.com'),
('KH019', N'Lê Văn S', N'Hà Giang', '0942345678', 'vans@example.com'),
('KH020', N'Trần Văn T', N'Tây Ninh', '0987654323', 'vant@example.com');


INSERT INTO CHUC_VU (MA_CV, TEN_CV, LUONG_CB, HE_SO_LUONG, TRO_CAP) VALUES
('CV001', N'Nhân viên phục vụ', 3000000, 1.0, 500000),
('CV002', N'Quản lý', 7000000, 1.5, 1000000),
('CV003', N'Bếp trưởng', 6000000, 1.4, 800000),
('CV004', N'Nhân viên bếp', 2500000, 1.0, 400000),
('CV005', N'Nhân viên thu ngân', 2800000, 1.0, 450000),
('CV006', N'Nhân viên vệ sinh', 2300000, 1.0, 300000),
('CV007', N'Chuyên viên marketing', 4000000, 1.2, 600000),
('CV008', N'Nhân viên giao hàng', 2700000, 1.0, 350000),
('CV009', N'Nhân viên IT', 5000000, 1.2, 700000),
('CV010', N'Nhân viên chăm sóc khách hàng', 3200000, 1.0, 500000),
('CV011', N'Nhân viên mua hàng', 3500000, 1.0, 600000),
('CV012', N'Nhân viên kế toán', 5500000, 1.2, 700000),
('CV013', N'Nhân viên bảo trì', 4000000, 1.0, 600000),
('CV014', N'Nhân viên hỗ trợ kỹ thuật', 4000000, 1.1, 600000),
('CV015', N'Nhân viên kho', 3000000, 1.0, 500000),
('CV016', N'Nhân viên giao hàng', 2700000, 1.0, 350000),
('CV017', N'Nhân viên bán hàng', 3500000, 1.0, 600000),
('CV018', N'Nhân viên phục vụ đồ uống', 2800000, 1.0, 400000),
('CV019', N'Nhân viên tiếp thị', 3200000, 1.0, 500000),
('CV020', N'Nhân viên vệ sinh nhà bếp', 2300000, 1.0, 300000);

INSERT INTO NHAN_VIEN (MA_NV, MA_CV, HO_VA_TEN_NV, NTNS, PHAI, SDT, EMAIL, TRANG_THAI_LAM_VIEC, CA_LV, NGAY_BAT_DAU_LAM_VIEC, MAT_KHAU) VALUES
('NV001', 'CV001', N'Nguyễn Văn C', '1995-01-15', 1, '0123456789', 'vanc@gmail.com', 1, 'Ca 1', '2023-01-01', 'password123'),
('NV002', 'CV002', N'Trần Thị D', '1990-05-20', 0, '0987654321', 'd@gmail.com', 1, 'Ca 2', '2022-05-01', 'password456'),
('NV003', 'CV001', N'Nguyễn Văn E', '1992-03-10', 1, '0123456780', 'vane@gmail.com', 1, 'Ca 1', '2023-01-15', 'password789'),
('NV004', 'CV001', N'Lê Thị F', '1994-07-22', 0, '0123456781', 'f@gmail.com', 1, 'Ca 2', '2023-02-01', 'password101'),
('NV005', 'CV001', N'Phạm Văn G', '1991-06-18', 1, '0123456782', 'g@gmail.com', 1, 'Ca 1', '2023-02-10', 'password202'),
('NV006', 'CV001', N'Đặng Thị H', '1993-11-29', 0, '0123456783', 'h@gmail.com', 1, 'Ca 2', '2023-03-01', 'password303'),
('NV007', 'CV001', N'Bùi Văn I', '1990-12-12', 1, '0123456784', 'i@gmail.com', 1, 'Ca 1', '2023-03-15', 'password404'),
('NV008', 'CV001', N'Nguyễn Thị J', '1995-09-05', 0, '0123456785', 'j@gmail.com', 1, 'Ca 2', '2023-04-01', 'password505'),
('NV009', 'CV001', N'Trần Văn K', '1994-02-20', 1, '0123456786', 'k@gmail.com', 1, 'Ca 1', '2023-04-10', 'password606'),
('NV010', 'CV001', N'Lê Thị L', '1996-04-15', 0, '0123456787', 'l@gmail.com', 1, 'Ca 2', '2023-05-01', 'password707'),
('NV011', 'CV001', N'Phạm Văn M', '1992-08-30', 1, '0123456788', 'm@gmail.com', 1, 'Ca 1', '2023-05-15', 'password808'),
('NV012', 'CV001', N'Nguyễn Thị N', '1993-05-05', 0, '0123456789', 'n@gmail.com', 1, 'Ca 2', '2023-06-01', 'password909'),
('NV013', 'CV001', N'Trần Văn O', '1991-03-03', 1, '0123456790', 'o@gmail.com', 1, 'Ca 1', '2023-06-15', 'password010'),
('NV014', 'CV001', N'Lê Thị P', '1995-09-18', 0, '0123456791', 'p@gmail.com', 1, 'Ca 2', '2023-07-01', 'password111'),
('NV015', 'CV001', N'Nguyễn Văn Q', '1990-11-25', 1, '0123456792', 'q@gmail.com', 1, 'Ca 1', '2023-07-15', 'password212'),
('NV016', 'CV001', N'Trần Thị R', '1996-02-14', 0, '0123456793', 'r@gmail.com', 1, 'Ca 2', '2023-08-01', 'password313'),
('NV017', 'CV001', N'Bùi Văn S', '1993-06-08', 1, '0123456794', 's@gmail.com', 1, 'Ca 1', '2023-08-15', 'password414'),
('NV018', 'CV001', N'Nguyễn Thị T', '1994-10-22', 0, '0123456795', 't@gmail.com', 1, 'Ca 2', '2023-09-01', 'password515'),
('NV019', 'CV001', N'Trần Văn U', '1995-07-30', 1, '0123456796', 'u@gmail.com', 1, 'Ca 1', '2023-09-15', 'password616'),
('NV020', 'CV001', N'Lê Thị V', '1990-04-09', 0, '0123456797', 'v@gmail.com', 1, 'Ca 2', '2023-10-01', 'password717');


INSERT INTO PHIEU_THONG_KE (MA_THONG_KE, MA_NV, NGAY_BAT_DAU_THONG_KE, NGAY_KET_THUC_THONG_KE, NGAY_THONG_KE, TONG_SL_BAN, TONG_DOANH_THU, THUE_HANG_NAM) VALUES
('TK001', 'NV002', '2024-10-01', '2024-10-31', '2024-10-31', 150, 5000000, 500000),
('TK002', 'NV001', '2024-10-01', '2024-10-15', '2024-10-15', 100, 3000000, 300000),
('TK003', 'NV001', '2024-10-01', '2024-10-05', '2024-10-05', 80, 2500000, 250000),
('TK004', 'NV002', '2024-10-06', '2024-10-15', '2024-10-15', 70, 2200000, 220000),
('TK005', 'NV001', '2024-10-10', '2024-10-20', '2024-10-20', 60, 1800000, 180000),
('TK006', 'NV002', '2024-10-01', '2024-10-25', '2024-10-25', 90, 3500000, 350000),
('TK007', 'NV001', '2024-10-01', '2024-10-15', '2024-10-15', 50, 1500000, 150000),
('TK008', 'NV002', '2024-10-01', '2024-10-30', '2024-10-30', 110, 4000000, 400000),
('TK009', 'NV001', '2024-10-15', '2024-10-20', '2024-10-20', 75, 2250000, 225000),
('TK010', 'NV002', '2024-10-01', '2024-10-10', '2024-10-10', 55, 1650000, 165000),
('TK011', 'NV001', '2024-10-12', '2024-10-22', '2024-10-22', 65, 1950000, 195000),
('TK012', 'NV002', '2024-10-20', '2024-10-30', '2024-10-30', 95, 3300000, 330000),
('TK013', 'NV001', '2024-10-01', '2024-10-18', '2024-10-18', 120, 4500000, 450000),
('TK014', 'NV002', '2024-10-15', '2024-10-25', '2024-10-25', 130, 4800000, 480000),
('TK015', 'NV001', '2024-10-05', '2024-10-15', '2024-10-15', 140, 4700000, 470000),
('TK016', 'NV002', '2024-10-01', '2024-10-20', '2024-10-20', 80, 2700000, 270000),
('TK017', 'NV001', '2024-10-12', '2024-10-31', '2024-10-31', 160, 6000000, 600000),
('TK018', 'NV002', '2024-10-08', '2024-10-18', '2024-10-18', 150, 5500000, 550000),
('TK019', 'NV001', '2024-10-15', '2024-10-31', '2024-10-31', 140, 5000000, 500000),
('TK020', 'NV002', '2024-10-20', '2024-10-30', '2024-10-30', 100, 4000000, 400000);


INSERT INTO PHIEU_NHAP_HANG (MA_NHAP_HANG, MA_NV, NGAY_NHAP_HANG, TONG_TIEN_NHAP) VALUES
('NH001', 'NV002', '2024-10-10', 2000000),
('NH002', 'NV001', '2024-10-15', 1500000),
('NH003', 'NV001', '2024-10-01', 3000000),
('NH004', 'NV002', '2024-10-05', 2500000),
('NH005', 'NV001', '2024-10-20', 3500000),
('NH006', 'NV002', '2024-10-12', 4000000),
('NH007', 'NV001', '2024-10-07', 2700000),
('NH008', 'NV002', '2024-10-18', 3200000),
('NH009', 'NV001', '2024-10-25', 2900000),
('NH010', 'NV002', '2024-10-30', 3100000),
('NH011', 'NV001', '2024-10-15', 2300000),
('NH012', 'NV002', '2024-10-01', 1800000),
('NH013', 'NV001', '2024-10-05', 2000000),
('NH014', 'NV002', '2024-10-20', 2200000),
('NH015', 'NV001', '2024-10-22', 2600000),
('NH016', 'NV002', '2024-10-03', 2400000),
('NH017', 'NV001', '2024-10-10', 2100000),
('NH018', 'NV002', '2024-10-14', 2500000),
('NH019', 'NV001', '2024-10-08', 2700000),
('NH020', 'NV002', '2024-10-11', 2800000);


INSERT INTO PHIEU_AN (MA_PHIEU_AN, MA_THONG_KE, MA_NV, MA_KH, NGAY_LAP, TONG_TIEN, PHUONG_THUC_THANH_TOAN) VALUES
('PA001', 'TK001', 'NV001', 'KH001', '2024-10-15', 500000, 1),
('PA002', 'TK002', 'NV002', 'KH002', '2024-10-16', 300000, 0),
('PA003', 'TK001', 'NV001', 'KH001', '2024-10-17', 450000, 1),
('PA004', 'TK002', 'NV002', 'KH002', '2024-10-18', 700000, 0),
('PA005', 'TK001', 'NV001', 'KH001', '2024-10-19', 600000, 1),
('PA006', 'TK002', 'NV002', 'KH002', '2024-10-20', 800000, 1),
('PA007', 'TK001', 'NV001', 'KH001', '2024-10-21', 550000, 0),
('PA008', 'TK002', 'NV002', 'KH002', '2024-10-22', 900000, 1),
('PA009', 'TK001', 'NV001', 'KH001', '2024-10-23', 750000, 1),
('PA010', 'TK002', 'NV002', 'KH002', '2024-10-24', 400000, 0),
('PA011', 'TK001', 'NV001', 'KH001', '2024-10-25', 500000, 1),
('PA012', 'TK002', 'NV002', 'KH002', '2024-10-26', 650000, 0),
('PA013', 'TK001', 'NV001', 'KH001', '2024-10-27', 720000, 1),
('PA014', 'TK002', 'NV002', 'KH002', '2024-10-28', 380000, 0),
('PA015', 'TK001', 'NV001', 'KH001', '2024-10-29', 610000, 1),
('PA016', 'TK002', 'NV002', 'KH002', '2024-10-30', 720000, 0),
('PA017', 'TK001', 'NV001', 'KH001', '2024-10-31', 580000, 1),
('PA018', 'TK002', 'NV002', 'KH002', '2024-10-31', 740000, 1),
('PA019', 'TK001', 'NV001', 'KH001', '2024-10-30', 630000, 0),
('PA020', 'TK002', 'NV002', 'KH002', '2024-10-29', 490000, 1);

INSERT INTO CHI_TIET_NHAP_HANG (MA_NHAP_HANG, MA_HANG, SO_LUONG_NHAP, GIA_MUA, DON_VI_TINH) VALUES
-- NH001
('NH001', 'MH001', 50, 10000, N'Chai'),
('NH001', 'MH003', 20, 50000, N'Chiếc'),
('NH001', 'MH005', 15, 60000, N'Cái'),
('NH001', 'MH007', 30, 40000, N'Bát'),

-- NH002
('NH002', 'MH002', 30, 15000, N'Ly'),
('NH002', 'MH004', 25, 35000, N'Phần'),
('NH002', 'MH006', 60, 18000, N'Kg'),
('NH002', 'MH008', 80, 11000, N'Chai'),

-- NH003
('NH003', 'MH006', 100, 20000, N'Kg'),
('NH003', 'MH009', 50, 17000, N'Ly'),
('NH003', 'MH010', 10, 120000, N'Chiếc'),
('NH003', 'MH012', 20, 55000, N'Hộp'),

-- NH004
('NH004', 'MH007', 25, 45000, N'Bát'),
('NH004', 'MH014', 50, 15000, N'Kg'),
('NH004', 'MH017', 35, 29000, N'Phần'),
('NH004', 'MH018', 40, 37000, N'Phần'),

-- NH005
('NH005', 'MH008', 100, 12000, N'Chai'),
('NH005', 'MH015', 30, 34000, N'Đĩa'),
('NH005', 'MH019', 20, 43000, N'Bát'),
('NH005', 'MH020', 25, 32000, N'Bát'),

-- NH006
('NH006', 'MH012', 20, 50000, N'Hộp'),
('NH006', 'MH013', 50, 32000, N'Kg'),
('NH006', 'MH014', 40, 22000, N'Kg'),
('NH006', 'MH016', 25, 29000, N'Cái'),

-- NH007
('NH007', 'MH001', 75, 10500, N'Chai'),
('NH007', 'MH005', 18, 63000, N'Cái'),
('NH007', 'MH009', 60, 17500, N'Ly'),
('NH007', 'MH011', 30, 28000, N'Cái'),

-- NH008
('NH008', 'MH013', 90, 31000, N'Kg'),
('NH008', 'MH017', 40, 29000, N'Phần'),
('NH008', 'MH018', 60, 39000, N'Phần'),
('NH008', 'MH019', 25, 42000, N'Bát'),

-- NH009
('NH009', 'MH002', 40, 16000, N'Ly'),
('NH009', 'MH003', 30, 55000, N'Chiếc'),
('NH009', 'MH006', 80, 19000, N'Kg'),
('NH009', 'MH010', 15, 115000, N'Chiếc'),

-- NH010
('NH010', 'MH004', 50, 34000, N'Phần'),
('NH010', 'MH015', 35, 33000, N'Đĩa'),
('NH010', 'MH016', 40, 27000, N'Cái'),
('NH010', 'MH020', 30, 30000, N'Bát'),

-- NH011
('NH011', 'MH001', 60, 11000, N'Chai'),
('NH011', 'MH005', 20, 62000, N'Cái'),
('NH011', 'MH007', 35, 42000, N'Bát'),
('NH011', 'MH018', 50, 38000, N'Phần'),

-- NH012
('NH012', 'MH008', 120, 12500, N'Chai'),
('NH012', 'MH011', 40, 27000, N'Cái'),
('NH012', 'MH019', 20, 41000, N'Bát'),
('NH012', 'MH017', 45, 30000, N'Phần'),

-- NH013
('NH013', 'MH002', 35, 14000, N'Ly'),
('NH013', 'MH004', 50, 33000, N'Phần'),
('NH013', 'MH006', 100, 21000, N'Kg'),
('NH013', 'MH012', 30, 54000, N'Hộp'),

-- NH014
('NH014', 'MH009', 75, 16000, N'Ly'),
('NH014', 'MH013', 80, 32000, N'Kg'),
('NH014', 'MH015', 40, 35000, N'Đĩa'),
('NH014', 'MH018', 50, 36000, N'Phần'),

-- NH015
('NH015', 'MH003', 50, 51000, N'Chiếc'),
('NH015', 'MH007', 25, 44000, N'Bát'),
('NH015', 'MH010', 20, 119000, N'Chiếc'),
('NH015', 'MH016', 45, 31000, N'Cái'),

-- NH016
('NH016', 'MH005', 25, 63000, N'Cái'),
('NH016', 'MH011', 55, 30000, N'Cái'),
('NH016', 'MH012', 40, 55000, N'Hộp'),
('NH016', 'MH020', 35, 32000, N'Bát'),

-- NH017
('NH017', 'MH001', 70, 10800, N'Chai'),
('NH017', 'MH003', 40, 54000, N'Chiếc'),
('NH017', 'MH008', 110, 12300, N'Chai'),
('NH017', 'MH019', 15, 43000, N'Bát'),

-- NH018
('NH018', 'MH007', 30, 46000, N'Bát'),
('NH018', 'MH012', 50, 57000, N'Hộp'),
('NH018', 'MH015', 35, 37000, N'Đĩa'),
('NH018', 'MH018', 60, 41000, N'Phần'),

-- NH019
('NH019', 'MH004', 40, 35000, N'Phần'),
('NH019', 'MH013', 70, 30000, N'Kg'),
('NH019', 'MH016', 50, 31000, N'Cái'),
('NH019', 'MH017', 30, 31000, N'Phần'),

-- NH020
('NH020', 'MH002', 50, 14500, N'Ly'),
('NH020', 'MH005', 30, 61000, N'Cái'),
('NH020', 'MH009', 60, 18000, N'Ly'),
('NH020', 'MH012', 40, 52000, N'Hộp');


INSERT INTO CHI_TIET_PHIEU_AN (MA_PHIEU_AN, MA_KHUYEN_MAI, MA_HANG, GIA_BAN, DON_VI_TINH, SO_LUONG_MUA)
VALUES
-- Phiếu ăn PA001
('PA001', 'KM001', 'MH001', 12000, N'Chai', 3),
('PA001', 'KM001', 'MH003', 50000, N'Chiếc', 2),
('PA001', 'KM002', 'MH005', 60000, N'Cái', 1),
('PA001', 'KM002', 'MH004', 25000, N'Phần', 2),
-- Phiếu ăn PA002
('PA002', 'KM003', 'MH002', 25000, N'Ly', 4),
('PA002', 'KM004', 'MH007', 35000, N'Bát', 2),
('PA002', 'KM005', 'MH008', 15000, N'Chai', 3),
('PA002', 'KM003', 'MH009', 10000, N'Ly', 2),
-- Phiếu ăn PA003
('PA003', 'KM004', 'MH007', 35000, N'Bát', 1),
('PA003', 'KM006', 'MH010', 80000, N'Chiếc', 1),
('PA003', 'KM004', 'MH011', 45000, N'Cái', 1),
('PA003', 'KM005', 'MH012', 10000, N'Hộp', 2),
-- Phiếu ăn PA004
('PA004', 'KM006', 'MH002', 25000, N'Ly', 4),
('PA004', 'KM007', 'MH004', 20000, N'Phần', 2),
('PA004', 'KM008', 'MH014', 12000, N'Kg', 3),
('PA004', 'KM009', 'MH015', 35000, N'Đĩa', 2),
-- Phiếu ăn PA005
('PA005', 'KM010', 'MH016', 50000, N'Cái', 1),
('PA005', 'KM011', 'MH017', 45000, N'Phần', 2),
('PA005', 'KM012', 'MH018', 30000, N'Phần', 2),
('PA005', 'KM013', 'MH019', 45000, N'Bát', 3),
-- Phiếu ăn PA006
('PA006', 'KM014', 'MH020', 35000, N'Bát', 2),
('PA006', 'KM015', 'MH001', 12000, N'Chai', 5),
('PA006', 'KM016', 'MH006', 15000, N'Kg', 4),
('PA006', 'KM017', 'MH005', 60000, N'Cái', 1),
-- Phiếu ăn PA007
('PA007', 'KM018', 'MH002', 25000, N'Ly', 3),
('PA007', 'KM019', 'MH003', 50000, N'Chiếc', 2),
('PA007', 'KM020', 'MH004', 20000, N'Phần', 1),
('PA007', 'KM018', 'MH008', 15000, N'Chai', 4),
-- Phiếu ăn PA008
('PA008', 'KM001', 'MH007', 35000, N'Bát', 1),
('PA008', 'KM002', 'MH010', 80000, N'Chiếc', 1),
('PA008', 'KM003', 'MH012', 10000, N'Hộp', 3),
('PA008', 'KM004', 'MH011', 45000, N'Cái', 1),
-- Phiếu ăn PA009
('PA009', 'KM005', 'MH002', 25000, N'Ly', 2),
('PA009', 'KM006', 'MH004', 20000, N'Phần', 2),
('PA009', 'KM007', 'MH017', 45000, N'Phần', 3),
('PA009', 'KM008', 'MH018', 30000, N'Phần', 2),
-- Phiếu ăn PA010
('PA010', 'KM009', 'MH019', 45000, N'Bát', 4),
('PA010', 'KM010', 'MH014', 12000, N'Kg', 3),
('PA010', 'KM011', 'MH015', 35000, N'Đĩa', 1),
('PA010', 'KM012', 'MH001', 12000, N'Chai', 5),
-- Phiếu ăn PA011
('PA011', 'KM013', 'MH016', 50000, N'Cái', 1),
('PA011', 'KM014', 'MH020', 35000, N'Bát', 3),
('PA011', 'KM015', 'MH002', 25000, N'Ly', 2),
('PA011', 'KM016', 'MH003', 50000, N'Chiếc', 2),
-- Phiếu ăn PA012
('PA012', 'KM017', 'MH007', 35000, N'Bát', 1),
('PA012', 'KM018', 'MH009', 10000, N'Ly', 4),
('PA012', 'KM019', 'MH005', 60000, N'Cái', 1),
('PA012', 'KM020', 'MH017', 45000, N'Phần', 2),
-- Phiếu ăn PA013
('PA013', 'KM001', 'MH019', 45000, N'Bát', 2),
('PA013', 'KM002', 'MH004', 20000, N'Phần', 3),
('PA013', 'KM003', 'MH010', 80000, N'Chiếc', 1),
('PA013', 'KM004', 'MH012', 10000, N'Hộp', 2),
-- Phiếu ăn PA014
('PA014', 'KM005', 'MH001', 12000, N'Chai', 4),
('PA014', 'KM006', 'MH003', 50000, N'Chiếc', 2),
('PA014', 'KM007', 'MH018', 30000, N'Phần', 1),
('PA014', 'KM008', 'MH014', 12000, N'Kg', 5),
-- Phiếu ăn PA015
('PA015', 'KM009', 'MH007', 35000, N'Bát', 2),
('PA015', 'KM010', 'MH002', 25000, N'Ly', 2),
('PA015', 'KM011', 'MH004', 20000, N'Phần', 3),
('PA015', 'KM012', 'MH017', 45000, N'Phần', 2),
-- Phiếu ăn PA016
('PA016', 'KM013', 'MH020', 35000, N'Bát', 1),
('PA016', 'KM014', 'MH019', 45000, N'Bát', 4),
('PA016', 'KM015', 'MH015', 35000, N'Đĩa', 3),
('PA016', 'KM016', 'MH008', 15000, N'Chai', 2),
-- Phiếu ăn PA017
('PA017', 'KM017', 'MH005', 60000, N'Cái', 2),
('PA017', 'KM018', 'MH002', 25000, N'Ly', 3),
('PA017', 'KM019', 'MH013', 10000, N'Kg', 3),
('PA017', 'KM020', 'MH014', 12000, N'Kg', 2),
-- Phiếu ăn PA018
('PA018', 'KM001', 'MH009', 10000, N'Ly', 5),
('PA018', 'KM002', 'MH017', 45000, N'Phần', 1),
('PA018', 'KM003', 'MH012', 10000, N'Hộp', 3),
('PA018', 'KM004', 'MH016', 50000, N'Cái', 2),
-- Phiếu ăn PA019
('PA019', 'KM005', 'MH006', 15000, N'Kg', 5),
('PA019', 'KM006', 'MH018', 30000, N'Phần', 1),
('PA019', 'KM007', 'MH002', 25000, N'Ly', 2),
('PA019', 'KM008', 'MH019', 45000, N'Bát', 4),
-- Phiếu ăn PA020
('PA020', 'KM009', 'MH007', 35000, N'Bát', 1),
('PA020', 'KM010', 'MH002', 25000, N'Ly', 3),
('PA020', 'KM011', 'MH004', 20000, N'Phần', 2),
('PA020', 'KM012', 'MH005', 60000, N'Cái', 1);
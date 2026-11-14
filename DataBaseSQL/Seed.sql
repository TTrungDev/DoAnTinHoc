-- =====================================================
-- 02_seed.sql - Dữ liệu mẫu cho LibraryManagement
-- Chạy SAU khi đã chạy file tạo bảng (01_schema.sql)
-- Chạy lại được nhiều lần: script xóa dữ liệu cũ rồi nạp lại
-- Mật khẩu mẫu: admin / admin123, lan và khoa / thuthu123, độc giả / docgia123
-- Hash là SHA-256 dạng HEX IN HOA, code C# phải tạo hash cùng định dạng
-- Ngày mượn/trả tính theo ngày hôm nay nên luôn có sách đang quá hạn để test
-- =====================================================
USE LibraryManagement;
GO

-- Xóa dữ liệu cũ (bảng con trước, bảng cha sau)
DELETE FROM WalletTransactions;
DELETE FROM BorrowDetails;
DELETE FROM BorrowRecords;
DELETE FROM Books;
DELETE FROM Publishers;
DELETE FROM Authors;
DELETE FROM Categories;
DELETE FROM Accounts;
DELETE FROM Users;
DELETE FROM Settings;

DECLARE @Today DATE = CAST(GETDATE() AS DATE); --

-- ---------- Settings ----------
INSERT INTO Settings (SettingKey, SettingValue, Description) VALUES
('MaxBorrowDays',     N'14',   N'Số ngày mượn tối đa'),
('FinePerDay',        N'2000', N'Tiền phạt mỗi ngày trả trễ (VND)'),
('MaxBooksPerReader', N'5',    N'Số sách tối đa một độc giả được mượn cùng lúc');

-- ---------- Users (1 admin, 2 thủ thư, 6 độc giả) ----------
INSERT INTO Users (FullName, BirthDate, Gender, PhoneNumber, Email, Address, Balance) VALUES
(N'Quản Trị Viên',    '1990-01-15', N'Nam', '0900000001', 'admin@library.com',      N'TP. Hồ Chí Minh', 0),
(N'Nguyễn Thị Lan',   '1995-05-20', N'Nữ',  '0900000002', 'lan@library.com',        N'TP. Hồ Chí Minh', 0),
(N'Trần Minh Khoa',   '1996-09-12', N'Nam', '0900000003', 'khoa@library.com',       N'TP. Hồ Chí Minh', 0),
(N'Lê Văn An',        '2004-03-10', N'Nam', '0901111111', 'an.le@gmail.com',        N'Quận 1, TP. Hồ Chí Minh', 42000),
(N'Trần Thu Hà',      '2003-07-25', N'Nữ',  '0902222222', 'ha.tran@gmail.com',      N'Quận 3, TP. Hồ Chí Minh', 30000),
(N'Phạm Quốc Bảo',    '2004-11-02', N'Nam', '0903333333', 'bao.pham@gmail.com',     N'Quận 7, TP. Hồ Chí Minh', 100000),
(N'Nguyễn Hồng Nhung','2002-12-30', N'Nữ',  '0904444444', 'nhung.nguyen@gmail.com', N'Thủ Đức, TP. Hồ Chí Minh', 20000),
(N'Võ Minh Tuấn',     '2005-02-18', N'Nam', '0905555555', 'tuan.vo@gmail.com',      N'Quận Bình Thạnh, TP. Hồ Chí Minh', 0),
(N'Đặng Gia Hân',     '2003-08-08', N'Nữ',  '0906666666', 'han.dang@gmail.com',     N'Quận 10, TP. Hồ Chí Minh', 46000);

DECLARE @Lan INT   = (SELECT UserID FROM Users WHERE Email = 'lan@library.com'); 
DECLARE @Khoa INT  = (SELECT UserID FROM Users WHERE Email = 'khoa@library.com');
DECLARE @An INT    = (SELECT UserID FROM Users WHERE Email = 'an.le@gmail.com');
DECLARE @Ha INT    = (SELECT UserID FROM Users WHERE Email = 'ha.tran@gmail.com');
DECLARE @Bao INT   = (SELECT UserID FROM Users WHERE Email = 'bao.pham@gmail.com');
DECLARE @Nhung INT = (SELECT UserID FROM Users WHERE Email = 'nhung.nguyen@gmail.com');
DECLARE @Tuan INT  = (SELECT UserID FROM Users WHERE Email = 'tuan.vo@gmail.com');
DECLARE @Han INT   = (SELECT UserID FROM Users WHERE Email = 'han.dang@gmail.com');

-- ---------- Accounts ----------
INSERT INTO Accounts (UserID, Username, PasswordHash, Role) VALUES
((SELECT UserID FROM Users WHERE Email = 'admin@library.com'), 'admin', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin123'), 2),  'Admin'),
(@Lan,   'lan',   CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'thuthu123'), 2), 'Librarian'),
(@Khoa,  'khoa',  CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'thuthu123'), 2), 'Librarian'),
(@An,    'an',    CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'docgia123'), 2), 'Reader'),
(@Ha,    'ha',    CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'docgia123'), 2), 'Reader'),
(@Bao,   'bao',   CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'docgia123'), 2), 'Reader'),
(@Nhung, 'nhung', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'docgia123'), 2), 'Reader'),
(@Tuan,  'tuan',  CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'docgia123'), 2), 'Reader'),
(@Han,   'han',   CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'docgia123'), 2), 'Reader');

-- ---------- Lịch sử quỹ (Amount dương = nạp, âm = trừ phạt) ----------
-- Số dư Users.Balance ở trên đã khớp với các giao dịch này
INSERT INTO WalletTransactions (UserID, Amount, TransType, Note, CreatedBy, CreatedAt) VALUES
(@An,    50000,  'Deposit', N'Nạp quỹ tại quầy',          @Lan,  DATEADD(DAY,-35,GETDATE())),
(@An,    -8000,  'Fine',    N'Phạt trả sách trễ 4 ngày',  @Lan,  DATEADD(DAY,-12,GETDATE())),
(@Ha,    30000,  'Deposit', N'Nạp quỹ tại quầy',          @Khoa, DATEADD(DAY,-22,GETDATE())),
(@Bao,   100000, 'Deposit', N'Nạp quỹ tại quầy',          @Lan,  DATEADD(DAY,-15,GETDATE())),
(@Nhung, 20000,  'Deposit', N'Nạp quỹ tại quầy',          @Khoa, DATEADD(DAY,-26,GETDATE())),
(@Han,   50000,  'Deposit', N'Nạp quỹ tại quầy',          @Khoa, DATEADD(DAY,-45,GETDATE())),
(@Han,   -4000,  'Fine',    N'Phạt trả sách trễ 2 ngày',  @Khoa, DATEADD(DAY,-24,GETDATE()));
GO

-- ---------- Danh mục ----------
INSERT INTO Categories (CategoryName, Description) VALUES
(N'Văn học',       N'Tiểu thuyết, truyện ngắn'),
(N'Kỹ năng sống',  N'Phát triển bản thân, giao tiếp'),
(N'Công nghệ',     N'Lập trình, công nghệ thông tin'),
(N'Khoa học',      N'Khoa học tự nhiên và xã hội'),
(N'Lịch sử',       N'Lịch sử và văn hóa'),
(N'Thiếu nhi',     N'Sách cho trẻ em và thiếu niên');

INSERT INTO Authors (AuthorName) VALUES
(N'Tô Hoài'), (N'Nguyễn Nhật Ánh'), (N'Paulo Coelho'), (N'Nam Cao'),
(N'Dale Carnegie'), (N'Robert C. Martin'), (N'Yuval Noah Harari'), (N'Stephen Hawking');

INSERT INTO Publishers (PublisherName) VALUES
(N'NXB Kim Đồng'), (N'NXB Trẻ'), (N'NXB Văn học'), (N'NXB Thế Giới'), (N'NXB Thông tin và Truyền thông');

-- ---------- Sách ----------
-- Available = Quantity(số lượng gốc) - số cuốn đang được mượn chưa trả (khớp với phiếu mượn bên dưới)
INSERT INTO Books (Title, CategoryID, AuthorID, PublisherID, PublishYear, Quantity, Available, Description) VALUES
(N'Dế Mèn phiêu lưu ký',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Thiếu nhi'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Tô Hoài'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Kim Đồng'),
 2019, 5, 3, N'Cuộc phiêu lưu của chú Dế Mèn qua nhiều vùng đất, gặp gỡ nhiều loài vật và rút ra bài học về tình bạn, lòng dũng cảm.'),
(N'Tôi thấy hoa vàng trên cỏ xanh',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Văn học'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Nguyễn Nhật Ánh'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Trẻ'),
 2018, 6, 5, N'Câu chuyện tuổi thơ ở làng quê nghèo, nói về tình anh em, tình bạn và những ký ức trong trẻo.'),
(N'Mắt biếc',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Văn học'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Nguyễn Nhật Ánh'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Trẻ'),
 2019, 4, 4, N'Mối tình đơn phương kéo dài từ thời thơ ấu của Ngạn dành cho Hà Lan, đẹp và buồn.'),
(N'Cho tôi xin một vé đi tuổi thơ',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Thiếu nhi'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Nguyễn Nhật Ánh'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Trẻ'),
 2017, 5, 4, N'Những trò nghịch ngợm, suy nghĩ ngộ nghĩnh của trẻ con được kể lại bằng góc nhìn của người lớn nhớ về tuổi thơ.'),
(N'Nhà giả kim',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Văn học'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Paulo Coelho'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Văn học'),
 2020, 3, 2, N'Hành trình của chàng chăn cừu Santiago đi tìm kho báu, qua đó khám phá ý nghĩa cuộc sống và theo đuổi ước mơ.'),
(N'Chí Phèo',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Văn học'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Nam Cao'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Văn học'),
 2017, 4, 4, N'Bi kịch của người nông dân bị đẩy đến đường cùng trong xã hội phong kiến, tác phẩm hiện thực tiêu biểu.'),
(N'Đắc nhân tâm',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Kỹ năng sống'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Dale Carnegie'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Trẻ'),
 2018, 8, 7, N'Các nguyên tắc giao tiếp và ứng xử để tạo thiện cảm, thuyết phục và xây dựng các mối quan hệ.'),
(N'Clean Code',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Công nghệ'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Robert C. Martin'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Thông tin và Truyền thông'),
 2021, 3, 2, N'Hướng dẫn viết mã nguồn sạch, dễ đọc, dễ bảo trì cho lập trình viên, kèm nhiều ví dụ và nguyên tắc thiết kế.'),
(N'Sapiens: Lược sử loài người',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Lịch sử'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Yuval Noah Harari'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Thế Giới'),
 2020, 5, 4, N'Lịch sử loài người từ thời săn bắt hái lượm đến cách mạng khoa học, nông nghiệp và xã hội hiện đại.'),
(N'Homo Deus',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Khoa học'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Yuval Noah Harari'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Thế Giới'),
 2019, 2, 2, N'Dự đoán tương lai của loài người khi công nghệ sinh học và trí tuệ nhân tạo thay đổi cách sống.'),
(N'Lược sử thời gian',
 (SELECT CategoryID FROM Categories WHERE CategoryName = N'Khoa học'),
 (SELECT AuthorID FROM Authors WHERE AuthorName = N'Stephen Hawking'),
 (SELECT PublisherID FROM Publishers WHERE PublisherName = N'NXB Thế Giới'),
 2016, 3, 2, N'Giải thích vũ trụ, hố đen, thời gian và nguồn gốc của vũ trụ bằng ngôn ngữ dễ hiểu cho người đọc phổ thông.');

DECLARE @bDeMen INT      = (SELECT BookID FROM Books WHERE Title = N'Dế Mèn phiêu lưu ký');
DECLARE @bHoaVang INT    = (SELECT BookID FROM Books WHERE Title = N'Tôi thấy hoa vàng trên cỏ xanh');
DECLARE @bMatBiec INT    = (SELECT BookID FROM Books WHERE Title = N'Mắt biếc');
DECLARE @bVeTuoiTho INT  = (SELECT BookID FROM Books WHERE Title = N'Cho tôi xin một vé đi tuổi thơ');
DECLARE @bGiaKim INT     = (SELECT BookID FROM Books WHERE Title = N'Nhà giả kim');
DECLARE @bChiPheo INT    = (SELECT BookID FROM Books WHERE Title = N'Chí Phèo');
DECLARE @bDacNhanTam INT = (SELECT BookID FROM Books WHERE Title = N'Đắc nhân tâm');
DECLARE @bCleanCode INT  = (SELECT BookID FROM Books WHERE Title = N'Clean Code');
DECLARE @bSapiens INT    = (SELECT BookID FROM Books WHERE Title = N'Sapiens: Lược sử loài người');
DECLARE @bHomoDeus INT   = (SELECT BookID FROM Books WHERE Title = N'Homo Deus');
DECLARE @bThoiGian INT   = (SELECT BookID FROM Books WHERE Title = N'Lược sử thời gian');

---- ---------- Phiếu mượn ----------
---- BR1: đã trả hết, 1 cuốn trả trễ 4 ngày (phạt 8.000)
--INSERT INTO BorrowRecords (UserID, IssuedBy, BorrowDate, DueDate) VALUES (@An, @Lan, DATEADD(DAY,-30,@Today), DATEADD(DAY,-16,@Today));
--DECLARE @br1 INT = SCOPE_IDENTITY();
---- BR2: Hà trả 1 cuốn đúng hạn, còn 1 cuốn QUÁ HẠN 6 ngày
--INSERT INTO BorrowRecords (UserID, IssuedBy, BorrowDate, DueDate) VALUES (@Ha, @Khoa, DATEADD(DAY,-20,@Today), DATEADD(DAY,-6,@Today));
--DECLARE @br2 INT = SCOPE_IDENTITY();
---- BR3: Bảo đang mượn, chưa tới hạn
--INSERT INTO BorrowRecords (UserID, IssuedBy, BorrowDate, DueDate) VALUES (@Bao, @Lan, DATEADD(DAY,-10,@Today), DATEADD(DAY,4,@Today));
--DECLARE @br3 INT = SCOPE_IDENTITY();
---- BR4: Nhung QUÁ HẠN 11 ngày, cả 2 cuốn chưa trả
--INSERT INTO BorrowRecords (UserID, IssuedBy, BorrowDate, DueDate) VALUES (@Nhung, @Khoa, DATEADD(DAY,-25,@Today), DATEADD(DAY,-11,@Today));
--DECLARE @br4 INT = SCOPE_IDENTITY();
---- BR5: Tuấn đang mượn, chưa tới hạn (mượn 2 cuốn Dế Mèn)
--INSERT INTO BorrowRecords (UserID, IssuedBy, BorrowDate, DueDate) VALUES (@Tuan, @Lan, DATEADD(DAY,-5,@Today), DATEADD(DAY,9,@Today));
--DECLARE @br5 INT = SCOPE_IDENTITY();
---- BR6: Hân đã trả hết, 1 cuốn trễ 2 ngày (phạt 4.000)
--INSERT INTO BorrowRecords (UserID, IssuedBy, BorrowDate, DueDate) VALUES (@Han, @Khoa, DATEADD(DAY,-40,@Today), DATEADD(DAY,-26,@Today));
--DECLARE @br6 INT = SCOPE_IDENTITY();
---- BR7: An mượn thêm, chưa tới hạn
--INSERT INTO BorrowRecords (UserID, IssuedBy, BorrowDate, DueDate) VALUES (@An, @Lan, DATEADD(DAY,-3,@Today), DATEADD(DAY,11,@Today));
--DECLARE @br7 INT = SCOPE_IDENTITY();

---- ---------- Chi tiết phiếu mượn (ReturnDate NULL = chưa trả) ----------
--INSERT INTO BorrowDetails (BorrowID, BookID, Quantity, ReturnDate, FineAmount) VALUES
--(@br1, @bMatBiec,    1, DATEADD(DAY,-18,@Today), 0),
--(@br1, @bChiPheo,    1, DATEADD(DAY,-12,@Today), 8000),
--(@br2, @bDacNhanTam, 1, DATEADD(DAY,-8,@Today),  0),
--(@br2, @bGiaKim,     1, NULL, 0),
--(@br3, @bCleanCode,  1, NULL, 0),
--(@br3, @bSapiens,    1, NULL, 0),
--(@br4, @bHoaVang,    1, NULL, 0),
--(@br4, @bThoiGian,   1, NULL, 0),
--(@br5, @bDeMen,      2, NULL, 0),
--(@br5, @bDacNhanTam, 1, NULL, 0),
--(@br6, @bMatBiec,    1, DATEADD(DAY,-27,@Today), 0),
--(@br6, @bHomoDeus,   1, DATEADD(DAY,-24,@Today), 4000),
--(@br7, @bVeTuoiTho,  1, NULL, 0);


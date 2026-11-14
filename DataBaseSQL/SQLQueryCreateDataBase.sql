CREATE DATABASE LibraryManagement;
GO

USE LibraryManagement; 
GO

-- Users: thong tin ca nhan cua moi nguoi (admin, thu thu, doc gia)
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    BirthDate DATE NULL,
    Gender NVARCHAR(10) NULL CHECK (Gender IN (N'Nam', N'Nữ')),
    PhoneNumber VARCHAR(15) NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Address NVARCHAR(200) NULL,
    Balance DECIMAL(12,0) NOT NULL DEFAULT 0 CHECK (Balance >= 0), -- So du quy (chi dung cho doc gia)
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Accounts: Thông tin đăng nhập của người dùng, mỗi người dùng chỉ có 1 tài khoản
CREATE TABLE Accounts (
    AccountID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL UNIQUE REFERENCES Users(UserID), -- Quan hệ 1-1 với bảng Users
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(64) NOT NULL, -- Lưu hash của mật khẩu (SHA-256)
    Role VARCHAR(20) NOT NULL CHECK (Role IN ('Admin', 'Librarian', 'Reader'))
);
GO

-- Categories: Các thể loại sách
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(200) NULL
);
GO

-- Authors: Tác giả của sách
CREATE TABLE Authors (
    AuthorID INT IDENTITY(1,1) PRIMARY KEY,
    AuthorName NVARCHAR(100) NOT NULL
);
GO

-- Publishers: nhà xuất bản của sách
CREATE TABLE Publishers (
    PublisherID INT IDENTITY(1,1) PRIMARY KEY,
    PublisherName NVARCHAR(100) NOT NULL UNIQUE
);
GO

-- Books: Thông tin sách, mỗi cuốn sách thuộc 1 thể loại, 1 tác giả, 1 nhà xuất bản,...
-- Books: Quantity = tổng số cuốn, Available = số cuốn còn có thể mượn (Available <= Quantity)
-- Description dùng cho AI đề xuất sách, không dùng cho quản lý
CREATE TABLE Books (
    BookID  INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    CategoryID  INT NOT NULL REFERENCES Categories(CategoryID),
    AuthorID INT NOT NULL REFERENCES Authors(AuthorID),
    PublisherID INT NOT NULL REFERENCES Publishers(PublisherID),
    PublishYear INT NULL CHECK (PublishYear BETWEEN 1000 AND 2100),
    Quantity INT NOT NULL DEFAULT 0 CHECK (Quantity >= 0),
    Available INT NOT NULL DEFAULT 0,
    Description NVARCHAR(MAX) NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE(),
    CHECK (Available >= 0 AND Available <= Quantity) -- Kiểm tra số lượng khả dụng không vượt quá tổng số lượng
);

-- Chưa dùng tới
-- Tạo chỉ mục trên cột Title để tăng tốc độ tìm kiếm sách theo tên
--GO
--CREATE INDEX IX_Books_Title ON Books(Title);
--GO

-- BorrowRecords: Phiếu mượn sách, mỗi phiếu do 1 người mượn, do 1 thủ thư phát hành
CREATE TABLE BorrowRecords (
    BorrowID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL REFERENCES Users(UserID), 
    IssuedBy INT NOT NULL REFERENCES Users(UserID), -- Thủ thư phát hành phiếu
    BorrowDate DATE NOT NULL DEFAULT (CAST(GETDATE() AS DATE)),
    DueDate DATE NOT NULL, 
    CHECK (DueDate >= BorrowDate) --Kiểm tra hạn trả không được trước ngày mượn
);
GO

-- BorrowDetails: tung cuon trong phieu, tra rieng tung cuon
-- ReturnDate = NULL nghia la chua tra. So ngay tre tinh bang truy van, khong luu cung
CREATE TABLE BorrowDetails (
    DetailID INT IDENTITY(1,1) PRIMARY KEY,
    BorrowID INT NOT NULL REFERENCES BorrowRecords(BorrowID),
    BookID INT NOT NULL REFERENCES Books(BookID),
    Quantity INT NOT NULL DEFAULT 1 CHECK (Quantity > 0),
    ReturnDate DATE NULL,
    FineAmount DECIMAL(12,0) NOT NULL DEFAULT 0 CHECK (FineAmount >= 0), 
    UNIQUE (BorrowID, BookID) -- Mỗi cuốn sách chỉ được mượn 1 lần trong 1 phiếu
);


-- Tạo chỉ mục trên cột BookID để tăng tốc độ tìm kiếm chi tiết mượn theo sách
GO
CREATE INDEX IX_BorrowDetails_BookID ON BorrowDetails(BookID);
GO

-- WalletTransactions: Ghi nhận các giao dịch nạp tiền và phạt tiền của người dùng
CREATE TABLE WalletTransactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL REFERENCES Users(UserID),
    Amount DECIMAL(12,0) NOT NULL, 
    TransType VARCHAR(10) NOT NULL CHECK (TransType IN ('Deposit', 'Fine')), 
    Note NVARCHAR(200) NULL,
    CreatedBy INT NULL REFERENCES Users(UserID),
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Settings: Cấu hình do Admin chỉnh (không viết cứng trong code)
CREATE TABLE Settings (
    SettingKey VARCHAR(50) PRIMARY KEY,
    SettingValue NVARCHAR(100) NOT NULL, -- Giá trị cấu hình
    Description NVARCHAR(200) NULL -- Mô tả cấu hình
);
GO

--------------------------

-- Stored Procedure: Lấy thông tin thể loại sách theo tên thể loại
CREATE PROC USP_GetCategoryByCategoryName
@categoryName NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Categories 
    WHERE CategoryName = @categoryName
END

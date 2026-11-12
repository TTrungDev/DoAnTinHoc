CREATE DATABASE LibraryManagement;
GO

USE LibraryManagement;
GO

-- Bang Users: Luu tru thong tin ve nguoi dung
CREATE TABLE Users (
	UserID INT PRIMARY KEY IDENTITY(1,1), -- Ma so cua nguoi dung
	FullName NVARCHAR(100) NOT NULL, -- Ho va ten cua nguoi dung
	BirthDate DATE NOT NULL, -- Ngay sinh cua nguoi dung
	PhoneNumber NVARCHAR(15) NOT NULL, -- So dien thoai cua nguoi dung
	Email NVARCHAR(100) NOT NULL UNIQUE, -- Dia chi email cua nguoi dung
);
GO

-- Bang Account: Luu tru thong tin ve cac tai khoan nguoi dung
CREATE TABLE ACCOUNT (
	AccountID INT PRIMARY KEY IDENTITY(1,1), -- Ma so cua tai khoan
	UserID INT FOREIGN KEY REFERENCES Users(UserID), -- Ma so cua nguoi dung
	Username NVARCHAR(50) NOT NULL UNIQUE, -- Ten dang nhap cua tai khoan
	Password NVARCHAR(50) NOT NULL, -- Mat khau cua tai khoan
	Role NVARCHAR(20) NOT NULL, -- Vai tro cua tai khoan (Admin, Librarian, User)
);
GO

-- Bang Categories: Luu tru thong tin ve cac danh muc sach
CREATE TABLE Categories (
	CategoryID INT PRIMARY KEY IDENTITY(1,1), -- Ma so cua danh muc
	CategoryName NVARCHAR(100) NOT NULL, -- Ten danh muc
);
GO

-- Bang Books: Luu tru thong tin ve cac cuon sach trong thu vien
CREATE TABLE Books (
	BookID INT PRIMARY KEY IDENTITY(1,1), -- Ma so cua cuon sach
	Title NVARCHAR(200) NOT NULL, -- Tieu de cua cuon sach
	Author NVARCHAR(100) NOT NULL, -- Tac gia cua cuon sach
	Publisher NVARCHAR(100) NOT NULL, -- Nha xuat ban cua cuon sach
	NumberOfCopies INT NOT NULL, -- So luong co the cho muon cua cuon sach
	CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID), -- Ma so danh muc cua cuon sach
);
GO

-- Bang BorrowRecords: Luu tru thong tin ve cac phieu muon sach
CREATE TABLE BorrowRecords (
	BorrowID INT PRIMARY KEY IDENTITY(1,1), -- Ma so cua phieu muon
	UserID INT FOREIGN KEY REFERENCES Users(UserID), -- Ma so cua nguoi dung
	BookID INT FOREIGN KEY REFERENCES Books(BookID), -- Ma so cua cuon sach
	BorrowDate DATE NOT NULL, -- Ngay muon sach
	BookReturnDate DATE NOT NULL, -- Ngay tra sach du kien
	ReturnDate DATE, -- Ngay tra sach (khong tra sach = null)
);
GO

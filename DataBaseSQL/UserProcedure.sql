USE LibraryManagement; 
GO
--------------------------



CREATE OR ALTER PROC USP_GetReaders
AS
BEGIN
    SELECT * FROM Users
END
GO

CREATE OR ALTER PROC USP_GetReadersByFullName
@fullName NVARCHAR(100)
as
BEGIN
    SELECT * FROM Users 
    WHERE FullName = @fullName
END
GO

-- Accounts

-- Lấy thông tin tài khoản theo username và passwordHash
CREATE OR ALTER PROC USP_Login
@username NVARCHAR(50) , @passwordHash VARCHAR(64)
AS
BEGIN
    SELECT * FROM Accounts 
    WHERE Username = @username 
        AND PasswordHash = CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @passwordHash), 2)
END
GO

-- Thêm tài khoản mới vào bảng Accounts và Users
CREATE OR ALTER PROC USP_Register
@fullName NVARCHAR(100), @birthDate DATE, @gender NVARCHAR(10), 
@phoneNumber VARCHAR(15), @email NVARCHAR(100), @address NVARCHAR(200),
@username NVARCHAR(50), @passwordHash VARCHAR(64)
AS
BEGIN
    INSERT INTO Users (FullName, BirthDate, Gender, PhoneNumber, Email, Address, Balance) VALUES
    (
        @fullName,
        @birthDate,
        @gender,
        @phoneNumber,
        @email,
        @address,
        0 -- Khởi tạo số dư ban đầu là 0
    )

    INSERT INTO Accounts (UserID, Username, PasswordHash, Role) VALUES
    (
        SCOPE_IDENTITY(), -- Lấy UserID vừa được tạo trong bảng Users
        @username,
        CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @passwordHash), 2),
        'Reader'
    )
END
GO

-- Lấy thông tin tài khoản và thông tin người dùng
CREATE OR ALTER PROC USP_GetAccounts
AS
BEGIN 
    SELECT  Accounts.UserID, Username, Role, FullName, BirthDate, Gender, PhoneNumber, Email, Address
    FROM Accounts JOIN Users on Accounts.UserId = Users.UserId
END
GO

-- Tao tài khoản mới với vai trò tùy chọn
CREATE OR ALTER PROC USP_AddAccount
@fullName NVARCHAR(100), @birthDate DATE, @gender NVARCHAR(10), 
@phoneNumber VARCHAR(15), @email NVARCHAR(100), @address NVARCHAR(200),
@username NVARCHAR(50), @passwordHash VARCHAR(64), @role VARCHAR(20)
AS
BEGIN
    INSERT INTO Users (FullName, BirthDate, Gender, PhoneNumber, Email, Address, Balance) VALUES
    (
        @fullName,
        @birthDate,
        @gender,
        @phoneNumber,
        @email,
        @address,
        0 -- Khởi tạo số dư ban đầu là 0
    )
    INSERT INTO Accounts (UserID, Username, PasswordHash, Role) VALUES
    (
        SCOPE_IDENTITY(), -- Lấy UserID vừa được tạo trong bảng Users
        @username,
        CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @passwordHash), 2),
        @role
    )
END
GO

-- Cập nhập thông tin vai trò của tài khoản
CREATE OR ALTER PROC USP_UpdateAccountRole
@accountID INT, @newRole VARCHAR(20)
AS
BEGIN
    UPDATE Accounts
    SET Role = @newRole
    WHERE AccountID = @accountID
END
GO

--Đổi mật khẩu của tài khoản
--CREATE OR ALTER PROC USP_ChangePassword

--Xóa tài khoản và thông tin người dùng
CREATE OR ALTER PROC USP_DeleteAccount
@accountID INT
AS
BEGIN
    DELETE FROM Accounts 
        WHERE AccountID = @accountID
    DELETE FROM Users 
        WHERE UserID = @accountID
END
GO

--Kiểm tra xem username đã tồn tại trong bảng Accounts hay chưa
CREATE OR ALTER PROC USP_IsUsernameExists
@username NVARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Accounts WHERE Username = @username)
        SELECT 1 AS IsExists
    ELSE
        SELECT 0 AS IsExists
END
GO

-- Categories

--Lấy thông tin tất cả các thể loại sách
CREATE OR ALTER PROC USP_GetCategories
AS
BEGIN
    SELECT * FROM Categories
END
GO

-- Stored Procedure: Lấy thông tin thể loại sách theo tên thể loại
CREATE OR ALTER PROC USP_GetCategoriesByCategoryName
@categoryName NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Categories 
    WHERE CategoryName = @categoryName
END
GO

--Tìm kiếm thể loại sách theo từ khóa
CREATE OR ALTER PROC USP_SearchCategories
@keyword NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Categories
    WHERE CategoryName LIKE '%' + @keyword + '%'
END
GO

-- Thêm thể loại sách mới
CREATE OR ALTER PROC USP_AddCategory
@categoryName NVARCHAR(100), @description NVARCHAR(200)
AS
BEGIN
    INSERT INTO Categories (CategoryName, Description) VALUES 
    (
        @categoryName, @description
    )
END
GO

-- Cập nhật thông tin thể loại sách
CREATE OR ALTER PROC USP_UpdateCategory
@categoryId INT,
@categoryName NVARCHAR(100),
@description NVARCHAR(200) 
AS
BEGIN
    UPDATE Categories
    SET CategoryName = @categoryName, Description = @description
    WHERE CategoryId = @categoryId
END
GO

-- Xóa thể loại sách
CREATE OR ALTER PROC USP_DeleteCategory
@categoryId INT
AS
BEGIN
    DELETE FROM Categories 
    WHERE CategoryId = @categoryId
END
GO

-- Kiểm tra xem tên thể loại đã tồn tại trong bảng Categories hay chưa
CREATE OR ALTER PROC USP_IsCategoryNameExists
@categoryName NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Categories WHERE CategoryName = @categoryName)
        SELECT 1 AS IsExists
    ELSE
        SELECT 0 AS IsExists
END
GO

-- Authors

-- Lấy thông tin tất cả các tác giả
CREATE OR ALTER PROC USP_GetAuthors
AS
BEGIN
    SELECT * FROM Authors
END
GO

-- Tìm kiếm tác giả theo từ khóa
CREATE OR ALTER PROC USP_SearchAuthors
@keyword NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Authors
    WHERE AuthorName LIKE '%' + @keyword + '%'
END
GO

-- Thêm tác giả mới
CREATE OR ALTER PROC USP_AddAuthor
@authorName NVARCHAR(100)
AS
BEGIN
    INSERT INTO Authors(AuthorName) VALUES
    (
        @authorName
    )
END
GO

-- Cập nhật thông tin tác giả
CREATE OR ALTER PROC USP_UpdateAuthor
@authorId INT, @authorName NVARCHAR(100)
AS
BEGIN
    UPDATE Authors
    SET AuthorName = @authorName
    WHERE AuthorID = @authorId
END
GO

-- Xóa tác giả
CREATE OR ALTER PROC USP_DeleteAuthor
@authorId INT
AS
BEGIN
    DELETE FROM Authors
    WHERE AuthorID = @authorId
END
GO

-- Publishers

-- Lấy thông tin tất cả các nhà xuất bản
CREATE OR ALTER PROC USP_GetPublishers
AS
BEGIN
    SELECT * FROM Publishers
END
GO

-- Tìm kiếm nhà xuất bản theo từ khóa
CREATE OR ALTER PROC USP_SearchPublishers
@keyword NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Publishers
    WHERE PublisherName LIKE '%' + @keyword + '%'
END
GO

-- Thêm nhà xuất bản mới
CREATE OR ALTER PROC USP_AddPublisher
@publisherName NVARCHAR(100)
AS
BEGIN
    INSERT INTO Publishers(PublisherName) VALUES
    (
        @publisherName
    )
END
GO

-- Cập nhật thông tin nhà xuất bản
CREATE OR ALTER PROC USP_UpdatePublisher
@publisherId INT, @publisherName NVARCHAR(100)
AS
BEGIN
    UPDATE Publishers
    SET PublisherName = @publisherName
    WHERE PublisherId = @publisherId
END
GO

-- Xóa nhà xuất bản
CREATE OR ALTER PROC USP_DeletePublisher
@publisherId INT
AS
BEGIN
    DELETE FROM Publishers
    WHERE PublisherId = @publisherId 
END
GO

-- Kiểm tra xem tên nhà xuất bản đã tồn tại trong bảng Publishers hay chưa
CREATE OR ALTER PROC USP_IsPublisherNameExists
@publisherName NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Publishers WHERE PublisherName = @publisherName)
        SELECT 1 AS IsExists
    ELSE
        SELECT 0 AS IsExists
END
GO


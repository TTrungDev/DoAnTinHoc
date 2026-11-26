USE LibraryManagement; 
GO
--------------------------
-- Stored Procedure: Lấy thông tin thể loại sách theo tên thể loại


CREATE OR ALTER PROC USP_GetCategoriesByCategoryName
@categoryName NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Categories 
    WHERE CategoryName = @categoryName
END
GO

CREATE OR ALTER PROC USP_GetBooks
AS
BEGIN
    SELECT * FROM Books
END
GO

CREATE OR ALTER PROC USP_GetBooksByTitle
@Title NVARCHAR(200)
AS
BEGIN
    SELECT * FROM Books 
    WHERE Title = @Title
END
GO

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

-- Account

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

--CREATE OR ALTER PROC USP_AddAccount

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

-- Category

--Lấy thông tin tất cả các thể loại sách
CREATE OR ALTER PROC USP_GetCategories
AS
BEGIN
    SELECT * FROM Categories
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






exec USP_GetCategories 
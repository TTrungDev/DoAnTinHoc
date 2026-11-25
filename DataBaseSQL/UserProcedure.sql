USE LibraryManagement; 
GO
--------------------------
-- Stored Procedure: Lấy thông tin thể loại sách theo tên thể loại

CREATE OR ALTER PROC USP_GetCategories
AS
BEGIN
    SELECT * FROM Categories
END
GO

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

CREATE OR ALTER PROC USP_Login
@userName NVARCHAR(50) , @passwordHash VARCHAR(64)
AS
BEGIN
    SELECT * FROM Accounts 
    WHERE Username = @userName 
        AND PasswordHash = CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @passwordHash), 2)
END
GO

--CREATE OR ALTER PROC USP_Register

CREATE OR ALTER PROC USP_GetAccounts
AS
BEGIN 
    SELECT  Accounts.UserID, Username, Role, FullName, BirthDate, Gender, PhoneNumber, Email, Address
    FROM Accounts JOIN Users on Accounts.UserId = Users.UserId
END

--CREATE OR ALTER PROC USP_AddAccount
--CREATE OR ALTER PROC USP_UpdateAccountRole



exec USP_Login @userName = 'lan' , @passwordHash = 'thuthu123'

-- Books

-- Lấy thông tin tất cả các sách
CREATE OR ALTER PROC USP_GetBooks
AS
BEGIN
    SELECT B.BookID, B.Title, B.PublishYear, B.Quantity, B.Available, B.Description, B.CreatedAt,
           C.CategoryName, A.AuthorName, P.PublisherName
    FROM Books B join Categories C ON B.CategoryId = C.CategoryId
                          join Authors A ON B.AuthorId = A.AuthorId
                          join Publishers P ON B.PublisherId = P.PublisherId
END
GO

-- Tìm kiếm sách theo từ khóa
CREATE OR ALTER PROC USP_SearchBooks
@keyword NVARCHAR(200)
AS
BEGIN
    SELECT * FROM Books 
    WHERE Title LIKE '%' + @keyword + '%'
END
GO

--CREATE OR ALTER PROC USP_GetBookById
--@bookId INT

CREATE OR ALTER PROC USP_AddBook
@title NVARCHAR(200), @categoryId INT, @authorId INT, @publisherId INT,
@publishYear INT, @quantity INT, @description NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Books(Title, CategoryID, AuthorID, PublisherID, PublishYear, Quantity, Available, Description) VALUES
    (
        @title,
        @categoryId,
        @authorId,
        @publisherId,
        @publishYear,
        @quantity,
        @quantity, -- Available = Quantity
        @description 
    )
END
GO

CREATE OR ALTER PROC USP_UpdateBook
@bookId INT,
@title NVARCHAR(200), @categoryId INT, @authorId INT, @publisherId INT,
@publishYear INT, @quantity INT, @description NVARCHAR(MAX)
AS
BEGIN
    UPDATE Books
    SET 
        Title =@title,
        CategoryID  =@categoryId,
        AuthorID =@authorId,
        PublisherID =@publisherId,
        PublishYear =@publishYear,
        Quantity =@quantity,
        Description = @description
    WHERE BookID = @bookId
END
GO

--Xóa sách, trả false nếu sách đã có trong phiếu mượn	
CREATE OR ALTER PROC USP_DeleteBook
@bookId INT
AS
BEGIN
    IF EXISTS( SELECT 1 FROM Books WHERE BookID = @bookId AND Available < Quantity)
        SELECT 0 AS IsDelete
    ELSE
    BEGIN
        SELECT 1 AS IsDelete
        DELETE FROM Books
        WHERE BookID = @bookId
    END
END
GO

--CREATE OR ALTER PROC USP_GetBooksBorrowedByReader
--@readerId INT
--AS
--BEGIN
--END
--GO


--exec USP_AddBook @title = 'wbbbbbb', @categoryId = 24,
--@authorId = 30, @publisherId =20,
--@publishYear =2099, @quantity =5, @description =''

--UPDATE Books
--    SET Available =5
--    WHERE BookID = 50


--exec USP_DeleteBook @bookId = 50
--exec USP_DeleteBook @bookId = 51


--exec USP_GetBooks

--select * from books


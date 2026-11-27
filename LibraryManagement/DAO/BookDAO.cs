using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Sách, tìm kiếm, lọc, sắp xếp</summary>
    internal class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BookDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private BookDAO() { }

        /// <summary>Lấy toàn bộ sách (JOIN để có CategoryName, AuthorName, PublisherName)</summary>
        /// <remarks>SP đề xuất: USP_GetBooks</remarks>
        public List<Book> LoadBookList()
        {
            List<Book> books = new List<Book>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetBooks");
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                books.Add(book);
            }
            return books;
        }

        /// <summary>Tìm/lọc/sắp xếp. criteria: ID | Title | Author | Publisher | Category (rỗng = tìm mọi cột). categoryId null = không lọc. sortBy: Title | PublishYear | Quantity</summary>
        /// <remarks>SP đề xuất: USP_SearchBooks</remarks>
        public List<Book> SearchBooks(string title, string criteria, int? categoryId, string sortBy, bool ascending)
        {
           string query = "EXEC USP_SearchBooks @title , @criteria , @categoryId , @sortBy , @ascending";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { title, criteria, (object)categoryId ?? DBNull.Value, sortBy, ascending });
            List<Book> books = new List<Book>();
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                books.Add(book);
            }
            return books;
        }

        /// <summary>Lấy 1 cuốn sách, không có thì null</summary>
        /// <remarks>SP đề xuất: USP_GetBookById</remarks>
        public Book? GetBookById(int bookId)
        {
            string query = "EXEC USP_GetBookById @bookId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { bookId });
            if (data.Rows.Count > 0)
            {
                return new Book(data.Rows[0]);
            }
            return null;
        }

        /// <summary>Thêm sách (Available ban đầu = Quantity)</summary>
        /// <remarks>SP đề xuất: USP_AddBook</remarks>
        public bool AddBook(Book book)
        {
            string query = "EXEC USP_AddBook @title , @authorId , @publisherId , @categoryId , @publishYear , @quantity";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { book.Title, book.AuthorID, book.PublisherID, book.CategoryID, book.PublishYear, book.Quantity });
            return result > 0;
        }

        /// <summary>Sửa sách theo book.ID</summary>
        /// <remarks>SP đề xuất: USP_UpdateBook</remarks>
        public bool UpdateBook(Book book)
        {
            string query = "EXEC USP_UpdateBook @bookId , @title , @authorId , @publisherId , @categoryId , @publishYear , @quantity";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { book.ID, book.Title, book.AuthorID, book.PublisherID, book.CategoryID, book.PublishYear, book.Quantity });
            return result > 0;

        }

        /// <summary>Xóa sách; trả false nếu sách đã có trong phiếu mượn</summary>
        /// <remarks>SP đề xuất: USP_DeleteBook</remarks>
        public bool DeleteBook(int bookId)
        {
            string query = "EXEC USP_DeleteBook @bookId";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { bookId });
            return result > 0;
        }

        /// <summary>Các sách độc giả đã mượn (có Description), làm dữ liệu cho AI đề xuất</summary>
        /// <remarks>SP đề xuất: USP_GetBooksBorrowedByReader</remarks>
        public List<Book> LoadBooksBorrowedByReader(int readerId)
        {
            string query = "EXEC USP_GetBooksBorrowedByReader @readerId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { readerId });
            List<Book> books = new List<Book>();
            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                books.Add(book);
            }
            return books;
        }
    }
}

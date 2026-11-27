using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Sách, tìm kiếm, lọc, sắp xếp</summary>
    internal class BookDAO
    {
        private static BookDAO? instance;

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
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Tìm/lọc/sắp xếp. criteria: ID | Title | Author | Publisher | Category (rỗng = tìm mọi cột). categoryId null = không lọc. sortBy: Title | PublishYear | Quantity</summary>
        /// <remarks>SP đề xuất: USP_SearchBooks</remarks>
        public List<Book> SearchBooks(string keyword, string criteria, int? categoryId, string sortBy, bool ascending)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Lấy 1 cuốn sách, không có thì null</summary>
        /// <remarks>SP đề xuất: USP_GetBookById</remarks>
        public Book? GetBookById(int bookId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Thêm sách (Available ban đầu = Quantity)</summary>
        /// <remarks>SP đề xuất: USP_AddBook</remarks>
        public bool AddBook(Book book)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Sửa sách theo book.ID</summary>
        /// <remarks>SP đề xuất: USP_UpdateBook</remarks>
        public bool UpdateBook(Book book)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Xóa sách; trả false nếu sách đã có trong phiếu mượn</summary>
        /// <remarks>SP đề xuất: USP_DeleteBook</remarks>
        public bool DeleteBook(int bookId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Các sách độc giả đã mượn (có Description), làm dữ liệu cho AI đề xuất</summary>
        /// <remarks>SP đề xuất: USP_GetBooksBorrowedByReader</remarks>
        public List<Book> LoadBooksBorrowedByReader(int readerId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

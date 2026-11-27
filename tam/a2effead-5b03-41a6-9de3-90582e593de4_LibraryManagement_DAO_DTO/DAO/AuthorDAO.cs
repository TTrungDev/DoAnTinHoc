using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Tác giả</summary>
    internal class AuthorDAO
    {
        private static AuthorDAO? instance;

        public static AuthorDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AuthorDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private AuthorDAO() { }

        /// <summary>Lấy toàn bộ tác giả</summary>
        /// <remarks>SP đề xuất: USP_GetAuthors</remarks>
        public List<Author> LoadAuthorList()
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Tìm tác giả theo tên (LIKE)</summary>
        /// <remarks>SP đề xuất: USP_SearchAuthors</remarks>
        public List<Author> SearchAuthors(string keyword)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Thêm tác giả</summary>
        /// <remarks>SP đề xuất: USP_AddAuthor</remarks>
        public bool AddAuthor(Author author)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Sửa tác giả theo author.ID</summary>
        /// <remarks>SP đề xuất: USP_UpdateAuthor</remarks>
        public bool UpdateAuthor(Author author)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Xóa tác giả; trả false nếu còn sách của tác giả này</summary>
        /// <remarks>SP đề xuất: USP_DeleteAuthor</remarks>
        public bool DeleteAuthor(int authorId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

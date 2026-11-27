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
            List<Author> authors = new List<Author>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAuthors");
            foreach (DataRow item in data.Rows)
            {
                Author author = new Author(item);
                authors.Add(author);
            }
            return authors;
        }

        /// <summary>Tìm tác giả theo tên (LIKE)</summary>
        /// <remarks>SP đề xuất: USP_SearchAuthors</remarks>
        public List<Author> SearchAuthors(string AuthorsName)
        {
            string query = "EXEC USP_SearchAuthors @AthorsName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { AuthorsName});
            List<Author> authors = new List<Author>();
            foreach (DataRow item in data.Rows)
            {
                Author author = new Author(item);
                authors.Add(author);
            }
            return authors;
        }

        /// <summary>Thêm tác giả</summary>
        /// <remarks>SP đề xuất: USP_AddAuthor</remarks>
        public bool AddAuthor(Author author)
        {
            string query = "EXEC USP_AddAuthor @name , @ID";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { author.Name,author.ID });
            return result > 0;
        }

        /// <summary>Sửa tác giả theo author.ID</summary>
        /// <remarks>SP đề xuất: USP_UpdateAuthor</remarks>
        public bool UpdateAuthor(Author author)
        {
            string query = "EXEC USP_UpdateAuthor @name , @ID";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { author.Name, author.ID });
            return result > 0;
        }

        /// <summary>Xóa tác giả; trả false nếu còn sách của tác giả này</summary>
        /// <remarks>SP đề xuất: USP_DeleteAuthor</remarks>
        public bool DeleteAuthor(int authorId)
        {
            string query = "EXEC USP_DeleteAuthor @authorId";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { authorId });
            return result > 0;
        }
    }
}

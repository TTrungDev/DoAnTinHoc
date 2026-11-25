using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryManagement.DAO
{
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
            set { instance = value; }
        }
        public List<Book> LoadBookList(object[] find = null)
        {
            string query = "EXEC USP_GetBooks";
            if (find == null || find.Length == 0 || find[0] == null)
            {
                find = new object[] { "" };
            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query, find);
            List<Book> bookList = new List<Book>();
            foreach (DataRow row in data.Rows)
            {
                Book book = new Book(row);
                bookList.Add(book);
            }

            return bookList;
        }
    }
}

using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryManagement.DAO
{
    internal class ReaderDAO
    {
        private static ReaderDAO instance;

        public static ReaderDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new ReaderDAO();
                return instance; 
            }
            set { instance = value; }
        }

        public List<Reader> LoadReaderList(object[] find=null)
        {
            string query = " EXEC USP_GetReadersByFullName @fullName ";
            if (find == null || find.Length == 0 || find[0] == null)
            {
                find = new object[] { " " };
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(query, find);

            List<Reader> readerList = new List<Reader>();
            foreach (DataRow row in data.Rows)
            {
                Reader reader = new Reader(row);
                readerList.Add(reader);
            }

            return readerList;
        }
    }
}

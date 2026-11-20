using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryManagement.DAO
{
    internal class ReaderDAO
    {
        private static ReaderDAO instation;

        public static ReaderDAO Instation
        {
            get 
            {
                if (instation == null)
                    instation = new ReaderDAO();
                return instation; 
            }
            set { instation = value; }
        }

        public List<Reader> LoadReaderList(object[] find=null)
        {
            string query = "EXEC USP_GetReadersByFullName @fullName";

            DataTable data = DataProvider.Instacne.ExecuteQuery(query,find);

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

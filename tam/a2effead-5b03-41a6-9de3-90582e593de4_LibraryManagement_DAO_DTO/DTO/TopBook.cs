using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Sách được mượn nhiều (kết quả query)</summary>
    internal class TopBook
    {
        public int BookID { get; set; }
        public string Title { get; set; } = "";
        public int BorrowCount { get; set; }

        public TopBook() { }

        public TopBook(DataRow row)
        {
            BookID = Convert.ToInt32(row["BookID"]);
            Title = row["Title"].ToString() ?? "";
            BorrowCount = Convert.ToInt32(row["BorrowCount"]);
        }
    }
}

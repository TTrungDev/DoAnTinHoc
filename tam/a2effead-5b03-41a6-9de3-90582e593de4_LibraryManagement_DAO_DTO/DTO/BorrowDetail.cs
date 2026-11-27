using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Chi tiết phiếu mượn (bảng BorrowDetails). ReturnDate = null là chưa trả. BookTitle/BorrowDate/DueDate chỉ có khi query JOIN</summary>
    internal class BorrowDetail
    {
        public int ID { get; set; }
        public int BorrowID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal FineAmount { get; set; }
        public string BookTitle { get; set; } = "";
        public DateTime? BorrowDate { get; set; }
        public DateTime? DueDate { get; set; }

        /// <summary>Số ngày trễ: (ngày trả, hoặc hôm nay nếu chưa trả) trừ hạn trả; không trễ thì bằng 0</summary>
        public int DaysLate
        {
            get
            {
                if (DueDate == null) return 0;
                DateTime end = ReturnDate ?? DateTime.Today;
                int days = (end.Date - DueDate.Value.Date).Days;
                return days > 0 ? days : 0;
            }
        }

        public BorrowDetail() { }

        public BorrowDetail(DataRow row)
        {
            ID = Convert.ToInt32(row["DetailID"]);
            BorrowID = Convert.ToInt32(row["BorrowID"]);
            BookID = Convert.ToInt32(row["BookID"]);
            Quantity = Convert.ToInt32(row["Quantity"]);
            ReturnDate = row["ReturnDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ReturnDate"]);
            FineAmount = Convert.ToDecimal(row["FineAmount"]);
            BookTitle = row.Table.Columns.Contains("BookTitle") ? (row["BookTitle"].ToString() ?? "") : "";
            BorrowDate = row.Table.Columns.Contains("BorrowDate") && row["BorrowDate"] != DBNull.Value ? Convert.ToDateTime(row["BorrowDate"]) : (DateTime?)null;
            DueDate = row.Table.Columns.Contains("DueDate") && row["DueDate"] != DBNull.Value ? Convert.ToDateTime(row["DueDate"]) : (DateTime?)null;
        }
    }
}

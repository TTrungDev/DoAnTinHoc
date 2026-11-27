using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Phiếu mượn (bảng BorrowRecords). Details chứa các cuốn trong phiếu, dùng khi lập phiếu mới</summary>
    internal class BorrowRecord
    {
        public int ID { get; set; }
        public int ReaderID { get; set; }
        public int IssuedBy { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public string ReaderName { get; set; } = "";
        public string IssuedByName { get; set; } = "";
        public List<BorrowDetail> Details { get; set; } = new List<BorrowDetail>();

        public BorrowRecord() { }

        public BorrowRecord(DataRow row)
        {
            ID = Convert.ToInt32(row["BorrowID"]);
            ReaderID = Convert.ToInt32(row["UserID"]);
            IssuedBy = Convert.ToInt32(row["IssuedBy"]);
            BorrowDate = Convert.ToDateTime(row["BorrowDate"]);
            DueDate = Convert.ToDateTime(row["DueDate"]);
            ReaderName = row.Table.Columns.Contains("ReaderName") ? (row["ReaderName"].ToString() ?? "") : "";
            IssuedByName = row.Table.Columns.Contains("IssuedByName") ? (row["IssuedByName"].ToString() ?? "") : "";
        }
    }
}

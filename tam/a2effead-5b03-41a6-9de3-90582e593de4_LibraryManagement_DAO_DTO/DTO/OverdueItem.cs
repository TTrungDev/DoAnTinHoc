using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Một dòng sách quá hạn chưa trả (kết quả query, không phải bảng). FineAmount là phạt tạm tính đến hôm nay</summary>
    internal class OverdueItem
    {
        public int ReaderID { get; set; }
        public string ReaderName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string BookTitle { get; set; } = "";
        public DateTime DueDate { get; set; }
        public int DaysLate { get; set; }
        public decimal FineAmount { get; set; }

        public OverdueItem() { }

        public OverdueItem(DataRow row)
        {
            ReaderID = Convert.ToInt32(row["UserID"]);
            ReaderName = row["FullName"].ToString() ?? "";
            PhoneNumber = row["PhoneNumber"].ToString() ?? "";
            BookTitle = row["Title"].ToString() ?? "";
            DueDate = Convert.ToDateTime(row["DueDate"]);
            DaysLate = Convert.ToInt32(row["DaysLate"]);
            FineAmount = Convert.ToDecimal(row["FineAmount"]);
        }
    }
}

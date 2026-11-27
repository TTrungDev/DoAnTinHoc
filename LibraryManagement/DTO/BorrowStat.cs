using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Thống kê mượn/trả theo ngày (kết quả query)</summary>
    internal class BorrowStat
    {
        public DateTime Date { get; set; }
        public int BorrowCount { get; set; }
        public int ReturnCount { get; set; }
        public decimal FineTotal { get; set; }

        public BorrowStat() { }

        public BorrowStat(DataRow row)
        {
            Date = Convert.ToDateTime(row["StatDate"]);
            BorrowCount = Convert.ToInt32(row["BorrowCount"]);
            ReturnCount = Convert.ToInt32(row["ReturnCount"]);
            FineTotal = Convert.ToDecimal(row["FineTotal"]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Tổng hợp mượn/trả trong một khoảng ngày (kết quả query)</summary>
    internal class BorrowSummary
    {
        public int TotalBorrowed { get; set; }
        public int Returned { get; set; }
        public int NotReturned { get; set; }
        public decimal TotalFine { get; set; }

        public BorrowSummary() { }

        public BorrowSummary(DataRow row)
        {
            TotalBorrowed = Convert.ToInt32(row["TotalBorrowed"]);
            Returned = Convert.ToInt32(row["Returned"]);
            NotReturned = Convert.ToInt32(row["NotReturned"]);
            TotalFine = Convert.ToDecimal(row["TotalFine"]);
        }
    }
}

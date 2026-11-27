using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Giao dịch quỹ (bảng WalletTransactions). Amount dương = nạp, âm = trừ phạt; TransType: Deposit, Fine</summary>
    internal class WalletTransaction
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public decimal Amount { get; set; }
        public string TransType { get; set; } = "";
        public string Note { get; set; } = "";
        public int? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public WalletTransaction() { }

        public WalletTransaction(DataRow row)
        {
            ID = Convert.ToInt32(row["TransactionID"]);
            UserID = Convert.ToInt32(row["UserID"]);
            Amount = Convert.ToDecimal(row["Amount"]);
            TransType = row["TransType"].ToString() ?? "";
            Note = row["Note"].ToString() ?? "";
            CreatedBy = row["CreatedBy"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["CreatedBy"]);
            CreatedAt = Convert.ToDateTime(row["CreatedAt"]);
        }
    }
}

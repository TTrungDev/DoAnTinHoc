using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Thống kê, báo cáo</summary>
    internal class StatisticalDAO
    {
        private static StatisticalDAO? instance;

        public static StatisticalDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StatisticalDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private StatisticalDAO() { }

        /// <summary>Tổng phiếu mượn, đã trả, chưa trả, tổng phạt trong khoảng ngày</summary>
        /// <remarks>SP đề xuất: USP_GetBorrowSummary</remarks>
        public BorrowSummary GetSummary(DateTime fromDate, DateTime toDate)
        {
            string query = "EXEC USP_GetBorrowSummary @fromDate , @toDate";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });
            if (data.Rows.Count > 0)
            {
                BorrowSummary summary = new BorrowSummary(data.Rows[0]);
                return summary;
            }
            return new BorrowSummary();
        }

        /// <summary>Số lượt mượn, trả và tiền phạt theo từng ngày</summary>
        /// <remarks>SP đề xuất: USP_GetBorrowReturnByDate</remarks>
        public List<BorrowStat> GetBorrowReturnByDate(DateTime fromDate, DateTime toDate)
        {
            string query = "EXEC USP_GetBorrowReturnByDate @fromDate , @toDate";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });
            List<BorrowStat> stats = new List<BorrowStat>();
            foreach (DataRow item in data.Rows)
            {
                BorrowStat stat = new BorrowStat(item);
                stats.Add(stat);
            }
            return stats;
        }

        /// <summary>Top sách được mượn nhiều nhất trong khoảng ngày</summary>
        /// <remarks>SP đề xuất: USP_GetTopBorrowedBooks</remarks>
        public List<TopBook> GetTopBorrowedBooks(int top, DateTime fromDate, DateTime toDate)
        {
            string query = "EXEC USP_GetTopBorrowedBooks @top , @fromDate , @toDate";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { top, fromDate, toDate });
            List<TopBook> topBooks = new List<TopBook>();
            foreach (DataRow item in data.Rows)
            {
                TopBook topBook = new TopBook(item);
                topBooks.Add(topBook);
            }
            return topBooks;
        }
    }
}

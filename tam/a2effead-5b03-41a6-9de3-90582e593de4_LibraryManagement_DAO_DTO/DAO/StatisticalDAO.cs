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
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Số lượt mượn, trả và tiền phạt theo từng ngày</summary>
        /// <remarks>SP đề xuất: USP_GetBorrowReturnByDate</remarks>
        public List<BorrowStat> GetBorrowReturnByDate(DateTime fromDate, DateTime toDate)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Top sách được mượn nhiều nhất trong khoảng ngày</summary>
        /// <remarks>SP đề xuất: USP_GetTopBorrowedBooks</remarks>
        public List<TopBook> GetTopBorrowedBooks(int top, DateTime fromDate, DateTime toDate)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

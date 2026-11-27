using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Sách quá hạn</summary>
    internal class OverdueDAO
    {
        private static OverdueDAO? instance;

        public static OverdueDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OverdueDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private OverdueDAO() { }

        /// <summary>Sách quá hạn chưa trả: DaysLate = hôm nay - DueDate, FineAmount = DaysLate x FinePerDay. Tính bằng query, không lưu cứng</summary>
        /// <remarks>SP đề xuất: USP_GetOverdueList</remarks>
        public List<OverdueItem> LoadOverdueList()
        {
            List<OverdueItem> overdueItems = new List<OverdueItem>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetOverdueList");
            foreach (DataRow item in data.Rows)
            {
                OverdueItem overdueItem = new OverdueItem(item);
                overdueItems.Add(overdueItem);
            }
            return overdueItems;
        }

        /// <summary>Tìm trong danh sách quá hạn theo tên độc giả hoặc tên sách</summary>
        /// <remarks>SP đề xuất: USP_SearchOverdue</remarks>
        public List<OverdueItem> SearchOverdue(string ReaderName, string BookTitle)
        {
            List<OverdueItem> overdueItems = new List<OverdueItem>();
            string query = "EXEC USP_SearchOverdue @ReaderName , @BookTitle";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { ReaderName, BookTitle });
            foreach (DataRow item in data.Rows)
            {
                OverdueItem overdueItem = new OverdueItem(item);
                overdueItems.Add(overdueItem);
            }
            return overdueItems;
        }
    }
}

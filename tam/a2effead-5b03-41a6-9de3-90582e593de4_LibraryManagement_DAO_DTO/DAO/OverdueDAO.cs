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
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Tìm trong danh sách quá hạn theo tên độc giả hoặc tên sách</summary>
        /// <remarks>SP đề xuất: USP_SearchOverdue</remarks>
        public List<OverdueItem> SearchOverdue(string keyword)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

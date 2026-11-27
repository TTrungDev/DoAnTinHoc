using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Cấu hình hệ thống do Admin chỉnh</summary>
    internal class SettingDAO
    {
        private static SettingDAO? instance;

        public static SettingDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SettingDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private SettingDAO() { }

        /// <summary>Lấy toàn bộ cấu hình</summary>
        /// <remarks>SP đề xuất: USP_GetSettings</remarks>
        public List<Setting> LoadSettingList()
        {
            List<Setting> settings = new List<Setting>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetSettings");
            foreach (DataRow item in data.Rows)
            {
                Setting setting = new Setting(item);
                settings.Add(setting);
            }
            return settings;
        }

        /// <summary>Giá trị của 1 cấu hình, không có thì trả chuỗi rỗng</summary>
        /// <remarks>SP đề xuất: USP_GetSettingValue</remarks>
        public string GetValue(string key)
        {
            string query = "EXEC USP_GetSettingValue @key";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { key });
            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["Value"].ToString() ?? string.Empty;
            }
            return string.Empty;
        }

        /// <summary>Cập nhật giá trị cấu hình</summary>
        /// <remarks>SP đề xuất: USP_UpdateSetting</remarks>
        public bool UpdateSetting(string key, string value)
        {
            string query = "EXEC USP_UpdateSetting @key , @value";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { key, value });
            return result > 0;
        }

        /// <summary>Tiền phạt mỗi ngày trễ (khóa FinePerDay)</summary>
        /// <remarks>SP đề xuất: (dùng GetValue)</remarks>
        public decimal GetFinePerDay()
        {
            string finePerDayStr = GetValue("FinePerDay");
            return decimal.TryParse(finePerDayStr, out decimal finePerDay) ? finePerDay : 0;
        }

        /// <summary>Số ngày mượn tối đa (khóa MaxBorrowDays)</summary>
        /// <remarks>SP đề xuất: (dùng GetValue)</remarks>
        public int GetMaxBorrowDays()
        {
            string maxBorrowDaysStr = GetValue("MaxBorrowDays");
            return int.TryParse(maxBorrowDaysStr, out int maxBorrowDays) ? maxBorrowDays : 0;
        }

        /// <summary>Số sách tối đa mỗi độc giả mượn cùng lúc (khóa MaxBooksPerReader)</summary>
        /// <remarks>SP đề xuất: (dùng GetValue)</remarks>
        public int GetMaxBooksPerReader()
        {
            string maxBooksPerReaderStr = GetValue("MaxBooksPerReader");
            return int.TryParse(maxBooksPerReaderStr, out int maxBooksPerReader) ? maxBooksPerReader : 0;
        }
    }
}

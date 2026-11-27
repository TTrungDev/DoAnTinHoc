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
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Giá trị của 1 cấu hình, không có thì trả chuỗi rỗng</summary>
        /// <remarks>SP đề xuất: USP_GetSettingValue</remarks>
        public string GetValue(string key)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Cập nhật giá trị cấu hình</summary>
        /// <remarks>SP đề xuất: USP_UpdateSetting</remarks>
        public bool UpdateSetting(string key, string value)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Tiền phạt mỗi ngày trễ (khóa FinePerDay)</summary>
        /// <remarks>SP đề xuất: (dùng GetValue)</remarks>
        public decimal GetFinePerDay()
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Số ngày mượn tối đa (khóa MaxBorrowDays)</summary>
        /// <remarks>SP đề xuất: (dùng GetValue)</remarks>
        public int GetMaxBorrowDays()
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Số sách tối đa mỗi độc giả mượn cùng lúc (khóa MaxBooksPerReader)</summary>
        /// <remarks>SP đề xuất: (dùng GetValue)</remarks>
        public int GetMaxBooksPerReader()
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Cấu hình hệ thống (bảng Settings)</summary>
    internal class Setting
    {
        public string Key { get; set; } = "";
        public string Value { get; set; } = "";
        public string Description { get; set; } = "";

        public Setting() { }

        public Setting(DataRow row)
        {
            Key = row["SettingKey"].ToString() ?? "";
            Value = row["SettingValue"].ToString() ?? "";
            Description = row["Description"].ToString() ?? "";
        }
    }
}

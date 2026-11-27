using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Tài khoản đăng nhập (bảng Accounts). Role: Admin, Librarian, Reader. FullName lấy từ Users khi JOIN</summary>
    internal class Account
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Role { get; set; } = "";
        public string FullName { get; set; } = "";

        public Account() { }

        public Account(DataRow row)
        {
            ID = Convert.ToInt32(row["AccountID"]);
            UserID = Convert.ToInt32(row["UserID"]);
            Username = row["Username"].ToString() ?? "";
            PasswordHash = row["PasswordHash"].ToString() ?? "";
            Role = row["Role"].ToString() ?? "";
            FullName = row.Table.Columns.Contains("FullName") ? (row["FullName"].ToString() ?? "") : "";
        }
    }
}

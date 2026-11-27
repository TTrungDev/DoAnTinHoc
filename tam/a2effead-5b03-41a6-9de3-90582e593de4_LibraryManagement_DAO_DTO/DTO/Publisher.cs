using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Nhà xuất bản (bảng Publishers)</summary>
    internal class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";

        public Publisher() { }

        public Publisher(DataRow row)
        {
            ID = Convert.ToInt32(row["PublisherID"]);
            Name = row["PublisherName"].ToString() ?? "";
        }
    }
}

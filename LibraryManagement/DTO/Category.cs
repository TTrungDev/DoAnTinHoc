using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Thể loại sách (bảng Categories)</summary>
    internal class Category
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";

        public Category() { }

        public Category(DataRow row)
        {
            ID = Convert.ToInt32(row["CategoryID"]);
            Name = row["CategoryName"].ToString() ?? "";
            Description = row["Description"].ToString() ?? "";
        }

        public Category(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Tác giả (bảng Authors)</summary>
    internal class Author
    {
        public int ID { get; set; }
        public string Name { get; set; } = "";

        public Author() { }

        public Author(DataRow row)
        {
            ID = Convert.ToInt32(row["AuthorID"]);
            Name = row["AuthorName"].ToString() ?? "";
        }
    }
}

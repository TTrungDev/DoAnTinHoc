using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DTO
{
    /// <summary>Sách (bảng Books). CategoryName/AuthorName/PublisherName chỉ có khi query JOIN, dùng để hiển thị lên lưới</summary>
    internal class Book
    {
        public int ID { get; set; }
        public string Title { get; set; } = "";
        public int CategoryID { get; set; }
        public int AuthorID { get; set; }
        public int PublisherID { get; set; }
        public int? PublishYear { get; set; }
        public int Quantity { get; set; }
        public int Available { get; set; }
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public string CategoryName { get; set; } = "";
        public string AuthorName { get; set; } = "";
        public string PublisherName { get; set; } = "";

        public Book() { }

        public Book(DataRow row)
        {
            ID = Convert.ToInt32(row["BookID"]);
            Title = row["Title"].ToString() ?? "";
            CategoryID = Convert.ToInt32(row["CategoryID"]);
            AuthorID = Convert.ToInt32(row["AuthorID"]);
            PublisherID = Convert.ToInt32(row["PublisherID"]);
            PublishYear = row["PublishYear"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["PublishYear"]);
            Quantity = Convert.ToInt32(row["Quantity"]);
            Available = Convert.ToInt32(row["Available"]);
            Description = row["Description"].ToString() ?? "";
            CreatedAt = Convert.ToDateTime(row["CreatedAt"]);
            CategoryName = row.Table.Columns.Contains("CategoryName") ? (row["CategoryName"].ToString() ?? "") : "";
            AuthorName = row.Table.Columns.Contains("AuthorName") ? (row["AuthorName"].ToString() ?? "") : "";
            PublisherName = row.Table.Columns.Contains("PublisherName") ? (row["PublisherName"].ToString() ?? "") : "";
        }
    }
}

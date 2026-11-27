using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Nhà xuất bản</summary>
    internal class PublisherDAO
    {
        private static PublisherDAO? instance;

        public static PublisherDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PublisherDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private PublisherDAO() { }

        /// <summary>Lấy toàn bộ nhà xuất bản</summary>
        /// <remarks>SP đề xuất: USP_GetPublishers</remarks>
        public List<Publisher> LoadPublisherList()
        {
            List<Publisher> publishers = new List<Publisher>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetPublishers");
            foreach (DataRow item in data.Rows)
            {
                Publisher publisher = new Publisher(item);
                publishers.Add(publisher);
            }
            return publishers;
        }

        /// <summary>Tìm NXB theo tên (LIKE)</summary>
        /// <remarks>SP đề xuất: USP_SearchPublishers</remarks>
        public List<Publisher> SearchPublishers(string PublisherName)
        {
            List<Publisher> publishers = new List<Publisher>();
            string query = "EXEC USP_SearchPublishers @PublisherName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { PublisherName });
            foreach (DataRow item in data.Rows)
            {
                Publisher publisher = new Publisher(item);
                publishers.Add(publisher);
            }
            return publishers;
        }

        /// <summary>Thêm NXB</summary>
        /// <remarks>SP đề xuất: USP_AddPublisher</remarks>
        public bool AddPublisher(Publisher publisher)
        {
            string query = "EXEC USP_AddPublisher @name , @ID";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { publisher.Name,publisher.ID });
            if (result != null && int.TryParse(result.ToString(), out int newPublisherId))
            {
                publisher.ID = newPublisherId; // Gán ID mới cho publisher
                return true;
            }
            return false;
        }

        /// <summary>Sửa NXB theo publisher.ID</summary>
        /// <remarks>SP đề xuất: USP_UpdatePublisher</remarks>
        public bool UpdatePublisher(Publisher publisher)
        {
            string query = "EXEC USP_UpdatePublisher @publisherId , @name";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { publisher.ID, publisher.Name });
            return result > 0;
        }

        /// <summary>Xóa NXB; trả false nếu còn sách của NXB này</summary>
        /// <remarks>SP đề xuất: USP_DeletePublisher</remarks>
        public bool DeletePublisher(int publisherId)
        {
            string query = "EXEC USP_DeletePublisher @publisherId";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { publisherId });
            return result > 0;
        }

        /// <summary>Kiểm tra trùng tên NXB</summary>
        /// <remarks>SP đề xuất: USP_IsPublisherNameExists</remarks>
        public bool IsNameExists(string name)
        {
            string query = "EXEC USP_IsPublisherNameExists @name";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return result.Rows.Count > 0;
        }
    }
}

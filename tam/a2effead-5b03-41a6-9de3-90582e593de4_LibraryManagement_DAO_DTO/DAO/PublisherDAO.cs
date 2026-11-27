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
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Tìm NXB theo tên (LIKE)</summary>
        /// <remarks>SP đề xuất: USP_SearchPublishers</remarks>
        public List<Publisher> SearchPublishers(string keyword)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Thêm NXB</summary>
        /// <remarks>SP đề xuất: USP_AddPublisher</remarks>
        public bool AddPublisher(Publisher publisher)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Sửa NXB theo publisher.ID</summary>
        /// <remarks>SP đề xuất: USP_UpdatePublisher</remarks>
        public bool UpdatePublisher(Publisher publisher)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Xóa NXB; trả false nếu còn sách của NXB này</summary>
        /// <remarks>SP đề xuất: USP_DeletePublisher</remarks>
        public bool DeletePublisher(int publisherId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Kiểm tra trùng tên NXB</summary>
        /// <remarks>SP đề xuất: USP_IsPublisherNameExists</remarks>
        public bool IsNameExists(string name)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

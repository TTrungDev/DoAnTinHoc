using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Text;

namespace LibraryManagement.DAO
{
    internal class CategoryDAO
    {
        private static CategoryDAO instance;
        public static int CategoryWidth = 100;
        public static int CategoryHeight = 100;
        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<Category> LoadCategoryList()
        {
            List<Category> categoryList = new List<Category>();

            string query = "EXEC USP_GetCategories";
            DataTable data = DataProvider.Instacne.ExecuteQuery(query, new object[] { });

            foreach (DataRow row in data.Rows)
            {
                Category category = new Category(row);

                categoryList.Add(category);
            }

            return categoryList;
        }

        /// <summary>Tìm thể loại theo tên (LIKE)</summary>
        /// <remarks>SP đề xuất: USP_SearchCategories</remarks>
        public List<Category> SearchCategories(string keyword)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Thêm thể loại</summary>
        /// <remarks>SP đề xuất: USP_AddCategory</remarks>
        public bool AddCategory(Category category)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Sửa thể loại theo category.ID</summary>
        /// <remarks>SP đề xuất: USP_UpdateCategory</remarks>
        public bool UpdateCategory(Category category)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Xóa thể loại; trả false nếu còn sách thuộc thể loại này</summary>
        /// <remarks>SP đề xuất: USP_DeleteCategory</remarks>
        public bool DeleteCategory(int categoryId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Kiểm tra trùng tên thể loại</summary>
        /// <remarks>SP đề xuất: USP_IsCategoryNameExists</remarks>
        public bool IsNameExists(string name)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

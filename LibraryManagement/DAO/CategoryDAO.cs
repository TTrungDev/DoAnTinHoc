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

        public List<Category> LoadCategoryList(object[] find = null)
        {
            List<Category> categoryList = new List<Category>();

            string query = "EXEC USP_GetCategories";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

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
            List<Category> categoryList = new List<Category>();
            string query = "EXEC USP_SearchCategories @CategoryName";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });

            foreach (DataRow row in data.Rows)
            {
                Category category = new Category(row);
                categoryList.Add(category);
            }

            return categoryList;
        }

        /// <summary>Thêm thể loại</summary>
        /// <remarks>SP đề xuất: USP_AddCategory</remarks>
        public bool AddCategory(Category category)
        {
            string query = "EXEC USP_AddCategory @name , @ID";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { category.Name, category.ID });
            return result > 0;
        }

        /// <summary>Sửa thể loại theo category.ID</summary>
        /// <remarks>SP đề xuất: USP_UpdateCategory</remarks>
        public bool UpdateCategory(Category category)
        {
            string query = "EXEC USP_UpdateCategory @name , @ID";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { category.Name, category.ID });
            return result > 0;
        }

        /// <summary>Xóa thể loại; trả false nếu còn sách thuộc thể loại này</summary>
        /// <remarks>SP đề xuất: USP_DeleteCategory</remarks>
        public bool DeleteCategory(int categoryId)
        {
            string query = "EXEC USP_DeleteCategory @categoryId";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { categoryId });
            return result > 0;
        }

        /// <summary>Kiểm tra trùng tên thể loại</summary>
        /// <remarks>SP đề xuất: USP_IsCategoryNameExists</remarks>
        public bool IsNameExists(string name)
        {
            string query = "EXEC USP_IsCategoryNameExists @name";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { name });
            return result.Rows.Count > 0;
        }
    }
}

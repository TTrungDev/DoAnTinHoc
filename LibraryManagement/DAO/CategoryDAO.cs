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
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });

            foreach (DataRow row in data.Rows)
            {
                Category category = new Category(row);

                categoryList.Add(category);
            }

            return categoryList;
        }
    }
}

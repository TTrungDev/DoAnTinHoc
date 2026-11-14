using LibraryManagement.DAO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class UCCategory : UserControl
    {
        public UCCategory()
        {
            InitializeComponent();

            LoadCategoryList();
        }

        public void LoadCategoryList()
        {
            string query = "EXEC USP_GetCategoryByCategoryName @categoryName";

            dgvCategory.DataSource = DataProvider.Instacne.ExecuteQuery(query, new object[] { "Khoa học"});
        }
    }
}

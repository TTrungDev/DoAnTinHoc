using LibraryManagement.DAO;
using LibraryManagement.DTO;
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

            LoadCategory();
        }

        public void LoadCategory()
        {
            List<Category> categoryList = CategoryDAO.Instance.LoadCategoryList();

            foreach (Category item in categoryList)
            {
                Button btn = new Button() { Width = CategoryDAO.CategoryWidth, Height = CategoryDAO.CategoryHeight };
                btn.Text = "#" + item.ID + Environment.NewLine + item.Name;

                flpCategory.Controls.Add(btn);

            }

        }
    }
}

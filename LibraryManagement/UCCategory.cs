using LibraryManagement.DAO;
using LibraryManagement.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
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
            showCategoryList();
        }


        private void showCategoryList()
        {
            
            dgvCaterory.DataSource = CategoryDAO.Instance.LoadCategoryList();
            object[] find = { txtFindCT.Text };
            dgvCaterory.DataSource = CategoryDAO.Instance.LoadCategoryList(find);

        }   
    }
}
    
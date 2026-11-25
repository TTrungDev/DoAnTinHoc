using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class UCBook : UserControl
    {
        public UCBook()
        {
            InitializeComponent();
            LoadBookList();
        }

        public void LoadBookList()
        {
            string query = "EXEC USP_GetBooksByTitle @Title";

            dgvBook.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "Clean Code"});
        }
    }
}

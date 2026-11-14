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
            string query = "SELECT * FROM Books";

            dgvBook.DataSource = DataProvider.Instacne.ExecuteQuery(query);
        }
    }
}

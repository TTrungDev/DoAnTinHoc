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
            showBookList();
        }

        public void showBookList()
        {
            dgvBook.DataSource = BookDAO.Instance.LoadBookList();
            object[] find = { txtFindB.Text };
            dgvBook.DataSource = BookDAO.Instance.LoadBookList(find);
        }
    }
}

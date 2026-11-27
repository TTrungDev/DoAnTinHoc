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
    public partial class UCBorrowRecord : UserControl
    {
        public UCBorrowRecord()
        {
            InitializeComponent();
            showBorrowRecordList();
        }
        public void showBorrowRecordList()
        {
            dgvBorrowRecord.DataSource = BorrowRecordDAO.Instance.LoadBorrowRecordList();
        }
    }
}

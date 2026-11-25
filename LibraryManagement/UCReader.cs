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
    public partial class UCReader : UserControl
    {
        public UCReader()
        {
            InitializeComponent();
            ShowReaderList();
        }
        
        private void ShowReaderList()
        {

            dgvReader.DataSource = ReaderDAO.Instance.LoadReaderList();
            object[] find = { txtFind.Text };
            dgvReader.DataSource = ReaderDAO.Instance.LoadReaderList(find);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormLibrarian : Form
    {
        public FormLibrarian()
        {
            InitializeComponent();
        }

        private void rbtnCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCategory.Checked) ucCategory1.BringToFront();
        }

        private void rbtnBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBook.Checked) ucBook1.BringToFront();
        }

        private void rbtnReader_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnReader.Checked) ucReader1.BringToFront();
        }

        private void rbtnBorrowRecord_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBorrowRecord.Checked) ucBorrowRecord1.BringToFront();
        }

        private void rbtnReturnRecord_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnReturnRecord.Checked) ucReturnRecord1.BringToFront();
        }

        private void rbtnOverdue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOverdue.Checked) ucOverdue1.BringToFront();
        }

        private void rbtnStatistical_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnStatistical.Checked) ucStatistical1.BringToFront();
        }

        private void FormLibrarian_Load(object sender, EventArgs e)
        {
            ucCategory1.BringToFront();
        }
    }
}

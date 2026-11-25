using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            loadAccountList();
        }
        void loadAccountList()
        {
            string query = "SELECT * FROM Account";

           dgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }
    }
}

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

            LoadCategoryList();
        }

        void LoadCategoryList()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryManagement;Integrated Security=True;Trust Server Certificate=True";

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Categories";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable data = new DataTable();

            adapter.Fill(data);

            dgvCategory.DataSource = data;

            connection.Close();
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryManagement.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;
        
        public static DataProvider Instacne
        {
            get
            { 
                if(instance == null) 
                    instance = new DataProvider(); 
                return instance; 
            }
            private set{ DataProvider.instance = value;}
        }

        DataProvider(){}

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibraryManagement;Integrated Security=True;Trust Server Certificate=True";

        // object[] parameter = null Là vì nếu không có 
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            // giải phóng cho dù khối lệnh không được thực thi hết
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        // Contains Trả về giá trị cho biết ký tự được chỉ định có xuất hiện trong chuỗi này hay không
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        // Trả về số dòng thực hiện query thành công
        public int ExecuteNoQuery(string query)
        {
            int data = 0;
            // giải phóng cho dù khối lệnh không được thực thi hết
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        // Trả về cột đầu tiên của hàng đầu tiên
        public object ExecuteScalar(string query)
        {
            object data = 0;
            // giải phóng cho dù khối lệnh không được thực thi hết
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

    }
}

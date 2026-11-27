using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryManagement.DAO
{
    internal class ReaderDAO
    {
        private static ReaderDAO instance;

        public static ReaderDAO Instance
        {
            get 
            {
                if (instance == null)
                    instance = new ReaderDAO();
                return instance; 
            }
            set { instance = value; }
        }

        public List<Reader> LoadReaderList(object[] find=null)
        {
            List<Reader> readers = new List<Reader>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetReaders");
            foreach (DataRow item in data.Rows)
            {
                Reader reader = new Reader(item);
                readers.Add(reader);
            }
            return readers;
        }

        /// <summary>Lấy 1 độc giả, không có thì null</summary>
        /// <remarks>SP đề xuất: USP_GetReaderById</remarks>
        public Reader? GetReaderById(int readerId)
        {
            string query = "EXEC USP_GetReaderById @readerId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { readerId });
            if (data.Rows.Count > 0)
            {
                Reader reader = new Reader(data.Rows[0]);
                return reader;
            }
            return null;
        }

        /// <summary>Tìm theo tên, SĐT hoặc email (LIKE)</summary>
        /// <remarks>SP đề xuất: USP_SearchReaders</remarks>
        public List<Reader> SearchReaders(string fullname)
        {
            string query = "EXEC USP_SearchReaders @fullname";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { fullname });
            List<Reader> readers = new List<Reader>();
            foreach (DataRow item in data.Rows)
            {
                Reader reader = new Reader(item);
                readers.Add(reader);
            }
            return readers;
        }

        /// <summary>Thêm độc giả (Users)</summary>
        /// <remarks>SP đề xuất: USP_AddReader</remarks>
        public bool AddReader(Reader reader)
        {
            string query = "EXEC USP_AddReader @fullname , @email , @phoneNumber , @address";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { reader.FullName, reader.Email, reader.PhoneNumber, reader.Address });
            return result > 0;
        }

        /// <summary>Sửa độc giả theo reader.ID (không sửa Balance)</summary>
        /// <remarks>SP đề xuất: USP_UpdateReader</remarks>
        public bool UpdateReader(Reader reader)
        {
            string query = "EXEC USP_UpdateReader @readerId , @fullname , @email , @phoneNumber , @address";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { reader.ID, reader.FullName, reader.Email, reader.PhoneNumber, reader.Address });
            return result > 0;
        }

            DataTable data = DataProvider.Instacne.ExecuteQuery(query,find);

            List<Reader> readerList = new List<Reader>();
            foreach (DataRow row in data.Rows)
            {
                Reader reader = new Reader(row);
                readerList.Add(reader);
            }

        /// <summary>Lịch sử nạp quỹ và phạt của độc giả, mới nhất trước</summary>
        /// <remarks>SP đề xuất: USP_GetWalletHistory</remarks>
        public List<WalletTransaction> LoadWalletHistory(int readerId)
        /// <summary>Xóa độc giả; trả false nếu còn sách chưa trả hoặc đã có phiếu mượn</summary>
        /// <remarks>SP đề xuất: USP_DeleteReader</remarks>
        public bool DeleteReader(int readerId)
        {
            string query = "EXEC USP_DeleteReader @readerId";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { readerId });
            return result > 0;
        }

        /// <summary>Kiểm tra trùng email (bỏ qua chính độc giả đang sửa)</summary>
        /// <remarks>SP đề xuất: USP_IsEmailExists</remarks>
        public bool IsEmailExists(string email, int? excludeReaderId = null)
        {
           string query = "EXEC USP_IsEmailExists @email , @excludeReaderId";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { email, excludeReaderId });
            return result.Rows.Count > 0;
        }

        /// <summary>Số dư quỹ hiện tại</summary>
        /// <remarks>SP đề xuất: USP_GetBalance</remarks>
        public decimal GetBalance(int readerId)
        {
            string query = "EXEC USP_GetBalance @readerId";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { readerId });
            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["Balance"]);
            }
            return 0;
        }
            string query = "EXEC USP_GetWalletHistory @readerId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { readerId });
            List<WalletTransaction> transactions = new List<WalletTransaction>();
            foreach (DataRow item in data.Rows)
            {
                WalletTransaction transaction = new WalletTransaction(item);
                transactions.Add(transaction);
            }
            return transactions;
        }
    }
}

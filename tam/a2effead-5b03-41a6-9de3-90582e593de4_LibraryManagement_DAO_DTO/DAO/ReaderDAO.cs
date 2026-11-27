using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LibraryManagement.DAO
{
    internal class ReaderDAO
    {
        private static ReaderDAO instation;

        public static ReaderDAO Instation
        {
            get 
            {
                if (instation == null)
                    instation = new ReaderDAO();
                return instation; 
            }
            set { instation = value; }
        }

        public List<Reader> LoadReaderList(object[] find=null)
        {
            string query = "EXEC USP_GetReadersByFullName @fullName";

            DataTable data = DataProvider.Instacne.ExecuteQuery(query,find);

            List<Reader> readerList = new List<Reader>();
            foreach (DataRow row in data.Rows)
            {
                Reader reader = new Reader(row);
                readerList.Add(reader);
            }

            return readerList;
        }

        /// <summary>Lấy 1 độc giả, không có thì null</summary>
        /// <remarks>SP đề xuất: USP_GetReaderById</remarks>
        public Reader? GetReaderById(int readerId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Tìm theo tên, SĐT hoặc email (LIKE)</summary>
        /// <remarks>SP đề xuất: USP_SearchReaders</remarks>
        public List<Reader> SearchReaders(string keyword)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Thêm độc giả (Users)</summary>
        /// <remarks>SP đề xuất: USP_AddReader</remarks>
        public bool AddReader(Reader reader)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Sửa độc giả theo reader.ID (không sửa Balance)</summary>
        /// <remarks>SP đề xuất: USP_UpdateReader</remarks>
        public bool UpdateReader(Reader reader)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Xóa độc giả; trả false nếu còn sách chưa trả hoặc đã có phiếu mượn</summary>
        /// <remarks>SP đề xuất: USP_DeleteReader</remarks>
        public bool DeleteReader(int readerId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Kiểm tra trùng email (bỏ qua chính độc giả đang sửa)</summary>
        /// <remarks>SP đề xuất: USP_IsEmailExists</remarks>
        public bool IsEmailExists(string email, int? excludeReaderId = null)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Số dư quỹ hiện tại</summary>
        /// <remarks>SP đề xuất: USP_GetBalance</remarks>
        public decimal GetBalance(int readerId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Nạp quỹ (amount > 0): cộng Balance và ghi WalletTransactions (Deposit) trong 1 transaction</summary>
        /// <remarks>SP đề xuất: USP_Deposit</remarks>
        public bool Deposit(int readerId, decimal amount, int staffId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Lịch sử nạp quỹ và phạt của độc giả, mới nhất trước</summary>
        /// <remarks>SP đề xuất: USP_GetWalletHistory</remarks>
        public List<WalletTransaction> LoadWalletHistory(int readerId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

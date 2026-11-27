using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Phiếu mượn sách</summary>
    internal class BorrowRecordDAO
    {
        private static BorrowRecordDAO? instance;

        public static BorrowRecordDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BorrowRecordDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private BorrowRecordDAO() { }

        /// <summary>Lập phiếu mượn: thêm BorrowRecords + BorrowDetails (record.Details) và trừ Books.Available trong 1 transaction. Trả BorrowID mới, thất bại trả 0</summary>
        /// <remarks>SP đề xuất: USP_CreateBorrowRecord</remarks>
        public int CreateBorrowRecord(BorrowRecord record)
        {
            string query = "EXEC USP_CreateBorrowRecord @readerId , @issuedBy , @borrowDate , @dueDate";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[]{ record.ReaderID,record.IssuedBy,record.BorrowDate,record.DueDate});

            return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
        }

        /// <summary>Danh sách phiếu mượn (có ReaderName, IssuedByName), mới nhất trước</summary>
        /// <remarks>SP đề xuất: USP_GetBorrowRecords</remarks>
        public List<BorrowRecord> LoadBorrowRecordList()
        {
            List<BorrowRecord> records = new List<BorrowRecord>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetBorrowRecords");
            foreach (DataRow item in data.Rows)
            {
                BorrowRecord record = new BorrowRecord(item);
                records.Add(record);
            }
            return records;
        }

        /// <summary>Phiếu mượn của 1 độc giả (dùng cho lịch sử của độc giả)</summary>
        /// <remarks>SP đề xuất: USP_GetBorrowRecordsByReader</remarks>
        public List<BorrowRecord> LoadBorrowRecordsByReader(int readerId)
        {
            List<BorrowRecord> records = new List<BorrowRecord>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetBorrowRecordsByReader @readerId", new object[] { readerId });
            foreach (DataRow item in data.Rows)
            {
                BorrowRecord record = new BorrowRecord(item);
                records.Add(record);
            }
            return records;
        }

        /// <summary>Các cuốn trong 1 phiếu (có BookTitle)</summary>
        /// <remarks>SP đề xuất: USP_GetBorrowDetails</remarks>
        public List<BorrowDetail> LoadBorrowDetails(int borrowId)
        {
            List<BorrowDetail> details = new List<BorrowDetail>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetBorrowDetails @borrowId", new object[] { borrowId });
            foreach (DataRow item in data.Rows)
            {
                BorrowDetail detail = new BorrowDetail(item);
                details.Add(detail);
            }
            return details;
        }

        /// <summary>Tổng số cuốn độc giả đang mượn chưa trả (kiểm tra MaxBooksPerReader)</summary>
        /// <remarks>SP đề xuất: USP_CountBooksBorrowing</remarks>
        public int CountBooksBorrowing(int readerId)
        {
            string query = "EXEC USP_CountBooksBorrowing @readerId";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { readerId });
            return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
        }

        /// <summary>Độc giả có sách quá hạn chưa trả không (nếu có thì không cho mượn)</summary>
        /// <remarks>SP đề xuất: USP_HasOverdue</remarks>
        public bool HasOverdue(int readerId)
        {
           string query = "EXEC USP_HasOverdue @readerId";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { readerId });
            return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) > 0 : false;
        }

        /// <summary>Số cuốn còn trong kho của 1 sách</summary>
        /// <remarks>SP đề xuất: USP_GetAvailable</remarks>
        public int GetAvailable(int bookId)
        {
            string query = "EXEC USP_GetAvailable @bookId";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { bookId });
            return (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
        }
    }
}

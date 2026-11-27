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
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Danh sách phiếu mượn (có ReaderName, IssuedByName), mới nhất trước</summary>
        /// <remarks>SP đề xuất: USP_GetBorrowRecords</remarks>
        public List<BorrowRecord> LoadBorrowRecordList()
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Phiếu mượn của 1 độc giả (dùng cho lịch sử của độc giả)</summary>
        /// <remarks>SP đề xuất: USP_GetBorrowRecordsByReader</remarks>
        public List<BorrowRecord> LoadBorrowRecordsByReader(int readerId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Các cuốn trong 1 phiếu (có BookTitle)</summary>
        /// <remarks>SP đề xuất: USP_GetBorrowDetails</remarks>
        public List<BorrowDetail> LoadBorrowDetails(int borrowId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Tổng số cuốn độc giả đang mượn chưa trả (kiểm tra MaxBooksPerReader)</summary>
        /// <remarks>SP đề xuất: USP_CountBooksBorrowing</remarks>
        public int CountBooksBorrowing(int readerId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Độc giả có sách quá hạn chưa trả không (nếu có thì không cho mượn)</summary>
        /// <remarks>SP đề xuất: USP_HasOverdue</remarks>
        public bool HasOverdue(int readerId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Số cuốn còn trong kho của 1 sách</summary>
        /// <remarks>SP đề xuất: USP_GetAvailable</remarks>
        public int GetAvailable(int bookId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

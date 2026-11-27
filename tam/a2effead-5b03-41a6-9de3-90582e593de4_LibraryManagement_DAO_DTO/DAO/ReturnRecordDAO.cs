using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Trả sách và tính phạt</summary>
    internal class ReturnRecordDAO
    {
        private static ReturnRecordDAO? instance;

        public static ReturnRecordDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ReturnRecordDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private ReturnRecordDAO() { }

        /// <summary>Các cuốn độc giả đang mượn chưa trả (có BookTitle, BorrowDate, DueDate)</summary>
        /// <remarks>SP đề xuất: USP_GetUnreturnedDetails</remarks>
        public List<BorrowDetail> LoadUnreturnedDetails(int readerId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Các cuốn chưa trả của 1 phiếu (tìm theo mã phiếu)</summary>
        /// <remarks>SP đề xuất: USP_GetUnreturnedDetailsByBorrowId</remarks>
        public List<BorrowDetail> LoadUnreturnedDetailsByBorrowId(int borrowId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Tiền phạt = số ngày trễ x FinePerDay (lấy từ Settings). Không trễ trả 0</summary>
        /// <remarks>SP đề xuất: (dùng SettingDAO.GetFinePerDay)</remarks>
        public decimal CalculateFine(DateTime dueDate, DateTime returnDate)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Trả các cuốn đã chọn trong 1 transaction: ghi ReturnDate và FineAmount, cộng lại Available, trừ phạt vào Balance, ghi WalletTransactions (Fine). Thất bại thì message nêu lý do</summary>
        /// <remarks>SP đề xuất: USP_ReturnBooks</remarks>
        public bool ReturnBooks(List<int> detailIds, DateTime returnDate, int staffId, out string message)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

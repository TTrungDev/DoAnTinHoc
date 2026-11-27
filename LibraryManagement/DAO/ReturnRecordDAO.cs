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
            List<BorrowDetail> unreturnedDetails = new List<BorrowDetail>();
            string query = "EXEC USP_GetUnreturnedDetails @readerId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { readerId });
            foreach (DataRow item in data.Rows)
            {
                BorrowDetail detail = new BorrowDetail(item);
                unreturnedDetails.Add(detail);
            }
            return unreturnedDetails;
        }

        /// <summary>Các cuốn chưa trả của 1 phiếu (tìm theo mã phiếu)</summary>
        /// <remarks>SP đề xuất: USP_GetUnreturnedDetailsByBorrowId</remarks>
        public List<BorrowDetail> LoadUnreturnedDetailsByBorrowId(int borrowId)
        {
            List<BorrowDetail> unreturnedDetails = new List<BorrowDetail>();
            string query = "EXEC USP_GetUnreturnedDetailsByBorrowId @borrowId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { borrowId });
            foreach (DataRow item in data.Rows)
            {
                BorrowDetail detail = new BorrowDetail(item);
                unreturnedDetails.Add(detail);
            }
            return unreturnedDetails;
        }

        /// <summary>Tiền phạt = số ngày trễ x FinePerDay (lấy từ Settings). Không trễ trả 0</summary>
        /// <remarks>SP đề xuất: (dùng SettingDAO.GetFinePerDay)</remarks>
        public decimal CalculateFine(DateTime dueDate, DateTime returnDate)
        {
            string query = "EXEC USP_GetFinePerDay";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                decimal finePerDay = Convert.ToDecimal(data.Rows[0]["FinePerDay"]);
                int daysLate = (returnDate - dueDate).Days;
                if (daysLate > 0)
                {
                    return daysLate * finePerDay;
                }
            }
            return 0;
        }

        /// <summary>Trả các cuốn đã chọn trong 1 transaction: ghi ReturnDate và FineAmount, cộng lại Available, trừ phạt vào Balance, ghi WalletTransactions (Fine). Thất bại thì message nêu lý do</summary>
        /// <remarks>SP đề xuất: USP_ReturnBooks</remarks>
        public bool ReturnBooks(List<int> detailIds, DateTime returnDate, int staffId, out string message)
        {
            message = string.Empty;
            if (detailIds == null || detailIds.Count == 0)
            {
                message = "Không có cuốn sách nào được chọn để trả.";
                return false;
            }
            string query = "EXEC USP_ReturnBooks @detailIds , @returnDate , @staffId";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { string.Join(",", detailIds), returnDate, staffId });
            if (result > 0)
            {
                return true;
            }
            else
            {
                message = "Trả sách thất bại. Vui lòng kiểm tra lại.";
                return false;
            }
        }
    }
}

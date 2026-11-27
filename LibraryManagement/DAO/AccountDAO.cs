using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement.DAO
{
    /// <summary>Tài khoản, đăng nhập, đăng ký</summary>
    internal class AccountDAO
    {
        private static AccountDAO? instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private AccountDAO() { }

        /// <summary>Đăng nhập: trả về tài khoản (kèm FullName) hoặc null nếu sai tên/mật khẩu</summary>
        /// <remarks>SP đề xuất: USP_Login</remarks>
        public bool Login(string username, string passwordHash)
        {
                string query = "EXEC USP_Login @username , @passwordHash";

                DataTable resutl= DataProvider.Instance.ExecuteQuery(query, new object[] { username, passwordHash });

                return resutl.Rows.Count > 0;
        }

        /// <summary>Đăng ký độc giả mới: tạo Users + Accounts (Role = Reader) trong 1 transaction</summary>
        /// <remarks>SP đề xuất: USP_Register</remarks>
        public bool Register(Reader reader, string username, string passwordHash)
        {
            string query = "EXEC USP_Register @username , @passwordHash , @fullname , @email , @PhoneNumber , @Adress";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { username, passwordHash, reader.FullName, reader.Email, reader.PhoneNumber, reader.Address });
            return result > 0;

        }

        /// <summary>Lấy toàn bộ tài khoản (JOIN Users để có FullName)</summary>
        /// <remarks>SP đề xuất: USP_GetAccounts</remarks>
        public List<Account> LoadAccountList()
        {
            List<Account> accounts = new List<Account>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetAccounts");
            foreach (DataRow item in data.Rows)
            {
                Account account = new Account(item);
                accounts.Add(account);
            }
            return accounts;    
        }

        /// <summary>Tạo tài khoản cho 1 User đã có (account.UserID)</summary>
        /// <remarks>SP đề xuất: USP_AddAccount</remarks>
        public bool AddAccount(Account account)
        {
            string query = "EXEC USP_AddAccount @userId , @username , @passwordHash , @role";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { account.UserID, account.Username, account.PasswordHash, account.Role });
            return result > 0;

        }

        /// <summary>Đổi vai trò (Admin, Librarian, Reader)</summary>
        /// <remarks>SP đề xuất: USP_UpdateAccountRole</remarks>
        public bool UpdateRole(int accountId, string role)
        {
            string query = "EXEC USP_UpdateAccountRole @accountId , @role";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { accountId, role });
            return result > 0;
        }

        /// <summary>Đổi mật khẩu (nhận vào hash, không nhận mật khẩu gốc)</summary>
        /// <remarks>SP đề xuất: USP_ChangePassword</remarks>
        public bool ChangePassword(int accountId, string newPasswordHash)
        {
            string query = "EXEC USP_ChangePassword @accountId , @newPasswordHash";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { accountId, newPasswordHash });
            return result > 0;
        }

        /// <summary>Xóa tài khoản</summary>
        /// <remarks>SP đề xuất: USP_DeleteAccount</remarks>
        public bool DeleteAccount(int accountId)
        {
            string query = "EXEC USP_DeleteAccount @accountId";
            int result = DataProvider.Instance.ExecuteNoQuery(query, new object[] { accountId });
            return result > 0;
        }

        /// <summary>Kiểm tra tên đăng nhập đã tồn tại chưa</summary>
        /// <remarks>SP đề xuất: USP_IsUsernameExists</remarks>
        public bool IsUsernameExists(string username)
        {
            string query = "EXEC USP_IsUsernameExists @username";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return result.Rows.Count > 0;
        }
    }
}

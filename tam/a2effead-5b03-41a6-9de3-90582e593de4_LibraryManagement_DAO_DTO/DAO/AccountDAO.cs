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
        public Account? Login(string username, string passwordHash)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Đăng ký độc giả mới: tạo Users + Accounts (Role = Reader) trong 1 transaction</summary>
        /// <remarks>SP đề xuất: USP_Register</remarks>
        public bool Register(Reader reader, string username, string passwordHash)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Lấy toàn bộ tài khoản (JOIN Users để có FullName)</summary>
        /// <remarks>SP đề xuất: USP_GetAccounts</remarks>
        public List<Account> LoadAccountList()
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Tạo tài khoản cho 1 User đã có (account.UserID)</summary>
        /// <remarks>SP đề xuất: USP_AddAccount</remarks>
        public bool AddAccount(Account account)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Đổi vai trò (Admin, Librarian, Reader)</summary>
        /// <remarks>SP đề xuất: USP_UpdateAccountRole</remarks>
        public bool UpdateRole(int accountId, string role)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Đổi mật khẩu (nhận vào hash, không nhận mật khẩu gốc)</summary>
        /// <remarks>SP đề xuất: USP_ChangePassword</remarks>
        public bool ChangePassword(int accountId, string newPasswordHash)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Xóa tài khoản</summary>
        /// <remarks>SP đề xuất: USP_DeleteAccount</remarks>
        public bool DeleteAccount(int accountId)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }

        /// <summary>Kiểm tra tên đăng nhập đã tồn tại chưa</summary>
        /// <remarks>SP đề xuất: USP_IsUsernameExists</remarks>
        public bool IsUsernameExists(string username)
        {
            // TODO: Triệu code ở đây
            throw new NotImplementedException();
        }
    }
}

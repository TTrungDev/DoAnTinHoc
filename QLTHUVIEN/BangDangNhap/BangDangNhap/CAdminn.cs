using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangDangNhap
{
    public class CAdminn
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public CAdminn() { }

        public CAdminn(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // Hàm kiểm tra thông tin đăng nhập có khớp hay không
        public bool KiemTraDangNhap(string inputUser, string inputPass)
        {
            return Username.Equals(inputUser, StringComparison.OrdinalIgnoreCase)
                   && Password == inputPass;
        }
    }
}

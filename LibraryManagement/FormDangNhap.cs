using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 2. Hàm kiểm tra dữ liệu đầu vào (Validation)
        private bool KiemTraHopLe()
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpassword.Focus();
                return false;
            }

            return true;
        }

        // 3. Hàm xử lý sự kiện nút "Sign In"
        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {

            FormDangKy f = new FormDangKy();
            f.Show();
        }

        // 5. Hàm xử lý sự kiện nhấn vào "Forgot_password."
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

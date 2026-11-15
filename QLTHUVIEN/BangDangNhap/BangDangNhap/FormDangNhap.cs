using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangDangNhap
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
        private List<CAdminn> danhSachTaiKhoan = new List<CAdminn>();
        // 1. Hàm khởi tạo khi mở Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Ẩn ký tự mật khẩu thành dấu chấm/sao
            txtpassword.UseSystemPasswordChar = true;

            // Tạo sẵn 1 tài khoản mẫu để test
            danhSachTaiKhoan.Add(new CAdminn("admin", "123456"));
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
            if (!KiemTraHopLe()) return;

            string user = txtusername.Text.Trim();
            string pass = txtpassword.Text;

            // Tìm kiếm tài khoản hợp lệ trong danh sách
            bool dangNhapThanhCong = false;
            foreach (CAdminn tk in danhSachTaiKhoan)
            {
                if (tk.KiemTraDangNhap(user, pass))
                {
                    dangNhapThanhCong = true;
                    break;
                }
            }

            if (dangNhapThanhCong)
            {
                // Kiểm tra trạng thái checkbox remember_password
                if (!chkRemember.Checked)
                {
                    txtpassword.Clear();
                }

                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: Mở Form chính của chương trình tại đây
                // FormMain f = new FormMain();
                // this.Hide();
                // f.ShowDialog();
                // this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtpassword.Focus();
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            FormDangKy f= new FormDangKy();
            f.Show();
        }

        // 5. Hàm xử lý sự kiện nhấn vào "Forgot_password."
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text.Trim();
            if (string.IsNullOrWhiteSpace(user))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản vào ô bên trên trước khi lấy lại mật khẩu!",
                    "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.Focus();
                return;
            }

            foreach (CAdminn tk in danhSachTaiKhoan)
            {
                if (tk.Username.Equals(user, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Mật khẩu của tài khoản '{user}' là: {tk.Password}",
                        "Khôi phục mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Không tìm thấy tài khoản này trong hệ thống!", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

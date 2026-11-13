using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form1 : Form
    {
        List<CSach> dsSach = new List<CSach>();
        List<CPhieuMuon> dsPhieu = new List<CPhieuMuon>();
        CDocGia nguoiDung = new CDocGia();
        string fileSach = "sach.dat";
        string filePhieu = "phieu.dat";
        string fileDocGia = "docgia.dat";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DocFile();
            if (dsSach.Count == 0)
            {
                dsSach.Add(new CSach("S01", "Đắc Nhân Tâm", "Dale Carnegie", "Kỹ năng sống", 10));
                dsSach.Add(new CSach("S02", "Lập trình C#", "Microsoft", "Tin học", 5));
                dsSach.Add(new CSach("S03", "Tuổi trẻ đáng giá bao nhiêu", "Rosie Nguyễn", "Kỹ năng sống", 8));
            }
            if (dsPhieu.Count == 0)
            {
                dsPhieu.Add(new CPhieuMuon("PM01", "Đắc Nhân Tâm", DateTime.Now.AddDays(-10), DateTime.Now.AddDays(4), "Đang mượn"));
                dsPhieu.Add(new CPhieuMuon("PM02", "Lập trình C#", DateTime.Now.AddDays(-20), DateTime.Now.AddDays(-6), "Quá Hạn"));
            }
            if (string.IsNullOrEmpty(nguoiDung.MaDG))
            {
                nguoiDung = new CDocGia("DG01", "Nguyễn Hồng Triết", "0123456789", "triet@gmail.com", "TP.HCM", 0);
            }
            GhiFile();     
            dgvSach.DataSource = dsSach;
            dgvPhieuMuon.DataSource = dsPhieu;
            HienThiThongTinNguoiDung();
            if (cboTimTheoSach.Items.Count > 0) cboTimTheoSach.SelectedIndex = 0; 
            if (cboTinhTrangPhieu.Items.Count > 0) cboTinhTrangPhieu.Text = "Tất cả";
        }
        private void HienThiThongTinNguoiDung()
        {
            txtMaDG.Text = nguoiDung.MaDG;
            txtHoTen.Text = nguoiDung.HoTen;
            txtSoDT.Text = nguoiDung.SoDT;
            txtEmail.Text = nguoiDung.Email;
            txtDiaChi.Text = nguoiDung.DiaChi;
            lblSoDu.Text = nguoiDung.SoDuQuy.ToString("#,##0") + " VNĐ";
        }
        private void DocFile()
        {
            try
            {
                if (File.Exists(fileSach))
                {
                    FileStream fs1 = new FileStream(fileSach, FileMode.Open);
                    BinaryFormatter bf1 = new BinaryFormatter();
                    dsSach = (List<CSach>)bf1.Deserialize(fs1);
                    fs1.Close();
                }
                if (File.Exists(filePhieu))
                {
                    FileStream fs2 = new FileStream(filePhieu, FileMode.Open);
                    BinaryFormatter bf2 = new BinaryFormatter();
                    dsPhieu = (List<CPhieuMuon>)bf2.Deserialize(fs2);
                    fs2.Close();
                }
                if (File.Exists(fileDocGia))
                {
                    FileStream fs3 = new FileStream(fileDocGia, FileMode.Open);
                    BinaryFormatter bf3 = new BinaryFormatter();
                    nguoiDung = (CDocGia)bf3.Deserialize(fs3);
                    fs3.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi đọc file: " + ex.Message); }
        }

        private void GhiFile()
        {
            try
            {
                FileStream fs1 = new FileStream(fileSach, FileMode.Create);
                BinaryFormatter bf1 = new BinaryFormatter();
                bf1.Serialize(fs1, dsSach);
                fs1.Close();

                FileStream fs2 = new FileStream(filePhieu, FileMode.Create);
                BinaryFormatter bf2 = new BinaryFormatter();
                bf2.Serialize(fs2, dsPhieu);
                fs2.Close();

                FileStream fs3 = new FileStream(fileDocGia, FileMode.Create);
                BinaryFormatter bf3 = new BinaryFormatter();
                bf3.Serialize(fs3, nguoiDung);
                fs3.Close();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi ghi file: " + ex.Message); }
        }
        private void LocPhieuMuon()
        {
            string tinhTrang = cboTinhTrangPhieu.Text; // Tất cả, Đang mượn, Đã trả, Quá Hạn
            string tuKhoa = txtTimKiemPhieu.Text.ToLower();
            List<CPhieuMuon> kq = new List<CPhieuMuon>();

            foreach (CPhieuMuon p in dsPhieu)
            {
                bool thoaDieuKien = true;

                if (tinhTrang != "Tất cả" && p.TinhTrang != tinhTrang) thoaDieuKien = false;
                if (tuKhoa != "" && !p.MaPhieu.ToLower().Contains(tuKhoa) && !p.TenSach.ToLower().Contains(tuKhoa)) thoaDieuKien = false;

                if (thoaDieuKien) kq.Add(p);
            }

            dgvPhieuMuon.DataSource = null;
            dgvPhieuMuon.DataSource = kq;
        }
        private void cboTinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocPhieuMuon();
        }
        private void btnNapQuy_Click(object sender, EventArgs e)
        {
            try
            {
                double tienNap = Convert.ToDouble(txtTienNap.Text);
                if (tienNap > 0)
                {
                    nguoiDung.SoDuQuy += tienNap;
                    HienThiThongTinNguoiDung();
                    GhiFile();
                    MessageBox.Show("Nạp thành công " + tienNap.ToString("#,##0") + " VNĐ!", "Thành công");
                    txtTienNap.Clear();
                }
                else MessageBox.Show("Số tiền nạp phải lớn hơn 0!");
            }
            catch { MessageBox.Show("Vui lòng nhập đúng định dạng số!"); }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void cboTimTheoSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            string tieuChi = cboTimTheoSach.Text; // Lấy tiêu chí chọn từ ComboBox (Tên sách, Tác giả, Thể loại)
            string tuKhoa = txtTimKiemSach.Text.ToLower().Trim(); // Lấy từ khóa và chuyển về chữ thường
            List<CSach> dsKetQua = new List<CSach>();

            // Duyệt qua toàn bộ danh sách sách trong kho
            foreach (CSach s in dsSach)
            {
                bool thoa = false;
                if (tieuChi == "Tên sách" && s.TenSach.ToLower().Contains(tuKhoa))
                {
                    thoa = true;
                }
                else if (tieuChi == "Tác giả" && s.TacGia.ToLower().Contains(tuKhoa))
                {
                    thoa = true;
                }
                else if (tieuChi == "Thể loại" && s.TheLoai.ToLower().Contains(tuKhoa))
                {
                    thoa = true;
                }
                if (thoa)
                {
                    dsKetQua.Add(s);
                }
            }       
            dgvSach.DataSource = null;
            dgvSach.DataSource = dsKetQua;
            if (dsKetQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy cuốn sách nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

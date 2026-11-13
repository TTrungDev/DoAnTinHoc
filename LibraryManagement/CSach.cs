using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class CSach
    {
        private string m_masach;
        private string m_tensach;
        private string m_tacgia;
        private string m_theloai;
        private int m_soluong;
        public string MaSach { get { return m_masach; } set { m_masach = value; } }
        public string TenSach { get { return m_tensach; } set { m_tensach = value; } }
        public string TacGia { get { return m_tacgia; } set { m_tacgia = value; } }
        public string TheLoai { get { return m_theloai; } set { m_theloai = value; } }
        public int SoLuong { get { return m_soluong; } set { m_soluong = value; } }
        public CSach() { }
        public CSach(string ma, string ten, string tg, string tl, int sl)
        {
            m_masach = ma;
            m_tensach = ten;
            m_tacgia = tg;
            m_theloai = tl;
            m_soluong = sl;
        }
    }

}

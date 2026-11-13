using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class CDocGia
    {
        private string m_madg;
        private string m_hoten;
        private string m_sdt;
        private string m_email;
        private string m_diachi;
        private double m_soduquy;

        public string MaDG { get { return m_madg; } set { m_madg = value; } }
        public string HoTen { get { return m_hoten; } set { m_hoten = value; } }
        public string SoDT { get { return m_sdt; } set { m_sdt = value; } }
        public string Email { get { return m_email; } set { m_email = value; } }
        public string DiaChi { get { return m_diachi; } set { m_diachi = value; } }
        public double SoDuQuy { get { return m_soduquy; } set { m_soduquy = value; } }

        public CDocGia() { }

        public CDocGia(string ma, string ten, string sdt, string email, string dc, double sodu)
        {
            m_madg = ma;
            m_hoten = ten;
            m_sdt = sdt;
            m_email = email;
            m_diachi = dc;
            m_soduquy = sodu;
        }
    }
}

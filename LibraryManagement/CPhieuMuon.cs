using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class CPhieuMuon
    {
        private string m_maphieu;
        private string m_tensach;
        private DateTime m_ngaymuon;
        private DateTime m_hantra;
        private string m_tinhtrang;
        private double m_dongia;
        public string MaPhieu { get { return m_maphieu; } set { m_maphieu = value; } }
        public string TenSach { get { return m_tensach; } set { m_tensach = value; } }
        public DateTime NgayMuon { get { return m_ngaymuon; } set { m_ngaymuon = value; } }
        public DateTime HanTra { get { return m_hantra; } set { m_hantra = value; } }
        public string TinhTrang { get { return m_tinhtrang; } set { m_tinhtrang = value; } }
        public double DonGia { get { return m_dongia; } set { m_dongia = value; } }
        public CPhieuMuon() { }
        public CPhieuMuon(string ma, string ten, DateTime nm, DateTime ht, string tt)
        {
            m_maphieu = ma;
            m_tensach = ten;
            m_ngaymuon = nm;
            m_hantra = ht;
            m_tinhtrang = tt;
            m_dongia = DonGia;
        }
        public double ThanhTien
        {
            get
            {
                int soNgay = (HanTra - NgayMuon).Days;
                if (soNgay < 1) soNgay = 1;
                return soNgay * m_dongia;
            }
        }
    }
}

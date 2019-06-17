using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeThuoc.Thuoc_DAL;
namespace KeThuoc.Thuoc_BLL
{
    class DonThuoc_BLL
    {
        Thuoc_DAL.Thuoc_DAL DonVaThuoc = new Thuoc_DAL.Thuoc_DAL();
        public IEnumerable<Object> HienThiDonThuocAdmin()
        {
            return DonVaThuoc.HienThiDonThuocAdmin();
        }
        public int LayMaDTLonNhat()
        {
            return DonVaThuoc.LayMaDTLonNhat();
        }
        public void ThemDonVaThuoc(DonVaThuoc DvT)
        {
            DonVaThuoc.ThemDonVaThuoc(DvT);
        }
        public void ThemDonThuoc(DonThuoc DT)
        {
            DonVaThuoc.ThemDonThuoc(DT);
        }
        public IEnumerable<Object> HienThiDanhSachThuocDaChon(string maDT)
        {
            return DonVaThuoc.HienThiDanhSachThuocDaChon(maDT);
        }
        public int TongSoDonThuocAdmin()
        {
            return DonVaThuoc.TongSoDonThuocAdmin();
        }
        public int TongSoDonThuocBacSi(string maBS)
        {
            return DonVaThuoc.TongSoDonThuocBacSi(maBS);
        }
        public string LayMaBenhNhanTuMaDon(string maDon)
        {
            return DonVaThuoc.LayMaBenhNhanTuMaDon(maDon);
        }
        public string LayMaBacSiTuMaDon(string maDon)
        {
            return DonVaThuoc.LayMaBacSiTuMaDon(maDon);
        }
        public DonThuoc LayThongTin1DonThuoc(string maDon)
        {
            return DonVaThuoc.LayThongTin1DonThuoc(maDon);
        }
        public IEnumerable<Object> HienThiDonThuocBacSi(string maBS)
        {
            return DonVaThuoc.HienThiDonThuocBacSi(maBS);
        }
        public IEnumerable<Object> HienThiDonThuocBenhNhan(string maBN)
        {
            return DonVaThuoc.HienThiDonThuocBenhNhan(maBN);
        }
        public IEnumerable<Object> HienThiDonThuocBenhNhanTheoNgay(DateTime date, string maBN)
        {
            return DonVaThuoc.HienThiDonThuocBenhNhanTheoNgay(date, maBN);
        }
        public IEnumerable<Object> HienThiDonThuocBenhNhanFromTo(DateTime dateFrom, DateTime dateTo, string maBN)
        {
            return DonVaThuoc.HienThiDonThuocBenhNhanFromTo(dateFrom, dateTo, maBN);
        }
        public IEnumerable<Object> KiemTraNgayLamViecCaNhan(DateTime date, string maBS)
        {
            return DonVaThuoc.KiemTraNgayLamViecCaNhan(date, maBS);
        }
        public IEnumerable<Object> KiemTraNgayLamViecCaNhanFromTo(DateTime dateFrom, DateTime dateTo, string maBS)
        {
            return DonVaThuoc.KiemTraNgayLamViecCaNhanFromTo(dateFrom, dateTo, maBS);
        }
        public IEnumerable<Object> KiemTraNgayLamViecThongKe(DateTime date)
        {
            return DonVaThuoc.KiemTraNgayLamViecThongKe(date);
        }
        public IEnumerable<Object> KiemTraNgayLamViecThongKeFromTo(DateTime dateFrom, DateTime dateTo)
        {
            return DonVaThuoc.KiemTraNgayLamViecThongKeFromTo(dateFrom, dateTo);
        }
    } 
}

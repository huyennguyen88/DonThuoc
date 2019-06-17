using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using KeThuoc.Thuoc_DAL;
namespace KeThuoc.Thuoc_BLL
{
    class BenhNhan_BLL
    {
        Thuoc_DAL.Thuoc_DAL QuanLyBenhNhan = new Thuoc_DAL.Thuoc_DAL();
        public IEnumerable<Object> HienThiThongTin()
        {
            return QuanLyBenhNhan.HienThiThongTinBenhNhan();
        }
        public IEnumerable<Object> TimKiemBenhNhanTheoTen(string ten)
        {
            return QuanLyBenhNhan.TimKiemBenhNhanTheoTen(ten);
        }
        public BenhNhan LayThongTin1BenhNhan(string ma)
        {
            return QuanLyBenhNhan.LayThongTin1BenhNhan(ma);
        }
        public void ChinhSuaBenhNhan(BenhNhan benhnhan)
        {
            QuanLyBenhNhan.ChinhSuaBenhNhan(benhnhan);
        }
        public void ThemBenhNhan(BenhNhan benhnhan)
        {
            QuanLyBenhNhan.ThemBenhNhan(benhnhan);
        }
        public void XoaBenhNhan(List<string> maList)
        {
            QuanLyBenhNhan.XoaBenhNhan(maList);
        }
        public IEnumerable<Object> SapXepBenhNhanTheoTen(List<string> maList,int kieu)
        {
            return QuanLyBenhNhan.SapXepBenhNhanTheoTen(maList, kieu);
        }
        public IEnumerable<Object> SapXepBenhNhanTheoSDT(List<string> maList,int kieu)
        {
            return QuanLyBenhNhan.SapXepBenhNhanhTheoSDT(maList, kieu);
        }
        public int LayMaBNLonNhat()
        {
            return QuanLyBenhNhan.LayMaBNLonNhat();
        }
        public void ImportBenhNhan(DataSet excel)
        {
            QuanLyBenhNhan.ImportExcelBenhNhan(excel);
        }
    }
}

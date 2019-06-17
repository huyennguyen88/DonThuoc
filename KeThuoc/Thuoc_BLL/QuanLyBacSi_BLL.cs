using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeThuoc.Thuoc_DAL;
namespace KeThuoc.Thuoc_BLL
{
    class QuanLyBacSi_BLL
    {
        Thuoc_DAL.Thuoc_DAL QuanLyBacSi = new Thuoc_DAL.Thuoc_DAL();
        public IEnumerable<Object> HienThiThongTin()
        {
            return QuanLyBacSi.HienThiThongTinBacSi();
        }
        public IEnumerable<Object> TimKiemTheoTenBacSi(string ten)
        {
            return QuanLyBacSi.TimKiemTenBacSi(ten);
        }
        public IEnumerable<Object> TimKiemTheoChucVu(string ten)
        {
            return QuanLyBacSi.TimKiemTheoChucVu(ten);
        }
        public IEnumerable<Object> TimKiemTheoKhoa(string ten)
        {
            return QuanLyBacSi.TimKiemTheoKhoa(ten);
        }
        public BacSi LayThongTin1BacSi(string ma)
        {
            return QuanLyBacSi.LayThongTin1BacSi(ma);
        }
        public List<string> LoadCBBChucVu()
        {
            return QuanLyBacSi.LoadCBBChucVu();
        }
        public List<string> LoadCBBKhoa()
        {
            return QuanLyBacSi.LoadCBBKhoa();
        }
        public string LayTenKhoa(string maKhoa)
        {
            return QuanLyBacSi.LayTenKhoa(maKhoa);
        }
        public string LayTenChucVu(string maChucVu)
        {
            return QuanLyBacSi.LayTenChucVu(maChucVu);
        }
        public void XoaBacSi(List<string> maList)
        {
            QuanLyBacSi.XoaBacSi(maList);
        }
        public string LayMaChucVu(string TenCV)
        {
            return QuanLyBacSi.LayMaChucVu(TenCV);
        }
        public string LayMaKhoa(string TenCV)
        {
            return QuanLyBacSi.LayMaKhoa(TenCV);
        }
        public void ThemBacSi(BacSi bs)
        {
            QuanLyBacSi.ThemBacSi(bs);
        }
        public IEnumerable<Object>SapXepBacSiTheoTen(List<string> maList, int kieu)
        {
            return QuanLyBacSi.SapXepBacSiTheoTen(maList,kieu);
        }
        public IEnumerable<Object> SapXepBacSiTheoChucVu(List<string> maList, int kieu)
        {
            return QuanLyBacSi.SapXepBacSiTheoChucVu(maList,kieu);
        }
        public IEnumerable<Object> SapXepBacSiTheoKhoa(List<string> maList, int kieu)
        {
            return QuanLyBacSi.SapXepBacSiTheoKhoa(maList,kieu);
        }
        public int LayMaBSLonNhat()
        {
            return QuanLyBacSi.LayMaBSLonNhat();
        }
        public BacSi Lay1BacSi(string maBS)
        {
            return QuanLyBacSi.LayThongTin1BacSi(maBS);
        }
        public void ImportExcelBacSi(DataSet excel)
        {
            QuanLyBacSi.ImportExcelBacSi(excel);
        }
    }
}

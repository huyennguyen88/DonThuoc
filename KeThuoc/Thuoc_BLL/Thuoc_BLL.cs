using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeThuoc.Thuoc_DAL;
namespace KeThuoc.Thuoc_BLL
{
    class Thuoc_BLL
    {
        Thuoc_DAL.Thuoc_DAL QuanLyThuoc = new Thuoc_DAL.Thuoc_DAL();
        public IEnumerable<Object> HienThiThongTin()
        {
            return QuanLyThuoc.HienThiThongTinThuoc();
        }
        public IEnumerable<Object> TimKiemThuocTheoTen(string ten)
        {
            return QuanLyThuoc.TimKiemThuocTheoTen(ten);
        }
        public IEnumerable<Object> TimKiemThuocTheoDang(string ten)
        {
            return QuanLyThuoc.TimKiemThuocTheoDang(ten);
        }
        public IEnumerable<Object> TimKiemThuocTheoLoai(string ten)
        {
            return QuanLyThuoc.TimKiemThuocTheoLoai(ten);
        }
        public IEnumerable<Object> SapXepThuocTheoTen(List<string> maList,int kieu)
        {
            return QuanLyThuoc.SapXepThuocTheoTen(maList, kieu);
        }
        public IEnumerable<Object> SapXepThuocTheoTenLoai(List<string> maList, int kieu)
        {
            return QuanLyThuoc.SapXepThuocTheoTenLoai(maList, kieu);
        }
        public IEnumerable<Object> SapXepThuocTheoTenDang(List<string> maList, int kieu)
        {
            return QuanLyThuoc.SapXepThuocTheoTenDang(maList, kieu);
        }
        public List<string> LoadCBBLoaiThuoc()
        {
            return QuanLyThuoc.LoadCBBLoaiThuoc();
        }
        public string LayMaLoaiThuoc(string tenLoai )
        {
            return QuanLyThuoc.LayMaLoaiThuoc(tenLoai);
        }
        public void XoaThuoc(List<string> maList)
        {
            QuanLyThuoc.XoaThuoc(maList);
        }
        public THUOC LayThongTin1Thuoc(string ma)
        {
            return QuanLyThuoc.LayThongTin1Thuoc(ma);
        }
        public string LayTenLoaiThuoc(string maLoaiThuoc)
        {
            return QuanLyThuoc.LayTenLoaiThuoc(maLoaiThuoc);
        }
        public void ChinhSuaThuoc(THUOC thuoc)
        {
            QuanLyThuoc.ChinhSuaThuoc(thuoc);
        }
        public void ThemThuoc(THUOC thuoc)
        {
            QuanLyThuoc.ThemThuoc(thuoc);
        }
        public int LayMaThuocLonNhat()
        {
            return QuanLyThuoc.LayMaThuocLonNhat();
        }
        public void ImportThuocExcel(DataSet excel)
        {
            QuanLyThuoc.ImportExcelThuoc(excel);
        }
    }
}

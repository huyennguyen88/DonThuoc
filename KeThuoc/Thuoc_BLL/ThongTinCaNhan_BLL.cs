using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeThuoc.Thuoc_DAL;

namespace KeThuoc.Thuoc_BLL
{
    class ThongTinCaNhan_BLL
    {
       Thuoc_DAL.Thuoc_DAL ThongTin = new Thuoc_DAL.Thuoc_DAL();
        public BacSi LayThongTin1BacSi(string ma)
        {
            return ThongTin.LayThongTin1BacSi(ma);
        }
        public List<string> LoadCBBChucVu()
        {
            return ThongTin.LoadCBBChucVu();
        }
        public List<string> LoadCBBKhoa()
        {
            return ThongTin.LoadCBBKhoa();
        }
        public string LayTenKhoa(string maKhoa)
        {
            return ThongTin.LayTenKhoa(maKhoa);
        }
        public string LayTenChucVu(string maChucVu)
        {
            return ThongTin.LayTenChucVu(maChucVu);
        }
        public string LayMaChucVu(string TenCV)
        {
            return ThongTin.LayMaChucVu(TenCV);
        }
        public string LayMaKhoa(string TenCV)
        {
            return ThongTin.LayMaKhoa(TenCV);
        }
        public void ChinhSuaBacSi(BacSi bs)
        {
            ThongTin.ChinhSuaBacSi(bs);
        }
        public void XoaBacSi(List<string> maList)
        {
            ThongTin.XoaBacSi(maList);
        }
    }
}

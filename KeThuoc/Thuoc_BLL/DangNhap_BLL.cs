using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeThuoc.Thuoc_DAL;
namespace KeThuoc.Thuoc_BLL
{
    class DangNhap_BLL
    {
        Thuoc_DAL.Thuoc_DAL dangnhap = new Thuoc_DAL.Thuoc_DAL();
       public  int KiemTra(string ma, string mk) //Kiem tra tai khoan
        {
            return  dangnhap.Kiemtra(ma,mk);
        }
        public string tenBS(string ma) //Tra ve ten tai khoan
        {
            return dangnhap.TenBacSi(ma);
        }
    }
}

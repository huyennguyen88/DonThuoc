using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeThuoc.Thuoc_DAL;
namespace KeThuoc.Thuoc_BLL
{
    class Admin_BLL
    {
        Thuoc_DAL.Thuoc_DAL Admin = new Thuoc_DAL.Thuoc_DAL();
        public string tenBS(string ma)
        {
            return Admin.TenBacSi(ma);
        }
    }
}

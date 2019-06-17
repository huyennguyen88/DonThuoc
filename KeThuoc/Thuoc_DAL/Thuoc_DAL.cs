using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace KeThuoc.Thuoc_DAL
{
    class Thuoc_DAL
    {
        KeThuocDB thuoc_dal = new KeThuocDB();
        #region TaiKhoan
        public int Kiemtra(string ma, string mk)
        {
                var query = thuoc_dal.BacSi.Where(p => p.MaBacSi == ma && p.MatKhau == mk);
                if (query.Count() > 0)
                {
                    int kiemtra = query.Select(f => f.PhanQuyen).SingleOrDefault();
                    return kiemtra;
                }
                else return 0;
        }
        public string TenBacSi(string ma)
        {
                var query = thuoc_dal.BacSi.Where(p => p.MaBacSi == ma).SingleOrDefault();
                string tenBS = query.TenBacSi;
                return tenBS;
        }
        #endregion
        #region ThongTinBacSi
        public BacSi LayThongTin1BacSi(string ma)
        {
                var query = thuoc_dal.BacSi.Where(p => p.MaBacSi == ma).SingleOrDefault();
                return query; // tra ve 1 bac si
        }
        public List<string> LoadCBBChucVu()
        {
            // var query = thuoc_dal.ChucVu.Select(p => p.TenChucVu);
            var query = from p in thuoc_dal.ChucVu
                        select p.TenChucVu;
             return query.ToList();
        }
        public List<string> LoadCBBKhoa()
        {
                var query = thuoc_dal.Khoa.Select(p => p.TenKhoa);
                return query.ToList();
        }
       public string LayTenKhoa(string maKhoa)
        {
            var query =(from p in thuoc_dal.Khoa where p.MaKhoa == maKhoa select p.TenKhoa).SingleOrDefault();
            return query.ToString();
        }
        public string LayTenChucVu(string maChucVu)
        {
            var query = (from p in thuoc_dal.ChucVu where p.MaChucVu == maChucVu select p.TenChucVu ).SingleOrDefault();
            return query.ToString();
        }
        public void ChinhSuaBacSi(BacSi bs)
        {
            var query = (from p in thuoc_dal.BacSi
                         where p.MaBacSi == bs.MaBacSi
                         select p).SingleOrDefault();
            query.TenBacSi = bs.TenBacSi;
            query.MatKhau = bs.MatKhau;
            query.MaChucVu = bs.MaChucVu;
            query.GioiTinh = bs.GioiTinh;
            query.MaKhoa = bs.MaKhoa;
            query.NgayBatDauLam = bs.NgayBatDauLam;
            query.NgaySinh = bs.NgaySinh;
            query.DiaChi = bs.DiaChi;
            query.Sdt = bs.Sdt;
            query.PhanQuyen = bs.PhanQuyen;
            query.Email = bs.Email;
            try
            {
                thuoc_dal.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Loi khong sua duoc");
            }
        }
        public void XoaBacSi(List<string> maList)
        {

            foreach (string ma in maList)
            {
                var query = thuoc_dal.BacSi.Where(p => p.MaBacSi.Equals(ma)).SingleOrDefault();

                thuoc_dal.BacSi.Remove(query);
                thuoc_dal.SaveChanges();
            }
        }
        #endregion
        #region QuanLyBacSi
        public IEnumerable<Object> HienThiThongTinBacSi()
        {
            var query = from p in thuoc_dal.BacSi
                        select new
                        {
                            p.MaBacSi,
                            p.TenBacSi,
                            p.MatKhau,
                            p.Khoa.TenKhoa,
                            p.ChucVu.TenChucVu,
                            p.GioiTinh,
                            p.DiaChi,
                            p.Sdt,
                            p.Email,
                            p.NgaySinh,
                            p.NgayBatDauLam,
                        };           
            return query.ToList();
        }
        public int LayMaBSLonNhat()
        {
            var query = (from p in thuoc_dal.BacSi select p.MaBacSi);
            List<int> maBS = new List<int>();
            foreach (string i in query)
            {
                maBS.Add(Convert.ToInt32(i.Substring(2)));

            }
            return maBS.Max();
        }
        public string LayMaChucVu(string TenCV)
        {
            var query = (from p in thuoc_dal.ChucVu
                         where p.TenChucVu == TenCV
                         select p.MaChucVu);
            if(query.Count()== 1)
            return query.SingleOrDefault().ToString();
            return "";
        }
        public string LayMaKhoa(string TenKhoa)
        {
            var query = (from p in thuoc_dal.Khoa
                         where p.TenKhoa == TenKhoa
                         select p.MaKhoa);
            if (query.Count() == 1)
                return query.SingleOrDefault().ToString();
            return "";
        }
        public void ThemBacSi(BacSi bacsi)
        {
            var query = thuoc_dal.BacSi.Where(p => p.MaBacSi == bacsi. MaBacSi).Count();
            if (query == 0)
            {
                thuoc_dal.BacSi.Add(bacsi);
                thuoc_dal.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi! Trùng mã số hoặc nhập thiếu thông tin,...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public IEnumerable<Object> TimKiemTenBacSi(string ten)
        {
            var query = from p in thuoc_dal.BacSi where p.TenBacSi.Contains(ten)
                        select new
                        {
                            p.MaBacSi,
                            p.TenBacSi,
                            p.MatKhau,
                            p.Khoa.TenKhoa,
                            p.ChucVu.TenChucVu,
                            p.GioiTinh,
                            p.DiaChi,
                            p.Sdt,
                            p.Email,
                            p.NgaySinh,
                            p.NgayBatDauLam,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> TimKiemTheoChucVu(string ten)
        {
            var query = from p in thuoc_dal.BacSi
                        where p.ChucVu.TenChucVu.Contains(ten)
                        select new
                        {
                            p.MaBacSi,
                            p.TenBacSi,
                            p.MatKhau,
                            p.Khoa.TenKhoa,
                            p.ChucVu.TenChucVu,
                            p.GioiTinh,
                            p.DiaChi,
                            p.Sdt,
                            p.Email,
                            p.NgaySinh,
                            p.NgayBatDauLam,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> TimKiemTheoKhoa(string ten)
        {
           
            var query = from p in thuoc_dal.BacSi
                        where p.Khoa.TenKhoa.Contains(ten)
                        select new
                        {
                            p.MaBacSi,
                            p.TenBacSi,
                            p.MatKhau,
                            p.Khoa.TenKhoa,
                            p.ChucVu.TenChucVu,
                            p.GioiTinh,
                            p.DiaChi,
                            p.Sdt,
                            p.Email,
                            p.NgaySinh,
                            p.NgayBatDauLam,
                        };
        
            return query.ToList();
        }
        public IEnumerable<Object> SapXepBacSiTheoTen(List<string> maList, int kieu)
        {
            List<BacSi> ListBS = LayDanhSachBacSiDGV(maList);
            List<BacSi> ListBacSiOrder;
            if(kieu == 0) ListBacSiOrder = ListBS.OrderBy(p => p.TenBacSi).ToList();
            else  ListBacSiOrder = ListBS.OrderByDescending(p => p.TenBacSi).ToList();
            return GetListBacSiVoDanh(ListBacSiOrder);
        }
        public IEnumerable<Object> SapXepBacSiTheoChucVu(List<string> maList,int kieu)
        {
            List<BacSi> ListBS = LayDanhSachBacSiDGV(maList);
            List<BacSi> ListBacSiOrder;
            if(kieu == 0) ListBacSiOrder = ListBS.OrderBy(p => p.ChucVu.TenChucVu).ToList();
            else ListBacSiOrder = ListBS.OrderByDescending(p => p.ChucVu.TenChucVu).ToList();
            return GetListBacSiVoDanh(ListBacSiOrder);
        }
        public IEnumerable<Object> SapXepBacSiTheoKhoa(List<string> maList, int kieu)
        {
            List<BacSi> ListBS = LayDanhSachBacSiDGV(maList);
            List<BacSi> ListBacSiOrder;
            if (kieu == 0) ListBacSiOrder = ListBS.OrderBy(p => p.Khoa.TenKhoa).ToList();
            else ListBacSiOrder = ListBS.OrderByDescending(p => p.Khoa.TenKhoa).ToList();
            return GetListBacSiVoDanh(ListBacSiOrder);
        }     
        public IEnumerable<Object> GetListBacSiVoDanh(List<BacSi> ListBS)
        {
            var query1 = from p in ListBS
                         select new
                         {
                             p.MaBacSi,
                             p.TenBacSi,
                             p.MatKhau,
                             p.Khoa.TenKhoa,
                             p.ChucVu.TenChucVu,
                             p.GioiTinh,
                             p.DiaChi,
                             p.Sdt,
                             p.Email,
                             p.NgaySinh,
                             p.NgayBatDauLam,
                         };
            return query1.ToList();
        }
        public List<BacSi> LayDanhSachBacSiDGV(List<string> maList)
        {
            List<BacSi> temp = new List<BacSi>();
            foreach (string i in maList)
            {
                var query = (from p in thuoc_dal.BacSi
                             where p.MaBacSi == i
                             select p).SingleOrDefault();
                temp.Add(query);
            }
            return temp;
        }
        #endregion
        #region QuanLyThuoc
        public IEnumerable<Object> HienThiThongTinThuoc()
        {
            var query = from p in thuoc_dal.THUOC
                        select new
                        {
                            p.MaThuoc,
                            p.TenThuoc,
                            p.DangThuoc,
                            p.CongDung,
                            p.TacDungPhu,
                            p.LoaiThuoc.TenLoai,
                            p.SoLuong,
                        };  
            return query.ToList();
        }
        public List<string> LoadCBBLoaiThuoc()
        {
            var query = thuoc_dal.LoaiThuoc.Select(p => p.TenLoai );
            return query.ToList();
        }
        public string LayMaLoaiThuoc(string tenLoai)
        {
            var query = (from p in thuoc_dal.LoaiThuoc
                         where p.TenLoai == tenLoai
                         select p.MaLoai);
            if(query.Count() ==1)
            return query.SingleOrDefault().ToString();
            return "";
        }
        public void XoaThuoc(List<string> maList)
        {
            foreach (string ma in maList)
            {
                var query = thuoc_dal.THUOC.Where(p => p.MaThuoc.Equals(ma)).SingleOrDefault();

                thuoc_dal.THUOC.Remove(query);
                thuoc_dal.SaveChanges();
            }
        }
        public THUOC LayThongTin1Thuoc(string ma)
        {
            var query = thuoc_dal.THUOC.Where(p => p.MaThuoc == ma).SingleOrDefault();
            return query; // tra ve 1 bac si
        }
        public string LayTenLoaiThuoc(string maLoaiThuoc)
        {
            var query = thuoc_dal.LoaiThuoc.Where(p => p.MaLoai == maLoaiThuoc).Select(p => p.TenLoai).SingleOrDefault();
            return query.ToString();
        }
        public void ChinhSuaThuoc (THUOC thuoc)
        {
            var query = (from p in thuoc_dal.THUOC
                         where p.MaThuoc == thuoc.MaThuoc
                         select p).SingleOrDefault();
            query.MaThuoc = thuoc.MaThuoc;
            query.TenThuoc =thuoc.TenThuoc;
            query.CongDung = thuoc.CongDung;
            query.TacDungPhu = thuoc.TacDungPhu;
            query.DangThuoc = thuoc.DangThuoc;
            query.MaLoai = thuoc.MaLoai;
            query.SoLuong = thuoc.SoLuong;
            try
            {
                thuoc_dal.SaveChanges();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public IEnumerable<Object> TimKiemThuocTheoTen(string ten)
        {
            var query = from p in thuoc_dal.THUOC
                        where p.TenThuoc.Contains(ten)
                        select new
                        {
                            p.MaThuoc,
                            p.TenThuoc,
                            p.DangThuoc,
                            p.CongDung,
                            p.TacDungPhu,
                            p.LoaiThuoc.TenLoai,
                            p.SoLuong,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> TimKiemThuocTheoDang(string ten)
        {
            var query = from p in thuoc_dal.THUOC
                        where p.DangThuoc.Contains(ten)
                        select new
                        {
                            p.MaThuoc,
                            p.TenThuoc,
                            p.DangThuoc,
                            p.CongDung,
                            p.TacDungPhu,
                            p.LoaiThuoc.TenLoai,
                            p.SoLuong,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> TimKiemThuocTheoLoai(string ten)
        {
            var query = from p in thuoc_dal.THUOC
                        where p.LoaiThuoc.TenLoai.Contains(ten)
                        select new
                        {
                            p.MaThuoc,
                            p.TenThuoc,
                            p.DangThuoc,
                            p.CongDung,
                            p.TacDungPhu,
                            p.LoaiThuoc.TenLoai,
                            p.SoLuong,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> SapXepThuocTheoTen(List<string> maList, int kieu)
        {
            List<THUOC> ListTHUOC = LayDanhSachThuocDGV(maList);
            List<THUOC> ListThuocOrder;
            if (kieu == 0) ListThuocOrder = ListTHUOC.OrderBy(p => p.TenThuoc).ToList();
            else ListThuocOrder = ListTHUOC.OrderByDescending(p => p.TenThuoc).ToList();
            return GetListThuocVoDanh(ListThuocOrder);
        }
        public IEnumerable<Object> SapXepThuocTheoTenLoai(List<string> maList, int kieu)
        {
            List<THUOC> ListTHUOC = LayDanhSachThuocDGV(maList);
            List<THUOC> ListThuocOrder;
            if (kieu == 0) ListThuocOrder = ListTHUOC.OrderBy(p => p.LoaiThuoc.TenLoai).ToList();
            else ListThuocOrder = ListTHUOC.OrderByDescending(p => p.LoaiThuoc.TenLoai).ToList();
            return GetListThuocVoDanh(ListThuocOrder);
        }
        public IEnumerable<Object> SapXepThuocTheoTenDang(List<string> maList, int kieu)
        {
            List<THUOC> ListTHUOC = LayDanhSachThuocDGV(maList);
            List<THUOC> ListThuocOrder;
            if (kieu == 0) ListThuocOrder = ListTHUOC.OrderBy(p => p.DangThuoc).ToList();
            else ListThuocOrder = ListTHUOC.OrderByDescending(p => p.DangThuoc).ToList();
            return GetListThuocVoDanh(ListThuocOrder);
        }
        public IEnumerable<Object> GetListThuocVoDanh(List<THUOC> ListTHUOC)
        {
            var query1 = from p in ListTHUOC
                         select new
                         {
                             p.MaThuoc,
                             p.TenThuoc,
                             p.DangThuoc,
                             p.CongDung,
                             p.TacDungPhu,
                             p.LoaiThuoc.TenLoai,
                             p.SoLuong,
                         };
            return query1.ToList();
        }
        public List<THUOC> LayDanhSachThuocDGV(List<string> maList)
        {
            List<THUOC> temp = new List<THUOC>();
            foreach (string i in maList)
            {
                var query = (from p in thuoc_dal.THUOC
                             where p.MaThuoc == i
                             select p).SingleOrDefault();
                temp.Add(query);
            }
            return temp;
        }
        public void ThemThuoc(THUOC thuoc)
        {
            var query = thuoc_dal.THUOC.Where(p => p.MaThuoc ==thuoc.MaThuoc).Count();
            if (query == 0)
            {
                thuoc_dal.THUOC.Add(thuoc);
                thuoc_dal.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lỗi! Trùng mã số hoặc nhập thiếu thông tin,...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int LayMaThuocLonNhat()
        {
            var query = (from p in thuoc_dal.THUOC select p.MaThuoc);
            List<int> maThuoc = new List<int>();
            foreach (string i in query)
            {
                maThuoc.Add(Convert.ToInt32(i.Substring(2)));

            }
            return maThuoc.Max();
        }
        #endregion
        #region QuanLyBenhNhan
        public IEnumerable<Object>HienThiThongTinBenhNhan()
        {
            var query = from p in thuoc_dal.BenhNhan
                        select new
                        {
                            p.MaBenhNhan,
                            p.TenBenhNhan,
                            p.NgaySinh,
                            p.DiaChi,
                            p.SDT,
                            p.GioiTinh,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> TimKiemBenhNhanTheoTen(string ten)
        {
            var query = from p in thuoc_dal.BenhNhan where p.TenBenhNhan.Contains(ten)
                        select new
                        {
                            p.MaBenhNhan,
                            p.TenBenhNhan,
                            p.NgaySinh,
                            p.DiaChi,
                            p.SDT,
                            p.GioiTinh,
                        };
            return query.ToList();
        }
        public BenhNhan LayThongTin1BenhNhan(string ma)
        {
            var query = thuoc_dal.BenhNhan.Where(p => p.MaBenhNhan == ma).SingleOrDefault();
            return query;
        }
        public void XoaBenhNhan(List<string> maList)
        {
            foreach (string ma in maList)
            {
                var query = thuoc_dal.BenhNhan.Where(p => p.MaBenhNhan.Equals(ma)).SingleOrDefault();

                thuoc_dal.BenhNhan.Remove(query);
                thuoc_dal.SaveChanges();
            }
        }
        public void ChinhSuaBenhNhan(BenhNhan benhnhan)
        {
            var query = thuoc_dal.BenhNhan.Where(p => p.MaBenhNhan == benhnhan.MaBenhNhan).SingleOrDefault();
            query.TenBenhNhan = benhnhan.TenBenhNhan;
            query.NgaySinh = benhnhan.NgaySinh;
            query.DiaChi = benhnhan.DiaChi;
            query.SDT = benhnhan.SDT;
            query.GioiTinh = benhnhan.GioiTinh;

            try
            {
                thuoc_dal.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Loi khong sua duoc");
            }
        }
        public void ThemBenhNhan(BenhNhan benhnhan)
        {
            var query = thuoc_dal.BenhNhan.Where(p => p.MaBenhNhan == benhnhan.MaBenhNhan).Count();
            if(query == 0)
            {
                thuoc_dal.BenhNhan.Add(benhnhan);
                thuoc_dal.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lỗi! Trùng mã số hoặc nhập thiếu thông tin,...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public IEnumerable<Object> SapXepBenhNhanTheoTen(List<string> maList, int kieu)
        {
            List<BenhNhan> ListBN = LayDanhSachBenhNhanDGV(maList);
            List<BenhNhan> ListBenhNhanOrder;
            if (kieu == 0) ListBenhNhanOrder = ListBN.OrderBy(p => p.TenBenhNhan).ToList();
            else ListBenhNhanOrder = ListBN.OrderByDescending(p => p.TenBenhNhan).ToList();
            return GetListBenhNhanVoDanh(ListBenhNhanOrder);
        }
        public IEnumerable<Object> SapXepBenhNhanhTheoSDT(List<string> maList, int kieu)
        {
            List<BenhNhan> ListBN = LayDanhSachBenhNhanDGV(maList);
            List<BenhNhan> ListBenhNhanOrder;
            if (kieu == 0) ListBenhNhanOrder = ListBN.OrderBy(p => p.SDT).ToList();
            else ListBenhNhanOrder = ListBN.OrderByDescending(p => p.SDT).ToList();
            return GetListBenhNhanVoDanh(ListBenhNhanOrder);
        }
        public IEnumerable<Object> GetListBenhNhanVoDanh(List<BenhNhan> ListBN)
        {
            var query1 = from p in ListBN
                         select new
                         {
                             p.MaBenhNhan,
                             p.TenBenhNhan,
                             p.NgaySinh,
                             p.DiaChi,
                             p.SDT,
                             p.GioiTinh,
                         };
            return query1.ToList();
        }
        public List<BenhNhan> LayDanhSachBenhNhanDGV(List<string> maList)
        {
            List<BenhNhan> temp = new List<BenhNhan>();
            foreach (string i in maList)
            {
                var query = (from p in thuoc_dal.BenhNhan
                             where p.MaBenhNhan == i
                             select p).SingleOrDefault();
                temp.Add(query);
            }
            return temp;
        }
        public int LayMaBNLonNhat()
        {
            var query = (from p in thuoc_dal.BenhNhan select p.MaBenhNhan);
            List<int> maBN = new List<int>();
            foreach (string i in query)
            {
                maBN.Add(Convert.ToInt32(i.Substring(2)));

            }
            return maBN.Max();
        }
        #endregion
        #region DonThuoc
        public IEnumerable<Object> HienThiDonThuocAdmin()
        {
            var query = from p in thuoc_dal.DonThuoc
                        orderby p.NgayLamDon ascending
                        select new
                        {
                            p.MaDon,
                            p.BacSi.TenBacSi,
                            p.BenhNhan.TenBenhNhan,
                            p.BenhLi,
                            p.BaoHiem,
                            p.NgayLamDon,
                            p.NgayTaiKham,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> HienThiDonThuocBacSi(string maBS)
        {
            var query = from p in thuoc_dal.DonThuoc where p.MaBacSi == maBS
                        orderby p.NgayLamDon ascending
                        select new
                        {
                            p.MaDon,
                            p.BacSi.TenBacSi,
                            p.BenhNhan.TenBenhNhan,
                            p.BenhLi,
                            p.BaoHiem,
                            p.NgayLamDon,
                            p.NgayTaiKham,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> HienThiDonThuocBenhNhan(string maBN)
        {
            var query = from p in thuoc_dal.DonThuoc
                        where p.MaBenhNhan == maBN
                        select new
                        {
                            p.MaDon,
                            p.BacSi.TenBacSi,
                            p.BenhNhan.TenBenhNhan,
                            p.BenhLi,
                            p.BaoHiem,
                            p.NgayLamDon,
                            p.NgayTaiKham,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> HienThiDonThuocBenhNhanTheoNgay(DateTime date,string maBN)
        {
            var query = from p in thuoc_dal.DonThuoc
                        where p.NgayLamDon == date && p.MaBenhNhan == maBN
                        orderby p.NgayLamDon ascending
                        select new
                        {
                            p.MaDon,
                            p.BacSi.TenBacSi,
                            p.BenhNhan.TenBenhNhan,
                            p.BenhLi,
                            p.BaoHiem,
                            p.NgayLamDon,
                            p.NgayTaiKham,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> HienThiDonThuocBenhNhanFromTo( DateTime dateFrom, DateTime dateTo, string maBN)
        {
            var query = from p in thuoc_dal.DonThuoc
                        where p.NgayLamDon >= dateFrom && p.NgayLamDon <= dateTo && p.MaBenhNhan==maBN
                        orderby p.NgayLamDon ascending
                        select new
                        {
                            p.MaDon,
                            p.BacSi.TenBacSi,
                            p.BenhNhan.TenBenhNhan,
                            p.BenhLi,
                            p.BaoHiem,
                            p.NgayLamDon,
                            p.NgayTaiKham,
                        };
            return query.ToList();
        }
        public int LayMaDTLonNhat()
        {
            var query = (from p in thuoc_dal.DonThuoc select p.MaDon);
            List<int> maDT = new List<int>();
            foreach (string i in query)
            {
                maDT.Add(Convert.ToInt32(i.Substring(2)));

            }
            return maDT.Max();
        }
        public void ThemDonVaThuoc(DonVaThuoc DvT)
        {
            var query = thuoc_dal.DonVaThuoc.Where(p => p.MaDon == DvT.MaDon && p.MaThuoc == DvT.MaThuoc ).Count();
            if (query == 0)
            {
             
                    thuoc_dal.DonVaThuoc.Add(DvT);
                    thuoc_dal.SaveChanges();
                    MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi! Trùng mã số hoặc đã thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ThemDonThuoc(DonThuoc DT)
        {
            var query = thuoc_dal.DonThuoc.Where(p => p.MaDon == DT.MaDon).Count();
            if (query == 0)
            {
                thuoc_dal.DonThuoc.Add(DT);
                thuoc_dal.SaveChanges();
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi! Trùng mã số hoặc đã thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public IEnumerable<Object> HienThiDanhSachThuocDaChon(string maDT)
        {
            var query = from p in thuoc_dal.DonVaThuoc
                        where p.MaDon == maDT
                        select new
                        {
                            p.MaThuoc,
                            p.THUOC.TenThuoc,
                            p.SoLuong,
                            p.DonViTinh,
                            p.CachDung,
                        };
            return query.ToList();
        }
        public int TongSoDonThuocAdmin()
        {
            var query = (from p in thuoc_dal.DonThuoc select p.MaDon).Count();
            return query;
        }
        public int TongSoDonThuocBacSi(string maBS)
        {
            var query = (thuoc_dal.DonThuoc.Where(p=>p.MaBacSi == maBS)).Count();
            return query;
        }
        public string LayMaBenhNhanTuMaDon(string maDon)
        {
            var query = (from p in thuoc_dal.DonThuoc
                         where p.MaDon == maDon
                         select p.MaBenhNhan).SingleOrDefault().ToString();
            return query;
        }
        public string LayMaBacSiTuMaDon(string maDon)
        {
            var query = (from p in thuoc_dal.DonThuoc
                         where p.MaDon == maDon
                         select p.MaBacSi).SingleOrDefault().ToString();
            return query;
        }
        public DonThuoc LayThongTin1DonThuoc(string maDon)
        {

            var query = thuoc_dal.DonThuoc.Where(p => p.MaDon == maDon).SingleOrDefault();
            return query;
        }
        public IEnumerable<Object> KiemTraNgayLamViecCaNhan(DateTime date, string maBS)
        {
            var query = from p in thuoc_dal.DonThuoc
                        where p.NgayLamDon == date && p.MaBacSi == maBS
                        orderby p.NgayLamDon ascending
                        select new
                        {
                            p.MaDon,
                            p.BacSi.TenBacSi,
                            p.BenhNhan.TenBenhNhan,
                            p.BenhLi,
                            p.BaoHiem,
                            p.NgayLamDon,
                            p.NgayTaiKham,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> KiemTraNgayLamViecCaNhanFromTo(DateTime dateFrom,DateTime dateTo, string maBS)
        {
            var query = from p in thuoc_dal.DonThuoc
                        where p.NgayLamDon >= dateFrom && p.NgayLamDon <= dateTo && p.MaBacSi == maBS
                        orderby p.NgayLamDon ascending
                        select new
                        {
                            p.MaDon,
                            p.BacSi.TenBacSi,
                            p.BenhNhan.TenBenhNhan,
                            p.BenhLi,
                            p.BaoHiem,
                            p.NgayLamDon,
                            p.NgayTaiKham,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> KiemTraNgayLamViecThongKeFromTo(DateTime dateFrom, DateTime dateTo)
        {
            var query = from p in thuoc_dal.DonThuoc
                        where p.NgayLamDon <= dateTo && p.NgayLamDon >= dateFrom
                        orderby p.NgayLamDon
                        select new
                        {
                            p.MaDon,
                            p.BacSi.TenBacSi,
                            p.BenhNhan.TenBenhNhan,
                            p.BenhLi,
                            p.BaoHiem,
                            p.NgayLamDon,
                            p.NgayTaiKham,
                        };
            return query.ToList();
        }
        public IEnumerable<Object> KiemTraNgayLamViecThongKe(DateTime date)
        {
            var query = from p in thuoc_dal.DonThuoc
                        where p.NgayLamDon == date
                        select new
                        {
                            p.MaDon,
                            p.BacSi.TenBacSi,
                            p.BenhNhan.TenBenhNhan,
                            p.BenhLi,
                            p.BaoHiem,
                            p.NgayLamDon,
                            p.NgayTaiKham,
                        };
            return query.ToList();
        }
        #endregion
        #region Excel
        public  void ImportExcelBenhNhan(DataSet excel)
        {
            try
            {
                string thanhcong = "";
                int maBN = LayMaBNLonNhat();
                DataTable Sheet1 = excel.Tables[0];
                int i = 0; 
                foreach (DataRow r in Sheet1.Rows)
                {
                    if (i < 2) i++;
                    else
                    {
                        BenhNhan bn = new BenhNhan
                        {
                            MaBenhNhan = "BN" + ++maBN,
                            TenBenhNhan = r[0].ToString(),
                            NgaySinh = Convert.ToDateTime(r[1]),
                            DiaChi = r[2].ToString(),
                            SDT = r[3].ToString(),
                            GioiTinh = Convert.ToBoolean(r[4]),
                        };
                        thanhcong += "BN" + maBN + "\n";
                        thuoc_dal.BenhNhan.Add(bn);
                    }
                }
                thuoc_dal.SaveChanges();
                MessageBox.Show(thanhcong + " Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void ImportExcelBacSi(DataSet excel)
        {
            try
            {
                string thatbai = "";
                string thanhcong = "";
                int maBS = LayMaBSLonNhat();
                DataTable Sheet1 = excel.Tables[0];
                int i = 0;
                foreach (DataRow r in Sheet1.Rows)
                {
                    if(i <2) i++;
                    else
                    {
                        var queryMaKhoa = LayMaKhoa(r[2].ToString());
                        var queryMaChucVu = LayMaChucVu(r[3].ToString());
                        if (queryMaKhoa == "" || queryMaChucVu == "")
                        {
                            thatbai += ("Tên: " + r[0].ToString() + ", SĐT " + r[6].ToString() + "\n");
                        }
                        else
                        {
                            BacSi bs = new BacSi
                            {
                                MaBacSi = "BS" + ++maBS,
                                TenBacSi = r[0].ToString(),
                                MatKhau = r[1].ToString(),
                                MaKhoa = queryMaKhoa,
                                MaChucVu = queryMaChucVu,
                                GioiTinh = Convert.ToBoolean(r[4]),
                                DiaChi = r[5].ToString(),
                                Sdt = r[6].ToString(),
                                Email = r[7].ToString(),
                                NgaySinh = Convert.ToDateTime(r[8]),
                                NgayBatDauLam = Convert.ToDateTime(r[9]),
                                PhanQuyen = 2,
                            };
                            thanhcong += "BS" + maBS + "\n";
                            thuoc_dal.BacSi.Add(bs);
                        }
                        thuoc_dal.SaveChanges();
                    }
                    
                }
                if(thanhcong != "")MessageBox.Show(thanhcong + "Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(thatbai != "") MessageBox.Show(thatbai + "Không tồn tại khoa hoặc chức vụ, không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void ImportExcelThuoc(DataSet excel)
        {
            try
            {
                string thatbai = "";
                string thanhcong = "";
                int maThuoc = LayMaThuocLonNhat();
                DataTable Sheet1 = excel.Tables[0];
                int i = 0;
                foreach (DataRow r in Sheet1.Rows)
                {
                    if (i < 2) i++;
                    else
                    {
                        var queryLoaiThuoc = LayMaLoaiThuoc(r[4].ToString());
                        if (queryLoaiThuoc == "")
                        {
                            thatbai += ("Thuốc: " + r[0].ToString() + "\n");
                        }
                        else
                        {
                            THUOC thuoc = new THUOC
                            {
                                MaThuoc = "TH" + ++maThuoc,
                                TenThuoc = r[0].ToString(),
                                DangThuoc = r[1].ToString(),
                                CongDung = r[2].ToString(),
                                TacDungPhu = r[3].ToString(),
                                MaLoai = queryLoaiThuoc,
                                SoLuong = r[5].ToString(),
                            };
                            thanhcong += "TH" + maThuoc + "\n";
                            thuoc_dal.THUOC.Add(thuoc);
                        }
                        thuoc_dal.SaveChanges();
                    }
                }
                if(thanhcong !="")MessageBox.Show(thanhcong + "Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (thatbai !="") MessageBox.Show(thatbai + "Không tồn tại loại thuốc, không thêm được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion
    }
}

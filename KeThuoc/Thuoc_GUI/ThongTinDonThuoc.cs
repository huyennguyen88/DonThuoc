using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeThuoc.Thuoc_BLL;
using KeThuoc.Thuoc_DAL;
using KeThuoc.Thuoc_GUI;
namespace KeThuoc
{
    public partial class ThongTinDonThuoc : Form
    {
        string maBN;
        string maBS;
        string maDon;
        DonThuoc_BLL DonVaThuoc = new DonThuoc_BLL();
        QuanLyBacSi_BLL QuanLyBacSi = new QuanLyBacSi_BLL();
        BenhNhan_BLL QuanLyBenhNhan = new BenhNhan_BLL();
        public ThongTinDonThuoc(string maDon, string maBS, string maBN)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.maDon = maDon;
            this.maBS = maBS;
            this.maBN = maBN;
        }
        #region Methods
        void LoadControlView()
        {
            //Load Cbb khoa
            cbbKhoa.Items.AddRange(QuanLyBacSi.LoadCBBKhoa().ToArray());
            //DonThuoc
            txtMaDon.Text = maDon;
            dtpNgayLamDon.Value = DonVaThuoc.LayThongTin1DonThuoc(maDon).NgayLamDon;
            //BacSi
            BacSi bs = QuanLyBacSi.LayThongTin1BacSi(maBS);
            txtMaBacSi.Text = maBS;
            txtTenBacSi.Text = bs.TenBacSi;
            txtSDTBS.Text = bs.Sdt;
            cbbKhoa.SelectedIndex = cbbKhoa.FindStringExact(bs.Khoa.TenKhoa);
            //BenhNhan
            BenhNhan bn = QuanLyBenhNhan.LayThongTin1BenhNhan(maBN);
            txtMaBenhNhan.Text = maBN;
            txtTenBenhNhan.Text = bn.TenBenhNhan;
            txtSDTBN.Text = bn.SDT;
            bool gender = bn.GioiTinh;
            if (gender == true) rdbNam.Checked = true; else rdbNu.Checked = true;
        }
        void LoadDSThuoc()
        {
            dgvDSThuoc.DataSource = DonVaThuoc.HienThiDanhSachThuocDaChon(maDon);
        }        
        private void ThongTinDonThuoc_Load(object sender, EventArgs e)
        {
            LoadControlView();
            LoadDSThuoc();
        }
        private void btnTT_BacSi_Click(object sender, EventArgs e)
        {
            int quyen = 2;
            if (maBS == "BS1") quyen = 1;
            new ThongTin_CaNhan(maBS, quyen).ShowDialog();
        }

        private void btn_TTBenhNhan_Click(object sender, EventArgs e)
        {
            int quyen = 2;
            if (maBS == "BS1") quyen = 1;
            new ThongTin_BenhNhan(maBN, maBS, quyen).ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\ThongTinDonThuoc.txt");
        }
    }
}

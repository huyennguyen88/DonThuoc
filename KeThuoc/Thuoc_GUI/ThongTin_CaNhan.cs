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

namespace KeThuoc
{
    public partial class ThongTin_CaNhan : Form
    {
        string maBS;
        int quyen;
        ThongTinCaNhan_BLL ThongTin = new ThongTinCaNhan_BLL();
        DonThuoc_BLL DonThuoc = new DonThuoc_BLL();
        public ThongTin_CaNhan(string maBS, int quyen)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.maBS = maBS;
            this.quyen = quyen;
        }
        #region Methods
        void LoadCBBChucVu()
        {
            cbbChucVu.Items.AddRange(ThongTin.LoadCBBChucVu().ToArray());
        }
        void LoadCBBKhoa()
        {
            cbbKhoa.Items.AddRange(ThongTin.LoadCBBKhoa().ToArray());
        }
        public void HienThiChiTiet()
        {
            //796, 498;
            BacSi bacsi = ThongTin.LayThongTin1BacSi(maBS);
            txtMaBacSi.Text = bacsi.MaBacSi;
            txtMatKhau.Text = bacsi.MatKhau;
            txtTenBacSi.Text = bacsi.TenBacSi;
            lbTen.Text = bacsi.TenBacSi;
            string khoa = ThongTin.LayTenKhoa(bacsi.MaKhoa);
            string chucvu = ThongTin.LayTenChucVu(bacsi.MaChucVu); 
            cbbKhoa.SelectedIndex = cbbKhoa.FindStringExact(khoa);
            cbbChucVu.SelectedIndex = cbbChucVu.FindStringExact(chucvu);
            dtpNgayDiLam.Value = bacsi.NgayBatDauLam;
            txtDiaChi.Text = bacsi.DiaChi;
            txtSDT.Text = bacsi.Sdt;
            txtEmail.Text = bacsi.Email;
            dtpNgaySinh.Value = bacsi.NgaySinh;
            bool gender = bacsi.GioiTinh;
            if (gender == true) rdbNam.Checked = true; else rdbNu.Checked = true;
        }
        public int ChinhSuaBacSi()
        {
            if (quyen != 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa thông tin", "Ngăn chặn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
            if (maBS == "BS1" && cbbChucVu.SelectedIndex != 0)
            {
                MessageBox.Show("Bạn không được đổi chức vụ ", "Ngăn chặn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
            if (maBS != "BS1" && cbbChucVu.SelectedIndex == 0)
            {
                MessageBox.Show("Không thể đặt chức vụ này", "Ngăn chặn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
            string maKhoa, maChucVu;
            maChucVu = ThongTin.LayMaChucVu(cbbChucVu.SelectedItem.ToString());
            maKhoa = ThongTin.LayMaKhoa(cbbKhoa.SelectedItem.ToString());
            int phanQ;
            if (maBS == "BS1") phanQ = 1;
            else phanQ = 2;
            BacSi bs = new BacSi
            {
                MaBacSi = txtMaBacSi.Text,
                TenBacSi = txtTenBacSi.Text,
                MatKhau = txtMatKhau.Text,
                MaChucVu = maChucVu,
                MaKhoa = maKhoa,
                GioiTinh = rdbNam.Checked,
                DiaChi = txtDiaChi.Text,
                Sdt = txtSDT.Text,
                Email = gbBS.Text,
                NgaySinh = dtpNgaySinh.Value,
                NgayBatDauLam = dtpNgayDiLam.Value,
                PhanQuyen = phanQ,
            };
            ThongTin.ChinhSuaBacSi(bs);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }
        public int XoaBacSi()
        {
            if (quyen != 1)
            {
                MessageBox.Show("Bạn không có quyền xoá tài khoản", "Ngăn chặn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
            if (maBS == "BS1")
            {
                MessageBox.Show("Không thể xoá Admin", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
            DialogResult kq = MessageBox.Show("Xoá bác sĩ sẽ xoá mọi đơn thuốc liên quan đến bác sĩ," +
                " bạn có muốn xoá không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No)
            {
                return 0;
            }
            List<string> maList = new List<string>();
            maList.Add(maBS);
            ThongTin.XoaBacSi(maList);
            MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }
        void HienThiLichSuKhamBenh()
        {
            dgvLichSu.DataSource = DonThuoc.HienThiDonThuocBacSi(maBS);
            lbSoDon.Text = DonThuoc.HienThiDonThuocBacSi(maBS).Count().ToString();
        }
        void LuaChon()
        {
            if (cbbLuaChon.SelectedIndex == -1 || cbbLuaChon.SelectedIndex == 0)
            {
                //Tu ngay den ngay
                lbTu.Visible = false;
                lbDen.Visible = false;
                dateFrom.Visible = false;
                dateTo.Visible = false;
                btnApDung2.Visible = false;
                // Vao ngay
                lbVao.Visible = false;
                dateThis.Visible = false;
                btnApDung1.Visible = false;
                //HienThiLai
                HienThiLichSuKhamBenh();
            }
            else if (cbbLuaChon.SelectedIndex == 1)
            {
                //Tu ngay den ngay
                lbTu.Visible = false;
                lbDen.Visible = false;
                dateFrom.Visible = false;
                dateTo.Visible = false;
                btnApDung2.Visible = false;
                // Vao ngay
                lbVao.Visible = true;
                dateThis.Visible = true;
                btnApDung1.Visible = true; ;
            }
            else if (cbbLuaChon.SelectedIndex == 2)
            {
                //Tu ngay den ngay
                lbTu.Visible = true;
                lbDen.Visible = true;
                dateFrom.Visible = true;
                dateTo.Visible = true;
                btnApDung2.Visible = true;
                // Vao ngay
                lbVao.Visible = false;
                dateThis.Visible = false;
                btnApDung1.Visible = false;
            }
        }
        #endregion
        #region Events
        public delegate void HienThi_delegate();
        public HienThi_delegate On_HienThi;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "" || txtTenBacSi.Text == "" || txtDiaChi.Text == ""
             || txtEmail.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ các trường");
                return;
            }
            if (cbbKhoa.SelectedIndex < 0 || cbbChucVu.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn đủ các hộp chọn");
                return;
            }
            if (rdbNam.Checked == false && rdbNu.Checked == false)
            {
                MessageBox.Show("Hãy chọn giới tính");
                return;
            }
            if (dtpNgaySinh.Value.CompareTo(DateTime.Now) >= 0)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                return;
            }
            if (dtpNgaySinh.Value.CompareTo(dtpNgayDiLam.Value) >= 0)
            {
                MessageBox.Show("Ngày vào làm không hợp lệ");
                return;
            }
            if (ChinhSuaBacSi() == 1)
            {
                if (On_HienThi != null) On_HienThi();
            }
        }
        private void ThongTin_CaNhan_Load(object sender, EventArgs e)
        {
            cbbLuaChon.SelectedIndex = 0;
            LoadCBBChucVu();
            LoadCBBKhoa();
            HienThiChiTiet();
            HienThiLichSuKhamBenh();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
             if(XoaBacSi()==1)
            {
                this.Close();
                if (On_HienThi != null) On_HienThi();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvLichSu_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             string maDon = dgvLichSu.SelectedRows[0].Cells[0].Value.ToString();
            string maBS = DonThuoc.LayMaBacSiTuMaDon(maDon);
            string maBN = DonThuoc.LayMaBenhNhanTuMaDon(maDon);
            ThongTinDonThuoc fo = new ThongTinDonThuoc(maDon, maBS, maBN);
            this.Hide();
            fo.ShowDialog();
            this.Show();
        }
        private void cbbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
             LuaChon();
        }
        private void btnApDung2_Click(object sender, EventArgs e)
        {
            dgvLichSu.DataSource = DonThuoc.KiemTraNgayLamViecCaNhanFromTo(dateFrom.Value.Date, dateTo.Value.Date, maBS);
            lbSoDon.Text = DonThuoc.KiemTraNgayLamViecCaNhanFromTo(dateFrom.Value.Date, dateTo.Value.Date, maBS).Count().ToString();
        }
        private void btnApDung1_Click(object sender, EventArgs e)
        {
            dgvLichSu.DataSource =  DonThuoc.KiemTraNgayLamViecCaNhan(dateThis.Value.Date,maBS);
            lbSoDon.Text = DonThuoc.KiemTraNgayLamViecCaNhan(dateThis.Value.Date, maBS).Count().ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnHelpLS_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\LichSu_BacSi.txt");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\ThongTin_CaNhan.txt");
        }
    }
}

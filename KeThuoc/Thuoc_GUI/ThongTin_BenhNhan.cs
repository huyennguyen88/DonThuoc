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
namespace KeThuoc.Thuoc_GUI
{
    public partial class ThongTin_BenhNhan : Form
    {
        string maBN;
        string maBS;
        int quyen;
        Thuoc_BLL.BenhNhan_BLL QuanLyBenhNhan = new BenhNhan_BLL();
        DonThuoc_BLL donthuoc = new DonThuoc_BLL();
        public ThongTin_BenhNhan(string maBN, string maBS, int quyen)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.maBN = maBN;
            this.maBS = maBS;
            this.quyen = quyen;
        }
        #region Methods
        public void HienThiChiTiet()
        {
            BenhNhan benhnhan = QuanLyBenhNhan.LayThongTin1BenhNhan(maBN);
            txtMaBenhNhan.Text = benhnhan.MaBenhNhan;
            txtTenBenhNhan.Text = benhnhan.TenBenhNhan;
            dtpNgaySinh.Value = benhnhan.NgaySinh;
            txtDiaChi.Text = benhnhan.DiaChi;
            txtSDT.Text = benhnhan.SDT;
            bool gender = benhnhan.GioiTinh;
            if (gender == true) rdbNam.Checked = true;
            else rdbNu.Checked = true;
        }
        public int ChinhSuaBenhNhan()
        {
            if (quyen != 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa thông tin", "Ngăn chặn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }

            BenhNhan benhnhan = new BenhNhan
            {
                MaBenhNhan = txtMaBenhNhan.Text,
                TenBenhNhan = txtTenBenhNhan.Text,
                NgaySinh = dtpNgaySinh.Value,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                GioiTinh = rdbNam.Checked,
            };
            QuanLyBenhNhan.ChinhSuaBenhNhan(benhnhan);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }
        public int XoaBenhNhan()
        {
            if (quyen != 1)
            {
                MessageBox.Show("Bạn không có quyền xoá", "Ngăn chặn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
            DialogResult kq = MessageBox.Show("Xoá thuốc sẽ xoá mọi đơn thuốc liên quan đến thuốc," +
                " bạn có muốn xoá không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No)
            {
                return 0;
            }
            List<string> maList = new List<string>();
            maList.Add(maBN);
            QuanLyBenhNhan.XoaBenhNhan(maList);
            MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }
        void HienThiLichSuKhamBenh()
        {
            lbTen.Text = txtTenBenhNhan.Text;
            dgvLichSu.DataSource = donthuoc.HienThiDonThuocBenhNhan(maBN);
            lbSoLanKham.Text = donthuoc.HienThiDonThuocBenhNhan(maBN).Count().ToString();
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
        #region Event
        public delegate void HienThi_delegate();
        public HienThi_delegate On_HienThi;
        private void ThongTin_BenhNhan_Load(object sender, EventArgs e)
        {
            cbbLuaChon.SelectedIndex = 0;
            HienThiChiTiet();
            HienThiLichSuKhamBenh();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "" || txtSDT.Text == "" 
             || txtTenBenhNhan.Text == "" )
            {
                MessageBox.Show("Hãy nhập đủ các trường");
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
            if ( ChinhSuaBenhNhan() == 1)
            {
                if (On_HienThi != null) On_HienThi();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XoaBenhNhan() == 1)
            {
                this.Close();
                if (On_HienThi != null) On_HienThi();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            int maCuoi = donthuoc.LayMaDTLonNhat();
            int maDT = maCuoi + 1;
            string maMoi = "DT" + maDT;
            formBacSi_TaoDon fo = new formBacSi_TaoDon(maBN,maBS,maMoi);
            fo.ShowDialog();
            this.Close();
        }
        private void dgvLichSu_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string maDon = dgvLichSu.SelectedRows[0].Cells[0].Value.ToString();
            string maBS = donthuoc.LayMaBacSiTuMaDon(maDon);
            string maBN = donthuoc.LayMaBenhNhanTuMaDon(maDon);
            ThongTinDonThuoc fo = new ThongTinDonThuoc(maDon, maBS, maBN);
            this.Hide();
            fo.ShowDialog();
            this.Show();
        }
        private void cbbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LuaChon();
        }
        private void btnApDung1_Click(object sender, EventArgs e)
        {
            dgvLichSu.DataSource = donthuoc.HienThiDonThuocBenhNhanTheoNgay(dateThis.Value.Date, maBN);
            lbSoLanKham.Text = donthuoc.HienThiDonThuocBenhNhanTheoNgay(dateThis.Value.Date, maBN).Count().ToString();
        }
        private void btnApDung2_Click(object sender, EventArgs e)
        {
            dgvLichSu.DataSource = donthuoc.HienThiDonThuocBenhNhanFromTo(dateFrom.Value.Date, dateTo.Value.Date, maBN);
            lbSoLanKham.Text = donthuoc.HienThiDonThuocBenhNhanFromTo(dateFrom.Value.Date, dateTo.Value.Date, maBN).Count().ToString();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\ThongTin_BenhNhan.txt");
        }

        private void btnHelpLS_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\LichSu_BenhNhan.txt");
        }
    }
}

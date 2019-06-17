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
    public partial class ThongTin_Thuoc : Form
    {
        Thuoc_BLL.Thuoc_BLL QuanLyThuoc = new Thuoc_BLL.Thuoc_BLL();
        string ma;
        int quyen;
        public ThongTin_Thuoc(string ma, int quyen)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.ma = ma;
            this.quyen = quyen;
        }
        void LoadCBBLoaiThuoc()
        {
            cbbLoaiThuoc.Items.AddRange(QuanLyThuoc.LoadCBBLoaiThuoc().ToArray());
        }
        private void ThongTin_Thuoc_Load(object sender, EventArgs e)
        {
            LoadCBBLoaiThuoc();
            HienThiChiTiet();
        }
        #region Methods
        public void HienThiChiTiet()
        {
            THUOC thuoc = QuanLyThuoc.LayThongTin1Thuoc(ma);
            string tenLoaiThuoc = QuanLyThuoc.LayTenLoaiThuoc(thuoc.MaLoai);
            txtMaThuoc.Text = thuoc.MaThuoc;
            txtTenThuoc.Text = thuoc.TenThuoc;
            txtCongDung.Text = thuoc.CongDung;
            txtTacDungPhu.Text = thuoc.TacDungPhu;
            txtDangThuoc.Text = thuoc.DangThuoc;
            txtSoLuong.Text = thuoc.SoLuong;
            cbbLoaiThuoc.SelectedIndex = cbbLoaiThuoc.FindStringExact(tenLoaiThuoc);
        }
        public int ChinhSuaThuoc()
        {
            if (quyen != 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa thông tin", "Ngăn chặn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return 0;
            }
            string maloai = QuanLyThuoc.LayMaLoaiThuoc(cbbLoaiThuoc.SelectedItem.ToString());
            THUOC thuoc = new THUOC
            {
                MaThuoc = txtMaThuoc.Text,
                TenThuoc = txtTenThuoc.Text,
                CongDung = txtCongDung.Text,
                TacDungPhu = txtTacDungPhu.Text,
                DangThuoc = txtDangThuoc.Text,
                MaLoai = maloai,
                SoLuong = txtSoLuong.Text
            };
            QuanLyThuoc.ChinhSuaThuoc(thuoc);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }
        public int XoaThuoc()
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
            maList.Add(ma);
            QuanLyThuoc.XoaThuoc(maList);
            MessageBox.Show("Xoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }
        #endregion
        #region Event
        public delegate void HienThi_delegate();
        public HienThi_delegate On_HienThi;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtCongDung.Text == "" || txtDangThuoc.Text == "" || txtSoLuong.Text == ""
              || txtTacDungPhu.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ các trường");
                return;
            }
            if (cbbLoaiThuoc.SelectedIndex < 0)
            {
                MessageBox.Show("Hãy chọn đủ các hộp chọn");
                return;
            }
            if (ChinhSuaThuoc() == 1)
            {
                if (On_HienThi != null) On_HienThi();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XoaThuoc() == 1)
            {
                this.Close();
                if (On_HienThi != null) On_HienThi();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\ThongTin_Thuoc.txt");
        }
    }
}

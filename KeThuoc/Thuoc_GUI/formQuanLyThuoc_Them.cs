using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KeThuoc.Thuoc_BLL;
using KeThuoc.Thuoc_DAL;
using System.Diagnostics;

namespace KeThuoc
{
    public partial class formQuanLyThuoc_Them : Form
    {
        Thuoc_BLL.Thuoc_BLL QuanLyThuoc = new Thuoc_BLL.Thuoc_BLL();
        string maThuoc;
        public formQuanLyThuoc_Them(string maThuoc)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.maThuoc = maThuoc;
            txtMaThuoc.Text = maThuoc;
        }
        #region Methods
        void ThemThuoc()
        {
            if (Regex.Replace(txtTenThuoc.Text, " ", "") == "")
            {
                MessageBox.Show("Không được để trống Tên thuốc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maloai = QuanLyThuoc.LayMaLoaiThuoc(cbbLoaiThuoc.SelectedItem.ToString());
                THUOC thuoc = new THUOC
                {
                    MaThuoc = maThuoc,
                    TenThuoc = txtTenThuoc.Text,
                    CongDung = txtCongDung.Text,
                    TacDungPhu = txtTacDungPhu.Text,
                    DangThuoc = txtDangThuoc.Text,
                    SoLuong = txtSoLuong.Text,
                    MaLoai = maloai
                };
                QuanLyThuoc.ThemThuoc(thuoc);
                this.Close();
            }
        }
        void LoadCBB()
        {
            cbbLoaiThuoc.Items.AddRange(QuanLyThuoc.LoadCBBLoaiThuoc().ToArray());
            cbbLoaiThuoc.SelectedIndex = 2;
        }
        #endregion
        #region Events
        public delegate void HienThi_delegate();
        public HienThi_delegate On_HienThi;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCongDung.Text == "" || txtDangThuoc.Text == "" || txtSoLuong.Text == ""
                || txtTacDungPhu.Text == "" )
            {
                MessageBox.Show("Hãy nhập đủ các trường");
                return;
            }
            if (cbbLoaiThuoc.SelectedIndex<0)
            {
                MessageBox.Show("Hãy chọn đủ các hộp chọn");
                return;
            }
            ThemThuoc();
            if (On_HienThi != null) On_HienThi();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void formQuanLyThuoc_Them_Load(object sender, EventArgs e)
        {
            LoadCBB();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\QuanLyThuoc_Them.txt");
        }
    }
}

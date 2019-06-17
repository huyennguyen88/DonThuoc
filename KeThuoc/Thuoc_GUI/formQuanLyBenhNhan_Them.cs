using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using KeThuoc.Thuoc_DAL;
using KeThuoc.Thuoc_BLL;
using System.Windows.Forms;
using System.Diagnostics;

namespace KeThuoc
{
    public partial class formQuanLyBenhNhan_Them : Form
    {
        Thuoc_BLL.BenhNhan_BLL QuanLyBenhNhan = new BenhNhan_BLL();
        string maBN;
        public formQuanLyBenhNhan_Them(string maBN)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.maBN = maBN;
            txtMaBenhNhan.Text = maBN;
        }
        # region Methods
        void ThemBenhNhan()
        {
            if (Regex.Replace(txtTenBenhNhan.Text, " ", "") == "")
            {
                MessageBox.Show("Không được để trống Tên Bệnh Nhân", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BenhNhan benhnhan = new BenhNhan
                {
                    MaBenhNhan = maBN,
                    TenBenhNhan = txtTenBenhNhan.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    GioiTinh = rdbNam.Checked
                };
                QuanLyBenhNhan.ThemBenhNhan(benhnhan);
                this.Close();
            }
        }
        #endregion
        #region Events
        public delegate void HienThi_delegate();
        public HienThi_delegate On_HienThi;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtTenBenhNhan.Text == "" || txtDiaChi.Text == ""
         || txtSDT.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ các trường");
                return;
            }
           
            if (dtpNgaySinh.Value.CompareTo(DateTime.Now) >=0)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                return;
            }
            if (rdbNam.Checked == false && rdbNu.Checked == false)
            {
                MessageBox.Show("Hãy chọn giới tính");
                return;
            }
            ThemBenhNhan();
            if (On_HienThi != null) On_HienThi();
            this.Close();
        }
        #endregion
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\QuanLyBenhNhan_Them.txt");
        }
    }
}

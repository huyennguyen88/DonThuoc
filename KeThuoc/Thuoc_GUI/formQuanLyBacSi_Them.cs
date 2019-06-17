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
    public partial class formQuanLyBacSi_Them : Form
    {
        string MaBS;
        Thuoc_BLL.QuanLyBacSi_BLL QuanLyBacSi = new QuanLyBacSi_BLL();
        public formQuanLyBacSi_Them(string MaBS)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            txtMaBacSi.Text = MaBS;
            this.MaBS = MaBS;
        }
        void ThemBacSi()
        {
            string makhoa = QuanLyBacSi.LayMaKhoa(cbbKhoa.SelectedItem.ToString());
            string machucvu = QuanLyBacSi.LayMaChucVu(cbbChucVu.SelectedItem.ToString());
            if (Regex.Replace(txtTenBacSi.Text, " ", "") == "" || Regex.Replace(txtMatKhau.Text, " ", "") == "")
            {
                MessageBox.Show("Không được để trống Tên Bác Sĩ và Mật Khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BacSi bs = new BacSi
                {
                    MaBacSi = MaBS,
                    MatKhau = txtMatKhau.Text,
                    TenBacSi = txtTenBacSi.Text,
                    MaKhoa = makhoa,
                    MaChucVu = machucvu,
                    NgayBatDauLam = dtpNgayDiLam.Value,
                    DiaChi = txtDiaChi.Text,
                    Sdt = txtSDT.Text,
                    Email = txtEmail.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    PhanQuyen = 2,
                };
                QuanLyBacSi.ThemBacSi(bs);
                this.Close();
            }
        }
        void LoadCBB()
        {
           cbbChucVu.Items.AddRange(QuanLyBacSi.LoadCBBChucVu().ToArray());
           cbbKhoa.Items.AddRange(QuanLyBacSi.LoadCBBKhoa().ToArray());
            cbbChucVu.SelectedIndex= 2;
            cbbKhoa.SelectedIndex = 2;
        }
        public delegate void OKbut_Dele();
        public OKbut_Dele On_OKbutton;
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.Text =="" || txtTenBacSi.Text =="" || txtDiaChi.Text ==""
                || txtEmail.Text =="" || txtSDT.Text =="")
            {
                MessageBox.Show("Hãy nhập đủ các trường");
                return;
            }
            if(cbbKhoa.SelectedIndex<0 || cbbChucVu.SelectedIndex<0)
            {
                MessageBox.Show("Hãy chọn đủ các hộp chọn");
                return;
            }
            if(rdbNam.Checked == false && rdbNu.Checked==false)
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
            ThemBacSi();
            if (On_OKbutton != null) On_OKbutton();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formQuanLyBacSi_Them_Load(object sender, EventArgs e)
        {
            LoadCBB();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\QuanLyBacSi_Them.txt");
        }
    }
}

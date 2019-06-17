using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using KeThuoc.Thuoc_BLL;
using System.Diagnostics;

namespace KeThuoc
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            pnLogin.Visible = false;
        }
        DangNhap_BLL dangnhap = new DangNhap_BLL();
        void DangNhap()
        {
            string ma = txtTaiKhoan.Text.ToUpper();
            string mk = txtMatKhau.Text;
            int kiemtra = dangnhap.KiemTra(ma, mk);
            if (kiemtra == 0)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            if (kiemtra == 1)
            {
                txtMatKhau.Clear();
                this.Hide();
                string ten= dangnhap.tenBS(ma);
                new AdminPage(ten,ma).ShowDialog();
                this.Show();
            }
            if (kiemtra == 2)
            {
                txtMatKhau.Clear();
                this.Hide();
                string ten = dangnhap.tenBS(ma);
                new BacSiPage(ten,ma).ShowDialog();
                this.Show();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text=="")
            {
                MessageBox.Show("Nhập tên tài khoản");
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu");
                return;
            }
            DangNhap();
        }

        private void MB_DangNhap_Click(object sender, EventArgs e)
        {
                
        }

        private void MS_DangNhap_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            txtTaiKhoan.Visible = true;
            txtMatKhau.Visible = true;
            btnOK.Visible = true;
            btnThoat.Visible = true;
            pnLogin.Visible = true;
        }

        private void MS_TrangChu_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            txtTaiKhoan.Visible = false;
            txtMatKhau.Visible = false;
            btnOK.Visible = false;
            btnThoat.Visible = false;
            pnLogin.Visible = false;

        }
        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        private void MB_TroGiup_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\Main.txt");
        }
    }
}

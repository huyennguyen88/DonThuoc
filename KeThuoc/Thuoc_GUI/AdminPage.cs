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

namespace KeThuoc
{
    public partial class AdminPage : Form
    {
        string maBS;
        public AdminPage(string ten, string maBS)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            labelXinChao.Text = "Admin: " + ten;
            this.maBS = maBS;
        }
        private void btnBacSi_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formQuanLyBacSi().ShowDialog();
            this.Show();
        }

        private void btnKhoThuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formQuanLyThuoc(1,"").ShowDialog();
            this.Show();
        }
        private void btnDonThuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ThongKeDonThuoc(maBS,1).ShowDialog();
            this.Show();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ThongTin_CaNhan(maBS,1).ShowDialog();
            this.Show();
        }

        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formQuanLyBenhNhan(maBS,1).ShowDialog();
            this.Show();
        }
        private void btnHlep_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\AdminPage.txt");
        }
    }
}

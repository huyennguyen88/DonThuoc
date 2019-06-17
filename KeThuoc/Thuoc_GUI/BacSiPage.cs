using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeThuoc.Thuoc_BLL;
using KeThuoc.Thuoc_DAL;
using KeThuoc.Thuoc_GUI;
using System.Diagnostics;
namespace KeThuoc
{
    public partial class BacSiPage : Form
    {
        string maBS;
        public BacSiPage(string ten, string mabs)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            labelXinChao.Text = "Bác Sĩ: " + ten;
            maBS = mabs;
        }
        #region Events
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ThongTin_CaNhan(maBS,2).ShowDialog();
            this.Show();
        }
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDonXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ThongKeDonThuoc(maBS, 2).ShowDialog(); 
            this.Show();
        }
        private void btnKhoThuoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formQuanLyThuoc(2,"").ShowDialog();
            this.Show();
        }
        private void btnBenhNhan_Click(object sender, EventArgs e)
        {
            this.Hide();

            new formQuanLyBenhNhan(maBS,2).ShowDialog();
            this.Show();
        }
        private void bntHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\BacSiPage.txt");
        }
        #endregion
    }
}

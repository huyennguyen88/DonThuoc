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
namespace KeThuoc
{
    public partial class ThongKeDonThuoc : Form
    {
        KeThuoc.Thuoc_BLL.DonThuoc_BLL DonThuoc = new DonThuoc_BLL();
        string maBS;
        int quyen;
        public ThongKeDonThuoc(string maBS, int quyen)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.maBS = maBS;
            this.quyen = quyen;
        }
        #region Methods
        void LuaChon()
        {
            if(cbbLuaChon.SelectedIndex == -1 || cbbLuaChon.SelectedIndex == 0)
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
                lbVao.Visible = true ;
                dateThis.Visible = true;
                btnApDung1.Visible = true; ;
            }
            else if(cbbLuaChon.SelectedIndex == 2)
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
        void HienThiLichSuKhamBenh()
        {
            dgvTongDT.DataSource = DonThuoc.HienThiDonThuocAdmin();
            lbTongSoDon.Text = DonThuoc.TongSoDonThuocAdmin().ToString();
        }
        #endregion
        #region Events
        private void ThongKeDonThuoc_Load(object sender, EventArgs e)
        {
            cbbLuaChon.SelectedIndex = 0;
            HienThiLichSuKhamBenh();
            
            //if(quyen == 1)
            //{
                
            // }
            //if(quyen == 2)
            //{
            //    dgvTongDT.DataSource = DonThuoc.HienThiDonThuocBacSi(maBS);
            //    lbTongSoDon.Text = DonThuoc.TongSoDonThuocBacSi(maBS).ToString();
            //}
            // Rút code Thằng bác sĩ vì không bỏ nút lịch sử tạo đơn
        }
        private void dgvTongDT_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string maDon = dgvTongDT.SelectedRows[0].Cells[0].Value.ToString();
            string maBS = DonThuoc.LayMaBacSiTuMaDon(maDon);
            string maBN = DonThuoc.LayMaBenhNhanTuMaDon(maDon);
            ThongTinDonThuoc fo = new ThongTinDonThuoc(maDon,maBS,maBN);
            this.Hide();
            fo.ShowDialog();
            this.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LuaChon();
        }
        private void btnApDung1_Click(object sender, EventArgs e)
        {
            dgvTongDT.DataSource = DonThuoc.KiemTraNgayLamViecThongKe(dateThis.Value.Date);
            lbTongSoDon.Text = DonThuoc.KiemTraNgayLamViecThongKe(dateThis.Value.Date).Count().ToString();
        }
        private void btnApDung2_Click(object sender, EventArgs e)
        {
            if(dateFrom.Value.CompareTo(dateTo.Value) >0 )
            {
                MessageBox.Show("Ngày sau phải lớn hơn hoặc bằng ngày đầu");
                return;
            }
            dgvTongDT.DataSource = DonThuoc.KiemTraNgayLamViecThongKeFromTo(dateFrom.Value.Date, dateTo.Value.Date);
            lbTongSoDon.Text = DonThuoc.KiemTraNgayLamViecThongKeFromTo(dateFrom.Value.Date, dateTo.Value.Date).Count().ToString();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\ThongKeDonThuoc.txt");
        }
    }
}

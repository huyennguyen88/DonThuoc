using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeThuoc.Thuoc_DAL;
using KeThuoc.Thuoc_BLL;
using System.Text.RegularExpressions; // BTCQ =)) kiemtra kitu "";
using System.Diagnostics;

namespace KeThuoc.Thuoc_GUI
{
    public partial class ChonSoluongThuoc : Form
    {
        string maDT;
        string maTH;
        DonThuoc_BLL DvT = new DonThuoc_BLL();
        Thuoc_BLL.Thuoc_BLL QuanLyThuoc = new Thuoc_BLL.Thuoc_BLL();
        public ChonSoluongThuoc(string maDT, string maTH)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.maDT = maDT;
            this.maTH = maTH;
            cbbDonvitinh.SelectedIndex = 0;
            txtSoLuong.Text = QuanLyThuoc.LayThongTin1Thuoc(maTH).SoLuong;
        }
        #region Methods
        void ThemDonThuoc()
        {
            if(Regex.Replace(txtSoLan.Text," ","") == "" || Regex.Replace(txtSoNgay.Text," ","") == ""  || Regex.Replace(txtSovien1L.Text, " ", "") == "")
            {
                MessageBox.Show("Không được để trống thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int soluongLay;
                int solan = Convert.ToInt32(txtSoLan.Text);
                int moilan = Convert.ToInt32(txtSovien1L.Text);
                int songay = Convert.ToInt32(txtSoNgay.Text);
                soluongLay = songay * solan * moilan;
                string cachDung = "Mỗi ngày " + solan + " lần, một lần " + moilan + " " + lbDVT.Text;
                DonVaThuoc Don = new DonVaThuoc
                {
                    MaDon = maDT,
                    MaThuoc = maTH,
                    SoLuong = soluongLay.ToString(),
                    DonViTinh = lbDVT.Text,
                    CachDung = cachDung,
                };
                THUOC thuoc_hientai = QuanLyThuoc.LayThongTin1Thuoc(maTH);
                int soluongKho = Convert.ToInt32(thuoc_hientai.SoLuong);
                int soluongConLai = soluongKho - soluongLay;
                if(soluongConLai < 0)
                {
                    MessageBox.Show("Không đủ số lượng thuốc cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    THUOC thuoc_capnhat = new THUOC
                    {
                        MaThuoc = thuoc_hientai.MaThuoc,
                        TenThuoc = thuoc_hientai.TenThuoc,
                        CongDung = thuoc_hientai.CongDung,
                        TacDungPhu = thuoc_hientai.TacDungPhu,
                        DangThuoc = thuoc_hientai.DangThuoc,
                        SoLuong = soluongConLai.ToString(),
                        MaLoai = thuoc_hientai.MaLoai,
                    };
                    DvT.ThemDonVaThuoc(Don); // them don
                    QuanLyThuoc.ChinhSuaThuoc(thuoc_capnhat); // cap nhat so luong thuoc
                    this.Close();
             }            
        }
        void KeyPressOnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char) 8) 
            {
                e.Handled = true;
                MessageBox.Show("Không cho nhập kí tự khác số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Events
        private void ChonSoluongThuoc_Load(object sender, EventArgs e)
        {
            txtMaDonThuoc.Text = maDT;
            txtMaThuoc.Text = maTH;
            txtSoLan.Text = "1";
            txtSoNgay.Text = "1";
            txtSovien1L.Text = "1";
        }
        private void cbbDonvitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dvt;
            dvt = cbbDonvitinh.SelectedItem.ToString();
            lbDVT.Text = dvt;
            lbDVT.Visible = true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            ThemDonThuoc();
        }
        private void txtSoNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressOnlyNumber(sender, e);
        }
        private void txtSoLan_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressOnlyNumber(sender, e);
        }
        private void txtSovien1L_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressOnlyNumber(sender, e);
        }
        #endregion

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\ChonSoLuongThuoc.txt");

        }
    }
}

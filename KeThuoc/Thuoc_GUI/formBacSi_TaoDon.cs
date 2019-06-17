using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeThuoc.Thuoc_GUI;
using KeThuoc.Thuoc_BLL;
using KeThuoc.Thuoc_DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace KeThuoc
{
    
    public partial class formBacSi_TaoDon : Form
    {

        string maBS;
        string maBN;
        string maDT;
        DangNhap_BLL tenBS = new DangNhap_BLL();
        Thuoc_BLL.DonThuoc_BLL DonVaThuoc = new DonThuoc_BLL();
        Thuoc_BLL.BenhNhan_BLL benhNhan = new BenhNhan_BLL();
        Thuoc_BLL.QuanLyBacSi_BLL bacSi = new QuanLyBacSi_BLL();
        public formBacSi_TaoDon(string maBN, string maBS,string maDT)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.maBS = maBS;
            this.maBN = maBN;
            this.maDT = maDT;
        }
        private void formBacSi_TaoDon_Load(object sender, EventArgs e)
        {
            this.Width = 690;
            this.Height = 310;
            txtMaDonThuoc.Text = maDT;
            txtMaBacSi.Text = maBS;
            txtTenBacSi.Text = tenBS.tenBS(maBS);
            txtMaBenhNhan.Text = maBN;
        }
        #region Methods
        void ThemDonThuoc()
        {
            DonThuoc donthuoc = new DonThuoc
            {
                MaDon = maDT,
                MaBacSi = maBS,
                MaBenhNhan = maBN,
                NgayLamDon = dtpNgayLamDon.Value,
                NgayTaiKham = dtpNgayTaiKham.Value,
                BenhLi = txtBenhLi.Text,
                BaoHiem = rdbKhong.Checked,
            };
            DonVaThuoc.ThemDonThuoc(donthuoc);
        }
        void VoHieuHoa()
        {
            this.Height = 579;
            this.Width = 690;

            //690, 579
            btnChonThuoc.Visible = true;
            btnHoanThanh.Enabled = true;
            btnThemDon.Visible = false;
            rdbCo.Enabled = false;
            rdbKhong.Enabled = false;
            txtBenhLi.Enabled = false;
            dtpNgayLamDon.Enabled = false;
            dtpNgayTaiKham.Enabled = false;
            dgvDSThuoc.DataSource = DonVaThuoc.HienThiDanhSachThuocDaChon(maDT);
        }
        public void HienThiDataGridView()
        {
            dgvDSThuoc.DataSource = DonVaThuoc.HienThiDanhSachThuocDaChon(maDT);
        }
        public void TaoPDF()
        {
            BaseFont bf = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\ARIALUNI.TTF", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font textFontVLC = new iTextSharp.text.Font(bf, 18, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font textFontHeader = new iTextSharp.text.Font(bf, 25, iTextSharp.text.Font.BOLD);

            iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font damNghieng = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLDITALIC);
            iTextSharp.text.Font nhatNghieng = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.ITALIC );
            Paragraph para1 = new Paragraph("SỞ Y TẾ THÀNH PHỐ ĐÀ NẴNG \n", textFontVLC);
            Paragraph para2 = new Paragraph("BỆNH VIỆN ABC \n",textFontVLC);
            Paragraph diachi = new Paragraph("Địa chỉ: 123 Nguyễn Huệ, phường Thạch Than, quận Hải Châu,Tp.Đà Nẵng\n", damNghieng);
            Paragraph sdt = new Paragraph("Số điện thoại: 0213012479\n", damNghieng);
            Paragraph madon = new Paragraph("Mã đơn thuốc: "+maDT, textFont);
            Paragraph header = new Paragraph("ĐƠN THUỐC", textFontHeader);
            header.Alignment = 1;
            string bh="Không";
            if (rdbCo.Checked) bh = "Có";
           
            string Strdoan = @"Tên bệnh nhân: " + benhNhan.LayThongTin1BenhNhan(maBN).TenBenhNhan + "\n" +
                "Tên bác sĩ: " + txtTenBacSi.Text+ "\n" +
                "Bảo hiểm: " + bh + "\n" +
                  "Bệnh lý: " + txtBenhLi.Text + "\n"+
            "Ngày làm đơn: " + dtpNgayLamDon.Value.ToShortDateString() + "\n" +
               "Ngày tái khám: " + dtpNgayTaiKham.Value.ToShortDateString() + "\n";
            Paragraph trong = new Paragraph("\n");
            Paragraph doanDau = new Paragraph(Strdoan, textFont);
            PdfPTable ptable = new PdfPTable(dgvDSThuoc.ColumnCount);
            string Strfooter = "Chữ kí bác sĩ\n";
            Paragraph doanCuoi = new Paragraph(Strfooter, nhatNghieng);
            doanCuoi.Alignment = 2;
            Paragraph tenBS = new Paragraph(txtTenBacSi.Text, damNghieng);
            tenBS.Alignment = 2;
            Paragraph demTheo = new Paragraph("Khi khám nhớ đem theo đơn thuốc này để bác sĩ dễ theo dõi", nhatNghieng);
            demTheo.Alignment = 1;

            ptable.DefaultCell.Padding = 5;
            ptable.WidthPercentage = 100;
            ptable.HorizontalAlignment = Element.ALIGN_CENTER;
            ptable.DefaultCell.BorderWidth = 1;
        
            //Add header
            foreach (DataGridViewColumn col in dgvDSThuoc.Columns)
            {

                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, textFont));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    ptable.AddCell(cell);
            }
            //Add datarow
            foreach (DataGridViewRow row in dgvDSThuoc.Rows)
            {
                foreach (DataGridViewCell c in row.Cells)
                {
                    ptable.AddCell(new Phrase(c.Value.ToString(), textFont));
                }
            }
            var saveDia = new SaveFileDialog();
            saveDia.FileName = "DonThuoc " + maDT;
            
            saveDia.DefaultExt = ".pdf";
            //Bat dau chep vao
            if (saveDia.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fstream = new FileStream(saveDia.FileName, FileMode.Create))
                {
                    Document pdoc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                    PdfWriter wri = PdfWriter.GetInstance(pdoc, fstream);

                    pdoc.Open();
                    pdoc.Add(para1);
                    pdoc.Add(para2);
                    pdoc.Add(diachi);
                    pdoc.Add(sdt);
                    pdoc.Add(madon);
                    pdoc.Add(header);
                    pdoc.Add(doanDau);
                    pdoc.Add(trong);
                    pdoc.Add(ptable);
                    pdoc.Add(trong);
                    pdoc.Add(trong);
                    pdoc.Add(doanCuoi);
                   for(int i=0; i<5;i++)
                    {
                        pdoc.Add(trong);
                    }
                    pdoc.Add(tenBS);
                    pdoc.Add(trong);
                    pdoc.Add(demTheo);
                    pdoc.Close();
                }
                Process.Start(saveDia.FileName);
            }
        }
        #endregion
        #region Events
        private void btnChonThuoc_Click(object sender, EventArgs e)
        {
            int quyen=2;
            if (maBS == "BS1") quyen = 1;
            formQuanLyThuoc fo = new formQuanLyThuoc(quyen, maDT);
            fo.On_HienThi += HienThiDataGridView;
            fo.ShowDialog();
        }
        private void btnOKdonthuoc_Click(object sender, EventArgs e)
        {
            if(rdbCo.Checked==false && rdbKhong.Checked==false)
            {
                MessageBox.Show("Chọn có bảo hiểm hay không?");
                return;
            }
            if(txtBenhLi.Text=="")
            {
                MessageBox.Show("Nhập bệnh lý ");
                return;
            }
            if (dtpNgayTaiKham.Value.CompareTo(dtpNgayLamDon.Value) < 0)
            {
                MessageBox.Show("Ngày tái khám là hôm nay hoặc sau hôm nay ");
                return;
            }
            ThemDonThuoc();
            VoHieuHoa();
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            TaoPDF();

            this.Close();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\BacSi_TaoDon.txt");
        }
    }
}

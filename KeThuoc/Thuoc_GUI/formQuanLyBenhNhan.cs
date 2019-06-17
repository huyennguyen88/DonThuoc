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
using System.IO;
using ExcelDataReader;
using iTextSharp.text;
using System.Diagnostics;

namespace KeThuoc
{
    public partial class formQuanLyBenhNhan : Form
    {
        int quyen;
        string maBS;
        Thuoc_BLL.BenhNhan_BLL QuanLyBenhNhan = new BenhNhan_BLL();
        public formQuanLyBenhNhan(string maBS, int quyen)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.quyen = quyen;
            this.maBS = maBS;
        }
        #region Methods
        void HienThiDatagridview()
        {
            dgvQLBN.DataSource = QuanLyBenhNhan.HienThiThongTin();
            lbTongCong.Text = QuanLyBenhNhan.HienThiThongTin().Count().ToString();
        }
        void XoaBenhNhan()
        {
            DataGridViewSelectedRowCollection tap = dgvQLBN.SelectedRows;
            string ma;
            List<string> maList = new List<string>();
            foreach (DataGridViewRow row in tap)
            {
                ma = row.Cells[0].Value.ToString();
                maList.Add(ma);
            }
            QuanLyBenhNhan.XoaBenhNhan(maList);
            MessageBox.Show("Đã xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiDatagridview();
        }
        void ThemBenhNhan()
        {
            int maCuoi = QuanLyBenhNhan.LayMaBNLonNhat();
            int maBN = maCuoi + 1;
            string maMoi = "BN" + maBN;
            formQuanLyBenhNhan_Them fo = new formQuanLyBenhNhan_Them(maMoi);
            fo.On_HienThi += HienThiDatagridview;
            fo.ShowDialog();
        }
        void TimKiemBenhNhanTheoTen(string ten)
        {
            dgvQLBN.DataSource = QuanLyBenhNhan.TimKiemBenhNhanTheoTen(ten);
        }
        void SapXep()
        {
            List<string> maList = new List<string>();
            DataGridViewRowCollection rows = dgvQLBN.Rows;
            foreach (DataGridViewRow r in rows)
            {
                maList.Add(r.Cells[0].Value.ToString());
            }
            //bat dau sap xep
            //sap xep theo Ten
            if(cbbSort.SelectedIndex==0)
            {
                if (rdAZ.Checked == true) dgvQLBN.DataSource = QuanLyBenhNhan.SapXepBenhNhanTheoTen(maList, 0);
                else dgvQLBN.DataSource = QuanLyBenhNhan.SapXepBenhNhanTheoTen(maList, 1);
            }
            //sap xep theo SDT
            if(cbbSort.SelectedIndex==1)
            {
                if (rdAZ.Checked == true) dgvQLBN.DataSource = QuanLyBenhNhan.SapXepBenhNhanTheoSDT(maList, 0);
                else dgvQLBN.DataSource = QuanLyBenhNhan.SapXepBenhNhanTheoSDT(maList, 1);
            }
            
        }
        void ThemBenhNhanExcel()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel File|*.xls;*.xlsx;*.xlsm";
            if (open.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                FileStream stream = new FileStream(open.FileName, FileMode.Open);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet excel = excelReader.AsDataSet();
                QuanLyBenhNhan.ImportBenhNhan(excel);

                excelReader.Close();
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Bạn file này đang mở cho tiến trình khác");
                return;
            }


        }
        public void XuatBenhNhanExcel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            ws = wb.Sheets[1];
            ws = wb.ActiveSheet;
            ws.Name = "Info";
            for (int i = 1; i <= dgvQLBN.Columns.Count; i++)
            {
                ws.Cells[1, i] = dgvQLBN.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvQLBN.Rows.Count; i++)
            {
                for (int j = 0; j < dgvQLBN.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dgvQLBN.Rows[i].Cells[j].Value.ToString();
                }
            }
            var SaveFile = new SaveFileDialog();
            SaveFile.FileName = "exportBN";
            SaveFile.DefaultExt = ".xlsx";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                wb.SaveAs(SaveFile.FileName, Type.Missing);
            }
            app.Quit();
        }
        #endregion
        #region Events
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            HienThiDatagridview();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn sắp xếp mục gì?");
                return;
            }
            if (rdAZ.Checked == false && rdZA.Checked == false)
            {
                MessageBox.Show("Bạn sắp xếp theo thứ tự gì?");
                return;
            }
            SapXep();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemBenhNhan();
        }
        private void dgvQLBN_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string maBN;
            maBN = dgvQLBN.SelectedRows[0].Cells[0].Value.ToString();
            ThongTin_BenhNhan fo = new ThongTin_BenhNhan(maBN,maBS, quyen);
            fo.On_HienThi += HienThiDatagridview;
            fo.ShowDialog();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            XoaBenhNhan();
        }   
        private void picSearch_Click(object sender, EventArgs e)
        {
            if (cbbSearch.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn tìm kiếm theo gì?");
                return;
            }
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Hãy nhập từ muốn tìm");
                return;
            }
            int chon = cbbSearch.SelectedIndex;
            if (chon == 0) TimKiemBenhNhanTheoTen(txtSearch.Text);
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            ThemBenhNhanExcel();
            HienThiDatagridview();
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            HienThiDatagridview();
            XuatBenhNhanExcel();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\QuanLyBenhNhan.txt");
        }
    }

}

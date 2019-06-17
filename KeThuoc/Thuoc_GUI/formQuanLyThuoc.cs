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
using System.Diagnostics;

namespace KeThuoc
{
    public partial class formQuanLyThuoc : Form
    {
        Thuoc_BLL.Thuoc_BLL QuanLyThuoc = new Thuoc_BLL.Thuoc_BLL();
        int quyen;
        string maDT;
        public formQuanLyThuoc(int quyen, string maDT)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.quyen = quyen;
            this.maDT = maDT;
        }
        private void formQuanLyThuoc_Load(object sender, EventArgs e)
        {
            if (maDT == "") btnChon.Visible = false;
        }
        public void XuatThuocExcel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            ws = wb.Sheets[1];
            ws = wb.ActiveSheet;
            ws.Name = "Info";
            for (int i = 1; i <= dgvQuanLyThuoc.Columns.Count; i++)
            {
                ws.Cells[1, i] = dgvQuanLyThuoc.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvQuanLyThuoc.Rows.Count; i++)
            {
                for (int j = 0; j < dgvQuanLyThuoc.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dgvQuanLyThuoc.Rows[i].Cells[j].Value.ToString();
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
        #region Methods
        void HienThiDatagridview()
        {
            dgvQuanLyThuoc.DataSource = QuanLyThuoc.HienThiThongTin();
        }
        void XoaThuoc()
        {
            if (quyen == 2)
            {
                MessageBox.Show("Bạn không có quyền xoá", "Ngăn chặn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            DataGridViewSelectedRowCollection tap = dgvQuanLyThuoc.SelectedRows;
            string ma;
            List<string> maList = new List<string>();
            foreach (DataGridViewRow row in tap)
            {
                ma = row.Cells[0].Value.ToString();
                maList.Add(ma);
            }
            QuanLyThuoc.XoaThuoc(maList);
            MessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiDatagridview();
        }
        void TimKiemThuocTheoTen(string ten)
        {
            dgvQuanLyThuoc.DataSource = QuanLyThuoc.TimKiemThuocTheoTen(ten);
        }
        void TimKiemThuocTheoDang(string ten)
        {
            dgvQuanLyThuoc.DataSource = QuanLyThuoc.TimKiemThuocTheoDang(ten);
        }
        void TimKiemThuocTheoLoai(string ten)
        {
            dgvQuanLyThuoc.DataSource = QuanLyThuoc.TimKiemThuocTheoLoai(ten);
        }
        void SapXep()
        {
            List<string> maList = new List<string>();
            DataGridViewRowCollection rows = dgvQuanLyThuoc.Rows;
            foreach (DataGridViewRow r in rows)
            {
                maList.Add(r.Cells[0].Value.ToString());
            }
            //Sap xep theo Ten thuoc
            if(cbbSort.SelectedIndex==0)
            {
                if (rdAZ.Checked == true) dgvQuanLyThuoc.DataSource = QuanLyThuoc.SapXepThuocTheoTen(maList, 0);
                else dgvQuanLyThuoc.DataSource = QuanLyThuoc.SapXepThuocTheoTen(maList, 1);
            }
            if(cbbSort.SelectedIndex==1)
            {
                if (rdAZ.Checked == true) dgvQuanLyThuoc.DataSource = QuanLyThuoc.SapXepThuocTheoTenDang(maList, 0);
                else dgvQuanLyThuoc.DataSource = QuanLyThuoc.SapXepThuocTheoTenDang(maList, 1);
            }
            if(cbbSort.SelectedIndex==2)
            {
                if(rdAZ.Checked==true) dgvQuanLyThuoc.DataSource = QuanLyThuoc.SapXepThuocTheoTenLoai(maList, 0);
                else dgvQuanLyThuoc.DataSource = QuanLyThuoc.SapXepThuocTheoTenLoai(maList, 1);
            }
        }
        void ThemThuocExcel()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel File|*.xls;*.xlsx;*.xlsm";
            if (open.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                FileStream stream = new FileStream(open.FileName, FileMode.Open);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet excel = excelReader.AsDataSet();
                QuanLyThuoc.ImportThuocExcel(excel);
                excelReader.Close();
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Bạn file này đang mở cho tiến trình khác");
                return;
            }

        }
        #endregion
        #region Events
        private void btnShow_Click(object sender, EventArgs e)
        {
            HienThiDatagridview();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            XoaThuoc();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int maCuoi = QuanLyThuoc.LayMaThuocLonNhat();
            int maThuoc = maCuoi + 1;
            string maMoi = "TH" + maThuoc;
            if (quyen == 2)
            {
                MessageBox.Show("Bạn không có quyền thêm", "Ngăn chặn", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            formQuanLyThuoc_Them fo = new formQuanLyThuoc_Them(maMoi);
            fo.On_HienThi += HienThiDatagridview;
            fo.ShowDialog();
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
            if (chon == 0)
            {
                TimKiemThuocTheoTen(txtSearch.Text);
            }
            else if (chon == 1)
            {
                TimKiemThuocTheoDang(txtSearch.Text);
            }
            else if (chon == 2)
            {
                TimKiemThuocTheoLoai(txtSearch.Text);
            }
            else return;
        }
        private void dgvQuanLyThuoc_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ma;
            ma = dgvQuanLyThuoc.SelectedRows[0].Cells[0].Value.ToString();
            ThongTin_Thuoc fo = new ThongTin_Thuoc(ma, quyen);
            fo.On_HienThi += HienThiDatagridview;
            fo.ShowDialog();
        }
        public delegate void HienThi_delegate();
        public HienThi_delegate On_HienThi;
        private void btnChon_Click(object sender, EventArgs e)
        {
            // loi~ chua hien thi thuoc ma da chon
            string maTH;
            maTH = dgvQuanLyThuoc.SelectedRows[0].Cells[0].Value.ToString();
            ChonSoluongThuoc fo = new ChonSoluongThuoc(maDT,maTH);
            fo.ShowDialog();
            if (On_HienThi != null) On_HienThi();
            this.Show();
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            ThemThuocExcel();
            HienThiDatagridview();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            HienThiDatagridview();
            XuatThuocExcel();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\QuanLyThuoc.txt");
        }
    }
    #endregion
}

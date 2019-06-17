using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;
using KeThuoc.Thuoc_BLL;
using KeThuoc.Thuoc_DAL;
using KeThuoc.Thuoc_GUI;
using System.IO;
using ExcelDataReader;
using System.Diagnostics;

namespace KeThuoc
{
    public partial class formQuanLyBacSi : Form
    {
        QuanLyBacSi_BLL QuanLyBacSi = new QuanLyBacSi_BLL();
        public formQuanLyBacSi()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        #region Methods
        //Load len combobox
        //Hien thi len datagridview
        void HienThiDatagridview()
        {
            dgvQLBS.DataSource = QuanLyBacSi.HienThiThongTin();
        }
        //Hien thi chi tiet thong tin len form
         void XoaBacSi()
        {
            DialogResult kq = MessageBox.Show("Xoá bác sĩ sẽ xoá mọi đơn thuốc liên quan đến bác sĩ," +
                " bạn có muốn xoá không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No)
            {
                return;
            }
            DataGridViewSelectedRowCollection tap = dgvQLBS.SelectedRows;
            string ma;
            List<string> maList = new List<string>();
            foreach (DataGridViewRow row in tap)
            {
                ma = row.Cells[0].Value.ToString();
                if (ma != "BS1") maList.Add(ma);
                else MessageBox.Show("Không thể xoá Admin", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            QuanLyBacSi.XoaBacSi(maList);
            HienThiDatagridview();
        }
         void TimKiemTheoTenBacSi(string ten)
        {
            dgvQLBS.DataSource = QuanLyBacSi.TimKiemTheoTenBacSi(ten);
        }
         void TimKiemTheoChucVu(string ten)
        {
            dgvQLBS.DataSource = QuanLyBacSi.TimKiemTheoChucVu(ten);
        }
         void TimKiemTheoKhoa(string ten)
        {
            dgvQLBS.DataSource = QuanLyBacSi.TimKiemTheoKhoa(ten);
        }
        void SapXep()
        { 
            List<string> maList = new List<string>();
             DataGridViewRowCollection rows = dgvQLBS.Rows;
            foreach (DataGridViewRow r in rows)
            {
                maList.Add(r.Cells[0].Value.ToString());
            }
            //chinh sua AZ ZA theo radiobutton va combox
            //Sap xep theo Chuc Vu
            if(cbbSort.SelectedIndex==2)
            {
                if(rdAZ.Checked==true)
                {
                    dgvQLBS.DataSource = QuanLyBacSi.SapXepBacSiTheoChucVu(maList, 0);
                }
                else dgvQLBS.DataSource = QuanLyBacSi.SapXepBacSiTheoChucVu(maList, 1);
            }
            //Sap xep theo Khoa
            if (cbbSort.SelectedIndex == 1)
            {
                if (rdAZ.Checked == true)
                {
                    dgvQLBS.DataSource = QuanLyBacSi.SapXepBacSiTheoKhoa(maList, 0);
                }
                else dgvQLBS.DataSource = QuanLyBacSi.SapXepBacSiTheoKhoa(maList, 1);
            }
            //Sap xep theo ten
            if (cbbSort.SelectedIndex == 0)
            {
                if (rdAZ.Checked == true)
                {
                    dgvQLBS.DataSource = QuanLyBacSi.SapXepBacSiTheoTen(maList, 0);
                }
                else dgvQLBS.DataSource = QuanLyBacSi.SapXepBacSiTheoTen(maList, 1);
            }
        }
        void ThemBacSiExcel()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Excel File|*.xls;*.xlsx;*.xlsm";
            if (open.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                FileStream stream = new FileStream(open.FileName, FileMode.Open);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet excel = excelReader.AsDataSet();
                QuanLyBacSi.ImportExcelBacSi(excel);

                excelReader.Close();
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Bạn file này đang mở cho tiến trình khác");
                return;
            }

        }
        public void XuatBacSiExcel()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook wb = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet ws = null;
            ws = wb.Sheets[1];
            ws = wb.ActiveSheet;
            ws.Name = "Info";
            for (int i = 1; i <= dgvQLBS.Columns.Count; i++)
            {
                ws.Cells[1, i] = dgvQLBS.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvQLBS.Rows.Count; i++)
            {
                for (int j = 0; j < dgvQLBS.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dgvQLBS.Rows[i].Cells[j].Value.ToString();
                }
            }
            var SaveFile = new SaveFileDialog();
            SaveFile.FileName = "exportBS";
            SaveFile.DefaultExt = ".xlsx";
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                wb.SaveAs(SaveFile.FileName, Type.Missing);
            }
            app.Quit();
            Process.Start(SaveFile.FileName);
        }
        #endregion
        #region Events
        private void formQuanLyBacSi_Load(object sender, EventArgs e)
        {

        }
        //Hien thi
        private void btnShow_Click(object sender, EventArgs e)
        {
            HienThiDatagridview();
        }
        //Xoa
        private void btnDel_Click(object sender, EventArgs e)
        {
            XoaBacSi();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int maCuoi = QuanLyBacSi.LayMaBSLonNhat();
            int maBS = maCuoi+1;
            string maMoi = "BS" + maBS;
           // MessageBox.Show(maMoi);
            formQuanLyBacSi_Them fo = new formQuanLyBacSi_Them(maMoi);
            fo.On_OKbutton += HienThiDatagridview;
            fo.ShowDialog();
            this.Show();
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            if(cbbSort.SelectedIndex<0)
            {
                MessageBox.Show("Bạn sắp xếp mục gì?");
                return;
            }
            if(rdAZ.Checked==false && rdZA.Checked ==false)
            {
                MessageBox.Show("Bạn sắp xếp theo thứ tự gì?");
                return;
            }
            SapXep();
        }
        private void dgvQLBS_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ma;
            ma = dgvQLBS.SelectedRows[0].Cells[0].Value.ToString();
            ThongTin_CaNhan fo = new ThongTin_CaNhan(ma,1);
            fo.On_HienThi += HienThiDatagridview;
            fo.ShowDialog();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picSearch_Click(object sender, EventArgs e)
        {
            if(cbbSearch.SelectedIndex <0 )
            {
                MessageBox.Show("Bạn tìm kiếm theo gì?");
                return;
            }
            if(txtSearch.Text=="")
            {
                MessageBox.Show("Hãy nhập từ muốn tìm");
                return;
            }
            string ten = txtSearch.Text;
            int chon = cbbSearch.SelectedIndex;
            if (chon == 0) TimKiemTheoTenBacSi(ten);
            else if (chon == 1) TimKiemTheoKhoa(ten);
            else if (chon == 2) TimKiemTheoChucVu(ten);
            else return;
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            ThemBacSiExcel();
            HienThiDatagridview();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            HienThiDatagridview();
            XuatBacSiExcel();
            
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\DotNet\ThayNguyen\TrangWebKeDonThuoc\Help\QuanLyBacSi.txt");
        }
    }
}

namespace KeThuoc
{
    partial class ThongTinDonThuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDonThuoc));
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDSThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.btn_TTBenhNhan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLamDon = new System.Windows.Forms.DateTimePicker();
            this.txtMaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenBacSi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaBacSi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDTBS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.btnTT_BacSi = new System.Windows.Forms.Button();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThuoc)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(201, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(418, 37);
            this.label9.TabIndex = 21;
            this.label9.Text = "THÔNG TIN ĐƠN THUỐC";
            // 
            // dgvDSThuoc
            // 
            this.dgvDSThuoc.AllowUserToAddRows = false;
            this.dgvDSThuoc.AllowUserToDeleteRows = false;
            this.dgvDSThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSThuoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSThuoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvDSThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThuoc.Location = new System.Drawing.Point(17, 23);
            this.dgvDSThuoc.Name = "dgvDSThuoc";
            this.dgvDSThuoc.ReadOnly = true;
            this.dgvDSThuoc.Size = new System.Drawing.Size(695, 161);
            this.dgvDSThuoc.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSThuoc);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(69, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 195);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thuốc đã kê";
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenBenhNhan.Enabled = false;
            this.txtTenBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.txtTenBenhNhan.Location = new System.Drawing.Point(123, 54);
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(235, 24);
            this.txtTenBenhNhan.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên bệnh nhân";
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaBenhNhan.Enabled = false;
            this.txtMaBenhNhan.ForeColor = System.Drawing.Color.Black;
            this.txtMaBenhNhan.Location = new System.Drawing.Point(123, 27);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.Size = new System.Drawing.Size(235, 24);
            this.txtMaBenhNhan.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã bệnh nhân";
            // 
            // txtSDTBN
            // 
            this.txtSDTBN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSDTBN.Enabled = false;
            this.txtSDTBN.ForeColor = System.Drawing.Color.Black;
            this.txtSDTBN.Location = new System.Drawing.Point(532, 29);
            this.txtSDTBN.Name = "txtSDTBN";
            this.txtSDTBN.Size = new System.Drawing.Size(234, 24);
            this.txtSDTBN.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Giới tính";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.BackColor = System.Drawing.Color.Transparent;
            this.rdbNu.Enabled = false;
            this.rdbNu.ForeColor = System.Drawing.Color.Black;
            this.rdbNu.Location = new System.Drawing.Point(593, 59);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 22);
            this.rdbNu.TabIndex = 12;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = false;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.BackColor = System.Drawing.Color.Transparent;
            this.rdbNam.Enabled = false;
            this.rdbNam.ForeColor = System.Drawing.Color.Black;
            this.rdbNam.Location = new System.Drawing.Point(531, 59);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 22);
            this.rdbNam.TabIndex = 11;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = false;
            // 
            // btn_TTBenhNhan
            // 
            this.btn_TTBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TTBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("btn_TTBenhNhan.Image")));
            this.btn_TTBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TTBenhNhan.Location = new System.Drawing.Point(299, 96);
            this.btn_TTBenhNhan.Name = "btn_TTBenhNhan";
            this.btn_TTBenhNhan.Size = new System.Drawing.Size(187, 48);
            this.btn_TTBenhNhan.TabIndex = 1;
            this.btn_TTBenhNhan.Text = "Nhấn để xem chi tiết";
            this.btn_TTBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TTBenhNhan.UseVisualStyleBackColor = true;
            this.btn_TTBenhNhan.Click += new System.EventHandler(this.btn_TTBenhNhan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_TTBenhNhan);
            this.groupBox2.Controls.Add(this.rdbNam);
            this.groupBox2.Controls.Add(this.rdbNu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSDTBN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaBenhNhan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTenBenhNhan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày làm đơn";
            // 
            // dtpNgayLamDon
            // 
            this.dtpNgayLamDon.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgayLamDon.Enabled = false;
            this.dtpNgayLamDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLamDon.Location = new System.Drawing.Point(561, 76);
            this.dtpNgayLamDon.Name = "dtpNgayLamDon";
            this.dtpNgayLamDon.Size = new System.Drawing.Size(236, 24);
            this.dtpNgayLamDon.TabIndex = 22;
            // 
            // txtMaDon
            // 
            this.txtMaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaDon.Enabled = false;
            this.txtMaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDon.ForeColor = System.Drawing.Color.Black;
            this.txtMaDon.Location = new System.Drawing.Point(152, 76);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(235, 24);
            this.txtMaDon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn";
            // 
            // txtTenBacSi
            // 
            this.txtTenBacSi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenBacSi.Enabled = false;
            this.txtTenBacSi.ForeColor = System.Drawing.Color.Black;
            this.txtTenBacSi.Location = new System.Drawing.Point(123, 58);
            this.txtTenBacSi.Name = "txtTenBacSi";
            this.txtTenBacSi.Size = new System.Drawing.Size(235, 24);
            this.txtTenBacSi.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên bác sĩ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Khoa";
            // 
            // txtMaBacSi
            // 
            this.txtMaBacSi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaBacSi.Enabled = false;
            this.txtMaBacSi.ForeColor = System.Drawing.Color.Black;
            this.txtMaBacSi.Location = new System.Drawing.Point(123, 32);
            this.txtMaBacSi.Name = "txtMaBacSi";
            this.txtMaBacSi.Size = new System.Drawing.Size(235, 24);
            this.txtMaBacSi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã bác sĩ";
            // 
            // txtSDTBS
            // 
            this.txtSDTBS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSDTBS.Enabled = false;
            this.txtSDTBS.ForeColor = System.Drawing.Color.Black;
            this.txtSDTBS.Location = new System.Drawing.Point(532, 61);
            this.txtSDTBS.Name = "txtSDTBS";
            this.txtSDTBS.Size = new System.Drawing.Size(234, 24);
            this.txtSDTBS.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số điện thoại";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbbKhoa.Enabled = false;
            this.cbbKhoa.ForeColor = System.Drawing.Color.Black;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(531, 31);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(235, 26);
            this.cbbKhoa.TabIndex = 2;
            // 
            // btnTT_BacSi
            // 
            this.btnTT_BacSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT_BacSi.Image = ((System.Drawing.Image)(resources.GetObject("btnTT_BacSi.Image")));
            this.btnTT_BacSi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTT_BacSi.Location = new System.Drawing.Point(299, 103);
            this.btnTT_BacSi.Name = "btnTT_BacSi";
            this.btnTT_BacSi.Size = new System.Drawing.Size(187, 49);
            this.btnTT_BacSi.TabIndex = 0;
            this.btnTT_BacSi.Text = "Nhấn để xem chi tiết";
            this.btnTT_BacSi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTT_BacSi.UseVisualStyleBackColor = true;
            this.btnTT_BacSi.Click += new System.EventHandler(this.btnTT_BacSi_Click);
            // 
            // gbThongTin
            // 
            this.gbThongTin.AutoSize = true;
            this.gbThongTin.Controls.Add(this.btnTT_BacSi);
            this.gbThongTin.Controls.Add(this.cbbKhoa);
            this.gbThongTin.Controls.Add(this.label8);
            this.gbThongTin.Controls.Add(this.txtSDTBS);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.txtMaBacSi);
            this.gbThongTin.Controls.Add(this.label7);
            this.gbThongTin.Controls.Add(this.label11);
            this.gbThongTin.Controls.Add(this.txtTenBacSi);
            this.gbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.Location = new System.Drawing.Point(29, 115);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(806, 177);
            this.gbThongTin.TabIndex = 15;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin bác sĩ";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(371, 695);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 42);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(760, 20);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 31);
            this.btnHelp.TabIndex = 24;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // ThongTinDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(847, 738);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dtpNgayLamDon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongTinDonThuoc";
            this.Text = "Thông tin đơn thuốc";
            this.Load += new System.EventHandler(this.ThongTinDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThuoc)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDSThuoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaBenhNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Button btn_TTBenhNhan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayLamDon;
        private System.Windows.Forms.TextBox txtMaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenBacSi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaBacSi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDTBS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.Button btnTT_BacSi;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHelp;
    }
}
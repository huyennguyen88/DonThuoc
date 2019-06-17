namespace KeThuoc
{
    partial class ThongKeDonThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDonThuoc));
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvTongDT = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTongSoDon = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.btnApDung1 = new System.Windows.Forms.Button();
            this.cbbLuaChon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateThis = new System.Windows.Forms.DateTimePicker();
            this.lbTu = new System.Windows.Forms.Label();
            this.lbDen = new System.Windows.Forms.Label();
            this.lbVao = new System.Windows.Forms.Label();
            this.btnApDung2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Green;
            this.Label1.Location = new System.Drawing.Point(258, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(347, 31);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "THỐNG KÊ ĐƠN THUỐC";
            // 
            // dgvTongDT
            // 
            this.dgvTongDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTongDT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTongDT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvTongDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongDT.Location = new System.Drawing.Point(6, 19);
            this.dgvTongDT.Name = "dgvTongDT";
            this.dgvTongDT.Size = new System.Drawing.Size(854, 202);
            this.dgvTongDT.TabIndex = 5;
            this.dgvTongDT.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTongDT_RowHeaderMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng số đơn";
            // 
            // lbTongSoDon
            // 
            this.lbTongSoDon.AutoSize = true;
            this.lbTongSoDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoDon.Location = new System.Drawing.Point(122, 54);
            this.lbTongSoDon.Name = "lbTongSoDon";
            this.lbTongSoDon.Size = new System.Drawing.Size(35, 20);
            this.lbTongSoDon.TabIndex = 6;
            this.lbTongSoDon.Text = "xuly";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(16, 341);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(347, 315);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(172, 20);
            this.dateFrom.TabIndex = 8;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(569, 315);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(172, 20);
            this.dateTo.TabIndex = 8;
            // 
            // btnApDung1
            // 
            this.btnApDung1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDung1.Image = ((System.Drawing.Image)(resources.GetObject("btnApDung1.Image")));
            this.btnApDung1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApDung1.Location = new System.Drawing.Point(757, 308);
            this.btnApDung1.Name = "btnApDung1";
            this.btnApDung1.Size = new System.Drawing.Size(109, 32);
            this.btnApDung1.TabIndex = 18;
            this.btnApDung1.Text = "Áp dụng";
            this.btnApDung1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApDung1.UseVisualStyleBackColor = true;
            this.btnApDung1.Click += new System.EventHandler(this.btnApDung1_Click);
            // 
            // cbbLuaChon
            // 
            this.cbbLuaChon.FormattingEnabled = true;
            this.cbbLuaChon.Items.AddRange(new object[] {
            "Toàn bộ",
            "Ngày",
            "Từ ngày đến ngày"});
            this.cbbLuaChon.Location = new System.Drawing.Point(133, 315);
            this.cbbLuaChon.Name = "cbbLuaChon";
            this.cbbLuaChon.Size = new System.Drawing.Size(170, 21);
            this.cbbLuaChon.TabIndex = 19;
            this.cbbLuaChon.SelectedIndexChanged += new System.EventHandler(this.cbbLuaChon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // dateThis
            // 
            this.dateThis.Location = new System.Drawing.Point(569, 315);
            this.dateThis.Name = "dateThis";
            this.dateThis.Size = new System.Drawing.Size(172, 20);
            this.dateThis.TabIndex = 8;
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTu.Location = new System.Drawing.Point(314, 315);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(27, 18);
            this.lbTu.TabIndex = 20;
            this.lbTu.Text = "Từ";
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDen.Location = new System.Drawing.Point(525, 317);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(38, 18);
            this.lbDen.TabIndex = 20;
            this.lbDen.Text = "Đến";
            // 
            // lbVao
            // 
            this.lbVao.AutoSize = true;
            this.lbVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVao.Location = new System.Drawing.Point(525, 317);
            this.lbVao.Name = "lbVao";
            this.lbVao.Size = new System.Drawing.Size(37, 18);
            this.lbVao.TabIndex = 20;
            this.lbVao.Text = "Vào";
            // 
            // btnApDung2
            // 
            this.btnApDung2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApDung2.Image = ((System.Drawing.Image)(resources.GetObject("btnApDung2.Image")));
            this.btnApDung2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApDung2.Location = new System.Drawing.Point(757, 310);
            this.btnApDung2.Name = "btnApDung2";
            this.btnApDung2.Size = new System.Drawing.Size(109, 32);
            this.btnApDung2.TabIndex = 18;
            this.btnApDung2.Text = "Áp dụng";
            this.btnApDung2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApDung2.UseVisualStyleBackColor = true;
            this.btnApDung2.Click += new System.EventHandler(this.btnApDung2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTongDT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 227);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(797, 40);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 31);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // ThongKeDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(878, 381);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.lbVao);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbLuaChon);
            this.Controls.Add(this.btnApDung2);
            this.Controls.Add(this.btnApDung1);
            this.Controls.Add(this.dateThis);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbTongSoDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKeDonThuoc";
            this.Text = "Thông kê đơn thuốc";
            this.Load += new System.EventHandler(this.ThongKeDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dgvTongDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTongSoDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Button btnApDung1;
        private System.Windows.Forms.ComboBox cbbLuaChon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateThis;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.Label lbVao;
        private System.Windows.Forms.Button btnApDung2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHelp;
    }
}
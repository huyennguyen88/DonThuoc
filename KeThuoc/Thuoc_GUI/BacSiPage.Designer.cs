namespace KeThuoc
{
    partial class BacSiPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BacSiPage));
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnBenhNhan = new System.Windows.Forms.Button();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.labelXinChao = new System.Windows.Forms.Label();
            this.btnKhoThuoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntHelp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnThongTin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.Crimson;
            this.btnThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Image")));
            this.btnThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTin.Location = new System.Drawing.Point(8, 227);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(257, 64);
            this.btnThongTin.TabIndex = 0;
            this.btnThongTin.Text = "Thông tin cá nhân";
            this.btnThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnBenhNhan
            // 
            this.btnBenhNhan.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBenhNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBenhNhan.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenhNhan.ForeColor = System.Drawing.Color.Crimson;
            this.btnBenhNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnBenhNhan.Image")));
            this.btnBenhNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBenhNhan.Location = new System.Drawing.Point(270, 227);
            this.btnBenhNhan.Name = "btnBenhNhan";
            this.btnBenhNhan.Size = new System.Drawing.Size(257, 64);
            this.btnBenhNhan.TabIndex = 1;
            this.btnBenhNhan.Text = "Thông tin bệnh nhân";
            this.btnBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBenhNhan.UseVisualStyleBackColor = false;
            this.btnBenhNhan.Click += new System.EventHandler(this.btnBenhNhan_Click);
            // 
            // btDangXuat
            // 
            this.btDangXuat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDangXuat.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btDangXuat.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btDangXuat.Image")));
            this.btDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDangXuat.Location = new System.Drawing.Point(373, 297);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(154, 64);
            this.btDangXuat.TabIndex = 4;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDangXuat.UseVisualStyleBackColor = true;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // labelXinChao
            // 
            this.labelXinChao.AutoSize = true;
            this.labelXinChao.BackColor = System.Drawing.Color.Transparent;
            this.labelXinChao.Font = new System.Drawing.Font("NewCentury-Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelXinChao.ForeColor = System.Drawing.Color.Crimson;
            this.labelXinChao.Location = new System.Drawing.Point(23, 147);
            this.labelXinChao.Name = "labelXinChao";
            this.labelXinChao.Size = new System.Drawing.Size(95, 25);
            this.labelXinChao.TabIndex = 26;
            this.labelXinChao.Text = "Tên bác sĩ";
            // 
            // btnKhoThuoc
            // 
            this.btnKhoThuoc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnKhoThuoc.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoThuoc.ForeColor = System.Drawing.Color.Crimson;
            this.btnKhoThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoThuoc.Image")));
            this.btnKhoThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoThuoc.Location = new System.Drawing.Point(8, 297);
            this.btnKhoThuoc.Name = "btnKhoThuoc";
            this.btnKhoThuoc.Size = new System.Drawing.Size(257, 64);
            this.btnKhoThuoc.TabIndex = 3;
            this.btnKhoThuoc.Text = "Thông tin kho thuốc";
            this.btnKhoThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhoThuoc.UseVisualStyleBackColor = false;
            this.btnKhoThuoc.Click += new System.EventHandler(this.btnKhoThuoc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelXinChao);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 213);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(158, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "TRANG BÁC SĨ";
            // 
            // bntHelp
            // 
            this.bntHelp.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.bntHelp.ForeColor = System.Drawing.Color.DarkOrchid;
            this.bntHelp.Location = new System.Drawing.Point(271, 297);
            this.bntHelp.Name = "bntHelp";
            this.bntHelp.Size = new System.Drawing.Size(96, 64);
            this.bntHelp.TabIndex = 29;
            this.bntHelp.Text = "Trợ giúp";
            this.bntHelp.UseVisualStyleBackColor = true;
            this.bntHelp.Click += new System.EventHandler(this.bntHelp_Click);
            // 
            // BacSiPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.CancelButton = this.btDangXuat;
            this.ClientSize = new System.Drawing.Size(533, 391);
            this.Controls.Add(this.bntHelp);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDangXuat);
            this.Controls.Add(this.btnBenhNhan);
            this.Controls.Add(this.btnKhoThuoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BacSiPage";
            this.Text = "Bác sĩ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnBenhNhan;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Label labelXinChao;
        private System.Windows.Forms.Button btnKhoThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntHelp;
    }
}
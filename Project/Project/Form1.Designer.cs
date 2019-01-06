namespace Project
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gb_ttphieukham = new System.Windows.Forms.GroupBox();
            this.txt_pk_trc = new System.Windows.Forms.TextBox();
            this.txt_pk_trchung = new System.Windows.Forms.TextBox();
            this.txt_pk_ngayk = new System.Windows.Forms.TextBox();
            this.txt_pk_stt = new System.Windows.Forms.TextBox();
            this.txt_pk_hoten = new System.Windows.Forms.TextBox();
            this.txt_pk_mabn = new System.Windows.Forms.TextBox();
            this.lb_pk_chuandoan = new System.Windows.Forms.Label();
            this.lb_pk_trchung = new System.Windows.Forms.Label();
            this.lb_pk_nk = new System.Windows.Forms.Label();
            this.lb_pk_stt = new System.Windows.Forms.Label();
            this.lb_pk_hoten = new System.Windows.Forms.Label();
            this.lb_pk_mabn = new System.Windows.Forms.Label();
            this.lb_pk_mapk = new System.Windows.Forms.Label();
            this.txt_pk_mapk = new System.Windows.Forms.TextBox();
            this.lb_pk_danhsach = new System.Windows.Forms.Label();
            this.dgv_phieukham = new System.Windows.Forms.DataGridView();
            this.btn_pk_huy = new System.Windows.Forms.Button();
            this.btn_pk_luu = new System.Windows.Forms.Button();
            this.btn_pk_xoa = new System.Windows.Forms.Button();
            this.btn_pk_sua = new System.Windows.Forms.Button();
            this.btn_pk_them = new System.Windows.Forms.Button();
            this.lb_phieukham = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.lb_tracuubenhnhan = new System.Windows.Forms.Label();
            this.dgv_TCBN = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txt_tracuu = new System.Windows.Forms.TextBox();
            this.tb_maBN_tc = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gb_ttphieukham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieukham)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TCBN)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(28, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 348);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách khám bệnh";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gb_ttphieukham);
            this.tabPage2.Controls.Add(this.lb_pk_danhsach);
            this.tabPage2.Controls.Add(this.dgv_phieukham);
            this.tabPage2.Controls.Add(this.btn_pk_huy);
            this.tabPage2.Controls.Add(this.btn_pk_luu);
            this.tabPage2.Controls.Add(this.btn_pk_xoa);
            this.tabPage2.Controls.Add(this.btn_pk_sua);
            this.tabPage2.Controls.Add(this.btn_pk_them);
            this.tabPage2.Controls.Add(this.lb_phieukham);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu khám bệnh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gb_ttphieukham
            // 
            this.gb_ttphieukham.Controls.Add(this.txt_pk_trc);
            this.gb_ttphieukham.Controls.Add(this.txt_pk_trchung);
            this.gb_ttphieukham.Controls.Add(this.txt_pk_ngayk);
            this.gb_ttphieukham.Controls.Add(this.txt_pk_stt);
            this.gb_ttphieukham.Controls.Add(this.txt_pk_hoten);
            this.gb_ttphieukham.Controls.Add(this.txt_pk_mabn);
            this.gb_ttphieukham.Controls.Add(this.lb_pk_chuandoan);
            this.gb_ttphieukham.Controls.Add(this.lb_pk_trchung);
            this.gb_ttphieukham.Controls.Add(this.lb_pk_nk);
            this.gb_ttphieukham.Controls.Add(this.lb_pk_stt);
            this.gb_ttphieukham.Controls.Add(this.lb_pk_hoten);
            this.gb_ttphieukham.Controls.Add(this.lb_pk_mabn);
            this.gb_ttphieukham.Controls.Add(this.lb_pk_mapk);
            this.gb_ttphieukham.Controls.Add(this.txt_pk_mapk);
            this.gb_ttphieukham.Location = new System.Drawing.Point(65, 36);
            this.gb_ttphieukham.Name = "gb_ttphieukham";
            this.gb_ttphieukham.Size = new System.Drawing.Size(690, 175);
            this.gb_ttphieukham.TabIndex = 24;
            this.gb_ttphieukham.TabStop = false;
            this.gb_ttphieukham.Text = "Thông Tin Phiếu Khám";
            // 
            // txt_pk_trc
            // 
            this.txt_pk_trc.Location = new System.Drawing.Point(348, 140);
            this.txt_pk_trc.Name = "txt_pk_trc";
            this.txt_pk_trc.Size = new System.Drawing.Size(105, 20);
            this.txt_pk_trc.TabIndex = 16;
            // 
            // txt_pk_trchung
            // 
            this.txt_pk_trchung.Location = new System.Drawing.Point(348, 93);
            this.txt_pk_trchung.Name = "txt_pk_trchung";
            this.txt_pk_trchung.Size = new System.Drawing.Size(105, 20);
            this.txt_pk_trchung.TabIndex = 15;
            // 
            // txt_pk_ngayk
            // 
            this.txt_pk_ngayk.Location = new System.Drawing.Point(527, 44);
            this.txt_pk_ngayk.Name = "txt_pk_ngayk";
            this.txt_pk_ngayk.Size = new System.Drawing.Size(105, 20);
            this.txt_pk_ngayk.TabIndex = 14;
            // 
            // txt_pk_stt
            // 
            this.txt_pk_stt.Location = new System.Drawing.Point(348, 48);
            this.txt_pk_stt.Name = "txt_pk_stt";
            this.txt_pk_stt.Size = new System.Drawing.Size(105, 20);
            this.txt_pk_stt.TabIndex = 13;
            // 
            // txt_pk_hoten
            // 
            this.txt_pk_hoten.Location = new System.Drawing.Point(82, 136);
            this.txt_pk_hoten.Name = "txt_pk_hoten";
            this.txt_pk_hoten.Size = new System.Drawing.Size(105, 20);
            this.txt_pk_hoten.TabIndex = 12;
            // 
            // txt_pk_mabn
            // 
            this.txt_pk_mabn.Location = new System.Drawing.Point(82, 90);
            this.txt_pk_mabn.Name = "txt_pk_mabn";
            this.txt_pk_mabn.Size = new System.Drawing.Size(105, 20);
            this.txt_pk_mabn.TabIndex = 11;
            // 
            // lb_pk_chuandoan
            // 
            this.lb_pk_chuandoan.AutoSize = true;
            this.lb_pk_chuandoan.Location = new System.Drawing.Point(269, 139);
            this.lb_pk_chuandoan.Name = "lb_pk_chuandoan";
            this.lb_pk_chuandoan.Size = new System.Drawing.Size(67, 13);
            this.lb_pk_chuandoan.TabIndex = 9;
            this.lb_pk_chuandoan.Text = "Chuẩn Đoán";
            // 
            // lb_pk_trchung
            // 
            this.lb_pk_trchung.AutoSize = true;
            this.lb_pk_trchung.Location = new System.Drawing.Point(269, 93);
            this.lb_pk_trchung.Name = "lb_pk_trchung";
            this.lb_pk_trchung.Size = new System.Drawing.Size(65, 13);
            this.lb_pk_trchung.TabIndex = 8;
            this.lb_pk_trchung.Text = "Triệu Chứng";
            // 
            // lb_pk_nk
            // 
            this.lb_pk_nk.AutoSize = true;
            this.lb_pk_nk.Location = new System.Drawing.Point(459, 47);
            this.lb_pk_nk.Name = "lb_pk_nk";
            this.lb_pk_nk.Size = new System.Drawing.Size(62, 13);
            this.lb_pk_nk.TabIndex = 7;
            this.lb_pk_nk.Text = "Ngày Khám";
            // 
            // lb_pk_stt
            // 
            this.lb_pk_stt.AutoSize = true;
            this.lb_pk_stt.Location = new System.Drawing.Point(277, 51);
            this.lb_pk_stt.Name = "lb_pk_stt";
            this.lb_pk_stt.Size = new System.Drawing.Size(28, 13);
            this.lb_pk_stt.TabIndex = 6;
            this.lb_pk_stt.Text = "STT";
            // 
            // lb_pk_hoten
            // 
            this.lb_pk_hoten.AutoSize = true;
            this.lb_pk_hoten.Location = new System.Drawing.Point(20, 143);
            this.lb_pk_hoten.Name = "lb_pk_hoten";
            this.lb_pk_hoten.Size = new System.Drawing.Size(61, 13);
            this.lb_pk_hoten.TabIndex = 5;
            this.lb_pk_hoten.Text = "Họ Tên BN";
            // 
            // lb_pk_mabn
            // 
            this.lb_pk_mabn.AutoSize = true;
            this.lb_pk_mabn.Location = new System.Drawing.Point(20, 93);
            this.lb_pk_mabn.Name = "lb_pk_mabn";
            this.lb_pk_mabn.Size = new System.Drawing.Size(40, 13);
            this.lb_pk_mabn.TabIndex = 4;
            this.lb_pk_mabn.Text = "Mã BN";
            // 
            // lb_pk_mapk
            // 
            this.lb_pk_mapk.AutoSize = true;
            this.lb_pk_mapk.Location = new System.Drawing.Point(20, 51);
            this.lb_pk_mapk.Name = "lb_pk_mapk";
            this.lb_pk_mapk.Size = new System.Drawing.Size(39, 13);
            this.lb_pk_mapk.TabIndex = 3;
            this.lb_pk_mapk.Text = "Mã PK";
            // 
            // txt_pk_mapk
            // 
            this.txt_pk_mapk.Location = new System.Drawing.Point(82, 47);
            this.txt_pk_mapk.Name = "txt_pk_mapk";
            this.txt_pk_mapk.Size = new System.Drawing.Size(105, 20);
            this.txt_pk_mapk.TabIndex = 0;
            // 
            // lb_pk_danhsach
            // 
            this.lb_pk_danhsach.AutoSize = true;
            this.lb_pk_danhsach.Location = new System.Drawing.Point(14, 242);
            this.lb_pk_danhsach.Name = "lb_pk_danhsach";
            this.lb_pk_danhsach.Size = new System.Drawing.Size(121, 13);
            this.lb_pk_danhsach.TabIndex = 23;
            this.lb_pk_danhsach.Text = "Danh Sách Phiếu Khám";
            // 
            // dgv_phieukham
            // 
            this.dgv_phieukham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieukham.Location = new System.Drawing.Point(17, 258);
            this.dgv_phieukham.Name = "dgv_phieukham";
            this.dgv_phieukham.Size = new System.Drawing.Size(738, 48);
            this.dgv_phieukham.TabIndex = 22;
            // 
            // btn_pk_huy
            // 
            this.btn_pk_huy.Location = new System.Drawing.Point(523, 213);
            this.btn_pk_huy.Name = "btn_pk_huy";
            this.btn_pk_huy.Size = new System.Drawing.Size(64, 25);
            this.btn_pk_huy.TabIndex = 21;
            this.btn_pk_huy.Text = "Hủy";
            this.btn_pk_huy.UseVisualStyleBackColor = true;
            // 
            // btn_pk_luu
            // 
            this.btn_pk_luu.Location = new System.Drawing.Point(440, 213);
            this.btn_pk_luu.Name = "btn_pk_luu";
            this.btn_pk_luu.Size = new System.Drawing.Size(64, 25);
            this.btn_pk_luu.TabIndex = 20;
            this.btn_pk_luu.Text = "Lưu";
            this.btn_pk_luu.UseVisualStyleBackColor = true;
            // 
            // btn_pk_xoa
            // 
            this.btn_pk_xoa.Location = new System.Drawing.Point(362, 213);
            this.btn_pk_xoa.Name = "btn_pk_xoa";
            this.btn_pk_xoa.Size = new System.Drawing.Size(64, 25);
            this.btn_pk_xoa.TabIndex = 19;
            this.btn_pk_xoa.Text = "Xóa";
            this.btn_pk_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_pk_sua
            // 
            this.btn_pk_sua.Location = new System.Drawing.Point(279, 213);
            this.btn_pk_sua.Name = "btn_pk_sua";
            this.btn_pk_sua.Size = new System.Drawing.Size(64, 25);
            this.btn_pk_sua.TabIndex = 18;
            this.btn_pk_sua.Text = "Sửa";
            this.btn_pk_sua.UseVisualStyleBackColor = true;
            // 
            // btn_pk_them
            // 
            this.btn_pk_them.Location = new System.Drawing.Point(189, 213);
            this.btn_pk_them.Name = "btn_pk_them";
            this.btn_pk_them.Size = new System.Drawing.Size(64, 25);
            this.btn_pk_them.TabIndex = 17;
            this.btn_pk_them.Text = "Thêm";
            this.btn_pk_them.UseVisualStyleBackColor = true;
            // 
            // lb_phieukham
            // 
            this.lb_phieukham.AutoSize = true;
            this.lb_phieukham.Location = new System.Drawing.Point(334, 20);
            this.lb_phieukham.Name = "lb_phieukham";
            this.lb_phieukham.Size = new System.Drawing.Size(92, 13);
            this.lb_phieukham.TabIndex = 1;
            this.lb_phieukham.Text = "Phiếu Khám Bệnh";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_tracuu);
            this.tabPage3.Controls.Add(this.tb_maBN_tc);
            this.tabPage3.Controls.Add(this.btn_timkiem);
            this.tabPage3.Controls.Add(this.lb_tracuubenhnhan);
            this.tabPage3.Controls.Add(this.dgv_TCBN);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tra cứu bệnh nhân";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(593, 61);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(64, 25);
            this.btn_timkiem.TabIndex = 28;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // lb_tracuubenhnhan
            // 
            this.lb_tracuubenhnhan.AutoSize = true;
            this.lb_tracuubenhnhan.Location = new System.Drawing.Point(33, 235);
            this.lb_tracuubenhnhan.Name = "lb_tracuubenhnhan";
            this.lb_tracuubenhnhan.Size = new System.Drawing.Size(118, 13);
            this.lb_tracuubenhnhan.TabIndex = 27;
            this.lb_tracuubenhnhan.Text = "Danh Sách Bệnh Nhân";
            // 
            // dgv_TCBN
            // 
            this.dgv_TCBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TCBN.Location = new System.Drawing.Point(36, 251);
            this.dgv_TCBN.Name = "dgv_TCBN";
            this.dgv_TCBN.Size = new System.Drawing.Size(738, 48);
            this.dgv_TCBN.TabIndex = 26;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(789, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Lập Hóa đơn";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(789, 322);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Lập báo cáo";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // txt_tracuu
            // 
            this.txt_tracuu.Location = new System.Drawing.Point(262, 64);
            this.txt_tracuu.Name = "txt_tracuu";
            this.txt_tracuu.Size = new System.Drawing.Size(302, 20);
            this.txt_tracuu.TabIndex = 11;
            // 
            // tb_maBN_tc
            // 
            this.tb_maBN_tc.AutoSize = true;
            this.tb_maBN_tc.Location = new System.Drawing.Point(144, 64);
            this.tb_maBN_tc.Name = "tb_maBN_tc";
            this.tb_maBN_tc.Size = new System.Drawing.Size(40, 13);
            this.tb_maBN_tc.TabIndex = 4;
            this.tb_maBN_tc.Text = "Mã BN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 480);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gb_ttphieukham.ResumeLayout(false);
            this.gb_ttphieukham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieukham)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TCBN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox gb_ttphieukham;
        private System.Windows.Forms.TextBox txt_pk_trc;
        private System.Windows.Forms.TextBox txt_pk_trchung;
        private System.Windows.Forms.TextBox txt_pk_ngayk;
        private System.Windows.Forms.TextBox txt_pk_stt;
        private System.Windows.Forms.TextBox txt_pk_hoten;
        private System.Windows.Forms.TextBox txt_pk_mabn;
        private System.Windows.Forms.Label lb_pk_chuandoan;
        private System.Windows.Forms.Label lb_pk_trchung;
        private System.Windows.Forms.Label lb_pk_nk;
        private System.Windows.Forms.Label lb_pk_stt;
        private System.Windows.Forms.Label lb_pk_hoten;
        private System.Windows.Forms.Label lb_pk_mabn;
        private System.Windows.Forms.Label lb_pk_mapk;
        private System.Windows.Forms.TextBox txt_pk_mapk;
        private System.Windows.Forms.Label lb_pk_danhsach;
        private System.Windows.Forms.DataGridView dgv_phieukham;
        private System.Windows.Forms.Button btn_pk_huy;
        private System.Windows.Forms.Button btn_pk_luu;
        private System.Windows.Forms.Button btn_pk_xoa;
        private System.Windows.Forms.Button btn_pk_sua;
        private System.Windows.Forms.Button btn_pk_them;
        private System.Windows.Forms.Label lb_phieukham;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label lb_tracuubenhnhan;
        private System.Windows.Forms.DataGridView dgv_TCBN;
        private System.Windows.Forms.TextBox txt_tracuu;
        private System.Windows.Forms.Label tb_maBN_tc;
    }
}


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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBN = new System.Windows.Forms.DataGridView();
            this.bttnLuu = new System.Windows.Forms.Button();
            this.btbSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.DateBorn = new System.Windows.Forms.DateTimePicker();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.txDiaChi = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.tbMaBN = new System.Windows.Forms.TextBox();
            this.lbMaBN = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gvListHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.btnmHoaDon = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.tbTienThuoc = new System.Windows.Forms.TextBox();
            this.cbbMaToaThuoc = new System.Windows.Forms.ComboBox();
            this.DateBan = new System.Windows.Forms.DateTimePicker();
            this.tbMaHoaDon = new System.Windows.Forms.TextBox();
            this.lbTienThuoc = new System.Windows.Forms.Label();
            this.lbMaToaThuoc = new System.Windows.Forms.Label();
            this.lbNgayBan = new System.Windows.Forms.Label();
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBN)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListHoaDon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
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
            this.tabControl1.Location = new System.Drawing.Point(28, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 534);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách khám bệnh";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bttnLuu);
            this.groupBox1.Controls.Add(this.btbSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.tbSDT);
            this.groupBox1.Controls.Add(this.DateBorn);
            this.groupBox1.Controls.Add(this.lbSDT);
            this.groupBox1.Controls.Add(this.lbNgaySinh);
            this.groupBox1.Controls.Add(this.txDiaChi);
            this.groupBox1.Controls.Add(this.tbHoTen);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbHoTen);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.lbGioiTinh);
            this.groupBox1.Controls.Add(this.tbMaBN);
            this.groupBox1.Controls.Add(this.lbMaBN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBN);
            this.groupBox2.Location = new System.Drawing.Point(4, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(975, 242);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bệnh nhân";
            // 
            // listBN
            // 
            this.listBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBN.Location = new System.Drawing.Point(23, 26);
            this.listBN.Name = "listBN";
            this.listBN.Size = new System.Drawing.Size(946, 202);
            this.listBN.TabIndex = 0;
            // 
            // bttnLuu
            // 
            this.bttnLuu.Location = new System.Drawing.Point(605, 175);
            this.bttnLuu.Name = "bttnLuu";
            this.bttnLuu.Size = new System.Drawing.Size(74, 37);
            this.bttnLuu.TabIndex = 15;
            this.bttnLuu.Text = "Lưu";
            this.bttnLuu.UseVisualStyleBackColor = true;
            // 
            // btbSua
            // 
            this.btbSua.Location = new System.Drawing.Point(469, 175);
            this.btbSua.Name = "btbSua";
            this.btbSua.Size = new System.Drawing.Size(74, 37);
            this.btbSua.TabIndex = 14;
            this.btbSua.Text = "Sửa";
            this.btbSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(338, 175);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 37);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(200, 175);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 37);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(776, 113);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(198, 27);
            this.tbSDT.TabIndex = 11;
            // 
            // DateBorn
            // 
            this.DateBorn.Location = new System.Drawing.Point(777, 46);
            this.DateBorn.Name = "DateBorn";
            this.DateBorn.Size = new System.Drawing.Size(199, 27);
            this.DateBorn.TabIndex = 10;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(657, 118);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(120, 22);
            this.lbSDT.TabIndex = 9;
            this.lbSDT.Text = "Số điện thoại:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(657, 49);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(98, 22);
            this.lbNgaySinh.TabIndex = 8;
            this.lbNgaySinh.Text = "Ngày Sinh:";
            this.lbNgaySinh.Click += new System.EventHandler(this.label5_Click);
            // 
            // txDiaChi
            // 
            this.txDiaChi.Location = new System.Drawing.Point(395, 110);
            this.txDiaChi.Name = "txDiaChi";
            this.txDiaChi.Size = new System.Drawing.Size(228, 27);
            this.txDiaChi.TabIndex = 7;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(395, 46);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(228, 27);
            this.tbHoTen.TabIndex = 6;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(303, 118);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(74, 22);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Địa Chỉ:";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(302, 49);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(75, 22);
            this.lbHoTen.TabIndex = 4;
            this.lbHoTen.Text = "Họ Tên:";
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(117, 110);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(131, 30);
            this.cbbGioiTinh.TabIndex = 3;
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(6, 118);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(81, 22);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "Giới tính:";
            // 
            // tbMaBN
            // 
            this.tbMaBN.Location = new System.Drawing.Point(117, 46);
            this.tbMaBN.Name = "tbMaBN";
            this.tbMaBN.Size = new System.Drawing.Size(131, 27);
            this.tbMaBN.TabIndex = 1;
            // 
            // lbMaBN
            // 
            this.lbMaBN.AutoSize = true;
            this.lbMaBN.Location = new System.Drawing.Point(6, 49);
            this.lbMaBN.Name = "lbMaBN";
            this.lbMaBN.Size = new System.Drawing.Size(69, 22);
            this.lbMaBN.TabIndex = 0;
            this.lbMaBN.Text = "Mã BN:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phiếu khám bệnh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(982, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tra cứu bệnh nhân";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(982, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Lập Hóa đơn";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gvListHoaDon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox4.Location = new System.Drawing.Point(10, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(936, 221);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hóa đơn";
            // 
            // gvListHoaDon
            // 
            this.gvListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListHoaDon.Location = new System.Drawing.Point(13, 51);
            this.gvListHoaDon.Name = "gvListHoaDon";
            this.gvListHoaDon.Size = new System.Drawing.Size(901, 157);
            this.gvListHoaDon.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLuuHoaDon);
            this.groupBox3.Controls.Add(this.btnmHoaDon);
            this.groupBox3.Controls.Add(this.btnTao);
            this.groupBox3.Controls.Add(this.btnXoaHoaDon);
            this.groupBox3.Controls.Add(this.tbTienThuoc);
            this.groupBox3.Controls.Add(this.cbbMaToaThuoc);
            this.groupBox3.Controls.Add(this.DateBan);
            this.groupBox3.Controls.Add(this.tbMaHoaDon);
            this.groupBox3.Controls.Add(this.lbTienThuoc);
            this.groupBox3.Controls.Add(this.lbMaToaThuoc);
            this.groupBox3.Controls.Add(this.lbNgayBan);
            this.groupBox3.Controls.Add(this.lbMaHoaDon);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.groupBox3.Location = new System.Drawing.Point(7, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(939, 206);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Hóa Đơn";
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(619, 164);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(129, 36);
            this.btnLuuHoaDon.TabIndex = 11;
            this.btnLuuHoaDon.Text = "Lưu Hóa Đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnmHoaDon
            // 
            this.btnmHoaDon.Location = new System.Drawing.Point(465, 164);
            this.btnmHoaDon.Name = "btnmHoaDon";
            this.btnmHoaDon.Size = new System.Drawing.Size(116, 36);
            this.btnmHoaDon.TabIndex = 10;
            this.btnmHoaDon.Text = "In Hóa đơn";
            this.btnmHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(142, 164);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(116, 36);
            this.btnTao.TabIndex = 8;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Location = new System.Drawing.Point(306, 164);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(116, 36);
            this.btnXoaHoaDon.TabIndex = 9;
            this.btnXoaHoaDon.Text = "Xóa";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // tbTienThuoc
            // 
            this.tbTienThuoc.Location = new System.Drawing.Point(584, 102);
            this.tbTienThuoc.Name = "tbTienThuoc";
            this.tbTienThuoc.Size = new System.Drawing.Size(211, 27);
            this.tbTienThuoc.TabIndex = 7;
            // 
            // cbbMaToaThuoc
            // 
            this.cbbMaToaThuoc.FormattingEnabled = true;
            this.cbbMaToaThuoc.Location = new System.Drawing.Point(585, 48);
            this.cbbMaToaThuoc.Name = "cbbMaToaThuoc";
            this.cbbMaToaThuoc.Size = new System.Drawing.Size(211, 30);
            this.cbbMaToaThuoc.TabIndex = 6;
            // 
            // DateBan
            // 
            this.DateBan.Location = new System.Drawing.Point(158, 99);
            this.DateBan.Name = "DateBan";
            this.DateBan.Size = new System.Drawing.Size(206, 27);
            this.DateBan.TabIndex = 5;
            // 
            // tbMaHoaDon
            // 
            this.tbMaHoaDon.Location = new System.Drawing.Point(158, 47);
            this.tbMaHoaDon.Name = "tbMaHoaDon";
            this.tbMaHoaDon.Size = new System.Drawing.Size(208, 27);
            this.tbMaHoaDon.TabIndex = 4;
            // 
            // lbTienThuoc
            // 
            this.lbTienThuoc.AutoSize = true;
            this.lbTienThuoc.Location = new System.Drawing.Point(433, 104);
            this.lbTienThuoc.Name = "lbTienThuoc";
            this.lbTienThuoc.Size = new System.Drawing.Size(107, 22);
            this.lbTienThuoc.TabIndex = 3;
            this.lbTienThuoc.Text = "Tiền Thuốc:";
            // 
            // lbMaToaThuoc
            // 
            this.lbMaToaThuoc.AutoSize = true;
            this.lbMaToaThuoc.Location = new System.Drawing.Point(433, 52);
            this.lbMaToaThuoc.Name = "lbMaToaThuoc";
            this.lbMaToaThuoc.Size = new System.Drawing.Size(132, 22);
            this.lbMaToaThuoc.TabIndex = 2;
            this.lbMaToaThuoc.Text = "Mã Toa Thuốc:";
            // 
            // lbNgayBan
            // 
            this.lbNgayBan.AutoSize = true;
            this.lbNgayBan.Location = new System.Drawing.Point(28, 104);
            this.lbNgayBan.Name = "lbNgayBan";
            this.lbNgayBan.Size = new System.Drawing.Size(94, 22);
            this.lbNgayBan.TabIndex = 1;
            this.lbNgayBan.Text = "Ngày Bán:";
            // 
            // lbMaHoaDon
            // 
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Location = new System.Drawing.Point(28, 52);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(115, 22);
            this.lbMaHoaDon.TabIndex = 0;
            this.lbMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(982, 508);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Lập báo cáo";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 578);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBN)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListHoaDon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txDiaChi;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.TextBox tbMaBN;
        private System.Windows.Forms.Label lbMaBN;
        private System.Windows.Forms.DateTimePicker DateBorn;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Button bttnLuu;
        private System.Windows.Forms.Button btbSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView listBN;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gvListHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnmHoaDon;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.TextBox tbTienThuoc;
        private System.Windows.Forms.ComboBox cbbMaToaThuoc;
        private System.Windows.Forms.DateTimePicker DateBan;
        private System.Windows.Forms.TextBox tbMaHoaDon;
        private System.Windows.Forms.Label lbTienThuoc;
        private System.Windows.Forms.Label lbMaToaThuoc;
        private System.Windows.Forms.Label lbNgayBan;
        private System.Windows.Forms.Label lbMaHoaDon;
    }
}


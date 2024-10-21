namespace bai2_qlThongTinSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_TongSVNu = new System.Windows.Forms.Label();
            this.tongnu = new System.Windows.Forms.TextBox();
            this.tongnam = new System.Windows.Forms.TextBox();
            this.label_TongSVNam = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.groupBox_ttsv = new System.Windows.Forms.GroupBox();
            this.label_ChuyenNganh = new System.Windows.Forms.Label();
            this.label_DTB = new System.Windows.Forms.Label();
            this.label_GioiTinh = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.label_mssv = new System.Windows.Forms.Label();
            this.cbxChuyenNganh = new System.Windows.Forms.ComboBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanLyKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbQuanLyKhoa = new System.Windows.Forms.ToolStripButton();
            this.tsbTimKiem = new System.Windows.Forms.ToolStripButton();
            this.tsbThoat = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.groupBox_ttsv.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_TongSVNu
            // 
            this.label_TongSVNu.AutoSize = true;
            this.label_TongSVNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TongSVNu.Location = new System.Drawing.Point(1233, 496);
            this.label_TongSVNu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_TongSVNu.Name = "label_TongSVNu";
            this.label_TongSVNu.Size = new System.Drawing.Size(31, 18);
            this.label_TongSVNu.TabIndex = 24;
            this.label_TongSVNu.Text = "Nữ:";
            // 
            // tongnu
            // 
            this.tongnu.Location = new System.Drawing.Point(1284, 494);
            this.tongnu.Margin = new System.Windows.Forms.Padding(5);
            this.tongnu.Name = "tongnu";
            this.tongnu.ReadOnly = true;
            this.tongnu.Size = new System.Drawing.Size(52, 22);
            this.tongnu.TabIndex = 23;
            // 
            // tongnam
            // 
            this.tongnam.Location = new System.Drawing.Point(1127, 491);
            this.tongnam.Margin = new System.Windows.Forms.Padding(5);
            this.tongnam.Name = "tongnam";
            this.tongnam.ReadOnly = true;
            this.tongnam.Size = new System.Drawing.Size(79, 22);
            this.tongnam.TabIndex = 22;
            // 
            // label_TongSVNam
            // 
            this.label_TongSVNam.AutoSize = true;
            this.label_TongSVNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TongSVNam.Location = new System.Drawing.Point(960, 494);
            this.label_TongSVNam.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_TongSVNam.Name = "label_TongSVNam";
            this.label_TongSVNam.Size = new System.Drawing.Size(140, 18);
            this.label_TongSVNam.TabIndex = 21;
            this.label_TongSVNam.Text = "Tổng sinh viên nam:";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(411, 443);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 41);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // btnThemSua
            // 
            this.btnThemSua.AutoSize = true;
            this.btnThemSua.Location = new System.Drawing.Point(245, 443);
            this.btnThemSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(155, 41);
            this.btnThemSua.TabIndex = 17;
            this.btnThemSua.Text = "Thêm/Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.buttonThemSV_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHT,
            this.ColGT,
            this.colDTB,
            this.colK});
            this.dgvStudent.Location = new System.Drawing.Point(513, 112);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(5);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.Size = new System.Drawing.Size(853, 372);
            this.dgvStudent.TabIndex = 16;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // groupBox_ttsv
            // 
            this.groupBox_ttsv.Controls.Add(this.label_ChuyenNganh);
            this.groupBox_ttsv.Controls.Add(this.label_DTB);
            this.groupBox_ttsv.Controls.Add(this.label_GioiTinh);
            this.groupBox_ttsv.Controls.Add(this.labelHoTen);
            this.groupBox_ttsv.Controls.Add(this.label_mssv);
            this.groupBox_ttsv.Controls.Add(this.cbxChuyenNganh);
            this.groupBox_ttsv.Controls.Add(this.txtDTB);
            this.groupBox_ttsv.Controls.Add(this.txtHoTen);
            this.groupBox_ttsv.Controls.Add(this.txtMSSV);
            this.groupBox_ttsv.Controls.Add(this.radioNu);
            this.groupBox_ttsv.Controls.Add(this.radioNam);
            this.groupBox_ttsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox_ttsv.Location = new System.Drawing.Point(29, 94);
            this.groupBox_ttsv.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_ttsv.Name = "groupBox_ttsv";
            this.groupBox_ttsv.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_ttsv.Size = new System.Drawing.Size(473, 341);
            this.groupBox_ttsv.TabIndex = 26;
            this.groupBox_ttsv.TabStop = false;
            this.groupBox_ttsv.Text = "Thông tin sinh viên";
            // 
            // label_ChuyenNganh
            // 
            this.label_ChuyenNganh.AutoSize = true;
            this.label_ChuyenNganh.Location = new System.Drawing.Point(21, 286);
            this.label_ChuyenNganh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_ChuyenNganh.Name = "label_ChuyenNganh";
            this.label_ChuyenNganh.Size = new System.Drawing.Size(115, 20);
            this.label_ChuyenNganh.TabIndex = 28;
            this.label_ChuyenNganh.Text = "Chuyên ngành";
            // 
            // label_DTB
            // 
            this.label_DTB.AutoSize = true;
            this.label_DTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DTB.Location = new System.Drawing.Point(21, 222);
            this.label_DTB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_DTB.Name = "label_DTB";
            this.label_DTB.Size = new System.Drawing.Size(38, 18);
            this.label_DTB.TabIndex = 27;
            this.label_DTB.Text = "ĐTB";
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.AutoSize = true;
            this.label_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_GioiTinh.Location = new System.Drawing.Point(21, 166);
            this.label_GioiTinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(62, 18);
            this.label_GioiTinh.TabIndex = 26;
            this.label_GioiTinh.Text = "Giới tính";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHoTen.Location = new System.Drawing.Point(21, 114);
            this.labelHoTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(52, 18);
            this.labelHoTen.TabIndex = 25;
            this.labelHoTen.Text = "Họ tên";
            // 
            // label_mssv
            // 
            this.label_mssv.AutoSize = true;
            this.label_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_mssv.Location = new System.Drawing.Point(21, 55);
            this.label_mssv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_mssv.Name = "label_mssv";
            this.label_mssv.Size = new System.Drawing.Size(90, 18);
            this.label_mssv.TabIndex = 24;
            this.label_mssv.Text = "Mã sinh viên";
            // 
            // cbxChuyenNganh
            // 
            this.cbxChuyenNganh.FormattingEnabled = true;
            this.cbxChuyenNganh.Items.AddRange(new object[] {
            "Chọn ngành",
            "Công nghệ thông tin",
            "Ngôn ngữ anh",
            "Quản trị kinh doanh",
            "Thiết kế đồ họa",
            "Kế toán/ Kiểm toán",
            "Thương mại điện tử"});
            this.cbxChuyenNganh.Location = new System.Drawing.Point(157, 283);
            this.cbxChuyenNganh.Margin = new System.Windows.Forms.Padding(5);
            this.cbxChuyenNganh.Name = "cbxChuyenNganh";
            this.cbxChuyenNganh.Size = new System.Drawing.Size(267, 28);
            this.cbxChuyenNganh.TabIndex = 23;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(157, 220);
            this.txtDTB.Margin = new System.Windows.Forms.Padding(5);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(184, 27);
            this.txtDTB.TabIndex = 22;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(159, 113);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(288, 27);
            this.txtHoTen.TabIndex = 21;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(159, 54);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(5);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(207, 27);
            this.txtMSSV.TabIndex = 20;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Checked = true;
            this.radioNu.Location = new System.Drawing.Point(292, 166);
            this.radioNu.Margin = new System.Windows.Forms.Padding(5);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(51, 24);
            this.radioNu.TabIndex = 19;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(157, 166);
            this.radioNam.Margin = new System.Windows.Forms.Padding(5);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(65, 24);
            this.radioNam.TabIndex = 18;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            // 
            // colHT
            // 
            this.colHT.FillWeight = 130F;
            this.colHT.HeaderText = "Họ tên";
            this.colHT.MinimumWidth = 6;
            this.colHT.Name = "colHT";
            // 
            // ColGT
            // 
            this.ColGT.FillWeight = 70F;
            this.ColGT.HeaderText = "Giới tính";
            this.ColGT.MinimumWidth = 6;
            this.ColGT.Name = "ColGT";
            // 
            // colDTB
            // 
            this.colDTB.HeaderText = "ĐTB";
            this.colDTB.MinimumWidth = 6;
            this.colDTB.Name = "colDTB";
            // 
            // colK
            // 
            this.colK.HeaderText = "Khoa";
            this.colK.MinimumWidth = 6;
            this.colK.Name = "colK";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbQuanLyKhoa,
            this.tsbTimKiem,
            this.tsbThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1384, 27);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuanLyKhoa,
            this.tsmTimKiem,
            this.toolStripSeparator1,
            this.tsmThoat});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // tsmQuanLyKhoa
            // 
            this.tsmQuanLyKhoa.Image = ((System.Drawing.Image)(resources.GetObject("tsmQuanLyKhoa.Image")));
            this.tsmQuanLyKhoa.Name = "tsmQuanLyKhoa";
            this.tsmQuanLyKhoa.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmQuanLyKhoa.Size = new System.Drawing.Size(224, 26);
            this.tsmQuanLyKhoa.Text = "Quản lý khoa";
            this.tsmQuanLyKhoa.Click += new System.EventHandler(this.tsbQuanLyKhoa_Click);
            // 
            // tsmTimKiem
            // 
            this.tsmTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsmTimKiem.Image")));
            this.tsmTimKiem.Name = "tsmTimKiem";
            this.tsmTimKiem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmTimKiem.Size = new System.Drawing.Size(224, 26);
            this.tsmTimKiem.Text = "Tìm kiếm";
            this.tsmTimKiem.Click += new System.EventHandler(this.tsbTimKiem_Click);
            // 
            // tsmThoat
            // 
            this.tsmThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsmThoat.Image")));
            this.tsmThoat.Name = "tsmThoat";
            this.tsmThoat.Size = new System.Drawing.Size(224, 26);
            this.tsmThoat.Text = "Thoát";
            this.tsmThoat.Click += new System.EventHandler(this.tsbThoat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsbQuanLyKhoa
            // 
            this.tsbQuanLyKhoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuanLyKhoa.Image")));
            this.tsbQuanLyKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuanLyKhoa.Name = "tsbQuanLyKhoa";
            this.tsbQuanLyKhoa.Size = new System.Drawing.Size(119, 24);
            this.tsbQuanLyKhoa.Text = "Quản lý khoa";
            this.tsbQuanLyKhoa.Click += new System.EventHandler(this.tsbQuanLyKhoa_Click);
            // 
            // tsbTimKiem
            // 
            this.tsbTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsbTimKiem.Image")));
            this.tsbTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTimKiem.Name = "tsbTimKiem";
            this.tsbTimKiem.Size = new System.Drawing.Size(94, 24);
            this.tsbTimKiem.Text = "Tìm kiếm";
            this.tsbTimKiem.Click += new System.EventHandler(this.tsbTimKiem_Click);
            // 
            // tsbThoat
            // 
            this.tsbThoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsbThoat.Image")));
            this.tsbThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThoat.Name = "tsbThoat";
            this.tsbThoat.Size = new System.Drawing.Size(71, 24);
            this.tsbThoat.Text = "Thoát";
            this.tsbThoat.Click += new System.EventHandler(this.tsbThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 530);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox_ttsv);
            this.Controls.Add(this.label_TongSVNu);
            this.Controls.Add(this.tongnu);
            this.Controls.Add(this.tongnam);
            this.Controls.Add(this.label_TongSVNam);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.groupBox_ttsv.ResumeLayout(false);
            this.groupBox_ttsv.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_TongSVNu;
        private System.Windows.Forms.TextBox tongnu;
        private System.Windows.Forms.TextBox tongnam;
        private System.Windows.Forms.Label label_TongSVNam;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.GroupBox groupBox_ttsv;
        private System.Windows.Forms.Label label_ChuyenNganh;
        private System.Windows.Forms.Label label_DTB;
        private System.Windows.Forms.Label label_GioiTinh;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label label_mssv;
        private System.Windows.Forms.ComboBox cbxChuyenNganh;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbQuanLyKhoa;
        private System.Windows.Forms.ToolStripButton tsbTimKiem;
        private System.Windows.Forms.ToolStripButton tsbThoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLyKhoa;
        private System.Windows.Forms.ToolStripMenuItem tsmTimKiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmThoat;
    }
}


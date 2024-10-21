namespace QLSV
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonThemSV = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label_ChuyenNganh = new System.Windows.Forms.Label();
            this.label_DTB = new System.Windows.Forms.Label();
            this.label_GioiTinh = new System.Windows.Forms.Label();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.label_mssv = new System.Windows.Forms.Label();
            this.comboNGANH = new System.Windows.Forms.ComboBox();
            this.textBox_DTB = new System.Windows.Forms.TextBox();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.textBoxMSSV = new System.Windows.Forms.TextBox();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.label_ThongTin = new System.Windows.Forms.Label();
            this.label_TongSVNam = new System.Windows.Forms.Label();
            this.tongnam = new System.Windows.Forms.TextBox();
            this.tongnu = new System.Windows.Forms.TextBox();
            this.label_TongSVNu = new System.Windows.Forms.Label();
            this.label_QLSV = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHT,
            this.colGT,
            this.colDTB,
            this.colK});
            this.dgvStudent.Location = new System.Drawing.Point(431, 102);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.Size = new System.Drawing.Size(743, 302);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick_1);
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSV_CellContentClick);
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            // 
            // colHT
            // 
            this.colHT.HeaderText = "Họ tên";
            this.colHT.MinimumWidth = 6;
            this.colHT.Name = "colHT";
            // 
            // colGT
            // 
            this.colGT.HeaderText = "Giới Tính";
            this.colGT.MinimumWidth = 6;
            this.colGT.Name = "colGT";
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
            // buttonThemSV
            // 
            this.buttonThemSV.AutoSize = true;
            this.buttonThemSV.Location = new System.Drawing.Point(229, 421);
            this.buttonThemSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThemSV.Name = "buttonThemSV";
            this.buttonThemSV.Size = new System.Drawing.Size(116, 33);
            this.buttonThemSV.TabIndex = 7;
            this.buttonThemSV.Text = "Thêm/Sửa";
            this.buttonThemSV.UseVisualStyleBackColor = true;
            this.buttonThemSV.Click += new System.EventHandler(this.buttonThemSV_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.AutoSize = true;
            this.buttonXoa.Location = new System.Drawing.Point(353, 421);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(69, 33);
            this.buttonXoa.TabIndex = 8;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label_ChuyenNganh);
            this.panel.Controls.Add(this.label_DTB);
            this.panel.Controls.Add(this.label_GioiTinh);
            this.panel.Controls.Add(this.labelHoTen);
            this.panel.Controls.Add(this.label_mssv);
            this.panel.Controls.Add(this.comboNGANH);
            this.panel.Controls.Add(this.textBox_DTB);
            this.panel.Controls.Add(this.textBoxHoTen);
            this.panel.Controls.Add(this.textBoxMSSV);
            this.panel.Controls.Add(this.radioNu);
            this.panel.Controls.Add(this.radioNam);
            this.panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.Location = new System.Drawing.Point(16, 102);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(379, 302);
            this.panel.TabIndex = 9;
            // 
            // label_ChuyenNganh
            // 
            this.label_ChuyenNganh.AutoSize = true;
            this.label_ChuyenNganh.Location = new System.Drawing.Point(11, 244);
            this.label_ChuyenNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ChuyenNganh.Name = "label_ChuyenNganh";
            this.label_ChuyenNganh.Size = new System.Drawing.Size(92, 16);
            this.label_ChuyenNganh.TabIndex = 17;
            this.label_ChuyenNganh.Text = "Chuyên ngành";
            // 
            // label_DTB
            // 
            this.label_DTB.AutoSize = true;
            this.label_DTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DTB.Location = new System.Drawing.Point(12, 188);
            this.label_DTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DTB.Name = "label_DTB";
            this.label_DTB.Size = new System.Drawing.Size(38, 18);
            this.label_DTB.TabIndex = 16;
            this.label_DTB.Text = "ĐTB";
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.AutoSize = true;
            this.label_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_GioiTinh.Location = new System.Drawing.Point(12, 137);
            this.label_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(62, 18);
            this.label_GioiTinh.TabIndex = 15;
            this.label_GioiTinh.Text = "Giới tính";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHoTen.Location = new System.Drawing.Point(12, 84);
            this.labelHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(52, 18);
            this.labelHoTen.TabIndex = 14;
            this.labelHoTen.Text = "Họ tên";
            // 
            // label_mssv
            // 
            this.label_mssv.AutoSize = true;
            this.label_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_mssv.Location = new System.Drawing.Point(11, 32);
            this.label_mssv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mssv.Name = "label_mssv";
            this.label_mssv.Size = new System.Drawing.Size(90, 18);
            this.label_mssv.TabIndex = 13;
            this.label_mssv.Text = "Mã sinh viên";
            // 
            // comboNGANH
            // 
            this.comboNGANH.FormattingEnabled = true;
            this.comboNGANH.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngôn ngữ anh",
            "Quản trị kinh doanh",
            "Thiết kế đồ họa",
            "Kế toán/ Kiểm toán",
            "Thương mại điện tử"});
            this.comboNGANH.Location = new System.Drawing.Point(132, 240);
            this.comboNGANH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboNGANH.Name = "comboNGANH";
            this.comboNGANH.Size = new System.Drawing.Size(216, 24);
            this.comboNGANH.TabIndex = 12;
            this.comboNGANH.SelectedIndexChanged += new System.EventHandler(this.comboNGANH_SelectedIndexChanged_1);
            // 
            // textBox_DTB
            // 
            this.textBox_DTB.Location = new System.Drawing.Point(132, 187);
            this.textBox_DTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_DTB.Name = "textBox_DTB";
            this.textBox_DTB.Size = new System.Drawing.Size(139, 22);
            this.textBox_DTB.TabIndex = 11;
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(132, 80);
            this.textBoxHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(217, 22);
            this.textBoxHoTen.TabIndex = 10;
            // 
            // textBoxMSSV
            // 
            this.textBoxMSSV.Location = new System.Drawing.Point(132, 30);
            this.textBoxMSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMSSV.Name = "textBoxMSSV";
            this.textBoxMSSV.Size = new System.Drawing.Size(156, 22);
            this.textBoxMSSV.TabIndex = 9;
            this.textBoxMSSV.TextChanged += new System.EventHandler(this.textBoxMSSV_TextChanged);
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Checked = true;
            this.radioNu.Location = new System.Drawing.Point(237, 137);
            this.radioNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(45, 20);
            this.radioNu.TabIndex = 8;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(136, 137);
            this.radioNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(57, 20);
            this.radioNam.TabIndex = 7;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // label_ThongTin
            // 
            this.label_ThongTin.AutoSize = true;
            this.label_ThongTin.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTin.Location = new System.Drawing.Point(27, 91);
            this.label_ThongTin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ThongTin.Name = "label_ThongTin";
            this.label_ThongTin.Size = new System.Drawing.Size(168, 21);
            this.label_ThongTin.TabIndex = 10;
            this.label_ThongTin.Text = "Thông tin sinh viên";
            // 
            // label_TongSVNam
            // 
            this.label_TongSVNam.AutoSize = true;
            this.label_TongSVNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TongSVNam.Location = new System.Drawing.Point(776, 432);
            this.label_TongSVNam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TongSVNam.Name = "label_TongSVNam";
            this.label_TongSVNam.Size = new System.Drawing.Size(140, 18);
            this.label_TongSVNam.TabIndex = 11;
            this.label_TongSVNam.Text = "Tổng sinh viên nam:";
            // 
            // tongnam
            // 
            this.tongnam.Location = new System.Drawing.Point(940, 430);
            this.tongnam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tongnam.Name = "tongnam";
            this.tongnam.ReadOnly = true;
            this.tongnam.Size = new System.Drawing.Size(60, 22);
            this.tongnam.TabIndex = 12;
            this.tongnam.TextChanged += new System.EventHandler(this.tongnam_TextChanged);
            // 
            // tongnu
            // 
            this.tongnu.Location = new System.Drawing.Point(1061, 430);
            this.tongnu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tongnu.Name = "tongnu";
            this.tongnu.ReadOnly = true;
            this.tongnu.Size = new System.Drawing.Size(40, 22);
            this.tongnu.TabIndex = 13;
            // 
            // label_TongSVNu
            // 
            this.label_TongSVNu.AutoSize = true;
            this.label_TongSVNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TongSVNu.Location = new System.Drawing.Point(1023, 432);
            this.label_TongSVNu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TongSVNu.Name = "label_TongSVNu";
            this.label_TongSVNu.Size = new System.Drawing.Size(31, 18);
            this.label_TongSVNu.TabIndex = 14;
            this.label_TongSVNu.Text = "Nữ:";
            // 
            // label_QLSV
            // 
            this.label_QLSV.AutoSize = true;
            this.label_QLSV.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_QLSV.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_QLSV.Location = new System.Drawing.Point(323, 30);
            this.label_QLSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_QLSV.Name = "label_QLSV";
            this.label_QLSV.Size = new System.Drawing.Size(392, 35);
            this.label_QLSV.TabIndex = 15;
            this.label_QLSV.Text = "Quản lý thông tin sinh viên";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 487);
            this.Controls.Add(this.label_QLSV);
            this.Controls.Add(this.label_TongSVNu);
            this.Controls.Add(this.tongnu);
            this.Controls.Add(this.tongnam);
            this.Controls.Add(this.label_TongSVNam);
            this.Controls.Add(this.label_ThongTin);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThemSV);
            this.Controls.Add(this.dgvStudent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK;
        private System.Windows.Forms.Button buttonThemSV;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox comboNGANH;
        private System.Windows.Forms.TextBox textBox_DTB;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.TextBox textBoxMSSV;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.Label label_ThongTin;
        private System.Windows.Forms.Label label_mssv;
        private System.Windows.Forms.Label label_ChuyenNganh;
        private System.Windows.Forms.Label label_DTB;
        private System.Windows.Forms.Label label_GioiTinh;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label label_TongSVNam;
        private System.Windows.Forms.TextBox tongnam;
        private System.Windows.Forms.TextBox tongnu;
        private System.Windows.Forms.Label label_TongSVNu;
        private System.Windows.Forms.Label label_QLSV;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}


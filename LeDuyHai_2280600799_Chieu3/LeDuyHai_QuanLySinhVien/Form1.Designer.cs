namespace LeDuyHai_QuanLySinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.dgvThongTinSV = new System.Windows.Forms.DataGridView();
            this.clnMssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDtb = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbnTongNam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbnTongNu = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(336, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // txtMssv
            // 
            this.txtMssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMssv.Location = new System.Drawing.Point(116, 42);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(224, 31);
            this.txtMssv.TabIndex = 1;
            this.txtMssv.TextChanged += new System.EventHandler(this.txtMssv_TextChanged);
            // 
            // dgvThongTinSV
            // 
            this.dgvThongTinSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMssv,
            this.clnHoTen,
            this.clnGioiTinh,
            this.clnDtb,
            this.clnKhoa});
            this.dgvThongTinSV.Location = new System.Drawing.Point(435, 63);
            this.dgvThongTinSV.Name = "dgvThongTinSV";
            this.dgvThongTinSV.Size = new System.Drawing.Size(501, 355);
            this.dgvThongTinSV.TabIndex = 2;
            this.dgvThongTinSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinSV_CellContentClick);
            // 
            // clnMssv
            // 
            this.clnMssv.FillWeight = 37.1134F;
            this.clnMssv.HeaderText = "MSSV";
            this.clnMssv.Name = "clnMssv";
            // 
            // clnHoTen
            // 
            this.clnHoTen.FillWeight = 37.1134F;
            this.clnHoTen.HeaderText = "Họ tên";
            this.clnHoTen.Name = "clnHoTen";
            this.clnHoTen.Width = 150;
            // 
            // clnGioiTinh
            // 
            this.clnGioiTinh.FillWeight = 37.1134F;
            this.clnGioiTinh.HeaderText = "Giới tính";
            this.clnGioiTinh.Name = "clnGioiTinh";
            this.clnGioiTinh.Width = 60;
            // 
            // clnDtb
            // 
            this.clnDtb.FillWeight = 288.6598F;
            this.clnDtb.HeaderText = "ĐTB";
            this.clnDtb.Name = "clnDtb";
            this.clnDtb.Width = 50;
            // 
            // clnKhoa
            // 
            this.clnKhoa.HeaderText = "Khoa";
            this.clnKhoa.Name = "clnKhoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbKhoa);
            this.groupBox1.Controls.Add(this.rdbNu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDtb);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMssv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(46, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Items.AddRange(new object[] {
            "Chọn khoa",
            "CNTT",
            "QTKD",
            "TMDT",
            "KT",
            "NNA",
            "KHMT"});
            this.cbbKhoa.Location = new System.Drawing.Point(116, 270);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(224, 33);
            this.cbbKhoa.TabIndex = 3;
            this.cbbKhoa.TextChanged += new System.EventHandler(this.txtMssv_TextChanged);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Checked = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbNu.Location = new System.Drawing.Point(237, 148);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(57, 29);
            this.rdbNu.TabIndex = 2;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.rdbNu.TextChanged += new System.EventHandler(this.txtMssv_TextChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdbNam.Location = new System.Drawing.Point(142, 148);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(74, 29);
            this.rdbNam.TabIndex = 2;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(19, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(22, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(22, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "ĐTB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV";
            // 
            // txtDtb
            // 
            this.txtDtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDtb.Location = new System.Drawing.Point(116, 213);
            this.txtDtb.Name = "txtDtb";
            this.txtDtb.Size = new System.Drawing.Size(224, 31);
            this.txtDtb.TabIndex = 1;
            this.txtDtb.TextChanged += new System.EventHandler(this.txtMssv_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.Location = new System.Drawing.Point(116, 95);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(224, 31);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtMssv_TextChanged);
            // 
            // btnThemSua
            // 
            this.btnThemSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemSua.Location = new System.Drawing.Point(170, 414);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(131, 30);
            this.btnThemSua.TabIndex = 4;
            this.btnThemSua.Text = "Thêm/Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(586, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng sinh viên nam: ";
            // 
            // lbnTongNam
            // 
            this.lbnTongNam.AutoSize = true;
            this.lbnTongNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbnTongNam.Location = new System.Drawing.Point(792, 432);
            this.lbnTongNam.Name = "lbnTongNam";
            this.lbnTongNam.Size = new System.Drawing.Size(24, 25);
            this.lbnTongNam.TabIndex = 0;
            this.lbnTongNam.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(824, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nữ: ";
            // 
            // lbnTongNu
            // 
            this.lbnTongNu.AutoSize = true;
            this.lbnTongNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbnTongNu.Location = new System.Drawing.Point(869, 432);
            this.lbnTongNu.Name = "lbnTongNu";
            this.lbnTongNu.Size = new System.Drawing.Size(24, 25);
            this.lbnTongNu.TabIndex = 0;
            this.lbnTongNu.Text = "0";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(307, 414);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 30);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 477);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThongTinSV);
            this.Controls.Add(this.lbnTongNu);
            this.Controls.Add(this.lbnTongNam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.DataGridView dgvThongTinSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDtb;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbnTongNam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbnTongNu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnKhoa;
    }
}


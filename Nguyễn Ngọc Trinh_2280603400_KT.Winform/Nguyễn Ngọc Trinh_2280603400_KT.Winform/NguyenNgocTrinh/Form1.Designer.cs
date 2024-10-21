namespace NguyenNgocTrinh
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
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtMaPhieuAn = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphieuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChiTietHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(136, 127);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(283, 22);
            this.txtMaNhanVien.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(394, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "HÓA ĐƠN CĂN TIN HUTECH";
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.Location = new System.Drawing.Point(136, 177);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(283, 22);
            this.dtp_ngaylap.TabIndex = 9;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Enabled = false;
            this.txtTongtien.Location = new System.Drawing.Point(136, 233);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(180, 22);
            this.txtTongtien.TabIndex = 8;
            this.txtTongtien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaPhieuAn
            // 
            this.txtMaPhieuAn.Location = new System.Drawing.Point(136, 84);
            this.txtMaPhieuAn.Name = "txtMaPhieuAn";
            this.txtMaPhieuAn.Size = new System.Drawing.Size(283, 22);
            this.txtMaPhieuAn.TabIndex = 5;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(136, 31);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(283, 22);
            this.txtMaHoaDon.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tổng tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên:";
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.AllowUserToAddRows = false;
            this.dgvhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.Mahoadon,
            this.Maphieuan,
            this.Manv,
            this.ColumnNgayLap,
            this.ColumnTongtien});
            this.dgvhoadon.Location = new System.Drawing.Point(487, 163);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.RowHeadersWidth = 51;
            this.dgvhoadon.RowTemplate.Height = 24;
            this.dgvhoadon.Size = new System.Drawing.Size(891, 401);
            this.dgvhoadon.TabIndex = 18;
            this.dgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellClick);
            // 
            // ColSTT
            // 
            this.ColSTT.FillWeight = 50F;
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            // 
            // Mahoadon
            // 
            this.Mahoadon.HeaderText = "Mã Hóa Đơn";
            this.Mahoadon.MinimumWidth = 6;
            this.Mahoadon.Name = "Mahoadon";
            // 
            // Maphieuan
            // 
            this.Maphieuan.HeaderText = "Mã Phiếu Ăn";
            this.Maphieuan.MinimumWidth = 6;
            this.Maphieuan.Name = "Maphieuan";
            // 
            // Manv
            // 
            this.Manv.HeaderText = "Mã Nhân Viên";
            this.Manv.MinimumWidth = 6;
            this.Manv.Name = "Manv";
            // 
            // ColumnNgayLap
            // 
            this.ColumnNgayLap.FillWeight = 150F;
            this.ColumnNgayLap.HeaderText = "Ngày Lập";
            this.ColumnNgayLap.MinimumWidth = 6;
            this.ColumnNgayLap.Name = "ColumnNgayLap";
            // 
            // ColumnTongtien
            // 
            this.ColumnTongtien.HeaderText = "Tổng Tiền";
            this.ColumnTongtien.MinimumWidth = 6;
            this.ColumnTongtien.Name = "ColumnTongtien";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã phiếu ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(281, 474);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(97, 41);
            this.btnThemSua.TabIndex = 20;
            this.btnThemSua.Text = "Thêm/Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_ngaylap);
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.txtMaNhanVien);
            this.groupBox2.Controls.Add(this.txtMaPhieuAn);
            this.groupBox2.Controls.Add(this.txtMaHoaDon);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(20, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 292);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(384, 474);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(54, 41);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1293, 570);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 41);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(487, 577);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(295, 41);
            this.btnChiTietHoaDon.TabIndex = 20;
            this.btnChiTietHoaDon.Text = "Chi tiết hóa đơn";
            this.btnChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietHoaDon.UseVisualStyleBackColor = true;
            this.btnChiTietHoaDon.Click += new System.EventHandler(this.btnChiTietHoaDon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvhoadon);
            this.Controls.Add(this.btnChiTietHoaDon);
            this.Controls.Add(this.btnThemSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtMaPhieuAn;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphieuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTongtien;
        private System.Windows.Forms.Button btnChiTietHoaDon;
    }
}


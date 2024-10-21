namespace bai4_qlSanPhamVaDonHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbXemTatCa = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDau = new System.Windows.Forms.DateTimePicker();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayGiaoHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbXemTatCa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpNgayCuoi);
            this.groupBox1.Controls.Add(this.dtpNgayDau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // chbXemTatCa
            // 
            this.chbXemTatCa.AutoSize = true;
            this.chbXemTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chbXemTatCa.Location = new System.Drawing.Point(38, 52);
            this.chbXemTatCa.Name = "chbXemTatCa";
            this.chbXemTatCa.Size = new System.Drawing.Size(230, 29);
            this.chbXemTatCa.TabIndex = 2;
            this.chbXemTatCa.Text = "Xem tất cả trong tháng";
            this.chbXemTatCa.UseVisualStyleBackColor = true;
            this.chbXemTatCa.CheckedChanged += new System.EventHandler(this.chbXemTatCa_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(654, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian giao hàng";
            // 
            // dtpNgayCuoi
            // 
            this.dtpNgayCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayCuoi.Location = new System.Drawing.Point(702, 106);
            this.dtpNgayCuoi.Name = "dtpNgayCuoi";
            this.dtpNgayCuoi.Size = new System.Drawing.Size(380, 30);
            this.dtpNgayCuoi.TabIndex = 0;
            this.dtpNgayCuoi.ValueChanged += new System.EventHandler(this.dtpNgayCuoi_ValueChanged);
            // 
            // dtpNgayDau
            // 
            this.dtpNgayDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayDau.Location = new System.Drawing.Point(251, 106);
            this.dtpNgayDau.Name = "dtpNgayDau";
            this.dtpNgayDau.Size = new System.Drawing.Size(387, 30);
            this.dtpNgayDau.TabIndex = 0;
            this.dtpNgayDau.ValueChanged += new System.EventHandler(this.dtpNgayDau_ValueChanged);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColSHoaDon,
            this.ColNgayDatHang,
            this.ColNgayGiaoHang,
            this.ColThanhTien});
            this.dgvDonHang.Location = new System.Drawing.Point(12, 177);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(1120, 408);
            this.dgvDonHang.TabIndex = 7;
            // 
            // ColSTT
            // 
            this.ColSTT.FillWeight = 40F;
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            // 
            // ColSHoaDon
            // 
            this.ColSHoaDon.HeaderText = "Số HD";
            this.ColSHoaDon.MinimumWidth = 6;
            this.ColSHoaDon.Name = "ColSHoaDon";
            // 
            // ColNgayDatHang
            // 
            this.ColNgayDatHang.FillWeight = 130F;
            this.ColNgayDatHang.HeaderText = "Ngày đặt hàng";
            this.ColNgayDatHang.MinimumWidth = 6;
            this.ColNgayDatHang.Name = "ColNgayDatHang";
            // 
            // ColNgayGiaoHang
            // 
            this.ColNgayGiaoHang.FillWeight = 130F;
            this.ColNgayGiaoHang.HeaderText = "Ngày giao hàng";
            this.ColNgayGiaoHang.MinimumWidth = 6;
            this.ColNgayGiaoHang.Name = "ColNgayGiaoHang";
            // 
            // ColThanhTien
            // 
            this.ColThanhTien.HeaderText = "Thành tiền";
            this.ColThanhTien.MinimumWidth = 6;
            this.ColThanhTien.Name = "ColThanhTien";
            // 
            // txtTongCong
            // 
            this.txtTongCong.Enabled = false;
            this.txtTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongCong.Location = new System.Drawing.Point(950, 593);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Size = new System.Drawing.Size(160, 30);
            this.txtTongCong.TabIndex = 6;
            this.txtTongCong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(837, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng cộng:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.txtTongCong);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbXemTatCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayCuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDau;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayGiaoHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThanhTien;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.Label label1;
    }
}


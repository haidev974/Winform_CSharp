namespace NguyenNgocTrinh
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_Thongtin = new System.Windows.Forms.GroupBox();
            this.cbx_TenHang = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.lbl_dongia = new System.Windows.Forms.Label();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_mahang = new System.Windows.Forms.Label();
            this.lbl_mahoadon = new System.Windows.Forms.Label();
            this.btn_ThemSua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiethoadon)).BeginInit();
            this.gbx_Thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(283, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // dgv_chitiethoadon
            // 
            this.dgv_chitiethoadon.AllowUserToAddRows = false;
            this.dgv_chitiethoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chitiethoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiethoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_STT,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_chitiethoadon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_chitiethoadon.Location = new System.Drawing.Point(663, 102);
            this.dgv_chitiethoadon.Name = "dgv_chitiethoadon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_chitiethoadon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_chitiethoadon.RowHeadersWidth = 51;
            this.dgv_chitiethoadon.RowTemplate.Height = 24;
            this.dgv_chitiethoadon.Size = new System.Drawing.Size(719, 331);
            this.dgv_chitiethoadon.TabIndex = 11;
            this.dgv_chitiethoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitiethoadon_CellClick);
            // 
            // col_STT
            // 
            this.col_STT.FillWeight = 50F;
            this.col_STT.HeaderText = "STT";
            this.col_STT.MinimumWidth = 6;
            this.col_STT.Name = "col_STT";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // gbx_Thongtin
            // 
            this.gbx_Thongtin.Controls.Add(this.cbx_TenHang);
            this.gbx_Thongtin.Controls.Add(this.txtGia);
            this.gbx_Thongtin.Controls.Add(this.txt_DonGia);
            this.gbx_Thongtin.Controls.Add(this.txtMaHang);
            this.gbx_Thongtin.Controls.Add(this.txt_SL);
            this.gbx_Thongtin.Controls.Add(this.lbl_dongia);
            this.gbx_Thongtin.Controls.Add(this.lbl_soluong);
            this.gbx_Thongtin.Controls.Add(this.label2);
            this.gbx_Thongtin.Controls.Add(this.lbl_mahang);
            this.gbx_Thongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Thongtin.Location = new System.Drawing.Point(28, 99);
            this.gbx_Thongtin.Name = "gbx_Thongtin";
            this.gbx_Thongtin.Size = new System.Drawing.Size(597, 272);
            this.gbx_Thongtin.TabIndex = 13;
            this.gbx_Thongtin.TabStop = false;
            this.gbx_Thongtin.Text = "Thông tin chi tiết";
            // 
            // cbx_TenHang
            // 
            this.cbx_TenHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_TenHang.FormattingEnabled = true;
            this.cbx_TenHang.Location = new System.Drawing.Point(162, 108);
            this.cbx_TenHang.Name = "cbx_TenHang";
            this.cbx_TenHang.Size = new System.Drawing.Size(252, 33);
            this.cbx_TenHang.TabIndex = 18;
            this.cbx_TenHang.SelectedIndexChanged += new System.EventHandler(this.cbx_TenHang_SelectedIndexChanged);
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.Location = new System.Drawing.Point(421, 108);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(171, 34);
            this.txtGia.TabIndex = 17;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Enabled = false;
            this.txt_DonGia.Location = new System.Drawing.Point(162, 219);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(211, 30);
            this.txt_DonGia.TabIndex = 17;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Location = new System.Drawing.Point(162, 51);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(271, 30);
            this.txtMaHang.TabIndex = 16;
            // 
            // txt_SL
            // 
            this.txt_SL.Location = new System.Drawing.Point(162, 163);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(211, 30);
            this.txt_SL.TabIndex = 16;
            this.txt_SL.TextChanged += new System.EventHandler(this.txt_SL_TextChanged);
            this.txt_SL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SL_KeyPress);
            // 
            // lbl_dongia
            // 
            this.lbl_dongia.AutoSize = true;
            this.lbl_dongia.Location = new System.Drawing.Point(29, 218);
            this.lbl_dongia.Name = "lbl_dongia";
            this.lbl_dongia.Size = new System.Drawing.Size(85, 25);
            this.lbl_dongia.TabIndex = 13;
            this.lbl_dongia.Text = "Đơn giá:";
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Location = new System.Drawing.Point(29, 165);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(96, 25);
            this.lbl_soluong.TabIndex = 12;
            this.lbl_soluong.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên hàng:";
            // 
            // lbl_mahang
            // 
            this.lbl_mahang.AutoSize = true;
            this.lbl_mahang.Location = new System.Drawing.Point(29, 54);
            this.lbl_mahang.Name = "lbl_mahang";
            this.lbl_mahang.Size = new System.Drawing.Size(95, 25);
            this.lbl_mahang.TabIndex = 11;
            this.lbl_mahang.Text = "Mã hàng:";
            // 
            // lbl_mahoadon
            // 
            this.lbl_mahoadon.AutoSize = true;
            this.lbl_mahoadon.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_mahoadon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_mahoadon.Location = new System.Drawing.Point(762, 32);
            this.lbl_mahoadon.Name = "lbl_mahoadon";
            this.lbl_mahoadon.Size = new System.Drawing.Size(422, 52);
            this.lbl_mahoadon.TabIndex = 10;
            this.lbl_mahoadon.Text = "[Mã HD được chọn]";
            // 
            // btn_ThemSua
            // 
            this.btn_ThemSua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ThemSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSua.Location = new System.Drawing.Point(222, 395);
            this.btn_ThemSua.Name = "btn_ThemSua";
            this.btn_ThemSua.Size = new System.Drawing.Size(170, 38);
            this.btn_ThemSua.TabIndex = 14;
            this.btn_ThemSua.Text = "Thêm/Sửa";
            this.btn_ThemSua.UseVisualStyleBackColor = false;
            this.btn_ThemSua.Click += new System.EventHandler(this.btn_ThemSua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(398, 395);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 38);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TroVe.Location = new System.Drawing.Point(505, 448);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(144, 38);
            this.btn_TroVe.TabIndex = 16;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = false;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Black;
            this.lblTongTien.Location = new System.Drawing.Point(1243, 456);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(36, 26);
            this.lblTongTien.TabIndex = 10;
            this.lblTongTien.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1140, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tổng tiền: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 497);
            this.Controls.Add(this.btn_TroVe);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_ThemSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_chitiethoadon);
            this.Controls.Add(this.gbx_Thongtin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lbl_mahoadon);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiethoadon)).EndInit();
            this.gbx_Thongtin.ResumeLayout(false);
            this.gbx_Thongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_chitiethoadon;
        private System.Windows.Forms.GroupBox gbx_Thongtin;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.Label lbl_dongia;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.Label lbl_mahang;
        private System.Windows.Forms.Label lbl_mahoadon;
        private System.Windows.Forms.Button btn_ThemSua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ComboBox cbx_TenHang;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGia;
    }
}
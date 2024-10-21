namespace QLTTTK
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
            this.textBox_stk = new System.Windows.Forms.TextBox();
            this.textBox_ten = new System.Windows.Forms.TextBox();
            this.textBox_diachi = new System.Windows.Forms.TextBox();
            this.textBox_soTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_SDTTTK = new System.Windows.Forms.DataGridView();
            this.Column_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_dc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_them_capnhat = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.textBox_TongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SDTTTK)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_stk
            // 
            this.textBox_stk.Location = new System.Drawing.Point(211, 73);
            this.textBox_stk.Name = "textBox_stk";
            this.textBox_stk.Size = new System.Drawing.Size(451, 20);
            this.textBox_stk.TabIndex = 0;
            // 
            // textBox_ten
            // 
            this.textBox_ten.Location = new System.Drawing.Point(211, 114);
            this.textBox_ten.Name = "textBox_ten";
            this.textBox_ten.Size = new System.Drawing.Size(451, 20);
            this.textBox_ten.TabIndex = 0;
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Location = new System.Drawing.Point(211, 159);
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(451, 20);
            this.textBox_diachi.TabIndex = 0;
            // 
            // textBox_soTien
            // 
            this.textBox_soTien.Location = new System.Drawing.Point(211, 210);
            this.textBox_soTien.Name = "textBox_soTien";
            this.textBox_soTien.Size = new System.Drawing.Size(451, 20);
            this.textBox_soTien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(42, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(42, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(42, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chị khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(42, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Tiền trong tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(75, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(587, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // dataGridView_SDTTTK
            // 
            this.dataGridView_SDTTTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SDTTTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SDTTTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_stt,
            this.Column_ma,
            this.Column_ten,
            this.Column_dc,
            this.Column_tien});
            this.dataGridView_SDTTTK.Location = new System.Drawing.Point(137, 303);
            this.dataGridView_SDTTTK.Name = "dataGridView_SDTTTK";
            this.dataGridView_SDTTTK.Size = new System.Drawing.Size(563, 191);
            this.dataGridView_SDTTTK.TabIndex = 3;
            this.dataGridView_SDTTTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SDTTTK_CellClick);
            // 
            // Column_stt
            // 
            this.Column_stt.HeaderText = "STT";
            this.Column_stt.Name = "Column_stt";
            // 
            // Column_ma
            // 
            this.Column_ma.HeaderText = "Mã tài khoản";
            this.Column_ma.Name = "Column_ma";
            // 
            // Column_ten
            // 
            this.Column_ten.HeaderText = "Tên khách hàng";
            this.Column_ten.Name = "Column_ten";
            // 
            // Column_dc
            // 
            this.Column_dc.HeaderText = "Địa chỉ";
            this.Column_dc.Name = "Column_dc";
            // 
            // Column_tien
            // 
            this.Column_tien.HeaderText = "Số tiền";
            this.Column_tien.Name = "Column_tien";
            // 
            // button_them_capnhat
            // 
            this.button_them_capnhat.Location = new System.Drawing.Point(330, 256);
            this.button_them_capnhat.Name = "button_them_capnhat";
            this.button_them_capnhat.Size = new System.Drawing.Size(112, 23);
            this.button_them_capnhat.TabIndex = 4;
            this.button_them_capnhat.Text = "Thêm/ Cập nhật";
            this.button_them_capnhat.UseVisualStyleBackColor = true;
            this.button_them_capnhat.Click += new System.EventHandler(this.button_them_capnhat_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(465, 256);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 23);
            this.button_xoa.TabIndex = 5;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(569, 256);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 6;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.Location = new System.Drawing.Point(526, 520);
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.ReadOnly = true;
            this.textBox_TongTien.Size = new System.Drawing.Size(100, 20);
            this.textBox_TongTien.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(451, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng tiền: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 565);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_TongTien);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them_capnhat);
            this.Controls.Add(this.dataGridView_SDTTTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_soTien);
            this.Controls.Add(this.textBox_diachi);
            this.Controls.Add(this.textBox_ten);
            this.Controls.Add(this.textBox_stk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SDTTTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_stk;
        private System.Windows.Forms.TextBox textBox_ten;
        private System.Windows.Forms.TextBox textBox_diachi;
        private System.Windows.Forms.TextBox textBox_soTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_SDTTTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_dc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tien;
        private System.Windows.Forms.Button button_them_capnhat;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.TextBox textBox_TongTien;
        private System.Windows.Forms.Label label6;
    }
}


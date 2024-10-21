namespace LeDuyHai_Buoi2_THLTWIN
{
    partial class TTDG
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
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.bt_number1 = new System.Windows.Forms.Label();
            this.bt_number2 = new System.Windows.Forms.Label();
            this.bt_numberKQ = new System.Windows.Forms.Label();
            this.MTDG = new System.Windows.Forms.Label();
            this.CONG = new System.Windows.Forms.Button();
            this.TRU = new System.Windows.Forms.Button();
            this.NHAN = new System.Windows.Forms.Button();
            this.CHIA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(112, 85);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(388, 20);
            this.txtNumber1.TabIndex = 0;
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(112, 141);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(388, 20);
            this.txtNumber2.TabIndex = 0;
            this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(112, 260);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(388, 20);
            this.txtKQ.TabIndex = 0;
            this.txtKQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // bt_number1
            // 
            this.bt_number1.AutoSize = true;
            this.bt_number1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_number1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_number1.Location = new System.Drawing.Point(11, 88);
            this.bt_number1.Name = "bt_number1";
            this.bt_number1.Size = new System.Drawing.Size(71, 16);
            this.bt_number1.TabIndex = 2;
            this.bt_number1.Text = "Number 1";
            this.bt_number1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_number2
            // 
            this.bt_number2.AutoSize = true;
            this.bt_number2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_number2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_number2.Location = new System.Drawing.Point(11, 141);
            this.bt_number2.Name = "bt_number2";
            this.bt_number2.Size = new System.Drawing.Size(71, 16);
            this.bt_number2.TabIndex = 2;
            this.bt_number2.Text = "Number 2";
            // 
            // bt_numberKQ
            // 
            this.bt_numberKQ.AutoSize = true;
            this.bt_numberKQ.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_numberKQ.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_numberKQ.Location = new System.Drawing.Point(11, 262);
            this.bt_numberKQ.Name = "bt_numberKQ";
            this.bt_numberKQ.Size = new System.Drawing.Size(62, 18);
            this.bt_numberKQ.TabIndex = 2;
            this.bt_numberKQ.Text = "RESULT";
            this.bt_numberKQ.Click += new System.EventHandler(this.label4_Click);
            // 
            // MTDG
            // 
            this.MTDG.AutoSize = true;
            this.MTDG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MTDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MTDG.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.MTDG.Location = new System.Drawing.Point(121, 9);
            this.MTDG.Name = "MTDG";
            this.MTDG.Size = new System.Drawing.Size(286, 31);
            this.MTDG.TabIndex = 2;
            this.MTDG.Text = "MÁY TÍNH ĐƠN GIẢN";
            // 
            // CONG
            // 
            this.CONG.Location = new System.Drawing.Point(137, 196);
            this.CONG.Name = "CONG";
            this.CONG.Size = new System.Drawing.Size(51, 23);
            this.CONG.TabIndex = 3;
            this.CONG.Text = "+";
            this.CONG.UseVisualStyleBackColor = true;
            this.CONG.Click += new System.EventHandler(this.CONG_Click);
            // 
            // TRU
            // 
            this.TRU.Location = new System.Drawing.Point(233, 196);
            this.TRU.Name = "TRU";
            this.TRU.Size = new System.Drawing.Size(50, 23);
            this.TRU.TabIndex = 4;
            this.TRU.Text = "-";
            this.TRU.UseVisualStyleBackColor = true;
            this.TRU.Click += new System.EventHandler(this.TRU_Click);
            // 
            // NHAN
            // 
            this.NHAN.Location = new System.Drawing.Point(334, 196);
            this.NHAN.Name = "NHAN";
            this.NHAN.Size = new System.Drawing.Size(48, 23);
            this.NHAN.TabIndex = 5;
            this.NHAN.Text = "*";
            this.NHAN.UseVisualStyleBackColor = true;
            this.NHAN.Click += new System.EventHandler(this.button1_Click);
            // 
            // CHIA
            // 
            this.CHIA.Location = new System.Drawing.Point(429, 196);
            this.CHIA.Name = "CHIA";
            this.CHIA.Size = new System.Drawing.Size(48, 23);
            this.CHIA.TabIndex = 6;
            this.CHIA.Text = "/";
            this.CHIA.UseVisualStyleBackColor = true;
            this.CHIA.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TTDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 307);
            this.Controls.Add(this.CHIA);
            this.Controls.Add(this.NHAN);
            this.Controls.Add(this.TRU);
            this.Controls.Add(this.CONG);
            this.Controls.Add(this.bt_numberKQ);
            this.Controls.Add(this.bt_number2);
            this.Controls.Add(this.MTDG);
            this.Controls.Add(this.bt_number1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Name = "TTDG";
            this.Text = "Tính Toán đơn giản";
            this.Load += new System.EventHandler(this.TTDG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label bt_number1;
        private System.Windows.Forms.Label bt_number2;
        private System.Windows.Forms.Label bt_numberKQ;
        private System.Windows.Forms.Label MTDG;
        private System.Windows.Forms.Button CONG;
        private System.Windows.Forms.Button TRU;
        private System.Windows.Forms.Button NHAN;
        private System.Windows.Forms.Button CHIA;
    }
}


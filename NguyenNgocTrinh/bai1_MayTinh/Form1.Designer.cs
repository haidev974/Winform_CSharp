namespace bai1_MayTinh
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
            this.CHIA = new System.Windows.Forms.Button();
            this.NHAN = new System.Windows.Forms.Button();
            this.TRU = new System.Windows.Forms.Button();
            this.CONG = new System.Windows.Forms.Button();
            this.bt_numberKQ = new System.Windows.Forms.Label();
            this.bt_number2 = new System.Windows.Forms.Label();
            this.MTDG = new System.Windows.Forms.Label();
            this.bt_number1 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CHIA
            // 
            this.CHIA.Location = new System.Drawing.Point(461, 195);
            this.CHIA.Margin = new System.Windows.Forms.Padding(4);
            this.CHIA.Name = "CHIA";
            this.CHIA.Size = new System.Drawing.Size(64, 28);
            this.CHIA.TabIndex = 17;
            this.CHIA.Text = "/";
            this.CHIA.UseVisualStyleBackColor = true;
            this.CHIA.Click += new System.EventHandler(this.CHIA_Click);
            // 
            // NHAN
            // 
            this.NHAN.Location = new System.Drawing.Point(368, 195);
            this.NHAN.Margin = new System.Windows.Forms.Padding(4);
            this.NHAN.Name = "NHAN";
            this.NHAN.Size = new System.Drawing.Size(64, 28);
            this.NHAN.TabIndex = 16;
            this.NHAN.Text = "*";
            this.NHAN.UseVisualStyleBackColor = true;
            this.NHAN.Click += new System.EventHandler(this.NHAN_Click);
            // 
            // TRU
            // 
            this.TRU.Location = new System.Drawing.Point(265, 195);
            this.TRU.Margin = new System.Windows.Forms.Padding(4);
            this.TRU.Name = "TRU";
            this.TRU.Size = new System.Drawing.Size(67, 28);
            this.TRU.TabIndex = 15;
            this.TRU.Text = "-";
            this.TRU.UseVisualStyleBackColor = true;
            this.TRU.Click += new System.EventHandler(this.TRU_Click);
            // 
            // CONG
            // 
            this.CONG.Location = new System.Drawing.Point(170, 195);
            this.CONG.Margin = new System.Windows.Forms.Padding(4);
            this.CONG.Name = "CONG";
            this.CONG.Size = new System.Drawing.Size(68, 28);
            this.CONG.TabIndex = 14;
            this.CONG.Text = "+";
            this.CONG.UseVisualStyleBackColor = true;
            this.CONG.Click += new System.EventHandler(this.CONG_Click);
            // 
            // bt_numberKQ
            // 
            this.bt_numberKQ.AutoSize = true;
            this.bt_numberKQ.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_numberKQ.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bt_numberKQ.Location = new System.Drawing.Point(13, 249);
            this.bt_numberKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bt_numberKQ.Name = "bt_numberKQ";
            this.bt_numberKQ.Size = new System.Drawing.Size(62, 18);
            this.bt_numberKQ.TabIndex = 10;
            this.bt_numberKQ.Text = "RESULT";
            // 
            // bt_number2
            // 
            this.bt_number2.AutoSize = true;
            this.bt_number2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_number2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bt_number2.Location = new System.Drawing.Point(13, 153);
            this.bt_number2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bt_number2.Name = "bt_number2";
            this.bt_number2.Size = new System.Drawing.Size(71, 16);
            this.bt_number2.TabIndex = 11;
            this.bt_number2.Text = "Number 2";
            // 
            // MTDG
            // 
            this.MTDG.AutoSize = true;
            this.MTDG.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MTDG.Font = new System.Drawing.Font("Matura MT Script Capitals", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTDG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MTDG.Location = new System.Drawing.Point(166, -6);
            this.MTDG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MTDG.Name = "MTDG";
            this.MTDG.Size = new System.Drawing.Size(311, 85);
            this.MTDG.TabIndex = 12;
            this.MTDG.Text = "calculator";
            // 
            // bt_number1
            // 
            this.bt_number1.AutoSize = true;
            this.bt_number1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_number1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.bt_number1.Location = new System.Drawing.Point(13, 87);
            this.bt_number1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bt_number1.Name = "bt_number1";
            this.bt_number1.Size = new System.Drawing.Size(71, 16);
            this.bt_number1.TabIndex = 13;
            this.bt_number1.Text = "Number 1";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(94, 247);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(516, 20);
            this.txtKQ.TabIndex = 7;
            this.txtKQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(94, 152);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(516, 20);
            this.txtNumber2.TabIndex = 8;
            this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(94, 83);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(516, 20);
            this.txtNumber1.TabIndex = 9;
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 283);
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
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CHIA;
        private System.Windows.Forms.Button NHAN;
        private System.Windows.Forms.Button TRU;
        private System.Windows.Forms.Button CONG;
        private System.Windows.Forms.Label bt_numberKQ;
        private System.Windows.Forms.Label bt_number2;
        private System.Windows.Forms.Label MTDG;
        private System.Windows.Forms.Label bt_number1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
    }
}


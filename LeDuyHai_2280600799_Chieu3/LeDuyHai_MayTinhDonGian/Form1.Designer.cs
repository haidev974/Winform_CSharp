namespace LeDuyHai_MayTinhDonGian
{
    partial class demClickChuot
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
            this.btn_clickMe = new System.Windows.Forms.Button();
            this.lbl_soLanClick = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình đếm click chuột";
            // 
            // btn_clickMe
            // 
            this.btn_clickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_clickMe.Location = new System.Drawing.Point(264, 134);
            this.btn_clickMe.Name = "btn_clickMe";
            this.btn_clickMe.Size = new System.Drawing.Size(99, 43);
            this.btn_clickMe.TabIndex = 1;
            this.btn_clickMe.Text = "Click me!";
            this.btn_clickMe.UseVisualStyleBackColor = true;
            this.btn_clickMe.Click += new System.EventHandler(this.btn_clickMe_Click);
            this.btn_clickMe.MouseEnter += new System.EventHandler(this.btn_clickMe_MouseEnter);
            this.btn_clickMe.MouseLeave += new System.EventHandler(this.btn_clickMe_MouseLeave);
            // 
            // lbl_soLanClick
            // 
            this.lbl_soLanClick.AutoSize = true;
            this.lbl_soLanClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_soLanClick.Location = new System.Drawing.Point(237, 211);
            this.lbl_soLanClick.Name = "lbl_soLanClick";
            this.lbl_soLanClick.Size = new System.Drawing.Size(147, 29);
            this.lbl_soLanClick.TabIndex = 0;
            this.lbl_soLanClick.Text = "Số lần click: ";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Location = new System.Drawing.Point(402, 134);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(83, 43);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // demClickChuot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 281);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_clickMe);
            this.Controls.Add(this.lbl_soLanClick);
            this.Controls.Add(this.label1);
            this.Name = "demClickChuot";
            this.Text = "CT ĐẾM SỐ LẦN CLICK CHUỘT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clickMe;
        private System.Windows.Forms.Label lbl_soLanClick;
        private System.Windows.Forms.Button btn_xoa;
    }
}


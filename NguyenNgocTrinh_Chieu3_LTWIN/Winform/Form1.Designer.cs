namespace Winform
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
            this.lbl_demclick = new System.Windows.Forms.Label();
            this.btn_clickme = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.lbl_solan = new System.Windows.Forms.Label();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_demclick
            // 
            this.lbl_demclick.AutoSize = true;
            this.lbl_demclick.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_demclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_demclick.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_demclick.Location = new System.Drawing.Point(258, 84);
            this.lbl_demclick.Name = "lbl_demclick";
            this.lbl_demclick.Size = new System.Drawing.Size(521, 32);
            this.lbl_demclick.TabIndex = 0;
            this.lbl_demclick.Text = "CHƯƠNG TRÌNH ĐẾM CLICK CHUỘT";
            // 
            // btn_clickme
            // 
            this.btn_clickme.Location = new System.Drawing.Point(171, 214);
            this.btn_clickme.Name = "btn_clickme";
            this.btn_clickme.Size = new System.Drawing.Size(283, 91);
            this.btn_clickme.TabIndex = 1;
            this.btn_clickme.Text = "CLICK ME";
            this.btn_clickme.UseVisualStyleBackColor = true;
            this.btn_clickme.Click += new System.EventHandler(this.btn_clickme_Click);
            this.btn_clickme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_clickme_MouseClick);
            this.btn_clickme.MouseHover += new System.EventHandler(this.btn_clickme_MouseHover);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(620, 214);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(283, 91);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "XÓA";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.MouseLeave += new System.EventHandler(this.btn_del_MouseLeave);
            // 
            // lbl_solan
            // 
            this.lbl_solan.AutoSize = true;
            this.lbl_solan.Location = new System.Drawing.Point(446, 391);
            this.lbl_solan.Name = "lbl_solan";
            this.lbl_solan.Size = new System.Drawing.Size(97, 16);
            this.lbl_solan.TabIndex = 3;
            this.lbl_solan.Text = "SỐ LẦN CLICK:";
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(549, 385);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(131, 22);
            this.txt_kq.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 504);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.lbl_solan);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_clickme);
            this.Controls.Add(this.lbl_demclick);
            this.Name = "Form1";
            this.Text = "frm_Maytinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.btn_clickme_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_demclick;
        private System.Windows.Forms.Button btn_clickme;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label lbl_solan;
        private System.Windows.Forms.TextBox txt_kq;
    }
}


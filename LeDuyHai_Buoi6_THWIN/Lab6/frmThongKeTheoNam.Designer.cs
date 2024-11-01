namespace Lab6
{
    partial class frmThongKeTheoNam
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
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rpvThongKeTheoNam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReport.Location = new System.Drawing.Point(453, 27);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(180, 44);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(57, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê theo năm";
            // 
            // rpvThongKeTheoNam
            // 
            this.rpvThongKeTheoNam.Location = new System.Drawing.Point(12, 80);
            this.rpvThongKeTheoNam.Name = "rpvThongKeTheoNam";
            this.rpvThongKeTheoNam.ServerReport.BearerToken = null;
            this.rpvThongKeTheoNam.Size = new System.Drawing.Size(731, 373);
            this.rpvThongKeTheoNam.TabIndex = 2;
            // 
            // frmThongKeTheoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 465);
            this.Controls.Add(this.rpvThongKeTheoNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Name = "frmThongKeTheoNam";
            this.Text = "frmThongKeTheoNam";
            this.Load += new System.EventHandler(this.frmThongKeTheoNam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvThongKeTheoNam;
    }
}
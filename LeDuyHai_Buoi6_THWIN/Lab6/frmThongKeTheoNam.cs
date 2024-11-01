using Lab6.Models;
using Lab6.Reporting;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class frmThongKeTheoNam : Form
    {
        public frmThongKeTheoNam()
        {
            InitializeComponent();
        }

        private void frmThongKeTheoNam_Load(object sender, EventArgs e)
        {
            //ReportThongKeTheoNam();
        }

        private void ReportThongKeTheoNam()
        {
            using (var _dbConntext = new SachDB_Context())
            {
                string TruyVan = "select NamXB, MaSach, TenSach, TenLoai " +
                                "from Sach s, LoaiSach l " +
                                "where s.MaLoai = l.MaLoai " +
                                "order by NamXB desc";
                List<ThongKe> ds = _dbConntext.Database.SqlQuery<ThongKe>(TruyVan).ToList();
                rpvThongKeTheoNam.LocalReport.ReportPath = "ReportThongKeTheoNam.rdlc";
                var reportDataSource = new ReportDataSource("ThongKeTheoNamDataset", ds);
                this.rpvThongKeTheoNam.LocalReport.DataSources.Clear();
                this.rpvThongKeTheoNam.LocalReport.DataSources.Add(reportDataSource);
                this.rpvThongKeTheoNam.RefreshReport();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportThongKeTheoNam();
        }
    }
}

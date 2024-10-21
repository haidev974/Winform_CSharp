using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDuyHai_QLThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //hàm ấn các form chưa dùng tới
        private void hideForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Hide();
            }
        }

        private void tsb_NhanVien_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if(f.Name == "frm_NhanVien")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frmNhanVien nv = new frmNhanVien();
            nv.MdiParent = this;
            nv.WindowState = FormWindowState.Maximized;
            nv.Show();
        }

        private void tsb_DocGia_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_DocGia")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frmDocGia dg = new frmDocGia();
            dg.MdiParent = this;
            dg.WindowState = FormWindowState.Maximized;
            dg.Show();
        }

        private void tsb_Sach_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_Sach")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frmSach s = new frmSach();
            s.MdiParent = this;
            s.WindowState = FormWindowState.Maximized;
            s.Show();
        }

        private void tsb_bangCap_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_BangCap")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frmBangCap bc = new frmBangCap();
            bc.MdiParent = this;
            bc.WindowState = FormWindowState.Maximized;
            bc.Show();
        }

        private void tsb_PhieuMuon_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_PhieuMuonSach")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frmPhieuMuonSach pm = new frmPhieuMuonSach();
            pm.MdiParent = this;
            pm.WindowState = FormWindowState.Maximized;
            pm.Show();
        }

        private void tsb_PhieuThu_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_PhieuThuTien")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frmPhieuThuTien pth = new frmPhieuThuTien();
            pth.MdiParent = this;
            pth.WindowState = FormWindowState.Maximized;
            pth.Show();
        }

        private void tsb_CTPheuMuon_Click(object sender, EventArgs e)
        {
            hideForm();
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frm_ChiTietPhieuMuon")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    return;
                }
            }
            frmChiTietPhieuMuon ctpm = new frmChiTietPhieuMuon();
            ctpm.MdiParent = this;
            ctpm.WindowState = FormWindowState.Maximized;
            ctpm.Show();
        }

        private void tsb_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenNgocTrinh_QuanLyThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //Hàm ẩn các form chưa dùng tới
        private void hideForm()
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.Name == "frmNhanVien")
                {
                    f.Hide();
                }    
            }    
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmSach")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Minimized;
                    return;
                }
            }
            frmSach s = new frmSach();
            s.MdiParent = this;
            s.WindowState = FormWindowState.Maximized;
            s.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
         
        }

        private void tsbNhanVien_Click(object sender, EventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.Name=="frm_NhanVien")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Minimized;
                    return;
                }    
            } 
            frmNhanVien nv=new frmNhanVien();
            nv.MdiParent = this;
            nv.WindowState = FormWindowState.Maximized;
            nv.Show();
        }

        private void tsbDocGia_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmDocGia")
                {
                    f.Activate();
                    f.BringToFront();
                    f.WindowState = FormWindowState.Minimized;
                    return;
                }
            }
            frmDocGia dg = new frmDocGia();
            dg.MdiParent = this;
            dg.WindowState = FormWindowState.Maximized;
            dg.Show();
        }

        private void nhânViênToolStripMenuItem_DisplayStyleChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}

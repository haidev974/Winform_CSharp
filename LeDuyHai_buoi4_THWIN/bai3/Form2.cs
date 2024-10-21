using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtKetQua.Text = " ";
            txtKetQua.Text = "0";
            cmbKhoa.SelectedIndex = 0;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn trở về?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvTimKiemSinhVien.Rows.Clear();
            txtHoTen.Text = "";
            txtMSSV.Text = "";
            txtKetQua.Text = "0";
        }
        void demSinhVien()
        {
            txtKetQua.Text = dgvTimKiemSinhVien.Rows.Count.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            demSinhVien();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

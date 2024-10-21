using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab03_03.Form1;

namespace Lab03_03
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Form1 formMain)
        {
            InitializeComponent();
            this.form1 = formMain;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbbKhoa.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chức năng thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Close();
        }
        void clearText()
        {
            txtMSSV.Text = "";
            txtTen.Text = string.Empty;
            txtDTB.Text = string.Empty;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSo = txtMSSV.Text;
            string tenSV = txtTen.Text;
            string khoa = cbbKhoa.SelectedItem?.ToString();
            string diemText = txtDTB.Text;
            if (string.IsNullOrWhiteSpace(maSo) || string.IsNullOrWhiteSpace(tenSV) || string.IsNullOrWhiteSpace(diemText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(diemText, out float diemTB) || diemTB < 0 || diemTB > 10)
            {
                MessageBox.Show("Điểm trung bình phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            form1.ThemSinhVien(maSo, tenSV, khoa, diemTB);
            clearText();
        }
    }
}
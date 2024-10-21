using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDuyHai_MayTinhDonGian
{
    public partial class demClickChuot : Form
    {
        private int soLanClick = 0;
        public demClickChuot()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clickMe_Click(object sender, EventArgs e)
        {
            soLanClick++;
            lbl_soLanClick.Text = "Số lần click: " + soLanClick.ToString();
        }

        private void btn_clickMe_MouseEnter(object sender, EventArgs e)
        {
            btn_clickMe.Text = "HI!!!";
            btn_clickMe.BackColor = Color.DeepPink;
        }

        private void btn_clickMe_MouseLeave(object sender, EventArgs e)
        {
            btn_clickMe.Text = "Click me!";
            btn_clickMe.BackColor = Color.White;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                soLanClick = 0;
                lbl_soLanClick.Text = "Số lần click: " + soLanClick.ToString();
            }
        }
    }
}

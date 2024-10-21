using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1_MayTinh
{
    public partial class Form1 : Form
    {
        float n1, n2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TRU_Click(object sender, EventArgs e)
        {
            bool checkNumber1 = float.TryParse(txtNumber1.Text, out n1);
            bool checkNumber2 = float.TryParse(txtNumber2.Text, out n2);

            if (checkNumber1 && checkNumber2)
            {
                txtKQ.Text = (n1 - n2).ToString();
            }
            else
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ!", "ERROR"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);//errpr: lỗi, Warning: Cảnh báo

            }
        }

        private void NHAN_Click(object sender, EventArgs e)
        {
            bool checkNumber1 = float.TryParse(txtNumber1.Text, out n1);
            bool checkNumber2 = float.TryParse(txtNumber2.Text, out n2);

            if (checkNumber1 && checkNumber2)
            {
                txtKQ.Text = (n1 * n2).ToString();
            }
            else
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ!", "ERROR"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);//errpr: lỗi, Warning: Cảnh báo

            }
        }

        private void CHIA_Click(object sender, EventArgs e)
        {
            bool checkNumber1 = float.TryParse(txtNumber1.Text, out n1);
            bool checkNumber2 = float.TryParse(txtNumber2.Text, out n2);

            if (checkNumber1 && checkNumber2)
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Giá trị thứ 2 không hợp lệ!", "ERROR"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);//errpr: lỗi, Warning: Cảnh báo
                }
                txtKQ.Text = (n1 / n2).ToString();
            }
            else
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ!", "ERROR"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);//errpr: lỗi, Warning: Cảnh báo

            }
        }

        private void CONG_Click(object sender, EventArgs e)
        {
            bool checkNumber1 = float.TryParse(txtNumber1.Text, out n1);
            bool checkNumber2 = float.TryParse(txtNumber2.Text, out n2);

            if (checkNumber1 && checkNumber2)
            {
                txtKQ.Text = (n1 + n2).ToString();
            }
            else
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ!", "ERROR"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);//errpr: lỗi, Warning: Cảnh báo

            }
        }
    }
}

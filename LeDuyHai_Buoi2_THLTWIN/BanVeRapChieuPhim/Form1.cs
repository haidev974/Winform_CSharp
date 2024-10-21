using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BanVeRapChieuPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbn_tongTien.Text = " 0 đ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button)
                {
                    control.Click += new EventHandler(button20_Click);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Vị trí này đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btn.BackColor = Color.Blue;
            }
        }

        private void button_chon_Click(object sender, EventArgs e)
        {
            int tongTien = 0;
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    if (btn.BackColor == Color.Blue)
                    {
                        int seatNumber = int.Parse(btn.Text);

                        if (seatNumber >= 1 && seatNumber <= 5)
                        {
                            tongTien += 30000;
                        }
                        else if (seatNumber >= 6 && seatNumber <= 10)
                        {
                            tongTien += 40000;
                        }
                        else if (seatNumber >= 11 && seatNumber <= 15)
                        {
                            tongTien += 50000;
                        }
                        else if (seatNumber >= 16 && seatNumber <= 20)
                        {
                            tongTien += 80000;
                        }
                        btn.BackColor = Color.Yellow;
                    }
                }
            }
            tbn_tongTien.Text = " " + tongTien.ToString() + " đ";
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;

                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.White;
                    }
                }
            }

            tbn_tongTien.Text = " 0 đ";
        }

        private void button_ketThuc_Click(object sender, EventArgs e)
        {
            tbn_tongTien.Text = " 0 đ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clickme_Click(object sender, EventArgs e)
        {

        }

        private void btn_clickme_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void btn_clickme_MouseEnter(object sender, EventArgs e)
        {
            btn_clickme.Text = "Please click me";
            btn_clickme.BackColor = Color.DeepPink;

        }

        private void btn_del_MouseLeave(object sender, EventArgs e)
        {
            btn_clickme.Text = "Click me";
            btn_clickme.BackColor= Color.White;
        }

        private void btn_clickme_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

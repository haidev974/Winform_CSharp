using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStrip_ThoiGian.Text = string.Format("Hôm nay là ngày: {0}, {1}",
                DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gọi hộp thoại mở file
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "AVI file|*.avi|MPEG File|*.mpeg|Wav File|*.Wav|Midi File|*.midi|Mp4 File|*.mp4|MP3|*.mp3|All file|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
            }    
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}

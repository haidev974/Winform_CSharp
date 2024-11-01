using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHIEUAN.Model;

namespace PHIEU_AN
{
    public partial class frm_PhieuAn : Form
    {
        DBContext db = new DBContext();
        List<PHIEU_AN> phieuAnList;
        public frm_PhieuAn()
        {
            InitializeComponent();
        }

        private void frm_PhieuAn_Load(object sender, EventArgs e)
        {
            phieuAnList = db.PHIEU_AN.ToList();
        }
    }
}

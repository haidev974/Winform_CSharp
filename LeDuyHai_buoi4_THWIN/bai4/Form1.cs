using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bai4.Models;

namespace bai4
{
    public partial class Form1 : Form
    {
        ProductDBContext db = new ProductDBContext();
        private List<Invoice> iList; // Khai báo danh sách hóa đơn toàn cục
        private List<Order> oList; // Khai báo danh sách đơn hàng toàn cục

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oList = db.Orders.ToList(); 
            iList = db.Invoices.ToList(); 
            dgvDonHang.Rows.Clear();
            fillDonHang(iList, oList);

            DateTime currentDate = DateTime.Now;
            dtpNgayDau.Value = currentDate;
            dtpNgayCuoi.Value = currentDate;

            LoadDataByDate(currentDate, currentDate);

            txtTongCong.Text = SoLuongDonHang().ToString();
        }

        private void fillDonHang(List<Invoice> iList, List<Order> oList)
        {
            dgvDonHang.Rows.Clear();

            foreach (var item in iList)
            {
                int n = dgvDonHang.Rows.Add();
                var totalAmount = oList
                    .Where(o => o.InvoiceNo == item.InvoiceNo) // Lọc
                    .Sum(o => o.Price * o.Quantity);
                dgvDonHang.Rows[n].Cells[0].Value = dgvDonHang.Rows.Count - 1;
                dgvDonHang.Rows[n].Cells[1].Value = item.InvoiceNo;
                dgvDonHang.Rows[n].Cells[2].Value = item.OrderDate.ToString("dd/MM/yyyy");
                dgvDonHang.Rows[n].Cells[3].Value = item.DeliveryDate.ToString("dd/MM/yyyy");
                dgvDonHang.Rows[n].Cells[4].Value = totalAmount;
            }
        }

        int SoLuongDonHang()
        {
            return dgvDonHang.Rows.Count - 1;
        }

        private void chbXemTatCa_CheckedChanged(object sender, EventArgs e)
        {
            DateTime timeCheck = dtpNgayDau.Value;
            if (chbXemTatCa.Checked)
            {
                DateTime firstDayOfMonth = new DateTime(timeCheck.Year, timeCheck.Month, 1);
                DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                dtpNgayDau.Value = firstDayOfMonth;
                dtpNgayCuoi.Value = lastDayOfMonth;

                LoadDataByDate(firstDayOfMonth, lastDayOfMonth);
            }
            txtTongCong.Text = SoLuongDonHang().ToString();
        }
        private void LoadDataByDate(DateTime fromDate, DateTime toDate)
        {
            if (iList == null)
            {
                MessageBox.Show("Danh sách hóa đơn không được khởi tạo.");
                return;
            }

            if (!iList.Any())
            {
                MessageBox.Show("Không có hóa đơn nào để hiển thị.");
                return;
            }

            var filteredInvoices = iList
                .Where(i => i.DeliveryDate >= fromDate.AddDays(-1) && i.DeliveryDate <= toDate.AddDays(-1)) // Subtract 1 day from each date
                .ToList();

            fillDonHang(filteredInvoices, oList);
            txtTongCong.Text = SoLuongDonHang().ToString();
        }

        private void dtpNgayDau_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromDate = dtpNgayDau.Value;
            DateTime toDate = dtpNgayCuoi.Value;
            //if (fromDate > toDate)
            //{
            //    MessageBox.Show("Ngày đầu phải nhỏ hơn ngày cuối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dtpNgayDau.Value = toDate;
            //    return;
            //}
            LoadDataByDate(fromDate, toDate);
            txtTongCong.Text = SoLuongDonHang().ToString();
        }

        private void dtpNgayCuoi_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromDate = dtpNgayDau.Value;
            DateTime toDate = dtpNgayCuoi.Value;
            if(fromDate > toDate)
            {
                MessageBox.Show("Ngày đầu phải nhỏ hơn ngày cuối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgayCuoi.Value = fromDate;
                return;
            }
            LoadDataByDate(fromDate, toDate);
            txtTongCong.Text = SoLuongDonHang().ToString();
        }
    }
}

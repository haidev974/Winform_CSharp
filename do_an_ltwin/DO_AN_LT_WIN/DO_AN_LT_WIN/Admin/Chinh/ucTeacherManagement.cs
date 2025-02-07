﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using DO_AN_LT_WIN.Entities;

namespace DO_AN_LT_WIN.Admin.Chinh
{
    public partial class ucTeacherManagement : UserControl
    {
        public ucTeacherManagement()
        {
            InitializeComponent();
            LoadData();
            cbo_khoa.SelectedIndex = 0;
            cbo_trinhdo.SelectedIndex = 0;
            cbo_chucvu.SelectedIndex = 0;
            dgv_giangvien.CellFormatting += dgv_giangvien_CellFormatting;
        }

        private void LoadData()
        {
            using (var context = new DBContext())
            {
                // Lấy danh sách sinh viên và thông tin người dùng
                var data = (from gv in context.Giang_Vien
                            join u in context.User on gv.Ma_Giang_Vien equals u.Ma_Giang_Vien
                            select new
                            {
                                UserID = u.UserID.Trim(),
                                UserName = u.UserName.Trim(),
                                Password = u.Password.Trim(),
                                MaSoGV = gv.Ma_Giang_Vien.Trim(),
                                Ho = u.Ho.Trim(),
                                Ten = u.Ten.Trim(),
                                GioiTinh = u.Gioi_Tinh,
                                NgaySinh = u.Ngay_Sinh,
                                Email = u.Email.Trim(),
                                SoDienThoai = u.So_Dien_Thoai.Trim(),
                                DiaChi = u.Dia_Chi.Trim(),
                                Khoa = gv.Khoa.Trim(),
                                ChucVu = gv.Chuc_Vu.Trim(),
                                TrinhDo = gv.Trinh_Do.Trim()
                                //Trang_Thai_Hoc_Tap = gv.Trang_Thai_Hoc_Tap
                            }).ToList();

                // Gọi hàm BindGrid để gán dữ liệu cho DataGridView
                BindGrid(data.Cast<object>().ToList());
            }
        }
        private void BindGrid(List<object> list)
        {
            dgv_giangvien.Rows.Clear();
            foreach (var item in list)
            {
                var obj = (dynamic)item; // Chuyển đổi item thành dynamic để truy cập các thuộc tính

                int index = dgv_giangvien.Rows.Add();
                dgv_giangvien.Rows[index].Cells[0].Value = obj.UserID;       // User ID
                dgv_giangvien.Rows[index].Cells[1].Value = obj.UserName;     // User Name
                dgv_giangvien.Rows[index].Cells[2].Value = obj.Password;      // Password
                dgv_giangvien.Rows[index].Cells[3].Value = obj.MaSoGV;       // Mã Số gv
                dgv_giangvien.Rows[index].Cells[4].Value = obj.Ho;           // Họ
                dgv_giangvien.Rows[index].Cells[5].Value = obj.Ten;          // Tên
                dgv_giangvien.Rows[index].Cells[6].Value = obj.GioiTinh ? "Nam" : "Nữ"; // Giới Tính
                dgv_giangvien.Rows[index].Cells[7].Value = obj.NgaySinh;     // Ngày Sinh
                dgv_giangvien.Rows[index].Cells[8].Value = obj.Email;        // Email
                dgv_giangvien.Rows[index].Cells[9].Value = obj.SoDienThoai;  // Số Điện Thoại
                dgv_giangvien.Rows[index].Cells[10].Value = obj.DiaChi;      // Địa Chỉ
                dgv_giangvien.Rows[index].Cells[11].Value = obj.Khoa;        // Khoa
                dgv_giangvien.Rows[index].Cells[12].Value = obj.TrinhDo;
                dgv_giangvien.Rows[index].Cells[13].Value = obj.ChucVu;

                //dgv_sinhvien.Rows[index].Cells[12].Value = obj.trang_thai_hoc_tap;
            }
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            using (var context = new DBContext())
            {
                try
                {
                    // Kiểm tra các trường không được để trống
                    if (string.IsNullOrWhiteSpace(txt_magiangvien.Text))
                    {
                        MessageBox.Show("Mã giảng viên không được để trống.");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txt_username.Text))
                    {
                        MessageBox.Show("Tên đăng nhập không được để trống.");
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txt_password.Text))
                    {
                        MessageBox.Show("Mật khẩu không được để trống.");
                        return;
                    }
                  

                    // Kiểm tra các thuộc tính unique trong Giang_Vien
                    if (context.Giang_Vien.Any(gv => gv.Ma_Giang_Vien == txt_magiangvien.Text))
                    {
                        MessageBox.Show("Mã giảng viên đã tồn tại. Vui lòng nhập mã khác.");
                        return;
                    }
                    if (context.User.Any(u => u.UserID == txt_username.Text))
                    {
                        MessageBox.Show("User ID đã tồn tại. Vui lòng nhập tên đăng nhập khác.");
                        return;
                    }

                    // Tạo đối tượng giảng viên mới
                    var newTeacher = new Giang_Vien
                    {
                        Ma_Giang_Vien = txt_magiangvien.Text,
                        Chuc_Vu = cbo_chucvu.Text,
                        Trinh_Do = cbo_trinhdo.Text,
                        Khoa = cbo_khoa.Text, // Khoa từ ComboBox
                        Trang_Thai_Lam_Viec = true
                    };

                    // Thêm giảng viên vào cơ sở dữ liệu
                    context.Giang_Vien.Add(newTeacher);
                    context.SaveChanges(); // Lưu giảng viên trước để có ID

                    // Tạo đối tượng người dùng mới
                    var newUser = new User
                    {
                        UserID = txt_username.Text,
                        Ma_Giang_Vien = newTeacher.Ma_Giang_Vien,
                        UserName = txt_username.Text,
                        Password = txt_password.Text,
                        Ho = txt_ho.Text,
                        Ten = txt_ten.Text,
                        So_Dien_Thoai = txt_sodienthoai.Text,
                        Email = txt_email.Text,
                        Dia_Chi = txt_diachi.Text,
                        Gioi_Tinh = rb_nam.Checked, // Lấy giá trị giới tính từ RadioButton
                        Ngay_Sinh = dtp_ngaysinh.Value,
                        Ngay_Cap = DateTime.Now,
                        Trang_Thai_Hoat_Dong = true
                    };

                    // Thêm người dùng vào cơ sở dữ liệu
                    context.User.Add(newUser);
                    context.SaveChanges(); // Lưu người dùng

                    // Tải lại dữ liệu
                    LoadData();

                    MessageBox.Show("Thêm giảng viên thành công!");
                }
                catch (DbUpdateException ex) when (ex.InnerException?.Message.Contains("unique") == true)
                {
                    MessageBox.Show("Lỗi: Mã giảng viên hoặc User ID đã tồn tại.");
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Thuộc tính: {validationError.PropertyName} Lỗi: {validationError.ErrorMessage}");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khóa ngoại khi thêm giảng viên");
                }
            }
        }



        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (var context = new DBContext())
            {
                try
                {
                    // Lấy mã giảng viên từ ô nhập liệu
                    string maGiangVien = txt_magiangvien.Text;

                    // Tìm giảng viên theo mã
                    var teacher = context.Giang_Vien.FirstOrDefault(gv => gv.Ma_Giang_Vien == maGiangVien);
                    var user = context.User.FirstOrDefault(u => u.Ma_Giang_Vien == maGiangVien);

                    if (teacher == null)
                    {
                        MessageBox.Show("Không tìm thấy giảng viên.");
                        return;
                    }

                    // Cập nhật thông tin giảng viên
                    teacher.Chuc_Vu = cbo_chucvu.Text;
                    teacher.Trinh_Do = cbo_trinhdo.Text;
                    teacher.Khoa = cbo_khoa.Text;
                    // teacher.Trang_Thai_Lam_Viec = chk_trangthailamviec.Checked ? 1 : 0; // Nếu cần thiết

                    // Cập nhật thông tin người dùng
                    if (user != null)
                    {
                        user.UserName = txt_username.Text;
                        user.Password = txt_password.Text;
                        user.Ho = txt_ho.Text;
                        user.Ten = txt_ten.Text;
                        user.So_Dien_Thoai = txt_sodienthoai.Text;
                        user.Email = txt_email.Text;
                        user.Dia_Chi = txt_diachi.Text;
                        user.Gioi_Tinh = rb_nam.Checked; // Giới tính
                        user.Ngay_Sinh = dtp_ngaysinh.Value; // Ngày sinh
                    }

                    // Lưu thay đổi vào cơ sở dữ liệu
                    context.SaveChanges();

                    // Tải lại dữ liệu
                    LoadData();

                    MessageBox.Show("Sửa giảng viên và thông tin người dùng thành công!");
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show("Lỗi khi sửa giảng viên: " + ex.InnerException?.Message);
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Thuộc tính: {validationError.PropertyName} Lỗi: {validationError.ErrorMessage}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi sửa giảng viên: " + ex.Message);
                }
            }
        }



        private void dgv_giangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng đã chọn
            {
                var selectedRow = dgv_giangvien.Rows[e.RowIndex]; // Lấy hàng đã chọn

                // Gán giá trị từ các ô trong hàng đã chọn vào các ô nhập liệu
                txt_userid.Text = selectedRow.Cells[0].Value?.ToString();      // User ID
                txt_username.Text = selectedRow.Cells[1].Value?.ToString();    // User Name
                txt_password.Text = selectedRow.Cells[2].Value?.ToString();    // Password
                txt_magiangvien.Text = selectedRow.Cells[3].Value?.ToString(); // Mã số giảng viên
                txt_ho.Text = selectedRow.Cells[4].Value?.ToString();          // Họ
                txt_ten.Text = selectedRow.Cells[5].Value?.ToString();         // Tên

                // Xác định giới tính
                rb_nam.Checked = selectedRow.Cells[6].Value?.ToString() == "Nam"; // Giới tính Nam
                rb_nu.Checked = !rb_nam.Checked; // Giới tính Nữ (ngược lại với Nam)

                // Chuyển đổi giá trị ngày sinh sang kiểu DateTime
                if (DateTime.TryParse(selectedRow.Cells[7].Value?.ToString(), out DateTime ngaysinh))
                {
                    dtp_ngaysinh.Value = ngaysinh; // Đặt giá trị cho DateTimePicker
                }

                txt_email.Text = selectedRow.Cells[8].Value?.ToString();        // Email
                txt_sodienthoai.Text = selectedRow.Cells[9].Value?.ToString();  // Số điện thoại
                txt_diachi.Text = selectedRow.Cells[10].Value?.ToString();      // Địa chỉ

                // Tìm và đặt giá trị khoa trong ComboBox
                cbo_khoa.Text = selectedRow.Cells[11].Value?.ToString();        // Khoa

                // Chức vụ
                cbo_trinhdo.Text = selectedRow.Cells[12].Value?.ToString();
                cbo_chucvu.Text = selectedRow.Cells[13].Value?.ToString();      // Chức Vụ
                
            }
        }

        private void dgv_giangvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đây là cột Password (cột thứ 3, index = 2)
            if (dgv_giangvien.Columns[e.ColumnIndex].Index == 2 && e.Value != null)
            {
                // Chuyển đổi mật khẩu thành dấu *
                e.Value = new string('*', e.Value.ToString().Length);
                e.FormattingApplied = true; // Ngăn chặn định dạng thêm
            }
        }

        
    }
}

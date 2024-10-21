using bai1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1.BUS
{
    public class FacultyService
    {
        public List<Faculty> GetAll()
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            return context.Faculties.ToList();
        }
        // Tìm kiếm Khoa theo ID
        public Faculty FindById(int facultyID)
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            return context.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);
        }

        // Thêm hoặc cập nhật Khoa
        public void InsertUpdate(Faculty faculty)
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            var existingFaculty = context.Faculties.FirstOrDefault(f => f.FacultyID == faculty.FacultyID);

            if (existingFaculty != null)
            {
                // Cập nhật thông tin nếu khoa đã tồn tại
                existingFaculty.FacultyName = faculty.FacultyName;
                // Cập nhật các trường khác nếu có...
            }
            else
            {
                // Thêm khoa mới
                context.Faculties.Add(faculty);
            }

            context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
        }

        // Xóa Khoa
        public void Delete(int facultyID)
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            var faculty = context.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

            if (faculty != null)
            {
                context.Faculties.Remove(faculty); // Xóa khỏi cơ sở dữ liệu
                context.SaveChanges(); // Lưu thay đổi
            }
        }
    }
}

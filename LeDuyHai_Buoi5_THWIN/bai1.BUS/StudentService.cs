using bai1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace bai1.BUS
{
    public class StudentService
    {
        //tạo đối tượng kết nối csdl
        public List<Student> GetAll()
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            return context.Students.ToList();
        }

        public List<Student> GetAllHasNoMajor()
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            return context.Students.Where(p => p.MajorID == null).ToList();
        }

        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            return context.Students.Where(p => p.MajorID == null && p.FacultyID == facultyID).ToList();
        }
        public List<Student> GetAllHasNoMajor(int facultyID, int MajorID)
        {
            using (SinhVienDatabaseContext context = new SinhVienDatabaseContext())
            {
                return context.Students
                              .Include(s => s.Faculty) // Bao gồm thông tin về Faculty
                              .Where(s => s.FacultyID == facultyID && (s.MajorID == null || s.MajorID != MajorID))
                              .ToList();
            }
        }
        public void DeleteStudent(string studentId)
        {
            using (SinhVienDatabaseContext context = new SinhVienDatabaseContext())
            {
                Student studentToDelete = context.Students.FirstOrDefault(s => s.StudentID == studentId);
                if (studentToDelete != null)
                {
                    context.Students.Remove(studentToDelete);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Không tìm thấy sinh viên có MSSV: " + studentId);
                }
            }
        }
        public Student FindById(string studentId)
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            return context.Students.FirstOrDefault(p => p.StudentID == studentId);
        }

        public void InsertUpdate(Student s)
        {
            SinhVienDatabaseContext context = new SinhVienDatabaseContext();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }
    }
}
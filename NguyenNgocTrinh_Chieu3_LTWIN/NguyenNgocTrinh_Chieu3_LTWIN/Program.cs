using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenNgocTrinh_Chieu3_LTWIN;

namespace NguyenNgocTrinh_Chieu3_LTWIN
{
    internal class Program
    {
        private static bool exit;

        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>();
            StudentList.Add(new Student("22899999", "Tran Van A", 9, "CNTT"));
            StudentList.Add(new Student("22888888", "Tran Van B", 8, "KTY"));
            StudentList.Add(new Student("22777777", "Tran Van C", 5, "MKT"));
            StudentList.Add(new Student("22866666", "Tran Van D", 10, "QTKD"));
            StudentList.Add(new Student("22855555", "Tran Van E", 7, "CNTT"));
            int chon = 1;
            while (chon > 0)
            {
                Console.WriteLine("=== MENU===");
                Console.WriteLine("1. Them Sinh Vien ");
                Console.WriteLine("2.Hien thi danh sach sinh vien");
                Console.WriteLine("3.Xuat ra thong tin sinh vien deu thuoc khoa CNNT ");
                Console.WriteLine("4. Xuat ra 3 sinh vien co diem cao nhat");
                Console.WriteLine("Chon chuc nang! ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        AddStudent(StudentList);
                        break;
                    case 2:
                        DisplayStudentList(StudentList);
                        break;
                    case 3:
                        DisplayStudentByfaculty(StudentList, "cnnt");
                        break;
                    case 4:
                        top3SVDTBCaoNhat(StudentList);
                        break;
                    case 0:
                        exit = true;
                        Console.WriteLine(" ket thuc chuong trinh . ");
                        break;
                    default:
                        Console.WriteLine("tuy chon khong hop le . vui long chon lai. ");
                        break;

                }
                Console.WriteLine();

            }
        }
        // THÊM VÀO 1 SINH VIÊN 
        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("Nhap thong tin sinh vien === ");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("them sinh vien thanh cong!");

        }
        static void DisplayStudentList(List<Student> studentsList)
        {
            Console.WriteLine("=== Danh sach  chi tiet thong tin sinh vien ===");
            foreach (Student student in studentsList)
            {
                student.Show();

            }
        }
        static void DisplayStudentByfaculty(List<Student> studentList, string facylty)
        {
            Console.WriteLine("=== danh sach sinh vien thuoc khoa {0}", facylty);
            var student = studentList.Where(s => s.Faculty1.Equals(facylty, StringComparison.OrdinalIgnoreCase));
            DisplayStudentList(studentList);
        }
        static void top3SVDTBCaoNhat(List<Student> studentList)
        {
            Console.WriteLine("=== 3 Sinh Vien Co Diem Cao Nhat ===");
            var top3Students = studentList
                .OrderByDescending(s => s.AverageScore)
                .Take(3);
            DisplayStudentList(top3Students.ToList());
        }
    }
}
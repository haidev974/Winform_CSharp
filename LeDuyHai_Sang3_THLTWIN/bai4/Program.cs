using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("               CHUONG TRINH QUAN LY DANH SACH SINH VIEN");
            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student("111", "Hai", 8.0f, "CNTT"));
            studentsList.Add(new Student("222", "DUong", 5.0f, "QTKD"));
            studentsList.Add(new Student("333", "Nguyen", 6.0f, "CNTT"));
            studentsList.Add(new Student("444", "Dat", 7.0f, "CNTT"));
            studentsList.Add(new Student("555", "Trai", 3.0f, "CNTT"));
            studentsList.Add(new Student("666", "Tien", 4.0f, "QTKD"));
            studentsList.Add(new Student("777", "Hao", 9.0f, "CNTT"));
            studentsList.Add(new Student("888", "Phat", 1.0f, "CNTT"));
            studentsList.Add(new Student("999", "Dang", 10.0f, "QTKD"));
            studentsList.Add(new Student("989", "Khoa", 10.0f, "CNTT"));
            studentsList.Add(new Student("898", "Tai", 10.0f, "QTKD"));
            bool exit = false;
            while (!exit)
            {
                menu();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh.");
                        break;
                    case 1:
                        THem1SV(studentsList);
                        break;
                    case 2:
                        XuatDS(studentsList);
                        break;
                    case 3:
                        XuatDSIT(studentsList, "CNTT");
                        break;
                    case 4:
                        XuatDS_Diemhon5(studentsList, 5);
                        break;
                    case 5:
                        SapXepDTB(studentsList);
                        break;
                    case 6:
                        XuatDS_IT_hon5(studentsList, "CNTT", 5);
                        break;
                    case 7:
                        XuatDS_DiemCao_IT(studentsList, "CNTT");
                        break;
                    case 8:
                        SoLuong_XepLoai(studentsList);
                        break;
                    default:
                        Console.WriteLine("Tuy chon khong hop le. Vui long chon lai.");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void menu()
        {
            Console.WriteLine();
            Console.WriteLine("               ~~~~~~~~~~~~~  MENU CHUC NANG  ~~~~~~~~~~~~~~~~");
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine("| 1. Them sinh vien                                                         |");
            Console.WriteLine("| 2. Hien thi danh sach sinh vien                                           |");
            Console.WriteLine("| 3. Xuat danh sach sinh vien thuoc khoa CNTT                               |");
            Console.WriteLine("| 4. Xuat danh sach sinh vien co DTB >= 5                                   |");
            Console.WriteLine("| 5. Xuat danh sach sinh vien duoc sap xep tang dan theo DTB                |");
            Console.WriteLine("| 6. Xuat danh sach sinh vien co DTB >= 5 va thuoc khoa CNTT                |");
            Console.WriteLine("| 7. Xuat danh sach sinh vien co diem trung binh cao nhat va thuoc khoa CNTT|");
            Console.WriteLine("| 8. So luong xep loai (xuat sac, gioi, kha, trung binh, yeu, kem)          |");
            Console.WriteLine("| 0. Thoat                                                                  |");
            Console.WriteLine("|___________________________________________________________________________|");
            Console.Write("Chon chuc nang (0-8): ");
        }

        private static void SoLuong_XepLoai(List<Student> studentsList)
        {
            var students = studentsList.GroupBy(s => s.tinhdiem()).Select(Group => new { tinhdiem = Group.Key, Count = Group.Count() }).ToList();
            if (!students.Any())
            {
                Console.WriteLine("KHONG CO SINH VIEN TRONG DANH SACH");
            }
            else
            {
                Console.WriteLine("<<< SO LUONG CAC XEP LOAI >>>");
                foreach (var studentGroup in students)
                {
                    Console.WriteLine($"Xep loai {studentGroup.tinhdiem}\t\t So luong: {studentGroup.Count}");
                }
            }
        }

        private static void XuatDS_DiemCao_IT(List<Student> studentList, string faculty)
        {
            
            var svIT = studentList.Where(s => s.Faculty == "CNTT").ToList();//sinh vien cntt
            if (!svIT.Any())
            {
                Console.WriteLine("KHONG CO SINH VIEN TRONG DANH SACH");
                return;
            }    
            var diemCaoNhat = svIT.Max(s => s.AverageScore);//diem cao nhat trong sv cntt
            var SVITDiemCao = svIT.Where(s => s.AverageScore == diemCaoNhat).ToList();
            if(SVITDiemCao.Any())
                Console.WriteLine("<<<DANH SACH SINH VIEN CO DIEM TRUNG BINH CAO NHAT VA THUOC KHOA {0} >>>", faculty);
            XuatDS(SVITDiemCao);
        }

        private static void XuatDS_IT_hon5(List<Student> studentList, string faculty, int minDTB)
        {
            var students = studentList.Where(s => s.AverageScore >= minDTB && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            if(students.Any())
                Console.WriteLine("<<< DANH SACH SINH VIEN CO DIEM TB >= {0} VA THUOC KHOA {1} >>>", minDTB, faculty);
            XuatDS(students);
        }

        private static void SapXepDTB(List<Student> studentList)
        {
            Console.WriteLine("<<< DANH SACH SINH VIEN DUOC SAP TANG DAN THEO DIEM TRUNG BINH >>> ");
            var sortedStudents = studentList.OrderBy(s => s.AverageScore).ToList();
            XuatDS(sortedStudents);
        }

        private static void XuatDS_Diemhon5(List<Student> studentList, int minDTB)
        {
            
            var students = studentList.Where(s => s.AverageScore > minDTB).ToList();
            if (students.Any())
                Console.WriteLine("<<< DANH SACH SINH VIEN CO DIEM TB >= {0} >>>", minDTB);
            XuatDS(students);
        }

        private static void XuatDSIT(List<Student> studentList, string faculty)
        {
            var students = studentList.Where(s => s.Faculty == faculty).ToList();
            if(students.Any())
                Console.WriteLine("<<< DANH SACH SINH VIEN THUOC KHOA {0} >>>", faculty);
            XuatDS(students);
        }

        static void THem1SV(List<Student> studentList)
        {
            Console.WriteLine("=== Nhap thong tin sinh vien ===");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Them sinh vien thanh cong!");
        }
        static void XuatDS(List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                student.Show();
            }
            if (!studentList.Any())
            {
                Console.WriteLine("KHONG CO SINH VIEN TRONG DANH SACH");
            }
        }
    }
}

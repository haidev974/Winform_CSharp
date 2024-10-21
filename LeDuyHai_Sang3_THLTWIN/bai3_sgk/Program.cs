using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_sgk
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Teacher> listTeacher = new List<Teacher>();
            List<Student> listStudent = new List<Student>();

            listStudent.Add(new Student("S01", "Nguyen Van A", 8.5f, "CNTT"));
            listStudent.Add(new Student("S02", "Le Thi B", 7.8f, "Kinh Te"));
            listStudent.Add(new Student("S03", "Tran Van C", 9.0f, "Y Duoc"));
            listStudent.Add(new Student("S04", "Pham Thi D", 6.5f, "Quan Tri Kinh Doanh"));
            listStudent.Add(new Student("S05", "Hoang Van E", 7.2f, "Ky Thuat"));
            listStudent.Add(new Student("S06", "Vu Thi F", 8.0f, "CNTT"));
            listStudent.Add(new Student("S07", "Bui Van G", 8.9f, "Luat"));
            listStudent.Add(new Student("S08", "Nguyen Thi H", 9.5f, "Kien Truc"));
            listStudent.Add(new Student("S09", "Tran Van I", 7.6f, "Du Lich"));

            listTeacher.Add(new Teacher("T01", "Nguyen Van Khoa", "123 Le Loi, Quan 1"));
            listTeacher.Add(new Teacher("T02", "Tran Thi Lan", "456 Dien Bien Phu, Quan 3"));
            listTeacher.Add(new Teacher("T03", "Le Van Minh", "789 Nguyen Trai, Quan 5"));
            listTeacher.Add(new Teacher("T04", "Hoang Thi Mai", "101 Le Van Luong, Quan 7"));
            listTeacher.Add(new Teacher("T05", "Pham Van Duc", "202 Le Hong Phong, Quan 10"));
            listTeacher.Add(new Teacher("T06", "Nguyen Thi Hoa", "303 Hoang Hoa Tham, Quan Tan Binh"));
            listTeacher.Add(new Teacher("T07", "Bui Van An", "404 Pham Van Dong, Quan Binh Thanh"));
            listTeacher.Add(new Teacher("T08", "Vu Thi Thuy", "505 Truong Sa, Quan Phu Nhuan"));
            listTeacher.Add(new Teacher("T09", "Do Van Phuoc", "606 Vo Van Ngan, Quan Thu Duc"));
            listTeacher.Add(new Teacher("T10", "Nguyen Van Phat", "707 Le Van Viet, Quan 9"));
            listTeacher.Add(new Teacher("T11", "Tran Thi Bao", "808 Do Xuan Hop, Quan 9"));
            listTeacher.Add(new Teacher("T12", "Le Van Hoang", "909 Nguyen Duy Trinh, Quan 9"));

            bool exit = false;
            while (!exit)
            {
                Menu();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("\t\t|  KET THUC CHUONG TRINH |");
                        Console.WriteLine("\t\t~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                    case 1:
                        them1SV(listStudent);
                        break;
                    case 2:
                        them1GV(listTeacher);
                        break;
                    case 3:
                        xuatDS_SV(listStudent);
                        break;
                    case 4:
                        XuatDS_GV(listTeacher);
                        break;
                    case 5:
                        soLuongTungDS(listStudent, listTeacher);
                        break;
                    case 6:
                        XuatDS_SV_CNTT(listStudent);
                        break;
                    case 7:
                        XuatDS_GVQ9(listTeacher);
                        break;
                    case 8:
                        XuatDS_DiemCao_IT(listStudent);
                        break;
                    case 9:
                        SoLuong_XepLoai(listStudent);
                        break;
                    case 10:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le! Nhap lai -> ");
                        break;
                }
            }
        }

        private static void SoLuong_XepLoai(List<Student> listStudent)
        {
            var loai = new List<string> { "Xuat sac", "Gioi", "Kha", "TB", "Yeu", "Kem" };
            var students = listStudent.GroupBy(s => s.tinhdiem()).Select(Group => new { XLoai = Group.Key, Count = Group.Count() }).ToList();

            var fullList = loai.GroupJoin(students,xepLoai => xepLoai,s => s.XLoai,
                   (xepLoai, studentGroup) => new
                   {
                       XepLoai = xepLoai,
                       Count = studentGroup.FirstOrDefault()?.Count ?? 0
                   }).ToList();
            Console.WriteLine("<<< SO LUONG CAC XEP LOAI >>>");
            foreach (var studentGroup in fullList)
            {
                Console.WriteLine($"Xep loai {studentGroup.XepLoai, -20}So luong: {studentGroup.Count}");
            }
        }

        private static void XuatDS_DiemCao_IT(List<Student> listStudent)
        {
            var svIT = listStudent.Where(s => s.Falcury == "CNTT").ToList();
            if (!svIT.Any())
            {
                Console.WriteLine("KHONG CO SINH VIEN TRONG DANH SACH");
                return;
            }
            var diemCaoNhat = svIT.Max(s => s.Avg);
            var SVITDiemCao = svIT.Where(s => s.Avg == diemCaoNhat).ToList();
            if (SVITDiemCao.Any())
                Console.WriteLine("<<< DANH SACH SINH VIEN CO DIEM TRUNG BINH CAO NHAT VA THUOC KHOA CNTT >>>");
            xuatDS_SV(SVITDiemCao);
        }

        private static void XuatDS_GVQ9(List<Teacher> listTeacher)
        {
            var tcq9 = listTeacher.Where(t => t.DiaChi.Contains("Quan 9"));
            if (!tcq9.Any())
                Console.WriteLine("KHONG CO GIAO VIEN O QUAN 9:");
            else
            {
                Console.WriteLine("\t\t\t>>> DANH SACH GIAO VIEN O QUAN 9 <<<");
                Console.WriteLine("\t{0,-6}{1,-15}{2,-50}", "ID", "Ten", "Dia Chi");
                Console.WriteLine(new string('-', 88));
            }
            foreach (var item in tcq9)
            {
                Console.Write("\t");
                item.output();
            }
        }

        private static void XuatDS_SV_CNTT(List<Student> listStudent)
        {
            var ls = listStudent.Where(s => s.Falcury == "CNTT").ToList();
            if(ls.Any())
                Console.WriteLine(">>> DANH SACH SINH VIEN THUOC KHOA CNTT <<<");
            xuatDS_SV(ls);
        }

        private static void soLuongTungDS(List<Student> listStudent, List<Teacher> listTeacher)
        {
            Console.WriteLine("So luong sinh vien trong danh sach sinh vien la: " + listStudent.Count);
            Console.WriteLine("So luong giao vien trong danh sach giao vien la: " + listTeacher.Count);
        }

        private static void XuatDS_GV(List<Teacher> listTeacher)
        {
            if (!listTeacher.Any())
                Console.WriteLine("KHONG CO GIAO VIEN TRONG DANHH SACH");
            else
            {
                Console.WriteLine("\t\t\t>>> DANH SACH GIAO VIEN <<<\n");
                Console.WriteLine("\t{0,-6}{1,-20}{2,-50}", "ID", "Ten", "Dia Chi");
                Console.WriteLine(new string('-', 88));
            }
            foreach (var item in listTeacher)
            {
                Console.Write("\t");
                item.output();
            }
        }

        private static void xuatDS_SV(List<Student> listStudent)
        {
            if(!listStudent.Any())
                Console.WriteLine("KHONG CO SINH VIEN TRONG DANHH SACH");
            else
            {
                Console.WriteLine("\t\t\t>>> DANH SACH SINH VIEN <<<\n");
                Console.WriteLine("\t{0,-6}{1,-20}{2,-10}{3, -15}", "ID", "Ten", "DiemTB", "Khoa");
                Console.WriteLine(new string('-', 88));
            }
            foreach (var item in listStudent)
            {
                Console.Write("\t");
                item.output();
            }
        }

        private static void them1GV(List<Teacher> listTeacher)
        {
            Console.WriteLine("- Nhap thong tin Giao vien");
            Teacher tc = new Teacher();
            tc.input();
            listTeacher.Add(tc);
            Console.WriteLine("Them giao vien thanh cong");
        }

        private static void them1SV(List<Student> listStudent)
        {
            Console.WriteLine(" - Nhap thong tin sinh vien");
            Student st = new Student();
            st.input();
            listStudent.Add(st);
            Console.WriteLine("Them sinh vien thanh cong");
        }

        private static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("                     ~~~~~~~~~~~~~  MENU CHUC NANG  ~~~~~~~~~~~~~~~~");
            Console.WriteLine("____________________________________________________________________________________________");
            Console.WriteLine("|1.  Them 1 sinh vien                                                                      |");
            Console.WriteLine("|2.  Them 1 giao vien                                                                      |");
            Console.WriteLine("|3.  Xuat danh sach sinh vien                                                              |");
            Console.WriteLine("|4.  Xuat danh sach giao vien                                                              |");
            Console.WriteLine("|5.  So luong tung danh sach                                                               |");
            Console.WriteLine("|6.  Xuat danh sach cac sinh vien thuoc khoa 'CNTT'                                        |");
            Console.WriteLine("|7.  Xuat danh sach giao vien co dia chi chua thong tin 'Quan 9'                           |");
            Console.WriteLine("|8.  Xuat danh sach sinh vien co diem trung binh cao nhat va thuoc khoa CNTT               |");
            Console.WriteLine("|9.  Hay cho biet so luong cua tung xep loai trong danh sach? Biet rang theo thang diem 10 |");
            Console.WriteLine("|10. CLEAR cmd                                                                             |");
            Console.WriteLine("|0.  THOAT CHUONG TRINH                                                                    |");
            Console.WriteLine("|__________________________________________________________________________________________|");
            Console.Write("Chon chuc nang (0-9): ");
        }
    }
}

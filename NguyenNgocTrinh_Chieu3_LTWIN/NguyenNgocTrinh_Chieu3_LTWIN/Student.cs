using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenNgocTrinh_Chieu3_LTWIN
{
    public class Student
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string Faculty;

        public Student()
        {
        }

        public Student(string studentID, string fullName, float averageScore, string faculty)
        {
            this.StudentID = studentID;
            this.FullName = fullName;
            this.AverageScore = averageScore;
            Faculty1 = faculty;
        }

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty1 { get => Faculty; set => Faculty = value; }
        //4. Methods
        public void Input()
        {
            Console.Write("Nhập MSSV:");
            StudentID = Console.ReadLine();
            Console.Write("Nhập Họ tên Sinh viên:");
            FullName = Console.ReadLine();
            Console.Write("Nhập Điểm TB:");
            AverageScore = float.Parse(Console.ReadLine()); //ép sang kiểu float 
            Console.Write("Nhập Khoa:");
            Faculty1 = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("MSSV:{0} Họ Tên:{1} Khoa:{2} ĐiêmTB:{3}",
            this.StudentID, this.FullName, this.Faculty1, this.AverageScore);
        }
    }
}



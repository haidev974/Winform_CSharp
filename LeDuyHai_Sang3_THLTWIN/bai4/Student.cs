using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Student
    {
        private string studentID;
        private string fullname;
        private float averageScore;
        private string faculty;

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullname; set => fullname = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public Student() { }
        public Student(string studentID, string fullname, float averageScore, string faculty)
        {
            this.studentID = studentID;
            this.fullname = fullname;
            this.averageScore = averageScore;
            this.faculty = faculty;

        }
        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            StudentID = Console.ReadLine();
            Console.Write("Nhap Ho ten sinh vien: ");
            FullName = Console.ReadLine();
            Console.Write("Nhap Diem TB: ");
            AverageScore = float.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("MSSV: {0}     \t| Ho Ten: {1}     \t| Khoa: {2}     \t| DiemTB: {3}", this.studentID, this.fullname, this.Faculty, this.AverageScore);
        }
        public string tinhdiem()
        {
            if (AverageScore >= 9.0) return "Xuat sac";
            else if (AverageScore >= 8.0) return "Gioi";
            else if (AverageScore >= 7.0) return "Kha";
            else if (AverageScore >= 5.0) return "TB";
            else if (AverageScore >= 4.0) return "Yeu";
            else return "Kem";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_sgk
{
    public class Student : Person
    {
        private float avg;
        private string falcury;
        public Student() { }
        public Student(string name, string id, float avg, string falcury) : base(id, name)
        {
            this.avg = avg;
            this.falcury = falcury;
        }

        public float Avg { get => avg; set => avg = value; }
        public string Falcury { get => falcury; set => falcury = value; }

        public new void input()
        {
            base.input();
            Console.Write("Nhap diem TB: ");
            avg = float.Parse(Console.ReadLine());
            Console.Write("Nhap khoa: ");
            falcury = Console.ReadLine();
        }

        public new void output()
        {
            base.output();
            Console.WriteLine("{0, -10}{1, -15}", Avg, falcury);
        }
        public string tinhdiem()
        {
            if (avg >= 9.0) return "Xuat sac";
            else if (avg >= 8.0) return "Gioi";
            else if (avg >= 7.0) return "Kha";
            else if (avg >= 5.0) return "TB";
            else if (avg >= 4.0) return "Yeu";
            else return "Kem";
        }
    }
}

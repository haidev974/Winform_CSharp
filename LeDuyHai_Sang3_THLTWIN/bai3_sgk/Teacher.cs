using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_sgk
{
    public class Teacher : Person
    {
        private string diaChi;

        public Teacher() { }

        public Teacher(string name, string id, string diaChi) : base(id, name)
        {
            this.diaChi = diaChi;
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public new void input()
        {
            base.input();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
        }
        public new void output()
        {
            base.output();
            Console.WriteLine("{0, -50}", diaChi);
        }
    }
}

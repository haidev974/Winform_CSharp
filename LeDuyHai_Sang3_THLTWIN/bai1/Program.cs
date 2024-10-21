using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void ctnt()
        {
            float cong, tru, nhan, chia, a, b;
            Console.WriteLine("+ - * /");

            Console.Write("Nhap a = ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Nhap b = ");
            b = float.Parse(Console.ReadLine());

            cong = a + b;
            tru = a - b;
            nhan = a * b;
            chia = a / b;

            Console.WriteLine("{0} + {1} = {2}", a, b, cong);
            Console.WriteLine("{0} - {1} = {2}", a, b, tru);
            Console.WriteLine("{0} * {1} = {2}", a, b, nhan);
            Console.WriteLine("{0} / {1} = {2}", a, b, chia);
        }
        static void Main(string[] args)
        {
            ctnt();
        }
    }
}

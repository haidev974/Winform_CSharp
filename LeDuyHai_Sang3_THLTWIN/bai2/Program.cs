using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void demsochan()
        {
            int cnt = 0, sum = 0, n;
            do
            {
                Console.Write("Nhap n = ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0) Console.WriteLine("Nhap lai!");
            } while (n <= 0);
            Console.Write("Cac so chan: ");
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    cnt++;
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine("\nSo chan tu 0 den {0} la {1}", n, cnt);
            Console.WriteLine("Tong cac so chan tu 0 den {0} la {1}", n, sum);

        }
        static void Main(string[] args)
        {
            demsochan();
        }
    }
}

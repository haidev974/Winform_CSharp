using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_sgk
{
    public class Person
    {
        private string name;
        private string id;

        public Person() { }
        public Person(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }

        public void input()
        {
            Console.Write("Nhap ma: ");
            id = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            name = Console.ReadLine();
        }

        public void output()
        {
            Console.Write("{0, -6}{1, -20}", id, name);
        }
    }
}

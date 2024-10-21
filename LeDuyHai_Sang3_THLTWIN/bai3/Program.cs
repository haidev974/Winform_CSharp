using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static string GetFeedBack(string target, string guess)
        {
            string feedback = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == guess[i])
                    feedback += "+";
                else if (target.Contains(guess[i].ToString()))
                    feedback += "?";
            }
            return feedback;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh doan so");
            Random random = new Random();
            int targetNumber = random.Next(100, 999);
            string targetString = targetNumber.ToString();
            int attempt = 1, MAX_GUESS = 7;
            string guess, feedback = " ";
            while (feedback != "+++" && attempt <= MAX_GUESS)
            {
                Console.Write("\nLan doan thu {0}: ", attempt);
                do
                {
                    guess = Console.ReadLine();
                    if (guess.Length != 3)
                        Console.Write("Khong hop le! Nhap lai:");
                } while (guess.Length != 3);
                
                feedback = GetFeedBack(targetString, guess);
                Console.WriteLine("Phan hoi tu may tinh: {0}", feedback);
                attempt++;
            }
            Console.WriteLine("Nguoi da doan {0} Lan. Tro choi ket thuc!", attempt - 1);
            if (feedback != "+++")
                Console.WriteLine("Nguoi choi thua cuoc. So can doan {0}", targetNumber);
            else
                Console.WriteLine("Nguoi choi thang cuoc", attempt);
            Console.ReadLine();
        }
    }
}
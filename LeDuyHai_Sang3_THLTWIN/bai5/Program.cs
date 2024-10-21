using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ĐỀ BÀI
 * Bạn phát đi thuê nhà là 10tr/ tháng (Cọc 2 tháng nhà 20tr _ sẽ trừ khi trả nhà)
 * Tiền nhà sẽ tăng 10% / năm
 * Hỏi nếu bạn Phát thuê nhà thì trong 20 năm bạn ấy phải trả bao nhiêu tiền???
 * Biết k là tiền thuê nhà, e là phần trăm tăng mỗi năm, n là số năm thuê
 * Hãy giúp bạn Phát 
 */


/*
 * GIẢI THÍCH
 * Vì tỉ lệ tăng là 10% 1 năm
 * => Cách làm: Mỗi khi đóng tiền nhà thì sẽ đóng cho 1 năm và cộng với 10% tiền nhà của năm đó
 * C2: Tổng tiền = tiền năm + tỷ lệ (tiền năm trước đó)
 */

namespace bai5
{
    internal class Program
    {
        static double tinhtien(double k, double e, int n)
        {
            double tienNam = k * 12;
            double tienTang = 0;
            double tongTien = tienNam;// năm đầu
            for (int i = 0; i < n - 1; i++)// n - 1 năm
            {
                //Console.WriteLine(tienNam + "\t" + tongTien);
                tienTang = tienNam * e;//tiền tăng là 10% của năm trước đó
                tienNam += tienTang;//tiền năm + số tiền tăng
                tongTien += tienNam;//tổng
                
            }
            return tongTien + 20000000;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("DEMO voi 10tr 1 thang, tang 10% 1 nam, PHAT thue 20 nam");
            Console.WriteLine("So tien PHAT phai dong = " + tinhtien(10000000, 0.1, 20));
            
            Console.WriteLine("\n_____Chuong trinh tinh tien nha cho PHAT_____");
            Console.WriteLine("Huong dan:");
            Console.WriteLine("Tien thang: Nhap 10 => 10000000");
            Console.WriteLine("Ty le tang: Nhap 10 => 10%\n\n");
            while (true)
            {
                Console.Write("Nhap so tien thang: ");
                double tienThang = double.Parse(Console.ReadLine());
                tienThang = tienThang * 1000000;

                Console.Write("Nhap so phan tram tang moi nam: ");
                double tyle = double.Parse(Console.ReadLine());
                tyle = tyle / 100;

                Console.Write("Nhap so nam PHAT thue: ");
                int nam = int.Parse(Console.ReadLine());

                Console.WriteLine("So tien PHAT phai dong = " + tinhtien(tienThang, tyle, nam));

                Console.Write("\n\tBan co muon tinh nua khong: (c: co & k: khong): ");
                char r = char.Parse(Console.ReadLine());
                if(r == 'k')
                    break;
            }
            Console.WriteLine("DUI DEEEE");
            Console.ReadKey();
        }
    }
}

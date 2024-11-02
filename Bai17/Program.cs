using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static int Tong(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        // giai thua
        static int GiaiThua(int n)
        {
            if (n == 0)
                return 1;
            return n * GiaiThua(n - 1);
        }
        // Tham tri: truyen gia tri cua bien
        static void ThamTri(int a)
        {
            a = a + 5;
            Console.WriteLine("Gia tri cua a trong ham la: " + a);
        }
        // Tham chieu: truyen dia chi cua bien
        static void ThamChieu(ref int b)
        {
            b = b + 5;
            Console.WriteLine("Gia tri cua a trong ham la: " + b);
        }
        // Tham chieu out
        static void ThamChieu2(out int c)
        {
            c = 10;
            c = c + 5;
            Console.WriteLine("Gia tri cua a trong ham la: " + c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong cua a va b la: " + Tong(a, b));
        
            // xuat giai thua
            Console.WriteLine("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Giai thua cua " + n + " la: " + GiaiThua(n));

            // Tham tri
            int x = 10;
            Console.WriteLine(x);
            ThamTri(x);
            Console.WriteLine("Gia tri cua x sau khi goi ham la: " + x);
            // Tham chieu
            int y = 10;
            Console.WriteLine(y);
            ThamChieu(ref y);
            Console.WriteLine("Gia tri cua y sau khi goi ham la: " + y);
            ThamChieu2(out y);
            Console.ReadKey();

        }
    }
}

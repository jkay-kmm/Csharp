using System;
using System.Text;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai tap C# 12
//for
            Console.WriteLine("Nhap so nguyen");
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Giai thua cua {0} la {1}", n, factorial);
//while
            Console.WriteLine("Nhap so nguyen");
            int n1 = int.Parse(Console.ReadLine());
            long factorial1 = 1;
            while (n1 > 0)
            {
                factorial1 *= n1;
                n1--;
            }
            Console.WriteLine("Giai thua cua {0} la {1}", n, factorial1);

            // Bai tap C# 13
            int a;
            int tong = 0;
            Console.WriteLine(" nhap so a");
            a = int.Parse(Console.ReadLine());

            if (a % 2 != 0)
            {
                Console.WriteLine("bye bye");
            }
            else
            {
                for (int i = 0; i < a; i += 2)
                {
                    tong += i;
                }
                Console.WriteLine("Tong cac so chan tu 0 den {0} la: {1}", a, tong);
            }

            // Bai tap C# 14
            Console.OutputEncoding = Encoding.UTF8;
            int n3 = 0;
            int tong2 = 0;
            Console.WriteLine("Nhập số nguyên n: ");
            n3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n3; i += 2)
            {
                if (i == 3)
                    continue;
                tong2 += i;
            }
            Console.WriteLine("Tong cac so le tu 1 den {0} la: {1}", n3, tong2);
        }
    }
}

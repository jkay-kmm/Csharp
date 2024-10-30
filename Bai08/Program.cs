using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();
            //Lay so ngau nhien
             int n = rnd.Next(1, 100);
            Console.WriteLine("So ngau nhien la: " + n);

            double k2 = rnd.NextDouble();
            Console.WriteLine("So ngau nhein K2 la" + k2);
            Console.ReadKey();

            // Datetime

          
            DateTime ngaysinh = new DateTime(1999, 12, 31);
            Console.WriteLine("Ngay sinh cua ban la: " + ngaysinh.ToString("dd/MM/yyyy"));
            DateTime ngayhientai = DateTime.Parse("12/12/2023");
            Console.WriteLine("Ngay hien tai la: " + ngayhientai.ToString("dd/MM/yyyy"));
            Console.ReadKey();

            //Viet chuong trih nhap vao
            Console.WriteLine("Nhap vao ngay sinh cua ban: ");
            string s = Console.ReadLine();
            DateTime ngaysinh1 = DateTime.Parse(s);
            Console.WriteLine("Ngay sinh cua ban la: " + ngaysinh1.ToString("dd/MM/yyyy"));
            Console.ReadKey();
        }
    }
}

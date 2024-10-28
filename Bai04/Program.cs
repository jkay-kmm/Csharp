using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r, dt, cv;
            const float PI = 3.14f;
            Console.WriteLine("moi nhap vao ban kinh cua duong tron:");
            r = float.Parse(Console.ReadLine());
            cv = 2 * r * PI;
            dt = r * r * PI;
            Console.WriteLine("chu vi cua duong tron la: {0}", cv);
            Console.WriteLine("dien tich cua duong tron la: {0}", dt);
            Console.ReadLine();
            int x =1, y = 2;
            int z = x++ - ++y + 1;
            Console.WriteLine("x = " +x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.ReadLine();
            Console.Write("Nhập chiều dài (a): ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Nhập chiều rộng (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        double dienTich = a * b;
        double chuVi = (a + b) * 2;

        Console.WriteLine("Diện tích hình chữ nhật: " + dienTich);
        Console.WriteLine("Chu vi hình chữ nhật: " + chuVi);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai tap if else
            // Bai 4
            Console.WriteLine("Nhap tong hai so: ");
            double tong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap hieu hai so: ");
            double hieu = double.Parse(Console.ReadLine());
            double a = (tong + hieu) / 2;
            double b = tong - a;
            Console.WriteLine("So thu nhat la: " + a);
            Console.WriteLine("So thu hai la: " + b);
            Console.ReadLine();
            //Bai 5 
            Console.WriteLine("Nhap can nang: ");
            double canNang = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu cao: ");
            double chieuCao = double.Parse(Console.ReadLine());
            double BMI = canNang / (chieuCao * chieuCao);
            if (BMI < 15)
            {
                Console.WriteLine("Qua gay");
            }
            else if (BMI >= 15 && BMI < 16)
            {
                Console.WriteLine("Hoi gay");

            }
            else if (BMI >= 16 && BMI < 18.5)
            {
                Console.WriteLine("Gay nhe");

            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Bình thường");
            }
            else if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("Hơi béo");
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("Béo");
            }
            else
            {
                Console.WriteLine("Béo phì ");
            }
            Console.ReadLine();
            // Bai 6
            Console.WriteLine("Nhap nam : ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Nam nhuan");
            }
            else
            {
                Console.WriteLine("Khong phai nam nhuan");
            }
            Console.ReadLine();
            // Bai 7
            Console.WriteLine("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            switch (thang)
            {
                case 1:
                    Console.WriteLine("Thang 1 co 31 ngay");
                    break;
                case 2:
                    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                    {
                        Console.WriteLine("Thang 2 co 29 ngay");
                    }
                    else
                    {
                        Console.WriteLine("Thang 2 co 28 ngay");
                    }
                    break;
                case 3:
                    Console.WriteLine("Thang 3 co 31 ngay");
                    break;
                case 4:
                    Console.WriteLine("Thang 4 co 30 ngay");
                    break;
                case 5:
                    Console.WriteLine("Thang 5 co 31 ngay");
                    break;
                case 6:
                    Console.WriteLine("Thang 6 co 30 ngay");
                    break;
                case 7:
                    Console.WriteLine("Thang 7 co 31 ngay");
                    break;
                case 8:
                    Console.WriteLine("Thang 8 co 31 ngay");
                    break;
                case 9:
                    Console.WriteLine("Thang 9 co 30 ngay");
                    break;
                case 10:
                    Console.WriteLine("Thang 10 co 31 ngay");
                    break;
                case 11:
                    Console.WriteLine("Thang 11 co 30 ngay");
                    break;
                case 12:
                    Console.WriteLine("Thang 12 co 31 ngay");
                    break;
                default:
                    Console.WriteLine("Nhap sai thang");
                    break;
            }
            Console.ReadLine();

            // Bai C#10: ap dung toan tu 3 ngoi
            float dtb;
            Console.WriteLine("nhap diem trung binh");
            dtb = float.Parse(Console.ReadLine());
            string kq = (dtb >=8 )? "Gioi" :((dtb<8 && dtb >=6.5)? "Kha" :(dtb <6.5 && dtb >=5)? "Trung binh":"Yeu");
            Console.WriteLine(kq);
            Console.ReadLine();

            // Bai C#11: ap dung switch case
            int luachon;
            luachon = int.Parse(Console.ReadLine());
            switch (luachon)
            {
                case 1:
                    Console.WriteLine("tim kiem theo ten");
                    break;
                case 2:
                    Console.WriteLine("Tim kiem theo ten tac gia");
                    break;
                case 3:
                    Console.WriteLine("Tim kiem theo nha xb");
                    break;
                case 4:
                    Console.WriteLine("Tim kiem theo tieu de");
                    break;
                default:
                    Console.WriteLine("lua chon sai rooi");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ds2 = new List<string>();
            List<int> ds4 = new List<int>() {1, 2, 3,4, 4,4, 6};
            foreach (var item in ds4)
            {
                Console.WriteLine(item);
            }
            ds4.Add(7); // them phan tu vao cuoi list
            ds4.Remove(4); // xoa phan tu dau tien 
            Console.WriteLine(ds4.Count); // dem so phan tu trong list
            ds4.Clear(); // xoa tat ca phan tu trong list
            List<int> ds65 = new List<int>() { 1, 3, 4 };
            List<int> d754 = new List<int>() { 1, 3, 754 };
            ds65.AddRange(d754); // them tat ca phan tu cua list d754 vao list ds65
            bool kq = ds65.Contains(3); // kiem tra phan tu co trong list hay khong
            Console.WriteLine(kq);
            // Bai 24
            Console.WriteLine(" moi nhap vao so phan tu n :");
            int n = int.Parse(Console.ReadLine());
            Random rd = new Random();
            List<int> ds = new List<int>();
            for (int i = 0; i < n; i++)
            {
                ds.Add(rd.Next(1, 101));
            }
            Console.WriteLine("danh sach ngau nhien vua tao ra la");
            foreach (var i in ds)
            {
                Console.WriteLine(i+ " ");
            }
            //Bai 26
            List<string> quest = new List<string>() { "2 + 5 +7 = ", "5 * 10 =", "sqrt(16) =", "12%2=", "5//2=" };
            List<int> tra = new List<int>() { 14, 50, 4, 0, 2 };
            for (int i = 0; i < quest.Count; i++)
            {
                Console.WriteLine(quest[i]);
                int kq1 = int.Parse(Console.ReadLine());
                if (kq1 == tra[i])
                {
                    Console.WriteLine("dung");
                }
                else
                {
                    Console.WriteLine("sai");
                }
            }
            //Bai 27
            Console.WriteLine("moi nhap vao so phan tu n :");
            int n3 = int.Parse(Console.ReadLine());
            List<int> ds3 = new List<int>();
            for (int i = 0; i < n3; i++)
            {
                Console.WriteLine("moi nhap vao phan tu thu " + i);
                int k = int.Parse(Console.ReadLine());
                ds3.Add(k);
            }
            // xuat danh sach
            Console.WriteLine("danh sach ban vua nhap la");
            foreach (var i in ds3)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            // in ra co bao nhieu so nho hon 5
            int dem = 0;
            foreach (var i in ds3)
            {
                if (i < 5)
                {
                    dem++;
                }
            }
            // in ra vi tri cua index cac so do 
            for( int i = 0; i < ds3.Count; i++)
            {
                if (ds3[i] < 5)
                {
                    Console.WriteLine("vi tri cua so " + ds3[i] + " la " + i);
                }
            }
            // Bai 28
            List< int> ds5 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> ds6 = new List<int>();
            ds6.AddRange(ds5);
            // xuat danh sach
            Console.WriteLine(" danh sach 2 sau khi chay");
            ds6.Remove(ds6.Max());
            ds6.Remove(ds6.Min());
            foreach (var i in ds6)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine(" phan tu lon thu 2 trong danh sach la " +ds6.Max());
            Console.WriteLine(" phan tu nho thu 2 trong danh sach la " + ds6.Min());
            // in ra vi tri index dung
            for(int i = 0; i < ds6.Count; i++)
            {
                if (ds6[i] == ds6.Max())
                {
                    Console.WriteLine("vi tri cua phan tu lon nhat la " + i);
                }
                if (ds6[i] == ds6.Min())
                {
                    Console.WriteLine("vi tri cua phan tu nho nhat la " + i);
                }
            }
            Console.ReadKey();

        }
    }
}

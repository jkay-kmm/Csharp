using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao mang
            int[] stt;
            char[] ten;
            string[] diachi;
            // khoi tao mang
            stt = new int[5];
            foreach (int i in stt)
            {
                Console.WriteLine("Nhap so thu tu: ");
                stt[i] = int.Parse(Console.ReadLine());
            }

            // khoi tao va gan gia tri cho mang
            int[] mang43 = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int i in mang43)
            {
                Console.WriteLine(i);
            }
            //  length kiem tra do dai cua mang
            int dai = mang43.Length;
            Console.WriteLine("Do dai cua mang la: " + dai);
            //  truy xuat phan tu cua mang  qua index
            int[] mang54 = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Phan tu thu 3 cua mang la: " + mang54[2]);
            // duyet mang
            int[] mang98 = new int[5] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < mang98.Length; i++)
            {
                Console.WriteLine(mang98[i]);
            }
            // gan mang
            int[] mang76 = new int[5] { 1, 2, 3, 4, 5 };
            int[] mang77 = new int[5];
            mang77 = mang76;
            Console.WriteLine(mang77);
            //Reverse
             int[] mang1 = new int[5] { 1, 2, 3, 4, 5 };
            Array.Reverse(mang1);
            foreach (int i in mang1)
            {
                Console.WriteLine(i);
            }
            //Sort
            int[] mang2 = new int[5] { 1, 2, 3, 4, 5 };
            Array.Sort(mang2);
            foreach (int i in mang2)
            {
                Console.WriteLine(i);
            }
              Console.ReadKey();

        }
    }
    }


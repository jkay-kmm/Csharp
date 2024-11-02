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
            int[,] arr = new int[3, 4];
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr3 = new int[4, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            // khoi tao mang ngau nhien
            Random rd = new Random();
            int dong = 3;
            int cot = 4;
            int[,] arr5 = new int[dong, cot];
            for( int i = 0; i < dong;i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    arr5[i, j] = rd.Next(1, 100);
                }
            }
            //xuat mang
            for (int  i = 0;  i <  arr5.GetLength(0);  i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    Console.Write(arr5[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

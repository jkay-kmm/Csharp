using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            a += 3;
            Console.WriteLine("A) a += 3: " + a); 

          
            a = 5;

            Console.WriteLine("B) a = 5: " + a); 

        
            a *= 2;
            Console.WriteLine("C) a *= 2: " + a); 

            
            a = 5;
            a /= 9;
            Console.WriteLine("D) a /= 9: " + a); 

           
            a = 5;

            int remainder = a % 5;
            Console.WriteLine("E) a % 5: " + remainder); 

            int b = 2;
            a = a - (b + 7);
            Console.WriteLine("F) a = a - (b + 7): " + a); // Kết quả: -4
        }
    }
}

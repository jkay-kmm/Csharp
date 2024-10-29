using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pi = " +Math.PI);
            Console.WriteLine("kieu du lieu cua math .pi" +Math.PI.GetType().ToString());
            float pi = (float)Math.PI;
            Console.WriteLine("Pi = " + pi);

            //Can bac 2 
            int a = 4;
            int b = 50;
            Console.WriteLine("Can bac 2 cua {0} la {1}", a, Math.Sqrt(a));
            Console.WriteLine("Can bac 2 cua {0} la {1}", b, Math.Sqrt(b));
            //luy thua
            Console.WriteLine("2 mu 3 = " + Math.Pow(2, 3));
            //max
            Console.WriteLine("Max(2,3) = " + Math.Max(2, 3));
            //lamtron
            Console.WriteLine("Lam tron 2.3 = " + Math.Round(2.3));

        }
    }
}

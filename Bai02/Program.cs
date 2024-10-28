using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int z = a + b;
            Console.WriteLine("Gia tri cua z la :" + z);
            var y = 12344;
            Console.WriteLine("kieu du lieu cua y la {0}", y.GetType().ToString());
        }
    }
}
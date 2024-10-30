using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char hi = 'a';
            Console.WriteLine("Nhap vao mot ki tu: " + hi);
            Console.Write(hi.GetType().ToString());
            
            // Ep kieu
            char hi1 = char.Parse("b");
            Console.WriteLine(hi1);
            Console.Write(hi1.GetType().ToString());
            
            // chuyen doi kieu du lieu
            char hi2 = Convert.ToChar("f");
            Console.WriteLine(hi1);
            Console.Write(hi1.GetType().ToString());
            // so sanh ki tu
            char hi3 = 'a';
            char hi4 = 'b';
            Console.WriteLine(hi3.CompareTo(hi4));
            // so sanh 2 ky tu  tra ve true false
            Console.WriteLine(hi3.Equals(hi4));
            // phuong  thuc
            Console.WriteLine(Char.IsDigit('t'));// chu so
            Console.WriteLine(Char.IsLetter('t'));// chu cai
            Console.ReadKey();
        }
    }
}

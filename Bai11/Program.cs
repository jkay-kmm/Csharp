using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chuoi20 = "Hello World";
            // IndexOf: Tim kiem chuoi con trong chuoi
              int kq = chuoi20.IndexOf("World");
            // LastIndexOf: Tim kiem chuoi con trong chuoi tu cuoi ve dau
              int kq2 = chuoi20.LastIndexOf("World");
            Console.WriteLine("Vi tri cua chuoi 'World' trong chuoi 'Hello World' la: " + kq);
            // remove: Xoa chuoi con trong chuoi
             string chuoi21 = chuoi20.Remove(5, 6);
            Console.WriteLine("Chuoi sau khi xoa chuoi con la: " + chuoi21);
             // Replace: Thay the chuoi con trong chuoi
             string chuoi22 = chuoi20.Replace("World", "C#");
             Console.WriteLine("Chuoi sau khi thay the chuoi con la: " + chuoi22);
              //startwith: Kiem tra chuoi co bat dau bang chuoi con hay khong
               bool kq3 = chuoi20.StartsWith("Hello");
            Console.WriteLine("Chuoi 'Hello World' co bat dau bang chuoi 'Hello' khong: " + kq3);
           Console.ReadKey();
    }
}
}

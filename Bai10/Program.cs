using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao chuoi
            string chuoi = "Hello World";
            Console.WriteLine("chuoi nhap vao la" + chuoi);
            // chuyen doi sang chuoi
            int i = 1234;
            Console.WriteLine(i.GetType().ToString());
            string str = i.ToString();
            Console.WriteLine(str.GetType().ToString());
            Console.WriteLine(str);
            //tach chuoi thanh ky tu le
            string chuoi3 = "Hello World";
            char[] kyTu = chuoi3.ToCharArray();
            Console.WriteLine(chuoi3);
            Console.WriteLine(chuoi3.GetType().ToString());
            //length
            string chuoi4 = "Hello World";
            int length = chuoi4.Length;
            Console.WriteLine(length);
            Console.WriteLine("ky tu thu 3 cua chuoi 4 la " + chuoi4[length -2]);

            //
            int demSo = 0;
            int demchuthuong = 0;
            int demchuhoa = 0;
            int demcach =0;
            string chuoi5 = "Hello World";
            char[] kyTu5 = chuoi5.ToCharArray();
            foreach (char c in kyTu5)
            {
               if(char.IsDigit(c))
                {
                    demSo++;
                }
                if (char.IsLower(c))
                {
                    demchuthuong++;
                }
                if (char.IsUpper(c))
                {
                    demchuhoa++;
                }
                if (char.IsWhiteSpace(c))
                {
                    demcach++;
                }
                Console.WriteLine(demchuthuong);
                Console.WriteLine(demchuhoa);
                Console.WriteLine(demSo);
                Console.WriteLine(demcach);

                //so sanh chuoi
                string chuoi6 = "Hello World";
                string chuoi7 = "Hello Worldfafafa";
                int kq = string.Compare(chuoi6, chuoi7);
                Console.WriteLine(kq);

                // kiem tra chuoi con
                string chuoi8 = "Helloeer World";
                string chuoi9 = "World";
                bool kq1 = chuoi8.Contains(chuoi9);
                Console.WriteLine(kq1);

                //Ham Copyto
                string chuoi10 = "Hello Worldrwwfs";
                char[] kyTu10 = new char[10];// tao mang ky tu co do dai 10
                chuoi10.CopyTo(6, kyTu10, 0, 10);
                //index 6 cua chuoi 10 copy 4 ky tu vao mang ky tu 10 tu vi tri 0

                //Ham bool EndWith
                string chuoi11 = "Hello World In C#";
                bool kq2 = chuoi11.EndsWith("C#");
                Console.WriteLine(kq2);

                // gan chuoi string Format
                int n = 34;
                string chuoi12 = string.Format("So n la {0}", n);
                Console.WriteLine(chuoi12);
                

                //Equals
                string chuoi13 = "Hello World";
                string chuoi14 = "Hello World";
                bool kq3 = chuoi13.Equals(chuoi14);
                Console.WriteLine(kq3);
                Console.ReadKey();
            }
        }
    }
}

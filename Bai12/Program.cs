using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 19 
            string str1 = " Toan = 7 , Ly = 8 , Hoa = 9 ";
            string[] lst = str1.Split(' ');
            string strSo = "";
            foreach (char c in str1)
            {
                if (Char.IsDigit(c))
                {
                    strSo += c + " ";
                    break;
                }
            }
            Console.WriteLine(strSo);
            strSo = strSo.Trim();
            string[] lst2 = strSo.Split(' ');
            int tong = 0;
            foreach (string s in lst2)
            {
                Console.WriteLine(s);
                tong += int.Parse(s);
            }
            Console.WriteLine("tong cac so can tim la " + tong);
            // Bai 20
            Console.WriteLine(" nhap it nhat 1 chu so");
            string mk = Console.ReadLine();
            bool check = true;
            int demSo = 0, demkytu = 0;
            while (check)
            {
                foreach (char c in mk)
                {
                    if (Char.IsDigit(c))
                    {
                        demSo++;
                    }
                    else if (Char.IsLetter(c))
                    {
                        demkytu++;
                    }
                }
                if (demkytu + demSo != 0 && mk.Length >= 6)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("nhap lai mat khau");
                    mk = Console.ReadLine();
                    check = true;
                }
            }
            // Bai 20 cach 2 

            //string login;
            //Console.WriteLine(" nhap mk");
            //login = Console.ReadLine();
            //int demLogin = 0;
            //while (true)
            //{
            //    bool kq = mk.Equals(login);
            //    if (kq)
            //    {
            //        Console.WriteLine("dung mk");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("nhap lai mk");
            //        login = Console.ReadLine();
            //        demLogin++;
            //        if (demLogin == 3)
            //        {
            //            Console.WriteLine("ban da nhap sai qua 3 lan");
            //            break;
            //        }
            //    }
            // Bai 21
            string a = "hidahdiadhaidhikajdad";
            string b = "fiafhaifhaa";
            Console.WriteLine(" moi ban nhap vao chuoi");
            string chuoiInput = Console.ReadLine();
            string chuoiOutput = "";
            foreach(char c in chuoiInput)
            {
                int indexkytu = a.IndexOf(c);
                chuoiOutput += b[indexkytu];
            }
            Console.WriteLine(chuoiOutput);
            // Bai 22
            string f = @"toi chiu hoc
                         toi chiu kho
                         toi chiu dau";
            string[] lst34 = f.Split(' ');
            int demkytu243 = 0;
            foreach (string s in lst34)
            {
                if ("toi".Equals(s))
                {
                    demkytu243++;
                }
                Console.WriteLine(demkytu243);
            }

            // Bai 23
            Console.WriteLine(" nhap vao 1 chuoi");
            string x = Console.ReadLine();
            string chuoi345 = "";
            string so344 = "";
            foreach (char c in x)
            {
                if( char.IsDigit(c))
                {
                    so344 += c;
                }
                else if (char.IsLetter(c))
                {
                    chuoi345 += c;
                }
            }
            Console.WriteLine(so344);
            Console.WriteLine(chuoi345);
            Console.ReadLine();
            }
        }
    }


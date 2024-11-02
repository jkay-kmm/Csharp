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
            // khai bao
            Dictionary<int, string> dic = new Dictionary<int, string>();
            // khoi tao va gan phan tu
            Dictionary<int, string> dic1 = new Dictionary<int, string>()
            {
                {1, "One"},
                {2, "Two"},
                {3, "Three"}
            };
            // them phan tu
            dic.Add(1, "Onefsafgfssf");
            // duyet dic
            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            // kiem tra key
            bool check = dic.ContainsKey(1);
            Console.WriteLine(check);
            // kiem tra value
            bool check1 = dic.ContainsValue("One");
            Console.WriteLine(check1);
            // dic[key] lay value tu key
            string value = dic[1];
            Console.WriteLine(value);
            // gan gia tri
            dic[1] = "Ones";
            // xoa phan tu theo key
            dic.Remove(1);
            // xoa tat ca phan tu
            dic.Clear();
            // dem so phan tu
            int count = dic.Count;
            Console.WriteLine(count);
            // chuyen value dic sang list
            List<string> list = dic.Values.ToList();
            // chuyen key dic sang list
            List<int> list1 = dic.Keys.ToList();

            // Bai 29
            Dictionary<string, string> dic2 = new Dictionary<string, string>()
            {
                {"1", "One"},
                {"2", "Two"},
                {"3", "Three"}
            };
            foreach (KeyValuePair<string, string> item in dic2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            // nhap vao username va password
            Console.WriteLine("Nhap username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Nhap password: ");
            string password = Console.ReadLine();
            // kiem tra username va password co ton tai khong
            if(dic2.ContainsKey(username) && dic2.ContainsValue(password))
            {
                Console.WriteLine("Dang nhap thanh cong");
            }
            else
            {
                Console.WriteLine("Dang nhap that bai");
            }
            
            Console.ReadKey();
        }
    }
}

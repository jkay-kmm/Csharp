using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    internal class Program
    {

        static void Ngoaile()
        {
            try
            {
                Console.WriteLine(" nhap vao ngay thang nam sinh");
                string ngay = Console.ReadLine();
                DateTime dt = DateTime.Parse(ngay);
                Console.WriteLine(" ngay thang nam sinh cua ban la: " + dt);
            }
            catch (FormatException e)
            {
                Console.WriteLine(" ban nhap sai dinh dang ngay thang nam sinh");
            }
            finally
            {
                Console.WriteLine(" cam on ban da su dung chuong trinh");
            }

        }
        static void Ngoaile2()
        {
            Console.WriteLine(" moi nhap vao tu so ");
            int tu = int.Parse(Console.ReadLine());
            Console.WriteLine(" moi nhap vao mau so ");
            int mau = int.Parse(Console.ReadLine());
            if( mau == 0)
                throw new ArithmeticException();
        }
        
        static void Main(string[] args)
        {
            //Ngoaile();
            try
            {
                Ngoaile2();
            }catch (ArithmeticException e)
            {
                Console.WriteLine(" mau so phai khac 0");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao
            Sinhvien sv = new Sinhvien();
            //xuat
            Console.WriteLine(sv.Hoten);
            Console.WriteLine(sv.Mssv);
            //tao doi tuong co truyen vao gia tri
            Sinhvien sv1 = new Sinhvien(123, "Nguyen Van B",10);
            //xuat
            Console.WriteLine(sv1.Hoten);
            Console.WriteLine(sv1.Mssv);
            // sua du lieu
            sv1.Hoten = "Nguyen Van C";
            sv1.Mssv = 456;
            Sinhvien sv2 = new Sinhvien(789, "Nguyen Van D", 8);
            sv2.Xuat();
            Giaovien gv = new Giaovien();
            gv.MonHoc = "Lap trinh C#";
            gv.DiaChi = "Ha Noi";

            Console.WriteLine("giao vien co chieu cao"+ gv.Chieucao());
            Phuhuynh ph = new Phuhuynh();
            ph.Ngoaihinh = "Dep trai";
            ph.Hoten = "Nguyen Van B";

            //ke thua tu lop cha ma ko can phai khai bao lai
            Console.WriteLine("phu huynf" +ph.Chieucao());
            Console.ReadKey();
        }
    }
}

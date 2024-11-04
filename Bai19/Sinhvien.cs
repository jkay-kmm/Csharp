using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
    public class Sinhvien
    {
        // tao 1 doi tuong : TenLop tenlop = new TenLop();
        private int mssv;
        private float diem;
        private string hoten;
        //khong truyen vao tham so
        public Sinhvien()
        {
            mssv = 0;
            hoten = "Nguyen Van A";
            diem = 0;
        }
        // do nguoi dung truyen vao tham so
        public Sinhvien(int mssv, string hoten,float diem)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.diem = diem;
        }
        //khai bao property de co the truy xuat sua doi du lieu
        public int Mssv
        {
            get { return mssv; }//get gia tri de doc
            set { mssv = value; } //set gia tri de ghi
        }
        public string Hoten
        {
            get { return hoten; } //get gia tri de doc
            set { hoten = value; } //set gia tri de ghi
        }
        public float Diem
        {
            get { return diem; } //get gia tri de doc
            set { diem = value; } //set gia tri de ghi
        }

        public double Chieucao()
        {
            return 1.7;
        }
        public override string ToString() {
            return "MSSV: " + mssv + ", Ho ten: " + hoten ;
        }
        //truy xuat den moi doi tuong
        // tenDoituong.TenPhuongthuc();
        private bool  kiemtra()
        {
            return(this.Diem >= 5);
        }
        public void Xuat()
        {
            Console.WriteLine("MSSV: " + mssv);
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Diem: " + diem);
            if (kiemtra())
            {
                Console.WriteLine("Dau");
            }
            else
            {
                Console.WriteLine("Rot");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Doantau
    {
        int khach;
        string matau;
        int tien;
        public void nhap()
        {
            Console.WriteLine("Nhap ma tau:\t");
            this.matau = Console.ReadLine();
            Console.WriteLine("Nhap so luong khach:\t");
            this.khach = Convert.ToInt32(Console.ReadLine());
        }
        public void intt()
        {
            Console.WriteLine("Ma tau {0} so tien la {1}", this.matau, this.tien);
        }
        public void tinhtien()
        {
            if (this.khach < 100)
                this.tien = this.khach * 100000;
            else this.tien = this.khach * 80000;

        }

        static void Main(string[] args)
        {
            Doantau s1 = new Doantau();
            s1.nhap();
            s1.tinhtien();
            s1.intt();
            Console.ReadKey();
        }
    }
}

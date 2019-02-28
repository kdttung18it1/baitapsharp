using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class tinhtong
    {  //cau a
        public int a(int n)
        {
            int s;

            if (n % 2 == 0)
                s = -n / 2;
            else s = (n / 2) + 1;
            return s;
        }
        //cau b
        public float b(int n)
        {
            float s = 0;
            for (float i = 1; i <= n; i++)
            { s = s + (1 / i); }
            return s;
        }
        //cau c
        public int c(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
                s = s + i;
            return s;
        }
        //cau d
        public int d(int n)
        {
            int s = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    s = s + i;
            return s;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao n:\n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong cau a la:\t{0}", a(n));
            Console.Write("Nhap vao n cau b:\n");
            Console.WriteLine("Tong cau b la:\t{0}", b(n));
            Console.Write("Nhap vao n cau c:\n");
            Console.WriteLine("Tong cau c la:\t{0}", c(n));
            Console.Write("Nhap vao n cau d:\n");
            Console.WriteLine("Tong cau d la:\t{0}", d(n));

            Console.ReadKey();
        }
    }
}

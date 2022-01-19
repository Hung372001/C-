using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, i, j, binno = 0, dn;
            Console.Write("\n");
            Console.Write("Chuyen doi thap phan thanh nhi phan trong C#:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot so thap phan bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            dn = n;
            i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                binno = binno + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }

            Console.Write("\nSo trong he nhi phan tuong duong cua so {0} la {1}.\n\n", dn, binno);

            Console.ReadKey();
        }
    }
}
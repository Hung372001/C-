using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, T, D, C;
            Console.Write("Nhap a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c:");
            c = double.Parse(Console.ReadLine());
            Console.Write("Nhap d:");
            d = double.Parse(Console.ReadLine());

            T = a + b + c + d;
            Console.WriteLine("\nTong 4 so da nhap la: {0}", T);
            D = T * 0.1;
            Console.WriteLine("\nChu so hang chuc la: {0}", (int)D);
            C = T % 10;
            Console.WriteLine("\nChu so hang chuc la: {0}", C);
        }
    }
}

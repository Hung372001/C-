using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, S, V;
            double PI = 3.14;
            Console.Write("Nhap Ban Kinh hinh cau:");
            R = double.Parse(Console.ReadLine());

            S = 4 * PI * Math.Pow(R, 2);
            Console.WriteLine("\nDien tich hinh cau la: {0}", S);
            V = (R * S) / 3;
            Console.WriteLine("\nThe tich hinh cau la: {0}", V);
        }
    }
}

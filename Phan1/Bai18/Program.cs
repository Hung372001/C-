using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, b1, c1, a2, b2, c2, x, y, d, dx, dy;
            Console.Write("Nhap a1:");
            a1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap b1:");
            b1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap c1:");
            c1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap a2:");
            a2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap b2:");
            b2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap c2:");
            c2 = double.Parse(Console.ReadLine());

            d = a1 * b2 - a2 * b1;
            dx = c1 * b2 - c2 * b1;
            dy = a1 * c2 - a2 * c1;

            if (d != 0)
            {
                x = dx / d;
                y = dy / d;
                Console.WriteLine("\nHe pt co nghiem la x = {0}, y = {1}", x, y);
            }
            else if (d == 0 && dx == 0)
            {
                Console.WriteLine("\nCo vo so ngiem");
            }
            else if (d == 0 && dx != 0)
            {
                Console.WriteLine("\n Phuong trinh vo nghiem");
            }

            // 		for(x = - c1; x = c1; x++){
            // 		    for (y = -c1; y <= c2; y++){
            // 		        if (a1 * x + b1 * y == c1 && a2 * x + b2 * y == c2){
            // 		            Console.WriteLine("\nHe pt co nghiem la x = {0}, y = {1}", x, y);
            // 		        }
            // 		    }
            // 		}
            Console.ReadLine();


        }
    }
}

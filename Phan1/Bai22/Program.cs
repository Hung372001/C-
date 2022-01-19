using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap thang:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam:");
            b = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("\nthang 1 co 31 ngay");
                    break;
                case 2:
                    if (b % 19 == 0 || b % 19 == 3 || b % 19 == 6 || b % 19 == 9 || b % 19 == 11 || b % 19 == 17 || b % 19 == 14)
                    {
                        Console.WriteLine("\nthang 2 co 29 co  ngay");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nthang 2 co 28 co  ngay");
                        break;
                    }
                case 3:
                    Console.WriteLine("\nthang 1 co 31 ngay");
                    break;
                case 4:
                    Console.WriteLine("\nthang 1 co 30 ngay");
                    break;
                case 5:
                    Console.WriteLine("\nthang 1 co 31 ngay");
                    break;
                case 6:
                    Console.WriteLine("\nthang 1 co 30 ngay");
                    break;
                case 7:
                    Console.WriteLine("\nthang 1 co 31 ngay");
                    break;
                case 8:
                    Console.WriteLine("\nthang 1 co 31 ngay");
                    break;
                case 9:
                    Console.WriteLine("\nthang 1 co 30 ngay");
                    break;
                case 10:
                    Console.WriteLine("\nthang 1 co 31 ngay");
                    break;
                case 11:
                    Console.WriteLine("\nthang 1 co 30 ngay");
                    break;
                case 12:
                    Console.WriteLine("\nthang 1 co 31 ngay");
                    break;
            }
            if (b % 19 == 0 || b % 19 == 3 || b % 19 == 6 || b % 19 == 9 || b % 19 == 11 || b % 19 == 17 || b % 19 == 14)
            {
                Console.WriteLine("\n{0} la nam nhuan", b);
            }
            else
            {
                Console.WriteLine("\n{0} khong phai la nam nhuan", b);
            }




            Console.ReadLine();


        }
    }
}

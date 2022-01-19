using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n, i, sum;


            Console.Write("Cac so hoan hao trong day da cho la: ");
            for (n = 1; n <= 1000; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");

            Console.ReadKey();
        }

    }
}


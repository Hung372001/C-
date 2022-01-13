using System;

namespace ConsoleApp
{
    public class Bai5
    {
        public static void Main(string[] args)
        {
            int a = 3;
            double s = Math.Sqrt(a + Math.Sqrt(a + Math.Sqrt(a)));
            Console.WriteLine(s);

            double result = 1 / (2 + (1 / (2 + 1 / 2)));
            Console.WriteLine(result);
        }
    }
}


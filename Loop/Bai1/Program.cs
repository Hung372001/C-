using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NHap n: ");
            double n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i / n;
            }
            Console.WriteLine("ket Qua la : {0}", sum);
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("B");
            Console.WriteLine("NHap n1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            double sum1 = 0;
            for (int i = 1; i <= n1; i++)
            {
                sum1 += Math.Sqrt(Math.Pow(i, 2));
            }
            Console.WriteLine("ket Qua la : {0}", sum1);
        }
    }
}

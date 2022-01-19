// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap a : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap b : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}     {1}", Math.Round(a, 2), Math.Round(b, 2));

        }
    }
}
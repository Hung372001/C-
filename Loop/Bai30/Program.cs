using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cac Cap So Sinh Doi La : ");
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (j - i == 2)
                    {
                        Console.WriteLine("{0} {1}", i, j);
                    }
                }
            }
        }
    }
}
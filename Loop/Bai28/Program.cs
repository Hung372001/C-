using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (i * j == 2 * (i + j))
                    {
                        Console.WriteLine("{0} {1}", i, j);
                    }
                }
            }
        }
    }
}
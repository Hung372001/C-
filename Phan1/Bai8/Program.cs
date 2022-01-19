using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c:");
            int c = Convert.ToInt32(Console.ReadLine());
            float tb = a + b + c / 3;
           Console.WriteLine("trung binh cong :{0}",tb);


        }
    }
}
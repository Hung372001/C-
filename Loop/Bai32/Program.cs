using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int ma;
            do
            {
                ma = getch();
                if (ma != 27)

                    Console.WriteLine("Ma {0} : {1}", ma, ma);
            }
            while (ma != 27);
            getch();

        }
    }
}
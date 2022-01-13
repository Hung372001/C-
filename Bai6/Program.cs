namespace System
{
    public class bai6cs
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c:");
            int c = Convert.ToInt32(Console.ReadLine());

            double result_a = Math.Pow(a, 2) - 2 * b + a * b / c;
            Console.WriteLine("result_a = {0}", Math.Round(result_a, 2));

            double result_b = Math.Pow(b, 2) - 4 * a * c / (2 * a);
            Console.WriteLine("result_b = {0}", Math.Round(result_b, 2));

            double result_c = Math.Sqrt(Math.Pow(a, 2) / (b - 4 * a / (b * c + 1)));
            Console.WriteLine("result_c = {0}", Math.Round(result_c, 2));

        }
    }
}
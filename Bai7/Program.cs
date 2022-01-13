namespace System
{
    public class bai7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("a:");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b:");
            float b = Convert.ToInt32(Console.ReadLine());
            float s = a + b;
            Console.WriteLine("Tong la : {0}", s);
            float h = a - b;
            Console.WriteLine("Tich la : {0}", h);

            float t = a * b;
            Console.WriteLine("Hieu la : {0}", t);

            float tg = a / b;
            Console.WriteLine("Thuong la : {0}", tg);


        }
    }
}
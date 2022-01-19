namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, T, a, b, c, d, D, C;
            Console.Write("Nhap a:");
            x = double.Parse(Console.ReadLine());

            a = x * 0.001;
            Console.WriteLine("\nChu so dau la: {0}", (int)a);
            b = x % 1000;
            b = b * 0.01;
            c = x % 100;
            c = c * 0.1;
            d = x % 10;
            Console.WriteLine("\nChi so cuoi da nhap la: {0}", (int)d);
            T = a + b + c + d;
            Console.WriteLine("\nTong 4 so da nhap la: {0}", (int)T);
        }
    }
}
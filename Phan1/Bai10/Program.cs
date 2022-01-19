using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double canh_1, canh_2, canh_3, C, S, h, ma, ga, r, R;
            Console.Write("Nhap 3 canh cua tam giac:");
            Console.Write("Nhap canh 1:");
            canh_1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh 2:");
            canh_2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh 3:");
            canh_3 = double.Parse(Console.ReadLine());

            C = canh_1 + canh_2 + canh_3;
            Console.WriteLine("\nChu vi cua tam giac la: {0}", C);
            S = Math.Sqrt(C * (C - canh_1) * (C - canh_2) * (C - canh_3));
            Console.WriteLine("\nDien tich cua tam giac la: {0}", S);
            h = (2 * S) / canh_1;
            Console.WriteLine("\nDo dai duong cao cua tam giac la: {0}", h);
            ma = (1 / 2) * Math.Sqrt((2 * Math.Pow(canh_2, 2)) + (2 * Math.Pow(canh_3, 2)) - Math.Pow(canh_1, 2));
            Console.WriteLine("\nDo dai 3 duong trung tuyen cua tam giac la: {0}", ma);
            ga = (2 / (canh_1 + canh_2)) * (Math.Sqrt(canh_2 * canh_3 * (canh_1 + canh_2 + canh_3)) * ((canh_1 + canh_2 + canh_3) - canh_1));
            Console.WriteLine("\n3 Duong phan giac cua tam giac la: {0}", ga);
            r = S / C;
            Console.WriteLine("\nDo dai 3 duong noi tiep cua tam giac la: {0}", r);
            R = (canh_1 * canh_2 * canh_3) / (4 * S);
            Console.WriteLine("\nDo dai 3 duong ngoai tiep cua tam giac la: {0}", R);
        }
    }
}

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap x:");
            char x = (char)Console.Read();

            if ((x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z'))
            {
                Console.Write("\nChuoi vua nhap la ky tu");
            }
            else
            {
                Console.Write("\nChuoi vua nhap khong phai la ky tu");
            }


        }
    }
}
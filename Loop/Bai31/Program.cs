using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int j = 2;
            int uppercase = 0;
            int lowercase = 0;
            int number = 0;
            int character = 0;
            Console.WriteLine("Nhap Chuoi : ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '.')
                {
                    break;
                }
                else
                {

                    if (Char.IsUpper(str[i]))
                    {
                        uppercase++;
                    }
                    else
                    {
                        if (Char.IsLower(str[i]))
                        {
                            lowercase++;
                        }
                        else
                        {
                            if (str[i] >= '0' && str[i] <= '9')
                            {
                                number++;
                            }
                            else
                            {
                                character++;
                            }
                        }
                    }
                }


            }





            Console.WriteLine(" Uppercase : {0} ,Lower :{1}, Number : {2}, Character : {3}", uppercase, lowercase, number, character);
        }
    }
}
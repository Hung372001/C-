using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
		double x;
		Console.Write("Nhap a:");
		x = double.Parse(Console.ReadLine());
		
		if(x > 0){
		    Console.WriteLine("\nSo ban va nhap la so nguyen duong: {0}", (int)x);
		    if(x % 2 == 0){
		        Console.WriteLine("\n{0} la so chan", (int)x);
		    } else {
		        Console.WriteLine("\n{0} la so le", (int)x);
		    }
		} else {
		    Console.WriteLine("\n{0} la so nguyen am", (int)x);
		}
		
    }
  }
}

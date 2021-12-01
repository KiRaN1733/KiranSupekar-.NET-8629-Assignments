using System;

public class Class1
{
	public static void Main()
	{
		Console.Write("Input the First Number: ");
		double a = double.Parse(Console.ReadLine());
		Console.Write("Input the Second Number: ");
		double b = double.Parse(Console.ReadLine());

		//ex.:  a = 5, b = 10;

		a = a + b;  // ===> a = 5 + 10 ===> a = 15;
		b = a - b;  // ===> b = 15 - 10 ===> b = 5;
		a = a - b;  // ===> a = 15 - 5 ===> a = 10;

		// double temp = a;
		// a = b;
		// b = temp;

		Console.WriteLine("After Swapping: ");
		Console.WriteLine("First Number: " + a);
		Console.WriteLine("Second Number: " + b);
	}  
	
}

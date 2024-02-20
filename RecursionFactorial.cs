using System;

public class RecursionFactorial
{

	public static int Factorial(int n)
	{
		if (n==0)
		{
			Console.WriteLine("{0}! = {1}",n,1);
			return 1;
		}
		else 
		{
			int f = n*Factorial(n-1);
			Console.WriteLine("{0} * {1}! = {2}",n,n-1,f);
			return f;
		}
	}

	public static void Main()
	{
		int n = 5;

		Console.WriteLine("The factorial of {0} is {1}", n, Factorial(n));
	}

}
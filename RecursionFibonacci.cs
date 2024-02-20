using System;

public class RecursionFibonacci
{
	
	public static int FibonacciBad(int n)
	{
		Console.WriteLine("FibonacciBad({0})",n);
		if (n==0 || n==1)
		{
			return n;
		}
		else 
		{
			return FibonacciBad(n-1)+FibonacciBad(n-2); // returns F_n = F_{n-1} + F_{n-2}
		}
	}

	public static int FibonacciGood(int n)
	{
		Console.WriteLine("FibonacciGood({0})",n);
		int[] r = FibonacciGoodRecursive(n);
		return r[0];
	}

	public static int[] FibonacciGoodRecursive(int n)
	{
		Console.WriteLine("FibonacciGoodRecursive({0})",n);
		if (n<=1)
		{	
			Console.WriteLine("[{0},{1}]",n,0);
			return new int[2]{n, 0};
		}
		else
		{
			int[] tmp = FibonacciGoodRecursive(n-1);			// returns { F_{n-1}, F_{n-2} }
			Console.WriteLine("[{0},{1}]",tmp[0]+tmp[1],tmp[0]);
			return new int[2]{tmp[0]+tmp[1], tmp[0]}; 	// returns { F_{n} = F_{n-1}+F_{n-2}, F_{n-1} }
		}
	}


	public static void Main()
	{

		int n = 5;

		Console.WriteLine("[bad] Fibonacci({0})={1}", n, FibonacciBad(n)); // 15 calls

		Console.WriteLine();

		Console.WriteLine("[good] Fibonacci({0})={1}", n, FibonacciGood(n));

	}

}
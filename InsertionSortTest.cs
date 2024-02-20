using System;
public class InsertionSortTest
{
	public static void randomDoubleVector(double[] v) {
		Random rand = new Random ();
		for (int i = 0; i < v.Length; i++) {
			v [i] = rand.NextDouble ();
		}
	}

	public static void printDoubleVector(double[] v) {
		for (int i = 0; i < v.Length; i++) {
			Console.Write (v [i] + "\t");
		}
		Console.WriteLine ();
	}

	public static void InsertionSort(double[] v) {
		for (int i = 1; i < v.Length; i++) {
			for (int j = i; j > 0; j--) {
				if (v [j] >= v [j-1]) {
					// interrupts the inner 'for loop'
					break;
				}
				double tmp = v [j-1];
				v [j-1] = v [j];
				v [j] = tmp;
			}
		}
	}


	static void Main()
	{
		int n = 8;
		double[] v = new double[n];
		Console.WriteLine ();
		randomDoubleVector (v);
		Console.WriteLine ("Unsorted vector");
		printDoubleVector (v);
		InsertionSort (v);
		Console.WriteLine ("Sorted vector");
		printDoubleVector (v);
		Console.WriteLine ();
	}
}

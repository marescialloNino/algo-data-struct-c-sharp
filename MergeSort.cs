using System;

public class MergeSortTest
{

	// copies source[start] ... source[start+len-1] into a nre vector
	private static int[] CopyPortionOfArray(int[] source, int start, int len) {
		int[] dest = new int[len];
		for (int i = 0; i < len; i++) {
			dest [i] = source [start + i];
		}
		return dest;
	}

	public static void PrintVectorInt(int[] v) {
		for (int i = 0; i < v.Length; i++) {
			Console.Write (v [i] + "\t");
		}
		Console.WriteLine ();
	}

	public static void RandomIntVector(int[] v, int maxValue = 100) {
		Random rand = new Random ();
		int n = v.Length;
		for (int i = 0; i < n; i++) { 
			v [i] = rand.Next () % maxValue;
		}	
	}

	public static int[] Merge(int[] v1, int[] v2, int[] v) {
		
		int i1 = 0, i2 = 0, i = 0;;
		while (i1 < v1.Length && i2 < v2.Length) {
			if (v1 [i1] < v2 [i2]) {
				v [i] = v1 [i1];
				i1++;
			} else {
				v [i] = v2 [i2];
				i2++;
			}
			i++;
		}

		while (i1 < v1.Length) {
			v [i] = v1 [i1];
			i1++;
			i++;
		}
		while (i2 < v2.Length) {
			v [i] = v2 [i2];
			i2++;
			i++;
		}
		return v;
	}
		

	public static int[] MergeSort(int[] v) {
		if (v.Length == 1) {
			return v;
		}
		// Divide
		int mid = v.Length / 2;

		// Conquer
		int[] v1 = CopyPortionOfArray(v, 0, mid);
		int[] v2 = CopyPortionOfArray (v, mid, v.Length-mid);
		v1 = MergeSort (v1);
		v2 = MergeSort (v2);
		// Recombine
		Merge (v1, v2, v);

		return v;
	}
	
	public static void Main()
	{
		int[] v1 = {2,3,3,6,8,10,11};
		int[] v2 = { -10,-1, 0,0, 2, 3, 4, 4, 5, 12, 30 };
		int[] v = new int[v1.Length + v2.Length];
		Merge (v1, v2, v);
		PrintVectorInt (v);

		Console.WriteLine ();

		int n = 32;
		int[] unsorted = new int[n];

		RandomIntVector (unsorted);
		Console.WriteLine ("Unsorted array");
		PrintVectorInt (unsorted);

		int[] sorted = MergeSort (unsorted);
		Console.WriteLine ("Sorted array");
		PrintVectorInt (sorted);
	}

}
using System;
public class BSearch
{
	public static int BinarySearchRec(int[] v, int e, int low, int high) {
		
		if (high < low) {
			return -1;
		}
		int mid = (high + low) / 2;
		Console.WriteLine (low + " " + high + " " + mid + " -- " + v[mid]);
		if (v [mid] == e) {
			return mid;
		}
		if (v [mid] > e) {
			return BinarySearchRec (v, e, low, mid - 1);	
		}
		return BinarySearchRec (v, e, mid + 1, high);

	}

	public static int BinarySearch(int[] v, int e) {
		return BinarySearchRec (v, e, 0, v.Length);
	}
	
	public static void Main()
	{
		int[] v = { -9, -3, -1, 0, 0, 2, 2, 4, 6, 7, 8, 10, 16, 17, 28 };
		Console.WriteLine ("Element 16 found at position " + BinarySearch (v, 16));
	}
}
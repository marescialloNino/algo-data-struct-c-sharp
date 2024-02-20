using System;

public class LinkedListTest
{
	public static void Main()
	{
		LinkedList ll = new LinkedList();
		ll.addHeadElement (100);
		ll.addHeadElement (200);
		ll.addHeadElement (202);
		System.Console.WriteLine (ll.getHeadElement ());
		System.Console.WriteLine (ll.elementAt (1));
		ll.setElementAt (1, 999);
		System.Console.WriteLine (ll.elementAt (1));
	}
}

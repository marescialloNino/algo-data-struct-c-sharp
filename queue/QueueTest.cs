using System;

public class QueueTest
{
	public static void TestDoublyLinkedList() {
		DoublyLinkedList dll = new DoublyLinkedList();
		dll.addHead (100);
		dll.addTail (101);
		dll.addHead (200);
		System.Console.WriteLine (dll.removeHead ());
		System.Console.WriteLine (dll.removeTail ());
		System.Console.WriteLine (dll.size ());
			
	}

	public static void TestListQueue() {
		ListQueue lq = new ListQueue();
		lq.enqueue ("first");
		lq.enqueue ("second");
		lq.enqueue ("last");
		while (!lq.isEmpty ()) {
			System.Console.WriteLine (lq.dequeue ());
		}
	}

	public static void TestArrayQueue() {
		ArrayQueue aq = new ArrayQueue (128);
		aq.enqueue (0.123);
		aq.enqueue (1.999);
		aq.enqueue (3.1415);
		aq.enqueue (-0.000001);
		while (!aq.isEmpty ()) {
			System.Console.WriteLine (aq.dequeue ());
		}
	}

	public static void Main() {
		TestDoublyLinkedList ();
		Console.WriteLine ();
		TestListQueue ();
		Console.WriteLine ();
		TestArrayQueue ();
	}
}
using System;

public class DoublyLinkedList
{
	private class DLLNode
	{
		public Object Content {get;set;}
		public DLLNode Next {get; set;}
		public DLLNode Prev {get; set;}
	}

	private DLLNode head;
	private DLLNode tail;
	private int n;

	public DoublyLinkedList() {
		this.n = 0;
		// for doubly linked list we use actual nodes as placeholders
		// for head and tail. They don't contain any element, they just
		// indicates the head and the tail of the list.
		this.head = new DLLNode();
		this.tail = new DLLNode();
		this.head.Next = this.tail;
		this.head.Prev = null;
		this.tail.Prev = this.head;
		this.tail.Next = null;
	}

	public int size() {
		return n;
	}

	public bool isEmpty() {
		return (this.n == 0);
	}

	public void addHead(Object e) {
		DLLNode newNode = new DLLNode ();
		newNode.Content = e;
		newNode.Prev = this.head;
		newNode.Next = this.head.Next;
		this.head.Next.Prev = newNode;
		this.head.Next = newNode;
		this.n++;
	}

	public Object removeHead() {
		if (this.head.Next == this.tail) {
			// this is the case of empty list
			return null;
		}
		// Work out carefully what happens here...
		DLLNode removedNode = this.head.Next;
		this.head.Next = removedNode.Next;
		removedNode.Next.Prev = this.head;

		this.n--;
		return removedNode.Content;
	}

	public void addTail(Object e) {
		DLLNode newNode = new DLLNode ();
		newNode.Content = e;
		newNode.Next = this.tail;
		newNode.Prev = this.tail.Prev;
		this.tail.Prev.Next = newNode;
		this.tail.Prev = newNode;
		this.n++;
	}

	public Object removeTail() {
		if (this.head.Next == this.tail) {
			// this is the case of empty list
			return null;
		}
		// again study this
		DLLNode removedNode = this.tail.Prev;
		this.tail.Prev = removedNode.Prev;
		removedNode.Prev.Next = this.tail;

		this.n--;
		return removedNode.Content;
	}
}
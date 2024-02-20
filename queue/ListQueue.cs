using System;

public class ListQueue : IQueue
{
	private DoublyLinkedList dll;

	public ListQueue() {
		this.dll = new DoublyLinkedList();
	}

	public int size() {
		return dll.size ();
	}

	public bool isEmpty() {
		return dll.isEmpty ();
	}
	
	public void enqueue(Object e) {
		dll.addHead (e);
	}

	public Object dequeue() {
		return dll.removeTail ();
	}

}
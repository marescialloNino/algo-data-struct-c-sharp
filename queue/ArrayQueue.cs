using System;

public class ArrayQueue : IQueue
{
	private Object[] v;
	// N is the size of array v
	private int tail;
	private int head;
	private int n;

	public ArrayQueue(int maxSize = 1024) {
		this.v = new Object[maxSize];
		tail = head = 0;
		n = 0;
	}

	public int size() {
		return n;
	}

	public bool isEmpty() {
		return (n == 0);
	}

	public void enqueue(Object e) {
		if (this.size() == this.v.Length) {
			// queue is full
			return;
		}
		v [head] = e;
		head = (head + 1) % v.Length;	
		n++;
	}

	public Object dequeue() {
		if (!this.isEmpty ()) {
			Object c = v [tail];
			tail = (tail + 1) % v.Length;
			n--;
			return c;
		}
		return null;
	}

}
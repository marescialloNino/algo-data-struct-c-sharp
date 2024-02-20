using System;

public class LinkedList
{
	private class LinkedListNode
	{
		public Object Content {get; set;}
		public LinkedListNode Next {get; set;}

		public LinkedListNode(Object c, LinkedListNode next)
		{
			Content = c;			
			Next = next;
		}
	}

	private LinkedListNode head;
	private int n;

	public LinkedList()
	{
		this.head = null;
		this.n = 0;
	}

	public int size()
	{
		return this.n;
	}

	public bool isEmpty()
	{
		return (this.n == 0);
	}

	public void addHeadElement(Object e)
	{
		LinkedListNode newNode = new LinkedListNode(e, head);
		this.head = newNode;
		this.n++;
	}

	public Object getHeadElement() {
		return head.Content;
	}

	public Object removeHeadElement()
	{
		if (head != null)
		{
			Object content = head.Content;
			head = head.Next;
			this.n--;
			return content;
		}
		// Good place for throwing an exception (possibly a custom one)
		return null;
	}

	public int find(Object e)
	{
		LinkedListNode iterator = this.head;
		int pos = 0;
		while(iterator != null) {
			if (iterator.Content.Equals(e))
			{
				return pos;				
			}
			iterator = iterator.Next;
			pos++;
		}
		return -1;
	}

	public Object elementAt(int i)
	{
		if (i >= n || i < 0) {
			// error occurs here
			return null;
		}
		LinkedListNode tmp = this.head;
		for (int j = 0; j < i; j++) {
			tmp = tmp.Next;
		}
		return tmp.Content;
	}

	public void setElementAt(int i, Object e)
	{
		if (i >= n || i < 0) {
			// error occurs here
			return ;
		}
		LinkedListNode tmp = this.head;
		for (int j = 0; j < i; j++) {
			tmp = tmp.Next;
		}
		tmp.Content = e;
	}
}

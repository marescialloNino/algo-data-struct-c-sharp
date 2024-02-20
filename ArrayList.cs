using System;

public class ArrayList
{
	private LinkedList list;

	public ArrayList(int n) {
		this.list = new LinkedList();
		for (int i = 0; i < n; i++) {
			this.list.addHeadElement (null);
		}
	}

	public int size() {
		return this.list.size ();
	}

	public Object elementAt(int i) {
		return this.list.elementAt(i);
	}

	public void setElementAt(int i, Object e) {
		this.list.setElementAt (i, e);
	}
}

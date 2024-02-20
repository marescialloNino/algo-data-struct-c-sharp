using System;

public interface IQueue
{
	int size();
	bool isEmpty();
	void enqueue(Object e);
	Object dequeue();
}
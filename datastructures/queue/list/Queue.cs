using System;

namespace Queue.List
{
	/*
	 * A First in First Out Collection
	 * @typeparm T : The type of data stored in the collection
	 */
	public class Queue<T> : System.Collections.Generic.IEnumerable<T>
	{
		System.Collections.Generic.LinkedList<T> _items = new System.Collections.Generic.LinkedList<T>();
	
		public void Enqueue(T item)
		{
			_items.AddLast(item);
		}
		
		public T Dequeue()
		{
			if (_items.Count == 0)
				throw new InvalidOperationException("The queue is empty");
			
			T value = _items.First.Value;
			_items.RemoveFirst();
			
			return value;
		}
		
		public T Peek()
		{
			if (_items.Count == 0)
			{
				throw new InvalidOperationException("The queue is empty");
			}
			
			return _items.First.Value;
		}
		
		public void Clear()
		{
			_items.Clear(); 
		}
		
		public System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return _items.GetEnumerator();
		}
		
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return _items.GetEnumerator();
		}
	}
}
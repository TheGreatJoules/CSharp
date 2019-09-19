using System;

namespace Queue.Priority
{
	/*
	 * A collection that returns the highest priority item first and lowest priority item last.
	 * @typeparam T: The type if data stored in the collection
	 */
	public class PriorityQueue<T> : System.Collections.Generic.IEnumerable<T> where T: IComparable<T>
	{
		System.Collections.Generic.LinkedList<T> _items = new System.Collections.Generic.LinkedList<T>();
		
		public void Enqueue(T item)
		{
			if (_items.Count == 0)
				_items.AddLast(item);
			else
			{
				var current = _items.First;
				while (current != null & current.Value.CompareTo(item) > 0)
					current = current.Next;
				if (current == null)
					_items.AddLast(item);
				else
					_items.AddBefore(current, item);
			}
		}
		
		public T Peek()
		{
			if (_items.Count == 0)
				throw new InvalidOperationException("The queue is empty");
			return _items.First.Value;
		}
		
		public int Count { get{ return _items.Count; }}
		
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
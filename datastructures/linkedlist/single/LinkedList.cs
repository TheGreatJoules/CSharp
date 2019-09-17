using System;

namespace SingleLinkedList
{
	/*
	 * A single linked list collection capable of
	 * add, remove find and enumerate
	 * @typeparam T : The type of item contained in the linkedlist.
	 */
	public class LinkedList<T> : System.Collections.Generic.ICollection<T>
	{
		public Node<T> Head { get; private set; }
		public Node<T> Tail { get; private set; }
		
		#region Add
		public void AddFirst(T value)
		{
			AddFirst(new Node<T>(value));
		}
		
		public void AddFirst(Node<T> node)
		{
			Node<T> temp = Head;
			Head = node;
			Head.Next = temp;
			Count++;
			if (Count == 1)
				Tail = Head;
		}
		
		public void AddLast(T value)
		{
			AddLast(new Node<T>(value));	
		}
		
		public void AddLast(Node<T> node)
		{
			if (Count == 0)
				Head = node;
			else
				Tail.Next = node;
			Tail = node;
			Count++;
		}
		#endregion
		
		#region Remove
		public void RemoveFirst()
		{
			if (Count != 0)
			{
				Head = Head.Next;
				Count--;
				if (Count == 0)
					Tail = null;
			}
		}
		
		public void RemoveLast()
		{
			if (Count != 0)
			{
				if (Count == 1)
				{
					Head = null;
					Tail = null;
				} else {
					Node<T> current = Head;
					while (current.Next != Tail)
						current = current.Next;
					current.Next = null;
					Tail = current;
				}
				Count--;
			}
		}
		#endregion
		
		#region ICollection
		public int Count { get; private set; }
		
		public void Add(T item)
		{
			AddFirst(item);
		}
		
		public bool Contains(T item)
		{
			Node<T> current = Head;
			while (current != null)
			{
				if (current.Value.Equals(item))
					return true;
				current = current.Next;
			}
			return false;
		}
		
		public void CopyTo(T[] array, int arrayIndex)
		{
			Node<T> current = Head;
			while (current != null)
			{
				array[arrayIndex++] = current.Value;
				current = current.Next;
			}
		}
		
		public bool IsReadOnly { get { return false; } }
		
		public bool Remove(T item)
		{
			Node<T> previous = null;
			Node<T> current = Head;
			
			while (current != null)
			{
				if (current.Value.Equals(item))
				{
					if (previous != null)
					{
						previous.Next = current.Next;
						if (current.Next == null)
							Tail = previous;
						Count--;
					} else {
						RemoveFirst();
					}
					return true;
				}
				previous = current;
				current = current.Next;
			}
			return false;
		}
		
		System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			Node<T> current = Head;
			while (current != null)
			{
				yield return current.Value;
				current = current.Next;
			}
		}
		
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
		}
		
		public void Clear()
		{
			Head = null;
			Tail = null;
			Count = 0;
		}
		#endregion
	}
}
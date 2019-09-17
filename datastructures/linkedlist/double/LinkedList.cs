namespace DoubleLinkedList
{
	public class LinkedList<T> : System.Collections.Generic.ICollection<T>
	{
		public Node<T> Head { get; private set; }
		
		public Node<T> Tail { get; private set; }
		
		#region Add
		public void AddFirst(T value)
		{
			AddFirst(new Node<T>(value));
		}
	}
}
namespace SingleLinkedList
{
	/*
	 * A node in the linkedlist
	 * @typeparam T : The type of item contained in the node.
	 */
	
	public class Node<T>
	{
		public Node(T value) { Value = value; }
		public T Value { get; set; }
		public Node<T> Next { get; set; }
	}
}
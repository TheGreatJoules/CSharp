using System;

namespace main_block
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


namespace LinkedList_Block
{
    //Creating a node class to avoid cycle nesting.
    internal class Node
    {
        internal int data;
        internal Node next;
    }

    internal class Stack
    {
        private Node front;
        private Node end;

        public Stack()
        {
            front = null;
        }

        public void pushBack(int value)
        {
            Node ptr = new Node();
            ptr.data = value;
            ptr.next = null;

            if (front != null) { ptr.next = front; }
            front = ptr;
            Console.Out.Write("--- New item was inserted ---\n");

        }

        public void remove ()
        {
            Node temp = new Node();
            if(front != null) { Console.Out.Write("--- The stack is empty ---\n"); }
            temp = front;
            front = front.next;
            Console.Out.Write("--- Removed value "+ temp.data);
            temp = null;

        }

        public void show ()
        {
            Node ptr = front;
            Console.Out.WriteLine("The stack is\n");

        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueUsingLinkedList
{
    /// <summary>
    /// Node is an element of linkedlist that hold data and address of next node.
    /// </summary>
    class Node
    {
        public int data;
        public Node next;
    }
    /// <summary>
    /// Implenting Stack using LinkedList.
    /// </summary>
    class StackLinkedList
    {
        private Node top;
        public StackLinkedList()
        {
            this.top = null;
        }
        /// <summary>
        /// Pushing data to the top of stack.
        /// </summary>
        /// <param name="data"></param>
        public void Push(int data)
        {
            Node node = new Node();
            node.data = data;

            if (isEmpty() == true)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine($"element pushed to stack: {node.data}");
        }
        /// <summary>
        /// method to display all the elements of stack.
        /// </summary>
        public void Show()
        {
            Node n = top;
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
        /// <summary>
        /// method to remove the top element of stack and points next element of stack as top.
        /// </summary>
        public void Pop()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("No elements to remove.");
            }
            if (this.top != null)
            {
                Console.WriteLine($"popped element: {this.top.data}");
                this.top = this.top.next;
            }
        }
        /// <summary>
        /// check whether the stack is empty or not.
        /// </summary>
        public bool isEmpty()
        {
            if (this.top == null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// mehtod to display the top element of the stack.
        /// </summary>
        public void Peek()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine($"top element: {this.top.data}");
            }
        }
        /// <summary>
        /// method to display the size of stack.
        /// </summary>
        public int Size()
        {
            int count = 0;
            Node n = top;
            while (n != null)
            {
                count++;
                n = n.next;
            }
            Console.WriteLine($"size of stack: {count}");
            return count;
        }
    }
}

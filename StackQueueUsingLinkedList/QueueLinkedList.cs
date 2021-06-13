using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueUsingLinkedList
{
    class NodeQ
    {
        public int data;
        public NodeQ next;
    }
    class QueueLinkedList
    {
        public NodeQ top;
        public QueueLinkedList()
        {
            this.top = null;
        }

        internal bool isEmpty()
        {
            if (this.top == null)
                return true;
            else
                return false;
        }

        internal void Enqueue(int data)
        {
            NodeQ node = new NodeQ();
            node.data = data;
            if (isEmpty() == true)
            {
                this.top = node;
                node.next = null;
            }
            else
            {
                NodeQ n = top;
               
                while(n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
            Console.WriteLine($"element add to Queue: {node.data}");
        }

        internal void Dequeue()
        {
            if(isEmpty() == true)
            {
                Console.WriteLine("Queue empty!!");
            }
           if(Size() == 1)
            {
                this.top = null;
            }
           if(Size() > 1)
            {
                NodeQ n = this.top;
                this.top = n.next;
            }
        }

        internal void ShowQue()
        {
            NodeQ n = this.top;
            while(n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }

        internal int Size()
        {
            int count = 0;
            NodeQ n = this.top;
            while ( n != null)
            {
                count++;
                n = n.next;
            }
           // Console.WriteLine($"size of Queue: {count}");
            return count;
        }
    }
}

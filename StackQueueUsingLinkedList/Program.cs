using System;

namespace StackQueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program statements");
            QueueLinkedList queue = new QueueLinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("------elements in queue-------");
            queue.ShowQue();
            queue.Dequeue();
            Console.WriteLine("------elements in queue after Dequeue");
            queue.ShowQue();
            queue.Dequeue();
            Console.WriteLine("------elements in queue after Dequeue");
            queue.ShowQue();
            queue.Dequeue();
            Console.WriteLine("------elements in queue after Dequeue");
            queue.ShowQue();

        }
    }
}

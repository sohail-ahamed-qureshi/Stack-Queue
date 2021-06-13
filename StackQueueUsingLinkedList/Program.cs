using System;

namespace StackQueueUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program statements");
            StackLinkedList stack = new StackLinkedList();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("--------stack elements--------");
            stack.Show();
        }
    }
}

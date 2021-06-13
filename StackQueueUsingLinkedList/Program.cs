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
            Console.WriteLine();
            int count = stack.Size();
            while (count != 0)
            {
                stack.Peek();
                stack.Pop();
                Console.WriteLine("--------stack elements after Pop()--------");
                stack.Show();
                count = stack.Size();
            }
        }
    }
}

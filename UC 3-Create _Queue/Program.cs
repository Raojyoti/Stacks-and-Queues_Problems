using System;

namespace UC_3_Create__Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            Console.WriteLine("Values inserted into queue : ");
            Console.WriteLine("----------------------------");
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.WriteLine("\n");
            Console.WriteLine("Sequence of queue are: ");
            Console.WriteLine("----------------------------");
            linkedListQueue.Display();
            Console.WriteLine("\n");
        }
    }
}

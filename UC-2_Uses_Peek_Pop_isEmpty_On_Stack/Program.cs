using System;

namespace UC_2_Uses_Peak_Pop_isEmpty_On_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            Console.WriteLine("Values push in stack are: ");
            Console.WriteLine("----------------------------");
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            Console.Write("\n");
           
            Console.WriteLine("Sequence of stack after push values are:  ");
            Console.WriteLine("--------------------------------------------");
            linkedListStack.Display();
            Console.Write("\n");

            Console.WriteLine("--------------------------------------------");
            linkedListStack.Peek();
            Console.Write("\n");

            Console.WriteLine("--------------------------------------------");
            linkedListStack.Pop();
            Console.Write("\n");

            Console.WriteLine("--------------------------------------------");
            linkedListStack.IsEmpty();
            Console.Write("\n");

           
            
        }
    }
}

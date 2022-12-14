using System;
using System.ComponentModel.DataAnnotations;

namespace UC_1_Create__Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Values push in stack are: ");
            Console.WriteLine("----------------------------");
            LinkedListStack linkedListStack= new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            Console.Write("\n");
            Console.WriteLine("Sequence of stack after push values are:  ");
            Console.WriteLine("--------------------------------------------");
            linkedListStack.Display();
            Console.Write("\n");
        }
    }
}

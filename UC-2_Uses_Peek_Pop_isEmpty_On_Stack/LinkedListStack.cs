using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UC_2_Uses_Peak_Pop_isEmpty_On_Stack
{
    public class LinkedListStack
    {
        public Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if(this.top==null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is the top of the stack", this.top.data);
        }
        public void Pop()
        {
            if(this.top==null)
            {
                Console.WriteLine("Stack is empty and deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}

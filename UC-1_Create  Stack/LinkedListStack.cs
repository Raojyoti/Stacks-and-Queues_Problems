using System;
using System.Collections.Generic;
using System.Text;

namespace UC_1_Create__Stack
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
            if(this.top==null)
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
            while(temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
    }
}

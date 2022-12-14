using System;
using System.Collections.Generic;
using System.Text;

namespace UC_4_Use_Dequeue_Operations
{
    public class LinkedListQueue
    {
        public Node head = null;
        public Node tail = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty and Deletion is not possible");
                return;
            }
            Node temp = this.head;
            this.head = this.head.next;
            if (this.head == null)
            {
                this.tail = null;
            }
            Console.WriteLine("Deleted elements is {0}", temp.data);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class QueueMethods
    {
        public Node head;
        public Node tail;
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                this.head = this.tail = newnode;
            }
            else
            {
                this.tail.next = newnode;
                this.tail = newnode;
            }
        }
        public int Dequeue()
        {
            int data = 0;
            if (this.head == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            else
            {
                data = head.data;
                this.head = this.head.next;
            }
            return data;
        }
        public void DisplayList()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                Console.WriteLine("{1} At {0} Index", count, temp.data);
                count++;
                temp = temp.next;
            }
        }
    }
}

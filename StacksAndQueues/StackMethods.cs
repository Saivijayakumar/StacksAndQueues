using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class StackMethods
    {
        public Node head;
        public Node tail;
        public void PushToStack(int data)
        {
            Node newnode = new Node(data);
            if (this.head == null)
            {
                this.head = this.tail = newnode;
            }
            else
            {
                newnode.next = this.head;
                this.head = newnode;
            }
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

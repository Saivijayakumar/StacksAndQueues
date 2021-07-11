using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    class Program
    {
        /// <summary>
        /// ----------------->WELCOME TO QUEUE OPERATIONS<----------------
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t----------------->WELCOME TO QUEUE OPERATIONS<----------------\n");
            QueueMethods queue = new QueueMethods();
            Console.WriteLine("\tQueue Contains\n");
            //pushing values to Queue
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("\tBefore Dequeue Method");
            queue.DisplayList();
            queue.Dequeue();
            Console.WriteLine("\tAfter Dequeue Method");
            queue.DisplayList();
            Console.Read();
        }
    }
}

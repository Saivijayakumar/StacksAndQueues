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
            QueueMethods stack = new QueueMethods();
            Console.WriteLine("\tQueue Contains\n");
            //pushing values to stack
            stack.Enqueue(56);
            stack.Enqueue(30);
            stack.Enqueue(70);
            stack.DisplayList();
            Console.Read();
        }
    }
}

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
        /// ----------------->WELCOME TO STACK OPERATIONS<----------------
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t----------------->WELCOME TO STACK OPERATIONS<----------------\n");
            StackMethods stack = new StackMethods();
            Console.WriteLine("\tStack Contains\n");
            stack.PushToStack(70);
            stack.PushToStack(30);
            stack.PushToStack(56);
            stack.DisplayList();
            Console.Read();
        }
    }
}

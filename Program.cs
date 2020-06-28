using System;
using System.Collections.Generic;

namespace Oplab_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linklist
            LinkedList<string> months = new LinkedList<string>();

            months.AddFirst("January");
            months.AddLast("March");

            LinkedListNode<string> node = months.FindLast("March");

            months.AddBefore(node, "February");
            months.AddAfter(node, "April");

            foreach (string list in months)
            {
                Console.WriteLine(list);
            }
        }
    }
}

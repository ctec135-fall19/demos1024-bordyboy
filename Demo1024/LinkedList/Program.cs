using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new LInkedListNode of type String
            //properties
            LinkedListNode<String> lln = new LinkedListNode<string>("orange");
            Console.WriteLine("display properties");
            DisplayProperties(lln);
            Console.WriteLine();

            //create linked list
            LinkedList<String> ll = new LinkedList<string>();
            ll.AddLast(lln);
            DisplayProperties(lln);

            // add
            ll.AddFirst("red");
            ll.AddLast("yellow");
            Console.WriteLine("\nafter adding other nodes");
            DisplayProperties(lln);

            Console.WriteLine("traversal");
            LinkedListNode<String> node = ll.First;
            while(node != null)
            {
                Console.WriteLine("    {0}", node.Value);
                node = node.Next;
            }


        }


        public static void DisplayProperties(LinkedListNode<string> lln)
        {
            if (lln.List == null)
                Console.WriteLine("Node is not linked.");
            else
                Console.WriteLine("   Node belong to a linked list with {0} elements", lln.List.Count);

            if (lln.Previous == null)
                Console.WriteLine("    Previous node is null");
            else
                Console.WriteLine("    value of previous node: {0}", lln.Previous.Value);

            if (lln.Next == null)
                Console.WriteLine("    Next node is null");
            else
                Console.WriteLine("    Value of next node: {0}", lln.Next.Value);

        }
    }
}

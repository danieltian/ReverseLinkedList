using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseLinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedList list = new LinkedList();

			list.Add("one") ;
			list.Add("two");
			list.Add("three");
			list.Add("four");
			list.Add("five");

			Console.WriteLine("List size = " + list.Count);

			for (Node node = list.headNode; node != null; node = node.nextNode)
			{
				Console.WriteLine((string)node.item);
			}

            Console.WriteLine();
            Console.WriteLine("Reversing list...");
			list.Reverse();

            Console.WriteLine();
			Console.WriteLine("List size = " + list.Count);

			for (Node node = list.headNode; node != null; node = node.nextNode)
			{
				Console.WriteLine((string)node.item);
			}

            Console.WriteLine();
            Console.WriteLine("Done, press any key to continue...");
		    Console.ReadLine();
		}
	}
}

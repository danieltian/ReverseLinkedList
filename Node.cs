using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseLinkedList
{
	class Node
	{
		public Object item;
		public Node nextNode;

		public Node(Object item)
		{
			this.item = item;
			nextNode = null;
		}
	}
}

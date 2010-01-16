using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseLinkedList
{
	class LinkedList
	{
		public Node headNode;

		private int count;

		public int Count
		{
			get
			{
				int i = 1;

				if (headNode == null)
				{
					return 0;
				}
				else
				{
					Node currentNode = headNode;

					while (currentNode.nextNode != null)
					{
						i++;
						currentNode = currentNode.nextNode;
					}
				}

				return i;
			}
			set
			{
				count++;
			}
		}

		public LinkedList()
		{
			headNode = null;
		}

		public void Add(Object item)
		{
			Node newNode = new Node(item);

			if (headNode == null)
			{
				headNode = newNode;
			}
			else
			{
				Node currentNode = headNode;

				while (currentNode.nextNode != null)
				{
					currentNode = currentNode.nextNode;
				}

				currentNode.nextNode = newNode;
			}
		}

		public void Reverse()
		{
			Node previousNode;
			Node currentNode;
			Node nextNode;

			previousNode = headNode;
			currentNode = headNode.nextNode;
			headNode.nextNode = null;

			while (currentNode.nextNode != null)
			{
				// temporarily store the next node, or else we'll lose it when we change the pointer
				nextNode = currentNode.nextNode;
				// change the next node pointer to the previous node
				currentNode.nextNode = previousNode;
				// previous node is now the current node
				previousNode = currentNode;
				// current node is now the next node that was stored temporarily
				currentNode = nextNode;
				// at this point we've moved onto the next node
			}

			headNode = currentNode;
			headNode.nextNode = previousNode;
		}
	}
}

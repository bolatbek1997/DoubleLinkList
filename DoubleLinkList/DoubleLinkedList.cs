using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkList
{
	public class DoubleLinkedList
	{
		private Node _first;
		private Node _last;
		public int size;
		//{
		//	get{
		//		int a= 0;
		//		var node = _first;
		//		while (node != null) {
		//			a++;
		//			node = node.NextLink;
		//		}
		//		return a;
		//	}
		//}
		public bool IsEmpty
		{
			get
			{
				return _first ==null;
			}
		}
		public DoubleLinkedList()
		{
			_first = null;
			_last = null;
		}
		public Node FindNode(int n) 
		{
			if (size / 2 > n)
			{
				var count = 1;
				var index = _first;
				while (index != null)
				{
					if (count == n)
						break;

					index = index.NextLink;
					count++;
				}
				return index ?? null;
			}
			else {
				var count = size;
				var index = _first;
				while (index != null)
				{
					if (count == n)
						break;

					index = index.NextLink;
					count--;
				}
				return index ?? null;
			}

			
		}
		public string RemoveNode(int n)
		{
			if (!IsEmpty)
				return "\r\nLink list is empty";

			var node = FindNode(n);

			if (node == null)
				return "Node not found in Doubly Linked List\r\n";

			if (node != _first)
				node.PreviousLink.NextLink = node.NextLink;

			if (node.NextLink != null)
				node.NextLink.PreviousLink = node.PreviousLink;
			return "Node removed from Doubly Linked List\r\n";
		}

		public override string ToString()
		{
			Node currentLink = _first;
			StringBuilder builder = new StringBuilder();
			while (currentLink != null)
			{
				builder.Append(currentLink+"->");
				currentLink = currentLink.NextLink;
			}
			return builder.ToString();
		}

		public void InsertAtIndex(int n, string title)
		{
			var link = FindNode(n);
			if (link != null)
			{
				InsertBefore(link, title);
			}
			else
				Console.WriteLine($"Not found element at index {n}");
		}

			public void InsertAfter(Node link, string title)
		{
			if (link == null || string.IsNullOrEmpty(title))
				return;
			Node newLink = new Node(title);
			newLink.PreviousLink = link;
			if (link.NextLink != null)
			{
				newLink.NextLink = link.NextLink;
				link.NextLink.PreviousLink = newLink;
			}
			else {
				newLink.NextLink = null;
				_last = newLink;
			}
			link.NextLink = newLink;
			size++;
		}
		public void InsertBefore(Node link, string title)
		{
			if (link == null || string.IsNullOrEmpty(title))
				return;
			Node newLink = new Node(title);
			newLink.NextLink = link;
			if (link.PreviousLink != null)
			{
				newLink.PreviousLink = link.PreviousLink;
				link.PreviousLink.NextLink = newLink;
			}
			else {
				newLink.PreviousLink = null;
				_first = newLink;
			}
			link.PreviousLink = newLink;
			size++;
		}
		public void InsertBeginning( string title)
		{	
			Node newLink = new Node(title);
			if (_first == null)
			{
				_first = newLink;
				_last = newLink;
				newLink.PreviousLink = null;
				newLink.NextLink = null;
				size++;
			}
			else {
				InsertBefore(_first, title);
			}
		}


		public void InsertEnd(string title)
		{
			if (_last == null)
			{
				InsertBeginning(title);
			}
			else {
				InsertAfter(_last, title);
			}
		}

	}
}

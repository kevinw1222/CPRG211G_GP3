using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
	public class Node
	{
		private object element;
		private Node next;

		public Node(object o)
		{
			this.element = o;
			next = null;
		}

		public Node(object o, Node next)
		{
			this.element = o;
			this.next = next;
		}

		public object Element { get => element; set => element = value; }
		public Node Next { get => next; set => next = value; }
	}
}
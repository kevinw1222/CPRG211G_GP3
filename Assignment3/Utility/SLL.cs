/*
Create by: Kevin Wong, Nathaly Haro
Class: CPRG-211-G Obejct Oriented Development
Assignment: Group Assignment - Serialization & Tests
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
	public class SLL : LinkedListADT
	{
		private Node head;
		private Node tail;
		private int listSize = 0;

		public Node Head { get => head; set => head = value; }
		public Node Tail { get => tail; set => tail = value; }
		public int ListSize { get => listSize; set => listSize = value; }

		public SLL()
		{
			head = tail = null;
			listSize = 0;
		}

		public bool IsEmpty()
		{ return head == null; }

		public void Clear()
		{
			head = null;
			listSize = 0;
		}

		public void Append(Object o)
		{
			Node newNode = new Node(o);
			if (head == null)
			{
				head = newNode;
			}
			else
			{
				Node currentNode = head;
				while (currentNode.Next != null)
				{ currentNode = currentNode.Next; }

				currentNode.Next = newNode;
			}
			listSize++;
		}
		
		public void Prepend(Object o)
		{
			Node newNode = new Node(o);
			newNode.Next = head;
			head = newNode;
			listSize++;
		}
		
		public void Insert(Object o, int index)
		{
			if (index < 0 || index > listSize)
			{ throw new IndexOutOfRangeException(); }

			if (index == 0)
			{
				Prepend(o);
				return;
			}

			Node newNode = new Node(o);
			Node currentNode = head;
			for (int i = 0; i < index - 1; i++)
			{ currentNode = currentNode.Next; }

			newNode.Next = currentNode.Next;
			currentNode.Next = newNode;
			listSize++;
		}

		public void Replace(Object data, int index)
		{
			if (index < 0 || index >= listSize)
			{ throw new IndexOutOfRangeException(); }

			Node currentNode = head;
			for (int i = 0; i < index; i++)
			{ currentNode = currentNode.Next; }

			currentNode.Element = data;
		}

		public int Size()
		{
			return listSize;
		}

		public void Delete(int index)
		{
			if (index < 0 || index >= listSize)
			{ throw new IndexOutOfRangeException(); }

			if (index == 0)
			{ head = head.Next; }

			else
			{
				Node currentNode = head;
				for (int i = 0; i < index - 1; i++)
				{ currentNode = currentNode.Next; }

				currentNode.Next = currentNode.Next.Next;
			}
			listSize--;
		}

		public Object Retrieve(int index)
		{
			if (index < 0 || index >= listSize)
			{ throw new IndexOutOfRangeException(); }

			Node currentNode = head;
			for (int i = 0; i < index; i++)
			{ currentNode = currentNode.Next; }

			return currentNode.Element;
		}

		public int IndexOf(Object o)
		{
			Node currentNode = head;
			int index = 0;
			while (currentNode != null)
			{
				if (currentNode.Element.Equals(o))
				{ return index; }

				currentNode = currentNode.Next;
				index++;
			}
			return -1;
		}

		public bool Contains(Object o)
		{ return IndexOf(o) != -1; }
	}
}
using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.LinkedList
{
	public class LinkedListTest
	{
		private class LinkNode
		{
			public int Value { get; private set; }
			public LinkNode Next { get; set; }
			public LinkNode(int item)
			{
				Value = item;
			}
		}

		private LinkNode First { get; set; }
		private LinkNode Last { get; set; }
		public EventHandler<string> Print;

		public void AddFirst(int value)
		{
			var node = new LinkNode(value);
			if (First == null)
			{
				Last = First = node;
			}
			else
			{
				node.Next = First;

				First = node;
			}
			PrintElements("------Add item to First-------");
		}

		public void AddLast(int value)
		{
			var node = new LinkNode(value);
			if (Last == null)
			{
				First = Last = node;
			}
			else
			{
				Last.Next = node;
				Last = node;
			}
			PrintElements("------Add item to Last-------");
		}

		public void DeleteFirst()
		{
			LinkNode node = First.Next;
			if (node.Next is null)
			{
				Last = node;
			}
			First.Next = null;
			First = node;
			PrintElements("------Delete From First-------");
		}
		public void DeleteLast()
		{
			if (First == null)
			{
				throw new InvalidOperationException();
			}

			if (First.GetHashCode() == Last.GetHashCode())
			{
				First = Last = null;
				return;
			}



			var currentNode = First;

			while (currentNode.Next.GetHashCode() != Last.GetHashCode())
			{
				currentNode = currentNode.Next;
			}
			currentNode.Next = null;
			Last = currentNode;
			PrintElements("------Delete From Last-------");
		}

		public int IndexOf(int value)
		{
			var currentNode = First;
			int i = 0;
			do
			{
				if (currentNode.Value.Equals(value))
				{
					PrintMessage($"------Index Of {value} is {i}");
					return i;
				}
				currentNode = currentNode.Next;
				i++;
			} while (currentNode != null || currentNode?.Next != null);
			PrintMessage($"------Index Of {value} is -1");
			return -1;
		}

		public bool Contains(int value)
		{
			var contains = IndexOf(value);
			PrintMessage($"Contains value {value} is {(contains != -1)} ");
			return contains != -1;
		}

		private void PrintMessage(string message)
		{
			Print?.Invoke(this, message);
		}

		private void PrintElements(string message)
		{
			var currentNode = First;
			PrintMessage(message);
			do
			{
				PrintMessage(currentNode.Value.ToString());
				currentNode = currentNode.Next;
			} while (currentNode != null || currentNode?.Next != null);
		}

	}
}

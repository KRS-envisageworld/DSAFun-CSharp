using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DatastructureAndAlgo_Practice.SignlyLinkedList
{
	public class Node
	{
		public int value { get; set; }
		public Node next { get; set; }

		public Node(int value = 0) { this.value = value; }
	}
	public class SinglyLinkList
	{
		public Node Head { get; set; }
		public Node Tail { get; set; }
		public int Length { get; set; }

		public SinglyLinkList()
		{
			this.Head = null;
			this.Tail = null;
			this.Length = 0;
		}

		public void Push(int val)
		{
			Node node = new Node(val);
			if (this.Length == 0) { this.Head = node; this.Tail = this.Head; }
			else
			{
				this.Tail.next = node;
				this.Tail = node;
			}
			this.Length++;
		}

		public Node Pop()
		{
			if (this.Length == 0) { return null; }
			Node currentNode = this.Head;
			Node previousNode = currentNode;


			while (currentNode.next != null)
			{
				previousNode = currentNode;
				currentNode = currentNode.next;
			}
			previousNode.next = null;
			this.Tail = previousNode;
			this.Length--;

			if (this.Length == 0)
			{
				this.Head = null;
				this.Tail = null;
			}
			return currentNode;
		}

		public Node Unshift(int val)
		{
			Node node = new Node(val);
			if (this.Length == 0)
			{
				this.Head = node;
				this.Tail = this.Head;
			}
			else
			{
				node.next = this.Head;
				this.Head = node;
			}
			this.Length++;
			return node;
		}

		public Node Remove(int index)
		{
			if (this.Length == 0 || index < 0 || index >= this.Length) { return null; }
			if (index == 0) { return this.Shift(); }
			if (index == this.Length - 1) { return this.Pop(); }
			Node prevNode = this.Get(index - 1);
			Node nextNode = this.Get(index).next;
			var removedNode = prevNode.next;
			prevNode.next = nextNode;
			this.Length--;
			return removedNode;
		}
		public Node Get(int index)
		{
			if (this.Length == 0 || index < 0 || index >= this.Length) { return null; }
			if (index == 0) return this.Head;

			var currentNode = this.Head;
			int counter = 0;
			while (counter != index && currentNode.next != null)
			{
				currentNode = currentNode.next;
				counter++;
			}

			return currentNode;
		}

		public Node Insert(int val, int index)
		{
			if (this.Length == 0 || index < 0 || index > this.Length) { return null; }
			Node newNode = new Node(val);
			if (index == 0)
			{
				newNode.next = this.Head;
				this.Head = newNode;
			}
			else if (index == this.Length) { this.Push(val); }
			else
			{
				Node prevNode = this.Get(index - 1);
				Node nextNode = this.Get(index);

				if (prevNode != null && nextNode != null)
				{
					prevNode.next = newNode;
					newNode.next = nextNode;
				}
			}
			this.Length++;
			return newNode;
		}

		public Node Shift()
		{

			if (this.Length == 0) { return null; }
			Node removedNode = null;
			if (this.Length == 1)
			{
				this.Head = null;
				this.Tail = null;
			}
			else
			{
				removedNode = this.Head.next;
				this.Head = this.Head.next;
			}
			this.Length--;
			return removedNode;
		}

		public void Reverse()
		{
			Node previousNode = null;
			var currentNode = this.Head;
			this.Head = this.Tail;
			this.Tail = currentNode;
			int counter = 0;
			Node next;

			while (this.Length > counter)
			{
				next = currentNode.next;
				currentNode.next = previousNode;
				previousNode = currentNode;
				currentNode = next;

				counter++;
			}
		}


		public bool DetectLoop() {
			Node slowNode = this.Head;
			Node fastNode = this.Head;

			while(slowNode != null && fastNode != null && fastNode.next != null) {
				slowNode = slowNode.next;
				fastNode = fastNode.next.next;
				if (slowNode == fastNode) {
					return true;
				}
			}
			return false;
		}

		public Node Clone() {
			Dictionary<Node, Node> mp = new Dictionary<Node, Node>();
			Node temp, clonned;
			temp = this.Head;
			clonned = new Node(temp.value);
			mp[temp] = clonned;

			while (temp.next != null)
			{
				clonned.next = new Node(temp.next.value);
				temp = temp.next;
				clonned = clonned.next;
				mp[temp] = clonned;
			}
			temp = this.Head;
			return mp[temp];
		}


		public void PrintSL()
		{
			var currentNode = this.Head;

			StringBuilder str = new StringBuilder();
			int counter = 0;
			while (counter < this.Length)
			{
				str.Append($"{currentNode.value},");
				currentNode = currentNode.next;
				counter++;
			}

			Console.WriteLine(str.ToString().Trim(','));
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.BST
{
	using System;

	public class Node
	{
		public int Value { get; set; }
		public Node Left { get; set; }
		public Node Right { get; set; }

		public Node(int value)
		{
			Value = value;
			Left = null;
			Right = null;
		}
	}

	public class BinarySearchTree
	{
		public Node Root { get; set; }

		public BinarySearchTree()
		{
			Root = null;
		}

		public BinarySearchTree Insert(int value)
		{
			var newNode = new Node(value);

			if (Root == null)
			{
				Root = newNode;
				return this;
			}

			var current = Root;

			while (true)
			{
				if (value == current.Value) return this;

				if (value < current.Value)
				{
					if (current.Left == null)
					{
						current.Left = newNode;
						return this;
					}

					current = current.Left;
				}
				else
				{
					if (current.Right == null)
					{
						current.Right = newNode;
						return this;
					}

					current = current.Right;
				}
			}
		}

		public Node Find(int value)
		{
			if (Root == null)
				return null;

			var current = Root;

			while (current != null)
			{
				if (value < current.Value)
				{
					current = current.Left;
				}
				else if (value > current.Value)
				{
					current = current.Right;
				}
				else
				{
					return current;
				}
			}

			return null;
		}

		public bool Contains(int value)
		{
			if (Root == null)
				return false;

			var current = Root;

			while (current != null)
			{
				if (value < current.Value)
				{
					current = current.Left;
				}
				else if (value > current.Value)
				{
					current = current.Right;
				}
				else
				{
					return true;
				}
			}

			return false;
		}
	}




}

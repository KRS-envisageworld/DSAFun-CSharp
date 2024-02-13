using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{

	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
		}
	}

	public class AddToLinkedListInReverseOrder : IRunProgram
	{
		public void Run()
		{
			ListNode listNode = new ListNode();
			listNode.val = 2;
			listNode.next = new ListNode(4);
			listNode.next.next = new ListNode(3);

			ListNode listNode2 = new ListNode();
			listNode2.val = 5;
			listNode2.next = new ListNode(6);
			listNode2.next.next = new ListNode(4);

			AddTwoNumbers(listNode, listNode2);
		}

		public string GetReversedNumber(ListNode listNode)
		{

			if (listNode.next == null) { return listNode.val.ToString(); }

			return GetReversedNumber(listNode.next) + listNode.val.ToString();
		}

		public ListNode GetList(int num)
		{
			ListNode listNode = new ListNode();
			int lastDigit = Convert.ToInt32(Math.Floor(Math.Abs(num) / Math.Pow(10, 0)) % 10);
			listNode.val = lastDigit;
			if (Math.Floor(Math.Log10(Math.Abs(num))) + 1 == 1) {
				return listNode;
			}
			listNode.next = GetList(Convert.ToInt32(Math.Floor((Math.Abs(num) / Math.Pow(10, 0)) / 10)));
			return listNode;
		}

		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{

			int num1 = Convert.ToInt32(GetReversedNumber(l1));
			int num2 = Convert.ToInt32(GetReversedNumber(l2));
			ListNode node = GetList(num1 + num2);
			return node;
		}
	}
}

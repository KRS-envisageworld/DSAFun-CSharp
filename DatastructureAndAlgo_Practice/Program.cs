
using DatastructureAndAlgo_Practice.BST;
using DatastructureAndAlgo_Practice.Leetcode_Practice;
using DatastructureAndAlgo_Practice.LinkedList;
using DatastructureAndAlgo_Practice.SignlyLinkedList;
using DatastructureAndAlgo_Practice.Sorts;

using System;
using System.Collections.Generic;

namespace DatastructureAndAlgo_Practice
{

	class Program
	{
		static void Main(string[] args)
		{
			IRunProgram program = GetInstance();
			if (program != null)
			{
				program.Run();
				while (true)
				{
					Console.WriteLine("Do you want to continue? Press Y to continue.");
					if (Console.ReadLine().ToLower() != "y")
					{
						break;
					}
					program.Run();

				}
			}
			

		}

		public static IRunProgram GetInstance()
		{
			IRunProgram instance = null;
			Console.WriteLine("Please select which program do you want to execute.");
			Console.WriteLine(@" 
1  > HCF  
2  > LCM  
3  > Factorial  
4  > Fibonaci  
5  > FizzBuzz  
6  > Balanced Brackets  
7  > Prime numbers in range  
8  > Daily Temperature   
9  > LCM of subarray  
10 > Max sub array  
11 > Palindriome   
12 > Max sum with give target with windowsize  
13 > MaxSumPairExist  
14 > InsertionSort 
15 > QuickSort 
16 > MergeSort 
17 > BST 
18 > SinglyLinkList 
19 > TwoNumberSum
20 > AddToLinkedListInReverseOrder

");
			switch (Console.ReadLine())
			{
				case "1":
					instance = new HCF();
					break;
				case "2":
					instance = new LCM();
					break;
				case "3":
					instance = new Factorial();
					break;
				case "4":
					instance = new Fibonaci();
					break;
				case "5":
					instance = new FizzBuzz();
					break;
				case "6":
					instance = new BalancedBrackets();
					break;
				case "7":
					instance = new PrimeNumber();
					break;
				case "8":
					instance = new Temperature();
					break;
				case "9":
					instance = new SubArrayEqualToLCM();
					break;
				case "10": 
						instance = new MaxSubarray();
					break;
				case "11":
					instance = new Palindrome();
					break;
				case "12":
					instance = new MaxSumToGivenTarget();
					break;
				case "13":
					instance = new MaxSumPairExist();
					break;
				case "14":
					instance = new InsertionSort();
					break;
				case "15":
					instance = new QuickSort();
					break;
				case "16":
					instance = new MergeSort();
					break;
				case "17":
					RunBinarySearchTree();
					break;
				case "18":
					SinglyLinskList();
					break;
				case "19":
					instance = new TwoNumberSum();
					break;
				case "20":
					instance = new AddToLinkedListInReverseOrder();
					break;
				default:
					Console.WriteLine("Please select valid program.");
					break;
			}
			return instance;
		}

		public static void RunBinarySearchTree() {
		
				// Example usage:
				BinarySearchTree tree = new BinarySearchTree();
				tree.Insert(10);
				tree.Insert(5);
				tree.Insert(15);

				Console.WriteLine(tree.Contains(5)); // Output: True
				Console.WriteLine(tree.Contains(12)); // Output: False
	}

		private static void SinglyLinskList() {
			SinglyLinkList sl = new SinglyLinkList();
			sl.Push(1);
			sl.Push(2);
			sl.Push(3);
			Console.WriteLine(sl.Pop().value);
			Console.WriteLine(sl.Pop().value);
			Console.WriteLine(sl.Pop().value);
			Console.WriteLine(sl.Pop()?.value);
			sl.Push(1);
			sl.Push(2);
			sl.Push(3);
			var res = sl.Get(3);
			PrintMessage(null, res?.ToString());
			PrintMessage(null, sl.Get(2).value.ToString());
			PrintMessage(null, sl.Get(1).value.ToString());
			PrintMessage(null, sl.Get(0).value.ToString());

			sl.Insert(4, 2);
			sl.Push(5);
			sl.Remove(4);
			sl.Remove(0);
			sl.Shift();
			sl.Remove(1);
			sl.Remove(0);

			sl.Push(1);
			sl.Push(2);
			sl.Push(3);
			sl.Push(4);
			sl.Push(5);
			sl.Push(6);
			sl.Reverse();
			sl.Shift();
			sl.Shift();
			sl.Shift();
			sl.Shift();
			sl.Shift();
			sl.Shift();
			sl.Push(1);
			sl.Push(2);
			sl.Push(3);
			sl.Push(4);
			sl.Push(5);
			sl.Push(6);
			sl.Clone();
			sl.Head.next.next.next.next.next = sl.Head;
			Console.WriteLine($"{sl.DetectLoop()}");
		}
		protected static void PrintMessage(object sender, string message)
		{
			Console.WriteLine(message);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class Factorial : IRunProgram
	{
		public void Run()
		{
			FindFactorial();
		}

		public void FindFactorial() {
			Console.WriteLine("Enter number to find factorial:");
			int num = Convert.ToInt32(Console.ReadLine());

			int find(int n)
			{
				if(n == 0) { return 1; }
				return n * find(n - 1);
			}

			int fact = find(num);
			Console.WriteLine($"Factorial of {num} is : {fact}");

		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class FizzBuzz : IRunProgram
	{
		public void Run()
		{
			MyFizzBuzz(15);
		}

		private IList<string> MyFizzBuzz(int limit) {

			if (limit < 0) { return new string[0]; }
			IList<string>result = new string[limit];
			int counter = 1;
			while (counter <= limit)
			{
				if (counter % 3 == 0)
				{
					if (counter % 5 == 0) result[counter - 1] = "FizzBuzz";
					else result[counter - 1] = "Fizz";

				}
				else if (counter % 5 == 0)
				{
					result[counter - 1] = "Buzz";
				}
				else
				{
					result[counter - 1] = $"{counter}";
				}
				counter++;
			}

			return result;
		}
	}
	/// <summary>
	/// Leet code solution for FizzBuzz
	/// </summary>
	public class Solution
	{
		public IList<string> FizzBuzz(int n)
		{
			IList<string> result = new List<string>();

			for (int i = 1; i <= n; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					result.Add("FizzBuzz");
				}
				else if (i % 3 == 0)
				{
					result.Add("Fizz");
				}
				else if (i % 5 == 0)
				{
					result.Add("Buzz");
				}
				else
				{
					result.Add(i.ToString());
				}
			}

			return result;
		}
	}
}

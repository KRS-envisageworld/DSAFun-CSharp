using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class Temperature : IRunProgram
	{
		public void Run()
		{
			CalculateTemp();
		}
		//[73,74,75,71,69,72,76,73]
		private int[] CalculateTemp()
		{
			Console.WriteLine("Enter comma seperated array for temperature:");
			string[] arrStr = Console.ReadLine().Split(',');
			int[] arr = Array.ConvertAll(arrStr, int.Parse);
			int[] result = new int[arr.Length];
			Array.Fill(result, 0);

			Stack<List<int>> stack = new Stack<List<int>>();
			stack.Push(new List<int>() { arr[0], 0 });

			for (int i = 1; i < arr.Length; i++)
			{
				if (stack.Peek()[0] < arr[i])
				{
					while (stack.Count > 0 && stack.Peek()[0] < arr[i])
					{
						List<int> val = stack.Peek();
						stack.Pop();
						result[val[1]] = i - val[1];
					}
				}
					stack.Push(new List<int>() { arr[i], i });
			}

			return result;
		}

		// Leetcode improved solution
		public int[] DailyTemperatures(int[] temperatures)
		{
			int[] result = new int[temperatures.Length];
			Stack<int> stack = new Stack<int>();
			for (int i = 0; i < temperatures.Length; i++)
			{
				while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
				{
					int val = stack.Pop();
					result[val] = i - val;
				}
				stack.Push(i);
			}
			return result;
		}

	}
}

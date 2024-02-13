using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class SubArrayEqualToLCM : IRunProgram
	{
		public void Run()
		{
			FindSubArrayLCM(new int[5] { 3, 6, 2, 7, 1 }, 6);
		}

		public int FindSubArrayLCM(int[] nums, int k)
		{
			int counter = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] == k) counter++;
				for (int j = i + 1; j < nums.Length; j++)
				{
					int Lcm = FindLCM(nums[i], nums[j]);
					if (Lcm == k) counter++;
					if (Lcm > k) break;
				}
			}
			return counter;
		}

		private int FindHCF(int a, int b)
		{
			int min = Math.Min(a, b);
			while (min > 0)
			{
				if (a % min == 0 && b % min == 0) break;
				min--;
			}
			return min;
		}

		private int FindLCM(int a, int b)
		{
			return (a * b) / FindHCF(a, b);
		}
	}
}

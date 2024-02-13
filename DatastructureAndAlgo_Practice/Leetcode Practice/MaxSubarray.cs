using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class MaxSubarray : IRunProgram
	{
		public void Run()
		{
			int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
			CalculateMaxSubArray(nums);
		}

		public int CalculateMaxSubArray(int[] nums) {
			int lenN = nums.Length;
			if (lenN == 1) return nums[0];
			int maxSum = nums[0];
			int sum = 0;
			for (int i = 1; i < lenN; i++)
			{
				sum += nums[i];
				maxSum = Math.Max(maxSum, sum);
				if (sum < 0) sum = 0;
			}
			Console.WriteLine($"MaxSubarray is: {maxSum}");
			return maxSum;
		}
	}
}

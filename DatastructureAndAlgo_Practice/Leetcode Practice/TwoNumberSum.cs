using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class TwoNumberSum : IRunProgram
	{
		public void Run()
		{
			int[] arr = { 2, 7, 11, 15 };
			TwoSum(arr, 9);
		}
		public int[] TwoSum(int[] nums, int target)
		{
			for(int i =0 ; i < nums.Length; i++)
			{
				for (int j = 1; j < nums.Length; j++) {
					if ((nums[i] + nums[j]) == target) {
						return new int[2]{ i, j};
					}
				}
			}
			return null;
		}
	}
}

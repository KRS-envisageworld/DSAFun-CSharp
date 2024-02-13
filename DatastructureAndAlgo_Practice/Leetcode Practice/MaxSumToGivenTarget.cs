using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class MaxSumToGivenTarget : IRunProgram
	{
		public void Run()
		{
			int[] arr = { 100, 200, 300, 400 };
			FindMaxSum(arr, 350 ,2);
		}

		private int FindMaxSum(int[] arr, int target, int windowSize) { 
			if(arr.Length == 0) { return 0; }

			var max = 0;
			for(int i = 0; i < windowSize; i++)
			{
				max += arr[i];
			}
			var innerMax = max;

			for (int i =windowSize; i < arr.Length; i++) { 
				innerMax  = innerMax - arr[i-windowSize] + arr[i];
				max = Math.Max(max, innerMax);
				if (max >= target) {
					break;	
				}
			}
			Console.WriteLine(max);
			return max;
		}
	}
}

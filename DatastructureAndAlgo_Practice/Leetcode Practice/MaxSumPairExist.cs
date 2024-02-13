using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class MaxSumPairExist : IRunProgram
	{
		public void Run()
		{
			int[] arr = { 100, 200, 300, 400 };
			FindMaxSumPair(arr, 500);
		}

		private bool FindMaxSumPair(int[] arr, int target) {
			int i = 0;
			Hashtable table = new System.Collections.Hashtable();
			int diffrence = 0;
			while (i < arr.Length) {
				diffrence = target - arr[i];
				if (!table.Contains(diffrence))
				{
					table.Add(arr[i], diffrence);
				}
				else {
					return true;
				}
			i++;
			}

			return false;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace DatastructureAndAlgo_Practice.Sorts
{
	public class InsertionSort : IRunProgram
	{
		public void Run()
		{
			int[] arr = { 2, 1, 9, 76, 4 };
			GetInsertionSort(arr);
		}

		private int[] GetInsertionSort(int[] arr) { 
			if(arr.Length <= 0) return null;
			var currentVal = 0;
			for (int i = 1; i < arr.Length; i++) { 
				currentVal = arr[i];
				int j;
				for (j = i-1; j >=0 && arr[j] > currentVal; j--)
				{
					arr[j+1] = arr[j];
				}
				arr[j + 1] = currentVal;
			}
			return arr;
		}
	}
}

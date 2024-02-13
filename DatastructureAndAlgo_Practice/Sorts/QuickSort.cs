using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DatastructureAndAlgo_Practice.Sorts
{
	public class QuickSort : IRunProgram
	{
		public void Run()
		{
			int[] arr = { 5, 4, 1, 8, 9, 6, 2, 3 };
			SortUisngQuicksort(arr, 0, arr.Length - 1);
		}
		// 5,4,1,8,9,6,2,3
		private int FetchPivotIndex(int[] arr, int start, int end) { 
			int pivot= arr[start];
			int swapIndex = start;

			for(int i = start +1; i <= end; i++)
			{
				if (arr[i] < pivot) {
					swapIndex++;
					Swap(arr, i, swapIndex);
				}
			}
			Swap(arr, start, swapIndex);
			return swapIndex;
		}

		private int[] SortUisngQuicksort(int[] arr, int left, int right) { 
			if(left< right) { 
				int pivotIndex = FetchPivotIndex(arr, left, right);
				SortUisngQuicksort(arr, pivotIndex +1, right);
				SortUisngQuicksort(arr, left, pivotIndex-1);
			}
			Print(arr);
			return arr;
		}
		private void Print(int[] arr) {
			StringBuilder str = new StringBuilder();
			foreach(int i in arr)
			{
				str.Append($"{i},");
			}
			Console.WriteLine(str.ToString().Trim(','));
		}
		private int[] Swap(int[] arr, int sourceIndex, int destinationIndex) {
			var temp = arr[sourceIndex];
			arr[sourceIndex] = arr[destinationIndex];
			arr[destinationIndex] = temp;
			return arr;
		}
	}
}

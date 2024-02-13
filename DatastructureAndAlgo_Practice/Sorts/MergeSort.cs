using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatastructureAndAlgo_Practice.Sorts
{
	public class MergeSort : IRunProgram
	{
		public void Run()
		{
			List<int> inputArray = new List<int> { 38, 27, 43, 3, 9, 82, 10 };
			Print(SortUsingMergeSort(inputArray));
		}

		public static List<int> Merge(List<int> arr1, List<int> arr2)
		{
			List<int> results = new List<int>();
			int i = 0;
			int j = 0;

			while (i < arr1.Count && j < arr2.Count)
			{
				if (arr2[j] > arr1[i])
				{
					results.Add(arr1[i]);
					i++;
				}
				else
				{
					results.Add(arr2[j]);
					j++;
				}
			}

			while (i < arr1.Count)
			{
				results.Add(arr1[i]);
				i++;
			}

			while (j < arr2.Count)
			{
				results.Add(arr2[j]);
				j++;
			}

			return results;
		}

		public static List<int> SortUsingMergeSort(List<int> arr)
		{
			if (arr.Count <= 1)
				return arr;

			int mid = arr.Count / 2;
			List<int> left = SortUsingMergeSort(arr.GetRange(0, mid));
			List<int> right = SortUsingMergeSort(arr.GetRange(mid, arr.Count - mid));

			return Merge(left, right);
		}

		private void Print(List<int> sortedArray)
		{

			foreach (int num in sortedArray)
			{
				Console.Write(num + " ");
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class Fibonaci : IRunProgram
	{
		public void Run()
		{
			MyFibonaci();
		}

		private void MyFibonaci() {
			Console.WriteLine("Enter the number:");
			int num = Convert.ToInt32(Console.ReadLine());

			int a = 0, b = 1, c;
			StringBuilder str = new StringBuilder($"{a}\t{b}\t");
			for(int i = 2; i < num; i++)
			{
				c = a + b;
				str.Append($"{c}\t");
				a = b;
				b = c;
			}
			Console.WriteLine(str.ToString());
		}
	}
}

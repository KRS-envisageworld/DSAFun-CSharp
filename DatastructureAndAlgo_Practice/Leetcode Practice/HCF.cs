using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class HCF : IRunProgram
	{
		public void Run()
		{
			FindHCF();
		}

		private void FindHCF() {
			Console.WriteLine("Enter two numbers to find the HCF:");
			int num1 = Convert.ToInt32(Console.ReadLine());
			int num2 = Convert.ToInt32(Console.ReadLine());
			
			int min = Math.Min(num1, num2);

			while (min > 0)
			{
				if(num1 % min  == 0 && num2 % min ==0) { break; }
				min--;
			}

			Console.WriteLine(min);
		}
	}
}

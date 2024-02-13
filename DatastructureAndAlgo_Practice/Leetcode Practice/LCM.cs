using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class LCM : IRunProgram
	{
		public void Run()
		{
			FindLCM();
		}

		private void FindLCM() {
			Console.WriteLine("Enter numbers to find the LCM");
			int firstNum = Convert.ToInt32(Console.ReadLine());
			int secondNum= Convert.ToInt32(Console.ReadLine());

			int min = Math.Min(firstNum, secondNum);
			while(min > 0)
			{
				if (firstNum % min == 0 && secondNum % min == 0) {
					break;
				}
				min--;
			}
			Console.WriteLine($"{min}");

			int lcm = (firstNum * secondNum) / min;
			Console.WriteLine($"LCM of {firstNum} and {secondNum} is: {lcm}");
		}
	}
}

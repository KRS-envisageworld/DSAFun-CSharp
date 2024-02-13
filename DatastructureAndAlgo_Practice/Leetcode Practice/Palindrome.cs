using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class Palindrome : IRunProgram
	{
		public void Run()
		{
			IsPalindrom("IBM");
		}

		private bool IsPalindrom(string input) { 
			if(string.IsNullOrEmpty(input)) return false;

			string output = GetReversedString(input);

			return output == input;
		}

		private string GetReversedString(string input) {
			if (string.IsNullOrEmpty(input)) return "";

			return input.Substring(input.Length - 1) + GetReversedString(input.Substring(0, input.Length - 1));
		}

	}
}

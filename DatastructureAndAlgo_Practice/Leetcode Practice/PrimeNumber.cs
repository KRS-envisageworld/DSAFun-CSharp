using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class PrimeNumber : IRunProgram
	{
		public void Run()
		{
			FindPrime();
		}

		private void FindPrime() {

			Console.WriteLine("Enter range to find prime numbers:");

			int limit = Convert.ToInt32(Console.ReadLine());
			if(limit == 1) { Console.WriteLine($"Number of prime numbers and count is 1 and "); return; }
			int primeCount = 0;
			StringBuilder	stringBuilder = new StringBuilder();
			for (int i = 2; i < limit; i++)
			{
				bool isPrime = true;
				int halfLimit =(int)(limit / 2);
				for(int j = 2; j < halfLimit; j++)
				{
					if (i % j == 0) {
						isPrime = false;
						break;
					}
				}
				if (isPrime)
				{
					stringBuilder.Append($"{i},");
					primeCount++;
				}
			}
			Console.WriteLine($"Count of prime number is: {primeCount}");

			Console.WriteLine($"Prime numbers are: {stringBuilder.ToString().Trim(',')}.");
		}
	}
}

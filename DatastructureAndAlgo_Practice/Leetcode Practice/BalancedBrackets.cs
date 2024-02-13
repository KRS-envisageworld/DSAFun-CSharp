using System;
using System.Collections.Generic;
using System.Text;

namespace DatastructureAndAlgo_Practice.Leetcode_Practice
{
	public class BalancedBrackets : IRunProgram
	{
		public void Run()
		{
			IsBalancedBrackets(new char[] { '{', '(', '}',')' });
		}

		private bool IsBalancedBrackets(char[] brrackets) { 
			Stack<char> brcStack= new Stack<char>();
			bool isbalanced = true;
			for (int i = 0; i < brrackets.Length; i++) {
				if (brrackets[i] == '{' || brrackets[i] == '(' || brrackets[i] == '[')
				{
					brcStack.Push(brrackets[i]);
				}
				else if (brrackets[i] == '}' || brrackets[i] == ')' || brrackets[i] == ']')
				{
					if (brcStack.Count == 0) {
						isbalanced = false;
						break;
					}
					var popedVal = brcStack.Pop();
					if (popedVal == '(' && brrackets[i] != ')')
					{
						isbalanced = false;
						break;
					}
					else if (popedVal == '{' && brrackets[i] != '}')
					{
						isbalanced = false;
						break;
					}
					else if (popedVal == '[' && brrackets[i] != ']')
					{
						isbalanced = false;
						break;
					}
				}
				else {
					isbalanced = false;
					 break;
				}
			}

			if(brcStack.Count > 0)
			{
				isbalanced = false;
			}
			Console.WriteLine(isbalanced);
			return isbalanced ;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjectEulerDesktop
{
	public class BaseEulerProblem
	{
		string result = "";

		public BaseEulerProblem() { }
		public BaseEulerProblem(int problemNumber, long stopNumber)
		{ 
			switch (problemNumber)
			{
				case 1:
					Problem1 problem1Solution = new Problem1();
					result = string.Concat("Problem 1 - ", problem1Solution.MultiplesOfThreeOrFive(stopNumber));
					break;
				case 2:
					Problem2 problem2Solution = new Problem2();
					result = string.Concat("Problem 2 - ", problem2Solution.EvenFibonacciNumbers(stopNumber));
					break;
				case 3:
					Problem3 problem3Solution = new Problem3();
					result = string.Concat("Problem 3 - ", problem3Solution.LargestPrimeFactor(stopNumber));
					break;
				case 4:
					Problem4 problem4Solution = new Problem4();
					result = string.Concat("Problem 4 - ", problem4Solution.LargestSixDigitPalindrome(stopNumber));
					break;

				default:
					result = "No solution found for that number.";
					break;

			}
		}

		public string ReturnResult()
		{
			return result;	
		}

	}
}

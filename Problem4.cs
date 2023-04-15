using ProjectEulerDesktop;
using System;

public class Problem4 : BaseEulerProblem
{
	public Problem4()
	{
	}

	/*************************************************************************************************
	/*  A palindromic number reads the same both ways.                                               *
	/*  The smallest 6 digit palindrome made from the product of two 3-digit numbers is .101101      *
	/*  which is 143x707.                                                                            *
	/*  Find the largest palindrome made from the product of two 3-digit numbers which is less than N*
	/*  Constraint: 101101 < N < 1000000
	/************************************************************************************************/

	public int LargestSixDigitPalindrome(long maxNumber)
	{
		int palindrome = 101101;
		for (int x = 101; x < 999; x++)
		{
			for (int y = 999; y > x; y--)
			{
				int product = x * y;
				if (product >= 101101)
				{
					if (product < maxNumber)
					{
						string productString = product.ToString();
						for (int front = 0, back = 5; front < 3 && back > 2; front++, back--)
						{
							if (productString[front] != productString[back])
							{
								break;
							}
							else if (front == 2 && back == 3)
							{
								if (palindrome < product)
								{
									palindrome = product;
								}
							}
						}
					}
				}
				else
				{
					break;
				}
			}
		}
		return palindrome;
	}
}

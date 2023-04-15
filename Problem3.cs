using ProjectEulerDesktop;
using System;

public class Problem3 : BaseEulerProblem
{
	public Problem3()
	{
	}

	/*************************************************************************************************
	/*  The prime factors of 13195 are 5, 7, 13 and 29.                                              *
	/*  What is the largest prime factor of the number 600851475143, or any other given number?      *
	/*  Constraints - 10 <= maxNumber <= 10 to the 12th power                                        *
	/************************************************************************************************/

	public long LargestPrimeFactor(long maxNumber)
	{
		long maxPrimeFactor = maxNumber;
		for (long x = 2; x <= Math.Sqrt(maxNumber); x++)
		{
			while (maxNumber % x == 0)
			{
				maxNumber /= x;
				maxPrimeFactor = x;
			}
		}
		if (maxNumber > maxPrimeFactor)
		{
			maxPrimeFactor = maxNumber;
		}

		return maxPrimeFactor;
	}
}

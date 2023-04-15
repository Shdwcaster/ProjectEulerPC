using ProjectEulerDesktop;
using System;
using static ProjectEulerDesktop.BaseEulerProblem;

public class Problem1 : BaseEulerProblem
{
	public Problem1()
	{
	}

    /*  If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
     *  Find the sum of all the multiples of 3 or 5 below 1000.
     */  

	public long MultiplesOfThreeOrFive(long maxNumber)
	{
        long sum = 0;
        for (int x = 5; x < maxNumber; x += 5)
        {
            sum += x;
        }
        for (int x = 3; x < maxNumber; x += 3)
        {
            if (x % 5 != 0)
            {
                sum += x;
            }
        }

        return sum;
    }
}

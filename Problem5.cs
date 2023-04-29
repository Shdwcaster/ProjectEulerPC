using ProjectEulerDesktop;
using System;

public class Problem5 : BaseEulerProblem
{
    public Problem5()
    {
    }

    /*************************************************************************************************
	/*   2520 is the smallest number that can be divided by each of the numbers from to without any  *
    /*     remainder.  What is the smallest positive number that is evenly divisible(divisible with  *
    /*     no remainder) by all of the numbers from 1 to N?                                          *
    /*   Constraints: 1 <= T <= 10, 1 <= N <= 40                                                     *
	/************************************************************************************************/

    public int SmallestPositiveNumberEvenlyDivisible(int targetNumber)
    {
        int result = 1;
        for (int x = 1; x <= targetNumber; x++)
        {
            if (result % x == 0)
            {
                continue;
            }
            else
            {
                if (result != 1)
                {
                    result += 2;
                }
                else
                {
                    result += 1;
                }
                x = 0;
            }
        }
        return result;
    }
}

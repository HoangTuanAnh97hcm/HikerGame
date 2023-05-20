using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PrimeNumber 
{
    public static long CaculatorFactorial(int number)
    {
        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    public static bool IsPrimeNumber(int number)
    {
        if (number == 2 || number == 3)
            return true;

        if (number <= 1 || number % 2 == 0 || number % 3 == 0)
            return false;

        for (int i = 5; i * i <= number; i += 6) // sqrt
        {
            if (number % i == 0 || number % (i + 2) == 0) //6k +- 1
                return false;
        }

        return true;
    }
}

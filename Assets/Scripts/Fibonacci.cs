
using System.Numerics;
using UnityEngine;

public class Fibonacci 
{
    public static void FibonacciSequence(int length)
    {
        BigInteger fibonacci1 = 0;
        BigInteger fibonacci2 = 1;
        BigInteger fibonacci3 = 0;

        Debug.Log(fibonacci1);
        Debug.Log(fibonacci2);

        for (int i = 2; i < length; i++)
        {
            fibonacci3 = fibonacci1 + fibonacci2;
            fibonacci1 = fibonacci2;
            fibonacci2 = fibonacci3;

            Debug.Log(fibonacci3);
        }
    }
}

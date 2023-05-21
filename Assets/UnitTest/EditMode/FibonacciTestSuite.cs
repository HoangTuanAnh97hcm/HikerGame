using NUnit.Framework;
using UnityEngine;
using UnityEngine.Profiling;

public class FibonacciTestSuite
{
    [Test]
    public void ShowFibonacciSequence_FristOneHundred()
    {
        long pre = Profiler.GetTotalAllocatedMemoryLong();

        Fibonacci.FibonacciSequence(100);
        
        long after = Profiler.GetTotalAllocatedMemoryLong();

        Debug.LogWarning($"Memory take: {(after - pre) / 1024} kb");
    }
}

using NUnit.Framework;
using UnityEngine;

public class CaculateXYTestSuite
{
    [Test]
    public void Test()
    {
        Debug.Log(CaculateXY.CaculateXYOfObject(10, 45, 1));
    }
}

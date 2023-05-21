using NUnit.Framework;
using UnityEngine;

public class FractionTestSuite
{
    [Test]
    public void AdditionFraction_SameDen()
    {
        float number = (float)2 / (float)4;

        Assert.AreEqual(number, ConvertStringFractionToFloat(Fraction.AdditionFraction("1/4", "1/4")));
    }

    [Test]
    public void AdditionFraction_NegativeSameDen()
    {
        float number = (float)-2 / (float)4;

        Assert.AreEqual(number, ConvertStringFractionToFloat(Fraction.AdditionFraction("-1/4", "-1/4")));
    }

    [Test]
    public void AdditionFraction_ToZero()
    {
        float number = 0;

        Assert.AreEqual(number, ConvertStringFractionToFloat(Fraction.AdditionFraction("-1/2", "1/2")));
    }

    [Test]
    public void AdditionFraction_DifferentDen()
    {
        float number = (float)37 / (float)24;

        Assert.AreEqual(number, ConvertStringFractionToFloat(Fraction.AdditionFraction("4/6", "7/8")));
    }

    [Test]
    public void AdditionFraction_NegativeDifferentDen()
    {
        float number = (float)-37 / (float)24;

        Assert.AreEqual(number, ConvertStringFractionToFloat(Fraction.AdditionFraction("-4/6", "-7/8")));
    }

    public float ConvertStringFractionToFloat(string fraction)
    {
        string[] fractionStringArray = fraction.Split('/');
        return float.Parse(fractionStringArray[0]) / float.Parse(fractionStringArray[1]);
    }
}

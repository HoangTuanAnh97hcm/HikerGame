using System.Linq;

public class Fraction
{
    public static string AdditionFraction(string fractionInput1, string fractionInput2)
    {
        int[] fraction1 = fractionInput1.Split('/').Select(int.Parse).ToArray();
        int[] fraction2 = fractionInput2.Split('/').Select(int.Parse).ToArray();

        if (fraction1[1] == fraction2[1]) 
        {
            return $"{fraction1[0] + fraction2[0]}/{fraction1[1]}";
        }else
        {

            int denominator = GreatestCommonDivisor(fraction1[1], fraction2[1]);

            denominator = (fraction1[1] * fraction2[1]) / denominator;

            int numerator = (fraction1[0]) * (denominator / fraction1[1]) + (fraction2[0]) * (denominator / fraction2[1]);

            return SimplifyFraction(denominator, numerator);
        }
    }

    private static int GreatestCommonDivisor(int num1, int num2)
    {
        if (num1 == 0)
        {
            return num2;
        }
        else
        {
            return GreatestCommonDivisor(num2 % num1, num1);
        }
    }

    private static string SimplifyFraction(int denominator, int numerator)
    {
        int commonFactor = GreatestCommonDivisor(numerator, denominator);

        denominator = denominator / commonFactor;
        numerator = numerator / commonFactor;

        return $"{numerator}/{denominator}";
    }

}

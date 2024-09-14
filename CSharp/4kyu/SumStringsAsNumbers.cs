using System;
using System.Text;

namespace CSharp._4kyu;

public static class SumStringsAsNumbers
{
    public static string sumStrings(string a, string b)
    {
        NumberConversion(ref a, ref b);

        var upperGrade = 0;
        var result = new StringBuilder();
        
        for (var i = a.Length - 1; i >= 0; i--)
        {
            var firstDigit = a[i].ToString();
            var secondDigit = b[i].ToString();

            var firstInt = Convert.ToInt32(firstDigit);
            var secondInt = Convert.ToInt32(secondDigit);

            var newNumber = firstInt + secondInt + upperGrade;

            var newDigit = newNumber.ToString()[^1].ToString();
            result.Insert(0, newDigit);

            upperGrade = newNumber >= 10 ? 1 : 0;
        }

        if (upperGrade == 1)
        {
            result.Insert(0, upperGrade);
        }

        return result.ToString().TrimStart('0');
    }
  
    private static void NumberConversion(ref string a, ref string b)
    {
        StringBuilder num;

        var aLength = a.Length;
        var bLength = b.Length;
        
        if (aLength > bLength)
        {
            num = new StringBuilder(b);
            num.Insert(0, "0", aLength - bLength);
            b = num.ToString();
        }
        else
        {
            num = new StringBuilder(a);
            num.Insert(0, "0", bLength - aLength);
            a = num.ToString();
        }
    }
}

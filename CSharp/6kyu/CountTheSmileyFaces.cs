using System;
using System.Text.RegularExpressions;

namespace CSharp._6kyu;

public class CountTheSmileyFaces
{
    public static int CountSmileys(string[] smileys) 
    {
        return smileys.Count(x => Regex.IsMatch(x, @"^(:|;)\S?(\)|D)$"));
    }
    
}
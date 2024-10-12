using System;
using System.Linq;

namespace CSharp._6kyu;

public class ConvertStringToCamelCase
{
    public static string ToCamelCase(string str)
    {
        return str.Split(new [] {'-', '_'}).First() + string.Concat(str.Split(new [] {'-', '_'}).Skip(1)
            .Select(x => char.ToUpper(x.ToCharArray()
                .First()) + x.Remove(0,1)));
    }
}
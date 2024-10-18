namespace CSharp._6kyu;

public class BreakCamelCaseSolver
{
    public static string BreakCamelCase(string str)
    {
        string result = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                result += " " + str.Substring(0, i);
                str = str.Substring(i, str.Length - i);
                i = 0;
            }
        }
        return result.Trim() + " " + str;
    }
}
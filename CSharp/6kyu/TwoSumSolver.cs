namespace CSharp._6kyu;

public class TwoSumSolver
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int[] result = new int[2];
        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }
        return result;
    }
}
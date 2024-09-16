namespace CSharp._6kyu;

public class SortTheOdd
{
    public static int[] SortArray(int[] array)
    {
        for (var first = 0; first < array.Length; first++)
        {
            for (var second = first; second < array.Length; second++)
            {
                if (array[first] % 2 == 1 && array[second] % 2 == 1 && array[first] > array[second])
                {
                    (array[first], array[second]) = (array[second], array[first]);
                }
            }
        }

        return array;
    }
}
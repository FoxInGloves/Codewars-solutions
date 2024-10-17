namespace CSharp._6kyu;

public class FindTheOddInt
{
    public static int find_it(int[] seq) 
    {
        foreach (var i in seq)
        {
            if(seq.Count(x => x == i) % 2 != 0)
                return i;
        }
        return -1;
    }
}
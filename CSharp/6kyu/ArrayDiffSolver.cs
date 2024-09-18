namespace CSharp._6kyu;

public class ArrayDiffSolver
{
    public static int[] ArrayDiff(int[] a, int[] b)
    {
        List<int> list = new List<int>();
        list.AddRange(a);
        foreach(int i in b)
        {
            foreach(int g in a)
            {
                if(i == g)
                    list.Remove(i);
            }
        }
        int[] ret = list.ToArray();
        return ret;
    }
}
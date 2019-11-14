// https://www.codewars.com/kata/573992c724fc289553000e95/train/csharp

using System;

public class ToSmallest 
{
    public static long[] Smallest (long n)
    {
        string num = n.ToString();
        long[] result = null;

        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < num.Length; j++)
            {
                long[] t = MoveDigit(num, i, j);

                result = Max(result, t);
            }
        }

        return result;
    }

    private static long[] MoveDigit(string num, int src, int dest)
    {
        string c = num[src].ToString();
        num = num.Remove(src, 1);
        num = num.Insert(dest, c);

        return new long[] { long.Parse(num), src, dest };
    }

    private static long[] Max(long[] a, long[] b)
    {
        if (a == null)
            return b;

        if (b == null)
            return a;

        for(int i=0; i<3; i++)
        {
            if (a[i] < b[i])
                return a;
            
            if (b[i] < a[i])
                return b;
        }

        return a;
    }
}
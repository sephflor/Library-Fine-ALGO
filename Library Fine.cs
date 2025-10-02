using System;

class Result
{
    public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        if (y1 > y2) 
            return 10000;
        
        if (y1 == y2 && m1 > m2) 
            return 500 * (m1 - m2);
        
        if (y1 == y2 && m1 == m2 && d1 > d2) 
            return 15 * (d1 - d2);
        
        return 0;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().Split(' ');
        int d1 = Convert.ToInt32(firstMultipleInput[0]);
        int m1 = Convert.ToInt32(firstMultipleInput[1]);
        int y1 = Convert.ToInt32(firstMultipleInput[2]);
        
        string[] secondMultipleInput = Console.ReadLine().Split(' ');
        int d2 = Convert.ToInt32(secondMultipleInput[0]);
        int m2 = Convert.ToInt32(secondMultipleInput[1]);
        int y2 = Convert.ToInt32(secondMultipleInput[2]);
        
        int result = Result.libraryFine(d1, m1, y1, d2, m2, y2);
        Console.WriteLine(result);
    }
}

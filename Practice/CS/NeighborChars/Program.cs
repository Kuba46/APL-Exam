using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        List<string> neighborArray = StringToNeighborArray(inputString);

        foreach (var pair in neighborArray)
        {
            Console.WriteLine(pair);
        }
    }

    static List<string> StringToNeighborArray(string s)
    {
        List<string> neighborArray = new List<string>();

        for (int i = 0; i < s.Length - 1; i += 2)
        {
            neighborArray.Add(s.Substring(i, 2));
        }
        if (s.Length % 2 != 0)
        {
            neighborArray.Add(s[s.Length - 1] + "_");
        }
        return neighborArray;
    }
}

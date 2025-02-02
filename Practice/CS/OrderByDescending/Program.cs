using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> ints = new List<int> { 1, -1213, 2132, 2, 6, 2, 3, 8, 11, 1232, 453, 563, -7872 };

        List<int> sorted= ints.OrderByDescending(n => n).ToList();

        foreach (int elem in sorted)
        {
            Console.WriteLine(elem);
        }
    }
}
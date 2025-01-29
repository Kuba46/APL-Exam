using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> list = new List<double> { 3.1, 1.2, 3.4, 5.2, 5.4, 2.4, 8.5 };
        List<double> sortedList = BubbleSort(list);

        Console.WriteLine("Sorted collection: ");
        foreach (var number in sortedList)
        {
            Console.WriteLine(number);
        }
    }

    static List<double> BubbleSort(List<double> list)
    {
        List<double> copy = new List<double>(list);
        int n = copy.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (copy[j] > copy[j + 1])
                {
                    double temp = copy[j];
                    copy[j] = copy[j + 1];
                    copy[j + 1] = temp;
                }
            }
        }
        return copy;
    }
}
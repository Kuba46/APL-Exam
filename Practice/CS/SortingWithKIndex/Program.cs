using System;
using System.Collections.Generic;
using System.Linq;

// На вход поступает массив из A элементов и индекс K. На C# (LINQ) срезать первые K элементов коллекции, а затем отсортировать её, оставив только нечётные элементы, по убыванию

class Program
{
    static void Main()
    {
        List<int> mainArr = new List<int> { 10, 2, 3, 5, 1, 3, 4, 6, 7, 12, 3, 4, 5, 11, 14, 15 };
        int K = 3;

        List<int> result = mainArr.Skip(K).Where(x => x % 2 != 0).OrderByDescending(x => x).ToList();
        //List<int> result = mainArr.Skip(K).Where(x => x % 2 == 0).OrderByDescending(x => x).ToList();
        //List<int> result = mainArr.Skip(K).Where(x => x % 2 != 0).Distinct().OrderByDescending(x => x).ToList();
        //List<int> result = mainArr.Skip(K).Where(x => x % 2 == 0).Distinct().OrderByDescending(x => x).ToList();

        result.ForEach(Console.WriteLine);
    }
}

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = "asadadfsad";
        char target = 'a';

        int output = input.Count(n => n == target);

        Console.WriteLine(output);
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();
        ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
        // ну если совсем тяжко, то можете просто написать char target = 'любой ваш символ'

        char target = (char)keyInfo.KeyChar;

        int result = CountDesiredChars(input, target);

        Console.WriteLine($"Target character '{target}' enters the string {result} times.");
    }

    static int CountDesiredChars(string inputString, char desiredChars)
    {
        int count = 0;
        foreach (char c in inputString)
        {
            if (c == desiredChars)
            { 
                count++;
            }
        }
        return count;
    }
}
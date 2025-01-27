using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите значение n: ");
            int n = int.Parse(Console.ReadLine());

            int result = Fibonacci(n);
            Console.WriteLine($"F({n}) = {result}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }

    static int Fibonacci(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Параметр n не может быть отрицательным.");
        }
        else if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

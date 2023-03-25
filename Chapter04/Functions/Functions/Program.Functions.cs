using static System.Console;
partial class Program
{
    static void DoSomething() // define a non-local static function
    {
        WriteLine("Doing something!");
    }

    static void Multiply(int size )
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                WriteLine($"{i} * {j} = {i * j}");
            }
            WriteLine("-------------------");
        }
    }

    static void TimesTable(byte number, byte size = 12)
    {
        for (int i = 1; i< size; i++)
        {
            WriteLine($" {i}*{number} = {i * number}");
        }
    }

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(message:
            $"The factorial function is defined for non-negative integers only.Input: { number }",
        paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}
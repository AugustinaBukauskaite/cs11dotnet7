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
    static void RunFactorial()
    {
        for (int i =-2; i < 15; i++)
        {
            try
            {
                WriteLine($"{i}!= {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }

    static int FibImperative(int term)
    {
        if (term ==1)
        {
            return 0;
        }
        if (term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term-1)+FibImperative(term-2);
        }

    }

    static int FibFunctional(int term) =>
        term switch
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(term-1) + FibFunctional(term-2)

        };

}
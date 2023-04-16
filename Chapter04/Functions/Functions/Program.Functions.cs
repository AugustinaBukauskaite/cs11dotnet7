using System.Buffers.Text;
using System.Diagnostics;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

partial class Program
{
    static void DoSomething() // define a non-local static function
    {
        WriteLine("Doing something!");
    }
    /// <summary>
    /// Print  multiplication table up to a certain amount
    /// </summary>
    /// <param name="size">the value up to which the multiplication table will be created</param>
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

    static void MyChecked()
    {
        unchecked
        {
            int x = int.MaxValue;
            WriteLine(x);
            x++;
            WriteLine(x);
            x++;
            WriteLine(x);
            x++; 
            WriteLine(x);
        }
        
    }

    static void Exceptions()
    {
        WriteLine("Before parsing");
        Write("What is your age? ");
        string? input = ReadLine(); // or use "49" in a notebook
        try
        {
            int age = int.Parse(input);
            WriteLine($"You are {age} years old.");
        }
        //catch(Exception ex)
        //{
        //    Console.WriteLine($"{ex.GetType} throws {ex.Message}");
        //}
        catch(FormatException)
        {
            WriteLine("The age is not in the right format");
        }
        catch(OverflowException ex)
        {
            WriteLine($"{ex.GetType()}your number is too large");
        }
        
        WriteLine("After parsing");
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

    static int FizzBuzz(int amount)
    {
        for(int i=1;i<amount; i++)
        {
            int num = 0;
            if(i%3==0)
            {
                Write("Fizz");
                num++;
            }
            if(i%5==0)
            {
                Write("Buzz");
                num++;
            }
            if (num==0)
            {
                Write($"{i}");
            }

        }
        return 0;
    }

   
    static void TwoNumbers()
    {
        WriteLine("please enter two numbers 0-255");
        try
        {
            byte no1 = byte.Parse(ReadLine());
            WriteLine(no1);
        }
        catch (Exception e)
        {
            WriteLine($"{e.GetType()} is throwing {e.Message}");
        }
        {

        }

    }


    //static decimal CalculateTax( decimal amount, string twoLetterRegionCode)
    //    {
    //        decimal rate = 0.0M;
    //        switch (twoLetterRegionCode)
    //        {
    //            case "CH": // Switzerland
    //                rate = 0.08M;
    //                break;
    //            case "DK": // Denmark
    //            case "NO": // Norway
    //                rate = 0.25M;
    //                break;
    //            case "GB": // United Kingdom
    //            case "FR": // France
    //                rate = 0.2M;
    //                break;
    //            case "HU": // Hungary
    //                rate = 0.27M;
    //                break;
    //            case "OR": // Oregon
    //            case "AK": // Alaska
    //            case "MT": // Montana
    //                rate = 0.0M;                    
    //        break;
    //            case "ND": // North Dakota
    //            case "WI": // Wisconsin
    //            case "ME": // Maine
    //            case "VA": // Virginia
    //                rate = 0.05M;
    //                break;
    //            case "CA": // California
    //                rate = 0.0825M;
    //                break;
    //            default: // most US states
    //                rate = 0.06M;
    //                break;
    //        }
    //        return amount * rate;
    // }

    static double Add(double a, double b)
    {
        return a + b; // deliberate bug!
    }

    static void TraceFolder()
    {
        string logPath = Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.DesktopDirectory), "log.txt");
        Console.WriteLine($"Writing to: {logPath}");
        TextWriterTraceListener logFile = new(File.CreateText(logPath));
        Trace.Listeners.Add(logFile);
        // text writer is buffered, so this option calls
        // Flush() on all listeners after writing
        Trace.AutoFlush = true;
        Debug.WriteLine("Debug says, I am watching!");
        Trace.WriteLine("Trace says, I am watching!");
    }

}
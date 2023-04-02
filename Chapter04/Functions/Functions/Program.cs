using System.Numerics;
using static System.Console;
DoSomething();
//Multiply(9);
//TimesTable(9);


//RunFactorial();

for (int i = 1; i <= 30; i++)
{
    WriteLine($"FibFunctional = {FibFunctional(term: i)}");
    WriteLine($"FibImperative = {FibImperative(i)}");
}
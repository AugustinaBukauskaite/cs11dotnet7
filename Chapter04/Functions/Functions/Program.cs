using System.Diagnostics;
using Microsoft.Extensions.Configuration;
DoSomething();
//Multiply(9);
//TimesTable(9);


//RunFactorial();

//for (int i = 1; i <= 30; i++)
//{
//    WriteLine($"FibFunctional = {FibFunctional(term: i)}");
//    WriteLine($"FibImperative = {FibImperative(i)}");
//}

//Exceptions();
//MyChecked();
//FizzBuzz(100);

//TwoNumbers();

//double a = 4.5;
//double b = 2.5;
//double answer = Add(a, b);
//WriteLine($"{a} + {b} = {answer}");
//WriteLine("Press ENTER to end the app.");
//ReadLine(); // wait for user to press ENTER

//while (true)
//{
//    WriteLine("Hey, Hot Reload!");
//    await Task.Delay(2000);
//}


//TraceFolder();

Console.WriteLine("Reading from appsettings.json in {0}",
 arg0: Directory.GetCurrentDirectory());
ConfigurationBuilder builder = new();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json",
 optional: true, reloadOnChange: true);
IConfigurationRoot configuration = builder.Build();
TraceSwitch ts = new(
 displayName: "PacktSwitch",
 description: "This switch is set via a JSON config.");
configuration.GetSection("PacktSwitch").Bind(ts);
Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
Console.ReadLine();
﻿// a semicolon indicates the end of a statement
using System;
using static System.Console;
namespace Basics
{ // an open brace indicates the start of a block
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments.");
            foreach (string arg in args)
            {
                WriteLine(arg);
            }

            if (args.Length < 3)
            {
                WriteLine("You must specify two colors and cursor size, e.g.");
                WriteLine("dotnet run red yellow 50");
                return; // stop running
            }
            ForegroundColor = (ConsoleColor)Enum.Parse(
             enumType: typeof(ConsoleColor),
             value: args[0],
             ignoreCase: true);
            BackgroundColor = (ConsoleColor)Enum.Parse(
             enumType: typeof(ConsoleColor),
             value: args[1],
             ignoreCase: true);
            CursorSize = int.Parse(args[2]);
        }
    }
}


----
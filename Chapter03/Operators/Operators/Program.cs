// See https://aka.ms/new-console-template for more information
bool a = true;
bool b = false;
static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}

WriteLine();
WriteLine($"a & DoStuff() = {a && DoStuff()}");
WriteLine($"b & DoStuff() = {b && DoStuff()}");

using System;
using static System.Console;
class MyClass
{
    static void Main()
    {
        Int16[] mas = { 1, -1, 0, 2, 3, -4, 5, 4, -8, 7, 11 };
        WriteLine("Plus: ");
        foreach (Int16 i in mas)
        {
            if (i > 0)
            {
                Write($"{i} ");
            }
        }
        WriteLine();
        WriteLine("Minus: ");
        foreach (Int16 i in mas)
        {
            if (i < 0)
            {
                Write($"{i} ");
            }
        }
    }
}
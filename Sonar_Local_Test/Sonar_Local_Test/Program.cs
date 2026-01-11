using System;
using System.Collections.Generic;

public class BadExample
{
    // Poorly named method, too long, too many responsibilities
    public void DoStuff(int x, int y, string str)
    {
        // Unused variable
        int unusedVar = 42;

        // Magic numbers
        if (x == 123)
        {
            Console.WriteLine("X is 123");
        }
        else if (x == 456)
        {
            Console.WriteLine("X is 456");
        }
        else if (x == 789)
        {
            Console.WriteLine("X is 789");
        }

        // Deep nesting
        if (y > 0)
        {
            if (y < 100)
            {
                if (y % 2 == 0)
                {
                    Console.WriteLine("Y is even and small");
                }
                else
                {
                    Console.WriteLine("Y is odd and small");
                }
            }
            else
            {
                Console.WriteLine("Y is large");
            }
        }

        // Duplicate code
        Console.WriteLine("Hello " + str);
        Console.WriteLine("Hello " + str);

        // Swallowing exceptions
        try
        {
            int z = int.Parse(str);
            Console.WriteLine("Parsed: " + z);
        }
        catch (Exception)
        {
            // Do nothing
        }

        // Too many parameters, poor cohesion
        HelperMethod(x, y, str, "extra", 999, true, false);
    }

    // Poorly named helper, too many parameters
    private void HelperMethod(int a, int b, string c, string d, int e, bool f, bool g)
    {
        Console.WriteLine("Doing something with: " + a + b + c + d + e + f + g);
    }

    public static void Main(string[] args) { }
}
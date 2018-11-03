using System;

class Program
{
    static void Main()
    {
        sbyte i = sbyte.Parse(Console.ReadLine());
        for (i = 0; i < 100; i++)
        {
            Console.WriteLine($"The numbers of i are {i}");
        }
    }
}


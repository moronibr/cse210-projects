using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a list of numbers, type 0 when finished.");
        int sum = 0;
        int value = -1;

        while (value != 0)
        {
            value = int.Parse(Console.ReadLine());
            sum += value;

        }
        Console.WriteLine("The total is " + sum);
        Console.WriteLine("");

    }
}

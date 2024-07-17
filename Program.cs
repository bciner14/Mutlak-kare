using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the integers: ");
        string input = Console.ReadLine();
        List<int> numbers = input.Split(' ').Select(int.Parse).ToList();

        int differenceSum = 0;
        int squaredDifferenceSum = 0;

        foreach (int number in numbers)
        {
            if (number < 67)
            {
                differenceSum += (67 - number);
            }
            else
            {
                squaredDifferenceSum += (number - 67) * (number - 67);
            }
        }

        Console.WriteLine($"Difference Sum (for numbers < 67): {differenceSum}");
        Console.WriteLine($"Squared Difference Sum (for numbers >= 67): {squaredDifferenceSum}");
    }
}

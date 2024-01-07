using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Add a new number to the list.");
        Console.WriteLine("Enter zero to stop adding more numbers to the list.");

        while (true)
        {
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int inputNumber))
            {
                if (inputNumber == 0)
                {
                    break;
                }

                numbers.Add(inputNumber);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine("Numbers in the list:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        int sum = numbers.Sum();
        double average = numbers.Count > 0 ? (double)sum / numbers.Count : 0;
        int maxNumber = numbers.Count > 0 ? numbers.Max() : 0;

        Console.WriteLine($"Sum of numbers: {sum}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Maximum number: {maxNumber}");
    }
}

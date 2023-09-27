using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int inputNumber = -1;

        List<int> numberList = new List<int>();

        while (inputNumber != 0)
        {
            Console.Write("Enter Number: ");
            inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber != 0)
            {
                numberList.Add(inputNumber);
            }
        }

        int sum = 0;

        int largest = 0;

        foreach (int number in numberList)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }  
        }

        Console.WriteLine($"The sum is: {sum}");

        // I do not know how to make all decimals how for average.
        // Doing this -- Console.WriteLine($"The average is: {sum / numberList.Count}"); -- prints an integer.
        // Console.WriteLine($"The average is: {((float)sum) / numberList.Count}"); -- prints up to some decimals.

        // Remember is better to keep the exact values of something and approximate them when sending an output to screen.

        float average = ((float)sum) / numberList.Count;

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largest}");

    }
}
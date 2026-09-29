using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int myNum = -1;
        while (myNum != 0)
        {
            Console.Write("Enter a number (enter 0 to quit): ");

            string userNum = Console.ReadLine();
            myNum = int.Parse(userNum);

            if (myNum != 0)
            {
                numbers.Add(myNum);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"The max is: {max}");
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1;
        while (number != 0)
        { 
                Console.Write("Enter a number: ");
                string answer = Console.ReadLine();
                number = int.Parse(answer);
                numbers.Add(number);
        }
        Console.WriteLine(numbers.Count);
        int sum = 0;
        foreach (int userNumbers in numbers)
        {
            sum += userNumbers;
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");  


        int max = numbers[0];


        foreach (int userNumbers in numbers)
        {
            if (userNumbers > max)
            {
                max = userNumbers;
            }
        }

  
    }
}
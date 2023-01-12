using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());  
        int guess = -1;
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());


            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }      
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
             Console.WriteLine("Well done, you got it!!");            
            }
        }
    }
}
using System;
using System.Threading;
using System.Diagnostics;

namespace ActivityMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                choice = Prompts.GetChoice();
                switch (choice)
                {
                    case 1:
                        ReflectionActivity();
                        break;
                    case 2:
                        BreathingActivity();
                        break;
                    case 3:
                        EnumerationActivity();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 4);
        }

        static void ReflectionActivity()
        {
            Console.WriteLine("Welcome to the reflection activity.");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
            Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");

            Prompts.PauseWithSpinner(500);

            Console.Write("How many seconds do you want to spend on this activity? ");
            int duration = int.Parse(Console.ReadLine());

            string[] prompts = PromptsData.ReflectionPrompts;

            string[] questions = PromptsData.ReflectionQuestions;

            Prompts.ShowStartMessage("Reflection", "Reflect on the prompt and write down your thoughts.", duration);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Random rnd = new Random();

            while (stopwatch.Elapsed.TotalSeconds < duration)
            {
                string prompt = prompts[rnd.Next(prompts.Length)];
                Console.WriteLine(prompt);
                string reflection = Console.ReadLine();
                Console.WriteLine("You reflected: " + reflection);

                string question = questions[rnd.Next(questions.Length)];
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                Console.WriteLine("You answered: " + answer);
            }

            stopwatch.Stop();

            Prompts.ShowEndMessage("Reflection", duration);
            Prompts.PauseWithSpinner(800);
        }

       static void BreathingActivity()
        {
            Console.WriteLine("Welcome to the breathing activity.");
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly.");
            Console.WriteLine("Clear your mind and focus on your breathing.");

            int duration = Prompts.GetDuration();
            Prompts.PauseWithSpinner(500);

            int cycleCount = (duration - 10) / 20;
            int lastCycleDuration = (duration - 10) % 20;

            Console.WriteLine("Breathing in");
            Prompts.PauseWithDuration(4000);
            Console.WriteLine("Breathing out");
            Prompts.PauseWithDuration(6000);

            for (int i = 1; i <= cycleCount; i++)
            {
                Console.WriteLine("Breathing in");
                Prompts.PauseWithDuration(4000);
                Console.WriteLine("Breathing out");;
                Prompts.PauseWithDuration(6000);
            }

            if (lastCycleDuration >= 10)
            {
                Console.WriteLine("Breathing in");
                Prompts.PauseWithDuration(4000);
                Console.WriteLine("Breathing out");
                Prompts.PauseWithDuration(6000);
            }

                Prompts.ShowEndMessage("Breathing", duration);
                Prompts.PauseWithSpinner(800);
        }



        static void EnumerationActivity()
        {
            Console.WriteLine("Welcome to the enumeration activity.");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine("Clear your mind and focus on the prompt.");

            int duration = Prompts.GetDuration();
            Prompts.PauseWithSpinner(500);

            Prompts.ShowStartMessage("Enumeration", "Think of as many things as you can in response to the prompt...", duration);

            string[] prompts = PromptsData.prompts;

            Random rnd = new Random();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.Elapsed.TotalSeconds < duration)
            {
                string prompt = prompts[rnd.Next(prompts.Length)];
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Console.WriteLine("You listed: " + response);   
            }

            stopwatch.Stop();

            Prompts.ShowEndMessage("Enumeration", duration);
            Prompts.PauseWithSpinner(800);
        }
    }
}


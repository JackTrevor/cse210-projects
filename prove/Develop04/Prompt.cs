using System;
using System.Threading;

namespace ActivityMenu
{
    public class Prompts
    {
        public static int GetChoice()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Activity Menu:");
            Console.WriteLine("1. Reflection");
            Console.WriteLine("2. Breathing");
            Console.WriteLine("3. Enumeration");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter your choice (1-4): ");
            return int.Parse(Console.ReadLine());
        }

        public static int GetDuration()
        {
            Console.Write("Please enter the duration of the activity in seconds: ");
            return int.Parse(Console.ReadLine());
        }

        public static void ShowStartMessage(string activityName, string description, int duration)
        {
            Console.WriteLine("Starting {0} Activity", activityName);
            Console.WriteLine(description);
            Console.WriteLine("Duration: {0} seconds", duration);
        }
 

        public static void ShowEndMessage(string activityName, int duration)
        {
            Console.WriteLine("Good job! You completed the {0} Activity for {1} seconds.", activityName, duration);
        }

        private class PauseSpinner
        {
            public static void Pause(int milliseconds)
            {
                string[] spinners = new string[] { "/", "-", "\\", "|" };
                int spinnerIndex = 0;
                int countDown = 5;
                while (countDown > 0)
                {
                    Console.Write("\r{0} {1}", "Get Ready", spinners[spinnerIndex], countDown);
                    spinnerIndex = (spinnerIndex + 1) % spinners.Length;
                    countDown--;
                    Thread.Sleep(milliseconds);
                }
                Console.WriteLine();
            }
        }

        private class PauseCountdown
        {
            public static void Pause(int milliseconds)
            {
                int countdown = 5;
                while (countdown > 0)
                {
                    Console.Write("\r{0}...", countdown);
                    countdown--;
                    Thread.Sleep(milliseconds);
                }
                Console.Write("\r     ");
            }
        }

        private class PausePeriods
        {
            public static void Pause(int milliseconds)
            {
                int periods = 0;
                while (true)
                {
                    Console.Write("\r{0} ", new string('.', periods));
                    periods = (periods + 1) % 4;
                    if (Console.KeyAvailable)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine();
                            break;
                        }
                    }
                    Thread.Sleep(milliseconds);
                }
            }
        }

        private class PauseDuration
        {
            public static void Pause(int milliseconds)
            {
                int remainingTime = milliseconds;
                while (remainingTime > 0)
                {
                    int pauseTime = Math.Min(remainingTime, 1000);
                    Console.Write("\r{0:D2}:{1:D2}", remainingTime / 1000, (remainingTime / 10) % 100);
                    remainingTime -= pauseTime;
                    Thread.Sleep(pauseTime);
                }
                Console.Write("\r     ");
            }
        }

        public static void PauseWithSpinner(int milliseconds)
        {
            PauseSpinner.Pause(milliseconds);
        }

        public static void PauseWithCountdown(int milliseconds)
        {
            PauseCountdown.Pause(milliseconds);
        }

        public static void PauseWithPeriods(int milliseconds)
        {
            PausePeriods.Pause(milliseconds);
        }

        public static void PauseWithDuration(int milliseconds)
        {
            PauseDuration.Pause(milliseconds);
        }
    }
}


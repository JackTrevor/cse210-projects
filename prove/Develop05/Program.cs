using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    private static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("----------------");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("\nCreate new Goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");

        Console.Write("\nEnter the goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter a description for this goal: ");
        string goalName = Console.ReadLine();

        Console.Write("Enter the goal points: ");
        int goalPoints = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goals.Add(new SimpleGoal(goalName, goalPoints));
                Console.WriteLine("Simple Goal created successfully!");
                break;
            case "2":
                goals.Add(new EternalGoal(goalName, goalPoints));
                Console.WriteLine("Eternal Goal created successfully!");
                break;
            case "3":
                Console.Write("Enter the goal target count: ");
                int goalTargetCount = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(goalName, goalPoints, goalTargetCount));
                Console.WriteLine("Checklist Goal created successfully!");
                break;
            case "4":
                goals.Add(new NegativeGoal(goalName, goalPoints));
                Console.WriteLine("Negative Goal created successfully!");
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("\nList Goals:");
        Console.WriteLine("Progress -- Description of the goal -- (Kind) ");

        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal);
        }
    }

    static void SaveGoals()
    {
        Console.Write("\nEnter the filename to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetGoalType()},{goal.GetName()},{goal.GetPoints()},{goal.IsCompleted()}");
            }
        }

        Console.WriteLine($"Goals saved to {filename} successfully!");
    }

        static void LoadGoals()
    {
        Console.Write("\nEnter the filename to load from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine($"File {filename} does not exist!");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string goalType = parts[0];
                string goalName = parts[1];
                int goalPoints = int.Parse(parts[2]);
                bool goalIsCompleted = bool.Parse(parts[3]);

                switch (goalType)
                {
                    case "Simple":
                        goals.Add(new SimpleGoal(goalName, goalPoints) );
                        break;
                    case "Eternal":
                        goals.Add(new EternalGoal(goalName, goalPoints) );
                        break;
                    case "Checklist":
                        int goalTargetCount = int.Parse(parts[2]);
                        goals.Add(new ChecklistGoal(goalName, goalPoints, goalTargetCount) );
                        break;
                    case "Negative":
                        goals.Add(new NegativeGoal(goalName, goalPoints) );
                        break;
                    default:
                        Console.WriteLine($"Invalid goal type {goalType} found in {filename}!");
                        break;
                }
            }
        }

        Console.WriteLine($"Goals loaded from {filename} successfully!");
    }

    static void RecordEvent()
    {
        Console.WriteLine("\nRecord Event:");

        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events on!");
            return;
        }

        Console.WriteLine("Available Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }

        Console.Write("Enter the goal number to record progress on: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber < 1 || goalNumber > goals.Count)
        {
            Console.WriteLine("Invalid goal number. Please try again.");
            return;
        }

        Goal goal = goals[goalNumber - 1];
        goal.RecordEvent();
    }
}



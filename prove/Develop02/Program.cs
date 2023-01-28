using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        Journal currentJournal = new Journal();
        string start = "y";

        Prompt promptForUser = new Prompt();
        promptForUser._prompt.Add(promptForUser._prompt1);
        promptForUser._prompt.Add(promptForUser._prompt2);
        promptForUser._prompt.Add(promptForUser._prompt3);
        promptForUser._prompt.Add(promptForUser._prompt4);
        promptForUser._prompt.Add(promptForUser._prompt5);
        Console.WriteLine();
        Console.WriteLine("This is your Personal Journal!");
        Console.Write("Would you like to resume writting? Y/N: ");
        Console.ReadLine();

        if (start == "y")
        {
            int userSelection = 0;

            while (userSelection != 5)
            {
                Console.WriteLine("Please choose 1: ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                userSelection = int.Parse(Console.ReadLine());
                
                if (userSelection == 1)
                {
                    Entry currentEntry = new Entry();
                    DateTime theCurrentTime = DateTime.Now;
                    currentEntry._date = theCurrentTime.ToShortDateString();
                    currentEntry._promptQuestion = promptForUser.DisplayPrompt();
                    Console.WriteLine(currentEntry._promptQuestion);
                    currentEntry._userResponse = Console.ReadLine();
                    currentJournal._entries.Add(currentEntry);
                }
                else if (userSelection == 2)
                {
                    currentJournal.DisplayJournal();
                }
                else if (userSelection == 3)
                {
                    currentJournal = new Journal();
                    Console.Write("Which file would you like the open? ");
                    currentJournal._fileName = Console.ReadLine();
                    currentJournal.LoadFile();
                }
                else if (userSelection == 4)
                {
                    currentJournal.SaveFile();
                    Console.WriteLine("The file has been saved");
                }
            }
        }

        else
        {
            Console.WriteLine("See you again sometime");
            System.Environment.Exit(1);
        }
    }
}
using System;
using System.IO; 



public class HabbitProject : Project 
{
    
    protected int _numOfTimes;

 

    public HabbitProject()
    {
        _projectType = "Habbit Project";
        Console.Write("What is the name of your project? ");
        _projectName = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it? ");
        _projectDescription = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this project? ");
        _projectPoints = int.Parse(Console.ReadLine());
    }

    public HabbitProject (string projectName, string projectDescription, int projectPoints, int numOfTimes) : base(projectName, projectDescription, projectPoints)
    {
        _projectType = "Habbit Project";
        _numOfTimes = numOfTimes;
    }

    
    public int GetNumOfTimes()
    {
        return _numOfTimes;
    }

  

    public override int RecordEvent()
    {
        _numOfTimes++;
        while(true)
        {
            _isComplete = true;

            Console.WriteLine($"Congratulations, you have completed this project {_numOfTimes} times!");
            Console.WriteLine($"Congratulations you have earned {_projectPoints} points!");
            Console.WriteLine();
            
            return _projectPoints;
        }
    }
}


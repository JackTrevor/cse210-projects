using System;
using System.IO; 



public class OneTimeProject : Project 
{

   
    public OneTimeProject()
    {
        _projectType = "One Time Project";
        Console.Write("What is the name of your project? Ex: Enroll? Ex: Buy?  Ex: Schedule? Ex: Weight?");
        _projectName = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it? ");
        _projectDescription = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this project? ");
        _projectPoints = int.Parse(Console.ReadLine());
    }

    public OneTimeProject (string projectName, string projectDescription, int projectPoints, bool complete) : base(projectName, projectDescription, projectPoints)
    {
        _projectType = "One Time";
        _isComplete = complete;
    }

    
    
    public override int RecordEvent()
    {

        

        _isComplete = true;

        Console.WriteLine($"Congratulations you have earned {_projectPoints} points!");
        Console.WriteLine();
        
        return _projectPoints;
    }
}


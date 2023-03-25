using System;
using System.IO; 



public class OverAchivingProject : Project 
{

 
    public OverAchivingProject()
    {
        _projectType = "Improvement Goal";
        Console.Write("What is the name of your goal? ");
        _projectName = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of something you want to improve on? ");
        _projectDescription = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _projectPoints = int.Parse(Console.ReadLine());
    }

    public OverAchivingProject (string projectName, string projectDescription, int projectPoints, bool complete) : base(projectName, projectDescription, projectPoints)
    {
        _projectType = "Overachieving Goal";
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


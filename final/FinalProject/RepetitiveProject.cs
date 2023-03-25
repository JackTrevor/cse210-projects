using System;
using System.IO; 



public class RepetitiveProject : Project 
{
    
    protected int _numOfTimesRequired;
    protected int _complete;
    protected int _numOfTimesCompleted;
    protected int _projectBonus;    

  
    public RepetitiveProject()
    {
        _projectType = "Repetitive Project";
        Console.Write("What is the name of the activity that you will repeat? ");
        _projectName = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it? ");
        _projectDescription = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the amount of points associated with this project? ");
        _projectPoints = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("How many times do you need to repeat this activity? ");
        _numOfTimesRequired = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _projectBonus = int.Parse(Console.ReadLine());
    }

    public RepetitiveProject (string projectName, string projectDescription, int projectPoints, int projectBonus, int complete, int numOfTimesRequired) : base(projectName, projectDescription, projectPoints)
    {
        _projectType = "Repetitive Project";
        _numOfTimesRequired = numOfTimesRequired;
        _numOfTimesCompleted = complete;
        _projectBonus = projectBonus;
    }

    
    public int GetNumOfTimesRequired()
    {
        return _numOfTimesRequired;
    }

    public int GetComplete()
    {
        return _numOfTimesCompleted;
    }

    public int GetProjectBonus()
    {
        return _projectBonus;
    }

  

    public override int RecordEvent()
    {
        _numOfTimesCompleted++;

       
        if (_numOfTimesCompleted >= _numOfTimesRequired){
            _isComplete = true;
            
        }

        Console.WriteLine($"Congratulations, you have completed this project {_numOfTimesCompleted} times!");
        Console.WriteLine();
        Console.WriteLine($"You have earned {_projectPoints}");
        Console.WriteLine();
        return _projectPoints;
    }
}


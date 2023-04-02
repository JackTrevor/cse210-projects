using System;
using System.IO; 



public class Project 
{
    

    protected string _projectType;
    protected string _projectName;
    protected string _projectDescription;
    protected int _projectPoints;
    protected bool _isComplete = false;

    
    public Project()
    {
    }

    
    public Project (string projectName, string projectDescription, int projectPoints)
    {   
        _projectName = projectName;
        _projectDescription = projectDescription;
        _projectPoints = projectPoints;

    }

 
    public string GetProjectType()
    {
        return _projectType;        
    }

    public string GetProjectName()
    {
        return _projectName;
    }

    public string GetProjectDescription()
    {
        return _projectDescription;
    }

    public int GetProjectPoints()
    {
        return _projectPoints;
    }

    public bool GetIsComplete(){
        return _isComplete;
    }

    
    public char GetIsCompleteChar(){
        if (!_isComplete)
            return ' ';
        else
            return 'X';
    }

    public void SetProjectType(string projectType)
    {
        _projectType = projectType;
    }

    public void SetProjectName(string projectName)
    {
        _projectName = projectName;
    }

    public void SetProjectDescription(string projectDescription)
    {
        _projectName = projectDescription;
    }

    public void SetProjectPoints(int projectPoints)
    {
        _projectPoints = projectPoints;
    }

    
    public virtual int RecordEvent()
    {
        return _projectPoints;
    }

}



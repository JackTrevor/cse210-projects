using System;
using System.Collections.Generic;
using System.IO; 



public class SaveAndLoad
{
    
    protected string _fileName;

   


  
    public void SaveFile(List<Project> projects, int totalPoints)
    {
        Console.Write("What would you like to name this file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName, append:false))
        {
            outputFile.WriteLine($"{totalPoints}");

            foreach (Project project in projects)
            {
                
                if (project is OneTimeProject)
                {
                    outputFile.WriteLine($"{project.GetProjectType()}:{project.GetProjectName()}|{project.GetProjectDescription()}|{project.GetProjectPoints()}|{project.GetIsComplete().ToString().ToLower()}");
                }

                else if (project is HabbitProject)
                {
                    HabbitProject habbitProject = (HabbitProject)project;
                    outputFile.WriteLine($"{project.GetProjectType()}:{project.GetProjectName()}|{project.GetProjectDescription()}|{project.GetProjectPoints()}|{habbitProject.GetNumOfTimes()}");
                }

                else if (project is RepetitiveProject)
                {
                    RepetitiveProject repetitiveProject = (RepetitiveProject)project;
                    outputFile.WriteLine($"{project.GetProjectType()}:{project.GetProjectName()}|{project.GetProjectDescription()}|{project.GetProjectPoints()}|{repetitiveProject.GetProjectBonus()}|{repetitiveProject.GetComplete()}|{repetitiveProject.GetNumOfTimesRequired()}");
                }

                else if (project is OverAchivingProject)
                {
                    outputFile.WriteLine($"{project.GetProjectType()}:{project.GetProjectName()}|{project.GetProjectDescription()}|{project.GetProjectPoints()}|{project.GetIsComplete().ToString().ToLower()}");
                }
            }
        }
    }

    public void LoadFile(List<Project> projectss, out int totalPoints)
    {
        Console.Write("Which file would you like to open? ");
        _fileName = Console.ReadLine();

        string[] projects = System.IO.File.ReadAllLines(_fileName);

        totalPoints = int.Parse(projects[0]);

        foreach (string project in projects)
        {
            string[] parts = project.Split(":"); 
            if (parts[0] == "One Time") 
            {
                string[] lines = parts[1].Split("|"); 
                OneTimeProject onetime = new OneTimeProject(lines[0], lines[1], int.Parse(lines[2]), bool.Parse(lines[3]));
                projectss.Add(onetime);
            }

            else if (parts[0] == "Habbit Project") 
            {
                string[] lines = parts[1].Split("|"); 
                HabbitProject longtime = new HabbitProject(lines[0], lines[1], int.Parse(lines[2]), int.Parse(lines[3]));
                projectss.Add(longtime);
            }

            else if (parts[0] == "Achiving Project") 
            {
                string[] lines = parts[1].Split("|"); 
                RepetitiveProject checklist = new RepetitiveProject(lines[0], lines[1], int.Parse(lines[2]), int.Parse(lines[3]), int.Parse(lines[4]), int.Parse(lines[5]));
                projectss.Add(checklist);
            }

            else if (parts[0] == "OverAchiving Project") 
            {
                string[] lines = parts[1].Split("|"); 
                OverAchivingProject improve = new OverAchivingProject(lines[0], lines[1], int.Parse(lines[2]), bool.Parse(lines[3]));
                projectss.Add(improve);
            }
        }
    }
}


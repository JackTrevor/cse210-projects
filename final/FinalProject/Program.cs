using System;
using System.Collections.Generic;
using System.IO; 


class Program
{
    static void Main(string[] args)
    {
                
        List<Project> projects = new List<Project>();
        int totalPoints = 0;

      
        while(true)
        {

            Console.WriteLine("Welcome to your Work Out Project Journal");
            Console.WriteLine();
            Console.WriteLine("Create a Project and Record the events of that project to keep track of how you are doing and what needs to be done");
            Console.WriteLine("You can create a project to Enroll in the gym, or to schedule a time to work out everyday. You can also keep track of how much you weight.");


            Console.WriteLine("Choices:");
            Console.WriteLine("1. Create a new project");
            Console.WriteLine("2. Display the project");
            Console.WriteLine("3. Save Project");
            Console.WriteLine("4. Load Project");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

          
            Console.Write("Select a choice from the menu: ");
            int userSelect = int.Parse(Console.ReadLine());

            
            if (userSelect == 1)
            {
                
                Console.WriteLine("Select the project type");
                Console.WriteLine("1. One time Project");
                Console.WriteLine("2. Habbit Project");
                Console.WriteLine("3. Repetitive Project");
                Console.WriteLine("4. Overachiving Project");
                Console.WriteLine();

                
                Console.WriteLine("What type of Project do you want? ");
                int userSelectProject = int.Parse(Console.ReadLine()); 
                Console.WriteLine();

                if (userSelectProject == 1) 
                {
                    
                    OneTimeProject p1 = new OneTimeProject();
                    projects.Add(p1);

                }

                else if (userSelectProject == 2) 
                {
                    
                    HabbitProject p2 = new HabbitProject();
                    projects.Add(p2);
                }
                else if (userSelectProject == 3) 
                {
                    
                    RepetitiveProject p3 = new RepetitiveProject();
                    projects.Add(p3);
                }

                else if (userSelectProject == 4) 
                {
                    
                    OverAchivingProject p4 = new OverAchivingProject();
                    projects.Add(p4);
                }
            }

            else if (userSelect == 2) 
            {
                foreach (Project project in projects)
                {
                    if (project is RepetitiveProject repetitiveProject)
                    {
                    Console.WriteLine($"[{project.GetIsCompleteChar()}] {project.GetProjectName()} ({project.GetProjectDescription()}) -- Currently Completed: {repetitiveProject.GetComplete()}/{repetitiveProject.GetNumOfTimesRequired()}");
                    }
                    else
                    {
                        Console.WriteLine($"[{project.GetIsCompleteChar()}] {project.GetProjectName()} ({project.GetProjectDescription()})");
                    }
                }
            }

            
            else if (userSelect == 3)
            {
            
                SaveAndLoad save = new SaveAndLoad();
                save.SaveFile(projects, totalPoints);
                Console.WriteLine("The file has been saved");
                Console.WriteLine();
            }

           
            else if (userSelect == 4)
            {
              
                SaveAndLoad load = new SaveAndLoad();
                load.LoadFile(projects, out totalPoints);
            }

            
            else if (userSelect == 5)
            {
                List<Project> temp = new List<Project>(); 
                int counter = 1; 
                foreach (Project project in projects)
                {
                    if (!project.GetIsComplete()){
                        temp.Add(project);
                        Console.WriteLine($"{counter}) {project.GetProjectName()}");
                        counter++;
                    }
                }
                Console.WriteLine("Which project did you accomplish? ");
                int index = int.Parse(Console.ReadLine());
                totalPoints += temp[index - 1].RecordEvent();

               
                Console.WriteLine($"You now have {totalPoints} points");
            }

            
            else if (userSelect == 6)
            {
                Console.WriteLine();
                Console.WriteLine("Come Back soon to Record more Events");
                Console.WriteLine();
                Environment.Exit(0);
            }

          
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input please try again.");
            }
        }
    }
}



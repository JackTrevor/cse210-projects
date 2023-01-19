using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Supervisor";
        job1._company = "G&L Construction";
        job1._startYear = 2003;
        job1._endYear = 2007;

        Job job2 = new Job();
        job2._jobTitle = "Supervisor";
        job2._company = "Idea Idiomas";
        job2._startYear = 2010;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "Jackson Fonseca";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
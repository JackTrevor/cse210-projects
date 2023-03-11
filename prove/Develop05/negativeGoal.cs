
using System;
using System.Collections.Generic;
using System.IO;

class NegativeGoal : Goal
{
public NegativeGoal(string name, int points) : base(name, -points)
{
}

 public override string GetGoalType()
    {
        return "Negative";
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You have engaged in the negative habit: {GetName()} ({GetPoints()} points deducted)");
        MarkAsCompleted();
    }
}

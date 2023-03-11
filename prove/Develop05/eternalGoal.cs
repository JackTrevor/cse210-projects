using System;
using System.Collections.Generic;
using System.IO;

// Eternal goal that is never complete, but gains points each time it's recorded
    class EternalGoal : Goal
    {
        private int count;

        public EternalGoal(string name, int points) : base(name, points)
        {
            this.count = 0;
        }

        public override string GetGoalType()
        {
            return "Eternal";
        }

        public override string GetProgress()
        {
            return $"Completed {count} times";
        }

        public override void RecordEvent()
        {
            Console.WriteLine($"You have recorded progress on the goal: {GetName()} (+{GetPoints()} points)");
            count++;
        }
    }

    